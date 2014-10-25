Public Class FrmMostrarPeriodos
    Dim formAnterior As Form


    Public Sub New(pformAnterior As Form)
        formAnterior = pformAnterior
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub FrmMostrarPeriodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgPeriodos.DataSource = objGestorPeriodo.obtenerPeriodos
        dtgPeriodos.Columns(0).Visible = False
        dtgPeriodos.Columns(4).Visible = False

        dtgPeriodos.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dtgPeriodos.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dtgPeriodos.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        dtgPeriodos.Columns(1).HeaderText = "Nombre"
        dtgPeriodos.Columns(2).HeaderText = "Dias"
        dtgPeriodos.Columns(3).HeaderText = "Meses"
        

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p As New FrmRegistrarPeriodo(Me)
        p.Show()

    End Sub
End Class