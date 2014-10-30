'Clase para mostrar los roles de la aplicación.
'revisado por daniel maietta
'Excelente revisión.
Imports BLL.GestorUsuarios
Imports System.Data.SqlClient
Imports DAL

Public Class FrmMostrarRoles
    Dim formAnterior As Form

    Public Sub New(pformAnterior As Form)
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub

    Private Sub FrmMostrarRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFiltroBusqueda.SelectedIndex = 0
        mostrarRoles()
    End Sub

    Private Sub FrmMostrarRoles_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
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
        dtgMostrarRoles.Columns(0).Visible = False
        dtgMostrarRoles.Columns(1).HeaderText = "Nombre"
        dtgMostrarRoles.Columns(2).HeaderText = "Descripción"
        dtgMostrarRoles.Columns(3).Visible = False
    End Sub

    Private Sub mostrarRoles()
        If gestorUsuario.obtenerRoles() Is Nothing = False Then
            lblRolesNoRegistrados.Visible = False
            dtgMostrarRoles.DataSource = gestorUsuario.obtenerRoles()
            configurarColumnasDGV()
        Else
            dtgMostrarRoles.DataSource = Nothing
            lblRolesNoRegistrados.Visible = True
        End If
    End Sub

    Private Sub mostrarRolesInactivos()
        If gestorUsuario.obtenerRolesInactivos() Is Nothing = False Then
            lblRolesNoRegistrados.Visible = False
            dtgMostrarRoles.DataSource = gestorUsuario.obtenerRolesInactivos()
            configurarColumnasDGV()
        Else
            dtgMostrarRoles.DataSource = Nothing
            lblRolesNoRegistrados.Visible = True
        End If
    End Sub

    Private Sub mostrarRolesPorNombre()

        If gestorUsuario.buscarRolPorNombre(txtBuscar.Text) Is Nothing = False Then
            lblRolesNoRegistrados.Visible = False
            dtgMostrarRoles.DataSource = gestorUsuario.buscarRolPorNombre(txtBuscar.Text)
            configurarColumnasDGV()
        Else
            dtgMostrarRoles.DataSource = Nothing
            lblRolesNoRegistrados.Visible = True
        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim idRol As Integer = dtgMostrarRoles.CurrentRow.Cells(0).Value.ToString()
        Dim frmModificarRol As FrmModificarRol = New FrmModificarRol(Me, idRol)
        frmModificarRol.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idRolSeleccionado As Integer = dtgMostrarRoles.CurrentRow.Cells(0).Value.ToString()
        gestorUsuario.eliminarRol(idRolSeleccionado)
    End Sub

    Private Sub chkUsuariosInactivos_CheckedChanged(sender As Object, e As EventArgs) Handles chkUsuariosInactivos.CheckedChanged
        If chkUsuariosInactivos.Checked = True Then
            mostrarRolesInactivos()
        Else
            mostrarRoles()
        End If
    End Sub
End Class