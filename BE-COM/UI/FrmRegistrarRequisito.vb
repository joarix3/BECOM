Public Class FrmRegistrarRequisito

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        If objValidaciones.validarCamposTexto(txtNombre) = True Then
            lblNombreV.Image = campoCorrecto
            lblNombreV.Visible = True
        Else
            lblNombreV.Image = campoIncorrecto
            lblNombreV.Visible = True
        End If
    End Sub

    Private Sub txtDescripcion_Leave(sender As Object, e As EventArgs) Handles txtDescripcion.Leave
        If objValidaciones.validarCamposTexto(txtDescripcion) = True Then
            lblDescripcionV.Image = campoCorrecto
            lblDescripcionV.Visible = True
        Else
            lblDescripcionV.Image = campoIncorrecto
            lblDescripcionV.Visible = True
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombre As String = txtNombre.Text
        Dim descripcion As String = txtDescripcion.Text

        Try
            validarCampoFormulario()
            gestorRequisito.agregarRequisito(nombre, descripcion)
            gestorRequisito.guardarCambios()
            Dim fecha As DateTime = DateTime.Now
            gestorBitacoraTransaccion.agregarBitacoraTransaccion(2, "Registrar Requisito", fecha)
            gestorBitacoraTransaccion.guardarCambios()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub validarCampoFormulario()
        For Each validacion As Label In Me.pnFormulario.Controls.OfType(Of Label)()
            If IsNumeric(validacion.Tag) = True Then
                If validacion.Image.Equals(campoIncorrecto) Then
                    MsgBox("Existen campos incorrectos")
                End If
            End If
        Next
    End Sub

    Private Sub pnFormulario_Paint(sender As Object, e As PaintEventArgs) Handles pnFormulario.Paint

    End Sub
End Class