Imports EntitiesLayer
Imports BLL

Module GlobalModule

    Public gestorUsuario As New GestorUsuarios()
    Public gestorCarrera As New GestorCarrera()
    Public validaciones As New Validaciones()
    Public objGestorPeriodo As New GestorPeriodo()
    Public campoCorrecto As Image = Image.FromFile("C:\Users\Douglas\Dropbox\Soft506\BE-COM\Imagens\Validaciones\Correcto.png")
    Public campoIncorrecto As Image = Image.FromFile("C:\Users\Douglas\Dropbox\Soft506\BE-COM\Imagens\Validaciones\Incorrecto.png")

End Module
