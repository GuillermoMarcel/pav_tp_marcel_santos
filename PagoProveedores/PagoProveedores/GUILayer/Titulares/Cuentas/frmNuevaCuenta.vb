Public Class frmNuevaCuenta
    Private id As Integer

    Public Sub New(id_titular As Integer)
        InitializeComponent()
        Me.id = id_titular
    End Sub

    Private Sub cargarCombo(cbo As ComboBox, surce As DataTable, value As String, display As String)
        cbo.DataSource = surce
        cbo.ValueMember = value
        cbo.DisplayMember = display
    End Sub


    Private Sub frmNuevaCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cbo_banco, DBHBanco.getBancos, "nro_banco", "nombre")
    End Sub


    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If Not validar() Then Return

        Dim c As String = -1
        If Not cb_not_cbu.Checked Then c = txt_cbu.Text

        If Not _
            DBHTitular.addCuenta(id, cbo_banco.SelectedValue, Integer.Parse(txt_sucursal.Text), txt_nrocuenta.Text.Trim, c) _
            Then Return

        MsgBox("Exito")
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Function validar() As Boolean
        Dim mensaje As String = String.Empty
        If Not cb_not_cbu.Checked And Not txt_cbu.MaskFull Then
            mensaje = "Debe completar el CBU correctamente"
        End If
        If txt_sucursal.Text = String.Empty Then mensaje = "Debe ingresar Nro de Sucursal"
        If Not Integer.TryParse(txt_sucursal.Text, Nothing) Then mensaje = "El nro de sucursal debe ser numerico"
        If txt_nrocuenta.Text = String.Empty Then mensaje = "Debe ingresar el numero de cuenta"
        If cbo_banco.SelectedIndex = -1 Then mensaje = "Debe Seleccionar un Banco"
        If mensaje <> String.Empty Then
            MsgBox(mensaje)
            Return False
        End If
        Return True
    End Function

    Private Sub cb_not_cbu_CheckedChanged(sender As Object, e As EventArgs) Handles cb_not_cbu.CheckedChanged
        txt_cbu.Enabled = Not cb_not_cbu.Checked
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class