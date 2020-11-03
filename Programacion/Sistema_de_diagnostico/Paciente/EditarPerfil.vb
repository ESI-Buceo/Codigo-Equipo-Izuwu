Imports Datos, Logica
Public Class EditarPerfil
    Dim instancia As New LogicaAplicacion()
    Public paciente As Paciente
    Private Sub EditarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPrimerNombre.Text = paciente.nombre
        txtSegundoNombre.Text = paciente.segundonombre
        txtPrimerApellido.Text = paciente.apellido
        txtSegundoApellido.Text = paciente.segundoapellido
        txtDireccion.Text = paciente.Direccion
        txtEmail.Text = paciente.email
        txtTelefono.Text = paciente.telefono
        numPeso.Value = Convert.ToSingle(paciente.peso)
        numAltura.Value = Convert.ToInt32(paciente.altura)
        txtContraseña.Text = paciente.contraseña
        txtConfirmarContraseña.Text = paciente.contraseña
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        If txtContraseña.Text = txtConfirmarContraseña.Text Then
            instancia.actualizarPaciente(New Paciente(txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtEmail.Text, paciente.ID, txtDireccion.Text,
                                                  paciente.CI, txtContraseña.Text, txtTelefono.Text, paciente.fechadenacimiento, paciente.sexo, numPeso.Value.ToString, numAltura.Value.ToString,
                                                  paciente.patologiaPrevia))
        Else
            MsgBox("Las contraseñas no coinciden.")
        End If

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
    End Sub
End Class