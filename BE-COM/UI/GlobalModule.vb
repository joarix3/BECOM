Imports EntitiesLayer
Imports BLL

Module GlobalModule
    Public gestorBitacora As New GestorBitacora()
    Public gestorUsuario As New GestorUsuarios()
    Public gestorCarrera As New GestorCarrera()

    Public objValidaciones As New Validaciones()
    Public gestorRequisito As New GestorRequisito()
    Public gestorBeneficio As New GestorBeneficio()
    Public gestorTipoBeca As New GestorTipoBeca()
    Public gestorPeriodo As New GestorPeriodo()
    Public gestorBitacoraTransaccion As New GestorBitacoraTransaccion()

<<<<<<< HEAD
=======
    Public campoCorrecto As Image = Image.FromFile("C:\Users\Douglas\Documents\BECOM\BE-COM\Imagens\Validaciones\Correcto.png")
    Public campoIncorrecto As Image = Image.FromFile("C:\Users\Douglas\Documents\BECOM\BE-COM\Imagens\Validaciones\Incorrecto.png")
>>>>>>> BECOMD
    
    Public validaciones As New Validaciones()
    Public campoCorrecto As Image = Image.FromFile("C:\Users\Mario\Documents\BECOM\BE-COM\Imagens\Validaciones\Correcto.png")
    Public campoIncorrecto As Image = Image.FromFile("C:\Users\Mario\Documents\BECOM\BE-COM\Imagens\Validaciones\Incorrecto.png")


End Module
