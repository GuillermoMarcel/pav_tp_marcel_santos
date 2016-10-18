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

    Private Sub btn_cuenta_Click(sender As Object, e As EventArgs) Handles btn_cuenta.Click
        Dim f As New frmConsultarCuenta(dgv_titulares.CurrentRow.Cells.Item("id_titular").Value)
        f.ShowDialog()
    End Sub


    Private Sub dgv_titulares_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_titulares.SelectionChanged
        btn_cuenta.Enabled = True
    End Sub
End Class