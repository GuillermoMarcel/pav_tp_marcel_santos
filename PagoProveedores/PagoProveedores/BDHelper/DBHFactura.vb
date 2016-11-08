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


    Public Shared Function confirmarPago(cheques As List(Of Cheque), facturas As List(Of Factura), efectivo As Decimal, obs As String, idprov As Integer)
        Dim mf As Decimal = 0,
            mp As Decimal = 0
        For Each ch As Cheque In cheques
            mp += ch.Monto
        Next
        mp += efectivo
        For Each fa As Factura In facturas
            mf += fa.Monto
        Next


        Dim comandos As New List(Of String)
        Dim q As New QueryBuilder
        q.table("Pagos").insert({{"fecha", "@getdate()"},
                                 {"monto_facturas", mf},
                                 {"monto_pagado", mp},
                                 {"efectivo", efectivo},
                                 {"observacion", obs}})
        comandos.Add(q.build)
        comandos.Add("DECLARE @PagoId INT = @@IDENTITY")
        Dim c As Cheque
        For Each c In cheques
            q = New QueryBuilder
            q.table("Cheques").update({"id_estado", 2}).where("@nro_banco", c.NroBanco).where("@nro_cheque", c.Numero).where("@nro_cuenta", "@'" & c.NroCuenta & "'")
            comandos.Add(q.build)
            q.clear()
            q.table("Pago_Cheques").insert({{"id_pago", "@@PagoId"},
                                            {"nro_cheque", c.Numero},
                                            {"nro_banco", c.NroBanco},
                                            {"nro_cuenta", "@'" & c.NroCuenta & "'"}})
            comandos.Add(q.build)
        Next

        Dim f As Factura
        For Each f In facturas
            q.clear.table("FacturasEntrantes").update({"fecha_pago", "@getdate()"}).where("@id_proveedor", idprov).where("@tipo_fact", f.Tipo).where("@nro_factura", f.NroFactura)
            comandos.Add(q.build)
            q.clear.table("Pago_Facturas").insert({{"id_pago", "@@PagoId"},
                                                     {"id_proveedor", idprov},
                                                     {"tipo_fact", f.Tipo},
                                                     {"nro_factura", f.NroFactura}})
            comandos.Add(q.build)
        Next
        q.clear.table("Proveedores").update({"cuenta_corriente", "@cuenta_corriente - " & mp}).where("@id_proveedor", idprov)
        comandos.Add(q.build)
        Return DBConn.executeTransaction(comandos.ToArray)
    End Function

End Class
