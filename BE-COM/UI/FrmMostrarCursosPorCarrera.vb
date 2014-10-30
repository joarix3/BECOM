'Clase para mostrar los roles de la aplicación.
Imports EntitiesLayer

Public Class FrmMostrarCursosPorCarrera
    Dim formAnterior As Form
    Dim idCarrera As Integer
    Public Sub New(pformAnterior As Form, pidCarrera As Integer)
        InitializeComponent()
        formAnterior = pformAnterior
        idCarrera = pidCarrera
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmMostrarCursosPorCarrera_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub FrmMostrarCursosPorCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dtgCarreras.DataSource = gestorCarrera.obtenerCarreras()
        cargarMostrarCursosCarrera()
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs)
        Dim frmRegistrarCarrera As Form = New FrmRegistrarCarrera(Me)
        frmRegistrarCarrera.Show()
        Me.Hide()
    End Sub
    Protected Friend Sub cargarMostrarCursosCarrera()
        Dim objCarrera As Carrera = gestorCarrera.ObtenerCarreraPorId(idCarrera)
        Dim nombre As String = objCarrera.Nombre
        lblNombreCarrera.Text = nombre
        dtgCursos.DataSource = Nothing
        dtgCursos.DataSource = gestorCarrera.obtenerCursosByCarrera(idCarrera)
        dtgCursos.Refresh()
    End Sub


    'Private Sub btnAsociar_Click(sender As Object, e As EventArgs) Handles btnAsociar.Click
    '    If (dtgCarreras.SelectedRows.Count = 1) Then

    '        Dim id As Integer = Convert.ToInt32(dtgCarreras.CurrentRow.Cells(0).Value)
    '        Dim p As New FrmAsociarCursoCarrera(Me, id)
    '        p.Show()
    '    Else
    '        Dim mensageError As String = "¡Debe de seleccionar una fila!"
    '        Dim popError As PopError = New PopError(mensageError)
    '        popError.Show()

    '    End If
    'End Sub
End Class