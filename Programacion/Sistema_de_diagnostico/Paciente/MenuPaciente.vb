Public Class MenuPaciente

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDiagnostico.Click
        Diagnostico.pnlListaSintoma.Visible = True
        Diagnostico.pnlDiagnostico.Visible = False
        Diagnostico.cbxSintoma.Items.Clear()
        Diagnostico.listSintoma.Items.Clear()
        Diagnostico.cbxSintoma.Items.Clear()
        Diagnostico.ShowDialog()

    End Sub

    Private Sub Historial_Click(sender As Object, e As EventArgs) Handles Historial.Click
        MsgBox("Proximamente.")
    End Sub

    Private Sub Chat_Click(sender As Object, e As EventArgs) Handles Chat.Click
        MsgBox("Proximamente.")
    End Sub
End Class
