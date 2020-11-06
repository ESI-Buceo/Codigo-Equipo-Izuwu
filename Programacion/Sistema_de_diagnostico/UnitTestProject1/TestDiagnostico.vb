Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Datos, Logica, PacienteAPP

<TestClass()> Public Class TestDiagnostico
    Dim prueba As New LogicaAplicacion()
    <TestInitialize()> Public Sub enviar_A_Posee()
        Dim sintomas As New List(Of Sintoma)
        sintomas.Add(New Sintoma("Dolor de garganta", "SIN-WWK-092"))
        sintomas.Add(New Sintoma("Dolor de cabeza", "SIN-JUR-393"))
        sintomas.Add(New Sintoma("Fiebre", "SIN-FGN-023"))
        sintomas.Add(New Sintoma("Sequedad en la boca", "SIN-DRX-943"))

        Dim paciente As New Paciente("Bruno", Nothing, "Pintos", "Etchart", "pintosbruno018@gmail.com", "PAC-BPE-018", "Londres esq Bruselas", "59692734366", "56505181bpe", "095277648", "2002-07-18", "H", "65.5", "1.72", "ninguna")

        Dim fecha As String = "2020-11-02"
        Dim lanzoError As Boolean = False
        Try
            prueba.agregarSintomasPaciente(sintomas, paciente, fecha)

            Dim diagnosticos As List(Of Diagnostico) = prueba.diagnostico()

            Dim id_diagnostico As String = prueba.codigoRandom(5)
            prueba.agregarDiagnostico_A_BD(diagnosticos, paciente, fecha, id_diagnostico)
        Catch ex As Exception
            lanzoError = True
        End Try
        Assert.AreEqual(True, lanzoError)

    End Sub

End Class
