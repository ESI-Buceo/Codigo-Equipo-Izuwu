Imports ConexionBD
Public Class LogicaAplicacion
    Dim instancia As ConexionBasedeDatos = New ConexionBasedeDatos()

    'Todas estas funciones sirven de nexo entre las sentencias de conexion a la base de datos y la aplicacion.


    Public Function login(ByVal usu, ByVal pass, ByVal ID) As Boolean
        Return instancia.login(usu, pass, ID)

    End Function

    Public Function generarRandomID(ByVal id, ByVal num) As String
        Dim IDnueva As String = instancia.codigoRandom(id, num)
        Return IDnueva
    End Function

    Public Sub agregarMedico(ByVal ID, ByVal nombre, ByVal apellido, ByVal CI, ByVal Telefono, ByVal direccion, ByVal especializacion, ByVal email, ByVal contraseña, ByVal fechanac)
        instancia.agregarmedico(ID, nombre, apellido, CI, Telefono, direccion, especializacion, email, contraseña, fechanac)
    End Sub

    Public Function cargarSintomas()
        Dim lista As New List(Of String)
        lista.AddRange(instancia.cargarSintomas())
        Return lista
    End Function

    Public Function cargarPatologia()
        Dim lista As New List(Of String)
        lista = instancia.cargarPatologia()
        Return lista
    End Function

    Public Sub agregarSintoma(ByVal ID, ByVal nom)
        instancia.agregarSintoma(ID, nom)
    End Sub

    Public Sub agregarReferenciaSintomaPatologia(ByVal ID, ByVal nom)
        Console.WriteLine(ID + " " + nom)
        instancia.agregarRefSintomaPatologia(ID, nom)
    End Sub

    Public Function obtenerIDSintoma(ByVal nom) As String
        Dim id As String = instancia.obtenerIDSintoma(nom)
        Return id
    End Function

    Public Function obtenerIDPatologia(ByVal nom)
        Dim id As String = instancia.obtenerIDPatologia(nom)
        Return id
    End Function

    Public Function obtenerReferenciaDeSintoma(ByVal nom)
        Dim lista As New List(Of String)
        lista.AddRange(instancia.obtenerRefSintoma(nom))
        Return lista
    End Function

    Public Sub eliminarReferenciaSintomaPatologia(ByVal nomSintoma, ByVal nomPatologia)
        instancia.eliminarReferenciaSintomaPatologia(nomSintoma, nomPatologia)
    End Sub

    Public Sub actualizarNombreSintoma(ByVal ID, ByVal nom)
        instancia.actualizarNombreSintoma(ID, nom)
    End Sub

    Public Sub eliminarSintoma(ByVal nom)
        instancia.eliminarSintoma(nom)
    End Sub

    Public Sub agregarPatologia(ByVal ID, ByVal nom, ByVal prioridad)
        instancia.agregarPatologia(ID, nom, prioridad)
    End Sub

    Public Function obtenerPrioridadPatologia(ByVal nom) As Integer
        Dim prioridad As Integer = instancia.obtenerPrioridadPatologia(nom)
        Return prioridad
    End Function

    Public Sub actualizarNombrePatologia(ByVal ID, ByVal nom)
        instancia.actualizarNombrePatologia(ID, nom)
    End Sub

    Public Sub actualizarPrioridadPatologia(ByVal ID, ByVal prioridad)
        instancia.actualizarPrioridadPatologia(ID, prioridad)
    End Sub

    Public Sub eliminarPatologia(ByVal nom)
        instancia.eliminarPatologia(nom)
    End Sub

    Public Sub agregarPaciente(ByVal ID, ByVal nombre, ByVal apellido, ByVal CI, ByVal Telefono, ByVal direccion, ByVal email, ByVal contraseña, ByVal fechanac)
        instancia.agregarPaciente(ID, nombre, apellido, CI, Telefono, direccion, email, contraseña, fechanac)
    End Sub

    Public Sub agregarGestor(ByVal ID, ByVal nombre, ByVal apellido, ByVal CI, ByVal Telefono, ByVal direccion, ByVal empresa, ByVal email, ByVal contraseña, ByVal fechanac)
        instancia.agregarGestor(ID, nombre, apellido, CI, Telefono, direccion, empresa, email, contraseña, fechanac)
    End Sub

    Public Function prueba(ByVal lista)
        Return instancia.prueba(lista)
    End Function

End Class