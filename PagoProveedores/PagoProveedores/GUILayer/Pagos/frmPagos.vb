Public Class frmPagos
    Dim chequesCartera As List(Of Cheque)
    Dim chequesSeleccionados As List(Of Cheque)

    Dim facturasPendiente As List(Of Factura)
    Dim facturasSeleccionadas As List(Of Factura)

    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_proveedor.DataSource = DBHProveedor.getProveedores
        cbo_proveedor.ValueMember = "id_proveedor"
        cbo_proveedor.DisplayMember = "razon_social"
        cbo_proveedor.SelectedIndex = 0
        chequesCartera = DBHCheque.getChequesCartera()
        llenarGridCheque(dgv_cheques_cartera, chequesCartera)
        actualizarlabels()
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

        facturasPendiente = Nothing
        facturasPendiente = DBHFactura.getFacturasImpagasProveedor(cbo_proveedor.SelectedValue)
        llenarGridFactura(dgv_facturas_pendientes, facturasPendiente)

    End Sub

    Private Sub llenarGridFactura(dgv As DataGridView, list As List(Of Factura))
        dgv_facturas_pendientes.Rows.Clear()
        dgv_facturas_seleccionadas.Rows.Clear()
        For Each f In list
            dgv.Rows.Add(New String() {f.Fecha.ToShortDateString, f.Tipo.ToString, f.NroFactura.ToString, f.Monto.ToString, f.Proveedor.ToString})
        Next
    End Sub

    Private Sub actualizarDGVCheques()
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
        Try
            actualizarDGVFacturas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_agregar_factura_Click(sender As Object, e As EventArgs) Handles btn_agregar_factura.Click
        For Each row As DataGridViewRow In dgv_facturas_pendientes.SelectedRows
            dgv_facturas_seleccionadas.Rows.Add(New String() {row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value})
        Next

        For Each row As DataGridViewRow In dgv_facturas_pendientes.SelectedRows
            dgv_facturas_pendientes.Rows.Remove(row)
        Next
        actualizarlabels()
    End Sub

    Private Sub btn_quitar_factura_Click(sender As Object, e As EventArgs) Handles btn_quitar_factura.Click
        For Each row As DataGridViewRow In dgv_facturas_seleccionadas.SelectedRows
            dgv_facturas_pendientes.Rows.Add(New String() {row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value})
        Next

        For Each row As DataGridViewRow In dgv_facturas_seleccionadas.SelectedRows
            dgv_facturas_seleccionadas.Rows.Remove(row)
        Next
        actualizarlabels()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_agregar_cheque_Click(sender As Object, e As EventArgs) Handles btn_agregar_cheque.Click
        For Each row As DataGridViewRow In dgv_cheques_cartera.SelectedRows
            dgv_cheques_seleccionados.Rows.Add(New String() {row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value})
        Next

        For Each row As DataGridViewRow In dgv_cheques_cartera.SelectedRows
            dgv_cheques_cartera.Rows.Remove(row)
        Next
        actualizarlabels()
    End Sub

    Private Sub btn_quitar_cheque_Click(sender As Object, e As EventArgs) Handles btn_quitar_cheque.Click
        For Each row As DataGridViewRow In dgv_cheques_seleccionados.SelectedRows
            dgv_cheques_cartera.Rows.Add(New String() {row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value})
        Next

        For Each row As DataGridViewRow In dgv_cheques_seleccionados.SelectedRows
            dgv_cheques_seleccionados.Rows.Remove(row)
        Next
        actualizarlabels()
    End Sub

    Private Sub actualizarlabels()
        Dim ac As Decimal = 0,
            af As Decimal = 0
        For Each r As DataGridViewRow In dgv_cheques_seleccionados.Rows
            ac += r.Cells(4).Value
        Next
        For Each r As DataGridViewRow In dgv_facturas_seleccionadas.Rows
            af += r.Cells(3).Value
        Next
        lbl_total_cheques.Text = ac.ToString("C")
        lbl_total_facturas.Text = af.ToString("C")
        If (af - ac) >= 0 Then txt_efectivo.Text = (af - ac) Else txt_efectivo.Text = 0
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If Not validar() Then Return
        If Not confirmar() Then Return

        If DBHFactura.confirmarPago(getCheques, getFacturas, Decimal.Parse(txt_efectivo.Text), txt_obs.Text, cbo_proveedor.SelectedValue) Then
            MsgBox("Exito")
            'Me.Close()
        End If
    End Sub

    Private Function confirmar() As Boolean
        Dim cf As Integer = 0,
            af As Decimal = 0,
            cc As Integer = 0,
            ac As Decimal = 0,
            ef As Decimal

        For Each r As DataGridViewRow In dgv_cheques_seleccionados.Rows
            cc += 1
            ac += r.Cells(4).Value
        Next
        For Each r As DataGridViewRow In dgv_facturas_seleccionadas.Rows
            cf += 1
            af += r.Cells(3).Value
        Next
        ef = Decimal.Parse(txt_efectivo.Text)
        Dim m As String = "¿Desea confirmar la siguiente operacion?" & vbCrLf
        m &= "Pago de " & cf & " facturas por el monto de " & af.ToString("C")
        m &= vbCrLf & "con " & cc & " cheques por monto de " & ac.ToString("C")
        m &= vbCrLf & "y efectivo de " & ef.ToString("C")
        m &= vbCrLf & "disminuyendo la cuenta corriente en " & (ac + ef).ToString("C")
        Dim res As MsgBoxResult = MsgBox(m, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2)
        Return res = MsgBoxResult.Yes
    End Function

    Private Function getFacturas() As List(Of Factura)
        Dim l As New List(Of Factura)
        Dim f As Factura
        For Each r As DataGridViewRow In dgv_facturas_seleccionadas.Rows
            f = New Factura()
            f.Tipo = r.Cells(1).Value
            f.NroFactura = r.Cells(2).Value
            f.Monto = r.Cells(3).Value
            f.Proveedor = r.Cells(4).Value
            l.Add(f)
        Next
        Return l
    End Function
    Private Function getCheques() As List(Of Cheque)
        Dim l As New List(Of Cheque)
        Dim c As Cheque
        For Each r As DataGridViewRow In dgv_cheques_seleccionados.Rows
            c = New Cheque
            c.Numero = r.Cells(1).Value
            c.NroCuenta = r.Cells(6).Value
            c.NroBanco = r.Cells(5).Value
            c.Monto = r.Cells(4).Value
            l.Add(c)
        Next
        Return l
    End Function


    Private Function validar() As Boolean
        Dim m As String = ""
        If Not Decimal.TryParse(txt_efectivo.Text, New Integer) Then m = "Efectivo debe ser numerico"
        If m <> "" Then
            MsgBox(m)
            Return False
        End If
        Return True
    End Function
End Class