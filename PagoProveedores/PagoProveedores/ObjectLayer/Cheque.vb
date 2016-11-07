Public Class Cheque
    Public Property Numero As Integer
    Public Property Monto As Decimal

    'esto es chanchada pero quiero ver si funciona y despues lo hago como la gente
    Public Property NroCuenta As String
    Public Property NroBanco As Integer
    Public Property Banco As String
    Public Property Titular As String
    'hasta aca llega la chanchada el resto estaba hecho de antes

    Public Property FechaEmision As Date
    Public Property FechaVencimiento As Date
    Public Property FechaDeposito As Date
    Public Property Cruzado As Boolean
    Public Property Estado As EstadoCheque
    Public Property Observacion As String

End Class
