Imports EntitiesLayer

Public Class FrmRegistrarCurso


    Dim formAnterior As Form
    Public Sub New(pformAnterior As Form)
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If validarEspaciosBlanco() = True Then
            If validarCamposFormulario() = True Then
                registrarCurso()
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

    Private Sub registrarCurso()
        Dim aceptado As String = "El curso se registro correctamente"
        Dim codigo As String = txtCodigo.Text
        Dim nombre As String = txtNombre.Text
        Dim creditos As Integer = txtCreditos.Text
        Dim costo As Integer = txtCosto.Text
        Dim estado As Integer = 1
        gestorCurso.agregarCurso(codigo, nombre, creditos, costo, estado)
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