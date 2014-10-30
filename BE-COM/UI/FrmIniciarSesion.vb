Public Class FrmIniciarSesion

    Private Sub FrmIniciaSesion_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub pnlIniciarSesion_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        If validarEspaciosBlanco() = False Then
            lblValidacion.Text = "*Existen espacios en blanco por favor ingresarlos antes de continuar"
            lblValidacion.Visible = True
        Else
            'validarDatosUsuario()
        End If
    End Sub

    Private Function validarEspaciosBlanco() As Boolean
        Dim permitido As Boolean
        If String.IsNullOrEmpty(txtCorreo.Text) = True Or String.IsNullOrEmpty(txtContrasena.Text) = True Then
            permitido = False
        Else
            permitido = True
        End If

        Return permitido
    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class