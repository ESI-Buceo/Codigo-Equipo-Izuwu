Public Class Diagnostico
    Inherits Patologia

    Public Property idPaciente As String
    Public Property Probabilidad As Integer
    Public Property fecha As Date


    Public Sub New(nombre As String, prioridad As String, idPatologia As String, especialidad As String, idPaciente As String, Probabilidad As Integer, fecha As Date)
        MyBase.New(nombre, prioridad, idPatologia, especialidad)
        Me.idPaciente = idPaciente
        Me.Probabilidad = Probabilidad
        Me.fecha = fecha

    End Sub

End Class
