Imports EntitiesLayer

Public Class FrmRegistrarCarrera

    'Dim objValidaciones As New Validaciones()
    Dim formAnterior As Form

    Public Sub New(pformAnterior As Form)
        InitializeComponent()
        formAnterior = pformAnterior
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        If cdCarrera.ShowDialog = DialogResult.OK Then
            rctColor.BackColor = cdCarrera.Color
        End If
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub FrmRegistrarCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim codigo As String = txtCodigo.Text
        Dim nombre As String = txtNombre.Text
        Dim director As Integer = comboDirector.SelectedItem
        Dim color As String = cdCarrera.Color.ToString
        Dim becasOtor As Integer = txtBecasOtorgables.Text


        'validarCampoFormulario()

        gestorCarrera.agregarCarrera(codigo, nombre, 2, color, becasOtor)
        gestorCarrera.guardarCambios()
        PopAgregado.Show()


    End Sub
    'Private Sub validarCampoFormulario()
    '    For Each validacion As Label In Me.pnFormulario.Controls.OfType(Of Label)()
    '        If IsNumeric(validacion.Tag) = True Then
    '            If validacion.Image.Equals(campoIncorrecto) Then
    '                MsgBox("Existen campos incorrectos")
    '            End If
    '        End If
    '    Next
    'End Sub

End Class