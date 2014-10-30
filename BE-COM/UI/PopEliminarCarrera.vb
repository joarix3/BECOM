Imports EntitiesLayer
Public Class PopEliminarCarrera
    Dim idCurso As Integer
    Dim texto As String

    Public Sub New(ptexto As String, pidCurso As Integer)
        texto = ptexto
        idCurso = pidCurso
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub PopEliminarCarrera_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub PopEliminarCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTexto.Text = texto
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim mensage As String = "¡La carrera se eliminó correctamente!"

        gestorCurso.eliminarCurso(idCurso)
        gestorCurso.guardarCambios()


        Dim popAgregado As PopAgregado = New PopAgregado(mensage)
        popAgregado.Show()
        Me.Close()
    End Sub
End Class