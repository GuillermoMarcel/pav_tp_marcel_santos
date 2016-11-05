Imports PagoProveedores.QB
Public Class RHProveedores
    Public Shared Sub proveedoresConDeuda(tabla As DataTable)
        Dim q As New QueryBuilder
        q.table("Proveedores").seleccionar({"id_proveedor Id", "razon_social", "cuit", "cuenta_corriente"}).orderBy("cuenta_corriente desc")
        tabla.Clear()
        DBConn.llenarTabla(q.build, tabla)
    End Sub

    Public Shared Sub facturas(tabla As DataTable)
        Dim q As New QueryBuilder
        q.table("Proveedores").seleccionar({"razon_social proveedor"}).
            join("FacturasEntrantes", "id_proveedor", {"tipo_fact tipo", "nro_factura nro", "monto"})
        q.orderBy("monto")
        tabla.Clear()
        DBConn.llenarTabla(q.build, tabla)
    End Sub
End Class
