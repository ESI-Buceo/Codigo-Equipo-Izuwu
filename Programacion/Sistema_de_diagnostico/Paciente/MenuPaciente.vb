﻿Imports Datos, Logica
Public Class MenuPaciente

    Public paciente As Paciente

    Dim ejeX, ejeY As Integer
    Dim Arrastre As Boolean
    Dim instancia As New LogicaAplicacion()
    Dim medico As Medico

    Dim SintomasSeleccionados As New List(Of Sintoma)
    Dim listaSintomas As List(Of Sintoma) = instancia.ObtenerSintoma()
    Dim filtroSintomas As New List(Of Sintoma)
    Dim listaResultadoDiag As List(Of Diagnostico)
    Dim listaHistorialConsulta As List(Of tratamiento)

    Dim listaChatsAceptados As List(Of Sala_Chat)
    Dim listaMensajes As List(Of Mensaje)

    Dim id_sala As String
    Dim salaActiva As Boolean = False
    Dim cambiarContraseña As Boolean = False
    Dim idDiagnostico As String

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

    '------------------------------------------------------------------------------------------------------------------------------------------------

    'Cuando se cargue la ventana se van a ocultar todos los paneles.
    'Se les da color a los botones (por si algo falla y no tienen el color preestablecido)
    'Se desactivan las funciones del chat
    'y por ultimo se colocan los datos del usuario ingresado en los labels de perfil
    Private Sub MenuPacienteNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListaSintomas()
        devolverColorBotonesMenu()
        labIniciales.Text = paciente.nombre(0) + " " + paciente.apellido(0)
        labNombre.Text = paciente.nombre + " " + paciente.apellido
        nullvisible()
        cargarHistorialConsultas()
        btnEnviar.Enabled = False
        btnVerPerfilMedico.Enabled = False
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------
    'Botones que sirven para activar los paneles para las
    'funciones del programa.
    Private Sub btnRealizarDiagnostico_Click(sender As Object, e As EventArgs) Handles btnMenu_RealizarDiagnostico.Click
        devolverColorBotonesMenu()
        btnMenu_RealizarDiagnostico.FillColor = Color.FromArgb(24, 68, 122)

        nullvisible()

        panelRealizarDiagnostico.Visible = True
        panelRealizarDiagnostico2.Visible = True
        labDiagnostico1.Visible = False
        labDiagnostico2.Visible = False
        labDiagnostico3.Visible = False
        labDiagnostico4.Visible = False

        cargarListaSintomas()
        lstSintomasSeleccionados.Clear()
        lstSintomasSeleccionados.Enabled = True
        btnAgregar.Enabled = True
        btnEliminar.Enabled = True
        btnRealizardiagnostico.Enabled = True
        btnFinalizarConsulta.Enabled = True
    End Sub
    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles labVolverPerfil.Click
        nullvisible()
        If perfilChat Then
            panelChat.Visible = True
            panelListaChats.Visible = True
        End If
    End Sub
    Private Sub btnChats_Click(sender As Object, e As EventArgs) Handles btnChats1.Click
        btnMenu_RealizarDiagnostico.BackColor = Color.FromArgb(40, 117, 207)
        btnChats1.FillColor = Color.FromArgb(24, 68, 122)
        btnCerrarSesion.FillColor = Color.FromArgb(40, 117, 207)
        nullvisible()
        cargarBurbujasChat()
        panelChat.Visible = True
        panelListaChats.Visible = True
    End Sub
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        devolverColorBotonesMenu()
        btnCerrarSesion.FillColor = Color.FromArgb(24, 68, 122)
        Dim pregunta As DialogResult = MessageBox.Show("¿Esta seguro quiere salir?", "Cerrar sesion", MessageBoxButtons.YesNo)
        If pregunta = DialogResult.Yes Then
            Me.Hide()
            Login.ShowDialog()
            Me.Close()
        End If

        nullvisible()
    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------------------------
    'Este evento sirve para los botones del chat que se creen
    'toma el nombre del boton (el cual es la ID de la sala de chat)
    'y obtiene los mensajes (si hay) ademas de activar 
    'las funciones de el chat (como es "ver perfil",
    '"enviar"), ademas de activar el timer para que actualize el chat.
    Private Sub btnChatsActivos_click(sender As Object, e As EventArgs)
        Dim boton As Guna.UI2.WinForms.Guna2CircleButton = DirectCast(sender, Guna.UI2.WinForms.Guna2CircleButton)

        id_sala = boton.Name
        medico = instancia.obtenerUnMedico(id_sala)
        btnVerPerfilMedico.Enabled = True
        btnEnviar.Enabled = True
        salaActiva = True
        cargarMensajes()
        refrescarChat.Start()
    End Sub



    'La variable "perfilChat" sirve para saber si
    'si el perfil que se quiere ver es de paciente o medico.
    Dim perfilChat As Boolean = False


    Private Sub labNombre_Click(sender As Object, e As EventArgs) Handles labNombre.Click
        cambiarContraseña = True
        If cambiarContraseña Then
            btnEditarPerfil.Visible = True
        End If
        labPerfilNombre.Text = paciente.nombre + " " + paciente.apellido
        labPerfilID.Text = paciente.ID
        labPerfilFechaDeNacimiento.Text = paciente.fechadenacimiento
        labPerfilTelefono.Text = paciente.telefono
        labPerfilDireccion.Text = paciente.Direccion
        txtPerfilPatologias.Text = paciente.patologiaPrevia
        devolverColorBotonesMenu()
        nullvisible()
        panelDatosMedicos.Visible = False
        panelPerfil.Visible = True
        refrescarChat.Stop()
    End Sub

    'Este evento sirve para ver el perfil de un medico.
    Private Sub btnVerPerfilMedico_Click(sender As Object, e As EventArgs) Handles btnVerPerfilMedico.Click
        cambiarContraseña = False
        If cambiarContraseña = False Then
            btnEditarPerfil.Visible = False
        End If
        panelPerfil.Visible = True
        labPerfilNombre.Text = medico.nombre + " " + medico.apellido
        labPerfilID.Text = medico.ID
        labLugardeTrabajoMED.Text = medico.lugarDeTrabajo
        labEspecialidadMED.Text = medico.especializacion
        panelDatosMedicos.Visible = True
        paneldatosPaciente.Visible = False
        panelChat.Visible = False
        panelListaChats.Visible = False

    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------------
    'Botones para cerrar y minimizar la aplicacion.
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------
    'Label que deja volver a el menu principal.
    Private Sub labVolverDisgnostico_Click(sender As Object, e As EventArgs) Handles labVolverDisgnostico.Click
        nullvisible()
        devolverColorBotonesMenu()
    End Sub


    '............................................................................................................................
    'Boton que recive el diagnostico dado por la aplicacion
    'y muestra las patologias en los labels correspondientes
    'siendo el primero el que mayor coincidencias tiene
    'y el ultimo el que menos.
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnRealizardiagnostico.Click
        Try
            Dim fechaActual As Date = Date.Now
            Dim fechaString As String = Format(fechaActual, "yyyy/MM/dd")

            instancia.agregarSintomasPaciente(SintomasSeleccionados, paciente, fechaString)
            listaResultadoDiag = instancia.diagnostico()

            labDiagnostico1.Text = listaResultadoDiag.ElementAt(0).nombre
            labDiagnostico1.Visible = True

            If listaResultadoDiag.Count >= 2 Then
                labDiagnostico2.Text = listaResultadoDiag.ElementAt(1).nombre
                labDiagnostico2.Visible = True
            End If

            If listaResultadoDiag.Count >= 3 Then
                labDiagnostico3.Text = listaResultadoDiag.ElementAt(2).nombre
                labDiagnostico3.Visible = True
            End If

            If listaResultadoDiag.Count = 4 Then
                labDiagnostico4.Text = listaResultadoDiag.ElementAt(3).nombre
                labDiagnostico4.Visible = True
            End If
            idDiagnostico = instancia.codigoRandom(5)
            instancia.agregarDiagnostico_A_BD(listaResultadoDiag, paciente, fechaString, idDiagnostico)

            lstSintomasSeleccionados.Enabled = False
            btnAgregar.Enabled = False
            btnEliminar.Enabled = False
            btnRealizardiagnostico.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Este boton agrega el sintoma que este seleccionado en el listView
    '"lstSintomas" y lo agrega a el otro listView "lstSintomasSeleccionados"
    'asi el usuario puede visualizar cuales agrego y cuales no.
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If lstSintomas.SelectedItems.Count = 0 Then
            MsgBox("No hay ningún síntoma seleccionado.")

        Else
            SintomasSeleccionados.Add(New Sintoma(filtroSintomas.ElementAt(lstSintomas.FocusedItem.Index).nombre, filtroSintomas.ElementAt(lstSintomas.FocusedItem.Index).id))
            listaSintomas.Remove(filtroSintomas.ElementAt(lstSintomas.FocusedItem.Index))
            cargarListaSintomas()
            lstSintomasSeleccionados.Clear()
            For Each sintoma As Sintoma In SintomasSeleccionados
                lstSintomasSeleccionados.Items.Add(sintoma.nombre)
            Next
            lstSintomas.SelectedItems.Clear()
            txtBusquedaSintomas.Clear()

        End If
    End Sub

    'Este boton elimina un sintoma seleccionado en el listView "lstSintomasSeleccionados
    'y lo devuelve a la lista anterior "lstSintomas".
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lstSintomasSeleccionados.SelectedItems.Count = 0 Then
            MsgBox("Ningún síntoma seleccionado.")
        Else
            listaSintomas.Add(SintomasSeleccionados.ElementAt(lstSintomasSeleccionados.FocusedItem.Index))
            SintomasSeleccionados.Remove(SintomasSeleccionados.ElementAt(lstSintomasSeleccionados.FocusedItem.Index))
            lstSintomasSeleccionados.Items.Remove(lstSintomasSeleccionados.Items.Item(lstSintomasSeleccionados.FocusedItem.Index))
            cargarListaSintomas()

        End If
    End Sub

    'Funcion para que el textbox pueda filtrar (o buscar) un sintoma en particular.
    Private Sub txtBusquedaSintomas_TextChanged_1(sender As Object, e As EventArgs) Handles txtBusquedaSintomas.TextChanged
        cargarListaSintomas()
    End Sub

    'Este boton lanza un mensaje de pregunta el cual deja al usuario
    'elegir si quiere iniciar un chat con un medico o no.

    'Si el usuario responde que si, se llamara a la ventana "finalizar consulta"
    'si el usuario responde que no, se "borraran" los paneles de la consulta y se mostrara
    'el menu principal.
    Private Sub btnFinalizarConsulta_Click(sender As Object, e As EventArgs) Handles btnFinalizarConsulta.Click
        Dim pregunta As DialogResult = MessageBox.Show("Consulta finalizada. ¿Desea comunicarse con un médico?", "Finalizar consulta", MessageBoxButtons.YesNo)

        If pregunta = DialogResult.Yes Then
            Dim solicitudchat As New SolicitudChat()
            Dim ResultadoPatologia As New Patologia(listaResultadoDiag.ElementAt(0).nombre, listaResultadoDiag.ElementAt(0).prioridad, listaResultadoDiag.ElementAt(0).id, listaResultadoDiag.ElementAt(0).especialidad)
            solicitudchat.patologia = ResultadoPatologia
            solicitudchat.paciente = paciente
            solicitudchat.idDiagnostico = idDiagnostico

            btnFinalizarConsulta.Enabled = False
            solicitudchat.ShowDialog()

        ElseIf pregunta = DialogResult.No Then
            panelRealizarDiagnostico.Visible = False
            panelRealizarDiagnostico2.Visible = False
            limpiarDiagnostico()
        End If
    End Sub

    '------------------------------------------------------------------------------------------------------------------------------------------------
    'Este evento abre la ventana de editar perfil para el paciente
    'y dandole como parametro el usuario logueado.
    Private Sub btnEditarPerfil_Click(sender As Object, e As EventArgs) Handles btnEditarPerfil.Click
        Dim editarperfil As New EditarPerfil
        editarperfil.paciente = paciente
        editarperfil.ShowDialog()

    End Sub

    'Funcion para el timer, para que actualize el chat constantemente.
    Private Sub refrescarChat_Tick(sender As Object, e As EventArgs) Handles refrescarChat.Tick
        cargarMensajes()
    End Sub

    'Evento del boton enviar, donde envia el mensaje escrito en el TextBox
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If txtMensaje.Text.Count = 0 Then

        Else
            Dim fechaActual As Date = Date.Now
            Dim fechaString As String = Format(fechaActual, "yyyy/MM/dd")
            instancia.enviarMensaje(txtMensaje.Text, id_sala, fechaString, paciente.ID, paciente.nombre + " " + paciente.apellido(0) + ".")
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
                instancia.enviarMensaje(txtMensaje.Text, id_sala, fechaString, paciente.ID, paciente.nombre + " " + paciente.apellido(0) + ".")
                txtMensaje.Clear()
                cargarMensajes()
            End If
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Funciones para la aplicacion que se van a repetir (Cargar listas, hacer invisibles sectores de la ventana, etc.)
    Public Sub cargarListaSintomas()
        filtroSintomas.Clear()
        For Each filtro As Sintoma In listaSintomas
            If filtro.nombre.ToLower.StartsWith(txtBusquedaSintomas.Text.ToLower) Then
                filtroSintomas.Add(filtro)
            End If
        Next
        lstSintomas.Clear()
        For Each resultado As Sintoma In filtroSintomas
            lstSintomas.Items.Add(resultado.nombre)
        Next
    End Sub

    Public Sub nullvisible()
        panelListaChats.Visible = False
        panelChat.Visible = False
        panelRealizarDiagnostico.Visible = False
        panelRealizarDiagnostico2.Visible = False
        panelPerfil.Visible = False
        panelHistorialConsulta.Visible = False
    End Sub

    Public Sub devolverColorBotonesMenu()
        btnMenu_RealizarDiagnostico.FillColor = Color.FromArgb(40, 117, 207)
        btnChats1.FillColor = Color.FromArgb(40, 117, 207)
        btnCerrarSesion.FillColor = Color.FromArgb(40, 117, 207)
    End Sub

    Public Sub limpiarDiagnostico()
        cargarListaSintomas()
        lstSintomasSeleccionados.Clear()
        labDiagnostico1.Visible = False
        labDiagnostico2.Visible = False
        labDiagnostico3.Visible = False
        labDiagnostico4.Visible = False
        lstSintomasSeleccionados.Enabled = True
        btnAgregar.Enabled = True
        btnEliminar.Enabled = True
        btnRealizardiagnostico.Enabled = True
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

    Private Sub labHistorialMedico_Click(sender As Object, e As EventArgs) Handles labHistorialMedico.Click
        nullvisible()
        panelHistorialConsulta.Show()
    End Sub



    Private Sub btnCerrarHistorial_Click(sender As Object, e As EventArgs) Handles btnCerrarHistorial.Click
        nullvisible()
    End Sub

    'Esta funcion crea botones circulares (de la extension GUNA)
    'y le da ciertos parametros, entre ellos se establece el nombre del boton
    'como la ID de la sala con el paciente.
    'Luego se agregan a el panel "listaChats".
    'Ademas siempre se limpian los chats que ya esten finalizados.
    Public Sub cargarBurbujasChat()
        Try
            For Each boton As Control In panelListaChats.Controls
                If ((TypeOf boton Is Guna.UI2.WinForms.Guna2CircleButton) AndAlso (boton.Name.Equals(id_sala))) Then
                    panelListaChats.Controls.Remove(boton)
                End If
            Next
            listaChatsAceptados = instancia.obtenerSolicitudesAceptadas(paciente)
            If listaChatsAceptados.Count > 0 Then
                Dim separacion As Single = 1
                Dim indice As Integer = 1
                Do
                    Dim botonChat As New Guna.UI2.WinForms.Guna2CircleButton()
                    With botonChat
                        .Font = New Font("DejaVu Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                        .ForeColor = Color.White
                        .Animated = True
                        .Location = New Point(11, separacion * 16)
                        .Name = listaChatsAceptados.ElementAt(indice - 1).id_sala
                        .ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
                        .FillColor = Color.FromArgb(3, 187, 133)
                        .Size = New Size(55, 57)
                        .TabIndex = 0
                        .Text = listaChatsAceptados.ElementAt(indice - 1).nombre_usuario(0) + " " + listaChatsAceptados.ElementAt(indice - 1).apellido_usuario(0)
                        AddHandler botonChat.Click, AddressOf btnChatsActivos_click
                    End With
                    panelListaChats.Controls.Add(botonChat)
                    separacion = separacion + 4.2
                    indice = indice + 1
                Loop While (indice < listaChatsAceptados.Count + 1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lstHistorialConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHistorialConsulta.SelectedIndexChanged
        Dim tratamiento As Integer = lstHistorialConsulta.FocusedItem.Index
        txtContenido.Text = listaHistorialConsulta.ElementAt(tratamiento).contenido
    End Sub

    Public Sub cargarHistorialConsultas()
        lstHistorialConsulta.Clear()


        Try
            listaHistorialConsulta = instancia.obtenerHistorialConsultasP(paciente.ID)
            For Each tratamiento As tratamiento In listaHistorialConsulta
                lstHistorialConsulta.Items.Add(tratamiento.nombre + " " + tratamiento.apellido + " - " + tratamiento.fecha)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class