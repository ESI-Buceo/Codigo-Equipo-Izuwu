
Public Class MenuGestorNew

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



    Private Sub MenuGestor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAgregarMedico.BackColor = Color.FromArgb(48, 48, 48)
        btnABMSintomas.BackColor = Color.FromArgb(48, 48, 48)
        btnModUsuario.BackColor = Color.FromArgb(48, 48, 48)

        pAgregarMed.Visible = False
        pABMSintoma.Visible = False
    End Sub

    Private Sub btnAgregarMedico_Click(sender As Object, e As EventArgs) Handles btnAgregarMedico.Click
        cbIDS.SelectedIndex = 0
        cbIDS.Enabled = False
        btnAgregarMedico.BackColor = Color.FromArgb(36, 36, 36)
        btnABMSintomas.BackColor = Color.FromArgb(48, 48, 48)
        btnModUsuario.BackColor = Color.FromArgb(48, 48, 48)

        pAgregarMed.Visible = True
        pABMSintoma.Visible = False
    End Sub

    Private Sub btnABMSintomas_Click(sender As Object, e As EventArgs) Handles btnABMSintomas.Click
        btnAgregarMedico.BackColor = Color.FromArgb(48, 48, 48)
        btnABMSintomas.BackColor = Color.FromArgb(36, 36, 36)
        btnModUsuario.BackColor = Color.FromArgb(48, 48, 48)

        pAgregarMed.Visible = False
        pABMSintoma.Visible = True
    End Sub


    Private Sub btnModUsuario_Click_1(sender As Object, e As EventArgs) Handles btnModUsuario.Click
        btnAgregarMedico.BackColor = Color.FromArgb(48, 48, 48)
        btnABMSintomas.BackColor = Color.FromArgb(48, 48, 48)
        btnModUsuario.BackColor = Color.FromArgb(36, 36, 36)

        cbIDS.SelectedIndex = 0
        cbIDS.Enabled = True

        pAgregarMed.Visible = True
        pABMSintoma.Visible = False
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------------

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




End Class