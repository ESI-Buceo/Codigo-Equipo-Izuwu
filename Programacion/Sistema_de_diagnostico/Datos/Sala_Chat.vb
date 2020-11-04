Public Class Sala_Chat
    Public Property id_sala As String
    Public Property fecha As String
    Public Property estado As String
    Public Property id_usuario As String
    Public Property nombre_usuario As String
    Public Property apellido_usuario As String

    Public Sub New(id_sala As String, fecha As String, estado As String, id_usuario As String, nombre_usuario As String, apellido_usuario As String)
        Me.id_sala = id_sala
        Me.fecha = fecha
        Me.estado = estado
        Me.id_usuario = id_usuario
        Me.nombre_usuario = nombre_usuario
        Me.apellido_usuario = apellido_usuario
    End Sub

End Class
