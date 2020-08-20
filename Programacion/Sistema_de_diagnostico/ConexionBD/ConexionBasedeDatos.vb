Imports System.Text
Imports ADODB


Public Class ConexionBasedeDatos
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


    'Funcion para logearse al sistema, ya sea desde la aplicacion de paciente, medico o gestor
    Public Function login(ByVal usu, ByVal pass, ByVal Identidad)

        Dim connection As Connection = conectar()
        Dim inicio As Boolean = False
        Try
            'Se toman los datos de la tabla CI y Contraseña para verificar que existen

            'consulta, es la sentencia para SQL de busqueda de datos
            Dim consulta As Recordset = connection.Execute("select CI, contraseña, ID_us from usuario where CI= '" + usu + "';")
            Dim id As String = Nothing
            Dim pas As String = Nothing
            Dim Autenticacion As String = Nothing
            Dim Identificador As String = Nothing
            Select Case Identidad
                Case "MED"
                    'Se recorre la columna y se toman los datos de las filas correspondientes
                    While (Not consulta.EOF)
                        id = TryCast(consulta.Fields("CI").Value, String)
                        pas = TryCast(consulta.Fields("contraseña").Value, String)
                        Autenticacion = TryCast(consulta.Fields("ID_us").Value, String)
                        consulta.MoveNext()
                    End While
                    'las variables user y pwd toman los valores que se envian desde el textbox de la aplicacion
                    Dim user = usu
                    Dim pwd = pass
                    Identificador = Autenticacion.Substring(0, 3)
                    Console.WriteLine(Identificador)


                    'Se realiza un if para verificar que lo ingresado en la aplicacion existe en la base de datos
                    If id = usu And pas = pass And Identificador = "MED" Then
                        inicio = True

                    End If

                Case "PAC"

                    'Se recorre la columna y se toman los datos de las filas correspondientes
                    While (Not consulta.EOF)
                        id = TryCast(consulta.Fields("CI").Value, String)
                        pas = TryCast(consulta.Fields("contraseña").Value, String)
                        Autenticacion = TryCast(consulta.Fields("ID_us").Value, String)
                        consulta.MoveNext()
                    End While
                    'las variables user y pwd toman los valores que se envian desde el textbox de la aplicacion
                    Dim user = usu
                    Dim pwd = pass


                    Identificador = Autenticacion.Substring(0, 3)


                    'Se realiza un if para verificar que lo ingresado en la aplicacion existe en la base de datos
                    If id = usu And pas = pass And Identificador = "PAC" Then
                        inicio = True

                    End If
                Case "GES"
                    'Se recorre la columna y se toman los datos de las filas correspondientes
                    While (Not consulta.EOF)
                        id = TryCast(consulta.Fields("CI").Value, String)
                        pas = TryCast(consulta.Fields("contraseña").Value, String)
                        Autenticacion = TryCast(consulta.Fields("ID_us").Value, String)
                        consulta.MoveNext()
                    End While
                    'las variables user y pwd toman los valores que se envian desde el textbox de la aplicacion
                    Dim user = usu
                    Dim pwd = pass
                    Identificador = Autenticacion.Substring(0, 3)
                    Console.WriteLine(Identificador)

                    'Se realiza un if para verificar que lo ingresado en la aplicacion existe en la base de datos
                    If id = usu And pas = pass And Identificador = "GES" Then
                        inicio = True

                    End If
            End Select

        Catch ex As Exception
            Console.WriteLine("El usuario no existe! " & ex.Message)
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()
        Return inicio
    End Function

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Inicio de funciones para el sistema


    'Funcion para generar codigos random y que no se repitan en la base de datos
    Public Function codigoRandom(ByVal id, ByVal num) As String

        Dim connection As Connection = conectar()

        Dim codigoRandoms As String = Nothing
        Dim consulta As Recordset
        Dim idConsulta As String

        Try
            Select Case num
                Case 0
                    consulta = connection.Execute("select ID_SIN from Sintoma ;")
                    idConsulta = TryCast(consulta.Fields("id_sin").Value, String)
                Case 1
                    consulta = connection.Execute("select ID_MED from Medico ;")
                    idConsulta = TryCast(consulta.Fields("id_MED").Value, String)
                Case 2
                    consulta = connection.Execute("select ID_Pat from Patologia ;")
                    idConsulta = TryCast(consulta.Fields("id_Pat").Value, String)
                Case 3
                    consulta = connection.Execute("select ID_Pac from Paciente ;")
                    idConsulta = TryCast(consulta.Fields("id_Pac").Value, String)
                Case 4
                    consulta = connection.Execute("select ID_ges from Gestor ;")
                    idConsulta = TryCast(consulta.Fields("id_ges").Value, String)
            End Select


            Dim idsin As String = id
            Do

                Dim letrasvalidas As String = "ABCDEFGHIJKMNOPQRSTUVWXYZ"
                Dim numerosvalidos As String = "0123456789"
                Dim sb As New StringBuilder()
                Dim random As New Random

                Dim primeraletra As Char = id(0)
                sb.Append(primeraletra)
                Dim segundaletra As Char = id(1)
                sb.Append(segundaletra)
                Dim terceraletra As Char = id(2)
                sb.Append(terceraletra)


                sb.Append("-")
                For a As Integer = 1 To 3
                    Dim indice As Integer = random.Next(0, letrasvalidas.Length)
                    Dim randomchar As Char = letrasvalidas(indice)
                    sb.Append(randomchar)
                Next a
                sb.Append("-")
                For b As Integer = 1 To 3
                    Dim indice As Integer = random.Next(0, numerosvalidos.Length)
                    Dim randomchar As Char = numerosvalidos(indice)
                    sb.Append(randomchar)
                Next b

                codigoRandoms = sb.ToString()

                If codigoRandoms = idConsulta Then

                    Dim letrasvalidas2 As String = "ABCDEFGHIJKMNOPQRSTUVWXYZ"
                    Dim numerosvalidos2 As String = "0123456789"
                    Dim sb2 As New StringBuilder()

                    Dim primeraletra2 As Char = id(0)
                    sb2.Append(primeraletra)
                    Dim segundaletra2 As Char = id(1)
                    sb2.Append(segundaletra)
                    Dim terceraletra2 As Char = id(2)
                    sb2.Append(terceraletra)

                    sb2.Append("-")
                    For a As Integer = 1 To 3
                        Dim indice As Integer = random.Next(0, letrasvalidas.Length)
                        Dim randomchar As Char = letrasvalidas(indice)
                        sb2.Append(randomchar)
                    Next a
                    sb2.Append("-")
                    For b As Integer = 1 To 3
                        Dim indice As Integer = random.Next(0, numerosvalidos.Length)
                        Dim randomchar As Char = numerosvalidos(indice)
                        sb2.Append(randomchar)
                    Next b
                    codigoRandoms = sb2.ToString()
                End If
                consulta.MoveNext()
            Loop While (Not consulta.EOF)




        Catch ex As Exception
            Console.WriteLine("El codigo no se pudo realizar:  " & ex.Message)
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()
        Return codigoRandoms
    End Function

    'Funcion para agregar medicos a la base de datos
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

    'Funcion para agregar medicos a la base de datos
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

    '////-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Funciones unicamente para el ABM de sintomas


    'Funcion para conseguir todos los nombres de los sintomas cargados a la base de datos
    Public Function cargarSintomas()
        Dim connection As Connection = conectar()
        Try
            'Se crea una lista para contener todos los sintomas
            Dim listasintoma As New List(Of String)
            Dim sintoma As String


            'Sentencia de busqueda para Mysql
            Dim consulta As Recordset = conectar.Execute("select nombre,id_sin from sintoma ;")

            'Recorre la consulta hecha por columna y se agrega cada fila a la lista
            While (Not consulta.EOF)
                sintoma = TryCast(consulta.Fields("nombre").Value, String)

                listasintoma.Add(sintoma)

                consulta.MoveNext()
            End While
            'Retorna la lista para su posterior uso
            Return listasintoma
        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()


    End Function


    'Funcion para conseguir todos los nombres de los sintomas cargados a la base de datos
    Public Function cargarPatologia()

        'Se crea una lista para contener todos los sintomas
        Dim listasintoma As New List(Of String)
        Dim sintoma As String
        Dim connection As Connection = conectar()

        'Sentencia de busqueda para Mysql
        Dim consulta As Recordset = conectar.Execute("select nombre,id_pat from patologia ;")

        'Recorre la consulta hecha por columna y se agrega cada fila a la lista
        While (Not consulta.EOF)

            sintoma = TryCast(consulta.Fields("nombre").Value, String)

            listasintoma.Add(sintoma)

            consulta.MoveNext()
        End While
        connection.Close()
        'Retorna la lista para su posterior uso
        Return listasintoma
    End Function


    '//-------------------------------------------------------------------------------------------------------------
    'Estas 2 funciones sirven para agregar un sintoma a la base de datos, y referenciarla a una patologia.
    Public Sub agregarSintoma(ByVal ID, ByVal nombre)
        Dim connection As Connection = conectar()

        Dim agregar As Recordset = connection.Execute("insert into sintoma values(""" + nombre + """,""" + ID + """);")
        connection.Close()
    End Sub

    Public Sub agregarRefSintomaPatologia(ByVal ID, ByVal nombrePat)
        Dim connection As Connection = conectar()
        Try
            Dim IDsin As String = obtenerIDSintoma(ID)
            Dim consulta As Recordset = connection.Execute("select * from patologia where nombre=" + "'" + nombrePat + "';")
            Dim idpat As String = TryCast(consulta.Fields("ID_Pat").Value, String)

            Dim agregarPertenencia As Recordset = connection.Execute("insert into tiene values(""" + idpat + """,""" + IDsin + """);")
        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            MsgBox("Error: " + ex.Message)
        End Try

        connection.Close()

    End Sub
    ''---------------------------------------------------------------------------------------------------//

    'Funcion para obtener la ID de cualquier sintoma, mediante su nombre en la base de datos.
    Public Function obtenerIDSintoma(ByVal nom) As String
        Dim connection As Connection = conectar()
        Dim consulta As Recordset
        Dim id As String = Nothing

        Try
            consulta = connection.Execute("Select ID_Sin from sintoma where nombre= " + "'" + nom + "'")
            id = TryCast(consulta.Fields("ID_Sin").Value, String)

        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            MsgBox("Error: " + ex.Message)

        End Try
        connection.Close()
        Return id

    End Function





    'Funcion para obtener las patologias asociadas a un sintoma, mediante el nombre del sintoma
    Public Function obtenerRefSintoma(ByVal nom)
        Dim connection As Connection = conectar()
        Dim listaRefSint As New List(Of String)
        Dim consulta As Recordset
        Dim referencia As String
        Try

            consulta = connection.Execute(" select patologia.nombre 'Patologia' " &
                                            "from patologia " &
                                            "inner join tiene on " &
                                            "tiene.id_pat=patologia.id_pat " &
                                            "inner join sintoma on " &
                                            "tiene.id_sin=sintoma.id_sin " &
                                            "where sintoma.nombre = '" + nom + "';")

            While (Not consulta.EOF)

                referencia = TryCast(consulta.Fields(0).Value, String)

                listaRefSint.Add(referencia)

                consulta.MoveNext()

            End While

        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            MsgBox("Error: " + ex.Message)
        End Try

        connection.Close()
        Return listaRefSint
    End Function

    'Funcion para eliminar la asociacion de una patologia con un sintoma
    Public Sub eliminarReferenciaSintomaPatologia(ByVal nomSintoma, ByVal nomPatologia)
        Dim connection As Connection = conectar()
        Try
            Dim IDSintoma As String = obtenerIDSintoma(nomSintoma)
            Dim IDPatologia As String = obtenerIDPatologia(nomPatologia)

            Dim eliminar As Recordset = connection.Execute("delete from tiene " +
                                                       "where ID_Sin = '" + IDSintoma + "' And ID_pat = '" + IDPatologia + "';")
        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            MsgBox("Error: " + ex.Message)
        End Try
        connection.Close()
    End Sub

    'Funcion para cambiar el nombre de un sintoma.
    Public Sub actualizarNombreSintoma(ByVal ID, ByVal nom)
        Dim connection As Connection = conectar()
        Dim actualizar As Recordset = connection.Execute("UPDATE sintoma set nombre = '" + nom + "' where id_sin = '" + ID + "';")
        connection.Close()
    End Sub

    'Funcion para eliminar un sintoma.
    Public Sub eliminarSintoma(ByVal nom)
        Dim connection As Connection = conectar()
        Dim IDsintoma As String = obtenerIDSintoma(nom)
        Dim eliminarRef As Recordset = connection.Execute("delete from tiene where id_sin = '" + IDsintoma + "';")
        Dim eliminarSintoma As Recordset = connection.Execute("delete from sintoma where id_sin = '" + IDsintoma + "';")
        connection.Close()
    End Sub

    '////-----------------------------------------------------------------------------------------------------------------------------
    'Funciones para el ABM de patologias


    'Funcion para agregar patologias
    Public Sub agregarPatologia(ByVal ID, ByVal nombre, ByVal prioridad)
        Dim connection As Connection = conectar()

        Dim agregar As Recordset = connection.Execute("insert into Patologia values('" + nombre + "','" + prioridad + "','" + ID + "');")
        connection.Close()
    End Sub

    'Funcion para obtener la ID de cualquier patologia, mediante su nombre en la base de datos.
    Public Function obtenerIDPatologia(ByVal nom) As String
        Dim connection As Connection = conectar()
        Dim consulta As Recordset
        Dim id As String = Nothing

        Try
            consulta = connection.Execute("Select ID_Pat from patologia where nombre= " + "'" + nom + "'")
            id = TryCast(consulta.Fields("ID_Pat").Value, String)

        Catch ex As Exception
            Console.WriteLine("Error: " + ex.Message)
            MsgBox("Error: " + ex.Message)

        End Try
        connection.Close()
        Return id
    End Function

    'Funcion para obtener el valor de la prioridad de una patologia
    Public Function obtenerPrioridadPatologia(ByVal nom) As Integer
        Dim connection As Connection = conectar()
        Dim consulta As Recordset
        Dim ID As String = obtenerIDPatologia(nom)
        Dim prioridad As Integer
        Try
            consulta = connection.Execute("select prioridad from patologia where id_pat =" + "'" + ID + "'")
            prioridad = Convert.ToInt32(TryCast(consulta.Fields("prioridad").Value, String))


        Catch ex As Exception

        End Try
        connection.Close()
        Return prioridad
    End Function


    'Funcion para cambiar el nombre de una patologia.
    Public Sub actualizarNombrePatologia(ByVal ID, ByVal nom)
        Dim connection As Connection = conectar()
        Dim actualizar As Recordset = connection.Execute("UPDATE patologia set nombre = '" + nom + "' where id_pat = '" + ID + "';")
        connection.Close()
    End Sub

    'Funcion para cambiar la prioridad de una patologia
    Public Sub actualizarPrioridadPatologia(ByVal ID, ByVal prioridad)
        Dim connection As Connection = conectar()
        Dim actualizar As Recordset = connection.Execute("UPDATE patologia set prioridad = '" + prioridad + "' where id_pat = '" + ID + "';")
        connection.Close()
    End Sub

    'Funcion para eliminar una Patologia.
    Public Sub eliminarPatologia(ByVal nom)
        Dim connection As Connection = conectar()
        Dim IDPatologia As String = obtenerIDPatologia(nom)
        Dim eliminarRef As Recordset = connection.Execute("delete from tiene where id_pat = '" + IDPatologia + "';")
        Dim eliminarSintoma As Recordset = connection.Execute("delete from patologia where id_pat = '" + IDPatologia + "';")
        connection.Close()
    End Sub


    '////------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Inicio de funciones para aplicacion Paciente

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

    '///------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Funcion para obtener diagnostico (esta sujeto a cambios)
    'Todavia no esta terminado
    Public Function prueba(ByVal lista)
        Dim connection As Connection = conectar()
        Dim cadena As New StringBuilder()
        Dim consulta As String = "select p.Nombre " +
                                 "from sintoma s inner join tiene t on s.id_sin=t.id_sin " +
                                 "inner join patologia p on t.id_pat=p.id_pat " +
                                 "where"
        cadena.Append(consulta)
        Dim listanom As New List(Of String)
        listanom.AddRange(lista)
        Dim primero As Boolean = True
        For Each nombre As String In listanom
            If Not primero Then
                cadena.Append(" OR")
            End If
            primero = False
            cadena.Append(" s.Nombre= '" + nombre + "'")

        Next
        cadena.Append(" ;")


        Try
            '   Dim consultaBD As Recordset = connection.Execute(consultaFinal)
        Catch ex As Exception

        End Try
        connection.Close()
        Return Nothing
    End Function
End Class
