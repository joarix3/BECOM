'Clase para mostrar los roles de la aplicación.
'revisado por daniel maietta
Public Class FrmMostrarRoles
    Dim formAnterior As Form

    Public Sub New(pformAnterior As Form)
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmMostrarRoles_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub FrmMostrarRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub gridMostrarAlumnos_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles gridMostrarAlumnos.CellMouseEnter
        gridMostrarAlumnos.RowsDefaultCellStyle.SelectionBackColor = Color.Purple
    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim frmRegistrarRol As FrmRegistrarRol = New FrmRegistrarRol(Me)
        frmRegistrarRol.Show()
        Me.Hide()
    End Sub
End Class