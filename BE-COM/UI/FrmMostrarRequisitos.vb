Imports EntitiesLayer

Public Class FrmMostrarRequisitos

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        cargarDataGridRequisitos()
        configuracionDataGritView()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub cargarDataGridRequisitos()
        dtgRequisitos.DataSource = Nothing
        dtgRequisitos.DataSource = gestorRequisito.consultarRequisitoPorEstado
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim objRequisito As Requisito

        If (dtgRequisitos.SelectedRows.Count = 1) Then

            Dim id As Integer = Convert.ToInt32(dtgRequisitos.CurrentRow.Cells(0).Value)
            objRequisito = gestorRequisito.ObtenerRequisitoPorId(id)
            Dim p As New FrmModificarRequisito(Me, objRequisito)
            p.Show()
            Me.Hide()
        Else
            MessageBox.Show("debe de seleccionar una fila")
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        FrmRegistrarRequisito.Show()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim nombre As String = txtBuscar.Text
            dtgRequisitos.DataSource = Nothing
            dtgRequisitos.DataSource = (gestorRequisito.consultarRequisitoPorNombre(nombre))
            configuracionDataGritView()
        Catch
            dtgRequisitos.DataSource = Nothing
        End Try
    End Sub

    Private Sub configuracionDataGritView()
        dtgRequisitos.Columns(0).Visible = False
        dtgRequisitos.Columns(1).HeaderText = "Nombre"
        dtgRequisitos.Columns(2).HeaderText = "Descripción"
        dtgRequisitos.Columns(2).FillWeight = 200
    End Sub

End Class