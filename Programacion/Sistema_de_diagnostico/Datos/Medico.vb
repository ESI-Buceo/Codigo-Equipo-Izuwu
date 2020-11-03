Public Class Medico
    Inherits Usuario


    Public Property lugarDeTrabajo As String
    Public Property especializacion As String

    Public Sub New(nombre As String, segundonombre As String, apellido As String, segundoapellido As String, email As String, id As String, direccion As String, ci As String, contraseña As String, especializacion As String, telefono As String, fecha As String, sexo As String, lugarDeTrabajo As String)
        MyBase.New(nombre, segundonombre, apellido, segundoapellido, email, id, direccion, ci, contraseña, telefono, fecha, sexo)
        Me.especializacion = especializacion
        Me.lugarDeTrabajo = lugarDeTrabajo
    End Sub
End Class
