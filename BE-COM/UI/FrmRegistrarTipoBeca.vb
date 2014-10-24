Public Class FrmRegistrarTipoBeca

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

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim nombre As String = txtNombre.Text
        Dim descripion As String = rctDescripcion.Text
        Dim periodo As string = 


        gestorTipoBeca.agregarTipoBeca()
    End Sub
End Class