Public Class frmPagos

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_proveedor.DataSource = DBHProveedor.getProveedores
        cbo_proveedor.ValueMember = "id_proveedor"
        cbo_proveedor.DisplayMember = "razon_social"

        dgv_cheques_cartera.DataSource = DBHCheque.getChequesCartera()
    End Sub

    Private Sub cbo_proveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_proveedor.SelectedIndexChanged
        dgv_facturas_pendientes.DataSource = Nothing
        dgv_facturas_seleccionadas.DataSource = Nothing
        actualizarDGVFacturas()
    End Sub

    Private Sub actualizarDGVFacturas()
        dgv_facturas_pendientes.DataSource = DBHFactura.getFacturasImpagasProveedor(cbo_proveedor.SelectedValue)
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        actualizarDGVFacturas()
    End Sub
End Class