Imports PagoProveedores.QB
Public Class RHProveedores
    Public Shared Sub proveedoresConDeuda(tabla As DataTable)
        Dim q As New QueryBuilder
        q.table("Proveedores").seleccionar({"id_proveedor Id", "razon_social", "cuit", "cuenta_corriente"}).orderBy("cuenta_corriente desc")
        tabla.Clear()
        DBConn.llenarTabla(q.build, tabla)
    End Sub
End Class
