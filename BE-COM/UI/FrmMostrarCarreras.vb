'Clase para mostrar los roles de la aplicación.
Imports EntitiesLayer

Public Class FrmMostrarCarreras
    Dim formAnterior As Form
    Public Sub New(pformAnterior As Form)
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmMostrarCarreras_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub FrmMostrarCarreras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dtgCarreras.DataSource = gestorCarrera.obtenerCarreras()
        cargarMostrarCarrera()
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim frmRegistrarCarrera As Form = New FrmRegistrarCarrera(Me)
        frmRegistrarCarrera.Show()
        Me.Hide()
    End Sub
    Protected Friend Sub cargarMostrarCarrera()
        dtgCarreras.DataSource = Nothing
        dtgCarreras.DataSource = gestorCarrera.obtenerCarreras()
        dtgCarreras.Refresh()
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        If (dtgCarreras.SelectedRows.Count = 1) Then

            Dim id As Integer = Convert.ToInt32(dtgCarreras.CurrentRow.Cells(0).Value)
            Dim p As New FrmModificarCarrera(Me, id)
            p.Show()
        Else
            Dim mensageError As String = "¡Debe de seleccionar una fila!"
            Dim popError As PopError = New PopError(mensageError)
            popError.Show()

        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim mensage As String = "¿Desea eliminar la carrera?"
        If (dtgCarreras.SelectedRows.Count = 1) Then

            Dim id As Integer = Convert.ToInt32(dtgCarreras.CurrentRow.Cells(0).Value)
            Dim popUpAlerta As PopEliminarCurso = New PopEliminarCurso(mensage, id)
            If popUpAlerta.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                gestorCarrera.eliminarCarrera(id)
                gestorCarrera.guardarCambios()
                cargarMostrarCarrera()
                Dim popAgregado As PopAgregado = New PopAgregado("¡La carrera se eliminó correctamente!")
                popAgregado.Show()
            End If
           
        Else
            Dim mensageError As String = "¡Debe de seleccionar una fila!"
            Dim popError As PopError = New PopError(mensageError)
            popError.Show()


        End If
    End Sub

    Private Sub btnDetalles_Click(sender As Object, e As EventArgs) Handles btnDetalles.Click
        If (dtgCarreras.SelectedRows.Count = 1) Then

<<<<<<< HEAD
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

=======
            Dim id As Integer = Convert.ToInt32(dtgCarreras.CurrentRow.Cells(0).Value)
            Dim p As New FrmInformacionCarrera(Me, id)
            p.Show()
        Else
            Dim mensageError As String = "¡Debe de seleccionar una fila!"
            Dim popError As PopError = New PopError(mensageError)
            popError.Show()

        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If String.IsNullOrEmpty(txtBuscar.Text) = True Then
            lblCarrerasNoRegistrados.Visible = False
            cargarMostrarCarrera()
        Else
            mostrarCarreraPorNombre()

        End If
    End Sub
    Private Sub mostrarCarreraPorNombre()
        If gestorCarrera.buscarCarreraPorNombre(txtBuscar.Text) Is Nothing = False Then
            lblCarrerasNoRegistrados.Visible = False
            dtgCarreras.DataSource = gestorCarrera.buscarCarreraPorNombre(txtBuscar.Text)
        Else
            dtgCarreras.DataSource = Nothing
            lblCarrerasNoRegistrados.Visible = True
        End If
    End Sub

    Private Sub btnAsociar_Click(sender As Object, e As EventArgs) Handles btnAsociar.Click
        If (dtgCarreras.SelectedRows.Count = 1) Then

            Dim id As Integer = Convert.ToInt32(dtgCarreras.CurrentRow.Cells(0).Value)
            Dim p As New FrmAsociarCursoCarrera(Me, id)
            p.Show()
        Else
            Dim mensageError As String = "¡Debe de seleccionar una fila!"
            Dim popError As PopError = New PopError(mensageError)
            popError.Show()

        End If
    End Sub

    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click
        If (dtgCarreras.SelectedRows.Count = 1) Then

            Dim id As Integer = Convert.ToInt32(dtgCarreras.CurrentRow.Cells(0).Value)
            Dim p As New FrmMostrarCursosPorCarrera(Me, id)
            p.Show()
        Else
            Dim mensageError As String = "¡Debe de seleccionar una fila!"
            Dim popError As PopError = New PopError(mensageError)
            popError.Show()

        End If
>>>>>>> New
    End Sub
End Class