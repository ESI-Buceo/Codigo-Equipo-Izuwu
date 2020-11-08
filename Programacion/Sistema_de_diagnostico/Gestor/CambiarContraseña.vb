Imports Datos, Logica
Public Class CambiarContraseña
    Public gestor As Gestor
    Dim instancia As New LogicaAplicacion()
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    'Este evento verifica que los campos de contraseña coincidan.
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtConfirmarContraseña.Text = txtContraseña.Text Then
            instancia.actualizarContraseñaGestor(txtContraseña.Text, gestor.ID)
            MsgBox("Contraseña cambiada con exito.")
            Me.Close()
        Else
            MsgBox("Las contraseñas no coinciden.")
        End If
    End Sub


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
End Class