Public Class frmNuevaCuenta

    Private Sub cargarCombo(cbo As ComboBox, surce As DataTable, value As String, display As String)
        cbo.DataSource = surce
        cbo.ValueMember = value
        cbo.DisplayMember = display
    End Sub


    Private Sub frmNuevaCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarCombo(cbo_banco, DBHBanco.getBancos, "nro_banco", "nombre")
        'Dim id_titular As Integer = frm
    End Sub


    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim l As Long
        If cbo_banco.SelectedIndex <> -1 And txt_nrocuenta.Text <> "" And Long.TryParse(txt_nrocuenta.Text, l) Then
            'DBHTitular.addCuenta(dgv
        End If
    End Sub
End Class