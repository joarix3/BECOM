Imports EntitiesLayer

Public Class FrmMostrarRequisitos

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        cargarDataGridRequisitos()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub cargarDataGridRequisitos()
        DataGridRequisitos.Rows.Clear()
        Dim requisitos As List(Of Requisito) = gestorRequisito.consultarRequisitoPorEstado
        If requisitos IsNot Nothing Then
            For Each c As Requisito In requisitos
                DataGridRequisitos.Rows.Add(c.Id, c.Nombre, c.Descripcion)
            Next c
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        FrmRegistrarRequisito.Show()
    End Sub
End Class