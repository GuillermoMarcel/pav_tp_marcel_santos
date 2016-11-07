Imports Microsoft.Reporting.WinForms
Public Class frmReporteCheques

    Private Sub frmReporteCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_cuenta.DataSource = DBHTitular.getCuentasFavoritas
        'cbo_cuenta.
        ''Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        If cb_filtro_fecha.Checked Then
            RHCheques.chequesEmitidos(Me.DataSet_Cheques.Cheques, cbo_cuenta.SelectedItem, {dtp_desde.Value, dtp_hasta.Value})
        Else
            RHCheques.chequesEmitidos(Me.DataSet_Cheques.Cheques, cbo_cuenta.SelectedItem)
        End If


        prepararReporte()
    End Sub
    Public Sub prepararReporte()
        Dim r, r2, r3 As ReportParameter
        If cb_filtro_fecha.Checked Then
            r = New ReportParameter("fecha_desde", dtp_desde.Value)
            r2 = New ReportParameter("fecha_hasta", dtp_hasta.Value)
            r3 = New ReportParameter("filtro_fechas", True)
            Me.ReportViewer1.LocalReport.SetParameters({r, r2, r3})
        Else
            r3 = New ReportParameter("filtro_fechas", False)
            Me.ReportViewer1.LocalReport.SetParameters({r3})
        End If
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub cb_filtro_fecha_CheckedChanged(sender As Object, e As EventArgs) Handles cb_filtro_fecha.CheckedChanged
        dtp_desde.Enabled = cb_filtro_fecha.Checked
        dtp_hasta.Enabled = cb_filtro_fecha.Checked
        dtp_desde.Value = Now
        dtp_hasta.Value = Now.AddDays(1)
    End Sub

    Private Sub dtp_desde_ValueChanged(sender As Object, e As EventArgs) Handles dtp_desde.ValueChanged
        dtp_hasta.MinDate = dtp_desde.Value
    End Sub
End Class