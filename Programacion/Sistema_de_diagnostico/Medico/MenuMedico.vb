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
        btnConsPendientes.BackColor = Color.FromArgb(50, 174, 144)
        btnChats.BackColor = Color.FromArgb(50, 174, 144)
        btnHistorialdeConsultas.BackColor = Color.FromArgb(50, 174, 144)
        labIniciales.Text = medico.nombre(0) + " " + medico.apellido(0)
        labNombre.Text = medico.nombre + " " + medico.apellido
        nullvisible()
        refrescarChat.Start()
    End Sub

    Private Sub btnConsPendientes_Click(sender As Object, e As EventArgs) Handles btnConsPendientes.Click
        btnConsPendientes.BackColor = Color.FromArgb(38, 131, 108)
        btnChats.BackColor = Color.FromArgb(50, 174, 144)
        btnHistorialdeConsultas.BackColor = Color.FromArgb(50, 174, 144)
        nullvisible()
        cargarConsultasPendientes()
        panelConsultaPendiente.Visible = True
    End Sub

    Private Sub btnChats_Click(sender As Object, e As EventArgs) Handles btnChats.Click
        btnConsPendientes.BackColor = Color.FromArgb(50, 174, 144)
        btnChats.BackColor = Color.FromArgb(38, 131, 108)
        btnHistorialdeConsultas.BackColor = Color.FromArgb(50, 174, 144)
        nullvisible()

        listaConsultas_EnCurso = instancia.obtenerSolicitudesChat_EnCurso(medico)
        If listaConsultas_EnCurso.Count > 0 Then


            Dim separacion As Single = 1
            Dim indice As Integer = 1
            Do
                Dim botonChat As New Guna.UI2.WinForms.Guna2CircleButton()
                With botonChat

                    .Font = New Font("Segoe UI", 16.0!)
                    .ForeColor = Color.White
                    .Animated = True
                    .Location = New Point(11, separacion * 16)
                    .Name = listaConsultas_EnCurso.ElementAt(indice - 1).id_sala
                    .ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
                    .FillColor = Color.FromArgb(3, 187, 133)
                    .Size = New Size(55, 57)
                    .TabIndex = 0
                    .Text = listaConsultas_EnCurso.ElementAt(indice - 1).nombre_usuario(0) + " " + listaConsultas_EnCurso.ElementAt(indice - 1).apellido_usuario(0)
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
        cargarMensajes()

    End Sub


    Private Sub btnHistorialdeConsultas_Click_1(sender As Object, e As EventArgs) Handles btnHistorialdeConsultas.Click
        btnConsPendientes.BackColor = Color.FromArgb(50, 174, 144)
        btnChats.BackColor = Color.FromArgb(50, 174, 144)
        btnHistorialdeConsultas.BackColor = Color.FromArgb(38, 131, 108)

        nullvisible()
        panelHistorialConsulta.Visible = True
    End Sub


    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        Button1.BackColor = Color.FromArgb(255, 96, 96)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        panelPerfilPaciente.Visible = False
    End Sub

    Private Sub lbNombre_Click(sender As Object, e As EventArgs) Handles labNombre.Click
        labPerfilNombre.Text = medico.nombre
        labPerfilID.Text = medico.ID
        labPerfilLugarDeTrabajo.Text = medico.lugarDeTrabajo
        labPerfilDireccion.Text = medico.Direccion
        labPerfilEspecialidad.Text = medico.especializacion
        labPerfilTelefono.Text = medico.telefono
        labPerfilFechaDeNacimiento.Text = medico.fechadenacimiento

        panelPerfilPaciente.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAceptarSolicitud_Click(sender As Object, e As EventArgs) Handles btnAceptarSolicitud.Click
        instancia.aceptarSolicitud_De_Chat(listaConsultas_Pendientes.ElementAt(lstConsultasPendientes.FocusedItem.Index).id_sala)
        MsgBox("Se acepto la solicitud con exito. Las solicitudes aceptadas se podran visualizar en la opcion de chat.")
        cargarConsultasPendientes()
    End Sub

    Private Sub refrescarChat_Tick(sender As Object, e As EventArgs) Handles refrescarChat.Tick
        cargarMensajes()
    End Sub

    Private Sub txtEnviarMensaje_Click(sender As Object, e As EventArgs) Handles txtEnviarMensaje.Click
        Dim fechaActual As Date = Date.Now
        Dim fechaString As String = Format(fechaActual, "yyyy/MM/dd")
        instancia.enviarMensaje(txtMensaje.Text, id_sala, fechaString, medico.ID)
        txtMensaje.Clear()
        cargarMensajes()
    End Sub



    '-------------------------------------------------------------------------------------------------------------------------------------------------
    Public Sub nullvisible()
        panelConsultaPendiente.Visible = False
        panelHistorialConsulta.Visible = False
        panelPerfilPaciente.Visible = False
        panelChat.Visible = False
        panelListaChats.Visible = False
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



    Public Sub cargarMensajes()
        txtChat.Clear()
        Dim mensajesCompletos As String = ""
        If id_sala = Nothing Then

        Else
            listaMensajes = instancia.obtenerMensajes(id_sala)
            For Each mensaje As Mensaje In listaMensajes
                Dim lineaMensaje As String = mensaje.emisor & ": " & mensaje.contenido & Environment.NewLine
                mensajesCompletos = mensajesCompletos & lineaMensaje

            Next
            txtChat.Text = mensajesCompletos
        End If

    End Sub
End Class