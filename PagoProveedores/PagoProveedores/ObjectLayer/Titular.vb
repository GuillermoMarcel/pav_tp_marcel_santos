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

    Public Function nombreCompleto()
        If Me.apellido = String.Empty Then Return Me.nombre
        If Me.nombre = String.Empty Then Return Me.apellido
        Return Me.apellido & ", " & Me.nombre
    End Function
End Class
