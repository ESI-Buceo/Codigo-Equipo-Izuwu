Imports Logica

Public Class ABMPatologiaSintomaGOLD
    Dim instancia As LogicaAplicacion = New LogicaAplicacion()
    Dim modificar As Boolean = False
    Dim nombreViejoSintoma As String = Nothing
    Dim nombreViejoPatologia As String = Nothing
    Dim prioridadVieja As Integer = Nothing
    Dim check As Integer = -1

    'Funcion para limpiar los campos de texto y el checkboxlist de la parte de sintomas
    Public Sub limpiarPantallaSintoma()
        Dim lista As Integer = chkListaRefPatologia.Items.Count - 1
        txtIDSin.ResetText()
        txtNsintoma.ResetText()
        For i = 0 To lista
            chkListaRefPatologia.SetItemChecked(i, False)
        Next
    End Sub

    'Funcion para limpiar los campos de texto y el contador de la parte de patologia
    Public Sub limpiarPantallaPatologia()
        txtIDpat.ResetText()
        txtNpatologia.ResetText()
        nmbPrioridadPat.Value = 1
    End Sub

    Private Sub AMPatologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lista para albergar los datos conseguidos en codigo
        Dim listaSin As New List(Of String)

        'A la lista se le cargan los valores de la Base de datos
        'listaSin.AddRange(instancia.cargarSintomas)

        'Se recorre la lista y se va agregando cada item a el combobox de la ventana
        For Each sintoma As String In listaSin
            lstSintoma.Items.Add(sintoma)

        Next

        'Lista para albergar los datos conseguidos en codigo
        Dim listaPat As New List(Of String)

        'A la lista se le cargan los valores de la Base de datos
        ' listaPat.AddRange(instancia.cargarPatologia)

        'Se recorre la lista y se va agregando cada item a el combobox de la ventana
        For Each patologia As String In listaPat
            lstPatologia.Items.Add(patologia)

        Next

        For Each checkPatologia As String In listaPat
            chkListaRefPatologia.Items.Add(checkPatologia)

        Next

    End Sub



    Private Sub btnAgregarSintoma_Click(sender As Object, e As EventArgs) Handles btnAgregarSintoma.Click

        If txtIDSin.Text = "" Or txtNsintoma.Text = "" Or chkListaRefPatologia.CheckedItems.Count = 0 Then
            MessageBox.Show("¡Datos faltantes!.")
        Else
            ' instancia.agregarSintoma(txtIDSin.Text, txtNsintoma.Text)
            lstSintoma.Items.Add(txtNsintoma.Text)
            Dim lista As Integer = chkListaRefPatologia.Items.Count - 1

            For i = 0 To lista
                If (chkListaRefPatologia.GetItemChecked(i)) Then
                    '  instancia.agregarReferenciaSintomaPatologia(txtIDSin.Text, chkListaRefPatologia.Items.Item(i))

                End If
            Next

            limpiarPantallaSintoma()

        End If
        chkListaRefPatologia.SelectedItem = Nothing

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerarIDSintoma.Click
        ' txtIDSin.Text = instancia.generarRandomID("SIN", "0")

    End Sub

    Private Sub btnModSintoma_Click(sender As Object, e As EventArgs) Handles btnModSintoma.Click
        chkListaRefPatologia.SelectedItem = Nothing

        If lstSintoma.SelectedItem = Nothing Then
            MsgBox("No hay ningun elemento seleccionado.")
        Else
            Dim ChkPatologia As Integer = chkListaRefPatologia.Items.Count - 1
            'Se activa el boton "Aceptar" en la pantalla para su uso
            btnAplicarModificarSintoma.Visible = True
            btnAgregarSintoma.Visible = False
            btnGenerarIDSintoma.Visible = False

            modificar = True

            limpiarPantallaSintoma()


            'Se crea una lista para albergar todos las patologias a las que pertenece un sintoma seleccionado
            'en la list
            Dim lista As New List(Of String)
            '  lista.AddRange(instancia.obtenerReferenciaDeSintoma(lstSintoma.SelectedItem.ToString))
            txtNsintoma.Text = lstSintoma.SelectedItem.ToString
            nombreViejoSintoma = lstSintoma.SelectedItem.ToString
            ' txtIDSin.Text = instancia.obtenerIDSintoma(lstSintoma.SelectedItem.ToString)



            For i = 0 To ChkPatologia
                For Each patologias As String In lista
                    If (chkListaRefPatologia.Items.Item(i) = patologias) Then
                        chkListaRefPatologia.SetItemChecked(i, True)
                    End If
                Next
            Next
        End If
    End Sub





    Private Sub btnAceptarModificar_Click(sender As Object, e As EventArgs) Handles btnAplicarModificarSintoma.Click
        Dim ChkPatologia As Integer = chkListaRefPatologia.Items.Count - 1
        Dim tamañoLista As Integer = lstSintoma.Items.Count - 1
        chkListaRefPatologia.SelectedItem = Nothing
        If nombreViejoSintoma = txtNsintoma.Text Then

            btnAplicarModificarSintoma.Visible = False
            btnAgregarSintoma.Visible = True
            btnGenerarIDSintoma.Visible = True
            limpiarPantallaSintoma()

            lstSintoma.Items.Clear()


            Dim listaSin As New List(Of String)


            listaSin.AddRange(instancia.ObtenerSintoma)


            For Each sintoma As String In listaSin
                lstSintoma.Items.Add(sintoma)

            Next

        Else
            instancia.actualizarNombreSintoma(txtIDSin.Text, txtNsintoma.Text)
            btnAplicarModificarSintoma.Visible = False
            btnAgregarSintoma.Visible = True
            btnGenerarIDSintoma.Visible = True

            limpiarPantallaSintoma()

            lstSintoma.Items.Clear()

            'Lista para albergar los datos conseguidos en codigo
            Dim listaSin As New List(Of String)

            'A la lista se le cargan los valores de la Base de datos
            listaSin.AddRange(instancia.ObtenerSintoma)

            'Se recorre la lista y se va agregando cada item a el combobox de la ventana
            For Each sintoma As String In listaSin
                lstSintoma.Items.Add(sintoma)

            Next
        End If

    End Sub

    Private Sub chkListaRefPatologia_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkListaRefPatologia.ItemCheck

        If modificar = True Then

            Dim check As Integer = chkListaRefPatologia.SelectedIndex

            If check = -1 Then
            Else

                If chkListaRefPatologia.GetItemChecked(check) Then



                    instancia.eliminarReferenciaPatologiaSintoma(nombreViejoSintoma, chkListaRefPatologia.SelectedItem)

                Else


                    'instancia.ObtenerReferenciaSintomaPatologia(nombreViejoSintoma, chkListaRefPatologia.SelectedItem)

                End If

            End If
        End If

    End Sub

    Private Sub btnBorrarSintoma_Click(sender As Object, e As EventArgs) Handles btnBorrarSintoma.Click

        If lstSintoma.SelectedItem = Nothing Then
            MsgBox("No hay ningun elemento seleccionado.")
        Else
            instancia.eliminarSintoma(lstSintoma.SelectedItem.ToString)
            MsgBox(lstSintoma.SelectedItem.ToString + " Eliminado con exito")
            lstSintoma.Items.Remove(lstSintoma.SelectedItem)
        End If

    End Sub


    'Funciones para Patologia
    Private Sub btnAgregarPatologia_Click(sender As Object, e As EventArgs) Handles btnAgregarPatologia.Click
        If txtIDpat.Text = "" Or txtNpatologia.Text = "" Then
            MsgBox("Datos faltantes.")
        Else
            '  instancia.agregarPatologia(txtIDpat.Text, txtNpatologia.Text, Convert.ToString(nmbPrioridadPat.Value))
            lstPatologia.Items.Add(txtNpatologia.Text)
            chkListaRefPatologia.Items.Add(txtNpatologia.Text)
            limpiarPantallaPatologia()

        End If
    End Sub

    Private Sub btnGenerarIDPat_Click(sender As Object, e As EventArgs) Handles btnGenerarIDPat.Click
        ' txtIDpat.Text = instancia.generarRandomID("PAT", "2")
    End Sub

    Private Sub btnModificarPatologia_Click(sender As Object, e As EventArgs) Handles btnModificarPatologia.Click
        ' txtNpatologia.Text = lstPatologia.SelectedItem.ToString
        ' txtIDpat.Text = instancia.obtenerIDPatologia(lstPatologia.SelectedItem.ToString)
        'nmbPrioridadPat.Value = instancia.obtenerPrioridadPatologia(lstPatologia.SelectedItem.ToString)
        btnAplicarModificarPatologia.Visible = True
        btnGenerarIDPat.Visible = False
        nombreViejoPatologia = lstPatologia.SelectedItem.ToString
        prioridadVieja = nmbPrioridadPat.Value
    End Sub

    Private Sub btnAplicarModificarPatologia_Click(sender As Object, e As EventArgs) Handles btnAplicarModificarPatologia.Click
        If nombreViejoPatologia = txtNpatologia.Text And prioridadVieja = nmbPrioridadPat.Value Then
            limpiarPantallaPatologia()
            lstPatologia.Items.Clear()
            Dim listaPat As New List(Of String)

            'listaPat.AddRange(instancia.cargarPatologia)

            For Each patologia As String In listaPat
                lstPatologia.Items.Add(patologia)

            Next

            btnGenerarIDPat.Visible = True

        ElseIf nombreViejoPatologia <> txtNpatologia.Text And prioridadVieja = nmbPrioridadPat.Value Then
            instancia.actualizarNombrePatologia(txtIDpat.Text, txtNpatologia.Text)
            limpiarPantallaPatologia()
            lstPatologia.Items.Clear()
            Dim listaPat As New List(Of String)

            'listaPat.AddRange(instancia.cargarPatologia)


            For Each patologia As String In listaPat
                lstPatologia.Items.Add(patologia)

            Next

            btnGenerarIDPat.Visible = True

        ElseIf nombreViejoPatologia = txtNpatologia.Text And prioridadVieja <> nmbPrioridadPat.Value Then
            instancia.actualizarPrioridadPatologia(txtIDpat.Text, nmbPrioridadPat.Value.ToString)
            limpiarPantallaPatologia()
            lstPatologia.Items.Clear()
            Dim listaPat As New List(Of String)

            ' listaPat.AddRange(instancia.cargarPatologia)

            For Each patologia As String In listaPat
                lstPatologia.Items.Add(patologia)

            Next

            btnGenerarIDPat.Visible = True

        ElseIf nombreViejoPatologia <> txtNpatologia.Text And prioridadVieja <> nmbPrioridadPat.Value Then
            instancia.actualizarPrioridadPatologia(txtIDpat.Text, nmbPrioridadPat.Value.ToString)
            instancia.actualizarNombrePatologia(txtIDpat.Text, txtNpatologia.Text)
            limpiarPantallaPatologia()
            lstPatologia.Items.Clear()
            Dim listaPat As New List(Of String)

            ' listaPat.AddRange(instancia.cargarPatologia)

            For Each patologia As String In listaPat
                lstPatologia.Items.Add(patologia)

            Next

            btnGenerarIDPat.Visible = True

        End If
    End Sub

    Private Sub btnBorrarPatologia_Click(sender As Object, e As EventArgs) Handles btnBorrarPatologia.Click
        If lstPatologia.SelectedItem = Nothing Then
            MsgBox("No hay ningun elemento seleccionado.")
        Else
            instancia.eliminarPatologia(lstPatologia.SelectedItem.ToString)
            MsgBox(lstPatologia.SelectedItem.ToString + " Eliminado con exito")
            lstPatologia.Items.Remove(lstPatologia.SelectedItem)
        End If
    End Sub
End Class
