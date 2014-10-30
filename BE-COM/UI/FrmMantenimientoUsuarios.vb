Public Class FrmMantenimientoUsuarios
    Dim formAnterior As Form

    Public Sub New(pformAnterior As Form)
        formAnterior = pformAnterior
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FrmMantenimientoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fechaActual As DateTime = DateTime.Now()
    End Sub

    Private Sub FrmMantenimientoUsuarios_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub lblMinimizar_MouseHover(sender As Object, e As EventArgs)
        BackColor = Color.Gainsboro
    End Sub

    Private Sub lblMinimizar_MouseLeave(sender As Object, e As EventArgs)
        BackColor = Color.White
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim frmMostrarUsuarios As FrmMostrarUsuarios = New FrmMostrarUsuarios(Me)
        frmMostrarUsuarios.Show()
        Me.Hide()
    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        Dim frmMostrarMostrarRoles As FrmMostrarRoles = New FrmMostrarRoles(Me)
        frmMostrarMostrarRoles.Show()
        Me.Hide()
    End Sub
End Class
