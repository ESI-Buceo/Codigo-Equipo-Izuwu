Imports Datos, Logica

Public Class SolicitudChat
    Dim instancia As New LogicaAplicacion()
    Public patologia As Patologia
    Public paciente As Paciente
    Public idDiagnostico As String
    Dim listaMedicos As List(Of Medico)

    'Boton para cerrar la ventana.
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    'Cuando la ventana se abra, segun los parametros recibidos
    'se muestran una serie de medicos que atienden una patologia en concreto.
    Private Sub SolicitudChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labPatologia.Text = patologia.nombre
        listaMedicos = instancia.medicosEspecializados(patologia)
        For Each medico As Medico In listaMedicos
            lstMedicos.Items.Add(medico.nombre + " " + medico.segundonombre + " " + medico.apellido + " " + medico.segundoapellido + " - " + medico.especializacion)
        Next
    End Sub

    'Este boton inicia una solitud con un medico, y crea una sala de chat (A nivel persistencia).
    Private Sub btnIniciarSolicitud_Click(sender As Object, e As EventArgs) Handles btnIniciarSolicitud.Click
        Dim fechaActual As Date = Date.Now
        Dim fechaString As String = Format(fechaActual, "yyyy/MM/dd")
        instancia.crearSalaChat(fechaString, listaMedicos.ElementAt(lstMedicos.FocusedItem.Index), paciente, idDiagnostico)
        MsgBox("Su solicitud se completo con exito. Un medico le atendera en la brevedad.")
        Me.Close()
    End Sub

    'misma funcion que la de cerrar, solo que se muestra otra vez (para comodidad del usuario).
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class