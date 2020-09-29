Imports Logica
Public Class DiagnosticoOLD
    Dim instancia As LogicaAplicacion = New LogicaAplicacion()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        listSintoma.Items.Add(cbxSintoma.Text)
        cbxSintoma.ResetText()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        pnlListaSintoma.Visible = False
        pnlDiagnostico.Visible = True

        Dim listasintomas As New List(Of String)
        For i = 0 To listSintoma.Items.Count - 1
            listasintomas.Add(listSintoma.Items.Item(i).ToString)
        Next
        'instancia.prueba(listasintomas)




    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        listSintoma.Items.Remove(listSintoma.SelectedItem)
    End Sub

    Private Sub Form3Paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '    Lista para albergar los datos conseguidos en codigo
        Dim lista As New List(Of String)

        '   A la lista se le cargan los valores de la Base de datos
        'lista.AddRange(instancia.cargarsintomas)

        'Se recorre la lista y se va agregando cada item a el combobox de la ventana
        For Each sintoma As String In lista
            cbxSintoma.Items.Add(sintoma)

        Next
    End Sub

End Class
