Imports EntitiesLayer
Public Class PopEliminarCurso
    Dim idCurso As Integer
    Dim texto As String
    Dim frm As Form

    Public Sub New(ptexto As String, pidCurso As Integer)
        texto = ptexto
        idCurso = pidCurso
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


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Public Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub
End Class