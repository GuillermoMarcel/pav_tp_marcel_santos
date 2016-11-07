Imports PagoProveedores.QB
Public Class RHCheques
    Public Shared Sub chequesEmitidos(tabla As DataTable)
        Dim q As New QueryBuilder
        DBConn.llenarTabla("select nro_cheque nro, monto, fecha_vencimiento fecha from Cheques ch join Cuentas c on ch.nro_cuenta = c.nro_cuenta and c.nro_banco = ch.nro_banco where favorita = 1", tabla)
    End Sub
End Class
