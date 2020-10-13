Public Class Gestor
    Inherits Usuario

    Public Property empresa As String

    Public Sub New(nombre As String, segundonombre As String, apellido As String, segundoapellido As String, email As String, id As String, direccion As String, ci As String, contraseña As String, telefono As String, fecha As String, sexo As String, empresa As String)
        MyBase.New(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fecha, sexo)
        Me.empresa = empresa
    End Sub
End Class
