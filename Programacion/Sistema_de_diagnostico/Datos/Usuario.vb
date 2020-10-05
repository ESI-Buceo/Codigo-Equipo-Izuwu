Public Class Usuario
    Public Property nombre As String
    Public Property segundonombre As String
    Public Property apellido As String
    Public Property segundoapellido As String
    Public Property email As String
    Public Property ID As String
    Public Property Direccion As String
    Public Property CI As String
    Public Property contraseña As String
    Public Property telefono As String
    Public Property fechadenacimiento As String

    Public Sub New(nombre As String, segundonombre As String, apellido As String, segundoapellido As String, email As String, id As String, direccion As String, ci As String, contraseña As String, telefono As String, fecha As String)
        Me.nombre = nombre
        Me.segundonombre = segundonombre
        Me.apellido = apellido
        Me.segundoapellido = segundoapellido
        Me.email = email
        Me.ID = id
        Me.Direccion = direccion
        Me.CI = ci
        Me.contraseña = contraseña
        Me.telefono = telefono
        Me.fechadenacimiento = fecha
    End Sub


End Class
