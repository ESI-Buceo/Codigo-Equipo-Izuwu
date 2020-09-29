Public Class MenuPacienteOLD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDiagnostico.Click
        DiagnosticoOLD.pnlListaSintoma.Visible = True
        DiagnosticoOLD.pnlDiagnostico.Visible = False
        DiagnosticoOLD.cbxSintoma.Items.Clear()
        DiagnosticoOLD.listSintoma.Items.Clear()
        DiagnosticoOLD.cbxSintoma.Items.Clear()
        DiagnosticoOLD.ShowDialog()

    End Sub

    Private Sub Historial_Click(sender As Object, e As EventArgs) Handles Historial.Click
        MsgBox("Proximamente.")
    End Sub

    Private Sub Chat_Click(sender As Object, e As EventArgs) Handles Chat.Click
        MsgBox("Proximamente.")
    End Sub
End Class
