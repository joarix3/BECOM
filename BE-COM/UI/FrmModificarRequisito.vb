Imports EntitiesLayer
Imports BLL

Public Class FrmModificarRequisito

    Dim formAnterior As Form
    Dim objRequisito As Requisito

    Public Sub New(pformAnterior As Form, pobjRequisito As Requisito)
        objRequisito = pobjRequisito
        formAnterior = pformAnterior
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        formAnterior.Show()
        Me.Hide()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim id As Integer = objRequisito.Id
        Dim nombre As String = txtNombre.Text
        Dim descripcion As String = txtDescripcion.Text

        gestorRequisito.modificarRequisito(id, nombre, descripcion)
        gestorRequisito.guardarCambios()

    End Sub

    Private Sub FrmModificarBeneficio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = objRequisito.Nombre
        txtDescripcion.Text = objRequisito.Descripcion
    End Sub

End Class