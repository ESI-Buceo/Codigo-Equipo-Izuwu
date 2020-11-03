Public Class Patologia
    Public Property nombre As String
    Public Property prioridad As String
    Public Property id As String

    Public Property especialidad As String

    Public Sub New(nombre As String, prioridad As String, id As String, especialidad As String)
        Me.nombre = nombre
        Me.prioridad = prioridad
        Me.id = id
        Me.especialidad = especialidad
    End Sub
End Class
