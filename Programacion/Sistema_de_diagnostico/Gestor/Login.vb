﻿Imports Logica, Datos
Public Class Login

    Dim ejeX, ejeY As Integer
    Dim Arrastre As Boolean
    Dim Instancia As New LogicaAplicacion()

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


    '-----------------------------------------------------------------------------------------------------------------------------------


    'Funciones para cerrar y minimizar la aplicacion.
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------------------------------

    'El boton hace que el TextBox "txtContraseña" cambie su propiedad
    'de mostrar el texto a modo de contraseña (con puntitos)
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

    'Se verifica si el usuario y contraseña esten bien ingresados
    'y se crea una nueva instancia de la ventana para crearla con los parametros
    'personalizados, para cada usuario.
    Private Sub btnEntrar_Click_1(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Try
            Dim login As Gestor = Instancia.loginGestor(txtUsuario.Text, txtContraseña.Text)
            Dim menuGestor As New MenuGestor
            menuGestor.gestor = login

            Me.Hide()
            menuGestor.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Este evento hace lo mismo que el boton de ingresar,
    'solo que ocurre cuando el usuario aprieta Enter,
    'mientras el foco este puesto en el textBox de contraseña.
    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                'Se toman los datos de los cuadros de texto CI y Contraseña
                Dim gestor As Gestor = Instancia.loginGestor(txtUsuario.Text, txtContraseña.Text)
                Dim menuGestor As New MenuGestor()
                menuGestor.gestor = gestor


                Me.Hide()
                menuGestor.ShowDialog()
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

End Class