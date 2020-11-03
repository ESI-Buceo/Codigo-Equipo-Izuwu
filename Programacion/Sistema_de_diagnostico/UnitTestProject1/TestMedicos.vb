Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Datos, Logica, MedicoAPP

<TestClass()> Public Class TestMedico
    Dim prueba As New LogicaAplicacion()
    <TestMethod()> Public Sub Test_AgregarMedico()

        Dim medico As New Medico("Nicolas", Nothing, "Perez", "Cotelo", "nicolasperezc96@gmail.com", "MED-ADS-321", "Asilo 3649", "50921456", "nico1234", "Dermatologo", "095277648", "1996-09-01", "H", Nothing)
        Dim LanzoError As Boolean = False
        Try
            prueba.agregarMedico(medico, "CPM-AAA-005")
        Catch ex As Exception
            LanzoError = True
        End Try
        Assert.AreEqual(True, LanzoError)
    End Sub

    <TestMethod()> Public Sub Test_ModificarMedico()
        Dim medico As New Medico("Esteban", "Martin", "Perez", Nothing, "nicolasperezc96@gmail.com", "MED-ADS-321", "Asilo 3649", "50921456", "nico1234", "Dermatologo", "095277648", "1996-09-01", "H", Nothing)
        Dim lanzoError As Boolean = False
        Try
            prueba.actualizarMedico(medico, "CPM-AAA-005")
        Catch ex As Exception
            lanzoError = True
        End Try
        Assert.AreEqual(True, lanzoError)
    End Sub

    <TestMethod()> Public Sub Test_EliminarMedico()
        Dim eliminar As String = "MED-ADS-321"
        Dim lanzoError As Boolean = False

        Try
            prueba.eliminarMedico(eliminar)
        Catch ex As Exception
            lanzoError = True
        End Try
        Assert.AreEqual(False, lanzoError)
    End Sub


End Class