Imports Microsoft.Reporting.WinForms

Public Class frmReporteFacturas

    Private Sub frmReporteFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_desde.Value = Now.AddDays(-1)
        dtp_hasta.Value = Now()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        Dim r, r2, r3 As ReportParameter
        If cb_filtro_fecha.Checked Then
            r = New ReportParameter("fecha_desde", dtp_desde.Value)
            r2 = New ReportParameter("fecha_hasta", dtp_hasta.Value)
            r3 = New ReportParameter("filtro_fecha", True)
            Me.ReportViewer1.LocalReport.SetParameters({r, r2, r3})
        Else
            r3 = New ReportParameter("filtro_fecha", False)
            Me.ReportViewer1.LocalReport.SetParameters({r3})
        End If
        Dim p As Integer = -1
        If cb_filtro_proveedor.Checked Then _
            p = cbo_proveedor.SelectedValue

        Dim f As Boolean = cb_filtro_fecha.Checked

        RHProveedores.facturas(Me.DataSet_Proveedores.Facturas, p, dtp_desde.Value, dtp_hasta.Value, f)

        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
        ReportViewer1.RefreshReport()

    End Sub


    Private Sub cb_filtro_fecha_CheckedChanged(sender As Object, e As EventArgs) Handles cb_filtro_fecha.CheckedChanged
        dtp_hasta.Enabled = cb_filtro_fecha.Checked
        dtp_desde.Enabled = cb_filtro_fecha.Checked
    End Sub

    Private Sub cb_filtro_proveedor_CheckedChanged(sender As Object, e As EventArgs) Handles cb_filtro_proveedor.CheckedChanged
        cbo_proveedor.Enabled = cb_filtro_proveedor.Checked
        If cbo_proveedor.Enabled And flag Then
            cbo_proveedor.DataSource = DBHProveedor.getProveedores
            cbo_proveedor.ValueMember = "id_proveedor"
            cbo_proveedor.DisplayMember = "razon_social"
        End If
        flag = False
    End Sub

    Private Sub dtp_desde_ValueChanged(sender As Object, e As EventArgs) Handles dtp_desde.ValueChanged
        dtp_hasta.MinDate = dtp_desde.Value
    End Sub

    Dim flag As Boolean = True

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class