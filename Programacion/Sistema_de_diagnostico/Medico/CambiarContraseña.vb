﻿Imports Datos, Logica
Public Class CambiarContraseña
    Public medico As Medico
    Dim instancia As New LogicaAplicacion()
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtConfirmarContraseña.Text = txtContraseña.Text Then
            instancia.actualizarContraseñaMedico(txtContraseña.Text, medico.ID)
            MsgBox("Contraseña cambiada con exito.")
            Me.Close()
        Else
            MsgBox("Las contraseñas no coinciden.")
        End If

    End Sub

    Dim mostrarContraseña As Boolean = True
    Private Sub btnMostrarContraseña_Click(sender As Object, e As EventArgs) Handles btnMostrarContraseña.Click
        If mostrarContraseña Then
            mostrarContraseña = False
            txtContraseña.UseSystemPasswordChar = False
            btnMostrarContraseña.FillColor = Color.Red
        Else
            mostrarContraseña = True
            txtContraseña.UseSystemPasswordChar = True
            btnMostrarContraseña.FillColor = Color.Green
        End If
    End Sub
End Class