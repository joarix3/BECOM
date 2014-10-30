Imports EntitiesLayer
Imports System.Text
Public Class FrmRegistrarUsuario

    Dim formAnterior As Form

    Public Sub New(pformAnterior As Form)
        InitializeComponent()
        formAnterior = pformAnterior
        rbtnMasculino.Checked = True
    End Sub

    Private Sub FrmAgregarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbRol.DataSource = gestorUsuario.obtenerRoles.ToList()
        cmbRol.DisplayMember = "Nombre"
        cmbRol.ValueMember = "Id"

    End Sub
    Private Sub FrmAgregarUsuario_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
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

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        validarEspaciosBlanco()
        registrarUsuario()
    End Sub

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

    Private Sub txtCedula_Leave(sender As Object, e As EventArgs) Handles txtCedula.Leave

        If txtCedula.Text.Length < 9 Then
            lblCedulaV.Image = campoIncorrecto
            lblCedulaV.Visible = True
        Else
            If objValidaciones.validarCamposNumericos(txtCedula) = True Then
                lblCedulaV.Image = campoCorrecto
                lblCedulaV.Visible = True
            Else
                lblCedulaV.Image = campoIncorrecto
                lblCedulaV.Visible = True
            End If
        End If
    End Sub

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        If objValidaciones.validarCamposTexto(txtNombre) = True Then
            lblNombreV.Image = campoCorrecto
            lblNombreV.Visible = True
        Else
            lblNombreV.Image = campoIncorrecto
            lblNombreV.Visible = True
        End If
    End Sub

    Private Sub txtPrimerApellido_Leave(sender As Object, e As EventArgs) Handles txtPrimerApellido.Leave
        If objValidaciones.validarCamposTexto(txtPrimerApellido) = True Then
            lblPrimerAV.Image = campoCorrecto
            lblPrimerAV.Visible = True
        Else
            lblPrimerAV.Image = campoIncorrecto
            lblPrimerAV.Visible = True
        End If
    End Sub

    Private Sub txtSegundoApellido_Leave(sender As Object, e As EventArgs) Handles txtSegundoApellido.Leave
        If objValidaciones.validarCamposTexto(txtSegundoApellido) = True Then
            lblSegundoAV.Image = campoCorrecto
            lblSegundoAV.Visible = True
        Else
            lblSegundoAV.Image = campoIncorrecto
            lblSegundoAV.Visible = True
        End If
    End Sub

    Private Sub txtTelefono_Leave(sender As Object, e As EventArgs) Handles txtTelefono.Leave
        If objValidaciones.validarCamposNumericos(txtTelefono) = True Then
            lblTelefonoV.Image = campoCorrecto
            lblTelefonoV.Visible = True
        Else
            lblTelefonoV.Image = campoIncorrecto
            lblTelefonoV.Visible = True
        End If
    End Sub

    Private Sub rctDireccion_Leave(sender As Object, e As EventArgs) Handles rctDireccion.Leave
        If objValidaciones.validarCamposTexto(rctDireccion) = True Then
            lblDireccionV.Image = campoCorrecto
            lblDireccionV.Visible = True
        Else
            lblDireccionV.Image = campoIncorrecto
            lblDireccionV.Visible = True
        End If
    End Sub

    Private Sub dtpNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpNacimiento.ValueChanged

        If dtpNacimiento.Value.Year.ToString() > Date.Today.Year Then
            lblFechaV.Visible = False
            dtpNacimiento.Value = Date.Today
            lblFechaV.Visible = True
        Else
            If dtpNacimiento.Value.Year.ToString() = Date.Today.Year Then
                lblFechaV.Visible = True
                lblFechaV.Text = "*Por favor ingrese una fecha de nacimiento anterior a este año."
            Else
                lblFechaV.Visible = False
                txtEdad.Text = Date.Today.Year - dtpNacimiento.Value.Year.ToString()
            End If

        End If
    End Sub

    Private Sub crearCorreo()
        If txtNombre.Text.Length > 0 And txtPrimerApellido.Text.Length > 0 And txtSegundoApellido.Text.Length > 0 Then
            If lblNombreV.Image.Equals(campoCorrecto) And lblPrimerAV.Image.Equals(campoCorrecto) And lblSegundoAV.Image.Equals(campoCorrecto) Then
                txtCorreoElectronico.Text = txtNombre.Text.Substring(0, 1).ToLower() + txtPrimerApellido.Text.ToLower() + txtSegundoApellido.Text.Substring(0, 1).ToLower() + "@ucenfotec.ac.cr"
            Else
            End If
        End If
    End Sub

    Private Sub pnFormulario_TabIndexChanged(sender As Object, e As EventArgs) Handles pnFormulario.TabIndexChanged
        crearCorreo()
    End Sub

    Private Sub pnFormulario_MouseMove(sender As Object, e As MouseEventArgs) Handles pnFormulario.MouseMove
        crearCorreo()
    End Sub

    Private Sub pnFormulario_Click(sender As Object, e As EventArgs) Handles pnFormulario.Click
        crearCorreo()
    End Sub

    Function generarContrasena()
        Dim r As New Random()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(6, 10)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Sub registrarUsuario()
        Dim random As New Random()
        Dim cedula As String = txtCedula.Text
        Dim nombre As String = txtNombre.Text
        Dim primerApellido As String = txtPrimerApellido.Text
        Dim segundoApellido As String = txtSegundoApellido.Text
        Dim genero As Char = obtenerGenero()
        Dim telefono As String = txtTelefono.Text
        Dim fechaNacimiento As String = dtpNacimiento.Value.ToString()
        Dim edad As String = txtEdad.Text.ToString()
        Dim idRol As Integer = cmbRol.SelectedValue.ToString()
        Dim correoElectronico As String = txtCorreoElectronico.Text
        Dim direccion As String = rctDireccion.Text.ToString()
        Dim contrasena As String = generarContrasena()

        gestorUsuario.agregarUsuario(cedula, nombre, primerApellido, segundoApellido, genero, telefono, fechaNacimiento, edad, idRol, correoElectronico, direccion, contrasena)
        gestorUsuario.guardarCambios()

        PopAgregado.Show()
        Me.Close()

    End Sub

    Private Function obtenerGenero() As Char
        Dim genero As Char
        If rbtnMasculino.Checked = True Then
            genero = "M"
        Else
        End If

        If rbtnFemenino.Checked = True Then
            genero = "F"
        End If
        Return genero
    End Function

End Class