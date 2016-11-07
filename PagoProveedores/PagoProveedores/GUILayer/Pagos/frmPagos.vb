Public Class frmPagos
    Dim chequesCartera As List(Of Cheque)
    Dim chequesSeleccionados As List(Of Cheque)

    Dim facturasPendiente As List(Of Factura)
    Dim facturasSeleccionadas As List(Of Factura)

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_proveedor.DataSource = DBHProveedor.getProveedores
        cbo_proveedor.ValueMember = "id_proveedor"
        cbo_proveedor.DisplayMember = "razon_social"
        cbo_proveedor.SelectedIndex = 1
        chequesCartera = DBHCheque.getChequesCartera()
        actualizarDGVCheques(chequesCartera)
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
        Dim c As Integer = Integer.Parse(cbo_proveedor.SelectedValue.ToString)
        facturasPendiente = Nothing
        facturasPendiente = DBHFactura.getFacturasImpagasProveedor(c)
        llenarGridFactura(dgv_facturas_pendientes, facturasPendiente)

    End Sub

    Private Sub llenarGridFactura(dgv As DataGridView, list As List(Of Factura))
        For Each f In list
            dgv.Rows.Add(New String() {f.Fecha.ToShortDateString, f.Tipo.ToString, f.NroFactura.ToString, f.Monto.ToString, f.Proveedor.ToString})
        Next
    End Sub

    Private Sub actualizarDGVCheques(list As List(Of Cheque))
        dgv_cheques_cartera.Rows.Clear()
        dgv_cheques_seleccionados.Rows.Clear()
        dgv_cheques_cartera.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub llenarGridCheque(dgv As DataGridView, list As List(Of Cheque))
        For Each c In list
            'Dim str As String() = {c.FechaVencimiento.ToShortDateString, c.Numero.ToString, c.Titular.ToString, c.Banco.ToString, c.Monto.ToString, c.NroBanco.ToString, c.NroCuenta.ToString}
            dgv.Rows.Add(New String() {c.FechaVencimiento.ToShortDateString, c.Numero.ToString, c.Titular.ToString, c.Banco.ToString, c.Monto.ToString, c.NroBanco.ToString, c.NroCuenta.ToString})
        Next
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
    End Sub
End Class