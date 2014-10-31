Imports BLL
Imports EntitiesLayer

Module GlobalModule

    Public validaciones As New Validaciones
    Public gestorBeneficio As New GestorBeneficio
    Public gestorRequisito As New GestorRequisito
    Public gestorBitacoraTransaccion As New GestorBitacoraTransaccion
    Public objValidaciones As New Validaciones
    Public campoCorrecto As Image = Image.FromFile("C:\Users\dani\Dropbox\Soft506\BE-COM\Imagens\Validaciones\Correcto.png")
    Public campoIncorrecto As Image = Image.FromFile("C:\Users\dani\Dropbox\Soft506\BE-COM\Imagens\Validaciones\Incorrecto.png")

End Module
