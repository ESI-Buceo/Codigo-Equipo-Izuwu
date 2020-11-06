Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Datos, Logica, GestorAPP

<TestClass()> Public Class TestGestor
    Dim prueba As New LogicaAplicacion()
    <TestMethod()> Public Sub Test_AgregarMedico()

        Dim gestor As New Gestor("Nicolas", Nothing, "Perez", "Cotelo", "nicolasperezc96@gmail.com", "GES-ADS-321", "Asilo 3649", "50921456", "nico1234", "095277648", "1996-09-01", "H", "Niidea")
        Dim LanzoError As Boolean = False
        Try
            prueba.agregarGestor(gestor)
        Catch ex As Exception
            LanzoError = True
        End Try
        Assert.AreEqual(True, LanzoError)
    End Sub

    <TestMethod()> Public Sub Test_ModificarMedico()
        Dim gestor As New Gestor("Nicolas", Nothing, "Perez", "Cotelo", "nicolasperezc96@gmail.com", "GES-ADS-321", "Asilo 3649", "50921456", "nico1234", "095277648", "1996-09-01", "H", "Niidea")
        Dim lanzoError As Boolean = False
        Try
            prueba.actualizarGestor(gestor)
        Catch ex As Exception
            lanzoError = True
        End Try
        Assert.AreEqual(True, lanzoError)
    End Sub

    <TestMethod()> Public Sub Test_EliminarMedico()
        Dim eliminar As String = "GES-ADS-321"
        Dim lanzoError As Boolean = False

        Try
            prueba.eliminarMedico(eliminar)
        Catch ex As Exception
            lanzoError = True
        End Try
        Assert.AreEqual(False, lanzoError)
    End Sub
End Class
