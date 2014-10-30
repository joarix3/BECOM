'Clase para mostrar los roles de la aplicación.
'revisado por daniel maietta
'Excelente revisión.
Imports BLL.GestorUsuarios
Imports System.Data.SqlClient
Imports DAL

Public Class FrmMostrarUsuarios
    Dim formAnterior As Form

    Public Sub New(pformAnterior As Form)
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub

    Private Sub FrmMostrarUsuarios_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub FrmMostrarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarUsuarios()
        cmbRoles.DataSource = gestorUsuario.obtenerRoles.ToList()
        cmbRoles.DisplayMember = "Nombre"
        cmbRoles.ValueMember = "Id"
        cmbFiltroBusqueda.SelectedIndex = 0
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim frmRegistrarUsuario As FrmRegistrarUsuario = New FrmRegistrarUsuario(Me)
        frmRegistrarUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        If String.IsNullOrEmpty(txtBuscar.Text) = True Then
            lblUsuariosNoRegistrados.Visible = False
            mostrarUsuarios()
            configurarColumnasDGV()
        Else
            Select Case cmbFiltroBusqueda.SelectedIndex
                Case 0
                    mostrarUsuariosPorNombre()
                Case 1
                    mostrarUsuariosPorCedula()
                Case 2
                    mostrarUsuariosPorRol()
            End Select
        End If
    End Sub

    Private Sub configurarColumnasDGV()
        dtgMostrarRoles.Columns(0).Visible = False
        dtgMostrarRoles.Columns(1).HeaderText = "Nombre"
        dtgMostrarRoles.Columns(2).Visible = False
        dtgMostrarRoles.Columns(3).Visible = False
        dtgMostrarRoles.Columns(4).HeaderText = "Cédula"
        dtgMostrarRoles.Columns(5).HeaderText = "Rol"
        dtgMostrarRoles.Columns(6).HeaderText = "Correo"
        dtgMostrarRoles.Columns(7).Visible = False
        dtgMostrarRoles.Columns(8).Visible = False
        dtgMostrarRoles.Columns(9).HeaderText = "Teléfono"
        dtgMostrarRoles.Columns(10).Visible = False
        dtgMostrarRoles.Columns(11).Visible = False
        dtgMostrarRoles.Columns(12).Visible = False
        dtgMostrarRoles.Columns(13).Visible = False
    End Sub

    Private Sub mostrarUsuarios()

        If gestorUsuario.obtenerUsuarios() Is Nothing = False Then
            lblUsuariosNoRegistrados.Visible = False
            dtgMostrarRoles.DataSource = gestorUsuario.obtenerUsuarios()
            configurarColumnasDGV()
        Else
            dtgMostrarRoles.DataSource = Nothing
            lblUsuariosNoRegistrados.Visible = True
        End If

    End Sub

    Private Sub mostrarUsuariosInactivos()
        If gestorUsuario.obtenerUsuariosInactivos() Is Nothing = False Then
            lblUsuariosNoRegistrados.Visible = False
            dtgMostrarRoles.DataSource = gestorUsuario.obtenerUsuariosInactivos()
            configurarColumnasDGV()
        Else
            dtgMostrarRoles.DataSource = Nothing
            lblUsuariosNoRegistrados.Visible = True
        End If
    End Sub

    Private Sub mostrarUsuariosPorNombre()

        If gestorUsuario.buscarUsuarioPorNombre(txtBuscar.Text) Is Nothing = False Then
            lblUsuariosNoRegistrados.Visible = False
            dtgMostrarRoles.DataSource = gestorUsuario.buscarUsuarioPorNombre(txtBuscar.Text)
            configurarColumnasDGV()
        Else
            dtgMostrarRoles.DataSource = Nothing
            lblUsuariosNoRegistrados.Visible = True
        End If

    End Sub

    Private Sub mostrarUsuariosPorRol()

        If gestorUsuario.buscarUsuariosPorRol(cmbRoles.SelectedValue) Is Nothing = False Then
            lblUsuariosNoRegistrados.Visible = False
            dtgMostrarRoles.DataSource = gestorUsuario.buscarUsuariosPorRol(cmbRoles.SelectedValue)
            configurarColumnasDGV()
        Else
            dtgMostrarRoles.DataSource = Nothing
            lblUsuariosNoRegistrados.Visible = True
        End If

    End Sub

    Private Sub mostrarUsuariosPorCedula()

        If gestorUsuario.buscarUsuarioPorCedula(txtBuscar.Text) Is Nothing = False Then
            lblUsuariosNoRegistrados.Visible = False
            dtgMostrarRoles.DataSource = gestorUsuario.buscarUsuarioPorCedula(txtBuscar.Text)
            configurarColumnasDGV()
        Else
            dtgMostrarRoles.DataSource = Nothing
            lblUsuariosNoRegistrados.Visible = True
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
            mostrarUsuariosInactivos()
        Else
            mostrarUsuarios()
        End If
    End Sub

    Private Sub cmbFiltroBusqueda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroBusqueda.SelectedIndexChanged
        Select Case cmbFiltroBusqueda.SelectedIndex
            Case 0

                cmbRoles.Visible = False
                lblBuscar.Visible = True
                lblBuscar.Text = "Buscar:"
                txtBuscar.Visible = True
                mostrarUsuariosPorNombre()

            Case 1
                cmbRoles.Visible = False
                lblBuscar.Text = "Buscar:"
                lblBuscar.Visible = True
                txtBuscar.Visible = True
                mostrarUsuariosPorCedula()

            Case 2
                lblBuscar.Visible = True
                txtBuscar.Visible = False
                cmbRoles.Visible = True
                lblBuscar.Text = "Rol:"
                mostrarUsuariosPorRol()
        End Select
    End Sub

    Private Sub cmbRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoles.SelectedIndexChanged
        If cmbRoles.Visible = True Then
            mostrarUsuariosPorRol()
        Else

        End If
    End Sub

    Private Sub btnInformacionUsuario_Click(sender As Object, e As EventArgs) Handles btnInformacionUsuario.Click

    End Sub
End Class