Public Class Cuenta
    Public Property NroCuenta As String
    Public Property Banco As Banco
    'Public Property id_titular As Integer
    Public Property Sucursal As Integer
    Public Property CBU As String

    Public Overrides Function ToString() As String
        Return Me.Banco.nombre & ": " & NroCuenta
    End Function
End Class
