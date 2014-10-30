Imports EntitiesLayer

Public Class FrmConfigurarParametros

    Dim formAnterior As Form
    Public Sub New(pformAnterior As Form)
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmConfigurarParametros_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub
End Class