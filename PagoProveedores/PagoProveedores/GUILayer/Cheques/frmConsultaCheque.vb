Public Class frmConsultaCheque


    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub frmConsultaCheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_cheque_consulta.DataSource = DBHCheque.getCheques
    End Sub
End Class