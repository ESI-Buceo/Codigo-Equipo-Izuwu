Imports ConexionBD, Datos
Imports Microsoft.VisualBasic.ApplicationServices

Public Class LogicaAplicacion
    Dim instancia As New ConexionConBD()

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

    Public Function ObtenerReferenciaSintomaPatologia() As List(Of ReferenciaSintomaPatologia)
        Return instancia.ObtenerReferenciaSintomaPatologia()
    End Function

    '----------------------------------------------------------------------------------------------------------------------------------------------

    Public Function loginMedico(userCI As String, pass As String) As Medico
        If userCI.Length = 0 Or pass.Length = 0 Then
            Throw New Exception("Usuario y/o contraseña vacio/s")
        Else
            Return instancia.loginMedico(userCI, pass)
        End If
    End Function

    Public Function loginPaciente(userCI As String, pass As String) As Paciente
        If userCI.Length = 0 Or pass.Length = 0 Then
            Throw New Exception("Usuario y/o contraseña vacio/s")
        Else
            Return instancia.loginPaciente(userCI, pass)
        End If
    End Function

    Public Function loginGestor(userCI As String, pass As String) As Gestor
        If userCI.Length = 0 Or pass.Length = 0 Then
            Throw New Exception("Usuario y/o contraseña vacio/s")
        Else
            Return instancia.loginGestor(userCI, pass)
        End If
    End Function

    '---------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub agregarPaciente(paciente As Paciente)
        If paciente.nombre.Length = 0 Or paciente.apellido.Length = 0 Or paciente.CI.Length = 0 Or paciente.Direccion.Length = 0 Or paciente.email.Length = 0 Or paciente.contraseña.Length = 0 Or paciente.telefono.Length = 0 Or paciente.fechadenacimiento.Length = 0 Then
            Throw New Exception("Datos incompletos.")
        Else
            instancia.agregarPaciente(paciente)
        End If
    End Sub

    Public Sub agregarMedico(medico As Medico)
        If medico.nombre.Length = 0 Or medico.apellido.Length = 0 Or medico.CI.Length = 0 Or medico.Direccion.Length = 0 Or medico.email.Length = 0 Or medico.contraseña.Length = 0 Or medico.telefono.Length = 0 Or medico.fechadenacimiento.Length = 0 Or medico.especializacion.Length = 0 Then
            Throw New Exception("Datos incompletos.")
        Else
            instancia.agregarMedico(medico)
        End If
    End Sub

    Public Sub agregarGestor(gestor As Gestor)
        If gestor.nombre.Length = 0 Or gestor.apellido.Length = 0 Or gestor.CI.Length = 0 Or gestor.Direccion.Length = 0 Or gestor.email.Length = 0 Or gestor.contraseña.Length = 0 Or gestor.telefono.Length = 0 Or gestor.fechadenacimiento.Length = 0 Or gestor.empresa.Length = 0 Then
            Throw New Exception("Datos incompletos.")
        Else
            instancia.agregarGestor(gestor)
        End If
    End Sub

    Public Sub agregarSintoma(sintoma As Sintoma)
        If sintoma.nombre.Length = 0 Or sintoma.id.Length = 0 Then
            Throw New Exception("Datos incompletos.")
        Else
            instancia.agregarSintoma(sintoma)
        End If
    End Sub

    Public Sub agregarPatologia(patologia As Patologia)
        If patologia.nombre.Length = 0 Or patologia.id.Length = 0 Or patologia.prioridad.Length = 0 Then
            Throw New Exception("Datos incompletos.")
        Else
            instancia.agregarPatologia(patologia)
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

    Public Sub actualizarNombreSintoma(ID As String, nom As String)
        If nom.Length = 0 Then
            Throw New Exception("Nombre vacio.")
        Else
            instancia.actualizarNombreSintoma(ID, nom)
        End If
    End Sub
    Public Sub actualizarNombrePatologia(ID As String, nom As String)
        If nom.Length = 0 Then
            Throw New Exception("Nombre vacio.")
        Else
            instancia.actualizarNombrePatologia(ID, nom)
        End If
    End Sub
    Public Sub actualizarPrioridadPatologia(ID As String, prioridad As String)
        If prioridad.Length = 0 Then
            Throw New Exception("Prioridad vacia.")
        Else
            instancia.actualizarPrioridadPatologia(ID, prioridad)
        End If
    End Sub


    Public Sub actualizarNombre(ID As String, nom As String)
        If nom.Length = 0 Then
            Throw New Exception("Nombre vacio.")
        Else
            instancia.actualizarNombre(ID, nom)
        End If
    End Sub
    Public Sub actualizarApellido(ID As String, apellido As String)
        If apellido.Length = 0 Then
            Throw New Exception("Apellido vacio.")
        Else
            instancia.actualizarApellido(ID, apellido)
        End If
    End Sub
    Public Sub actualizarEmail(ID As String, email As String)
        If email.Length = 0 Then
            Throw New Exception("Email vacio.")
        Else
            instancia.actualizarEmail(ID, email)
        End If
    End Sub
    Public Sub actualizarDireccion(ID As String, direccion As String)
        If direccion.Length = 0 Then
            Throw New Exception("Direccion vacia.")
        Else
            instancia.actualizarDireccion(ID, direccion)
        End If
    End Sub
    Public Sub actualizarCI(ID As String, CI As String)
        If CI.Length = 0 Then
            Throw New Exception("Cedula de identidad vacia.")
        Else
            instancia.actualizarCI(ID, CI)
        End If
    End Sub
    Public Sub actualizarContraseña(ID As String, contraseña As String)
        If contraseña.Length = 0 Then
            Throw New Exception("Contraseña vacia.")
        Else
            instancia.actualizarContraseña(ID, contraseña)
        End If
    End Sub
    Public Sub actualizarTelefono(ID As String, telefono As String)
        If telefono.Length = 0 Then
            Throw New Exception("Numero de telefono vacio.")
        Else
            instancia.actualizarTelefono(ID, telefono)
        End If
    End Sub
    Public Sub actualizarFechadeNacimiento(ID As String, fecha As String)
        If fecha.Length = 0 Then
            Throw New Exception("Fecha de nacimiento vacia.")
        Else
            instancia.actualizarFechadeNacimiento(ID, fecha)
        End If
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Function codigoRandom(id As String, num As Integer) As String
        Return instancia.codigoRandom(id, num)
    End Function

End Class