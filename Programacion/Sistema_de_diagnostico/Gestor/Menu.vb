Public Class Menu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarUs.Click
        AgrUsuario.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnABMPatologia.Click
        ABMPatologiaSintoma.Show()
    End Sub

    Private Sub btnModificarUs_Click(sender As Object, e As EventArgs) Handles btnModificarUs.Click
        MsgBox("Proximamente.")
    End Sub
End Class
