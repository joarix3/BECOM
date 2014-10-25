Imports EntitiesLayer
Imports BLL
Public Class FrmRegistrarTiposDeBeca
    Dim formAnterior As Form

    Public Sub New(pformAnterior As Form)
        formAnterior = pformAnterior
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim nombre As String = txtNombreTipoBeca.Text
        Dim descripcion As String = rctDescripcion.Text
        Dim idPeriodo As String = "1" 'cmbNombrePeriodo.SelectedItem

        objGestorTipoBeca.agregarTipoBeca(nombre, descripcion, idPeriodo)
        objGestorTipoBeca.guardarCambios()
    End Sub
End Class