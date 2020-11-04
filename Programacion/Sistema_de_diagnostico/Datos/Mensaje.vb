Imports System.Diagnostics.Contracts

Public Class Mensaje
    Public Property contenido As String
    Public Property emisor As String
    Public Property fecha As String

    Public Sub New(contenido As String, emisor As String, fecha As String)
        Me.contenido = contenido
        Me.emisor = emisor
        Me.fecha = fecha
    End Sub
End Class
