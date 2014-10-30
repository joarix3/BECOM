Public Class FrmAcademico
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

    ''Private Sub btnCarreras_Click(sender As Object, e As EventArgs) Handles btnCarreras.Click
    '    Dim frmMostrarCarreras As Form = New FrmMostrarCarreras(Me)
    '    frmMostrarCarreras.Show()
    'End Sub
End Class