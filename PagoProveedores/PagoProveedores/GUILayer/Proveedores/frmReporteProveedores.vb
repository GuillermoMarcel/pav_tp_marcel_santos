Imports System.Data.SqlClient
Public Class frmReporteProveedores

    Private Sub frmReporteProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RHProveedores.proveedoresConDeuda(Me.DataSet_Proveedores.Proveedores)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class