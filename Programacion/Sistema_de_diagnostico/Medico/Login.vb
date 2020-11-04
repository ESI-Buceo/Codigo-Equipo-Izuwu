Imports Logica, Datos
Public Class Login

    Dim ex, ey As Integer
    Dim Arrastre As Boolean



    'Definir variables globales; estas van despues de la linea de inherits

    'Estas tres subrutinas permiten desplazar el formulario. 

    Private Sub LoginNew_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        ex = e.X

        ey = e.Y

        Arrastre = True

    End Sub

    Private Sub LoginNew_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp

        Arrastre = False

    End Sub

    Private Sub LoginNew_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))

        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))

    End Sub


    Dim Instancia As LogicaAplicacion = New LogicaAplicacion()



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        Try
            'Se toman los datos de los cuadros de texto CI y Contraseña
            Dim medico As Medico = Instancia.loginMedico(txtUsuario.Text, txtContraseña.Text)
            Dim menuPaciente As New MenuMedico()
            menuPaciente.medico = medico


            Me.Hide()
            menuPaciente.ShowDialog()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                'Se toman los datos de los cuadros de texto CI y Contraseña
                Dim medico As Medico = Instancia.loginMedico(txtUsuario.Text, txtContraseña.Text)
                Dim menuPaciente As New MenuMedico()
                menuPaciente.medico = medico


                Me.Hide()
                menuPaciente.ShowDialog()
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label6_MouseMove(sender As Object, e As MouseEventArgs) Handles Label6.MouseMove
        Label6.ForeColor = Color.FromArgb(0, 0, 255)
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub



    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        'Registro.ShowDialog()
        Me.Close()
    End Sub
End Class