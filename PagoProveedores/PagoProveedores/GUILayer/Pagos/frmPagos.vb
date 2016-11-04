Public Class frmPagos

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_proveedor.DataSource = DBHProveedor.getProveedores
        cbo_proveedor.ValueMember = "id_proveedor"
        cbo_proveedor.DisplayMember = "razon_social"
    End Sub

    Private Sub cbo_proveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_proveedor.SelectedIndexChanged
        dgv_facturas_pendientes.DataSource = Nothing
        dgv_facturas_seleccionadas.DataSource = Nothing
    End Sub


    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click

        dgv_facturas_pendientes.DataSource = DBHFactura.getFacturasImpagasProveedor(cbo_proveedor.SelectedValue)
    End Sub
End Class