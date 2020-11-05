Imports Datos, Logica
Public Class EditarPerfil
    Dim instancia As New LogicaAplicacion()
    Public paciente As Paciente
    Private Sub EditarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPaciente()
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

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