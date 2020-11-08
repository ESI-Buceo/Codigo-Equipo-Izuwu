Imports Logica, Datos
Public Class Login

    Dim Instancia As LogicaAplicacion = New LogicaAplicacion()
    Dim ejeX, ejeY As Integer
    Dim Arrastre As Boolean

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

    '------------------------------------------------------------------------------------------------------------------------------

    'Se verifica si el usuario y contraseña esten bien ingresados
    'y se crea una nueva instancia de la ventana para crearla con los parametros
    'personalizados, para cada usuario.
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

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

    'Este evento hace lo mismo que el boton de ingresar,
    'solo que ocurre cuando el usuario aprieta Enter,
    'mientras el foco este puesto en el textBox de contraseña.
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class