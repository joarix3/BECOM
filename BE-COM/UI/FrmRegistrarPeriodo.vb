Imports EntitiesLayer
Imports BLL
Public Class FrmRegistrarPeriodo
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
        Dim nombre As String = txtNombrePeriodo.Text
        Dim dia As Integer = txtDia.Text
        Dim mes As Integer = txtMes.Text

        gestorPeriodo.agregarPeriodo(nombre, dia, mes)
        gestorPeriodo.guardarCambios()
    End Sub


    Private Sub txtMes_Leave(sender As Object, e As EventArgs) Handles txtMes.Leave
        If String.IsNullOrEmpty(txtMes.Text) = True Then
            txtMes.Text = 0
        End If
    End Sub

    Private Sub txtDia_Leave(sender As Object, e As EventArgs) Handles txtDia.Leave
        If String.IsNullOrEmpty(txtDia.Text) = True Then
            txtDia.Text = 0
        End If
    End Sub

    Private Sub FrmRegistrarPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMes.Text = 0
        txtDia.Text = 0
    End Sub

    Private Sub txtMes_Enter(sender As Object, e As EventArgs) Handles txtMes.Enter
        If String.IsNullOrEmpty(txtMes.Text) = False Then
            txtMes.Text = ""
        End If
    End Sub

    Private Sub txtDia_Enter(sender As Object, e As EventArgs) Handles txtDia.Enter
        If String.IsNullOrEmpty(txtDia.Text) = False Then
            txtDia.Text = ""
        End If
    End Sub
End Class