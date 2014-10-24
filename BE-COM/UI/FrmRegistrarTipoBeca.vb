Imports BLL
Imports EntitiesLayer
Public Class FrmRegistrarTipoBeca

    Dim formAnterior As Form

    Private Sub FrmRegistrarTipoBeca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each beneficio As Beneficio In gestorBeneficio.obtenerBeneficios
            ChkLbBeneficios.Items.Add(beneficio.Nombre())
        Next

    End Sub

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
    ''' <summary>
    ''' Metodo con el evento click para registrar los campos del formulario Tipo de beca
    ''' </summary>
    ''' <param name="sender">object</param>
    ''' <param name="e">EventArgs</param>
    ''' <remarks></remarks>
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim nombre As String = txtNombre.Text
        Dim descripion As String = rctDescripcion.Text
        Dim periodo As String = cmbPeriodo.SelectedValue
        Dim estado As String = cmbEstado.SelectedValue

        'gestorTipoBeca.agregarTipoBeca()
    End Sub
End Class