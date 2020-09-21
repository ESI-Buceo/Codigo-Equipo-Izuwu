Public Class Medico
    Inherits Usuario
    Public Property IDmedico As String
    Public Property especializacion As String

    Public Sub New(nombre As String, apellido As String, email As String, id As String, direccion As String, ci As String, contraseña As String, telefono As String, fecha As String, IDmedico As String, Especializacion As String)
        MyBase.New(nombre, apellido, email, id, direccion, ci, contraseña, telefono, fecha)
        Me.IDmedico = IDmedico
        Me.especializacion = Especializacion
    End Sub
End Class
