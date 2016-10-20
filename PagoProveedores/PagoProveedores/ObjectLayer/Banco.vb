Public Class Banco
    Public Property id
    Public Property nombre

    Public Overrides Function ToString() As String
        Return Me.nombre
    End Function
End Class
