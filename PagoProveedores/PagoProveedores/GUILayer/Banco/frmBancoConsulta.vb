Public Class frmBancoConsulta

    Private Sub ConsultaBancoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar()
        dgv_grid.Columns("nombre").Name = "Nomb"
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Dim f As New frmBancoModif
        If f.ShowDialog() <> Windows.Forms.DialogResult.OK Then Return
        If DBHBanco.insertarBanco(f.txt_nro.Text, f.txt_banco.Text) Then
            MsgBox("Exito")
        End If
        actualizar()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        actualizar()
    End Sub
    Private Sub actualizar()
        Dim t As DataTable = DBHBanco.getBancos
        Me.dgv_grid.DataSource = t
    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim id As Integer = dgv_grid.CurrentRow.Cells("nro_banco").Value
        If DBHBanco.borrarBanco(id) Then
            MsgBox("Exito")
            actualizar()
        End If
    End Sub

    Private Sub btn_modify_Click(sender As Object, e As EventArgs) Handles btn_modify.Click
        Dim f As New frmBancoModif
        Dim curid As Integer = dgv_grid.CurrentRow.Cells("nro_banco").Value
        f.txt_banco.Text = dgv_grid.CurrentRow.Cells("nombre").Value
        f.txt_nro.Text = dgv_grid.CurrentRow.Cells("nro_banco").Value

        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            If DBHBanco.modificarBanco(curid, f.txt_nro.Text, f.txt_banco.Text) Then
                MsgBox("Exito")
            End If
        End If
        actualizar()
    End Sub
End Class