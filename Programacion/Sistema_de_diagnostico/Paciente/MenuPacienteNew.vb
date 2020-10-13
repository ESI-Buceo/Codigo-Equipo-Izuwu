Imports Datos, Logica
Public Class MenuPacienteNew

    Public paciente As Paciente

    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim instancia As New LogicaAplicacion()

    Dim SintomasSeleccionados As New List(Of Sintoma)
    Dim listaSintomas As List(Of Sintoma) = instancia.ObtenerSintoma()
    Dim filtroSintomas As New List(Of Sintoma)


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

        nullvisible()

    End Sub

    Private Sub btnRealizarDiagnostico_Click(sender As Object, e As EventArgs) Handles btnRealizarDiagnostico.Click
        devolverColorBotonesMenu()
        btnRealizarDiagnostico.BackColor = Color.FromArgb(24, 68, 122)

        nullvisible()

        panelRealizarDiagnostico.Visible = True
        panelRealizarDiagnostico2.Visible = True
        labDiagnostico.Visible = False

    End Sub




    Private Sub btnCerrarsesion_Click_1(sender As Object, e As EventArgs) Handles btnCerrarsesion.Click
        devolverColorBotonesMenu()
        btnCerrarsesion.BackColor = Color.FromArgb(24, 68, 122)

        nullvisible()
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        SintomasSeleccionados.Add(New Sintoma(listaSintomas.ElementAt(lstSintomas.FocusedItem.Index).nombre, listaSintomas.ElementAt(lstSintomas.FocusedItem.Index).id))

        lstSintomasSeleccionados.Clear()
        For Each sintoma As Sintoma In SintomasSeleccionados
            lstSintomasSeleccionados.Items.Add(sintoma.nombre)
        Next
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles labVolverDisgnostico.Click
        nullvisible()
        devolverColorBotonesMenu()
    End Sub

    Private Sub txtBusquedaSintomas_TextChanged(sender As Object, e As EventArgs) Handles txtBusquedaSintomas.TextChanged
        cargarListaSintomas()
    End Sub

    Private Sub labNombre_Click(sender As Object, e As EventArgs) Handles labNombre.Click
        labPerfilNombre.Text = paciente.nombre
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        labDiagnostico.Visible = True

    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If lstSintomasSeleccionados.SelectedItems.Count = 0 Then
            MsgBox("Ningun sintoma seleccionado.")

        Else
            SintomasSeleccionados.Remove(SintomasSeleccionados.ElementAt(lstSintomasSeleccionados.FocusedItem.Index))
            lstSintomasSeleccionados.Items.Remove(lstSintomasSeleccionados.Items.Item(lstSintomasSeleccionados.FocusedItem.Index))
        End If
    End Sub
    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles labVolverPerfil.Click
        nullvisible()
    End Sub
    Private Sub btnChats_Click(sender As Object, e As EventArgs) Handles btnChats.Click
        btnRealizarDiagnostico.BackColor = Color.FromArgb(40, 117, 207)
        btnChats.BackColor = Color.FromArgb(24, 68, 122)
        btnCerrarsesion.BackColor = Color.FromArgb(40, 117, 207)

        nullvisible()
        Dim indice As Single = 1
        Do

            Dim chatLabel As New Label
            With chatLabel
                .Text = "A B"
                .Parent = Me
                .Location = New Point(5, indice * 14)
                .Font = New Font("Microsoft Sans Serif", 15.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                .ForeColor = Color.White
                .AutoSize = True
                .BackColor = Color.FromArgb(117, 117, 117)
            End With

            panelMenu_Chat.Controls.Add(chatLabel)
            indice = indice + 3.2
        Loop While (indice < 50)


        panelChat.Visible = True
        panelMenu_Chat.Visible = True


    End Sub

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
        panelMenu_Chat.Visible = False
        panelChat.Visible = False
        panelRealizarDiagnostico.Visible = False
        panelRealizarDiagnostico2.Visible = False
        panelPerfil.Visible = False
    End Sub

    Public Sub devolverColorBotonesMenu()
        btnRealizarDiagnostico.BackColor = Color.FromArgb(40, 117, 207)
        btnChats.BackColor = Color.FromArgb(40, 117, 207)
        btnCerrarsesion.BackColor = Color.FromArgb(40, 117, 207)
    End Sub
End Class