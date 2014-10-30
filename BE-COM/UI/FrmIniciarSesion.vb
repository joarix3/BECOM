Imports EntitiesLayer
Public Class FrmIniciarSesion

    Private Sub FrmIniciaSesion_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub pnlIniciarSesion_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        PopRecuperarContrasenna.Show()
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
    End Sub
End Class