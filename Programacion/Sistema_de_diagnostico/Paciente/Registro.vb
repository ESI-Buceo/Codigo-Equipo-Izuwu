Imports Datos, Logica
Public Class Registro


    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim instancia As New LogicaAplicacion()


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


    Private Sub Button1_MouseMove(sender As Object, e As MouseEventArgs) Handles Button1.MouseMove
        Button1.BackColor = Color.FromArgb(255, 96, 96)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        If txtContraseña.Text = txtConfContraseña.Text Then
            Dim fecha As Date = dateFechaNacimiento.Value.Date
            Dim fechastring As String = Format(fecha, "yyyy/MM/dd")
            Dim id As String = instancia.codigoRandom(3)
            instancia.agregarPaciente(New Paciente(txtPrimerNombre.Text, txtSegundoNombre.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, id, txtDireccion.Text, txtCI.Text, txtContraseña.Text, txtTelefono.Text, fechastring, cbxSexo.Text, numPeso.Value.ToString, numAltura.Value.ToString, txtPatologiaPrevia.Text))
            MsgBox("Registro exitoso.")
            txtPrimerNombre.Clear()
            txtSegundoNombre.Clear()
            txtApellido.Clear()
            txtSegundoApellido.Clear()
            dateFechaNacimiento.ResetText()
            cbxSexo.ResetText()
            numAltura.ResetText()
            numPeso.ResetText()
            txtDireccion.Clear()
            txtCI.Clear()
            txtEmail.Clear()
            txtTelefono.Clear()
            txtContraseña.Clear()
            txtConfContraseña.Clear()
            Me.Close()
        Else
            MsgBox("Las contraseñas no coincides.")
        End If
    End Sub

    Private Sub RegistroNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles labAtras.Click
        Me.Hide()
        Login.ShowDialog()
        Me.Close()
    End Sub
End Class