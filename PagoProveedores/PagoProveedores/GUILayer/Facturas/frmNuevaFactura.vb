Public Class frmNuevaFactura

    Private Sub frmNuevaFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_proveedor.DataSource = DBHProveedor.getProveedores
        cmb_proveedor.DisplayMember = "razon_social"
        cmb_proveedor.ValueMember = "id_proveedor"
        cmb_tipo.DataSource = DBHFactura.getTiposFactura
        cmb_tipo.DisplayMember = "tipo_fact"
        cmb_tipo.ValueMember = "tipo_fact"
        dtp_fecha.MaxDate = Now
        txt_montodec.MaxLength = 2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not validar() Then Return
        Dim n As Integer = Integer.Parse(txt_monto.Text)
        Dim d As Integer = Integer.Parse(txt_montodec.Text)
        Dim monto As Decimal = n + (d / 100)

    End Sub
    Public Function validar() As Boolean
        Try
            If txt_montodec.Text = "" Then txt_montodec.Text = "0"
            Dim n As Integer = Integer.Parse(txt_monto.Text)
            Dim d As Integer = Integer.Parse(txt_montodec.Text)

            Return True
        Catch ex As Exception
            MsgBox("No se puede transformar")
            Return False
        End Try

    End Function
End Class