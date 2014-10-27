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
        dgvMostrarRoles.Columns(3).Visible = False
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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim idRol As Integer = dgvMostrarRoles.CurrentRow.Cells(0).Value.ToString()
        gestorUsuario.eliminarRol(idRol)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        PNoEliminar.Visible = True
        'dgvMostrarRoles.Rows(dgvMostrarRoles.CurrentCell.RowIndex).Visible = Falsed
        dgvMostrarRoles.CurrentCell = Nothing
        '(dgvMostrarRoles.SelectedRows.Item)
        'dgvMostrarRoles.SelectedRows(0).Visible = False
    End Sub

    Private Sub eliminarUsuario()
        Dim idRolSeleccionado As Integer = dgvMostrarRoles.CurrentRow.Cells(0).Value.ToString()
        Dim conexion As SqlConnection = DBAccess.GetConnection()
        conexion.Open()
        Dim PaEliminarRol As SqlCommand = New SqlCommand("PaEliminarRol", conexion)
        PaEliminarRol.CommandType = CommandType.StoredProcedure

        Dim idRol As SqlParameter = PaEliminarRol.Parameters.Add("@IdRol", SqlDbType.Int)
        idRol.Direction = ParameterDirection.Input

        idRol.Value = idRolSeleccionado

        Dim lectorId As SqlDataReader = PaEliminarRol.ExecuteReader
    End Sub
End Class