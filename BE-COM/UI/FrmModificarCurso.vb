Imports EntitiesLayer

Public Class FrmModificarCurso

    Dim validaciones As New Validaciones()
    Dim formAnterior As Form
    Dim aceptado As String = "El curso se modifico correctamente"
    Dim idCurso As String
    Public Sub New(pformAnterior As Form, pidCurso As String)
        idCurso = pidCurso
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub

    Public Sub validarDatosCargados()
        txtCodigo_Leave(txtCodigo, Nothing)
        txtNombre_Leave(txtNombre, Nothing)
        txtCreditos_Leave(txtCreditos, Nothing)
        txtCosto_Leave(txtCosto, Nothing)

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub



    Private Sub FrmModificarCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rellenarTextBox()
        validarDatosCargados()
    End Sub

    Private Sub rellenarTextBox()
        Dim objCurso As Curso
        objCurso = gestorCurso.ObtenerCursoPorId(idCurso)
        txtCodigo.Text = objCurso.Codigo
        txtNombre.Text = objCurso.Nombre
        txtCreditos.Text = objCurso.Creditos
        txtCosto.Text = objCurso.Costo
        cmbEstado.Items.Add("Activo")
        cmbEstado.Items.Add("Inactivo")
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If validarEspaciosBlanco() = True Then
            If validarCamposFormulario() = True Then
                modificarCurso()
            Else

            End If
        Else

        End If
    End Sub

    Private Function validarEspaciosBlanco() As Boolean
        Dim permitido = False

        For Each textBox As TextBox In Me.Controls.OfType(Of TextBox)()
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

        For Each validacion As Label In Me.Controls.OfType(Of Label)()
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
    Private Sub modificarCurso()
        Dim codigo As String = txtCodigo.Text
        Dim nombre As String = txtNombre.Text
        Dim creditos As Integer = txtCreditos.Text
        Dim costo As Integer = txtCosto.Text
        Dim estado As String = cmbEstado.Text
        Dim estadoInt As Integer = 1
        If cmbEstado.Text = "Activo" Then
            estadoInt = 1
        ElseIf cmbEstado.Text = "Inactivo" Then
            estadoInt = 2
        End If
        gestorCurso.modificarCurso(idCurso, codigo, nombre, creditos, costo, estadoInt)
        gestorCurso.guardarCambios()
        Dim popUpAgregado As PopAgregado = New PopAgregado(aceptado)
        popUpAgregado.Show()
    End Sub
    Private Sub txtCodigo_Leave(sender As Object, e As EventArgs) Handles txtCodigo.Leave
        If validaciones.validarCamposTexto(txtCodigo) = True Then
            lblCodigoV.Image = campoCorrecto
            lblCodigoV.Visible = True
        Else
            lblCodigoV.Image = campoIncorrecto
            lblCodigoV.Visible = True
        End If
    End Sub
    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        If validaciones.validarCamposTexto(txtNombre) = True Then
            lblNombreV.Image = campoCorrecto
            lblNombreV.Visible = True
        Else
            lblNombreV.Image = campoIncorrecto
            lblNombreV.Visible = True
        End If
    End Sub

    Private Sub txtCreditos_Leave(sender As Object, e As EventArgs) Handles txtCreditos.Leave
        If validaciones.validarCamposNumericos(txtCreditos) = True Then
            lblCreditosV.Image = campoCorrecto
            lblCreditosV.Visible = True
        Else
            lblCreditosV.Image = campoIncorrecto
            lblCreditosV.Visible = True
        End If
    End Sub

    Private Sub txtCosto_Leave(sender As Object, e As EventArgs) Handles txtCosto.Leave
        If validaciones.validarCamposNumericos(txtCosto) = True Then
            lblCostoV.Image = campoCorrecto
            lblCostoV.Visible = True
        Else
            lblCostoV.Image = campoIncorrecto
            lblCostoV.Visible = True
        End If
    End Sub



End Class