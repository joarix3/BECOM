Public Class FrmMostrarTiposDeBeca
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmRegistrarTiposBeca As Form = New FrmRegistrarTipoBeca(Me)
        frmRegistrarTiposBeca.Show()
    End Sub


End Class