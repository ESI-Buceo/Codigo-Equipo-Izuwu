Imports Datos, Logica
Public Class MenuGestorNew

    Public gestor As Gestor

    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Dim instancia As New LogicaAplicacion()

    Dim listaMedicos As List(Of Medico)
    Dim listaSintomas As List(Of Sintoma) = instancia.ObtenerSintoma()
    Dim listaPatologia As List(Of Patologia) = instancia.ObtenerPatologia()

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

        labIniciales.Text = gestor.nombre(0) + " " + gestor.apellido(0)
        labNombre.Text = gestor.nombre + " " + gestor.apellido
        nullvisible()


        cargarListaSintoma()
        cargarListaPatologia()
        cargarListaMedicos()



    End Sub


    '-------------------------------------------------------------------------------------------------------------------------------------------------

    Private Sub btnAceptarModificar_Click(sender As Object, e As EventArgs) Handles btnAceptarModificar.Click
        Try


            Dim fecha As Date = dateModDel_FechaNacimiento.Value.Date
            Dim fechastring As String = Format(fecha, "yyyy/MM/dd")
            instancia.actualizarMedico(New Medico(txtModDel_PrimerNombre.Text, txtModDel_SegundoNombre.Text, txtModDel_Apellido.Text,
                                                  txtModDel_Segundoapellido.Text, txtModDel_Email.Text, listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).ID,
                                                  txtModDel_Direccion.Text, txtModDel_CI.Text, txtModDel_Contraseña.Text, txtModDel_Telefono.Text, fechastring, cbxModDel_Sexo.Text,
                                                  txtModDel_Especializacion.Text, txtModDel_Empresa.Text))
            limpiarModDel_Medicos()
            cargarListaMedicos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lstSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSintomas.SelectedIndexChanged

        If lstSintomas.SelectedItems.Count = 0 Then
            limpiarListaPatologia()
            cargarListaPatologia()
        Else
            limpiarListaPatologia()
            Dim listaPatologiasDeSintomas As List(Of Patologia) = instancia.ObtenerReferenciaSintomaPatologia(filtroSintomas.ElementAt(lstSintomas.FocusedItem.Index).id)
            For Each patologia As Patologia In listaPatologiasDeSintomas
                lstPatologia.Items.Add(patologia.nombre)
            Next
        End If



    End Sub
    Private Sub lstPatologia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPatologia.SelectedIndexChanged
        If lstPatologia.SelectedItems.Count = 0 Then
            limpiarListaSintomas()
            cargarListaSintoma()
        Else
            limpiarListaSintomas()
            Dim listaSintomaDePatologia As List(Of Sintoma) = instancia.ObtenerReferenciaPatologiaSintoma(filtroPatologias.ElementAt(lstPatologia.FocusedItem.Index).id)
            For Each sintoma As Sintoma In listaSintomaDePatologia
                lstSintomas.Items.Add(sintoma.nombre)
            Next
        End If
    End Sub

    Private Sub btnAgregarMedico_Click(sender As Object, e As EventArgs) Handles btnAgregarMedico.Click
        Try


            Dim fecha As Date = dateFechaNacimiento.Value.Date
            Dim fechastring As String = Format(fecha, "yyyy/MM/dd")
            Dim ID As String = instancia.codigoRandom(1)

            If txtContraseña.Text = txtConfContraseña.Text Then
                instancia.agregarMedico(New Medico(txtPrimerNombre.Text, txtSegundoNombre.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text,
                                                   ID, txtDireccion.Text, txtCI.Text, txtContraseña.Text, txtTelefono.Text, fechastring, cbxSexo.Text, txtEspecializacion.Text, txtEmpresa.Text))
                limpiarAgregarMedico()
            Else
                MsgBox("Las contraseñas no coiniciden.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

        cbxModDel_Sexo.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).sexo
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
        If lstSintomas.SelectedItems.Count = 0 Then
            MsgBox("Ningun sintoma seleccionado")
        Else
            Dim sintoma As New Sintoma(filtroSintomas.ElementAt(lstSintomas.FocusedItem.Index).nombre, filtroSintomas.ElementAt(lstSintomas.FocusedItem.Index).id)
            AltaModSintoma.sintoma = sintoma
            AltaModSintoma.confirmar = 0


            AltaModSintoma.ShowDialog()
            limpiarListaSintomas()
            cargarListaSintoma()
            limpiarListaPatologia()
            cargarListaPatologia()

        End If

    End Sub


    Private Sub btnAgregarPatologia_Click_1(sender As Object, e As EventArgs) Handles btnAgregarPatologia.Click
        AltaModPatologia.confirmar = -1
        AltaModPatologia.ShowDialog()
        limpiarListaPatologia()
        cargarListaPatologia()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnModPatologia.Click
        If lstPatologia.SelectedItems.Count = 0 Then
            MsgBox("Ninguna patologia seleccionada")
        Else
            Dim patologia As New Patologia(filtroPatologias.ElementAt(lstPatologia.FocusedItem.Index).nombre, filtroPatologias.ElementAt(lstPatologia.FocusedItem.Index).prioridad,
                                          filtroPatologias.ElementAt(lstPatologia.FocusedItem.Index).id)
            AltaModPatologia.patologia = patologia
            AltaModPatologia.confirmar = 0
            AltaModPatologia.ShowDialog()
            limpiarListaPatologia()
            cargarListaPatologia()
        End If

    End Sub

    Private Sub txtBuscarPatologia_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscarPatologia.TextChanged
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

    Private Sub txtBuscarSintoma_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscarSintoma.TextChanged
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

    Private Sub btnEliminarSintoma_Click(sender As Object, e As EventArgs) Handles btnEliminarSintoma.Click
        Try


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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarPatologia_Click(sender As Object, e As EventArgs) Handles btnEliminarPatologia.Click
        Try

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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub panelABMSintoma_MouseClick(sender As Object, e As MouseEventArgs) Handles panelABMSintoma.MouseClick
        lstPatologia.SelectedItems.Clear()
        lstSintomas.SelectedItems.Clear()
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
        txtSegundoApellido.Clear()
        txtCI.Clear()
        txtDireccion.Clear()
        dateFechaNacimiento.ResetText()
        txtTelefono.Clear()
        txtEspecializacion.Clear()
        txtEmail.Clear()
        txtEmpresa.Clear()
        cbxSexo.ResetText()
        txtContraseña.Clear()
        txtConfContraseña.Clear()
    End Sub

    Public Sub limpiarModDel_Medicos()
        txtModDel_PrimerNombre.Clear()
        txtModDel_SegundoNombre.Clear()
        txtModDel_Apellido.Clear()
        txtModDel_Segundoapellido.Clear()
        txtModDel_CI.Clear()
        txtModDel_Direccion.Clear()
        dateModDel_FechaNacimiento.ResetText()
        txtModDel_Telefono.Clear()
        txtModDel_Especializacion.Clear()
        txtModDel_Email.Clear()
        txtModDel_Empresa.Clear()
        cbxModDel_Sexo.ResetText()
        txtModDel_Contraseña.Clear()
        txtModDel_ConfContraseña.Clear()
        lstModDel_Medicos.Items.Clear()
    End Sub

    Private Sub btnMenu_AgregarMedico_Click_1(sender As Object, e As EventArgs) Handles btnMenu_AgregarMedico.Click
        nullvisible()

        panelAgregarUsuario.Visible = True
        btnMenu_AgregarMedico.FillColor = Color.FromArgb(36, 36, 36)
        btn_ABMSinPat.FillColor = Color.FromArgb(48, 48, 48)
        btnMenu_ModUsuario.FillColor = Color.FromArgb(48, 48, 48)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_ABMSinPat.Click
        limpiarListaPatologia()
        limpiarListaSintomas()
        cargarListaSintoma()
        cargarListaPatologia()
        nullvisible()

        btnMenu_AgregarMedico.FillColor = Color.FromArgb(48, 48, 48)
        btn_ABMSinPat.FillColor = Color.FromArgb(36, 36, 36)
        btnMenu_ModUsuario.FillColor = Color.FromArgb(48, 48, 48)

        panelABMSintoma.Visible = True
    End Sub

    Private Sub btnMenu_ModUsuario_Click(sender As Object, e As EventArgs) Handles btnMenu_ModUsuario.Click
        limpiarModDel_Medicos()
        cargarListaMedicos()
        nullvisible()

        btnMenu_AgregarMedico.FillColor = Color.FromArgb(48, 48, 48)
        btn_ABMSinPat.FillColor = Color.FromArgb(48, 48, 48)
        btnMenu_ModUsuario.FillColor = Color.FromArgb(36, 36, 36)

        panelModificarEliminarMedico.Visible = True
    End Sub

    Private Sub btnAgregarSintoma_Click(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        AltaModSintoma.confirmar = -1
        AltaModSintoma.sintoma = Nothing
        AltaModSintoma.ShowDialog()
        limpiarListaSintomas()
        cargarListaSintoma()
    End Sub



    Public Sub nullvisible()
        panelABMSintoma.Visible = False
        panelAgregarUsuario.Visible = False
        panelModificarEliminarMedico.Visible = False
    End Sub
End Class