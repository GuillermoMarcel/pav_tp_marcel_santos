Public Class Direccion
    Public Sub New(Optional calle As String = "", Optional altura As Integer = 0)
        Me.Calle = calle
        Me.Altura = altura
    End Sub
    Public Property Calle As String
    Public Property Altura As Integer
    Public Overrides Function ToString() As String
        Return Me.Calle & " " & Me.Altura
    End Function
End Class
