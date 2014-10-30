Imports EntitiesLayer
Public Class PopRecuperarContrasenna
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub PopRecuperarContrasenna_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    ''' <summary>
    ''' En el boton se llama gestor de usuarios para la recuperacion de la contrasenna
    ''' cuando se crea un correo se le llama al metodo de recuperar contrasenna, y lo almacena 
    ''' despues se le llama enviarCorreo, este envia el correo para recuperar la contrasenna al usuario por medio del correo digitado
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim correoEle As String = txtCorreo.Text
        Try
            Dim correo As Correo = gestorUsuario.recuperarContra(correoEle) 'recupera la contrasenna del usuario
            gestorUsuario.enviarCorreo(correoEle, correo.Contra) 'envia el correo electronico
            Me.Hide()

        Catch ex As Exception

        End Try
  
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub
End Class