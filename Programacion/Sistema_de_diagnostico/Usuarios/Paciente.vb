Public Class Paciente
    Inherits Usuario
    Public Property IDpaciente As String

    Public Sub New(nombre As String, apellido As String, email As String, id As String, direccion As String, ci As String, contraseña As String, telefono As String, fecha As String, IDpaciente As String)
        MyBase.New(nombre, apellido, email, id, direccion, ci, contraseña, telefono, fecha)
        Me.IDpaciente = IDpaciente
    End Sub
End Class
