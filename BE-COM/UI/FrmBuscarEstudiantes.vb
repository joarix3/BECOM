Public Class FrmBuscarEstudiantes
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
        mostrarEstudiantes()
        configurarColumnasDGV()

    End Sub

    Private Sub mostrarEstudiantes()
        dtgMostrarEstudiantes.DataSource = gestorUsuarios.obtenerTipoBecas()
    End Sub

    Private Sub configurarColumnasDGV()
        dtgMostrarEstudiantes.Columns(0).Visible = False
        dtgMostrarEstudiantes.Columns(4).Visible = False
        dtgMostrarEstudiantes.Columns(1).HeaderText = "Nombre"
        dtgMostrarEstudiantes.Columns(2).HeaderText = "Descripción"
        dtgMostrarEstudiantes.Columns(3).HeaderText = "Estado"

        dtgMostrarEstudiantes.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dtgMostrarEstudiantes.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dtgMostrarEstudiantes.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If String.IsNullOrEmpty(txtBuscar.Text) = True Then
            lblRolesNoRegistrados.Visible = False
            mostrarEstudiantes()
            configurarColumnasDGV()
        Else
            mostrarTiposDeBecaPorNombre()
        End If
    End Sub
    Private Sub mostrarTiposDeBecaPorNombre()

        If gestorUsuarios.buscarTipoBecaPorNombre(txtBuscar.Text) Is Nothing = False Then
            lblRolesNoRegistrados.Visible = False
            dtgMostrarEstudiantes.DataSource = gestorUsuarios.buscarTipoBecaPorNombre(txtBuscar.Text)
            configurarColumnasDGV()
        Else
            dtgMostrarEstudiantes.DataSource = Nothing
            lblRolesNoRegistrados.Visible = True
        End If

    End Sub
End Class