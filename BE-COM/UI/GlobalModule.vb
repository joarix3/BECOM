Imports BLL
Imports EntitiesLayer

Module GlobalModule

    Public gestorUsuario As New GestorUsuarios()
    Public validaciones As New Validaciones()
    Public gestorBeneficio As New GestorBeneficio
    Public campoCorrecto As Image = Image.FromFile("C:\Users\PC\Dropbox\Soft506\BE-COM\Imagens\Validaciones\Correcto.png")
    Public campoIncorrecto As Image = Image.FromFile("C:\Users\PC\Dropbox\Soft506\BE-COM\Imagens\Validaciones\Incorrecto.png")

    Public gestorTipoBeca As New GestorTipoBeca()

End Module
