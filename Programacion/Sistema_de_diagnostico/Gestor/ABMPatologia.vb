Imports Datos, Logica

Public Class ABMPatologia
    Public patologia As Patologia
    Public confirmar As Integer
    Dim listaSintomas As List(Of Sintoma)
    Dim sintomasDePatologia As List(Of Sintoma)
    Dim instancia As New LogicaAplicacion()
    Dim listaEspecialidad As List(Of campo_medico) = instancia.ObtenerEspecializacionMedico()

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub ABMPatologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If confirmar = -1 Then
            cargarPantalla()
            txtIDPatologia.Text = instancia.codigoRandom(2)

        ElseIf confirmar = 0 Then
            cargarPantalla()
            cargarPatologia()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            If confirmar = -1 Then
                instancia.AMpatologia(confirmar, New Patologia(txtNombre.Text, numPrioridad.Value.ToString, txtIDPatologia.Text, cbxEspecialidad.Text))

                For i = 1 To chkListaSintomas.Items.Count
                    If chkListaSintomas.GetItemChecked(i - 1) Then
                        instancia.agregarSintomaDePatologia(listaSintomas.ElementAt(i - 1).id, txtIDPatologia.Text)
                    End If
                Next

            ElseIf confirmar = 0 Then
                instancia.AMpatologia(confirmar, New Patologia(txtNombre.Text, numPrioridad.Value.ToString, txtIDPatologia.Text, cbxEspecialidad.Text))

                For Each sintoma As Sintoma In sintomasDePatologia
                    instancia.eliminarReferenciaPatologiaSintoma(sintoma.id, patologia.id)
                Next

                For i = 1 To chkListaSintomas.Items.Count
                    If chkListaSintomas.GetItemChecked(i - 1) Then
                        instancia.agregarSintomaDePatologia(listaSintomas.ElementAt(i - 1).id, txtIDPatologia.Text)
                    End If
                Next
            End If

            MenuGestor.limpiarListaPatologia()
            MenuGestor.limpiarListaSintomas()
            MenuGestor.cargarListaSintoma()
            MenuGestor.cargarListaPatologia()
            Me.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Funcion para cargar listas, textbox, etc.

    Public Sub cargarPantalla()
        listaSintomas = instancia.ObtenerSintoma()
        txtNombre.Clear()
        txtIDPatologia.Clear()
        numPrioridad.Value = 1
        chkListaSintomas.Items.Clear()
        For Each sintoma As Sintoma In listaSintomas
            chkListaSintomas.Items.Add(sintoma.nombre)
        Next
        For Each campo As campo_medico In listaEspecialidad
            cbxEspecialidad.Items.Add(campo.nombre)
        Next
    End Sub


    Public Sub cargarPatologia()

        txtNombre.Text = patologia.nombre
        txtIDPatologia.Text = patologia.id
        numPrioridad.Value = Convert.ToInt32(patologia.prioridad)
        cbxEspecialidad.Text = patologia.especialidad
        sintomasDePatologia = instancia.ObtenerReferenciaPatologiaSintoma(patologia.id)

        For i = 0 To chkListaSintomas.Items.Count - 1
            For Each sintoma As Sintoma In sintomasDePatologia
                If chkListaSintomas.Items.Item(i) = sintoma.nombre Then
                    chkListaSintomas.SetItemChecked(i, True)
                End If
            Next
        Next

    End Sub


End Class