Imports Logica
Public Class Registro
    Dim instancia As LogicaAplicacion = New LogicaAplicacion()
    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click


        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtCI.Text = "" Or txtTelefono.Text = "" Or txtDireccion.Text = "" Or txtCorreo.Text = "" Then
            MsgBox("Datos faltantes.")

        ElseIf txtContraseña.Text <> txtConfContraseña.Text Then
            MsgBox("Las contraseñas no coinciden.")

        ElseIf txtConfContraseña.Text = txtContraseña.Text Then
            Dim Anio As String = (mthFecha.SelectionStart.Year)
            Dim Mes As String = (mthFecha.SelectionStart.Month)
            Dim Dia As String = (mthFecha.SelectionStart.Day)
            Dim FDN As String = (Anio + "-" + Mes + "-" + Dia)
            Dim ID As String = instancia.generarRandomID("PAC", "3")
            instancia.agregarPaciente(ID, txtNombre.Text, txtApellido.Text, txtCI.Text, txtTelefono.Text, txtDireccion.Text, txtCorreo.Text, txtContraseña.Text, FDN)
            MsgBox("Registro realizado con exito.")
            Me.Close()


        End If


    End Sub

End Class
