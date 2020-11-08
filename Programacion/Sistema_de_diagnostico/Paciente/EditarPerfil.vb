Imports Datos, Logica
Public Class EditarPerfil
    Dim instancia As New LogicaAplicacion()
    Public paciente As Paciente

    'Cuando se carga la ventana, se cargan con los datos del paciente
    'en los textbox y numericUpDown correspondientes.
    Private Sub EditarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPaciente()
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

    'Se envian los datos cambiados (y no cambiados)
    'a la persistencia para que se actualicen los datos del paciente.
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtContraseña.Text = txtConfirmarContraseña.Text Then
            instancia.actualizarPaciente(New Paciente(paciente.nombre, paciente.apellido, paciente.apellido, paciente.segundoapellido, txtEmail.Text, paciente.ID, txtDireccion.Text,
                                                  paciente.CI, txtContraseña.Text, txtTelefono.Text, paciente.fechadenacimiento, paciente.sexo, numAltura.Value.ToString, numPeso.Value.ToString,
                                                  paciente.patologiaPrevia))
        Else
            MsgBox("Las contraseñas no coinciden.")
        End If

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
    End Sub

    Public Sub cargarPaciente()
        txtDireccion.Text = paciente.Direccion
        txtEmail.Text = paciente.email
        txtTelefono.Text = paciente.telefono
        numAltura.Value = Convert.ToSingle(paciente.altura)
        numPeso.Value = Convert.ToSingle(paciente.peso)
        txtContraseña.Text = paciente.contraseña
        txtConfirmarContraseña.Text = paciente.contraseña
    End Sub

End Class