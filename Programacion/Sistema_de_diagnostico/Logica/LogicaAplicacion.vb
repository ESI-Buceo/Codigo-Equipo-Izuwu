﻿Imports ConexionBD, Datos
Imports Microsoft.VisualBasic.ApplicationServices

Public Class LogicaAplicacion
    Dim instancia As New ConexionConBD()

    'Las funciones de aca en general sirven como "puente" o "conector"
    'entre la persistencia y la presentacion.

    'Algunas de estas funciones realizan validaciones para que no lleguen
    'datos erroneos a la persistencia.


    Public Function ObtenerPacientes() As List(Of Paciente)
        Return instancia.ObtenerPacientes()
    End Function

    Public Function ObtenerMedicos() As List(Of Medico)
        Return instancia.ObtenerMedicos()
    End Function

    Public Function ObtenerGestores() As List(Of Gestor)
        Return instancia.ObtenerGestores()
    End Function

    Public Function ObtenerSintoma() As List(Of Sintoma)
        Return instancia.ObtenerSintoma()
    End Function

    Public Function ObtenerPatologia() As List(Of Patologia)
        Return instancia.ObtenerPatologia()
    End Function

    Public Function ObtenerReferenciaSintomaPatologia(ID As String) As List(Of Patologia)
        Return instancia.ObtenerReferenciaSintomaPatologia(ID)
    End Function

    Public Function ObtenerReferenciaPatologiaSintoma(ID As String) As List(Of Sintoma)
        Return instancia.ObtenerRefenciaPatologiaSintoma(ID)
    End Function

    Public Function ObtenerEspecializacionMedico() As List(Of campo_medico)
        Return instancia.ObtenerEspecializacionesMedicos
    End Function

    Public Function obtenerUnPaciente(ID_sala As String) As Paciente
        Return instancia.obtenerUnPaciente(ID_sala)
    End Function

    Public Function obtenerUnMedico(ID_sala As String) As Medico
        Return instancia.obtenerUnMedico(ID_sala)
    End Function

    Public Function obtenerHistorialConsultasM(id_med As String) As List(Of tratamiento)
        Return instancia.obtenerHistorialMedico_Medico(id_med)
    End Function

    Public Function obtenerHistorialConsultasP(id_pac As String) As List(Of tratamiento)
        Return instancia.obtenerHistorialMedico_Paciente(id_pac)
    End Function

    '----------------------------------------------------------------------------------------------------------------------------------------------

    Public Function loginMedico(userCI As String, pass As String) As Medico
        If userCI.Length = 0 Or pass.Length = 0 Then
            Throw New Exception("Usuario y/o contraseña vacío/s")
        Else
            Return instancia.loginMedico(userCI, pass)
        End If
    End Function

    Public Function loginPaciente(userCI As String, pass As String) As Paciente
        If userCI.Length = 0 Or pass.Length = 0 Then
            Throw New Exception("Usuario y/o contraseña vacío/s")
        Else
            Return instancia.loginPaciente(userCI, pass)
        End If
    End Function

    Public Function loginGestor(userCI As String, pass As String) As Gestor
        If userCI.Length = 0 Or pass.Length = 0 Then
            Throw New Exception("Usuario y/o contraseña vacío/s")
        Else
            Return instancia.loginGestor(userCI, pass)
        End If
    End Function

    '---------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub AMsintoma(conf As Integer, sintoma As Sintoma)
        If conf = -1 Then
            agregarSintoma(sintoma)

        ElseIf conf = 0 Then
            actualizarSintoma(sintoma)
        End If
    End Sub

    Public Sub AMpatologia(conf As Integer, patologia As Patologia, id_campoMedico As String)
        If conf = -1 Then
            agregarPatologia(patologia, id_campoMedico)
        ElseIf conf = 0 Then
            actualizarPatologia(patologia, id_campoMedico)
        End If
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------------------------------
    Public Sub agregarPaciente(paciente As Paciente)
        If paciente.nombre.Length = 0 Or paciente.apellido.Length = 0 Or paciente.CI.Length = 0 Or paciente.Direccion.Length = 0 Or paciente.email.Length = 0 Or
            paciente.contraseña.Length = 0 Or paciente.telefono.Length = 0 Or paciente.fechadenacimiento.Length = 0 Or paciente.segundoapellido.Length = 0 Or
            paciente.altura.Length = 0 Or paciente.peso.Length = 0 Or paciente.patologiaPrevia.Length = 0 Then
            Throw New Exception("Datos incompletos.")
        Else
            instancia.agregarPaciente(paciente)
        End If
    End Sub

    Public Sub agregarMedico(medico As Medico, idcampo As String)
        If medico.nombre.Length = 0 Or medico.apellido.Length = 0 Or medico.CI.Length = 0 Or medico.Direccion.Length = 0 Or medico.email.Length = 0 Or
            medico.contraseña.Length = 0 Or medico.telefono.Length = 0 Or medico.fechadenacimiento.Length = 0 Or medico.segundoapellido.Length = 0 Or
            medico.lugarDeTrabajo.Length = 0 Then
            Throw New Exception("Datos incompletos.")
        Else
            instancia.agregarMedico(medico, idcampo)
        End If
    End Sub

    Public Sub agregarGestor(gestor As Gestor)
        If gestor.nombre.Length = 0 Or gestor.apellido.Length = 0 Or gestor.CI.Length = 0 Or gestor.Direccion.Length = 0 Or gestor.email.Length = 0 Or
            gestor.contraseña.Length = 0 Or gestor.telefono.Length = 0 Or gestor.fechadenacimiento.Length = 0 Or gestor.empresa.Length = 0 Or
            gestor.segundoapellido.Length = 0 Then
            Throw New Exception("Datos incompletos.")
        Else
            instancia.agregarGestor(gestor)
        End If
    End Sub

    Private Sub agregarSintoma(sintoma As Sintoma)
        If sintoma.nombre.Length = 0 Or sintoma.id.Length = 0 Then
            Throw New Exception("Datos incompletos.")
        Else
            instancia.agregarSintoma(sintoma)
        End If
    End Sub

    Public Sub agregarPatologia(patologia As Patologia, id_campoMedico As String)
        If patologia.nombre.Length = 0 Or patologia.id.Length = 0 Or patologia.prioridad.Length = 0 Then
            Throw New Exception("Datos incompletos.")
        Else
            instancia.agregarPatologia(patologia, id_campoMedico)
        End If
    End Sub

    Public Sub agregarSintomaDePatologia(IDsintoma As String, IDpatologia As String)
        If IDpatologia.Length = 0 Then
            Throw New Exception("Ninguna patología seleccionada.")
        Else
            instancia.agregarSintomaDePatologia(IDsintoma, IDpatologia)
        End If
    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub eliminarPaciente(ID As String)
        instancia.eliminarPaciente(ID)
    End Sub
    Public Sub eliminarMedico(ID As String)
        instancia.eliminarMedico(ID)
    End Sub
    Public Sub eliminarGestor(ID As String)
        instancia.eliminarGestor(ID)
    End Sub
    Public Sub eliminarSintoma(ID As String)
        instancia.eliminarSintoma(ID)
    End Sub
    Public Sub eliminarPatologia(ID As String)
        instancia.eliminarPatologia(ID)
    End Sub
    Public Sub eliminarReferenciaPatologiaSintoma(IDsin As String, IDpat As String)
        instancia.eliminarReferenciaPatologiaSintoma(IDsin, IDpat)
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub actualizarSintoma(sintoma As Sintoma)
        If sintoma.nombre.Length = 0 Then
            Throw New Exception("Nombre vacío.")
        Else
            instancia.actualizarSintoma(sintoma)
        End If
    End Sub
    Public Sub actualizarPatologia(patologia As Patologia, id_campoMedico As String)
        If patologia.nombre.Length = 0 Then
            Throw New Exception("Nombre vacío.")
        Else
            instancia.actualizarPatologia(patologia, id_campoMedico)
        End If
    End Sub

    Public Sub actualizarMedico(medico As Medico, idcampo As String)
        If medico.nombre.Length = 0 Or medico.apellido.Length = 0 Or medico.email.Length = 0 Or medico.Direccion.Length = 0 Or
            medico.CI.Length = 0 Or medico.contraseña.Length = 0 Or medico.telefono.Length = 0 Or medico.fechadenacimiento.Length = 0 Or
            medico.segundoapellido.Length = 0 Or medico.lugarDeTrabajo.Length = 0 Then
            Throw New Exception("Datos vacíos.")
        Else
            instancia.actualizarMedico(medico, idcampo)
        End If
    End Sub
    Public Sub actualizarContraseñaMedico(contraseña As String, id_medico As String)
        instancia.actualizarContraseñaMedico(contraseña, id_medico)
    End Sub

    Public Sub actualizarPaciente(paciente As Paciente)
        If paciente.email.Length = 0 Or paciente.Direccion.Length = 0 Or paciente.contraseña.Length = 0 Or paciente.telefono.Length = 0 Or
            paciente.altura.Length = 0 Or paciente.peso.Length = 0 Then
            Throw New Exception("Datos vacíos.")
        Else
            instancia.actualizarPaciente(paciente)
        End If
    End Sub

    Public Sub actualizarGestor(gestor As Gestor)
        If gestor.nombre.Length = 0 Or gestor.apellido.Length = 0 Or gestor.email.Length = 0 Or gestor.Direccion.Length = 0 Or gestor.CI.Length = 0 Or
            gestor.contraseña.Length = 0 Or gestor.telefono.Length = 0 Or gestor.fechadenacimiento.Length = 0 Or gestor.empresa.Length = 0 Or gestor.segundoapellido.Length = 0 Then
            Throw New Exception("Datos vacíos.")
        Else
            instancia.actualizarGestor(gestor)
        End If
    End Sub
    Public Sub actualizarContraseñaGestor(contraseña As String, id_gestor As String)
        instancia.actualizarContraseñaGestor(contraseña, id_gestor)
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Function codigoRandom(num As Integer) As String
        Return instancia.codigoRandom(num)
    End Function

    Public Sub agregarSintomasPaciente(sintomas As List(Of Sintoma), paciente As Paciente, fecha As String)
        If sintomas.Count = 0 Then
            Throw New Exception("No hay síntomas seleccionados.")
        ElseIf sintomas.Count = 1 Or sintomas.Count = 2 Then
            Throw New Exception("Seleccione mas síntomas para ser mas preciso.")
        Else
            instancia.agregarSintomasPaciente(sintomas, paciente, fecha)
        End If
    End Sub
    Public Function diagnostico() As List(Of Diagnostico)
        Return instancia.Diagnostico()
    End Function
    Public Sub agregarDiagnostico_A_BD(diagnosticos As List(Of Diagnostico), paciente As Paciente, fecha As String, idDiagnostico As String)
        instancia.agregarDiagnostico_A_BD(diagnosticos, paciente, fecha, idDiagnostico)
    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Function medicosEspecializados(patologia As Patologia) As List(Of Medico)
        Return instancia.medicosEspecializados(patologia)
    End Function

    Public Sub crearSalaChat(fecha As String, medico As Medico, paciente As Paciente, idDiagnostico As String)
        instancia.crearSalaChat(fecha, medico, paciente, idDiagnostico)
    End Sub

    Public Function obtenerIDDiagnostico(idpaciente As String) As String
        Return instancia.obtenerIDDiagnostico(idpaciente)
    End Function

    Public Function obtenerSolicitudesChatPendientes(medico As Medico) As List(Of Sala_Chat)
        Return instancia.obtenerSolicitudesChatPendientes(medico)
    End Function
    Public Sub aceptarSolicitud_De_Chat(id_sala As String)
        instancia.aceptarSolicitud_De_Chat(id_sala)
    End Sub
    Public Function obtenerSolicitudesChat_EnCurso(medico As Medico) As List(Of Sala_Chat)
        Return instancia.obtenerSolicitudesChat_EnCurso(medico)
    End Function

    Public Function obtenerSolicitudesAceptadas(paciente As Paciente) As List(Of Sala_Chat)
        Return instancia.obtenerSolicitudesAceptadas(paciente)
    End Function

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub enviarMensaje(contenido As String, id_sala As String, fecha As String, id_emisor As String, nombre As String)
        If id_emisor(0) = "P" Then
            instancia.enviarMensajePaciente(contenido, id_sala, fecha, nombre)
        ElseIf id_emisor(0) = "M" Then
            instancia.enviarMensajeMedico(contenido, id_sala, fecha, nombre)
        End If
    End Sub

    Public Function obtenerMensajes(id_sala As String) As List(Of Mensaje)
        Return instancia.obtenerMensajes(id_sala)
    End Function

    '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub finalizarConsultaMedico(contenido As String, id_consulta As String, id_medico As String, id_diagnostico As String, id_sala As String)
        instancia.finalizarConsultaMedico(contenido, id_consulta, id_medico, id_diagnostico, id_sala)
    End Sub



End Class