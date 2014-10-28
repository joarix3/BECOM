Imports BLL
Imports EntitiesLayer


Module GlobalModule

    Public gestorUsuario As New GestorUsuarios()
    Public gestorCarrera As New GestorCarrera()
    Public objValidaciones As New Validaciones()
    Public gestorRequisito As New GestorRequisito()
    Public gestorBeneficio As New GestorBeneficio()
    Public gestorTipoBeca As New GestorTipoBeca()
    Public gestorPeriodo As New GestorPeriodo()
    Public gestorBitacoraTransaccion As New GestorBitacoraTransaccion()

    Public campoCorrecto As Image = Image.FromFile("C:\Users\JuanManuel\Documents\BECOM\BECOM\BECOM\BE-COM\Imagens\Validaciones\Correcto.png")
    Public campoIncorrecto As Image = Image.FromFile("C:\Users\JuanManuel\Documents\BECOM\BECOM\BECOM\BE-COM\Imagens\Validaciones\Incorrecto.png")
    

End Module
