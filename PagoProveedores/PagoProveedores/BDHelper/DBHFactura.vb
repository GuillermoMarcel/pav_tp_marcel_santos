Imports System.Data
Imports PagoProveedores.QB
Public Class DBHFactura
    Public Shared Function getTiposFactura() As DataTable
        Dim b As New QueryBuilder
        b.table("TiposFacturas").seleccionar()
        Return DBConn.executeSQL(b.build)
    End Function

    Public Shared Function registrarFactura(idProveedor As Integer, tipo As Char, nro As Long, monto As Decimal, fecha As Date) As Boolean
        Dim comandos As New List(Of String)
        Dim b As New QueryBuilder
        b.table("FacturasEntrantes").insert({
                                            {"id_proveedor", idProveedor},
                                            {"tipo_fact", tipo},
                                            {"nro_factura", nro},
                                            {"monto", monto},
                                            {"fecha", fecha}
                                            })
        comandos.Add(b.build)

        'Para meter un decimal en un campo sin escapar, usar el format provider del escaper: Escaper.getIFormatProvider
        'EJ: nro.toString(Escaper.getIFormatProvider)
        b.table("Proveedores").update({"cuenta_corriente", "@cuenta_corriente + " + monto.ToString(Escaper.getIFormatProvider)}).
            where("@id_proveedor", idProveedor)
        comandos.Add(b.build)

        Return DBConn.executeTransaction(comandos.ToArray)

    End Function

    Public Shared Function getFacturasImpagasProveedor(id As Integer) As DataTable
        Dim q As New QueryBuilder
        q.table("FacturasEntrantes").seleccionar({"nro_factura NumeroFactura", "fecha Fecha", "monto Monto"}).
            where("@id_proveedor", id).where("@fecha_pago", "is", "@null")
        Dim t As DataTable = DBConn.executeSQL(q.build)
        If t.Rows.Count = 0 Then Throw New Exception("No se encontraron facturas impagas")
        Return t
    End Function
End Class
