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

    Public Shared Function getFacturasImpagasProveedor(id As Integer) As List(Of Factura)
        Dim q As New QueryBuilder
        Dim i As Integer
        Dim t As New DataTable
        Dim facturas As New List(Of Factura)
        If Integer.TryParse(id, i) Then
            q.table("FacturasEntrantes").seleccionar({"nro_factura", "fecha", "monto", "tipo_fact"}).
            where("@id_proveedor", id).where("@fecha_pago", "is", "@null")
            t = DBConn.executeSQL(q.build)
            If t.Rows.Count = 0 Then Throw New Exception("No se encontraron facturas impagas")
        Else
            Throw New Exception("Id proveedor invalido")
        End If
        For Each row As DataRow In t.Rows
            Dim f As New Factura

            f.NroFactura = Long.Parse(row.Item("nro_factura").ToString)
            f.Tipo = Char.Parse(row.Item("tipo_fact").ToString)
            f.Fecha = Date.Parse(row.Item("fecha").ToString)
            f.Monto = Decimal.Parse(row.Item("monto").ToString)
            f.Proveedor = id
            facturas.Add(f)
        Next

        Return facturas
    End Function

End Class
