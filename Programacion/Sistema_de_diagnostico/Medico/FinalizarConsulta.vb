Imports Datos, Logica
Public Class FinalizarConsulta
    Dim instancia As New LogicaAplicacion()
    Public paciente As Paciente
    Public medico As Medico
    Public diagnostico As String

    Dim listaPatoligia As List(Of Patologia)

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
        ' instancia.finalizarConsultaMedico(textoFinal, id_tratamiento)
        Me.Close()
    End Sub
End Class