Public Class Medico
    Inherits Usuario

    Public Property especializacion As String

    Public Sub New(nombre As String, apellido As String, email As String, id As String, direccion As String, ci As String, contraseña As String, telefono As String, fecha As String, Especializacion As String)
        MyBase.New(nombre, apellido, email, id, direccion, ci, contraseña, telefono, fecha)
        Me.especializacion = Especializacion
    End Sub
End Class
