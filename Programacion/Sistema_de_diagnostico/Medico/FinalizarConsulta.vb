﻿Imports Datos, Logica
Public Class FinalizarConsulta
    Dim instancia As New LogicaAplicacion()
    Public paciente As Paciente
    Public medico As Medico
    Public sala As String

    Dim listaPatoligia As List(Of Patologia) = instancia.ObtenerPatologia()

    Private Sub FinalizarConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labNombrePaciente.Text = paciente.nombre + " " + paciente.apellido + " " + paciente.segundoapellido
        labCedulaPaciente.Text = paciente.CI

        For Each patologia As Patologia In listaPatoligia
            cbxPatologiaFinal.Items.Add(patologia.nombre)
        Next
        Dim fechaActual As Date = Date.Now
        dateFechaDiagnostico.Value = fechaActual
    End Sub

    Private Sub btnFinalizarConsulta_Click(sender As Object, e As EventArgs) Handles btnFinalizarConsulta.Click
        Dim textoFinal As String = "Patologia diagnosticada por el medico: " + cbxPatologiaFinal.Text + ". Detalles de la consulta: " + txtContenido.Text
        Dim id_tratamiento As String = instancia.codigoRandom(7)
        Dim idDiagnostico As String = instancia.obtenerIDDiagnostico(medico.ID)
        instancia.finalizarConsultaMedico(textoFinal, id_tratamiento, medico.ID, idDiagnostico, sala)
        Me.Close()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class