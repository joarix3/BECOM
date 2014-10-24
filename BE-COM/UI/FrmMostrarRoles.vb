'Clase para mostrar los roles de la aplicación.
'revisado por daniel maietta
'Excelente revisión.
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
        cmbFiltroBusqueda.SelectedIndex = 0
        txtBuscar.Focus()
        mostrarRoles()
        configurarColumnasDGV()

    End Sub

    Private Sub gridMostrarAlumnos_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMostrarRoles.CellMouseEnter
        dgvMostrarRoles.RowsDefaultCellStyle.SelectionBackColor = Color.Purple
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

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        If String.IsNullOrEmpty(txtBuscar.Text) = True Then
            lblRolesNoRegistrados.Visible = False
            mostrarRoles()
            configurarColumnasDGV()
        Else
            Select Case cmbFiltroBusqueda.SelectedIndex
                Case 0
                    mostrarRolesPorNombre()
            End Select
        End If
    End Sub

    Private Sub configurarColumnasDGV()
        dgvMostrarRoles.Columns(0).Visible = False
        dgvMostrarRoles.Columns(1).HeaderText = "Nombre"
        dgvMostrarRoles.Columns(2).HeaderText = "Descripción"
    End Sub

    Private Sub mostrarRoles()
        dgvMostrarRoles.DataSource = gestorUsuario.obtenerRoles()
    End Sub

    Private Sub mostrarRolesPorNombre()

        If gestorUsuario.buscarRolPorNombre(txtBuscar.Text) Is Nothing = False Then
            lblRolesNoRegistrados.Visible = False
            dgvMostrarRoles.DataSource = gestorUsuario.buscarRolPorNombre(txtBuscar.Text)
            configurarColumnasDGV()
        Else
            dgvMostrarRoles.DataSource = Nothing
            lblRolesNoRegistrados.Visible = True
        End If

    End Sub
End Class