Public Class MenuPacienteNew

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



    Private Sub MenuPacienteNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRealizarDiagnostico.BackColor = Color.FromArgb(40, 117, 207)
        btnChats.BackColor = Color.FromArgb(40, 117, 207)
        btnCerrarsesion.BackColor = Color.FromArgb(40, 117, 207)

        pChat.Visible = False
        pRealizarD.Visible = False
        pRealizaD2.Visible = False
    End Sub

    Private Sub btnRealizarDiagnostico_Click(sender As Object, e As EventArgs) Handles btnRealizarDiagnostico.Click
        btnRealizarDiagnostico.BackColor = Color.FromArgb(24, 68, 122)
        btnChats.BackColor = Color.FromArgb(40, 117, 207)
        btnCerrarsesion.BackColor = Color.FromArgb(40, 117, 207)

        pChat.Visible = False
        pRealizarD.Visible = True
        pRealizaD2.Visible = True
    End Sub

    Private Sub btnChats_Click(sender As Object, e As EventArgs) Handles btnChats.Click
        btnRealizarDiagnostico.BackColor = Color.FromArgb(40, 117, 207)
        btnChats.BackColor = Color.FromArgb(24, 68, 122)
        btnCerrarsesion.BackColor = Color.FromArgb(40, 117, 207)

        pChat.Visible = True
    End Sub


    Private Sub btnCerrarsesion_Click_1(sender As Object, e As EventArgs) Handles btnCerrarsesion.Click
        btnRealizarDiagnostico.BackColor = Color.FromArgb(40, 117, 207)
        btnChats.BackColor = Color.FromArgb(40, 117, 207)
        btnCerrarsesion.BackColor = Color.FromArgb(24, 68, 122)

        pChat.Visible = False
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



    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        pRealizarD.Visible = False
        pRealizaD2.Visible = False
        btnRealizarDiagnostico.BackColor = Color.FromArgb(40, 117, 207)
    End Sub
End Class