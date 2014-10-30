Public Class PopAgregado

    Dim texto As String

    Public Sub New(ptexto As String)
        texto = ptexto
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

   
    Private Sub PorAgrgado_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub PopAgregado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTexto.Text = texto
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class