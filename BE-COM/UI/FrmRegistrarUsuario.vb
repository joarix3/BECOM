Public Class FrmRegistrarUsuario

    Private Sub FrmAgregarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub FrmAgregarUsuario_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        PopAgregado.Show()
    End Sub


    Private Sub ptrFoto_Click(sender As Object, e As EventArgs) Handles ptrFoto.Click
        oflImagen.ShowDialog()
        If oflImagen.FileName > "" Then
            ptrFoto.ImageLocation = oflImagen.FileName
        End If
    End Sub


    Private Sub btnMenu_Click(sender As Object, e As EventArgs)
        PopMenu.Show()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PopAgregado.Show()

    End Sub
End Class