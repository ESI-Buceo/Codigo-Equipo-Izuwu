Public Class ReferenciaSintomaPatologia
    Public Property IDSintoma As String
    Public Property IDPatologia As String

    Public Sub New(IDsintoma As String, IDpatologia As String)
        Me.IDSintoma = IDsintoma
        Me.IDPatologia = IDpatologia
    End Sub
End Class
