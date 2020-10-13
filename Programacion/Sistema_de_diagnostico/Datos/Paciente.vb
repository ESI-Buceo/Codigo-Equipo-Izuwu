Public Class Paciente
    Inherits Usuario

    Public Property peso As String
    Public Property altura As String
    Public Property patologiaPrevia As String

    Public Sub New(nombre As String, segundonombre As String, apellido As String, segundoapellido As String, email As String, id As String, direccion As String, ci As String, contraseña As String, telefono As String, fecha As String, sexo As String, peso As String, altura As String, patologiaprevia As String)
        MyBase.New(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fecha, sexo)

        Me.peso = peso
        Me.altura = altura
        Me.patologiaPrevia = patologiaprevia
    End Sub
End Class
