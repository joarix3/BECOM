Imports EntitiesLayer

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
        mostrarPeriodos()
        dtgPeriodos.Columns(0).Visible = False
        dtgPeriodos.Columns(1).HeaderText = "Nombre"
        dtgPeriodos.Columns(3).HeaderText = "Meses"
        dtgPeriodos.Columns(2).HeaderText = "Dias"
        dtgPeriodos.Columns(4).Visible = False


    End Sub

    Private Sub mostrarPeriodos()
        If gestorPeriodo.obtenerPeriodos Is Nothing = False Then
            lblRolesNoRegistrados.Visible = False
            dtgPeriodos.DataSource = gestorPeriodo.obtenerPeriodos
        Else
            dtgPeriodos.DataSource = Nothing
            lblRolesNoRegistrados.Visible = True
        End If

    End Sub

    Private Sub mostrarPeriodosInactivos()
        If gestorPeriodo.obtenerPeriodos Is Nothing = False Then
            lblRolesNoRegistrados.Visible = False
            dtgPeriodos.DataSource = gestorPeriodo.obtenerPeriodosInaactivos()
        Else
            dtgPeriodos.DataSource = Nothing
            lblRolesNoRegistrados.Visible = True
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p As Form = New FrmRegistrarPeriodo(Me)
        p.Show()
        Me.Hide()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        If (dtgPeriodos.SelectedRows.Count = 1) Then

            Dim id As Integer = Convert.ToInt32(dtgPeriodos.CurrentRow.Cells(0).Value)
            Dim p As New FrmModificarPeriodo(Me, id)
            p.Show()
            Me.Hide()
        Else
            MessageBox.Show("debe de seleccionar una fila")
        End If




    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim idPeriodo As Integer = dtgPeriodos.CurrentRow.Cells(0).Value.ToString()
        gestorPeriodo.eliminarPeriodo(idPeriodo)
    End Sub

    Private Sub chkPeriodosInactivos_CheckedChanged(sender As Object, e As EventArgs) Handles chkPeriodosInactivos.CheckedChanged
        If chkPeriodosInactivos.Checked = True Then
            mostrarPeriodosInactivos()
        Else
            mostrarPeriodos()
        End If
    End Sub
End Class