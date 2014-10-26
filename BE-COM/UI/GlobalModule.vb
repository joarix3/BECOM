Imports BLL
Imports EntitiesLayer

Module GlobalModule

    Public gestorUsuario As New GestorUsuarios()
    Public gestorCarrera As New GestorCarrera()
    Public validaciones As New Validaciones()
    Public campoCorrecto As Image = Image.FromFile("C:\Users\JuanManuel\Documents\BECOM\BECOM\BE-COM\Imagens\Validaciones\Correcto.png")
    Public campoIncorrecto As Image = Image.FromFile("C:\Users\JuanManuel\Documents\BECOM\BECOM\BE-COM\Imagens\Validaciones\Incorrecto.png")

End Module
