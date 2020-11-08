Imports System.Globalization
Imports Datos, Logica
Public Class Registro


    Dim ejeX, ejeY As Integer
    Dim Arrastre As Boolean
    Dim instancia As New LogicaAplicacion()

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
    '------------------------------------------------------------------------------------------------------------------------------------------------
    'Botones para cerrar y minimizar la aplicacion.
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    '----------------------------------------------------------------------------------------------------------------------------------------------

    'Este boton toma todos los datos introducidos en las casillas correspondientes
    'y los envia a la funcion "AgregarPaciente" de la persistencia.
    'Luego llama a la ventana login para que el paciente pueda loguearse.
    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        If txtContraseña.Text = txtConfContraseña.Text Then
            Dim fecha As Date = dateFechaNacimiento.Value.Date
            Dim fechastring As String = Format(fecha, "yyyy/MM/dd")
            Dim id As String = instancia.codigoRandom(3)
            Dim altura As String = String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:0.00}", numAltura.Value)
            Dim peso As String = String.Format(System.Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:0.0}", numPeso.Value)

            instancia.agregarPaciente(New Paciente(txtPrimerNombre.Text, txtSegundoNombre.Text, txtApellido.Text, txtSegundoApellido.Text, txtEmail.Text, id, txtDireccion.Text, txtCI.Text, txtContraseña.Text, txtTelefono.Text, fechastring, cbxSexo.Text, peso, altura, txtPatologiaPrevia.Text))
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

            Me.Hide()
            Login.ShowDialog()
            Me.Close()
        Else
            MsgBox("Las contraseñas no coincides.")
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