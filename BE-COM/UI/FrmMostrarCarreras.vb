'Clase para mostrar los roles de la aplicación.
Imports EntitiesLayer

Public Class FrmMostrarCarreras
    Dim formAnterior As Form
    Public Sub New(pformAnterior As Form)
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmMostrarCarreras_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub FrmMostrarCarreras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgCarreras.DataSource = gestorCarrera.obtenerCarreras()

    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim frmRegistrarCarrera As Form = New FrmRegistrarCarrera(Me)
        frmRegistrarCarrera.Show()
        Me.Hide()
    End Sub


    Private Sub FrmMostrarCarreras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class