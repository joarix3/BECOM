Imports EntitiesLayer
Imports BLL
Public Class FrmModificarRol
    Dim formAnterior As Form
    Dim rolAModificar As Rol
    Dim idPermisos As New List(Of Integer)
    Dim listaPermisosRol As New List(Of Integer)


    Public Sub New(pformAnterior As Form, pidRol As Integer)
        formAnterior = pformAnterior
        InitializeComponent()
        rolAModificar = gestorUsuario.buscarRolPorId(pidRol)
        obtenerPermisosRol(pidRol)
    End Sub

    Private Sub FrmModificarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each permiso As Permiso In gestorUsuario.obtenerPermisos()
            LchkPermisos.Items.Add(permiso.Nombre)
            idPermisos.Add(permiso.Id)
        Next
        cargarDatos()
    End Sub

    Private Sub obtenerPermisosRol(pidRol As Integer)
        For Each permiso As Permiso In gestorUsuario.obtenerPermisosPorRol(pidRol)
            listaPermisosRol.Add(permiso.Id)
        Next
    End Sub

    Private Sub cargarDatos()
        txtNombre.Text = rolAModificar.Nombre
        rctDescripcion.Text = rolAModificar.Descripcion
        Select Case rolAModificar.Estado
            Case 1
                rbtActivo.Checked = True
            Case 2
                rbtInactivo.Checked = True
        End Select
        cargarPermisos()

    End Sub

    Private Sub cargarPermisos()
        For Each permisoDeRol As Integer In listaPermisosRol
            For i As Integer = 0 To idPermisos.Count - 1
                If idPermisos.Item(i) = permisoDeRol Then
                    LchkPermisos.SetItemChecked(i, True)
                End If
            Next
        Next
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim permisosSeleccionados As List(Of Integer)
        Dim nombre As String = txtNombre.Text
        Dim descripcion As String = rctDescripcion.Text
<<<<<<< HEAD
        Dim estado As Integer = obtenerEstadoRol()
        validarCampoFormulario()
=======

        'validarCampoFormulario()
>>>>>>> New
        permisosSeleccionados = obtenerPermisosSeleccionados()


        gestorUsuario.modificarRol(rolAModificar.Id, nombre, descripcion, estado, permisosSeleccionados)
        gestorUsuario.guardarCambios()

    End Sub

<<<<<<< HEAD
    Public Function obtenerEstadoRol()
        Dim estado As Integer

        If rbtActivo.Checked = True Then
            estado = 1
        Else
            estado = 2
        End If

        Return estado
    End Function

    Private Sub validarCampoFormulario()
        For Each validacion As Label In Me.pnFormulario.Controls.OfType(Of Label)()
            If IsNumeric(validacion.Tag) = True Then
                If validacion.Image.Equals(campoIncorrecto) Then
                    MsgBox("Existen campos incorrectos")
                End If
            End If
        Next
    End Sub
=======
    'Private Sub validarCampoFormulario()
    '    For Each validacion As Label In Me.pnFormulario.Controls.OfType(Of Label)()
    '        If IsNumeric(validacion.Tag) = True Then
    '            If validacion.Image.Equals(campoIncorrecto) Then
    '                MsgBox("Existen campos incorrectos")
    '            End If
    '        End If
    '    Next
    'End Sub
>>>>>>> New

    Private Function obtenerPermisosSeleccionados()
        Dim listaPermisosSeleccionados As New List(Of Integer)
        For Each permisoSeleccionado As Integer In LchkPermisos.CheckedIndices
            listaPermisosSeleccionados.Add(idPermisos.Item(permisoSeleccionado))
        Next
        Return listaPermisosSeleccionados
    End Function

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave

        If objValidaciones.validarCamposTexto(txtNombre) = True Then
            lblNombreV.Image = campoCorrecto
            lblNombreV.Visible = True
        Else
            lblNombreV.Image = campoIncorrecto
            lblNombreV.Visible = True
        End If
    End Sub

    Private Sub rctDescripcion_Leave(sender As Object, e As EventArgs) Handles rctDescripcion.Leave
        If objValidaciones.validarCamposTexto(rctDescripcion) = True Then
            lblDescripcionV.Image = campoCorrecto
            lblDescripcionV.Visible = True
        Else
            lblDescripcionV.Image = campoIncorrecto
            lblDescripcionV.Visible = True
        End If
    End Sub
End Class