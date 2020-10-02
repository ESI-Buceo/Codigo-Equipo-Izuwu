Imports Datos, Logica
Public Class MenuGestorNew

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Dim instancia As New LogicaAplicacion()

    Dim listaMedicos As List(Of Medico)
    Dim listaSintomas As List(Of Sintoma)
    Dim listaPatologia As List(Of Patologia)

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



    Private Sub MenuGestor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMenu_AgregarMedico.BackColor = Color.FromArgb(48, 48, 48)
        btnMenu_ABMSintomas.BackColor = Color.FromArgb(48, 48, 48)
        btnMenu_ModUsuario.BackColor = Color.FromArgb(48, 48, 48)

        panelAgregarUsuario.Visible = False
        panelModificarEliminarMedico.Visible = False
        panelABMSintoma.Visible = False

        cargarListaSintomaPatologia()
        cargarListaMedicos()



    End Sub

    Private Sub btnMenu_AgregarMedico_Click(sender As Object, e As EventArgs) Handles btnMenu_AgregarMedico.Click
        btnMenu_AgregarMedico.BackColor = Color.FromArgb(36, 36, 36)
        btnMenu_ABMSintomas.BackColor = Color.FromArgb(48, 48, 48)
        btnMenu_ModUsuario.BackColor = Color.FromArgb(48, 48, 48)



        panelAgregarUsuario.Visible = True
        panelModificarEliminarMedico.Visible = False
        panelABMSintoma.Visible = False


    End Sub

    Private Sub btnABMSintomas_Click(sender As Object, e As EventArgs) Handles btnMenu_ABMSintomas.Click
        btnMenu_AgregarMedico.BackColor = Color.FromArgb(48, 48, 48)
        btnMenu_ABMSintomas.BackColor = Color.FromArgb(36, 36, 36)
        btnMenu_ModUsuario.BackColor = Color.FromArgb(48, 48, 48)
        limpiarListaPatologia()
        limpiarListaSintomas()
        cargarListaSintomaPatologia()

        panelAgregarUsuario.Visible = False
        panelModificarEliminarMedico.Visible = False
        panelABMSintoma.Visible = True
    End Sub


    Private Sub btnModUsuario_Click_1(sender As Object, e As EventArgs) Handles btnMenu_ModUsuario.Click
        btnMenu_AgregarMedico.BackColor = Color.FromArgb(48, 48, 48)
        btnMenu_ABMSintomas.BackColor = Color.FromArgb(48, 48, 48)
        btnMenu_ModUsuario.BackColor = Color.FromArgb(36, 36, 36)
        limpiarModDel_Medicos()
        cargarListaMedicos()

        panelAgregarUsuario.Visible = False
        panelModificarEliminarMedico.Visible = True
        panelABMSintoma.Visible = False


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

    Private Sub btnAceptarModificar_Click(sender As Object, e As EventArgs) Handles btnAceptarModificar.Click
        Dim fecha As Date = dateModDel_FechaNacimiento.Value.Date
        Dim fechastring As String = Format(fecha, "yyyy/MM/dd")
        instancia.actualizarMedico(New Medico(txtModDel_PrimerNombre.Text, txtModDel_Apellido.Text, txtModDel_Email.Text, listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).ID, txtModDel_Direccion.Text, txtModDel_CI.Text, txtModDel_Contraseña.Text, txtModDel_Telefono.Text, fechastring, txtModDel_Especializacion.Text))
        limpiarModDel_Medicos()
        cargarListaMedicos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lstSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSintomas.SelectedIndexChanged
        limpiarListaPatologia()
        Dim listaPatologiasDeSintomas As List(Of Patologia) = instancia.ObtenerReferenciaSintomaPatologia(listaSintomas.ElementAt(lstSintomas.FocusedItem.Index).id)
        For Each patologia As Patologia In listaPatologiasDeSintomas
            lstPatologia.Items.Add(patologia.nombre)
        Next


    End Sub





    Private Sub btnAgregarMedico_Click(sender As Object, e As EventArgs) Handles btnAgregarMedico.Click
        Dim fecha As Date = dateFechaNacimiento.Value.Date
        Dim fechastring As String = Format(fecha, "yyyy/MM/dd")
        Dim ID As String = instancia.codigoRandom(1)

        If txtContraseña.Text = txtConfContraseña.Text Then
            instancia.agregarMedico(New Medico(txtPrimerNombre.Text, txtApellido.Text, txtEmail.Text, ID, txtDireccion.Text, txtCI.Text, txtContraseña.Text, txtTelefono.Text, fechastring, txtEspecializacion.Text))
            limpiarAgregarMedico()
        Else
            MsgBox("Las contraseñas no coiniciden.")
        End If
    End Sub

    Private Sub lstMedicos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstModDel_Medicos.SelectedIndexChanged
        'instancia.ObtenerReferenciaSintomaPatologia(listaSintomas.ElementAt(lstSintomas.FocusedItem.Index).id

        txtModDel_PrimerNombre.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).nombre
        txtModDel_Apellido.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).apellido
        txtModDel_CI.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).CI
        txtModDel_Direccion.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).Direccion
        Dim fechaString As String = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).fechadenacimiento
        Dim fecha As Date = Date.ParseExact(fechaString, "yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        dateModDel_FechaNacimiento.Value = fecha
        'dateModDel_FechaNacimiento.Value = DateTime.Parse(listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).fechadenacimiento).ToString("yyyy-MM-dd")  'Format(listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).fechadenacimiento, "yyyy-MM-dd")
        txtModDel_Contraseña.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).contraseña
        txtModDel_ConfContraseña.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).contraseña
        txtModDel_Telefono.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).telefono
        txtModDel_Especializacion.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).especializacion
        txtModDel_Email.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).email
        'txtModDel_Email.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).contraseña
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Lista de funciones para limpiar diferentes areas de la pantalla (textbox, listbox, etc.)

    Public Sub limpiarListaSintomas()
        lstSintomas.Clear()
    End Sub
    Public Sub cargarListaSintomaPatologia()
        listaSintomas = instancia.ObtenerSintoma()
        For Each sintoma As Sintoma In listaSintomas
            lstSintomas.Items.Add(sintoma.nombre)
        Next

        listaPatologia = instancia.ObtenerPatologia()
        For Each patologia As Patologia In listaPatologia
            lstPatologia.Items.Add(patologia.nombre)
        Next
    End Sub

    Public Sub cargarListaMedicos()
        listaMedicos = instancia.ObtenerMedicos()

        For Each medico As Medico In listaMedicos
            lstModDel_Medicos.Items.Add(medico.CI + " " + medico.nombre(0) + " " + medico.apellido(0))
        Next
    End Sub

    Public Sub limpiarListaPatologia()
        lstPatologia.Clear()
    End Sub

    Private Sub limpiarAgregarMedico()
        txtPrimerNombre.Clear()
        txtSegundoNombre.Clear()
        txtApellido.Clear()
        txtCI.Clear()
        txtDireccion.Clear()
        dateFechaNacimiento.ResetText()
        txtTelefono.Clear()
        txtEspecializacion.Clear()
        txtEmail.Clear()
        txtEmpresa.Clear()
        txtContraseña.Clear()
        txtConfContraseña.Clear()
    End Sub

    Private Sub btnEliminarMedico_Click(sender As Object, e As EventArgs) Handles btnEliminarMedico.Click
        instancia.eliminarMedico(listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).ID)
        limpiarModDel_Medicos()
        cargarListaMedicos()
    End Sub



    Public Sub limpiarModDel_Medicos()
        txtModDel_PrimerNombre.Clear()
        txtModDel_SegundoNombre.Clear()
        txtModDel_Apellido.Clear()
        txtModDel_CI.Clear()
        txtModDel_Direccion.Clear()
        dateModDel_FechaNacimiento.ResetText()
        txtModDel_Telefono.Clear()
        txtModDel_Especializacion.Clear()
        txtModDel_Email.Clear()
        txtModDel_Empresa.Clear()
        txtModDel_Contraseña.Clear()
        txtModDel_ConfContraseña.Clear()

        lstModDel_Medicos.Items.Clear()
    End Sub
End Class