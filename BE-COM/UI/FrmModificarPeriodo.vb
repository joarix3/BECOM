Imports EntitiesLayer
Imports BLL
Public Class FrmModificarPeriodo
    Dim formAnterior As Form
    Dim objPeriodo As Periodo

    Public Sub New(pformAnterior As Form, pobjPeriodo As Periodo)
        objPeriodo = pobjPeriodo
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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim nombre As String = txtNombrePeriodo.Text
        Dim dia As Integer = txtDia.Text
        Dim mes As Integer = txtMes.Text
        Dim estado As String = cmbEstado.SelectedItem
        Dim idPeriodo As Integer = objPeriodo.Id

        If estado = "Activa" Then
            estado = "1"
        Else
            estado = "0"
        End If

        gestorPeriodo.modificarPeriodo(idPeriodo, nombre, dia, mes, estado)
        gestorPeriodo.guardarCambios()
    End Sub

    Private Sub FrmModificarPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombrePeriodo.Text = objPeriodo.Nombre
        txtDia.Text = objPeriodo.Dia
        txtMes.Text = objPeriodo.Mes

    End Sub
End Class