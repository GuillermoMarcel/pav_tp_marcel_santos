Public Class frmPagos

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_proveedor.DataSource = DBHProveedor.getProveedores
        cbo_proveedor.ValueMember = "id_proveedor"
        cbo_proveedor.DisplayMember = "razon_social"
        cbo_proveedor.SelectedIndex = 1
        dgv_cheques_cartera.DataSource = DBHCheque.getChequesCartera()
    End Sub

    Private Sub cbo_proveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_proveedor.SelectedIndexChanged
        'Por alguna razon si el cbo nunca se habia seleccionado me tiraba invalid cast ex, pero si controlo con una bandera que la primer no haga nada esta todo ok
        Dim flag As Boolean = False
        If flag Then
            actualizarDGVFacturas()
        End If
        flag = True
    End Sub

    Private Sub actualizarDGVFacturas()
        dgv_facturas_pendientes.DataSource = Nothing
        dgv_facturas_seleccionadas.DataSource = Nothing
        Dim c As Integer = Integer.Parse(cbo_proveedor.SelectedValue.ToString)
        dgv_facturas_pendientes.DataSource = DBHFactura.getFacturasImpagasProveedor(c)
        dgv_facturas_pendientes.Columns.Item(3).Visible = False
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        actualizarDGVFacturas()
    End Sub

    Private Sub btn_agregar_factura_Click(sender As Object, e As EventArgs) Handles btn_agregar_factura.Click
        For Each row As DataGridViewRow In dgv_facturas_pendientes.SelectedRows
            dgv_facturas_seleccionadas.Rows.Add(New String() {row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value})
        Next

        For Each row As DataGridViewRow In dgv_facturas_pendientes.SelectedRows
            dgv_facturas_pendientes.Rows.Remove(row)
        Next

    End Sub

    Private Sub btn_quitar_factura_Click(sender As Object, e As EventArgs) Handles btn_quitar_factura.Click
        Dim list As New List(Of factura)
        For Each row As DataGridViewRow In dgv_facturas_seleccionadas.SelectedRows
            Dim f As New Factura
            f.NroFactura = row.Cells(0).Value
            f.tipoFactura = row.Cells(3).Value
            f.Proveedor = cbo_proveedor.SelectedValue
            list.Add(f)
        Next

        For Each Factura As Factura In list

        Next

        For Each row As DataGridViewRow In dgv_facturas_pendientes.SelectedRows
            dgv_facturas_seleccionadas.Rows.Remove(row)
        Next

    End Sub
End Class