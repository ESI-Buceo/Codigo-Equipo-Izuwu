﻿Imports Datos, Logica
Public Class ABMSintoma
    Dim instancia As New LogicaAplicacion()
    Public sintoma As Sintoma
    Public confirmar As Integer
    Dim listaPatologias As List(Of Patologia)
    Dim sintomasDePatologias As List(Of Patologia)



    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    'Al cargarse la ventana se verifica si es una modificacion
    'o si es un elemento nuevo.
    'Esto se hace con el atributo "confirmar"
    'si el mismo es 0 significa que es un elemento existente
    'si es -1 significa que es un elemento nuevo.
    Private Sub ABMSintoma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If confirmar = -1 Then
            txtIDSintoma.Text = instancia.codigoRandom(0)
            cargarPantalla()
        ElseIf confirmar = 0 Then
            cargarPantalla()
            cargarSintoma()
        End If

    End Sub

    'Despues de apretar aceptar se verifican cuales casillas del CheckListBox
    'estan marcadas y mediante un for se agregan a la referencia sintoma-patologia.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            If confirmar = -1 Then
                instancia.AMsintoma(confirmar, New Sintoma(txtNombre.Text, txtIDSintoma.Text))

                For i = 1 To chkListaPatologias.Items.Count
                    If chkListaPatologias.GetItemChecked(i - 1) Then
                        instancia.agregarSintomaDePatologia(txtIDSintoma.Text, listaPatologias.ElementAt(i - 1).id)
                    End If
                Next

            ElseIf confirmar = 0 Then
                instancia.AMsintoma(confirmar, New Sintoma(txtNombre.Text, txtIDSintoma.Text))

                For Each patologia As Patologia In sintomasDePatologias
                    instancia.eliminarReferenciaPatologiaSintoma(sintoma.id, patologia.id)
                Next

                For i = 1 To chkListaPatologias.Items.Count
                    If chkListaPatologias.GetItemChecked(i - 1) Then
                        instancia.agregarSintomaDePatologia(txtIDSintoma.Text, listaPatologias.ElementAt(i - 1).id)
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
    'Funciones para cargar listas, textbox, etc.
    Public Sub cargarPantalla()
        listaPatologias = instancia.ObtenerPatologia()
        txtNombre.Clear()
        chkListaPatologias.Items.Clear()
        For Each patologia As Patologia In listaPatologias
            chkListaPatologias.Items.Add(patologia.nombre)
        Next
    End Sub

    Public Sub cargarSintoma()
        txtNombre.Text = sintoma.nombre
        txtIDSintoma.Text = sintoma.id

        sintomasDePatologias = instancia.ObtenerReferenciaSintomaPatologia(sintoma.id)

        For i = 0 To chkListaPatologias.Items.Count - 1
            For Each patologia As Patologia In sintomasDePatologias
                If chkListaPatologias.Items.Item(i) = patologia.nombre Then
                    chkListaPatologias.SetItemChecked(i, True)
                End If
            Next
        Next
    End Sub


End Class