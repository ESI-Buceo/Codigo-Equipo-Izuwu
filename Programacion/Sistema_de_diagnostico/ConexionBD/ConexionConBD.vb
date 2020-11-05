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
        Dim id, nombre, segundonombre, apellido, segundoapellido, email, direccion, ci, contraseña, especializacion, telefono, sexo, lugardetrabajo As String

        Dim consulta As Recordset = connection.Execute("select usuario.* ,medico.* ,telefono_us.Telefono,campo_medico.nombre as 'Campo',campo_medico.id_campomedico " +
                                                       "from usuario inner join medico on " +
                                                       "usuario.id_us = medico.id_med inner join especializado on " +
                                                       "medico.ID_MED = especializado.id_medE inner join campo_medico on " +
                                                       "especializado.id_campomedicoE = campo_medico.id_campomedico inner join telefono_us on " +
                                                       "usuario.id_us = telefono_us.ID_US " +
                                                       "group by id_us;")

        While (Not consulta.EOF)
            id = TryCast(consulta.Fields("ID_us").Value, String)
            nombre = TryCast(consulta.Fields("Nombre").Value, String)
            apellido = TryCast(consulta.Fields("Apellido").Value, String)
            email = TryCast(consulta.Fields("Email").Value, String)
            direccion = TryCast(consulta.Fields("Direccion").Value, String)
            ci = TryCast(consulta.Fields("CI").Value, String)
            contraseña = TryCast(consulta.Fields("Contrasenia").Value, String)
            Dim consultaTelefono As Recordset = connection.Execute("Select telefono From telefono_us Where id_us ='" + id + "';")
            telefono = TryCast(consultaTelefono.Fields("Telefono").Value, String)
            fechaBaseDatos = TryCast(consulta.Fields("FDN").Value, Object)
            fechaString = Format(fechaBaseDatos, "yyyy/MM/dd")
            especializacion = TryCast(consulta.Fields("Campo").Value, String)
            segundonombre = TryCast(consulta.Fields("segundo_nombre").Value, String)
            segundoapellido = TryCast(consulta.Fields("segundo_apellido").Value, String)
            lugardetrabajo = TryCast(consulta.Fields("Lugar_de_trabajo").Value, String)
            sexo = TryCast(consulta.Fields("Sexo").Value, String)

            ListaMedico.Add(New Medico(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, especializacion, telefono, fechaString, sexo, lugardetrabajo))

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

        Dim consulta As Recordset = connection.Execute("select campo_medico.nombre as 'especialidad',patologia.* " +
                                                       "from patologia inner join trata on " +
                                                       "patologia.id_pat = trata.id_patT inner join campo_medico on " +
                                                       "trata.id_campomedicoT = campo_medico.id_campomedico order by nombre asc;")
        Dim nombre, prioridad, id, especialidad As String
        While (Not consulta.EOF)
            nombre = TryCast(consulta.Fields("Nombre").Value, String)
            prioridad = TryCast(consulta.Fields("Prioridad").Value, String)
            id = TryCast(consulta.Fields("id_pat").Value, String)
            especialidad = TryCast(consulta.Fields("especialidad").Value, String)
            ListaPatologia.Add(New Patologia(nombre, prioridad, id, especialidad))
            consulta.MoveNext()
        End While


        Return ListaPatologia
    End Function




    Public Function ObtenerReferenciaSintomaPatologia(ID As String) As List(Of Patologia)
        Dim connection As Connection = conectar()
        Dim listaReferencias As New List(Of Patologia)
        Dim consulta As Recordset = connection.Execute("select campo_medico.nombre as 'especialidad',patologia.* " +
                                                       "from sintoma inner join tiene on " +
                                                       "sintoma.ID_SIN = tiene.ID_SIN inner join patologia on " +
                                                       "tiene.ID_PAT = patologia.ID_PAT inner join trata on " +
                                                       "patologia.ID_PAT = trata.id_patT inner join campo_medico on " +
                                                       "trata.id_campomedicoT = campo_medico.id_campomedico " +
                                                       "where sintoma.id_sin = '" + ID + "' " +
                                                       "order by nombre asc;")
        Dim nombre, IDpatologia, prioridad, especialidad As String
        While (Not consulta.EOF)
            IDpatologia = TryCast(consulta.Fields("ID_pat").Value, String)
            nombre = TryCast(consulta.Fields("nombre").Value, String)
            prioridad = TryCast(consulta.Fields("prioridad").Value, String)
            especialidad = TryCast(consulta.Fields("especialidad").Value, String)
            listaReferencias.Add(New Patologia(nombre, prioridad, IDpatologia, especialidad))
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


    Public Function ObtenerEspecializacionesMedicos() As List(Of campo_medico)
        Dim connection As Connection = conectar()
        Dim listaEspecializacion As New List(Of campo_medico)
        Dim consulta As Recordset = connection.Execute("select * from campo_medico;")

        While (Not consulta.EOF)
            Dim nombre As String = TryCast(consulta.Fields("nombre").Value, String)
            Dim id As String = TryCast(consulta.Fields("id_campomedico").Value, String)
            listaEspecializacion.Add(New campo_medico(id, nombre))
            consulta.MoveNext()
        End While
        Return listaEspecializacion
    End Function




    '-----------------------------------------------------------------------------------------------------------////
    'Funcion de logeo a la aplicacion

    Public Function LoginMedico(UserCi As String, pass As String) As Medico
        Dim connection As Connection = conectar()
        Dim consulta As Recordset = connection.Execute("select usuario.* ,medico.* ,telefono_us.Telefono,campo_medico.nombre as 'Campo',campo_medico.id_campomedico " +
                                                       "from usuario inner join medico on " +
                                                       "usuario.id_us = medico.id_med inner join especializado on " +
                                                       "medico.ID_MED = especializado.id_medE inner join campo_medico on " +
                                                       "especializado.id_campomedicoE = campo_medico.id_campomedico inner join telefono_us on " +
                                                       "usuario.id_us = telefono_us.ID_US " +
                                                       "where CI ='" + UserCi + "';")

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
                Dim especializacion As String = TryCast(consulta.Fields("Campo").Value, String)
                Dim segundonombre As String = TryCast(consulta.Fields("segundo_nombre").Value, String)
                Dim segundoapellido As String = TryCast(consulta.Fields("segundo_apellido").Value, String)
                Dim lugardetrabajo As String = TryCast(consulta.Fields("Lugar_de_trabajo").Value, String)
                Dim sexo As String = TryCast(consulta.Fields("Sexo").Value, String)
                Dim medico As New Medico(nombre, segundonombre, apellido, segundoapellido, email, ID_user, direccion, UserCi, pasw, especializacion, telefono, fechaString, sexo, lugardetrabajo)
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
                                                       "on usuario.id_us = paciente.id_pac " +
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
                altura = TryCast(consulta.Fields("altura").Value, String)
                patologiaprevia = TryCast(consulta.Fields("patologiasp").Value, String)
                segundonombre = TryCast(consulta.Fields("segundo_nombre").Value, String)
                segundoapellido = TryCast(consulta.Fields("segundo_apellido").Value, String)
                sexo = TryCast(consulta.Fields("Sexo").Value, String)
                Dim paciente As New Paciente(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fechaString, sexo, peso, altura, patologiaprevia)
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

    Public Sub agregarMedico(medico As Medico, idcampo As String)
        Dim connection As Connection = conectar()
        Dim agregarUsuario As Recordset = connection.Execute("insert into usuario values('" + medico.nombre + "','" + medico.apellido + "','" + medico.email + "','" + medico.ID + "','" + medico.Direccion + "','" + medico.CI + "','" + medico.contraseña + "','" + medico.fechadenacimiento + "','" + medico.segundoapellido + "','" + medico.segundonombre + "','" + medico.sexo + "');")
        Dim agregarTelefonoUsuario As Recordset = connection.Execute("insert into telefono_us values('" + medico.telefono + "','" + medico.ID + "');")
        Dim agregarMedico As Recordset = connection.Execute("insert into medico values ('" + medico.ID + "','" + medico.lugarDeTrabajo + "');")
        Dim agregarEspecialidad As Recordset = connection.Execute("insert into especializado values('" + medico.ID + "','" + idcampo + "');")
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

    Public Sub agregarPatologia(patologia As Patologia, id_campoMedico As String)
        Dim connection As Connection = conectar()
        Dim agregar As Recordset = connection.Execute("insert into patologia values('" + patologia.nombre + "','" + patologia.prioridad + "','" + patologia.id + "');")
        Dim agregarEspecialidad As Recordset = connection.Execute("insert into trata values('" + patologia.id + "','" + id_campoMedico + "')")

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
        Dim eliminarEspecialiadaMedico As Recordset = connection.Execute("delete from especializado where id_medE= '" + ID + "';")
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
        Dim eliminarCampo As Recordset = connection.Execute("delete from trata where id_patT ='" + ID + "';")
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

    Public Sub actualizarPatologia(patologia As Patologia, id_campoMedico As String)
        Dim connection As Connection = conectar()
        Dim actualizar As Recordset = connection.Execute("update patologia set nombre = '" + patologia.nombre + "', prioridad ='" + patologia.prioridad + "' where id_pat = '" + patologia.id + "';")
        Dim actualizarCampoMedico As Recordset = connection.Execute("update trata set id_campomedicoT ='" + id_campoMedico + "' where id_patT ='" + patologia.id + "';")
    End Sub


    Public Sub actualizarMedico(medico As Medico, idcampo As String)
        Dim connection As Connection = conectar()
        Dim actualizarUsuario As Recordset = connection.Execute("update usuario set nombre = '" + medico.nombre + "', apellido = '" + medico.apellido + "', email = '" + medico.email + "', direccion = '" + medico.Direccion + "', ci = '" + medico.CI + "', contrasenia= '" + medico.contraseña + "', FDN ='" + medico.fechadenacimiento + "', segundo_nombre ='" + medico.segundonombre + "', segundo_apellido= '" + medico.segundoapellido + "', sexo ='" + medico.sexo + "' where id_us ='" + medico.ID + "';")
        Dim actualizarTelefonoUsuario As Recordset = connection.Execute("update telefono_us set telefono ='" + medico.telefono + "', id_us ='" + medico.ID + "' where id_us ='" + medico.ID + "';")
        Dim actualizarMedico As Recordset = connection.Execute("update medico set Lugar_de_trabajo ='" + medico.lugarDeTrabajo + "' where id_med ='" + medico.ID + "';")
        Dim actualizarEspecialidad As Recordset = connection.Execute("update especializado set id_campomedicoE = '" + idcampo + "' where id_medE= '" + medico.ID + "';")
    End Sub

    Public Sub actualizarPaciente(paciente As Paciente)
        Dim connection As Connection = conectar()
        Dim actualizarUsuario As Recordset = connection.Execute("update usuario set email = '" + paciente.email + "', direccion = '" + paciente.Direccion + "', contrasenia= '" + paciente.contraseña + "', where id_us ='" + paciente.ID + "';")
        Dim actualizarTelefonoUsuario As Recordset = connection.Execute("update telefono_us set telefono ='" + paciente.telefono + "', id_us ='" + paciente.ID + "' where id_us ='" + paciente.ID + "';")
        Dim actualizarPaciente As Recordset = connection.Execute("update paciente set peso = '" + paciente.peso + "', altura = '" + paciente.altura + "' where id_pat = '" + paciente.ID + "';")

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
                If consulta.EOF = False Then
                    idConsulta = TryCast(consulta.Fields("ID_SIN").Value, String)
                End If
                id = "SIN"
            Case 1
                consulta = connection.Execute("select ID_MED from medico ;")
                If consulta.EOF = False Then
                    idConsulta = TryCast(consulta.Fields("id_MED").Value, String)
                End If
                id = "MED"
            Case 2
                consulta = connection.Execute("select ID_Pat from patologia ;")
                If consulta.EOF = False Then
                    idConsulta = TryCast(consulta.Fields("id_Pat").Value, String)
                End If
                id = "PAT"
            Case 3
                consulta = connection.Execute("select ID_Pac from paciente ;")
                If consulta.EOF = False Then
                    idConsulta = TryCast(consulta.Fields("id_Pac").Value, String)
                End If
                id = "PAC"
            Case 4
                consulta = connection.Execute("select ID_ges from gestor ;")
                If consulta.EOF = False Then
                    idConsulta = TryCast(consulta.Fields("id_ges").Value, String)
                End If
                id = "GES"
            Case 5
                consulta = connection.Execute("select ID_DIAG from diagnostico ;")
                If consulta.EOF = False Then
                    idConsulta = TryCast(consulta.Fields("id_diag").Value, String)
                End If
                id = "DIG"
            Case 6
                consulta = connection.Execute("select id_sala from sala;")
                If consulta.EOF = False Then
                    idConsulta = TryCast(consulta.Fields("id_sala").Value, String)
                End If
                id = "SAL"
            Case 7
                consulta = connection.Execute("select id_tratamiento from tratamiento;")
                If consulta.EOF = False Then
                    idConsulta = TryCast(consulta.Fields("id_trt").Value, String)
                End If
                id = "TRT"
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
            If consulta.EOF = False Then
                consulta.MoveNext()
            End If
        Loop While (Not consulta.EOF)


        Return codigoRandoms
    End Function



    '///------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'Funcion para obtener diagnostico y agregarlo a la base de datos

    Public Sub agregarSintomasPaciente(sintomas As List(Of Sintoma), paciente As Paciente, fecha As String)
        Dim connection As Connection = conectar()
        Dim nTest As Recordset = connection.Execute("SELECT nro_test FROM test " +
                                                    "order by nro_test desc " +
                                                    "limit 1;")
        Dim numeroTest As Integer
        If nTest.EOF = True Then
            numeroTest = 1
        Else
            numeroTest = DirectCast(nTest.Fields("nro_test").Value, Integer) + 1
        End If
        Dim crearTest As Recordset = connection.Execute("insert into test values(" + numeroTest.ToString + ",'" + paciente.ID + "','" + fecha + "')")
        For Each sintoma As Sintoma In sintomas
            Dim agregarSintomas As Recordset = connection.Execute("insert into posee values('" + sintoma.id + "','" + paciente.ID + "'," + numeroTest.ToString + ");")
        Next
    End Sub

    Public Function Diagnostico() As List(Of Diagnostico)
        Dim connection As Connection = conectar()
        Dim listaDiagnostico As New List(Of Diagnostico)
        Dim nTest As Recordset = connection.Execute("SELECT nro_test FROM test " +
                                                    "order by nro_test desc " +
                                                    "limit 1;")
        Dim numeroTest As Integer
        If nTest.EOF = True Then
            numeroTest = 1
        Else
            numeroTest = DirectCast(nTest.Fields("nro_test").Value, Integer)
        End If

        Dim consulta As Recordset = connection.Execute("select test.fecha as 'Fecha_test',test.nro_test,test.Tid_pac,count(posee.Pid_sin) as 'Coincidencia'" +
                                                       ",patologia.id_pat,patologia.nombre as 'Nombre_patologia', patologia.Prioridad,campo_medico.nombre as  'especialidad' " +
                                                       "from test inner join posee on test.nro_test = posee.Pnro_test inner join sintoma on " +
                                                       "posee.Pid_sin = sintoma.ID_SIN inner join tiene on sintoma.ID_SIN = tiene.ID_SIN inner join patologia on " +
                                                       "tiene.ID_PAT = patologia.ID_PAT inner join trata on " +
                                                       "patologia.ID_PAT = trata.id_patT inner join campo_medico on " +
                                                       "trata.id_campomedicoT = campo_medico.id_campomedico " +
                                                       "where nro_test = " + numeroTest.ToString + " " +
                                                       "group by patologia.nombre " +
                                                       "order by count(posee.Pid_sin) desc " +
                                                       "limit 4;")
        While (Not consulta.EOF)
            Dim fechaBaseDatos As Date = Convert.ToDateTime(TryCast(consulta.Fields("Fecha_test").Value, Object))
            Dim fechaString As String = Format(fechaBaseDatos, "yyyy/MM/dd")
            Dim idPaciente As String = DirectCast(consulta.Fields("Tid_pac").Value, String)
            Dim probabilidadPatologia As Integer = Convert.ToInt32(TryCast(consulta.Fields("Coincidencia").Value, Object))
            Dim idPatologia As String = DirectCast(consulta.Fields("id_pat").Value, String)
            Dim nombrePatologia As String = DirectCast(consulta.Fields("Nombre_patologia").Value, String)
            Dim prioridadPatologia As String = DirectCast(consulta.Fields("prioridad").Value, String)
            Dim campoMedico As String = DirectCast(consulta.Fields("especialidad").Value, String)
            listaDiagnostico.Add(New Diagnostico(nombrePatologia, prioridadPatologia, idPatologia, campoMedico, idPaciente, probabilidadPatologia, fechaString))
            consulta.MoveNext()
        End While


        Return listaDiagnostico
    End Function

    Public Sub agregarDiagnostico_A_BD(diagnosticos As List(Of Diagnostico), paciente As Paciente, fecha As String, idDiagnostico As String)
        Dim connection As Connection = conectar()

        Dim agregar_A_Diagnostico As Recordset = connection.Execute("insert into diagnostico values('" + idDiagnostico + "');")
        Dim diagnostico As String = diagnosticos.ElementAt(0).id
        Dim agregar_A_Resulta As Recordset = connection.Execute("insert into resulta values('" + idDiagnostico + "','" + diagnostico + "');")
        Dim patologia_Mas_probable As String = diagnosticos.ElementAt(0).nombre
        Dim agregar_a_dianosticoapp As Recordset = connection.Execute("insert into diagnostico_app values('" + idDiagnostico + "','" + paciente.ID + "','" + fecha + "');")

    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------/////
    'Funciones para realizar el chat medico - paciente 
    'Se compone de dos partes

    'Parte del paciente

    Public Function medicosEspecializados(patologia As Patologia) As List(Of Medico)
        Dim connection As Connection = conectar()

        Dim obtenerMedicos As Recordset = connection.Execute("select usuario.*,medico.Lugar_de_trabajo,telefono_us.Telefono,campo_medico.nombre as 'campo_medico' " +
                                                             "from usuario inner join medico on " +
                                                             "usuario.ID_US = medico.ID_MED inner join telefono_us on " +
                                                             "usuario.ID_US = telefono_us.ID_US inner join especializado on " +
                                                             "medico.ID_MED = especializado.id_medE inner join campo_medico on " +
                                                             "especializado.id_campomedicoE = campo_medico.id_campomedico inner join trata on " +
                                                             "campo_medico.id_campomedico = trata.id_campomedicoT inner join patologia on " +
                                                             "trata.id_patT = patologia.ID_PAT " +
                                                             "where patologia.ID_PAT = '" + patologia.id + "';")
        Dim listaMedicos As New List(Of Medico)

        While (Not obtenerMedicos.EOF)
            Dim primernombre As String = TryCast(obtenerMedicos.Fields("nombre").Value, String)
            Dim segundonombre As String = TryCast(obtenerMedicos.Fields("segundo_nombre").Value, String)
            Dim primerapellido As String = TryCast(obtenerMedicos.Fields("apellido").Value, String)
            Dim segundoapellido As String = TryCast(obtenerMedicos.Fields("segundo_apellido").Value, String)
            Dim email As String = TryCast(obtenerMedicos.Fields("email").Value, String)
            Dim id As String = TryCast(obtenerMedicos.Fields("id_us").Value, String)
            Dim direccion As String = TryCast(obtenerMedicos.Fields("direccion").Value, String)
            Dim ci As String = TryCast(obtenerMedicos.Fields("ci").Value, String)
            Dim contraseña As String = TryCast(obtenerMedicos.Fields("contrasenia").Value, String)
            Dim sexo As String = TryCast(obtenerMedicos.Fields("sexo").Value, String)
            Dim fechaBaseDatos As Date = TryCast(obtenerMedicos.Fields("FDN").Value, Object)
            Dim fechaString As String = Format(fechaBaseDatos, "yyyy/MM/dd")
            Dim lugardetrabajo As String = TryCast(obtenerMedicos.Fields("lugar_de_trabajo").Value, String)
            Dim especialidad As String = TryCast(obtenerMedicos.Fields("campo_medico").Value, String)
            Dim telefono As String = TryCast(obtenerMedicos.Fields("telefono").Value, String)

            listaMedicos.Add(New Medico(primernombre, segundonombre, primerapellido, segundoapellido, email, id, direccion, ci, contraseña,
                                        especialidad, telefono, fechaString, sexo, lugardetrabajo))
            obtenerMedicos.MoveNext()
        End While
        Return listaMedicos
    End Function

    Public Sub crearSalaChat(fecha As String, medico As Medico, paciente As Paciente, idDiagnostico As String)
        Dim connection As Connection = conectar()
        Dim idsala As String = codigoRandom(6)
        Dim crearsala As Recordset = connection.Execute("insert into sala values('" + idsala + "','" + fecha + "','P');")
        Dim insetarPacienteEnSala As Recordset = connection.Execute("insert into chatea values('" + paciente.ID + "','" + idsala + "');")
        Dim insertarMedico As Recordset = connection.Execute("insert into atiende values('" + idsala + "','" + medico.ID + "');")
        Dim crearDiagnostico_medico As Recordset = connection.Execute("insert into diagnostico_med values('" + idDiagnostico + "','" + fecha + "','" + medico.ID + "')")

    End Sub

    Public Function obtenerSolicitudesAceptadas(paciente As Paciente) As List(Of Sala_Chat)
        Dim connection As Connection = conectar()
        Dim obtenerSolicitudes As Recordset = connection.Execute("select Cid_sala,sala.estado,sala.fecha,usuario.Nombre,usuario.Apellido,atiende.Aid_medico " +
                                                                 "from paciente inner join chatea on paciente.id_pac = chatea.Cid_pac inner join sala on " +
                                                                 "chatea.Cid_sala = sala.id_sala inner join atiende on sala.id_sala = atiende.Aid_sala inner join medico on " +
                                                                 "atiende.Aid_medico = medico.ID_MED inner join usuario on " +
                                                                 "medico.ID_MED = usuario.ID_US where Cid_pac = '" + paciente.ID + "' and sala.estado ='C';")
        If obtenerSolicitudes.EOF = True Then
            Throw New Exception("No hay ninguna solicitud aceptada por un medico.")
        Else
            Dim listaSalas As New List(Of Sala_Chat)

            While (Not obtenerSolicitudes.EOF)
                Dim id_sala As String = TryCast(obtenerSolicitudes.Fields("Cid_sala").Value, String)
                Dim fechaBaseDatos As Date = TryCast(obtenerSolicitudes.Fields("fecha").Value, Object)
                Dim fechaString As String = Format(fechaBaseDatos, "yyyy/MM/dd")
                Dim estado As String = TryCast(obtenerSolicitudes.Fields("estado").Value, String)
                Dim id_usuario As String = TryCast(obtenerSolicitudes.Fields("Aid_medico").Value, String)
                Dim nombre_usuario As String = TryCast(obtenerSolicitudes.Fields("nombre").Value, String)
                Dim apellido_usuario As String = TryCast(obtenerSolicitudes.Fields("apellido").Value, String)
                listaSalas.Add(New Sala_Chat(id_sala, fechaString, estado, id_usuario, nombre_usuario, apellido_usuario))
                obtenerSolicitudes.MoveNext()
            End While
            Return listaSalas
        End If

    End Function

    '------------------------------------------------------------
    'Parte del medico

    Public Function obtenerSolicitudesChatPendientes(medico As Medico) As List(Of Sala_Chat)
        Dim connection As Connection = conectar()
        Dim obtenerSolicitudes As Recordset = connection.Execute("select usuario.nombre,usuario.apellido,sala.*,chatea.Cid_pac " +
                                                                 "from sala inner join atiende on sala.id_sala = atiende.Aid_sala inner join chatea on " +
                                                                 "chatea.Cid_sala = sala.id_sala inner join paciente on chatea.Cid_pac = paciente.ID_PAC inner join usuario on " +
                                                                 "paciente.id_pac = usuario.id_us where Aid_medico = '" + medico.ID + "' and estado = 'P' " +
                                                                 "order by fecha desc;")
        If obtenerSolicitudes.EOF = True Then
            Throw New Exception("No hay ninguna solicitud nueva.")
        Else
            Dim listaSalas As New List(Of Sala_Chat)

            While (Not obtenerSolicitudes.EOF)
                Dim id_sala As String = TryCast(obtenerSolicitudes.Fields("id_sala").Value, String)
                Dim fechaBaseDatos As Date = TryCast(obtenerSolicitudes.Fields("fecha").Value, Object)
                Dim fechaString As String = Format(fechaBaseDatos, "yyyy/MM/dd")
                Dim estado As String = TryCast(obtenerSolicitudes.Fields("estado").Value, String)
                Dim id_usuario As String = TryCast(obtenerSolicitudes.Fields("Cid_pac").Value, String)
                Dim nombre_usuario As String = TryCast(obtenerSolicitudes.Fields("nombre").Value, String)
                Dim apellido_usuario As String = TryCast(obtenerSolicitudes.Fields("apellido").Value, String)
                listaSalas.Add(New Sala_Chat(id_sala, fechaString, estado, id_usuario, nombre_usuario, apellido_usuario))
                obtenerSolicitudes.MoveNext()
            End While
            Return listaSalas
        End If

    End Function

    Public Sub aceptarSolicitud_De_Chat(id_sala As String)
        Dim connection As Connection = conectar()
        Dim cambiarEstado As Recordset = connection.Execute("update sala set estado ='C' where id_sala ='" + id_sala + "';")
    End Sub

    Public Function obtenerSolicitudesChat_EnCurso(medico As Medico) As List(Of Sala_Chat)
        Dim connection As Connection = conectar()
        Dim obtenerSolicitudes As Recordset = connection.Execute("select usuario.nombre,usuario.apellido,sala.*,atiende.Aid_medico,chatea.Cid_pac " +
                                                                 "from sala inner join atiende on sala.id_sala = atiende.Aid_sala inner join chatea on " +
                                                                 "chatea.Cid_sala = sala.id_sala inner join paciente on chatea.Cid_pac = paciente.ID_PAC inner join usuario on " +
                                                                 "paciente.id_pac = usuario.id_us where Aid_medico = '" + medico.ID + "' and estado = 'C' ")
        Dim listaSalas As New List(Of Sala_Chat)

        While (Not obtenerSolicitudes.EOF)
            Dim id_sala As String = TryCast(obtenerSolicitudes.Fields("id_sala").Value, String)
            Dim fechaBaseDatos As Date = TryCast(obtenerSolicitudes.Fields("fecha").Value, Object)
            Dim fechaString As String = Format(fechaBaseDatos, "yyyy/MM/dd")
            Dim estado As String = TryCast(obtenerSolicitudes.Fields("estado").Value, String)
            Dim id_usuario As String = TryCast(obtenerSolicitudes.Fields("Cid_pac").Value, String)
            Dim nombre_usuario As String = TryCast(obtenerSolicitudes.Fields("nombre").Value, String)
            Dim apellido_usuario As String = TryCast(obtenerSolicitudes.Fields("apellido").Value, String)
            listaSalas.Add(New Sala_Chat(id_sala, fechaString, estado, id_usuario, nombre_usuario, apellido_usuario))
            obtenerSolicitudes.MoveNext()
        End While
        Return listaSalas
    End Function

    '---------------------------------------------------------------------------------------------------------
    'Funciones para obtener los mensajes y mandar nuevos


    'enviar mensaje
    Public Sub enviarMensajePaciente(contenido As String, id_sala As String, fecha As String)
        Dim connection As Connection = conectar()
        Dim numeroMensaje As Recordset = connection.Execute("select nro_msg from mensaje where Sid_sala ='" + id_sala + "' order by nro_msg desc limit 1;")
        Dim numero As Integer
        If numeroMensaje.EOF = True Then
            numero = 1
        Else
            Dim numeroBD As Integer = DirectCast(numeroMensaje.Fields("nro_msg").Value, Integer)
            numero = numeroBD + 1
        End If
        Dim mensaje As Recordset = connection.Execute("insert into mensaje values(" + numero.ToString + ",'" + contenido + "','" + fecha + "','Paciente','" + id_sala + "');")

    End Sub

    Public Sub enviarMensajeMedico(contenido As String, id_sala As String, fecha As String)
        Dim connection As Connection = conectar()
        Dim numeroMensaje As Recordset = connection.Execute("select nro_msg from mensaje where Sid_sala ='" + id_sala + "' order by nro_msg desc limit 1;")
        Dim numero As Integer
        If numeroMensaje.EOF = True Then
            numero = 1
        Else
            Dim numeroBD As Integer = DirectCast(numeroMensaje.Fields("nro_msg").Value, Integer)
            numero = numeroBD + 1
        End If
        Dim mensaje As Recordset = connection.Execute("insert into mensaje values(" + numero.ToString + ",'" + contenido + "','" + fecha + "','Medico','" + id_sala + "');")

    End Sub

    'Recibir mensajes (Todos)
    Public Function obtenerMensajes(id_sala As String) As List(Of Mensaje)
        Dim connection As Connection = conectar()
        Dim listaMensajes As New List(Of Mensaje)
        Dim mensajes As Recordset = connection.Execute("select contenido,quienEnvia,fechaM from mensaje where Sid_sala ='" + id_sala + "';")

        While (Not mensajes.EOF)
            Dim contenido As String = TryCast(mensajes.Fields("contenido").Value, String)
            Dim emisor As String = TryCast(mensajes.Fields("quienEnvia").Value, String)
            Dim fechaBaseDatos As Date = TryCast(mensajes.Fields("fechaM").Value, Object)
            Dim fechaString As String = Format(fechaBaseDatos, "yyyy/MM/dd")
            listaMensajes.Add(New Mensaje(contenido, emisor, fechaString))
            mensajes.MoveNext()
        End While
        Return listaMensajes
    End Function

    '------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Funciones para el historial de consulta y ingresar nuevas consultas al historial.
    Public Function obtenerIDDiagnostico(idmedico As String) As String
        Dim connection As Connection = conectar()
        Dim consulta As Recordset = connection.Execute("select diagnostico_med.id_Dmed " +
                                                        "from paciente inner join chatea on " +
                                                        "paciente.ID_PAC = chatea.Cid_pac inner join sala on " +
                                                        "chatea.Cid_sala = sala.id_sala inner join atiende on " +
                                                        "sala.id_sala = atiende.Aid_sala inner join medico on " +
                                                        "atiende.Aid_medico = medico.ID_MED inner join diagnostico_med on " +
                                                        "medico.ID_MED = diagnostico_med.Did_med " +
                                                        "where medico.id_med = '" + idmedico + "';")
        Dim idDiag As String = TryCast(consulta.Fields("id_Dmed").Value, String)
        Return idDiag
    End Function

    Public Sub finalizarConsultaMedico(contenido As String, id_tratamiento As String, id_medico As String, id_diag As String, id_sala As String)
        Dim connection As Connection = conectar()
        Dim consulta As Recordset = connection.Execute("insert into tratamiento values('" + id_tratamiento + "','" + contenido + "','" + id_medico + "','" + id_diag + "')")
        Dim cambiarEstado As Recordset = connection.Execute("update sala set estado ='F' where id_sala ='" + id_sala + "';")
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------------------
    'Funciones para obtener un solo medico o paciente, para tener un perfil o cualquier dato que se desee.
    Public Function obtenerUnPaciente(ID_sala As String) As Paciente
        Dim connection As Connection = conectar()
        Dim fechaBaseDatos As Date
        Dim fechaString As String
        Dim nombre, segundonombre, apellido, segundoapellido, email, direccion, ci, contraseña, telefono, sexo, peso, altura, patologiaprevia, id As String
        Dim obtenerPaciente As Recordset = connection.Execute("select usuario.*,telefono_us.Telefono,paciente.altura,paciente.PatologiasP,paciente.peso,sala.id_sala " +
                                                              "from usuario inner join paciente on " +
                                                              "usuario.ID_US = paciente.ID_PAC join telefono_us on " +
                                                              "usuario.ID_US = telefono_us.ID_US inner join chatea on " +
                                                              "paciente.ID_PAC = chatea.Cid_pac inner join sala on " +
                                                              "chatea.Cid_sala = sala.id_sala inner join atiende on " +
                                                              "sala.id_sala = atiende.Aid_sala where sala.id_sala = '" + ID_sala + "';")

        id = TryCast(obtenerPaciente.Fields("id_us").Value, String)
        nombre = TryCast(obtenerPaciente.Fields("Nombre").Value, String)
        apellido = TryCast(obtenerPaciente.Fields("Apellido").Value, String)
        email = TryCast(obtenerPaciente.Fields("Email").Value, String)
        direccion = TryCast(obtenerPaciente.Fields("Direccion").Value, String)
        ci = TryCast(obtenerPaciente.Fields("CI").Value, String)
        contraseña = TryCast(obtenerPaciente.Fields("Contrasenia").Value, String)
        Dim consultaTelefono As Recordset = connection.Execute("select telefono from telefono_us where id_us ='" + id + "';")
        telefono = TryCast(consultaTelefono.Fields("Telefono").Value, String)
        fechaBaseDatos = TryCast(obtenerPaciente.Fields("FDN").Value, Object)
        fechaString = Format(fechaBaseDatos, "yyyy/MM/dd")
        peso = TryCast(obtenerPaciente.Fields("peso").Value, String)
        altura = TryCast(obtenerPaciente.Fields("altura").Value, String)
        patologiaprevia = TryCast(obtenerPaciente.Fields("patologiasp").Value, String)
        segundonombre = TryCast(obtenerPaciente.Fields("segundo_nombre").Value, String)
        segundoapellido = TryCast(obtenerPaciente.Fields("segundo_apellido").Value, String)
        sexo = TryCast(obtenerPaciente.Fields("Sexo").Value, String)
        Dim paciente As New Paciente(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fechaString, sexo, peso, altura, patologiaprevia)

        Return paciente
    End Function


    Public Function obtenerUnMedico(id_sala As String) As Medico
        Dim connection As Connection = conectar()
        Dim fechaBaseDatos As Date
        Dim fechaString As String
        Dim id, nombre, segundonombre, apellido, segundoapellido, email, direccion, ci, contraseña, especializacion, telefono, sexo, lugardetrabajo As String
        Dim obtenerMedico As Recordset = connection.Execute("select usuario.*, telefono_us.Telefono, medico.Lugar_de_trabajo, campo_medico.nombre, sala.id_sala " +
                                                            "from usuario inner Join medico On usuario.ID_US = medico.ID_MED inner Join telefono_us On " +
                                                            "Usuario.ID_US = telefono_us.ID_US inner Join especializado On medico.ID_MED = especializado.id_medE inner Join campo_medico On " +
                                                            "especializado.id_campomedicoE = campo_medico.id_campomedico inner Join atiende On medico.ID_MED = atiende.Aid_medico inner Join sala On " +
                                                            "atiende.Aid_sala = sala.id_sala Where sala.id_sala = '" + id_sala + "';")

        id = TryCast(obtenerMedico.Fields("id_us").Value, String)
        ci = TryCast(obtenerMedico.Fields("CI").Value, String)
        nombre = TryCast(obtenerMedico.Fields("nombre").Value, String)
        apellido = TryCast(obtenerMedico.Fields("apellido").Value, String)
        email = TryCast(obtenerMedico.Fields("email").Value, String)
        direccion = TryCast(obtenerMedico.Fields("direccion").Value, String)
        Dim consultaTelefono As Recordset = connection.Execute("select telefono from telefono_us where id_us ='" + id + "';")
        telefono = TryCast(consultaTelefono.Fields("Telefono").Value, String)
        fechaBaseDatos = TryCast(obtenerMedico.Fields("FDN").Value, Object)
        fechaString = Format(fechaBaseDatos, "yyyy/MM/dd")
        especializacion = TryCast(obtenerMedico.Fields("Campo").Value, String)
        segundonombre = TryCast(obtenerMedico.Fields("segundo_nombre").Value, String)
        segundoapellido = TryCast(obtenerMedico.Fields("segundo_apellido").Value, String)
        lugardetrabajo = TryCast(obtenerMedico.Fields("Lugar_de_trabajo").Value, String)
        sexo = TryCast(obtenerMedico.Fields("Sexo").Value, String)
        contraseña = TryCast(obtenerMedico.Fields("contrasenia").Value, String)
        Dim medico As New Medico(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, especializacion, telefono, fechaString, sexo, lugardetrabajo)
        Return medico
    End Function



End Class


