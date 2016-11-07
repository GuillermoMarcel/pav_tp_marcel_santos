Public Class frmReporteCheques

    Private Sub frmReporteCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        RHCheques.chequesEmitidos(Me.DataSet_Cheques.Cheques)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class