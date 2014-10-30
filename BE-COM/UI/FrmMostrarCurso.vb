'Clase para mostrar los roles de la aplicación.
Imports EntitiesLayer

Public Class FrmMostrarCurso
    Dim formAnterior As Form

    Public Sub New(pformAnterior As Form)
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub
    Public Sub New()
        InitializeComponent()

    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmMostrarCursos_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub FrmMostrarCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarMostrarCurso()
    End Sub

    Protected Friend Sub cargarMostrarCurso()
        dtgCursos.DataSource = Nothing
        dtgCursos.DataSource = gestorCurso.obtenerCursos
        dtgCursos.Refresh()
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim frmRegistrarCurso As Form = New FrmRegistrarCurso(Me)
        frmRegistrarCurso.Show()
        Me.Hide()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If (dtgCursos.SelectedRows.Count = 1) Then

            Dim id As Integer = Convert.ToInt32(dtgCursos.CurrentRow.Cells(0).Value)
            Dim p As New FrmModificarCurso(Me, id)
            p.Show()
        Else
            Dim mensageError As String = "¡Debe de seleccionar una fila!"
            Dim popError As PopError = New PopError(mensageError)
            popError.Show()

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As Integer = Convert.ToInt32(dtgCursos.CurrentRow.Cells(0).Value)
        Dim mensage As String = "¿Desea eliminar el curso?"
        If (dtgCursos.SelectedRows.Count = 1) Then
            Dim popUpAlerta As PopEliminarCurso = New PopEliminarCurso(mensage, id)
            If popUpAlerta.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                gestorCurso.eliminarCurso(id)
                gestorCurso.guardarCambios()
                cargarMostrarCurso()
                Dim popAgregado As PopAgregado = New PopAgregado("¡El curso se elimino correctamente!")
                popAgregado.Show()
            End If
        Else
            Dim mensageError As String = "¡Debe de seleccionar una fila!"
            Dim popError As PopError = New PopError(mensageError)
            popError.Show()


        End If
    End Sub
End Class