Public Class frmNuevaFactura

    Private Sub frmNuevaFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_proveedor.DataSource = DBHProveedor.getProveedores
        cmb_proveedor.DisplayMember = "razon_social"
        cmb_proveedor.ValueMember = "id_proveedor"
        cmb_tipo.DataSource = DBHFactura.getTiposFactura
        cmb_tipo.DisplayMember = "tipo_fact"
        cmb_tipo.ValueMember = "tipo_fact"
        dtp_fecha.MaxDate = Now
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If Not validar() Then Return

        Dim monto As Decimal = Decimal.Parse(txt_monto.Text)
        Dim nro As Long = Long.Parse(txt_nro.Text)
        If Not confirmar(txt_nro.Text, monto) Then Return

        If DBHFactura.registrarFactura(
            cmb_proveedor.SelectedValue,
            cmb_tipo.SelectedValue,
            nro,
            monto,
            dtp_fecha.Value) Then

            MsgBox("Exito")
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub
    Private Function confirmar(nro As String, monto As Decimal) As Boolean
        Dim mensaje As String = "Desea confirmar la factura Nro: " + nro.ToString + vbCrLf + _
            "De monto: " + monto.ToString("C")
        Dim res As MsgBoxResult = MsgBox(mensaje, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question)
        Return (res = MsgBoxResult.Yes)
    End Function
    Public Function validar() As Boolean
        If cmb_proveedor.SelectedIndex = -1 Then
            MsgBox("Debe Seleccionar un proveedor")
            Return False
        End If
        If cmb_tipo.SelectedIndex = -1 Then
            MsgBox("Debe seleccionar un tipo")
            Return False
        End If
        Try
            Decimal.Parse(txt_monto.Text)
            Dim n As Long = Long.Parse(txt_nro.Text)
            If n.ToString.Length < 9 Then
                MsgBox("Numero de factura incorrecto")
            End If
            Return True
        Catch ex As Exception
            MsgBox("No se puede transformar")
            Return False
        End Try

    End Function

    Private Sub cancelar_btn_Click(sender As Object, e As EventArgs) Handles cancelar_btn.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class