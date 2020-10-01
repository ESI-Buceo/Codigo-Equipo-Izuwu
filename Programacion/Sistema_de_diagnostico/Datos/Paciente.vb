Public Class Paciente
    Inherits Usuario


    Public Sub New(nombre As String, apellido As String, email As String, id As String, direccion As String, ci As String, contraseña As String, telefono As String, fecha As String)
        MyBase.New(nombre, apellido, email, id, direccion, ci, contraseña, telefono, fecha)

    End Sub
End Class
