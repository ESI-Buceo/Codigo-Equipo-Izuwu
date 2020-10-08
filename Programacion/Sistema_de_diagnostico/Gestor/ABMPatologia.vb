Imports Datos, Logica

Public Class ABMPatologia
    Public patologia As Patologia
    Public confirmar As Integer
    Dim instancia As New LogicaAplicacion()



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub ABMPatologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If confirmar = -1 Then
            limpiarPantalla()
            txtIDPatologia.Text = instancia.codigoRandom(2)

        ElseIf confirmar = 0 Then
            limpiarPantalla()
            cargarPatologia()
        End If
    End Sub

    Public Sub limpiarPantalla()
        txtNombre.Clear()
        txtIDPatologia.Clear()
        numPrioridad.Value = 1
    End Sub

    Public Sub cargarPatologia()

        txtNombre.Text = patologia.nombre
        txtIDPatologia.Text = patologia.id
        numPrioridad.Value = Convert.ToInt32(patologia.prioridad)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If confirmar = -1 Then
            instancia.AMpatologia(confirmar, New Patologia(txtNombre.Text, numPrioridad.Value.ToString, txtIDPatologia.Text))
        ElseIf confirmar = 0 Then
            instancia.AMpatologia(confirmar, New Patologia(txtNombre.Text, numPrioridad.Value.ToString, txtIDPatologia.Text))
        End If

        MenuGestorNew.limpiarListaPatologia()
        MenuGestorNew.limpiarListaSintomas()
        MenuGestorNew.cargarListaSintoma()
        MenuGestorNew.cargarListaPatologia()
        Me.Close()
    End Sub
End Class