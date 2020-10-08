Imports ADODB, Datos, System.Text
Public Class ConexionConBD

    'Funcion para conectarse a la base de datos
    Private Function conectar() As Connection
        Dim connection As New Connection
        connection.ConnectionString = "" &
            "driver={MySQL ODBC 8.0 Unicode Driver};" &
            "server=127.0.0.1;" &
            "port=3306;" &
            "database=proyecto_prueba;" &
            "uid=root;" &
            "pwd=1234;"

        connection.Open()
        Return connection
    End Function

    '///---------------------------------------------------------------------------------------------------------------
    'Funciones para obtener los datos de la base de datos y almacenarlos en listas

    Public Function ObtenerPacientes() As List(Of Paciente)
        Dim connection As Connection = conectar()
        Dim ListaPaciente As New List(Of Paciente)
        Dim fechaBaseDatos As Date
        Dim fechaString As String
        Dim id, nombre, segundonombre, apellido, segundoapellido, email, direccion, ci, contraseña, telefono, peso, altura, patologiaprevia As String
        Dim consulta As Recordset = connection.Execute("select * " +
                                                       "from usuario inner join paciente " +
                                                       "on usuario.id_us = paciente.id_pac;")

        While (Not consulta.EOF)

            id = TryCast(consulta.Fields("ID_us").Value, String)
            nombre = TryCast(consulta.Fields("Nombre").Value, String)

            apellido = TryCast(consulta.Fields("Apellido").Value, String)

            email = TryCast(consulta.Fields("Email").Value, String)
            direccion = TryCast(consulta.Fields("Direccion").Value, String)
            ci = TryCast(consulta.Fields("CI").Value, String)
            contraseña = TryCast(consulta.Fields("Contraseña").Value, String)
            telefono = TryCast(consulta.Fields("Telefono").Value, String)
            fechaBaseDatos = TryCast(consulta.Fields("FDN").Value, Object)
            fechaString = Format(fechaBaseDatos, "yyyy/MM/dd")
            peso = TryCast(consulta.Fields("peso").Value, String)
            altura = DirectCast(consulta.Fields("altura").Value, Double)
            patologiaprevia = TryCast(consulta.Fields("patologiasp").Value, String)
            segundonombre = TryCast(consulta.Fields("segundo_nombre").Value, String)
            segundoapellido = TryCast(consulta.Fields("segundo_apellido").Value, String)

            ListaPaciente.Add(New Paciente(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fechaString, peso, altura.ToString, patologiaprevia))

            consulta.MoveNext()
        End While

        connection.Close()
        Return ListaPaciente
    End Function

    Public Function ObtenerMedicos() As List(Of Medico)
        Dim connection As Connection = conectar()
        Dim ListaMedico As New List(Of Medico)

        Dim fechaBaseDatos As Date
        Dim fechaString As String
        Dim id, nombre, segundonombre, apellido, segundoapellido, email, direccion, ci, contraseña, telefono, especializacion, lugardetrabajo As String

        Dim consulta As Recordset = connection.Execute("select * " +
                                                       "from usuario inner join medico " +
                                                       "on usuario.id_us = medico.id_med;")

        While (Not consulta.EOF)
            id = TryCast(consulta.Fields("ID_us").Value, String)
            nombre = TryCast(consulta.Fields("Nombre").Value, String)
            apellido = TryCast(consulta.Fields("Apellido").Value, String)
            email = TryCast(consulta.Fields("Email").Value, String)
            direccion = TryCast(consulta.Fields("Direccion").Value, String)
            ci = TryCast(consulta.Fields("CI").Value, String)
            contraseña = TryCast(consulta.Fields("Contraseña").Value, String)
            telefono = TryCast(consulta.Fields("Telefono").Value, String)
            fechaBaseDatos = TryCast(consulta.Fields("FDN").Value, Object)
            fechaString = Format(fechaBaseDatos, "yyyy/MM/dd")
            especializacion = TryCast(consulta.Fields("Especializacion").Value, String)
            segundonombre = TryCast(consulta.Fields("segundo_nombre").Value, String)
            segundoapellido = TryCast(consulta.Fields("segundo_apellido").Value, String)
            lugardetrabajo = TryCast(consulta.Fields("Lugar_de_trabajo").Value, String)
            ListaMedico.Add(New Medico(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fechaString, especializacion, lugardetrabajo))

            consulta.MoveNext()
        End While


        connection.Close()
        Return ListaMedico
    End Function

    Public Function ObtenerGestores() As List(Of Gestor)
        Dim connection As Connection = conectar()
        Dim ListaGestor As New List(Of Gestor)
        Dim fechaBaseDatos As Date
        Dim fechaString As String
        Dim id, nombre, segundonombre, apellido, segundoapellido, email, direccion, ci, contraseña, telefono, empresa As String

        Dim consulta As Recordset = connection.Execute("select * " +
                                                       "from usuario inner join gestor " +
                                                       "on usuario.id_us = gestor.id_ges;")
        While (Not consulta.EOF)
            id = TryCast(consulta.Fields("ID_us").Value, String)
            nombre = TryCast(consulta.Fields("Nombre").Value, String)
            apellido = TryCast(consulta.Fields("Apellido").Value, String)
            email = TryCast(consulta.Fields("Email").Value, String)
            direccion = TryCast(consulta.Fields("Direccion").Value, String)
            ci = TryCast(consulta.Fields("CI").Value, String)
            contraseña = TryCast(consulta.Fields("Contraseña").Value, String)
            telefono = TryCast(consulta.Fields("Telefono").Value, String)
            fechaBaseDatos = TryCast(consulta.Fields("FDN").Value, Object)
            fechaString = Format(fechaBaseDatos, "yyyy/MM/dd")
            empresa = TryCast(consulta.Fields("Empresa").Value, String)
            segundonombre = TryCast(consulta.Fields("segundo_nombre").Value, String)
            segundoapellido = TryCast(consulta.Fields("segundo_apellido").Value, String)
            ListaGestor.Add(New Gestor(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fechaString, empresa))

            consulta.MoveNext()
        End While

        connection.Close()
        Return ListaGestor
    End Function

    Public Function ObtenerSintoma() As List(Of Sintoma)
        Dim connection As Connection = conectar()
        Dim ListaSintomas As New List(Of Sintoma)

        Dim consulta As Recordset = connection.Execute("Select * from sintoma")
            Dim nombre, id As String
            While (Not consulta.EOF)
                nombre = TryCast(consulta.Fields("Nombre").Value, String)
                id = TryCast(consulta.Fields("ID_SIN").Value, String)
                ListaSintomas.Add(New Sintoma(nombre, id))
                consulta.MoveNext()
            End While

            connection.Close()
        Return ListaSintomas
    End Function

    Public Function ObtenerPatologia() As List(Of Patologia)
        Dim connection As Connection = conectar()
        Dim ListaPatologia As New List(Of Patologia)

        Dim consulta As Recordset = connection.Execute("Select * from patologia")
            Dim nombre, prioridad, id As String
            While (Not consulta.EOF)
                nombre = TryCast(consulta.Fields("Nombre").Value, String)
                prioridad = TryCast(consulta.Fields("Prioridad").Value, String)
                id = TryCast(consulta.Fields("ID_PAT").Value, String)
                ListaPatologia.Add(New Patologia(nombre, prioridad, id))
                consulta.MoveNext()
            End While

            connection.Close()
        Return ListaPatologia
    End Function




    Public Function ObtenerReferenciaSintomaPatologia(ID As String) As List(Of Patologia)
        Dim connection As Connection = conectar()
        Dim listaReferencias As New List(Of Patologia)

        Dim consulta As Recordset = Connection.Execute("Select patologia.nombre, patologia.id_pat, patologia.prioridad " &
                                                        "from patologia inner join tiene on tiene.id_pat=patologia.id_pat " &
                                                        "inner join sintoma on tiene.id_sin=sintoma.id_sin " &
                                                        "where sintoma.id_sin = '" & ID & "';")
        Dim nombre, IDpatologia, prioridad As String
        While (Not consulta.EOF)
            IDpatologia = TryCast(consulta.Fields("ID_pat").Value, String)
            nombre = TryCast(consulta.Fields("nombre").Value, String)
            prioridad = TryCast(consulta.Fields("prioridad").Value, String)
            listaReferencias.Add(New Patologia(nombre, prioridad, IDpatologia))
            consulta.MoveNext()
        End While
        Connection.Close()
        Return listaReferencias
    End Function


    Public Function ObtenerRefenciaPatologiaSintoma(ID As String) As List(Of Sintoma)
        Dim connection As Connection = conectar()
        Dim listaReferencias As New List(Of Sintoma)
        Dim consulta As Recordset = connection.Execute("Select sintoma.nombre, sintoma.id_sin " &
                                                        "from patologia inner join tiene on tiene.id_pat=patologia.id_pat " &
                                                        "inner join sintoma on tiene.id_sin=sintoma.id_sin " &
                                                        "where patologia.id_pat = '" & ID & "';")
        Dim nombre, IDsintoma As String
        While (Not consulta.EOF)
            nombre = TryCast(consulta.Fields("nombre").Value, String)
            IDsintoma = TryCast(consulta.Fields("id_sin").Value, String)
            listaReferencias.Add(New Sintoma(nombre, IDsintoma))
            consulta.MoveNext()
        End While
        connection.Close()
        Return listaReferencias
    End Function
    '-----------------------------------------------------------------------------------------------------------////
    'Funcion de logeo a la aplicacion


    Public Function loginMedico(userCI As String, pass As String) As Medico
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
            Dim fechaBaseDatos As Date = TryCast(consultaUsuario.Fields("FDN").Value, Object)
            Dim fechaString As String = Format(fechaBaseDatos, "yyyy/MM/dd")
            Dim especializacion As String = TryCast(consultaMedico.Fields("Especializacion").Value, String)
            Dim segundonombre = TryCast(consultaUsuario.Fields("segundo_nombre").Value, String)
            Dim segundoapellido = TryCast(consultaUsuario.Fields("segundo_apellido").Value, String)
            Dim lugardetrabajo = TryCast(consultaMedico.Fields("Lugar_de_trabajo").Value, String)

            Dim medico As New Medico(nombre, segundonombre, apellido, segundoapellido, email, idUser, direccion, userCI, pasw, telefono, fechaString, especializacion, lugardetrabajo)
            connection.Close()
            Return medico
        Else
            connection.Close()
            Throw New Exception("Cedula y/o Contraseña incorrectos.")
        End If
    End Function

    Public Function loginPaciente(userCI As String, pass As String) As Paciente
        Dim connection As Connection = conectar()

        Dim consultaUsuario As Recordset = connection.Execute("Select * from usuario where CI='" + userCI + "';")
        Dim idUser As String = TryCast(consultaUsuario.Fields("ID_US").Value, String)
        Dim pasw As String
        pasw = TryCast(consultaUsuario.Fields("contraseña").Value, String)

        Dim consultaPaciente As Recordset = connection.Execute("Select * from paciente where ID_PAC='" + idUser + "';")
        Dim idPac As String

        idPac = TryCast(consultaPaciente.Fields("ID_PAC").Value, String)

        If pasw = pass And idPac = idUser Then
            Dim nombre As String = TryCast(consultaUsuario.Fields("nombre").Value, String)
            Dim apellido As String = TryCast(consultaUsuario.Fields("apellido").Value, String)
            Dim email As String = TryCast(consultaUsuario.Fields("email").Value, String)
            Dim direccion As String = TryCast(consultaUsuario.Fields("direccion").Value, String)
            Dim telefono As String = TryCast(consultaUsuario.Fields("telefono").Value, String)
            Dim fechaBaseDatos As Date = Convert.ToDateTime(TryCast(consultaUsuario.Fields("FDN").Value, Object))
            Dim fechaString As String = Format(fechaBaseDatos, "yyyy/MM/dd")
            Dim peso = TryCast(consultaPaciente.Fields("peso").Value, String)
            Dim altura = DirectCast(consultaPaciente.Fields("altura").Value, Double)
            Dim patologiaprevia = TryCast(consultaPaciente.Fields("patologiasp").Value, String)
            Dim segundonombre = TryCast(consultaUsuario.Fields("segundo_nombre").Value, String)
            Dim segundoapellido = TryCast(consultaUsuario.Fields("segundo_apellido").Value, String)

            Dim paciente As New Paciente(nombre, segundonombre, apellido, segundoapellido, email, idUser, direccion, userCI, pasw, telefono, fechaString, peso, altura.ToString, patologiaprevia)
            connection.Close()
            Return paciente
        Else
            connection.Close()
            Throw New Exception("Cedula y/o Contraseña incorrectos.")
        End If
    End Function

    Public Function loginGestor(userCI As String, pass As String) As Gestor
        Dim connection As Connection = conectar()

        Dim consultaUsuario As Recordset = connection.Execute("Select * from usuario where CI='" + userCI + "';")
        Dim idUser As String = TryCast(consultaUsuario.Fields("ID_US").Value, String)
        Dim pasw As String
        pasw = TryCast(consultaUsuario.Fields("contraseña").Value, String)

        Dim consultaGestor As Recordset = connection.Execute("Select * from gestor where ID_GES='" + idUser + "';")
        Dim idGes As String

        idGes = TryCast(consultaGestor.Fields("ID_GES").Value, String)

        If pasw = pass And idGes = idUser Then
            Dim nombre As String = TryCast(consultaUsuario.Fields("nombre").Value, String)
            Dim apellido As String = TryCast(consultaUsuario.Fields("apellido").Value, String)
            Dim email As String = TryCast(consultaUsuario.Fields("email").Value, String)
            Dim direccion As String = TryCast(consultaUsuario.Fields("direccion").Value, String)
            Dim telefono As String = TryCast(consultaUsuario.Fields("telefono").Value, String)
            Dim fechaBaseDatos As Date = Convert.ToDateTime(TryCast(consultaUsuario.Fields("FDN").Value, Object))
            Dim fechaString As String = Format(fechaBaseDatos, "yyyy/MM/dd")
            Dim empresa As String = TryCast(consultaGestor.Fields("empresa").Value, String)
            Dim segundonombre = TryCast(consultaUsuario.Fields("segundo_nombre").Value, String)
            Dim segundoapellido = TryCast(consultaUsuario.Fields("segundo_apellido").Value, String)
            Dim gestor As New Gestor(nombre, segundonombre, apellido, segundoapellido, email, idUser, direccion, userCI, pasw, telefono, fechaString, empresa)
            connection.Close()
            Return gestor

        Else
            connection.Close()
            Throw New Exception("Cedula y/o Contraseña incorrectos.")
        End If
    End Function



    '///-------------------------------------------------------------------------------------------------------------------------------------
    'Funcion de agregar datos (sintomas, patologias, usuarios)
    Public Sub agregarPaciente(paciente As Paciente)
        Dim connection As Connection = conectar()

        Dim agregarUsuario As Recordset = connection.Execute("insert into Usuario values('" + paciente.nombre + "','" + paciente.apellido + "','" + paciente.email + "','" + paciente.ID + "','" + paciente.Direccion + "','" + paciente.CI + "','" + paciente.contraseña + "','" + paciente.telefono + "','" + paciente.fechadenacimiento + "','" + paciente.segundonombre + "','" + paciente.segundoapellido + "');")
        Dim agregarPaciente As Recordset = connection.Execute("insert into Paciente values ('" + paciente.ID + "'" + paciente.peso + "" + paciente.altura + "" + paciente.patologiaPrevia + ");")

        connection.Close()
    End Sub

    Public Sub agregarMedico(medico As Medico)
        Dim connection As Connection = conectar()
        Dim agregarUsuario As Recordset = connection.Execute("insert into Usuario values('" + medico.nombre + "','" + medico.apellido + "','" + medico.email + "','" + medico.ID + "','" + medico.Direccion + "','" + medico.CI + "','" + medico.contraseña + "','" + medico.telefono + "','" + medico.fechadenacimiento + "','" + medico.segundonombre + "','" + medico.segundoapellido + "');")
        Dim agregarMedico As Recordset = connection.Execute("insert into Medico values ('" + medico.especializacion + "','" + medico.ID + "','" + medico.lugarDeTrabajo + "');")

        connection.Close()
    End Sub

    Public Sub agregarGestor(gestor As Gestor)
        Dim connection As Connection = conectar()
        Dim agregarUsuario As Recordset = connection.Execute("insert into Usuario values('" + gestor.nombre + "','" + gestor.apellido + "','" + gestor.email + "','" + gestor.ID + "','" + gestor.Direccion + "','" + gestor.CI + "','" + gestor.contraseña + "','" + gestor.telefono + "','" + gestor.fechadenacimiento + "','" + gestor.segundonombre + "','" + gestor.segundoapellido + "');")
        Dim agregarGestor As Recordset = connection.Execute("insert into Gestor values (""" + gestor.ID + """,""" + gestor.empresa + """);")



        connection.Close()
    End Sub

    Public Sub agregarSintoma(sintoma As Sintoma)
        Dim connection As Connection = conectar()

        Dim agregar As Recordset = connection.Execute("insert into sintoma values(""" + sintoma.nombre + """,""" + sintoma.id + """);")
        connection.Close()
    End Sub

    Public Sub agregarPatologia(patologia As Patologia)
        Dim connection As Connection = conectar()

        Dim agregar As Recordset = connection.Execute("insert into patologia values('" + patologia.nombre + "','" + patologia.prioridad + "','" + patologia.id + "');")
        connection.Close()
    End Sub

    Public Sub agregarSintomaDePatologia(IDSintoma As String, IDPatologia As String)
        Dim connection As Connection = conectar()

        Dim agregar As Recordset = connection.Execute("insert into tiene values ('" + IDPatologia + "','" + IDSintoma + "');")
        connection.Close()

    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------////

    '////-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Funcion para eliminar datos de la base de datos (usuarios, sintomas, patologias)

    Public Sub eliminarPaciente(ID As String)
        Dim connection As Connection = conectar()
        Dim eliminarPaciente As Recordset = connection.Execute("delete from paciente where id_pac = '" + ID + "';")
        Dim eliminarUsuario As Recordset = connection.Execute("delete from usuario where id_us = '" + ID + "';")
        connection.Close()
    End Sub

    Public Sub eliminarMedico(ID As String)
        Dim connection As Connection = conectar()
        Dim eliminarMedico As Recordset = connection.Execute("delete from medico where id_med = '" + ID + "';")
        Dim eliminarUsuario As Recordset = connection.Execute("delete from usuario where id_us = '" + ID + "';")
        connection.Close()
    End Sub

    Public Sub eliminarGestor(ID As String)
        Dim connection As Connection = conectar()
        Dim eliminarGestor As Recordset = connection.Execute("delete from gestor where id_ges = '" + ID + "';")
        Dim eliminarUsuario As Recordset = connection.Execute("delete from usuario where id_us = '" + ID + "';")
        connection.Close()
    End Sub

    Public Sub eliminarSintoma(ID As String)
        Dim connection As Connection = conectar()
        Dim eliminarRef As Recordset = connection.Execute("delete from tiene where id_sin = '" + ID + "';")
        Dim eliminarSintoma As Recordset = connection.Execute("delete from sintoma where id_sin = '" + ID + "';")
        connection.Close()
    End Sub

    Public Sub eliminarPatologia(ID As String)
        Dim connection As Connection = conectar()
        Dim eliminarRef As Recordset = connection.Execute("delete from tiene where id_pat = '" + ID + "';")
        Dim eliminarPatologia As Recordset = connection.Execute("delete from patologia where id_pat = '" + ID + "';")
        connection.Close()
    End Sub

    Public Sub eliminarReferenciaPatologiaSintoma(IDsin As String, IDpat As String)
        Dim connection As Connection = conectar()
        Dim eliminarRef As Recordset = connection.Execute("delete from tiene where ID_Sin = '" + IDsin + "' And ID_pat = '" + IDpat + "';")
        connection.Close()
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------------------------------/////


    '////------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Funcion para modificar datos

    Public Sub actualizarSintoma(sintoma As Sintoma)
        Dim connection As Connection = conectar()
        Dim actualizar As Recordset = connection.Execute("UPDATE sintoma set nombre = '" + sintoma.nombre + "' where id_sin = '" + sintoma.id + "';")
        connection.Close()
    End Sub

    Public Sub actualizarPatologia(patologia As Patologia)
        Dim connection As Connection = conectar()
        Dim actualizar As Recordset = connection.Execute("UPDATE patologia set nombre = '" + patologia.nombre + "', prioridad ='" + patologia.prioridad + "' where id_pat = '" + patologia.id + "';")
        connection.Close()
    End Sub


    Public Sub actualizarMedico(medico As Medico)
        Dim connection As Connection = conectar()
        Dim actualizarUsuario As Recordset = connection.Execute("UPDATE usuario set nombre = '" + medico.nombre + "', apellido = '" + medico.apellido + "', email = '" + medico.email + "', direccion = '" + medico.Direccion + "', ci = '" + medico.CI + "', contraseña= '" + medico.contraseña + "', telefono ='" + medico.telefono + "', FDN ='" + medico.fechadenacimiento + "', segundo_nombre ='" + medico.segundonombre + "', segundo_apellido= '" + medico.segundoapellido + "' where id_us ='" + medico.ID + ";")
        Dim actualizarMedico As Recordset = connection.Execute("UPDATE medico set especializacion ='" + medico.especializacion + "', Lugar_de_trabajo ='" + medico.lugarDeTrabajo + "' where id_med ='" + medico.ID + "';")
        connection.Close()
    End Sub

    Public Sub actualizarPaciente(paciente As Paciente)
        Dim connection As Connection = conectar()
        Dim actualizarUsuario As Recordset = connection.Execute("UPDATE usuario set nombre = '" + paciente.nombre + "', apellido = '" + paciente.apellido + "', email = '" + paciente.email + "', direccion = '" + paciente.Direccion + "', ci = '" + paciente.CI + "', contraseña= '" + paciente.contraseña + "', telefono ='" + paciente.telefono + "', FDN ='" + paciente.fechadenacimiento + "', segundo_nombre= '" + paciente.segundonombre + "', segundo_apellido= '" + paciente.segundoapellido + " where id_us ='" + paciente.ID + "';")
        Dim actualizarPaciente As Recordset = connection.Execute("UPDATE paciente set peso = '" + paciente.peso + "', altura = '" + paciente.altura + "', Patologiasp = '" + paciente.patologiaPrevia + "' where id_pat = '" + paciente.ID + "';")
        connection.Close()
    End Sub

    Public Sub actualizarGestor(gestor As Gestor)
        Dim connection As Connection = conectar()
        Dim actualizarUsuario As Recordset = connection.Execute("UPDATE usuario set nombre = '" + gestor.nombre + "', apellido = '" + gestor.apellido + "', email = '" + gestor.email + "', direccion = '" + gestor.Direccion + "', ci = '" + gestor.CI + "', contraseña= '" + gestor.contraseña + "', telefono ='" + gestor.telefono + "', FDN ='" + gestor.fechadenacimiento + "', segundo_nombre= '" + gestor.segundonombre + "', segundo_apellido = '" + gestor.segundoapellido + "' where id_us ='" + gestor.ID + "';")
        Dim actualizarMedico As Recordset = connection.Execute("UPDATE gestor set empresa ='" + gestor.empresa + "' where id_ges ='" + gestor.ID + "';")
        connection.Close()
    End Sub


    '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------////



    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------////
    Public Function codigoRandom(num As Integer) As String

        Dim connection As Connection = conectar()

        Dim codigoRandoms As String = Nothing
        Dim consulta As Recordset
        Dim idConsulta As String
        Dim id As String

        Select Case num
            Case 0
                consulta = connection.Execute("select ID_SIN from Sintoma ;")
                idConsulta = TryCast(consulta.Fields("id_sin").Value, String)
                id = "SIN"
            Case 1
                consulta = connection.Execute("select ID_MED from Medico ;")
                idConsulta = TryCast(consulta.Fields("id_MED").Value, String)
                id = "MED"
            Case 2
                consulta = connection.Execute("select ID_Pat from Patologia ;")
                idConsulta = TryCast(consulta.Fields("id_Pat").Value, String)
                id = "PAT"
            Case 3
                consulta = connection.Execute("select ID_Pac from Paciente ;")
                idConsulta = TryCast(consulta.Fields("id_Pac").Value, String)
                id = "PAC"
            Case 4
                consulta = connection.Execute("select ID_ges from Gestor ;")
                idConsulta = TryCast(consulta.Fields("id_ges").Value, String)
                id = "GES"
        End Select



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

        connection.Close()
        Return codigoRandoms
    End Function





End Class
