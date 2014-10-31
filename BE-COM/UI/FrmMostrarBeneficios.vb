Imports EntitiesLayer

Public Class FrmMostrarBeneficios

    Public Sub New()
        InitializeComponent()
        cargarDataGridBeneficios()
    End Sub

    Public Sub cargarDataGridBeneficios()
        dtgBeneficios.DataSource = Nothing
        dtgBeneficios.DataSource = gestorBeneficio.consultarBeneficioPorEstado
        configuracionDataGritView()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        FrmRegistrarBeneficio.Show()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Try
            Dim nombre As String = txtBuscar.Text
            dtgBeneficios.DataSource = Nothing
            dtgBeneficios.DataSource = (gestorBeneficio.consultarBeneficioPorNombre(nombre))
            configuracionDataGritView()
        Catch
            dtgBeneficios.DataSource = Nothing
            lblBeneficiosNoRegistrados.Visible = True
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim objBeneficio As Beneficio
        If (dtgBeneficios.SelectedRows.Count = 1) Then
            Try
                objBeneficio = gestorBeneficio.ObtenerBeneficioPorId(dtgBeneficios.CurrentRow.Cells(0).Value)
                Dim p As New FrmModificarBeneficio(Me, objBeneficio)
                p.Show()
                If p.DialogResult() = Windows.Forms.DialogResult.OK Then
                    cargarDataGridBeneficios()
                End If
                MessageBox.Show("debe de seleccionar una fila")
            Catch ex As Exception
                '' Por hacer
            End Try
        Else
        End If
    End Sub

    Private Sub configuracionDataGritView()
        dtgBeneficios.Columns(0).Visible = False
        dtgBeneficios.Columns(1).HeaderText = "Nombre"
        dtgBeneficios.Columns(2).HeaderText = "Porcentaje"
        dtgBeneficios.Columns(3).HeaderText = "Descripción"
        dtgBeneficios.Columns(3).FillWeight = 200
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim objBeneficio As Beneficio
        Try
            If (dtgBeneficios.SelectedRows.Count = 1) Then
                objBeneficio = gestorBeneficio.ObtenerBeneficioPorId(dtgBeneficios.CurrentRow.Cells(0).Value)
                gestorBeneficio.eliminarBeneficio(objBeneficio.Id)
                gestorBeneficio.guardarCambios()
                cargarDataGridBeneficios()
            Else
                MessageBox.Show("debe de seleccionar una fila")
            End If
        Catch ex As Exception
            '' Por hacer
        End Try
    End Sub
End Class