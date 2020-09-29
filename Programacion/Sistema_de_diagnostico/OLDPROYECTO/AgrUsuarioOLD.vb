Imports Logica
Public Class AgrUsuarioOLD
    Dim instancia As LogicaAplicacion = New LogicaAplicacion()

    Public Sub limpiarPantalla()
        txtID.ResetText()
        txtNombre.ResetText()
        txtApellido.ResetText()
        txtCI.ResetText()
        txtTelefono.ResetText()
        txtDireccion.ResetText()
        txtEspecializacion.ResetText()
        txtEmpresa.ResetText()
        txtEMail.ResetText()
        txtConfContraseña.ResetText()
        txtContraseña.ResetText()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        If rbtnMedico.Checked = True Then


            If txtContraseña.Text = txtConfContraseña.Text Then
                Dim Anio As String = (mthFecha.SelectionStart.Year)
                Dim Mes As String = (mthFecha.SelectionStart.Month)
                Dim Dia As String = (mthFecha.SelectionStart.Day)
                Dim FDN As String = (Anio + "-" + Mes + "-" + Dia)

                ' instancia.agregarMedico(txtID.Text, txtNombre.Text, txtApellido.Text, txtCI.Text, txtTelefono.Text, txtDireccion.Text, txtEspecializacion.Text, txtEMail.Text, txtContraseña.Text, FDN)

                MessageBox.Show("El registro de " + txtNombre.Text + " " + txtApellido.Text + " se realizo con exito")

                limpiarPantalla()

            Else
                MessageBox.Show("Las contraseñas no coinciden!")
            End If
        ElseIf rbtnGestor.Checked = True Then
            If txtContraseña.Text = txtConfContraseña.Text Then
                Dim Anio As String = (mthFecha.SelectionStart.Year)
                Dim Mes As String = (mthFecha.SelectionStart.Month)
                Dim Dia As String = (mthFecha.SelectionStart.Day)
                Dim FDN As String = (Anio + "-" + Mes + "-" + Dia)

                'instancia.agregarGestor(txtID.Text, txtNombre.Text, txtApellido.Text, txtCI.Text, txtTelefono.Text, txtDireccion.Text, txtEmpresa.Text, txtEMail.Text, txtContraseña.Text, FDN)

                MessageBox.Show("El registro de " + txtNombre.Text + " " + txtApellido.Text + " se realizo con exito")

                limpiarPantalla()
            Else
                MessageBox.Show("Las contraseñas no coinciden!")
            End If
        End If



    End Sub

    Private Sub rbtnMedico_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMedico.CheckedChanged
        lblInfo.Text = "Especializacion"
        'txtID.Text = instancia.generarRandomID("MED", "1")
        txtEmpresa.Visible = False
        txtEspecializacion.Visible = True
    End Sub

    Private Sub rbtnGestor_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnGestor.CheckedChanged
        lblInfo.Text = "Empresa"
        ' txtID.Text = instancia.generarRandomID("GES", "4")
        txtEmpresa.Visible = True
        txtEspecializacion.Visible = False
    End Sub
End Class
