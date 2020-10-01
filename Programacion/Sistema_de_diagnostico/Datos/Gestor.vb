Public Class Gestor
    Inherits Usuario

    Public Property empresa As String

    Public Sub New(nombre As String, apellido As String, email As String, id As String, direccion As String, ci As String, contraseña As String, telefono As String, fecha As String, empresa As String)
        MyBase.New(nombre, apellido, email, id, direccion, ci, contraseña, telefono, fecha)
        Me.empresa = empresa
    End Sub
End Class
