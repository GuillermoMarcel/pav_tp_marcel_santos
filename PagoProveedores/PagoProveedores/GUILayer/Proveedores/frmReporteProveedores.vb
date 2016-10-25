Imports System.Data.SqlClient
Public Class frmReporteProveedores

    Private Sub frmReporteProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RHProveedores.proveedoresConDeuda(Me.DataSet_Proveedores.Proveedores)
        ReportViewer1.RefreshReport()
    End Sub
End Class