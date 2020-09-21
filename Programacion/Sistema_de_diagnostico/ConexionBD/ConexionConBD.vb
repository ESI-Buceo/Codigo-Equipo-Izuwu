Imports ADODB, Datos, System.Text
Public Class ConexionConBD

    'Funcion para conectarse a la base de datos
    Private Function conectar() As Connection
        Dim connection As New Connection
        connection.ConnectionString = "" &
            "driver={MySQL ODBC 8.0 Unicode Driver};" &
            "server=127.0.0.1;" &
            "port=3306;" &
            "database=proyecto_izuwu;" &
            "uid=root;" &
            "pwd=1234;"

        connection.Open()
        Return connection
    End Function

    '///---------------------------------------------------------------------------------------------------------------
    'Funciones para obtener los datos de la base de datos y almacenarlos en listas
    Public Function ObtenerUsuarios() As List(Of Usuario)
        Dim connection As Connection = conectar()
        Dim ListaUsuario As New List(Of Usuario)
        Try


            Dim consulta As Recordset = connection.Execute("Select * from usuario")
            Dim fechaBaseDatos As Date
            Dim fechaString As String
            Dim id, nombre, apellido, email, direccion, ci, contraseña, telefono As String

            While (Not consulta.EOF)
                nombre = TryCast(consulta.Fields("Nombre").Value, String)
                apellido = TryCast(consulta.Fields("Apellido").Value, String)
                email = TryCast(consulta.Fields("Email").Value, String)
                id = TryCast(consulta.Fields("ID_US").Value, String)
                direccion = TryCast(consulta.Fields("Direccion").Value, String)
                ci = TryCast(consulta.Fields("CI").Value, String)
                contraseña = TryCast(consulta.Fields("Contraseña").Value, String)
                telefono = TryCast(consulta.Fields("Telefono").Value, String)
                'Este fragmento de codigo obtiene la fecha como objeto y la convierte en un string
                'Con el formato DD/MM/YYYY
                Dim fecha As New StringBuilder()
                Dim caracter As Char
                Dim contador As Integer = 0
                Dim espacio As Boolean = False
                fechaBaseDatos = Convert.ToDateTime(TryCast(consulta.Fields("FDN").Value, Object))
                fechaString = fechaBaseDatos.ToString
                Do
                    caracter = fechaString(contador)

                    If caracter = " " Then
                        espacio = True


                    ElseIf caracter = "/" Then
                        fecha.Append("-")
                    Else
                        fecha.Append(caracter)
                    End If
                    contador = contador + 1
                Loop While (espacio = False)

                ListaUsuario.Add(New Usuario(nombre, apellido, email, id, direccion, ci, contraseña, telefono, fecha.ToString))
                consulta.MoveNext()
            End While
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()
        Return ListaUsuario
    End Function

    Public Function ObtenerPacientes() As List(Of Paciente)
        Dim connection As Connection = conectar()
        Dim ListaPaciente As New List(Of Paciente)
        Dim ListaUsuarios As List(Of Usuario) = ObtenerUsuarios()

        Try
            Dim consulta As Recordset = connection.Execute("Select * from paciente")
            Dim ID As String

            While (Not consulta.EOF)
                ID = TryCast(consulta.Fields("ID_PAC").Value, String)
                For Each paciente As Usuario In ListaUsuarios
                    If (paciente.ID = ID) Then
                        ListaPaciente.Add(New Paciente(paciente.nombre, paciente.apellido, paciente.email, paciente.ID, paciente.Direccion, paciente.CI, paciente.contraseña, paciente.telefono, paciente.fechadenacimiento, ID))
                    End If

                Next

                consulta.MoveNext()
            End While
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()
        Return ListaPaciente
    End Function

    Public Function ObtenerMedicos() As List(Of Medico)
        Dim connection As Connection = conectar()
        Dim ListaMedico As New List(Of Medico)
        Dim ListaUsuario As List(Of Usuario) = ObtenerUsuarios()
        Try
            Dim consulta As Recordset = connection.Execute("Select * from Medico")
            Dim ID As String
            Dim especializacion As String

            While (Not consulta.EOF)
                ID = TryCast(consulta.Fields("ID_MED").Value, String)
                especializacion = TryCast(consulta.Fields("Especializacion").Value, String)
                For Each medico As Usuario In ListaMedico
                    If (medico.ID = ID) Then
                        ListaMedico.Add(New Medico(medico.nombre, medico.apellido, medico.email, medico.ID, medico.Direccion, medico.CI, medico.contraseña, medico.telefono, medico.fechadenacimiento, ID, especializacion))
                    End If

                Next

                consulta.MoveNext()
            End While

        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()
        Return ListaMedico
    End Function

    Public Function ObtenerGestores() As List(Of Gestor)
        Dim connection As Connection = conectar()
        Dim ListaGestor As New List(Of Gestor)
        Dim ListaUsuario As List(Of Usuario) = ObtenerUsuarios()

        Try
            Dim consulta As Recordset = connection.Execute("Select * from Gestor")
            Dim ID, empresa As String
            While (Not consulta.EOF)
                ID = TryCast(consulta.Fields("ID_GES").Value, String)
                empresa = TryCast(consulta.Fields("Empresa").Value, String)
                For Each gestor As Usuario In ListaUsuario
                    If (gestor.ID = ID) Then
                        ListaGestor.Add(New Gestor(gestor.nombre, gestor.apellido, gestor.email, gestor.ID, gestor.Direccion, gestor.CI, gestor.contraseña, gestor.telefono, gestor.fechadenacimiento, ID, empresa))
                    End If
                Next

                consulta.MoveNext()
            End While
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()
        Return ListaGestor
    End Function

    Public Function ObtenerSintoma() As List(Of Sintoma)
        Dim connection As Connection = conectar()
        Dim ListaSintomas As New List(Of Sintoma)
        Try
            Dim consulta As Recordset = connection.Execute("Select * from sintoma")
            Dim nombre, id As String
            While (Not consulta.EOF)
                nombre = TryCast(consulta.Fields("Nombre").Value, String)
                id = TryCast(consulta.Fields("ID_SIN").Value, String)
                ListaSintomas.Add(New Sintoma(nombre, id))
                consulta.MoveNext()
            End While
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()
        Return ListaSintomas
    End Function

    Public Function ObtenerPatologia() As List(Of Patologia)
        Dim connection As Connection = conectar()
        Dim ListaPatologia As New List(Of Patologia)
        Try
            Dim consulta As Recordset = connection.Execute("Select * from patologia")
            Dim nombre, prioridad, id As String
            While (Not consulta.EOF)
                nombre = TryCast(consulta.Fields("Nombre").Value, String)
                prioridad = TryCast(consulta.Fields("Prioridad").Value, String)
                id = TryCast(consulta.Fields("ID_PAT").Value, String)
                ListaPatologia.Add(New Patologia(nombre, prioridad, id))
                consulta.MoveNext()
            End While
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()
        Return ListaPatologia
    End Function

    '-----------------------------------------------------------------------------------------------------------////


    'Funcion de logeo a la aplicacion
    Public Function login(userCI As String, pass As String) As Medico
        Dim connection As Connection = conectar()

        Dim consultaUsuario As Recordset = connection.Execute("Select * from usuario where CI='" + userCI + "';")
        Dim idUser As String = TryCast(consultaUsuario.Fields("ID_US").Value, String)
        Dim pasw As String
        pasw = TryCast(consultaUsuario.Fields("contraseña").Value, String)

        Dim consultaMedico As Recordset = connection.Execute("Select * from medico where ID_MED='" + idUser + "';")
        Dim idMed As String

        idMed = TryCast(consultaMedico.Fields("ID_Med").Value, String)

        If pasw = pass And idMed = idUser Then
            Dim nombre As String = TryCast(consultaUsuario.Fields("nombre").Value, String)
            Dim apellido As String = TryCast(consultaUsuario.Fields("apellido").Value, String)
            Dim email As String = TryCast(consultaUsuario.Fields("email").Value, String)
            Dim direccion As String = TryCast(consultaUsuario.Fields("direccion").Value, String)
            Dim telefono As String = TryCast(consultaUsuario.Fields("telefono").Value, String)
            'Este fragmento de codigo obtiene la fecha como objeto y la convierte en un string
            'Con el formato DD/MM/YYYY
            Dim fecha As New StringBuilder()
            Dim caracter As Char
            Dim contador As Integer = 0
            Dim espacio As Boolean = False
            Dim fechaBaseDatos As Date = Convert.ToDateTime(TryCast(consultaUsuario.Fields("FDN").Value, Object))
            Dim fechaString As String = fechaBaseDatos.ToString
            Do
                caracter = fechaString(contador)

                If caracter = " " Then
                    espacio = True


                ElseIf caracter = "/" Then
                    fecha.Append("-")
                Else
                    fecha.Append(caracter)
                End If
                contador = contador + 1
            Loop While (espacio = False)
            Dim especializacion As String = TryCast(consultaMedico.Fields("Especializacion").Value, String)


            Dim medico As New Medico(nombre, apellido, email, idUser, direccion, userCI, pasw, telefono, fecha.ToString, idMed, especializacion)

            Return medico
        Else
            Throw New Exception("Cedula y/o Contraseña incorrectos.")
        End If
    End Function

    '///-------------------------------------------------------------------------------------------------------------------------------------
    'Funcion de agregar usuarios
    Public Sub agregarPaciente(ByVal ID, ByVal nombre, ByVal apellido, ByVal CI, ByVal Telefono, ByVal direccion, ByVal email, ByVal contraseña, ByVal fechanac)
        Dim connection As Connection = conectar()
        Dim fecha As String = "'" + fechanac + "'"
        Try
            Dim agregarUsuario As Recordset = connection.Execute("insert into Usuario values(""" + nombre + """,""" + apellido + """,""" + email + """,""" + ID + """,""" + direccion + """,""" + CI + """,""" + contraseña + """,""" + Telefono + """," + fecha + ");")
            Dim agregarPaciente As Recordset = connection.Execute("insert into Paciente values (""" + ID + """);")
        Catch ex As Exception
            Console.WriteLine("No se pudieron introducir los datos. Error: " + ex.Message)
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()
    End Sub

    Public Sub agregarmedico(ByVal ID, ByVal nombre, ByVal apellido, ByVal CI, ByVal Telefono, ByVal direccion, ByVal especializacion, ByVal email, ByVal contraseña, ByVal fechanac)
        Dim connection As Connection = conectar()
        Dim fecha As String = "'" + fechanac + "'"
        Try
            Dim agregarUsuario As Recordset = connection.Execute("insert into Usuario values(""" + nombre + """,""" + apellido + """,""" + email + """,""" + ID + """,""" + direccion + """,""" + CI + """,""" + contraseña + """,""" + Telefono + """," + fecha + ");")
            Dim agregarMedico As Recordset = connection.Execute("insert into Medico values (""" + especializacion + """,""" + ID + """);")
        Catch ex As Exception
            Console.WriteLine("No se pudieron introducir los datos. Error: " + ex.Message)
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()
    End Sub

    Public Sub agregarGestor(ByVal ID, ByVal nombre, ByVal apellido, ByVal CI, ByVal Telefono, ByVal direccion, ByVal empresa, ByVal email, ByVal contraseña, ByVal fechanac)
        Dim connection As Connection = conectar()
        Dim fecha As String = "'" + fechanac + "'"
        Try
            Dim agregarUsuario As Recordset = connection.Execute("insert into Usuario values(""" + nombre + """,""" + apellido + """,""" + email + """,""" + ID + """,""" + direccion + """,""" + CI + """,""" + contraseña + """,""" + Telefono + """," + fecha + ");")
            Dim agregarGestor As Recordset = connection.Execute("insert into Gestor values (""" + ID + """,""" + empresa + """);")
        Catch ex As Exception
            Console.WriteLine("No se pudieron introducir los datos. Error: " + ex.Message)
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()
    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------////


End Class
