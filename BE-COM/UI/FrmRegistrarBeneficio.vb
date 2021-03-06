﻿Public Class FrmRegistrarBeneficio

    Private Sub txtNombre_Leave(sender As Object, e As EventArgs) Handles txtNombre.Leave
        If objValidaciones.validarCamposTexto(txtNombre) = True Then
            lblNombreV.Image = campoCorrecto
            lblNombreV.Visible = True
        Else
            lblNombreV.Image = campoIncorrecto
            lblNombreV.Visible = True
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        'formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub txtPorcentaje_Leave(sender As Object, e As EventArgs) Handles txtPorcentaje.Leave
        If objValidaciones.validarCamposNumericos(txtPorcentaje) = True Then
            lblPorcentajeV.Image = campoCorrecto
            lblPorcentajeV.Visible = True
        Else
            lblPorcentajeV.Image = campoIncorrecto
            lblPorcentajeV.Visible = True
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As String = txtNombre.Text
        Dim porcentaje As Double = Convert.ToDouble(txtPorcentaje.Text)
        Dim descripcion As String = txtDescripcion.Text

        Try
            validarCampoFormulario()
            gestorBeneficio.agregarBeneficio(nombre, porcentaje, descripcion)
            gestorBeneficio.guardarCambios()
            PopAgregado.Show()
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

End Class