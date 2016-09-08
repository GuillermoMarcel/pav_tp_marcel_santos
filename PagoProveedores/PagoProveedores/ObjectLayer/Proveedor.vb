Public Class Proveedor
    Private id_ As Integer
    Public ReadOnly Property Id As Integer
        Get
            Return id_
        End Get
    End Property
    Public Property RazonSocial As String
    Public Property Direccion As String
    Public Property Cuit As Integer
    Public Property Observacion As String
    Public Property Telefonos As List(Of Telefono)
    Public Property Mails As List(Of Mail)

    Public Sub New(id As Integer, telefonos As List(Of Telefono), mails As List(Of Mail))
        id_ = id
        Me.Telefonos = telefonos
        Me.Mails = mails
    End Sub
End Class
