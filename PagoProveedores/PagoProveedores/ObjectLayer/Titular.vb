Public Class Titular
    Public Sub New()
        cuentas = New List(Of Cuenta)
    End Sub
    Public Property id_titular As Integer
    Public Property nombre As String
    Public Property apellido As String
    Public Property cuit As Long
    Public Property calle As String
    Public Property altura As Integer
    Public Property cuentas As List(Of Cuenta)
End Class
