Imports Logica

Public Class Login

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim instancia As LogicaAplicacion = New LogicaAplicacion()
        Dim ventanaLog As Menu = New Menu()
        Dim log As Boolean = instancia.login(txtUsuario.Text, txtContraseña.Text, "GES")

        If log = True Then
        
        Me.hide()
        ventanaLog.ShowDialog()
        Me.Close()
        
        else 
        
        MessageBox.Show("Error. Usuario o Contraseña incorrectos")
        
        End if




    End Sub
End Class
