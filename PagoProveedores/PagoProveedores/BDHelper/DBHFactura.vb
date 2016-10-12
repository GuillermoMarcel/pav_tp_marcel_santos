Imports System.Data
Imports PagoProveedores.QB
Public Class DBHFactura
    Public Shared Function getTiposFactura() As DataTable
        Dim b As New QueryBuilder
        b.table("TiposFacturas").seleccionar()
        Return DBConn.executeSQL(b.build)
    End Function
End Class
