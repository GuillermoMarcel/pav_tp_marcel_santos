Imports Microsoft.Reporting.WinForms

Public Class frmReporteFacturas

    Private Sub frmReporteFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As New ReportParameter("fecha_desde", Now())
        Dim r2 As New ReportParameter("fecha_hasta", Now())
        Me.ReportViewer1.LocalReport.SetParameters({r, r2})
        RHProveedores.facturas(Me.DataSet_Proveedores.Facturas)
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        
        ReportViewer1.RefreshReport()
    End Sub
End Class