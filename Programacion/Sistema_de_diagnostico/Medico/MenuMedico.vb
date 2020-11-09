Imports Datos, Logica

Public Class MenuMedico

    Public medico As Medico
    Dim instancia As New LogicaAplicacion()
    Dim ejeX, ejeY As Integer
    Dim Arrastre As Boolean

    Dim listaConsultas_Pendientes As List(Of Sala_Chat)
    Dim listaConsultas_EnCurso As List(Of Sala_Chat)
    Dim listaMensajes As List(Of Mensaje)

    Dim id_sala As String
    Dim salaActiva As Boolean = False
    Dim paciente As Paciente
    Dim cambiarContraseña As Boolean = False
    Dim botonesChat As New List(Of Guna.UI2.WinForms.Guna2CircleButton)
    Dim listaHistorialConsulta As List(Of tratamiento)


    'Estas tres subrutinas permiten desplazar el formulario. 
    Private Sub LoginNew_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ejeX = e.X
        ejeY = e.Y
        Arrastre = True
    End Sub

    Private Sub LoginNew_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub LoginNew_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ejeX, Me.MousePosition.Y - Me.Location.Y - ejeY))
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------

    'Cuando se cargue la ventana se van a ocultar todos los paneles.
    'Se les da color a los botones (por si algo falla y no tienen el color preestablecido)
    'Se desactivan las funciones del chat
    'y por ultimo se colocan los datos del usuario ingresado en los labels de perfil
    Private Sub MenuPacienteNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        devolverColorBotonesMenu()
        labIniciales.Text = medico.nombre(0) + " " + medico.apellido(0)
        labNombre.Text = medico.nombre + " " + medico.apellido
        nullvisible()

        btnEnviar.Enabled = False
        btnVerPerfilPaciente.Enabled = False
        btnFinalizarConsulta.Enabled = False
    End Sub
    '----------------------------------------------------------------------------------------------------------------------------------------------
    'Botones que sirven para activar los paneles para las
    'funciones del programa.
    Private Sub btnConsPendientes_Click(sender As Object, e As EventArgs) Handles btnConsPendientes.Click
        devolverColorBotonesMenu()
        btnConsPendientes.FillColor = Color.FromArgb(38, 131, 108)
        nullvisible()
        cargarConsultasPendientes()
        panelConsultaPendiente.Visible = True
        refrescarChat.Stop()
    End Sub
    Private Sub btnHistorialdeConsultas_Click_1(sender As Object, e As EventArgs) Handles btnHistorialdeConsultas.Click
        devolverColorBotonesMenu()
        btnHistorialdeConsultas.FillColor = Color.FromArgb(38, 131, 108)
        cargarHistorialConsulta()
        nullvisible()
        panelHistorialConsulta.Visible = True
        refrescarChat.Stop()
    End Sub

    Private Sub btnChats_Click(sender As Object, e As EventArgs) Handles btnChats.Click
        devolverColorBotonesMenu()
        btnChats.FillColor = Color.FromArgb(38, 131, 108)

        nullvisible()
        cargarBurbujasChat()

        panelChat.Visible = True
        panelListaChats.Visible = True
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------------------
    'Este evento sirve para los botones del chat que se creen
    'toma el nombre del boton (el cual es la ID de la sala de chat)
    'y obtiene los mensajes (si hay) ademas de activar 
    'las funciones de el chat (como es "ver perfil", "finalizar consulta"
    '"enviar"), ademas de activar el timer para que actualize el chat.
    Private Sub btnChatsActivos_click(sender As Object, e As EventArgs)
        Dim boton As Guna.UI2.WinForms.Guna2CircleButton = DirectCast(sender, Guna.UI2.WinForms.Guna2CircleButton)

        id_sala = boton.Name
        paciente = instancia.obtenerUnPaciente(id_sala)
        btnEnviar.Enabled = True
        btnVerPerfilPaciente.Enabled = True
        btnFinalizarConsulta.Enabled = True
        salaActiva = True
        refrescarChat.Start()
        cargarMensajes()
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------------
    'Botones de minimizar y cerrar la aplicacion.
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------
    'Devuelve la ventana a la venana principal (ocultando todo)
    Private Sub labVolver_Click(sender As Object, e As EventArgs) Handles labVolver.Click
        nullvisible()
        If perfilChat Then
            panelChat.Visible = True
            panelListaChats.Visible = True
        End If
    End Sub
    '------------------------------------------------------------------------------------------------------------------------------------------
    'Se aceptan las solicitudes de los pacientes
    'los cuales aparecen en un lisview, cambiando su estado a En Curso
    Private Sub btnAceptarSolicitud_Click(sender As Object, e As EventArgs) Handles btnAceptarSolicitud.Click
        instancia.aceptarSolicitud_De_Chat(listaConsultas_Pendientes.ElementAt(lstConsultasPendientes.FocusedItem.Index).id_sala)
        MsgBox("Se acepto la solicitud con exito. Las solicitudes aceptadas se podran visualizar en la opcion de chat.")
        cargarConsultasPendientes()
    End Sub

    'Funcion para el timer, cuando se active.
    Private Sub refrescarChat_Tick(sender As Object, e As EventArgs) Handles refrescarChat.Tick
        Dim cantidadMensajes As Integer = instancia.obtenerMensajes(id_sala).Count
        If listaMensajes.Count = cantidadMensajes Then

        Else
            cargarMensajes()
        End If
    End Sub

    'Evento del boton enviar, donde envia el mensaje escrito en el TextBox
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If txtMensaje.Text.Count = 0 Then
        Else
            Dim fechaActual As Date = Date.Now
            Dim fechaString As String = Format(fechaActual, "yyyy/MM/dd")
            instancia.enviarMensaje(txtMensaje.Text, id_sala, fechaString, medico.ID, medico.nombre + " " + medico.apellido(0) + ".")
            txtMensaje.Clear()
            cargarMensajes()
        End If
    End Sub

    'Misma funcion que el boton enviar, solo que este evento
    'funciona cuando el usuario da Enter cuando el foco
    'esta en el TextBox de mensaje.
    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMensaje.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) And salaActiva = True Then
            If txtMensaje.Text.Count = 0 Then

            Else
                Dim fechaActual As Date = Date.Now
                Dim fechaString As String = Format(fechaActual, "yyyy/MM/dd")
                instancia.enviarMensaje(txtMensaje.Text, id_sala, fechaString, medico.ID, medico.nombre + " " + medico.apellido(0) + ".")
                txtMensaje.Clear()
                cargarMensajes()
            End If
        End If
    End Sub

    'La variable "perfilChat" sirve para saber si
    'si el perfil que se quiere ver es de paciente o medico.
    Dim perfilChat As Boolean = False

    'Este evento sirve para ver el perfil de un medico.
    Private Sub labVerPerfil_Click(sender As Object, e As EventArgs) Handles labVerPerfil.Click
        nullvisible()
        devolverColorBotonesMenu()
        cambiarContraseña = True
        If cambiarContraseña Then
            btnCambiarContraseña.Visible = True
        End If
        paneldatosPaciente.Visible = False
        panelPerfil.Visible = True
        panelDatosMedicos.Visible = True
        labFechaDeNacimientoMED.Text = medico.fechadenacimiento
        labLugarDeTrabajoMED.Text = medico.lugarDeTrabajo
        labEspecialidadMED.Text = medico.especializacion
        labDireccionMED.Text = medico.Direccion
        labTelefonoMED.Text = medico.telefono
        labPerfilNombre.Text = medico.nombre + " " + medico.apellido + " " + medico.segundoapellido
        labPerfilID.Text = medico.ID
        refrescarChat.Stop()
        perfilChat = False
    End Sub

    'Este evento sirve para ver el perfil de un paciente
    'el mismo tiene que estar en una sala de chat con el medico
    Private Sub btnVerPerfilPaciente_Click(sender As Object, e As EventArgs) Handles btnVerPerfilPaciente.Click
        cambiarContraseña = False
        If cambiarContraseña = False Then
            btnCambiarContraseña.Visible = False
        End If
        panelDatosMedicos.Visible = False
        panelPerfil.Visible = True
        paneldatosPaciente.Visible = True
        labFechaDeNacimientoPAC.Text = paciente.fechadenacimiento
        labTelefonoPAC.Text = paciente.telefono
        labDireccionPAC.Text = paciente.Direccion
        txtPatologiasPreviasPAC.Text = paciente.patologiaPrevia
        labPerfilNombre.Text = paciente.nombre + " " + paciente.apellido + " " + paciente.segundoapellido
        labPerfilID.Text = paciente.ID
        perfilChat = True
        panelChat.Visible = False
        panelListaChats.Visible = False
    End Sub

    'Este evento abre la ventana de finalizar consulta
    'con los parametros que se precisan
    'como los datos del paciente, medico y la ID de la sala
    'ademas de volver a cargar los chats activos una vez
    'cerrada la ventana de finalizar consulta.
    Private Sub btnFinalizarConsulta_Click(sender As Object, e As EventArgs) Handles btnFinalizarConsulta.Click
        Dim finalizarConsulta As New FinalizarConsulta()
        finalizarConsulta.paciente = paciente
        finalizarConsulta.medico = medico
        finalizarConsulta.sala = id_sala
        finalizarConsulta.ShowDialog()

        cargarBurbujasChat()
    End Sub

    'Esta funcion llama a la ventana de cambiar contraseña
    'con los parametros del medico que esta logueado.
    Private Sub btnCambiarContraseña_Click(sender As Object, e As EventArgs) Handles btnCambiarContraseña.Click
        Dim cambiarContraseña As New CambiarContraseña
        cambiarContraseña.medico = medico
        cambiarContraseña.ShowDialog()
    End Sub

    '-----------------------------------------------------------------------------------------------------------
    'Estos dos eventos, le dan color a el label de "ver perfil"
    Private Sub labVerPerfil_MouseLeave(sender As Object, e As EventArgs) Handles labVerPerfil.MouseLeave
        labVerPerfil.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub labVerPerfil_MouseMove(sender As Object, e As MouseEventArgs) Handles labVerPerfil.MouseMove
        labVerPerfil.ForeColor = Color.FromArgb(0, 0, 255)
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------------
    'Estos eventos sirven para cargar datos, cambiar la visibilidad de los paneles
    'cambiar los colores de los botones, entre otras cosas.
    Public Sub nullvisible()
        panelConsultaPendiente.Visible = False
        panelHistorialConsulta.Visible = False
        panelPerfil.Visible = False
        panelChat.Visible = False
        panelListaChats.Visible = False
    End Sub

    Public Sub devolverColorBotonesMenu()
        btnConsPendientes.FillColor = Color.FromArgb(50, 174, 144)
        btnChats.FillColor = Color.FromArgb(50, 174, 144)
        btnHistorialdeConsultas.FillColor = Color.FromArgb(50, 174, 144)
    End Sub

    'Se cargan las consultas donde el estado sea Pendiente
    Public Sub cargarConsultasPendientes()
        lstConsultasPendientes.Clear()
        Try
            listaConsultas_Pendientes = instancia.obtenerSolicitudesChatPendientes(medico)
            For Each chat As Sala_Chat In listaConsultas_Pendientes
                lstConsultasPendientes.Items.Add(chat.nombre_usuario + " " + chat.apellido_usuario + " - " + chat.fecha)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Carga los mensajes ya escritos
    'si no existe ninguno, esta funcion no hace nada.
    Public Sub cargarMensajes()
        txtChat.Clear()
        Dim mensajesCompletos As String = ""

        If id_sala = Nothing Then

        Else
            listaMensajes = instancia.obtenerMensajes(id_sala)
            For Each mensaje As Mensaje In listaMensajes
                Dim lineaMensaje As String = mensaje.emisor & ": " & mensaje.contenido & Environment.NewLine
                mensajesCompletos = mensajesCompletos & Environment.NewLine & lineaMensaje
            Next
            txtChat.Text = mensajesCompletos
            txtChat.SelectionStart = txtChat.TextLength
            txtChat.ScrollToCaret()
        End If

    End Sub


    'Esta funcion crea botones circulares (de la extension GUNA)
    'y le da ciertos parametros, entre ellos se establece el nombre del boton
    'como la ID de la sala con el paciente.
    'Luego se agregan a el panel "listaChats".
    'Ademas siempre se limpian los chats que ya esten finalizados.
    Public Sub cargarBurbujasChat()
        For Each boton As Control In panelListaChats.Controls
            If ((TypeOf boton Is Guna.UI2.WinForms.Guna2CircleButton) AndAlso (boton.Name.Equals(id_sala))) Then
                panelListaChats.Controls.Remove(boton)
            End If
        Next
        listaConsultas_EnCurso = instancia.obtenerSolicitudesChat_EnCurso(medico)
        If listaConsultas_EnCurso.Count > 0 Then
            Dim separacion As Single = 1
            Dim indice As Integer = 1
            Do
                Dim botonChat As New Guna.UI2.WinForms.Guna2CircleButton()
                With botonChat
                    .Font = New Font("DejaVu Sans", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    .ForeColor = Color.Black
                    .Animated = True
                    .Location = New Point(11, separacion * 16)
                    .Name = listaConsultas_EnCurso.ElementAt(indice - 1).id_sala
                    .ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
                    .FillColor = Color.FromArgb(255, 255, 255)
                    .Size = New Size(55, 57)
                    .TabIndex = 0
                    .Text = listaConsultas_EnCurso.ElementAt(indice - 1).nombre_usuario(0) + listaConsultas_EnCurso.ElementAt(indice - 1).apellido_usuario(0)
                    AddHandler botonChat.Click, AddressOf btnChatsActivos_click
                End With
                panelListaChats.Controls.Add(botonChat)
                separacion = separacion + 4.2
                indice = indice + 1
                botonesChat.Add(botonChat)
            Loop While (indice < listaConsultas_EnCurso.Count + 1)

        End If
    End Sub

    Private Sub lstHistorialConsulta_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstHistorialConsulta.ItemSelectionChanged
        Dim tratamiento As Integer = lstHistorialConsulta.FocusedItem.Index
        txtContenido.Text = listaHistorialConsulta.ElementAt(tratamiento).contenido
    End Sub



    'Esta funcion se encargara de cargarlo las consultas que hayan sido antendidas
    'por el medico que se encuentre logeado en el momento.
    Public Sub cargarHistorialConsulta()
        lstHistorialConsulta.Clear()


        Try
            listaHistorialConsulta = instancia.obtenerHistorialConsultasM(medico.ID)
            For Each tratamiento As tratamiento In listaHistorialConsulta
                lstHistorialConsulta.Items.Add(tratamiento.nombre + " " + tratamiento.apellido + " - " + tratamiento.fecha)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class