Imports Datos, Logica
Public Class MenuGestorNew

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Dim instancia As New LogicaAplicacion()

    Dim listaMedicos As List(Of Medico)
    Dim listaSintomas As List(Of Sintoma)
    Dim listaPatologia As List(Of Patologia)

    Dim AltaModSintoma As New ABMSintoma()
    Dim AltaModPatologia As New ABMPatologia()

    Dim filtroSintomas As New List(Of Sintoma)
    Dim filtroPatologias As New List(Of Patologia)

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

        cargarListaSintoma()
        cargarListaPatologia()
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
        cargarListaSintoma()
        cargarListaPatologia()

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
        instancia.actualizarMedico(New Medico(txtModDel_PrimerNombre.Text, txtModDel_SegundoNombre.Text, txtModDel_Apellido.Text, txtModDel_Segundoapellido.Text, txtModDel_Email.Text, listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).ID, txtModDel_Direccion.Text, txtModDel_CI.Text, txtModDel_Contraseña.Text, txtModDel_Telefono.Text, fechastring, txtModDel_Especializacion.Text, txtModDel_Empresa.Text))
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
            instancia.agregarMedico(New Medico(txtPrimerNombre.Text, txtSegundoNombre.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, ID, txtDireccion.Text, txtCI.Text, txtContraseña.Text, txtTelefono.Text, fechastring, txtEspecializacion.Text, txtEmpresa.Text))
            limpiarAgregarMedico()
        Else
            MsgBox("Las contraseñas no coiniciden.")
        End If
    End Sub

    Private Sub lstMedicos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstModDel_Medicos.SelectedIndexChanged


        txtModDel_PrimerNombre.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).nombre
        txtModDel_SegundoNombre.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).segundonombre
        txtModDel_Apellido.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).apellido
        txtModDel_Segundoapellido.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).segundoapellido
        txtModDel_CI.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).CI
        txtModDel_Direccion.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).Direccion
        Dim fechaString As String = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).fechadenacimiento
        Dim fecha As Date = Date.ParseExact(fechaString, "yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        dateModDel_FechaNacimiento.Value = fecha

        txtModDel_Contraseña.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).contraseña
        txtModDel_ConfContraseña.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).contraseña
        txtModDel_Telefono.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).telefono
        txtModDel_Especializacion.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).especializacion
        txtModDel_Email.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).email
        txtModDel_Empresa.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).lugarDeTrabajo

    End Sub




    Private Sub btnEliminarMedico_Click(sender As Object, e As EventArgs) Handles btnEliminarMedico.Click
        instancia.eliminarMedico(listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).ID)
        limpiarModDel_Medicos()
        cargarListaMedicos()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnModSintoma.Click
        If lstSintomas.FocusedItem.Index = Nothing Then
            MsgBox("Ningun sintoma seleccionado")
        Else
            Dim sintoma As New Sintoma(listaSintomas.ElementAt(lstSintomas.FocusedItem.Index).nombre, listaSintomas.ElementAt(lstSintomas.FocusedItem.Index).id)
            AltaModSintoma.sintoma = sintoma
            AltaModSintoma.confirmar = 0


            AltaModSintoma.ShowDialog()
        End If

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        AltaModSintoma.confirmar = -1
        AltaModSintoma.sintoma = Nothing
        AltaModSintoma.ShowDialog()


    End Sub

    Private Sub btnAgregarPatologia_Click(sender As Object, e As EventArgs) Handles btnAgregarPatologia.Click
        AltaModPatologia.confirmar = -1
        AltaModPatologia.ShowDialog()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnModPatologia.Click
        If lstPatologia.FocusedItem.Index = Nothing Then
            MsgBox("Ninguna patologia seleccionada")
        Else
            Dim patologia As New Patologia(listaPatologia.ElementAt(lstPatologia.FocusedItem.Index).nombre, listaPatologia.ElementAt(lstPatologia.FocusedItem.Index).prioridad, listaPatologia.ElementAt(lstPatologia.FocusedItem.Index).id)
            AltaModPatologia.patologia = patologia
            AltaModPatologia.confirmar = 0
            AltaModPatologia.ShowDialog()
        End If

    End Sub

    Private Sub txtBuscarSintoma_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarSintoma.TextChanged
        filtroSintomas.Clear()
        For Each filtro As Sintoma In listaSintomas
            If filtro.nombre.ToLower.StartsWith(txtBuscarSintoma.Text.ToLower) Then
                filtroSintomas.Add(filtro)
            End If
        Next
        lstSintomas.Clear()
        For Each resultado As Sintoma In filtroSintomas
            lstSintomas.Items.Add(resultado.nombre)
        Next
    End Sub

    Private Sub txtBuscarPatologia_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarPatologia.TextChanged
        filtroPatologias.Clear()
        For Each filtro As Patologia In listaPatologia
            If filtro.nombre.ToLower.StartsWith(txtBuscarPatologia.Text.ToLower) Then
                filtroPatologias.Add(filtro)
            End If
        Next
        lstPatologia.Clear()
        For Each resultado As Patologia In filtroPatologias
            lstPatologia.Items.Add(resultado.nombre)
        Next
    End Sub

    Private Sub btnEliminarSintoma_Click(sender As Object, e As EventArgs) Handles btnEliminarSintoma.Click

        If lstSintomas.SelectedItems.Count = 0 Then
            MsgBox("Ningun sintoma seleccionado")
        Else
            Dim pregunta As DialogResult = MessageBox.Show("¿Esta seguro de que quiere eliminar el sintoma?", "Eliminar", MessageBoxButtons.YesNo)
            If pregunta = DialogResult.Yes Then
                Dim patologiaDeSintoma As List(Of Patologia) = instancia.ObtenerReferenciaSintomaPatologia(listaSintomas.ElementAt(lstSintomas.FocusedItem.Index).id)
                If patologiaDeSintoma.Count < 0 Then
                    For Each patologia As Patologia In patologiaDeSintoma
                        instancia.eliminarReferenciaPatologiaSintoma(listaSintomas.ElementAt(lstSintomas.FocusedItem.Index).id, patologia.id)
                    Next


                End If
                instancia.eliminarSintoma(listaSintomas.ElementAt(lstSintomas.FocusedItem.Index).id)
                limpiarListaSintomas()
                cargarListaSintoma()
                limpiarListaPatologia()
                cargarListaPatologia()
            End If

        End If
    End Sub

    Private Sub btnEliminarPatologia_Click(sender As Object, e As EventArgs) Handles btnEliminarPatologia.Click

        If lstPatologia.SelectedItems.Count = 0 Then
            MsgBox("Ninguna patologia seleccionada")
        Else
            Dim pregunta As DialogResult = MessageBox.Show("¿Esta seguro de que quiere eliminar la patologia?", "Eliminar", MessageBoxButtons.YesNo)
            If pregunta = DialogResult.Yes Then
                Dim sintomaDePatologia As List(Of Sintoma) = instancia.ObtenerReferenciaPatologiaSintoma(listaPatologia.ElementAt(lstPatologia.FocusedItem.Index).id)
                If sintomaDePatologia.Count < 0 Then
                    For Each sintoma As Sintoma In sintomaDePatologia
                        instancia.eliminarReferenciaPatologiaSintoma(sintoma.id, listaPatologia.ElementAt(lstPatologia.FocusedItem.Index).id)
                    Next


                End If
                instancia.eliminarPatologia(listaPatologia.ElementAt(lstPatologia.FocusedItem.Index).id)
                limpiarListaSintomas()
                cargarListaSintoma()
                limpiarListaPatologia()
                cargarListaPatologia()
            End If

        End If


    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Lista de funciones para limpiar diferentes areas de la pantalla (textbox, listbox, etc.)

    Public Sub limpiarListaSintomas()
        lstSintomas.Clear()
    End Sub
    Public Sub cargarListaSintoma()
        listaSintomas = instancia.ObtenerSintoma()
        For Each sintoma As Sintoma In listaSintomas
            lstSintomas.Items.Add(sintoma.nombre)
        Next
    End Sub
    Public Sub cargarListaPatologia()

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