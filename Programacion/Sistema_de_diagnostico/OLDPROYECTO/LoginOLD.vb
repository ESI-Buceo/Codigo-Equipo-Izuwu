﻿Imports Logica


Public Class LoginOLD
    Dim Instancia As LogicaAplicacion = New LogicaAplicacion()



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        'Se toman los datos de los cuadros de texto CI y Contraseña
        Dim nada As Boolean = Instancia.login(txtCI.Text, txtContraseña.Text, "PAC")

        'Vefiricacion de datos correspondientes en la base de datos
        If nada = False Then

            MessageBox.Show("Error. Usuario o Contraseña incorrectos")

        Else
            Me.Hide()
            MenuPacienteOLD.ShowDialog()
            Me.Close()

        End If

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnRegistro.Click
        RegistroOLD.ShowDialog()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub LoginOLD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class