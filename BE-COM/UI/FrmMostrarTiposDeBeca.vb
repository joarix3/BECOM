Public Class FrmMostrarTiposDeBeca
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

    Private Sub FrmMostrarTiposDeBeca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBuscar.Focus()
        mostrarTipoBecas()
        configurarColumnasDGV()

    End Sub

    Private Sub mostrarTipoBecas()
        dtgMostrarTipoBeca.DataSource = gestorTipoBeca.obtenerTipoBecas()
    End Sub

    Private Sub configurarColumnasDGV()
        dtgMostrarTipoBeca.Columns(0).Visible = False
        dtgMostrarTipoBeca.Columns(4).Visible = False
        dtgMostrarTipoBeca.Columns(1).HeaderText = "Nombre"
        dtgMostrarTipoBeca.Columns(2).HeaderText = "Descripción"
        dtgMostrarTipoBeca.Columns(3).HeaderText = "Estado"

        dtgMostrarTipoBeca.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dtgMostrarTipoBeca.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dtgMostrarTipoBeca.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If String.IsNullOrEmpty(txtBuscar.Text) = True Then
            lblRolesNoRegistrados.Visible = False
            mostrarTipoBecas()
            configurarColumnasDGV()
        Else
            mostrarTiposDeBecaPorNombre()
        End If
    End Sub
    Private Sub mostrarTiposDeBecaPorNombre()

        If gestorTipoBeca.buscarTipoBecaPorNombre(txtBuscar.Text) Is Nothing = False Then
            lblRolesNoRegistrados.Visible = False
            dtgMostrarTipoBeca.DataSource = gestorTipoBeca.buscarTipoBecaPorNombre(txtBuscar.Text)
            configurarColumnasDGV()
        Else
            dtgMostrarTipoBeca.DataSource = Nothing
            lblRolesNoRegistrados.Visible = True
        End If

    End Sub
End Class