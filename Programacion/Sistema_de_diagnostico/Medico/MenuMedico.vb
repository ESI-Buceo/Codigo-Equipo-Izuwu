Imports Datos, Logica

Public Class MenuMedico

    Public medico As Medico
    Dim instancia As New LogicaAplicacion()
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Dim listaConsultas_Pendientes As List(Of Sala_Chat)
    Dim listaConsultas_EnCurso As List(Of Sala_Chat)
    Dim listaMensajes As List(Of Mensaje)

    Dim id_sala As String

    Dim salaActiva As Boolean = False

    Dim paciente As Paciente

    Dim cambiarContraseña As Boolean = False
    'Estas tres subrutinas permiten desplazar el formulario. 

    Private Sub LoginNew_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        ex = e.X

        ey = e.Y

        Arrastre = True

    End Sub

    Private Sub LoginNew_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp

        Arrastre = False

    End Sub

    Private Sub LoginNew_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))

        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))

    End Sub



    Private Sub MenuPacienteNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        devolverColorBotonesMenu()
        labIniciales.Text = medico.nombre(0) + " " + medico.apellido(0)
        labNombre.Text = medico.nombre + " " + medico.apellido
        nullvisible()

        btnEnviar.Enabled = False
        btnVerPerfilPaciente.Enabled = False
        btnFinalizarConsulta.Enabled = False
    End Sub

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

        nullvisible()
        panelHistorialConsulta.Visible = True
        refrescarChat.Stop()
    End Sub

    Private Sub btnChats_Click(sender As Object, e As EventArgs) Handles btnChats.Click
        devolverColorBotonesMenu()
        btnChats.FillColor = Color.FromArgb(38, 131, 108)

        nullvisible()

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

            Loop While (indice < listaConsultas_EnCurso.Count + 1)

        End If
        panelChat.Visible = True
        panelListaChats.Visible = True
    End Sub

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles labVolver.Click
        panelPerfil.Visible = False
        paneldatosPaciente.Visible = False
        panelDatosMedicos.Visible = False
        If perfilChat Then
            panelChat.Visible = True
            panelListaChats.Visible = True
        End If
    End Sub
    Private Sub btnAceptarSolicitud_Click(sender As Object, e As EventArgs) Handles btnAceptarSolicitud.Click
        instancia.aceptarSolicitud_De_Chat(listaConsultas_Pendientes.ElementAt(lstConsultasPendientes.FocusedItem.Index).id_sala)
        MsgBox("Se acepto la solicitud con exito. Las solicitudes aceptadas se podran visualizar en la opcion de chat.")
        cargarConsultasPendientes()
    End Sub

    Private Sub refrescarChat_Tick(sender As Object, e As EventArgs) Handles refrescarChat.Tick
        Dim cantidadMensajes As Integer = instancia.obtenerMensajes(id_sala).Count
        If listaMensajes.Count = cantidadMensajes Then

        Else
            cargarMensajes()
        End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If txtMensaje.Text.Count = 0 Then

        Else
            Dim fechaActual As Date = Date.Now
            Dim fechaString As String = Format(fechaActual, "yyyy/MM/dd")
            instancia.enviarMensaje(txtMensaje.Text, id_sala, fechaString, medico.ID)
            txtMensaje.Clear()
            cargarMensajes()
        End If


    End Sub

    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMensaje.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) And salaActiva = True Then
            If txtMensaje.Text.Count = 0 Then

            Else
                Dim fechaActual As Date = Date.Now
                Dim fechaString As String = Format(fechaActual, "yyyy/MM/dd")
                instancia.enviarMensaje(txtMensaje.Text, id_sala, fechaString, medico.ID)
                txtMensaje.Clear()
                cargarMensajes()
            End If
        End If
    End Sub

    Private Sub labVerPerfil_MouseLeave(sender As Object, e As EventArgs) Handles labVerPerfil.MouseLeave
        labVerPerfil.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub labVerPerfil_MouseMove(sender As Object, e As MouseEventArgs) Handles labVerPerfil.MouseMove
        labVerPerfil.ForeColor = Color.FromArgb(0, 0, 255)
    End Sub

    Dim perfilChat As Boolean = False
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

    Private Sub btnFinalizarConsulta_Click(sender As Object, e As EventArgs) Handles btnFinalizarConsulta.Click
        Dim finalizarConsulta As New FinalizarConsulta()
        finalizarConsulta.paciente = paciente
        finalizarConsulta.medico = medico
        finalizarConsulta.sala = id_sala

        finalizarConsulta.ShowDialog()

    End Sub



    '-------------------------------------------------------------------------------------------------------------------------------------------------
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

    Private Sub btnCambiarContraseña_Click(sender As Object, e As EventArgs) Handles btnCambiarContraseña.Click
        Dim cambiarContraseña As New CambiarContraseña
        cambiarContraseña.medico = medico
        cambiarContraseña.ShowDialog()
    End Sub

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
End Class