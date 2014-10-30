Imports EntitiesLayer
Imports BLL
Public Class FrmRegistrarRol
    Dim formAnterior As Form
    Dim idPermisos As New List(Of Integer)

    Public Sub New(pformAnterior As Form)
        formAnterior = pformAnterior
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FrmRegistrarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each permiso As Permiso In gestorUsuario.obtenerPermisos()
            LchkPermisos.Items.Add(permiso.Nombre)
            idPermisos.Add(permiso.Id)
        Next

    End Sub

    Private Sub FrmRegistrarRol_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
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

        If validarEspaciosBlanco() = True Then
            If validarCamposFormulario() = True Then
                registrarRol()
            Else
                MsgBox("Existen errores.")
            End If
        Else
            MsgBox("Existen errores.")
        End If

<<<<<<< HEAD

=======

        validarCampoFormulario()
        permisosSeleccionados = obtenerPermisosSeleccionados()



        'validarCampoFormulario()
        permisosSeleccionados = obtenerPermisosSeleccionados()        

        gestorUsuario.agregarRol(nombre, descripcion, permisosSeleccionados)
        gestorUsuario.guardarCambios()
>>>>>>> New

    End Sub

    Private Function validarEspaciosBlanco() As Boolean
        Dim permitido = False

        For Each textBox As TextBox In Me.pnFormulario.Controls.OfType(Of TextBox)()
            If String.IsNullOrEmpty(textBox.Text) Then
                lblEspaciosEnBlanco.Visible = True
                permitido = False
            Else
                lblEspaciosEnBlanco.Visible = False
                permitido = True
            End If
        Next
        Return permitido
    End Function

    Private Function validarCamposFormulario() As Boolean
        Dim listaCampos As New List(Of Boolean)
        Dim permitido As Boolean

        For Each validacion As Label In Me.pnFormulario.Controls.OfType(Of Label)()
            If IsNumeric(validacion.Tag) = True Then
                If validacion.Visible = True Then
                    If validacion.Image.Equals(campoIncorrecto) Then
                        listaCampos.Add(False)
                    Else
                        listaCampos.Add(True)
                    End If
                End If
            End If
        Next

        permitido = corroborarDatos(listaCampos)

        Return permitido
    End Function

    Private Function corroborarDatos(plistaCampos As List(Of Boolean))
        Dim datosCorrectos As Boolean
        For Each permiso As Boolean In plistaCampos
            If (permiso.Equals(False)) Then
                datosCorrectos = False
                Exit For
            Else
                datosCorrectos = True
            End If
        Next

        Return datosCorrectos

    End Function

    Private Sub registrarRol()
        Dim permisosSeleccionados As List(Of Integer)
        Dim nombre As String = txtNombre.Text.ToString()
        Dim descripcion As String = rctDescripcion.Text.ToString()

        permisosSeleccionados = obtenerPermisosSeleccionados()

        gestorUsuario.agregarRol(nombre, descripcion, permisosSeleccionados)
        gestorUsuario.guardarCambios()

        PopAgregado.Show()
        Me.Close()

    End Sub

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