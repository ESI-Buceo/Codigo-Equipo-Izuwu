Imports Datos, Logica
Public Class MenuPaciente

    Public paciente As Paciente

    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim instancia As New LogicaAplicacion()

    Dim SintomasSeleccionados As New List(Of Sintoma)
    Dim listaSintomas As List(Of Sintoma) = instancia.ObtenerSintoma()
    Dim filtroSintomas As New List(Of Sintoma)
    Dim listaResultadoDiag As List(Of Diagnostico)


    Dim listaChatsAceptados As List(Of Sala_Chat)
    Dim listaMensajes As List(Of Mensaje)

    Dim id_sala As String


    'Definir variables globales; estas van despues de la linea de inherits

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

        cargarListaSintomas()
        devolverColorBotonesMenu()
        labIniciales.Text = paciente.nombre(0) + " " + paciente.apellido(0)
        labNombre.Text = paciente.nombre + " " + paciente.apellido
        refrescarChat.Start()
        nullvisible()

    End Sub

    Private Sub btnRealizarDiagnostico_Click(sender As Object, e As EventArgs) Handles btnMenu_RealizarDiagnostico.Click
        devolverColorBotonesMenu()
        btnMenu_RealizarDiagnostico.BackColor = Color.FromArgb(24, 68, 122)

        nullvisible()

        panelRealizarDiagnostico.Visible = True
        panelRealizarDiagnostico2.Visible = True
        labDiagnostico1.Visible = False
        labDiagnostico2.Visible = False
        labDiagnostico3.Visible = False
        labDiagnostico4.Visible = False

    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        Button1.BackColor = Color.FromArgb(255, 96, 96)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles labVolverDisgnostico.Click
        nullvisible()
        devolverColorBotonesMenu()
    End Sub


    Private Sub labNombre_Click(sender As Object, e As EventArgs) Handles labNombre.Click
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

    End Sub

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

            instancia.agregarDiagnostico_A_BD(listaResultadoDiag, paciente, fechaString)

            lstSintomasSeleccionados.Enabled = False
            btnAgregar.Enabled = False
            btnEliminar.Enabled = False
            btnRealizardiagnostico.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles labVolverPerfil.Click
        nullvisible()
    End Sub
    Private Sub btnChats_Click(sender As Object, e As EventArgs) Handles btnChats1.Click
        btnMenu_RealizarDiagnostico.BackColor = Color.FromArgb(40, 117, 207)
        btnChats1.FillColor = Color.FromArgb(24, 68, 122)
        btnCerrarSesion.FillColor = Color.FromArgb(40, 117, 207)

        nullvisible()
        Try


            listaChatsAceptados = instancia.obtenerSolicitudesAceptadas(paciente)
            If listaChatsAceptados.Count > 0 Then


                Dim separacion As Single = 1
                Dim indice As Integer = 1
                Do
                    Dim botonChat As New Guna.UI2.WinForms.Guna2CircleButton()
                    With botonChat

                        .Font = New Font("Segoe UI", 16.0!)
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
        panelChat.Visible = True
        panelListaChats.Visible = True


    End Sub

    Private Sub btnChatsActivos_click(sender As Object, e As EventArgs)
        Dim boton As Guna.UI2.WinForms.Guna2CircleButton = DirectCast(sender, Guna.UI2.WinForms.Guna2CircleButton)

        id_sala = boton.Name
        cargarMensajes()

    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        devolverColorBotonesMenu()
        btnCerrarSesion.FillColor = Color.FromArgb(24, 68, 122)
        nullvisible()
    End Sub

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

    Private Sub txtBusquedaSintomas_TextChanged_1(sender As Object, e As EventArgs) Handles txtBusquedaSintomas.TextChanged
        cargarListaSintomas()
    End Sub

    Private Sub btnFinalizarConsulta_Click(sender As Object, e As EventArgs) Handles btnFinalizarConsulta.Click
        Dim pregunta As DialogResult = MessageBox.Show("Consulta finalizada. ¿Desea comunicarse con un médico?", "Finalizar consulta", MessageBoxButtons.YesNo)

        If pregunta = DialogResult.Yes Then
            Dim solicitudchat As New SolicitudChat()
            Dim ResultadoPatologia As New Patologia(listaResultadoDiag.ElementAt(0).nombre, listaResultadoDiag.ElementAt(0).prioridad, listaResultadoDiag.ElementAt(0).id, listaResultadoDiag.ElementAt(0).especialidad)
            solicitudchat.patologia = ResultadoPatologia
            solicitudchat.paciente = paciente
            solicitudchat.ShowDialog()

        ElseIf pregunta = DialogResult.No Then
            panelRealizarDiagnostico.Visible = False
            panelRealizarDiagnostico2.Visible = False
            limpiarDiagnostico()
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim editarperfil As New EditarPerfil
        editarperfil.paciente = paciente
        editarperfil.ShowDialog()

    End Sub

    Private Sub refrescarChat_Tick(sender As Object, e As EventArgs) Handles refrescarChat.Tick
        cargarMensajes()
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If txtMensaje.Text.Count > 0 Then
            Dim fechaActual As Date = Date.Now
            Dim fechaString As String = Format(fechaActual, "yyyy/MM/dd")
            instancia.enviarMensaje(txtMensaje.Text, id_sala, fechaString, paciente.ID)
            txtMensaje.Clear()
            cargarMensajes()
        End If

    End Sub
    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMensaje.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim fechaActual As Date = Date.Now
            Dim fechaString As String = Format(fechaActual, "yyyy/MM/dd")
            instancia.enviarMensaje(txtMensaje.Text, id_sala, fechaString, paciente.ID)
            txtMensaje.Clear()
            cargarMensajes()
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
    End Sub

    Public Sub devolverColorBotonesMenu()
        btnMenu_RealizarDiagnostico.BackColor = Color.FromArgb(40, 117, 207)
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
        End If

    End Sub
End Class