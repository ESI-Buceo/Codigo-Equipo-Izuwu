Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Datos, Logica, PacienteAPP

<TestClass()> Public Class TestPaciente
    Dim prueba As New LogicaAplicacion()

    <TestMethod()> Public Sub Test_AgregarPaciente()
        Dim paciente As New Paciente("Nicolas", Nothing, "Perez", "Cotelo", "nicolasperezc96@gmail.com", "PAC-ADS-321", "Asilo 3649", "50921456", "nico1234", "095277648", "1996-09-01", "H", Nothing, "1.75", "Nada")
        Dim LanzoError As Boolean = False
        Try
            prueba.agregarPaciente(paciente)
        Catch ex As Exception
            LanzoError = True
        End Try
        Assert.AreEqual(True, LanzoError)
    End Sub

    <TestMethod()> Public Sub Test_ModificarPaciente()
        Dim paciente As New Paciente("Pablo", "Nicolas", "Perez", "Cotelo", "nicolasperezc96@gmail.com", "PAC-ADS-321", "Asilo 3649", "50921456", "nico1234", "095277648", "1996-09-01", "H", Nothing, "1.75", "Nada")
        Dim LanzoError As Boolean = False
        Try
            prueba.agregarPaciente(paciente)
        Catch ex As Exception
            LanzoError = True
        End Try
        Assert.AreEqual(True, LanzoError)
    End Sub

    <TestMethod()> Public Sub Test_EliminarPaciente()
        Dim eliminar As String = "PAC-ADS-321"
        Dim lanzoError As Boolean = False
        Try
            prueba.eliminarMedico(eliminar)
        Catch ex As Exception
            lanzoError = True
        End Try
        Assert.AreEqual(False, lanzoError)
    End Sub


End Class
