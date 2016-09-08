Public Class Telefono
    Public Property Numero As String
    Public Property Observacion As String
    Public Overrides Function ToString() As String
        Return Numero
    End Function
End Class
