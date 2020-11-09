Public Class tratamiento
    Public Property nombre As String
    Public Property apellido As String
    Public Property id_dapp As String
    Public Property contenido As String

    Public Property fecha As String

    Public Sub New(nombre As String, apellido As String, id_dapp As String, contenido As String, fecha As String)
        Me.nombre = nombre
        Me.apellido = apellido
        Me.id_dapp = id_dapp
        Me.contenido = contenido
        Me.fecha = fecha
    End Sub

End Class
