'Clase para mostrar los roles de la aplicación.
Imports EntitiesLayer
Imports System.Collections

Public Class FrmAsociarCursoCarrera
    Dim formAnterior As Form
    Dim idCarrera As Integer
    Dim listaCursosBaseDatos As New List(Of Curso)
    Dim listaCursosAgregados As New List(Of Curso)
    Dim curso As Curso
    Public Sub New(pformAnterior As Form, pidCarrera As Integer)
        InitializeComponent()
        formAnterior = pformAnterior
        idCarrera = pidCarrera
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmMostrarCarreras_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub FrmAsociarCursosCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dtgCarreras.DataSource = gestorCarrera.obtenerCursosUnSeleccionados
        cargarCursos()
        lstCursos.SelectedIndex = -1
        Dim objCarrera As Carrera = gestorCarrera.ObtenerCarreraPorId(idCarrera)
        Dim nombre As String = objCarrera.Nombre
        lblNombreCarrera.Text = nombre
    End Sub

    Private Sub cargarCursos()
        listaCursosBaseDatos = gestorCarrera.obtenerCursosUnSeleccionados(idCarrera)
        lstCursos.DataSource = listaCursosBaseDatos
        lstCursos.DisplayMember = "Nombre"
        lstCursos.ValueMember = "Id"

    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs)
        Dim frmRegistrarCarrera As Form = New FrmRegistrarCarrera(Me)
        frmRegistrarCarrera.Show()
    End Sub

    Private Sub lstCursos_Click(sender As Object, e As EventArgs) Handles lstCursos.Click
        'MessageBox.Show(lstCursos.SelectedItem.Nombre)
        'MessageBox.Show(lstCursos.SelectedItem.Id.ToString())
        Dim sdsd As Integer = lstCursos.SelectedIndex
        If (lstCursos.SelectedItem IsNot Nothing) Then
            Dim indiceCurso As Integer = listaCursosBaseDatos.IndexOf(lstCursos.SelectedItem)
            Dim idCurso As Integer = lstCursos.SelectedValue.ToString()
            Dim nombre As String = lstCursos.SelectedItem.Nombre
            curso = New Curso(idCurso, nombre)
            listaCursosAgregados.Add(curso)

            listaCursosBaseDatos.RemoveAt(indiceCurso)
            lstCursos.DataSource = Nothing
            lstCursos.DataSource = listaCursosBaseDatos
            lstCursos.DisplayMember = "Nombre"
            lstCursos.ValueMember = "Id"

            lstCursosAgregar.DataSource = Nothing
            lstCursosAgregar.DataSource = listaCursosAgregados
            lstCursosAgregar.DisplayMember = "Nombre"
            lstCursosAgregar.ValueMember = "Id"
            lstCursos.SelectedIndex = -1
            lstCursosAgregar.SelectedIndex = -1
        End If
    End Sub

    Private Sub lstCursosAgregar_Click(sender As Object, e As EventArgs) Handles lstCursosAgregar.Click
        'MessageBox.Show(lstCursosAgregar.SelectedItem.Nombre)
        'MessageBox.Show(lstCursosAgregar.SelectedItem.Id.ToString())
        If (lstCursosAgregar.SelectedItem IsNot Nothing) Then
            Dim indiceCurso As Integer = listaCursosAgregados.IndexOf(lstCursosAgregar.SelectedItem)
            Dim idCurso As Integer = lstCursosAgregar.SelectedValue.ToString()
            Dim nombre As String = lstCursosAgregar.SelectedItem.Nombre
            curso = New Curso(idCurso, nombre)
            listaCursosBaseDatos.Add(curso)

            listaCursosAgregados.RemoveAt(indiceCurso)
            lstCursosAgregar.DataSource = Nothing
            lstCursosAgregar.DataSource = listaCursosAgregados
            lstCursosAgregar.DisplayMember = "Nombre"
            lstCursosAgregar.ValueMember = "Id"

            lstCursos.DataSource = Nothing
            lstCursos.DataSource = listaCursosBaseDatos
            lstCursos.DisplayMember = "Nombre"
            lstCursos.ValueMember = "Id"
            lstCursos.SelectedIndex = -1
            lstCursosAgregar.SelectedIndex = -1
        End If
    End Sub

    Private Sub btnAsociar_Click(sender As Object, e As EventArgs) Handles btnAsociar.Click
        For Each i As Curso In listaCursosAgregados
            gestorCarrera.asociarCursosCarrera(idCarrera, i.Id)
        Next
    End Sub

End Class