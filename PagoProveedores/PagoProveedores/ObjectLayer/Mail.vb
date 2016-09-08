Public Class Mail
    Public Property Direccion As String
    Public Property Observacion As String
    Public Overrides Function ToString() As String
        Return Me.Direccion
    End Function
End Class
