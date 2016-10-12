Public Class frmTitularesConsulta

    Private Sub frmTitularesConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_titulares.DataSource = DBHTitular.getTitulares
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim id As String
        id = dgv_titulares.CurrentRow.Cells("id_titular").Value

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        frmTitularesNuevo.ShowDialog()
    End Sub
End Class