Imports Datos, Logica
Public Class MenuGestor

    Public gestor As Gestor

    Dim ejeX, ejeY As Integer
    Dim Arrastre As Boolean

    Dim instancia As New LogicaAplicacion()

    Dim listaMedicos As List(Of Medico)
    Dim listaSintomas As List(Of Sintoma) = instancia.ObtenerSintoma()
    Dim listaPatologia As List(Of Patologia) = instancia.ObtenerPatologia()
    Dim listaEspecialidad As List(Of campo_medico) = instancia.ObtenerEspecializacionMedico()

    Dim AltaModSintoma As New ABMSintoma()
    Dim AltaModPatologia As New ABMPatologia()

    Dim filtroSintomas As New List(Of Sintoma)
    Dim filtroPatologias As New List(Of Patologia)


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

    '------------------------------------------------------------------------------------------------------------------------------------
    'Funciones de load y de cambio de color en el label "cambiarContraseña".

    Private Sub MenuGestor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labIniciales.Text = gestor.nombre(0) + " " + gestor.apellido(0)
        labNombre.Text = gestor.nombre + " " + gestor.apellido
        nullvisible()

        cargarEspecialidad()
        cargarListaSintoma()
        cargarListaPatologia()
        cargarListaMedicos()
    End Sub
    Private Sub labCambiarContraseña_MouseMove(sender As Object, e As MouseEventArgs) Handles labCambiarContraseña.MouseMove
        labCambiarContraseña.ForeColor = Color.FromArgb(0, 0, 255)
    End Sub
    Private Sub labCambiarContraseña_MouseLeave(sender As Object, e As EventArgs) Handles labCambiarContraseña.MouseLeave
        labCambiarContraseña.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------------
    'Eventos de click de los botones que utilizan los menus.
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    'Se crea una nueva instancia de la ventana "cambiarContraseña"
    'con los parametros de el gestor que esta logueado.
    Private Sub labCambiarContraseña_Click(sender As Object, e As EventArgs) Handles labCambiarContraseña.Click
        Dim cambiarContraseña As New CambiarContraseña()
        cambiarContraseña.gestor = gestor
        cambiarContraseña.ShowDialog()
    End Sub

    Private Sub btn_ABMSinPat_Click(sender As Object, e As EventArgs) Handles btn_ABMSinPat.Click
        limpiarListaPatologia()
        limpiarListaSintomas()
        cargarListaSintoma()
        cargarListaPatologia()
        nullvisible()

        devolverColoresBotones()
        btn_ABMSinPat.FillColor = Color.FromArgb(36, 36, 36)

        panelABMSintoma.Visible = True
    End Sub
    Private Sub btnMenu_ModUsuario_Click(sender As Object, e As EventArgs) Handles btnMenu_ModUsuario.Click
        limpiarModDel_Medicos()
        cargarListaMedicos()
        nullvisible()

        devolverColoresBotones()
        btnMenu_ModUsuario.FillColor = Color.FromArgb(36, 36, 36)

        panelModificarEliminarMedico.Visible = True
    End Sub
    Private Sub btnMenu_AgregarMedico_Click_1(sender As Object, e As EventArgs) Handles btnMenu_AgregarMedico.Click
        nullvisible()

        panelAgregarUsuario.Visible = True
        devolverColoresBotones()
        btnMenu_AgregarMedico.FillColor = Color.FromArgb(36, 36, 36)
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------------------------------
    'A continuacion estan las funciones para el gestor.

    '--------------------------------------------------------------------------------------------------------------------------------------
    'Funciones dentro de Modificar/Eliminar medico.

    'Aqui se acepta los cambios y se los envia a la base de datos para hacer el Update.
    Private Sub btnAceptarModificar_Click(sender As Object, e As EventArgs) Handles btnAceptarModificar.Click
        Try


            Dim fecha As Date = dateModDel_FechaNacimiento.Value.Date
            Dim fechastring As String = Format(fecha, "yyyy/MM/dd")
            instancia.actualizarMedico(New Medico(txtModDel_PrimerNombre.Text, txtModDel_SegundoNombre.Text, txtModDel_Apellido.Text,
                                                  txtModDel_Segundoapellido.Text, txtModDel_Email.Text, listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).ID,
                                                  txtModDel_Direccion.Text, txtModDel_CI.Text, txtModDel_Contraseña.Text, cbxModDel_Especializacion.Text, txtModDel_Telefono.Text, fechastring,
                                                  cbxModDel_Sexo.Text, txtModDel_Empresa.Text), listaEspecialidad.ElementAt(cbxModDel_Especializacion.SelectedIndex).id)
            limpiarModDel_Medicos()
            cargarListaMedicos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Aca se cargan los datos de un medico seleccionado en los campos que corresponden.
    Private Sub lstMedicos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstModDel_Medicos.SelectedIndexChanged

        If lstModDel_Medicos.SelectedItems.Count > 0 Then
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
            cbxModDel_Especializacion.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).especializacion
            txtModDel_Email.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).email
            txtModDel_Empresa.Text = listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).lugarDeTrabajo

        End If
    End Sub

    'Y por ultimo aqui se elimina un medico de la base de datos.
    Private Sub btnEliminarMedico_Click(sender As Object, e As EventArgs) Handles btnEliminarMedico.Click
        If lstModDel_Medicos.SelectedItems.Count = 0 Then
            MsgBox("Ningún medico seleccionado")
        Else
            Dim pregunta As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar a este usuario?", "Eliminar", MessageBoxButtons.YesNo)
            If pregunta = DialogResult.Yes Then
                instancia.eliminarMedico(listaMedicos.ElementAt(lstModDel_Medicos.FocusedItem.Index).ID)
                limpiarModDel_Medicos()
                cargarListaMedicos()
            End If

        End If
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Funciones dentro de Agregar medico.

    'Aqui se agrega un nuevo medico con los datos ingresado en los campos correspondientes.
    Private Sub btnAgregarMedico_Click(sender As Object, e As EventArgs) Handles btnAgregarMedico.Click
        Try
            Dim fecha As Date = dateFechaNacimiento.Value.Date
            Dim fechastring As String = Format(fecha, "yyyy/MM/dd")
            Dim ID As String = instancia.codigoRandom(1)

            If txtContraseña.Text = txtConfContraseña.Text Then
                instancia.agregarMedico(New Medico(txtPrimerNombre.Text, txtSegundoNombre.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text,
                                                   ID, txtDireccion.Text, txtCI.Text, txtContraseña.Text, cbxEspecializacion.Text, txtTelefono.Text, fechastring, cbxSexo.Text, txtEmpresa.Text),
                                                    listaEspecialidad.ElementAt(cbxEspecializacion.SelectedIndex).id)
                limpiarAgregarMedico()
            Else
                MsgBox("Las contraseñas no coiniciden.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------------------
    'Funciones para el ABM sintoma/patologia

    'Aqui se filtran los sintomas o patologias que correspondan a alguno de los dos (Osea los sintomas que pertenezcan a una patologia y viceversa)
    'se seleccionen en el listView correspondiente
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

    'Estas dos funciones sirven de filtro de busqueda
    'para los textBox que estan por arriba de los listView de patologia y sintoma.
    Private Sub txtBuscarPatologia_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscarPatologia.TextChanged
        cargarFiltroPatologia()
    End Sub

    Private Sub txtBuscarSintoma_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscarSintoma.TextChanged
        cargarFiltroSintomas()
    End Sub

    'Estas dos funciones abren la ventana altaModSintoma y altaModPatologia,
    'para agregar sintomas y patologias respectivamente.
    Private Sub btnAgregarSintoma_Click(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click
        AltaModSintoma.confirmar = -1
        AltaModSintoma.sintoma = Nothing
        AltaModSintoma.ShowDialog()

        limpiarListaSintomas()
        cargarListaSintoma()
        cargarFiltroPatologia()
        cargarFiltroSintomas()
    End Sub

    Private Sub btnAgregarPatologia_Click_1(sender As Object, e As EventArgs) Handles btnAgregarPatologia.Click
        AltaModPatologia.confirmar = -1
        AltaModPatologia.ShowDialog()

        limpiarListaPatologia()
        cargarListaPatologia()
        cargarFiltroPatologia()
        cargarFiltroSintomas()
    End Sub

    'Estas dos funciones al igual que las anteriores abren la ventana altaModSintoma y patologia
    'pero con los datos de un simtoma o patologia.
    Private Sub btnModSintoma_Click(sender As Object, e As EventArgs) Handles btnModSintoma.Click
        If lstSintomas.SelectedItems.Count = 0 Then
            MsgBox("Ningún síntoma seleccionado")
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
    Private Sub btnModPatologia_Click(sender As Object, e As EventArgs) Handles btnModPatologia.Click
        If lstPatologia.SelectedItems.Count = 0 Then
            MsgBox("Ninguna patologia seleccionada")
        Else
            Dim patologia As New Patologia(filtroPatologias.ElementAt(lstPatologia.FocusedItem.Index).nombre, filtroPatologias.ElementAt(lstPatologia.FocusedItem.Index).prioridad,
                                          filtroPatologias.ElementAt(lstPatologia.FocusedItem.Index).id, filtroPatologias.ElementAt(lstPatologia.FocusedItem.Index).especialidad)
            AltaModPatologia.patologia = patologia
            AltaModPatologia.confirmar = 0
            AltaModPatologia.ShowDialog()
            limpiarListaPatologia()
            cargarListaPatologia()
            limpiarListaSintomas()
            cargarListaSintoma()
        End If

    End Sub


    'Funciones para eliminar un sintoma o patologia seleccionado en el listView.
    Private Sub btnEliminarSintoma_Click(sender As Object, e As EventArgs) Handles btnEliminarSintoma.Click
        Try
            If lstSintomas.SelectedItems.Count = 0 Then
                MsgBox("Ningún síntoma seleccionado")
            Else
                Dim pregunta As DialogResult = MessageBox.Show("¿Está seguro de que quiere eliminar el sintoma?", "Eliminar", MessageBoxButtons.YesNo)
                If pregunta = DialogResult.Yes Then
                    Dim patologiaDeSintoma As List(Of Patologia) = instancia.ObtenerReferenciaSintomaPatologia(filtroSintomas.ElementAt(lstSintomas.FocusedItem.Index).id)
                    If patologiaDeSintoma.Count < 0 Then
                        For Each patologia As Patologia In patologiaDeSintoma
                            instancia.eliminarReferenciaPatologiaSintoma(filtroSintomas.ElementAt(lstSintomas.FocusedItem.Index).id, patologia.id)
                        Next
                    End If
                    instancia.eliminarSintoma(filtroSintomas.ElementAt(lstSintomas.FocusedItem.Index).id)
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
                MsgBox("Ninguna patología seleccionada")
            Else
                Dim pregunta As DialogResult = MessageBox.Show("¿Está seguro de que quiere eliminar la patología?", "Eliminar", MessageBoxButtons.YesNo)
                If pregunta = DialogResult.Yes Then
                    Dim sintomaDePatologia As List(Of Sintoma) = instancia.ObtenerReferenciaPatologiaSintoma(filtroPatologias.ElementAt(lstPatologia.FocusedItem.Index).id)
                    If sintomaDePatologia.Count < 0 Then
                        For Each sintoma As Sintoma In sintomaDePatologia
                            instancia.eliminarReferenciaPatologiaSintoma(sintoma.id, filtroPatologias.ElementAt(lstPatologia.FocusedItem.Index).id)
                        Next
                    End If
                    instancia.eliminarPatologia(filtroPatologias.ElementAt(lstPatologia.FocusedItem.Index).id)
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

    'Esta funcion unicamente sirve para cuando se deseleccione un sintoma o patologia
    'las listas se vuelvan a cargar de 0
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
        cbxEspecializacion.ResetText()
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
        cbxModDel_Especializacion.ResetText()
        txtModDel_Email.Clear()
        txtModDel_Empresa.Clear()
        cbxModDel_Sexo.ResetText()
        txtModDel_Contraseña.Clear()
        txtModDel_ConfContraseña.Clear()
        lstModDel_Medicos.Items.Clear()
    End Sub
    Public Sub cargarEspecialidad()
        For Each especialidad As campo_medico In listaEspecialidad
            cbxEspecializacion.Items.Add(especialidad.nombre)
            cbxModDel_Especializacion.Items.Add(especialidad.nombre)
        Next
    End Sub
    Public Sub cargarFiltroPatologia()
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
    Public Sub cargarFiltroSintomas()
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
    Public Sub devolverColoresBotones()
        btnMenu_AgregarMedico.FillColor = Color.FromArgb(48, 48, 48)
        btn_ABMSinPat.FillColor = Color.FromArgb(48, 48, 48)
        btnMenu_ModUsuario.FillColor = Color.FromArgb(48, 48, 48)
    End Sub
    Public Sub nullvisible()
        panelABMSintoma.Visible = False
        panelAgregarUsuario.Visible = False
        panelModificarEliminarMedico.Visible = False
    End Sub
End Class