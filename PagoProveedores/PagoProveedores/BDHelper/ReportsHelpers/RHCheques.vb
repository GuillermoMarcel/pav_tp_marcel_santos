Imports PagoProveedores.QB
Public Class RHCheques
    Public Shared Sub chequesEmitidos(tabla As DataTable, c As Cuenta, Optional fechas As Date() = Nothing)
        Dim sql As String = "select nro_cheque nro, monto, fecha_vencimiento from Cheques ch " & _
            "join Cuentas c on ch.nro_cuenta = c.nro_cuenta and c.nro_banco = ch.nro_banco where " & _
            " c.nro_cuenta = '" & c.NroCuenta & "' and c.nro_banco= " & c.Banco.id
        If fechas IsNot Nothing AndAlso fechas.Length = 2 Then
            sql &= " and fecha_vencimiento between '" & DBUtils.DateToDB(fechas(0)) & "' and '" & DBUtils.DateToDB(fechas(1)) & "'"
        End If
        tabla.Clear()
        DBConn.llenarTabla(sql, tabla)
    End Sub
End Class
