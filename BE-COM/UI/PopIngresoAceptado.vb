Public Class PopIngresoAceptado

    Private Sub PorIngresoAceptado_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub


    Private Sub PopIngresoAceptado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class