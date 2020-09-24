Imports Logica
Public Class Login
    Dim instancia As LogicaAplicacion = New LogicaAplicacion()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menu As Menu = New Menu()
        Dim login As Boolean = instancia.login(txtUsuario.Text, txtContraseña.Text, "MED")

        If login Then
            Me.Hide()
            menu.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Error. Usuario o Contraseña incorrectos")
        End If
    End Sub


End Class