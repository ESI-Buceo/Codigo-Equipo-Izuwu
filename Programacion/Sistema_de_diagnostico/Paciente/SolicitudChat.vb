Imports Datos, Logica

Public Class SolicitudChat
    Dim instancia As New LogicaAplicacion()
    Public patologia As Patologia
    Public paciente As Paciente
    Dim listaMedicos As List(Of Medico)

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
    End Sub

    Private Sub SolicitudChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labPatologia.Text = patologia.nombre
        listaMedicos = instancia.medicosEspecializados(patologia)
        For Each medico As Medico In listaMedicos
            lstMedicos.Items.Add(medico.nombre + " " + medico.segundonombre + " " + medico.apellido + " " + medico.segundoapellido + " - " + medico.especializacion)
        Next
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim fechaActual As Date = Date.Now
        Dim fechaString As String = Format(fechaActual, "yyyy/MM/dd")
        instancia.crearSalaChat(fechaString, listaMedicos.ElementAt(lstMedicos.FocusedItem.Index), paciente)
        MsgBox("Su solicitud se completo con exito. Un medico le atendera en la brevedad.")
        Me.Close()
    End Sub
End Class