Imports ADODB, Datos, System.Text
Imports Microsoft.VisualBasic.ApplicationServices

Public Class ConexionConBD
    Private Shared Property connection As New Connection
    'Funcion para conectarse a la base de datos
    Private Function conectar() As Connection
        If connection.State = 0 Then
            connection.ConnectionString = "" &
            "driver={MySQL ODBC 8.0 Unicode Driver};" &
            "server=izuwuedb.co8sw6a5kje7.us-east-2.rds.amazonaws.com;" &
            "port=3306;" &
            "database=izuwuDB;" &
            "uid=admin;" &
            "pwd=izuwuteam;"

            connection.Open()
        End If

        Return connection
    End Function

    '///---------------------------------------------------------------------------------------------------------------
    'Funciones para obtener los datos de la base de datos y almacenarlos en listas

    Public Function ObtenerPacientes() As List(Of Paciente)
        Dim connection As Connection = conectar()
        Dim ListaPaciente As New List(Of Paciente)
        Dim fechaBaseDatos As Date
        Dim fechaString As String
        Dim id, nombre, segundonombre, apellido, segundoapellido, email, direccion, ci, contraseña, telefono, sexo, peso, altura, patologiaprevia As String
        Dim consulta As Recordset = connection.Execute("select * " +
                                                       "from usuario inner join paciente " +
                                                       "on usuario.id_us = paciente.id_pac" +
                                                       "order by nombre asc;")


        While (Not consulta.EOF)

            id = TryCast(consulta.Fields("ID_us").Value, String)
            nombre = TryCast(consulta.Fields("Nombre").Value, String)

            apellido = TryCast(consulta.Fields("Apellido").Value, String)

            email = TryCast(consulta.Fields("Email").Value, String)
            direccion = TryCast(consulta.Fields("Direccion").Value, String)
            ci = TryCast(consulta.Fields("CI").Value, String)
            contraseña = TryCast(consulta.Fields("Contrasenia").Value, String)
            Dim consultaTelefono As Recordset = connection.Execute("select telefono from telefono_us where id_us ='" + id + "';")
            telefono = TryCast(consultaTelefono.Fields("Telefono").Value, String)
            fechaBaseDatos = TryCast(consulta.Fields("FDN").Value, Object)
            fechaString = Format(fechaBaseDatos, "yyyy/MM/dd")
            peso = TryCast(consulta.Fields("peso").Value, String)
            altura = DirectCast(consulta.Fields("altura").Value, Double)
            patologiaprevia = TryCast(consulta.Fields("patologiasp").Value, String)
            segundonombre = TryCast(consulta.Fields("segundo_nombre").Value, String)
            segundoapellido = TryCast(consulta.Fields("segundo_apellido").Value, String)
            sexo = TryCast(consulta.Fields("Sexo").Value, String)

            ListaPaciente.Add(New Paciente(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fechaString, sexo, peso, altura.ToString, patologiaprevia))

            consulta.MoveNext()
        End While


        Return ListaPaciente
    End Function

    Public Function ObtenerMedicos() As List(Of Medico)
        Dim connection As Connection = conectar()
        Dim ListaMedico As New List(Of Medico)

        Dim fechaBaseDatos As Date
        Dim fechaString As String
        Dim id, nombre, segundonombre, apellido, segundoapellido, email, direccion, ci, contraseña, telefono, sexo, especializacion, lugardetrabajo As String

        Dim consulta As Recordset = connection.Execute("select * " +
                                                       "from usuario inner join medico " +
                                                       "on usuario.id_us = medico.id_med " +
                                                       "order by nombre asc;")

        While (Not consulta.EOF)
            id = TryCast(consulta.Fields("ID_us").Value, String)
            nombre = TryCast(consulta.Fields("Nombre").Value, String)
            apellido = TryCast(consulta.Fields("Apellido").Value, String)
            email = TryCast(consulta.Fields("Email").Value, String)
            direccion = TryCast(consulta.Fields("Direccion").Value, String)
            ci = TryCast(consulta.Fields("CI").Value, String)
            contraseña = TryCast(consulta.Fields("Contrasenia").Value, String)
            Dim consultaTelefono As Recordset = connection.Execute("select telefono from telefono_us where id_us ='" + id + "';")
            telefono = TryCast(consultaTelefono.Fields("Telefono").Value, String)
            fechaBaseDatos = TryCast(consulta.Fields("FDN").Value, Object)
            fechaString = Format(fechaBaseDatos, "yyyy/MM/dd")
            especializacion = TryCast(consulta.Fields("Especializacion").Value, String)
            segundonombre = TryCast(consulta.Fields("segundo_nombre").Value, String)
            segundoapellido = TryCast(consulta.Fields("segundo_apellido").Value, String)
            lugardetrabajo = TryCast(consulta.Fields("Lugar_de_trabajo").Value, String)
            sexo = TryCast(consulta.Fields("Sexo").Value, String)

            ListaMedico.Add(New Medico(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fechaString, sexo, especializacion, lugardetrabajo))

            consulta.MoveNext()
        End While



        Return ListaMedico
    End Function

    Public Function ObtenerGestores() As List(Of Gestor)
        Dim connection As Connection = conectar()
        Dim ListaGestor As New List(Of Gestor)
        Dim fechaBaseDatos As Date
        Dim fechaString As String
        Dim id, nombre, segundonombre, apellido, segundoapellido, email, direccion, ci, contraseña, telefono, sexo, empresa As String

        Dim consulta As Recordset = connection.Execute("select * " +
                                                       "from usuario inner join gestor " +
                                                       "on usuario.id_us = gestor.id_ges " +
                                                       "order by nombre asc;")
        While (Not consulta.EOF)
            id = TryCast(consulta.Fields("ID_us").Value, String)
            nombre = TryCast(consulta.Fields("Nombre").Value, String)
            apellido = TryCast(consulta.Fields("Apellido").Value, String)
            email = TryCast(consulta.Fields("Email").Value, String)
            direccion = TryCast(consulta.Fields("Direccion").Value, String)
            ci = TryCast(consulta.Fields("CI").Value, String)
            contraseña = TryCast(consulta.Fields("Contrasenia").Value, String)
            Dim consultaTelefono As Recordset = connection.Execute("select telefono from telefono_us where id_us ='" + id + "';")
            telefono = TryCast(consultaTelefono.Fields("Telefono").Value, String)
            fechaBaseDatos = TryCast(consulta.Fields("FDN").Value, Object)
            fechaString = Format(fechaBaseDatos, "yyyy/MM/dd")
            empresa = TryCast(consulta.Fields("Empresa").Value, String)
            segundonombre = TryCast(consulta.Fields("segundo_nombre").Value, String)
            segundoapellido = TryCast(consulta.Fields("segundo_apellido").Value, String)
            sexo = TryCast(consulta.Fields("Sexo").Value, String)
            ListaGestor.Add(New Gestor(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fechaString, sexo, empresa))

            consulta.MoveNext()
        End While


        Return ListaGestor
    End Function

    Public Function ObtenerSintoma() As List(Of Sintoma)
        Dim connection As Connection = conectar()
        Dim ListaSintomas As New List(Of Sintoma)

        Dim consulta As Recordset = connection.Execute("select * from sintoma order by nombre asc")
        Dim nombre, id As String
        While (Not consulta.EOF)
            nombre = TryCast(consulta.Fields("Nombre").Value, String)
            id = TryCast(consulta.Fields("ID_SIN").Value, String)
            ListaSintomas.Add(New Sintoma(nombre, id))
            consulta.MoveNext()
        End While


        Return ListaSintomas
    End Function

    Public Function ObtenerPatologia() As List(Of Patologia)
        Dim connection As Connection = conectar()
        Dim ListaPatologia As New List(Of Patologia)

        Dim consulta As Recordset = connection.Execute("select * from patologia order by nombre asc")
        Dim nombre, prioridad, id As String
        While (Not consulta.EOF)
            nombre = TryCast(consulta.Fields("Nombre").Value, String)
            prioridad = TryCast(consulta.Fields("Prioridad").Value, String)
            id = TryCast(consulta.Fields("ID_PAT").Value, String)
            ListaPatologia.Add(New Patologia(nombre, prioridad, id))
            consulta.MoveNext()
        End While


        Return ListaPatologia
    End Function




    Public Function ObtenerReferenciaSintomaPatologia(ID As String) As List(Of Patologia)
        Dim connection As Connection = conectar()
        Dim listaReferencias As New List(Of Patologia)

        Dim consulta As Recordset = connection.Execute("select patologia.nombre, patologia.id_pat, patologia.prioridad " &
                                                        "from patologia inner join tiene on tiene.id_pat=patologia.id_pat " &
                                                        "inner join sintoma on tiene.id_sin=sintoma.id_sin " &
                                                        "where sintoma.id_sin = '" & ID & "'" +
                                                        "order by nombre asc;")
        Dim nombre, IDpatologia, prioridad As String
        While (Not consulta.EOF)
            IDpatologia = TryCast(consulta.Fields("ID_pat").Value, String)
            nombre = TryCast(consulta.Fields("nombre").Value, String)
            prioridad = TryCast(consulta.Fields("prioridad").Value, String)
            listaReferencias.Add(New Patologia(nombre, prioridad, IDpatologia))
            consulta.MoveNext()
        End While

        Return listaReferencias
    End Function


    Public Function ObtenerRefenciaPatologiaSintoma(ID As String) As List(Of Sintoma)
        Dim connection As Connection = conectar()
        Dim listaReferencias As New List(Of Sintoma)
        Dim consulta As Recordset = connection.Execute("select sintoma.nombre, sintoma.id_sin " &
                                                        "from patologia inner join tiene on tiene.id_pat=patologia.id_pat " &
                                                        "inner join sintoma on tiene.id_sin=sintoma.id_sin " &
                                                        "where patologia.id_pat = '" & ID & "'" +
                                                        "order by nombre asc;")
        Dim nombre, IDsintoma As String
        While (Not consulta.EOF)
            nombre = TryCast(consulta.Fields("nombre").Value, String)
            IDsintoma = TryCast(consulta.Fields("id_sin").Value, String)
            listaReferencias.Add(New Sintoma(nombre, IDsintoma))
            consulta.MoveNext()
        End While

        Return listaReferencias
    End Function




    '-----------------------------------------------------------------------------------------------------------////
    'Funcion de logeo a la aplicacion

    Public Function LoginMedico(UserCi As String, pass As String) As Medico
        Dim connection As Connection = conectar()
        Dim consulta As Recordset = connection.Execute("select * " +
                                                       "from usuario inner join medico " +
                                                       "on usuario.id_us = medico.id_med " +
                                                       "where CI='" + UserCi + "' ;")

        If consulta.EOF = True Then
            Throw New Exception("Cedula y/o contraseña incorrecta.")
        Else


            Dim pasw As String = TryCast(consulta.Fields("contrasenia").Value, String)
            If pasw = pass Then
                Dim ID_user As String = TryCast(consulta.Fields("id_us").Value, String)
                Dim nombre As String = TryCast(consulta.Fields("nombre").Value, String)
                Dim apellido As String = TryCast(consulta.Fields("apellido").Value, String)
                Dim email As String = TryCast(consulta.Fields("email").Value, String)
                Dim direccion As String = TryCast(consulta.Fields("direccion").Value, String)
                Dim consultaTelefono As Recordset = connection.Execute("select telefono from telefono_us where id_us ='" + ID_user + "';")
                Dim telefono = TryCast(consultaTelefono.Fields("Telefono").Value, String)
                Dim fechaBaseDatos As Date = TryCast(consulta.Fields("FDN").Value, Object)
                Dim fechaString As String = Format(fechaBaseDatos, "yyyy/MM/dd")
                Dim especializacion As String = TryCast(consulta.Fields("Especializacion").Value, String)
                Dim segundonombre As String = TryCast(consulta.Fields("segundo_nombre").Value, String)
                Dim segundoapellido As String = TryCast(consulta.Fields("segundo_apellido").Value, String)
                Dim lugardetrabajo As String = TryCast(consulta.Fields("Lugar_de_trabajo").Value, String)
                Dim sexo As String = TryCast(consulta.Fields("Sexo").Value, String)
                Dim medico As New Medico(nombre, segundonombre, apellido, segundoapellido, email, ID_user, direccion, UserCi, pasw, telefono, fechaString, sexo, especializacion, lugardetrabajo)
                Return medico
            Else
                Throw New Exception("Cedula y/o contraseña incorrecta.")
            End If
        End If
    End Function

    Public Function LoginPaciente(UserCI As String, pass As String) As Paciente
        Dim connection As Connection = conectar()
        Dim fechaBaseDatos As Date
        Dim fechaString As String
        Dim id, nombre, segundonombre, apellido, segundoapellido, email, direccion, ci, contraseña, telefono, sexo, peso, altura, patologiaprevia As String
        Dim consulta As Recordset = connection.Execute("select * " +
                                                       "from usuario inner join paciente " +
                                                       "on usuario.id_us = paciente.id_pac" +
                                                       "where CI = '" + UserCI + "';")
        If consulta.EOF = True Then
            Throw New Exception("Cedula y/o contraseña incorrecta.")
        Else
            Dim pasw As String = TryCast(consulta.Fields("contrasenia").Value, String)
            If pass = pasw Then


                id = TryCast(consulta.Fields("ID_us").Value, String)
                nombre = TryCast(consulta.Fields("Nombre").Value, String)
                apellido = TryCast(consulta.Fields("Apellido").Value, String)
                email = TryCast(consulta.Fields("Email").Value, String)
                direccion = TryCast(consulta.Fields("Direccion").Value, String)
                ci = TryCast(consulta.Fields("CI").Value, String)
                contraseña = TryCast(consulta.Fields("Contrasenia").Value, String)
                Dim consultaTelefono As Recordset = connection.Execute("select telefono from telefono_us where id_us ='" + id + "';")
                telefono = TryCast(consultaTelefono.Fields("Telefono").Value, String)
                fechaBaseDatos = TryCast(consulta.Fields("FDN").Value, Object)
                fechaString = Format(fechaBaseDatos, "yyyy/MM/dd")
                peso = TryCast(consulta.Fields("peso").Value, String)
                altura = DirectCast(consulta.Fields("altura").Value, Double)
                patologiaprevia = TryCast(consulta.Fields("patologiasp").Value, String)
                segundonombre = TryCast(consulta.Fields("segundo_nombre").Value, String)
                segundoapellido = TryCast(consulta.Fields("segundo_apellido").Value, String)
                sexo = TryCast(consulta.Fields("Sexo").Value, String)
                Dim paciente As New Paciente(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fechaString, sexo, peso, altura.ToString, patologiaprevia)
                Return paciente
            Else
                Throw New Exception("Cedula y/o contraseña incorrecta.")
            End If
        End If
    End Function

    Public Function LoginGestor(UserCI As String, pass As String) As Gestor
        Dim connection As Connection = conectar()
        Dim fechaBaseDatos As Date
        Dim fechaString As String
        Dim id, nombre, segundonombre, apellido, segundoapellido, email, direccion, ci, contraseña, telefono, sexo, empresa As String

        Dim consulta As Recordset = connection.Execute("select * " +
                                                      "from usuario inner join gestor " +
                                                      "on usuario.id_us = gestor.id_ges " +
                                                      "where CI = '" + UserCI + "';")
        If consulta.EOF = True Then
            Throw New Exception("Cedula y/o contraseña incorrecta.")
        Else
            Dim pasw As String = TryCast(consulta.Fields("contrasenia").Value, String)
            If pass = pasw Then
                id = TryCast(consulta.Fields("ID_us").Value, String)
                nombre = TryCast(consulta.Fields("Nombre").Value, String)
                apellido = TryCast(consulta.Fields("Apellido").Value, String)
                email = TryCast(consulta.Fields("Email").Value, String)
                direccion = TryCast(consulta.Fields("Direccion").Value, String)
                ci = TryCast(consulta.Fields("CI").Value, String)
                contraseña = TryCast(consulta.Fields("Contrasenia").Value, String)
                Dim consultaTelefono As Recordset = connection.Execute("select telefono from telefono_us where id_us ='" + id + "';")
                telefono = TryCast(consultaTelefono.Fields("Telefono").Value, String)
                fechaBaseDatos = TryCast(consulta.Fields("FDN").Value, Object)
                fechaString = Format(fechaBaseDatos, "yyyy/MM/dd")
                empresa = TryCast(consulta.Fields("Empresa").Value, String)
                segundonombre = TryCast(consulta.Fields("segundo_nombre").Value, String)
                segundoapellido = TryCast(consulta.Fields("segundo_apellido").Value, String)
                sexo = TryCast(consulta.Fields("Sexo").Value, String)
                Dim gestor As New Gestor(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fechaString, sexo, empresa)
                Return gestor
            Else
                Throw New Exception("Cedula y/o contraseña incorrecta.")
            End If
        End If

    End Function



    '///-------------------------------------------------------------------------------------------------------------------------------------
    'Funcion de agregar datos (sintomas, patologias, usuarios)
    Public Sub agregarPaciente(paciente As Paciente)
        Dim connection As Connection = conectar()

        Dim agregarUsuario As Recordset = connection.Execute("insert into usuario values('" + paciente.nombre + "','" + paciente.apellido + "','" + paciente.email + "','" + paciente.ID + "','" + paciente.Direccion + "','" + paciente.CI + "','" + paciente.contraseña + "','" + paciente.fechadenacimiento + "','" + paciente.segundoapellido + "','" + paciente.segundonombre + "','" + paciente.sexo + "');")
        Dim agregarTelefonoUsuario As Recordset = connection.Execute("insert into telefono_us values('" + paciente.telefono + "','" + paciente.ID + "');")
        Dim agregarPaciente As Recordset = connection.Execute("insert into paciente values ('" + paciente.ID + "','" + paciente.altura + "','" + paciente.patologiaPrevia + "','" + paciente.peso + "');")


    End Sub

    Public Sub agregarMedico(medico As Medico)
        Dim connection As Connection = conectar()
        Dim agregarUsuario As Recordset = connection.Execute("insert into usuario values('" + medico.nombre + "','" + medico.apellido + "','" + medico.email + "','" + medico.ID + "','" + medico.Direccion + "','" + medico.CI + "','" + medico.contraseña + "','" + medico.fechadenacimiento + "','" + medico.segundoapellido + "','" + medico.segundonombre + "','" + medico.sexo + "');")
        Dim agregarTelefonoUsuario As Recordset = connection.Execute("insert into telefono_us values('" + medico.telefono + "','" + medico.ID + "');")
        Dim agregarMedico As Recordset = connection.Execute("insert into medico values ('" + medico.especializacion + "','" + medico.ID + "','" + medico.lugarDeTrabajo + "');")


    End Sub

    Public Sub agregarGestor(gestor As Gestor)
        Dim connection As Connection = conectar()
        Dim agregarUsuario As Recordset = connection.Execute("insert into usuario values('" + gestor.nombre + "','" + gestor.apellido + "','" + gestor.email + "','" + gestor.ID + "','" + gestor.Direccion + "','" + gestor.CI + "','" + gestor.contraseña + "','" + gestor.fechadenacimiento + "','" + gestor.segundoapellido + "','" + gestor.segundonombre + "','" + gestor.sexo + "');")
        Dim agregarTelefonoUsuario As Recordset = connection.Execute("insert into telefono_us values('" + gestor.telefono + "','" + gestor.ID + "');")
        Dim agregarGestor As Recordset = connection.Execute("insert into gestor values ('" + gestor.ID + "','" + gestor.empresa + "');")




    End Sub

    Public Sub agregarSintoma(sintoma As Sintoma)
        Dim connection As Connection = conectar()

        Dim agregar As Recordset = connection.Execute("insert into sintoma values('" + sintoma.nombre + "','" + sintoma.id + "');")

    End Sub

    Public Sub agregarPatologia(patologia As Patologia)
        Dim connection As Connection = conectar()

        Dim agregar As Recordset = connection.Execute("insert into patologia values('" + patologia.nombre + "','" + patologia.prioridad + "','" + patologia.id + "');")

    End Sub

    Public Sub agregarSintomaDePatologia(IDSintoma As String, IDPatologia As String)
        Dim connection As Connection = conectar()

        Dim agregar As Recordset = connection.Execute("insert into tiene values ('" + IDPatologia + "','" + IDSintoma + "');")


    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------////

    '////-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Funcion para eliminar datos de la base de datos (usuarios, sintomas, patologias)

    Public Sub eliminarPaciente(ID As String)
        Dim connection As Connection = conectar()
        Dim eliminarTelefonoUsuario As Recordset = connection.Execute("delete from telefono_us where id_us ='" + ID + "';")
        Dim eliminarPaciente As Recordset = connection.Execute("delete from paciente where id_pac = '" + ID + "';")
        Dim eliminarUsuario As Recordset = connection.Execute("delete from usuario where id_us = '" + ID + "';")

    End Sub

    Public Sub eliminarMedico(ID As String)
        Dim connection As Connection = conectar()
        Dim eliminarTelefonoUsuario As Recordset = connection.Execute("delete from telefono_us where id_us ='" + ID + "';")
        Dim eliminarMedico As Recordset = connection.Execute("delete from medico where id_med = '" + ID + "';")
        Dim eliminarUsuario As Recordset = connection.Execute("delete from usuario where id_us = '" + ID + "';")

    End Sub

    Public Sub eliminarGestor(ID As String)
        Dim connection As Connection = conectar()
        Dim eliminarTelefonoUsuario As Recordset = connection.Execute("delete from telefono_us where id_us ='" + ID + "';")
        Dim eliminarGestor As Recordset = connection.Execute("delete from gestor where id_ges = '" + ID + "';")
        Dim eliminarUsuario As Recordset = connection.Execute("delete from usuario where id_us = '" + ID + "';")

    End Sub

    Public Sub eliminarSintoma(ID As String)
        Dim connection As Connection = conectar()
        Dim eliminarRef As Recordset = connection.Execute("delete from tiene where id_sin = '" + ID + "';")
        Dim eliminarSintoma As Recordset = connection.Execute("delete from sintoma where id_sin = '" + ID + "';")

    End Sub

    Public Sub eliminarPatologia(ID As String)
        Dim connection As Connection = conectar()
        Dim eliminarRef As Recordset = connection.Execute("delete from tiene where id_pat = '" + ID + "';")
        Dim eliminarPatologia As Recordset = connection.Execute("delete from patologia where id_pat = '" + ID + "';")

    End Sub

    Public Sub eliminarReferenciaPatologiaSintoma(IDsin As String, IDpat As String)
        Dim connection As Connection = conectar()
        Dim eliminarRef As Recordset = connection.Execute("delete from tiene where ID_Sin = '" + IDsin + "' And ID_pat = '" + IDpat + "';")

    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------------------------------/////


    '////------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Funcion para modificar datos

    Public Sub actualizarSintoma(sintoma As Sintoma)
        Dim connection As Connection = conectar()
        Dim actualizar As Recordset = connection.Execute("update sintoma set nombre = '" + sintoma.nombre + "' where id_sin = '" + sintoma.id + "';")

    End Sub

    Public Sub actualizarPatologia(patologia As Patologia)
        Dim connection As Connection = conectar()
        Dim actualizar As Recordset = connection.Execute("update patologia set nombre = '" + patologia.nombre + "', prioridad ='" + patologia.prioridad + "' where id_pat = '" + patologia.id + "';")

    End Sub


    Public Sub actualizarMedico(medico As Medico)
        Dim connection As Connection = conectar()
        Dim actualizarUsuario As Recordset = connection.Execute("update usuario set nombre = '" + medico.nombre + "', apellido = '" + medico.apellido + "', email = '" + medico.email + "', direccion = '" + medico.Direccion + "', ci = '" + medico.CI + "', contrasenia= '" + medico.contraseña + "', FDN ='" + medico.fechadenacimiento + "', segundo_nombre ='" + medico.segundonombre + "', segundo_apellido= '" + medico.segundoapellido + "', sexo ='" + medico.sexo + "' where id_us ='" + medico.ID + "';")
        Dim actualizarTelefonoUsuario As Recordset = connection.Execute("update telefono_us set telefono ='" + medico.telefono + "', id_us ='" + medico.ID + "' where id_us ='" + medico.ID + "';")
        Dim actualizarMedico As Recordset = connection.Execute("update medico set especializacion ='" + medico.especializacion + "', Lugar_de_trabajo ='" + medico.lugarDeTrabajo + "' where id_med ='" + medico.ID + "';")

    End Sub

    Public Sub actualizarPaciente(paciente As Paciente)
        Dim connection As Connection = conectar()
        Dim actualizarUsuario As Recordset = connection.Execute("update usuario set nombre = '" + paciente.nombre + "', apellido = '" + paciente.apellido + "', email = '" + paciente.email + "', direccion = '" + paciente.Direccion + "', ci = '" + paciente.CI + "', contrasenia= '" + paciente.contraseña + "', FDN ='" + paciente.fechadenacimiento + "', segundo_nombre= '" + paciente.segundonombre + "', segundo_apellido= '" + paciente.segundoapellido + "', sexo ='" + paciente.sexo + " where id_us ='" + paciente.ID + "';")
        Dim actualizarTelefonoUsuario As Recordset = connection.Execute("update telefono_us set telefono ='" + paciente.telefono + "', id_us ='" + paciente.ID + "' where id_us ='" + paciente.ID + "';")
        Dim actualizarPaciente As Recordset = connection.Execute("update paciente set peso = '" + paciente.peso + "', altura = '" + paciente.altura + "', Patologiasp = '" + paciente.patologiaPrevia + "' where id_pat = '" + paciente.ID + "';")

    End Sub

    Public Sub actualizarGestor(gestor As Gestor)
        Dim connection As Connection = conectar()
        Dim actualizarUsuario As Recordset = connection.Execute("update usuario set nombre = '" + gestor.nombre + "', apellido = '" + gestor.apellido + "', email = '" + gestor.email + "', direccion = '" + gestor.Direccion + "', ci = '" + gestor.CI + "', contrasenia= '" + gestor.contraseña + "', FDN ='" + gestor.fechadenacimiento + "', segundo_nombre= '" + gestor.segundonombre + "', segundo_apellido = '" + gestor.segundoapellido + "', sexo ='" + gestor.sexo + " where id_us ='" + gestor.ID + "';")
        Dim actualizarTelefonoUsuario As Recordset = connection.Execute("update telefono_us set telefono ='" + gestor.telefono + "', id_us ='" + gestor.ID + "' where id_us ='" + gestor.ID + "';")
        Dim actualizarMedico As Recordset = connection.Execute("update gestor set empresa ='" + gestor.empresa + "' where id_ges ='" + gestor.ID + "';")

    End Sub


    '--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------////
    Public Function codigoRandom(num As Integer) As String

        Dim connection As Connection = conectar()
        Dim codigoRandoms As String
        Dim consulta As Recordset
        Dim idConsulta As String
        Dim id As String

        Select Case num
            Case 0
                consulta = connection.Execute("select ID_SIN from sintoma ;")
                idConsulta = TryCast(consulta.Fields("ID_SIN").Value, String)
                id = "SIN"
            Case 1
                consulta = connection.Execute("select ID_MED from medico ;")
                idConsulta = TryCast(consulta.Fields("id_MED").Value, String)
                id = "MED"
            Case 2
                consulta = connection.Execute("select ID_Pat from patologia ;")
                idConsulta = TryCast(consulta.Fields("id_Pat").Value, String)
                id = "PAT"
            Case 3
                consulta = connection.Execute("select ID_Pac from paciente ;")
                idConsulta = TryCast(consulta.Fields("id_Pac").Value, String)
                id = "PAC"
            Case 4
                consulta = connection.Execute("select ID_ges from gestor ;")
                idConsulta = TryCast(consulta.Fields("id_ges").Value, String)
                id = "GES"
            Case 5
                consulta = connection.Execute("select ID_DIAG from diagnostico ;")
                idConsulta = TryCast(consulta.Fields("id_diag").Value, String)
                id = "DIG"
            Case 6
                consulta = connection.Execute("select id_sala from mensaje;")
                idConsulta = TryCast(consulta.Fields("id_sala").Value, String)
                id = "IDS"
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


        Return codigoRandoms
    End Function



    '///------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'Funcion para obtener diagnostico y agregarlo a la base de datos

    Public Sub agregarSintomasPaciente(sintomas As List(Of Sintoma), paciente As Paciente, fecha As String)
        Dim connection As Connection = conectar()

        For Each sintoma As Sintoma In sintomas
            Dim agregarSintomas As Recordset = connection.Execute("insert into posee values('" + fecha + "','" + sintoma.id + "','" + paciente.ID + "');")
        Next

    End Sub

    Public Function Diagnostico(paciente As Paciente) As List(Of Diagnostico)
        Dim connection As Connection = conectar()
        Dim listaDiagnostico As New List(Of Diagnostico)
        Dim consulta As Recordset = connection.Execute("select posee.fecha,posee.id_pac,count(posee.id_sin) as 'Posible_patologia',tiene.ID_pat,patologia.nombre,patologia.prioridad" +
                                                       " From posee inner join tiene on " +
                                                       " posee.id_sin = tiene.id_sin inner join patologia on" +
                                                       " tiene.id_pat = patologia.ID_PAT inner join sintoma on" +
                                                       " posee.ID_SIN = sintoma.id_sin" +
                                                       " where id_pac = '" + paciente.ID + "'" +
                                                       " group by patologia.nombre" +
                                                       " order by count(posee.ID_SIN) desc" +
                                                       " limit 4")
        While (Not consulta.EOF)
            Dim fechaBaseDatos As Date = Convert.ToDateTime(TryCast(consulta.Fields("fecha").Value, Object))
            Dim fechaString As String = Format(fechaBaseDatos, "yyyy/MM/dd")
            Dim idPaciente As String = DirectCast(consulta.Fields("id_pac").Value, String)
            Dim probabilidadPatologia As Integer = Convert.ToInt32(TryCast(consulta.Fields("Posible_patologia").Value, Object))
            Dim idPatologia As String = DirectCast(consulta.Fields("id_pat").Value, String)
            Dim nombrePatologia As String = DirectCast(consulta.Fields("nombre").Value, String)
            Dim prioridadPatologia As String = DirectCast(consulta.Fields("prioridad").Value, String)
            listaDiagnostico.Add(New Diagnostico(nombrePatologia, prioridadPatologia, idPatologia, idPaciente, probabilidadPatologia, fechaString))
            consulta.MoveNext()
        End While


        Return listaDiagnostico
    End Function

    Public Sub agregarDiagnostico_A_BD(diagnosticos As List(Of Diagnostico), paciente As Paciente, fecha As String)
        Dim connection As Connection = conectar()
        Dim idDiagnostico As String = codigoRandom(5)
        Dim agregar_A_Diagnostico As Recordset = connection.Execute("insert into diagnostico values('" + idDiagnostico + "');")
        For Each diagnostico As Diagnostico In diagnosticos
            Dim agregar_A_Resulta As Recordset = connection.Execute("insert into resulta values('" + idDiagnostico + "','" + diagnostico.id + "');")
        Next
        Dim agregar_a_dianosticoapp As Recordset = connection.Execute("insert into diagnostico_app values('" + idDiagnostico + "','" + paciente.ID + "','" + fecha + "');")

    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------/////
    'Funciones para realizar el chat medico - paciente


End Class


