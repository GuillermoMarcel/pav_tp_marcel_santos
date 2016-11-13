Public Class frm_principal

    Private Sub btn_proveedor_Click(sender As Object, e As EventArgs) Handles btn_proveedor.Click
        frmProveedorConsulta.Show()
    End Sub

    Private Sub btn_banco_Click(sender As Object, e As EventArgs) Handles btn_banco.Click
        frmBancoConsulta.Show()
    End Sub


    Private Sub btn_titulares_Click(sender As Object, e As EventArgs) Handles btn_titulares.Click
        Dim f As New frmTitularesConsulta
        f.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New frmNuevaFactura
        f.ShowDialog()
    End Sub


    Private Sub frm_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mensaje para avisar que hay cambios en la base de datos.
        'Cuando actualices la Base de datos simplemente comenta esta linea
        'MsgBox("Cambio importante en la estructura de la DB" & vbCrLf & _
        '       "Desactivar este mensaje comentando la linea")
    End Sub

    Private Sub btn_cheques_Click(sender As Object, e As EventArgs) Handles btn_nuevo_cheque.Click
        Dim f As New frmNuevoCheque
        While f.ShowDialog() = Windows.Forms.DialogResult.Retry
            f = New frmNuevoCheque
        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_reporte_proveedor.Click
        Dim f As New frmReporteProveedores
        f.ShowDialog()
    End Sub

    Private Sub btn_pagar_Click(sender As Object, e As EventArgs) Handles btn_pagar.Click
        Dim d As New frmPagos
        d.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_reporte_factura.Click
        Dim f As New frmReporteFacturas
        f.ShowDialog()
    End Sub

    Private Sub btn_reporte_cheques_Click(sender As Object, e As EventArgs) Handles btn_reporte_cheques.Click
        Dim f As New frmReporteCheques
        f.ShowDialog()
    End Sub

    Private Sub btn_cheques_consulta_Click(sender As Object, e As EventArgs) Handles btn_cheques.Click
        Dim f As New frmConsultaCheque
        f.ShowDialog()
    End Sub

    Private Sub btn_consulta_pagos_Click(sender As Object, e As EventArgs) Handles btn_consulta_pagos.Click
        Dim f As New frmPagosConsulta
        f.Show()
    End Sub
End Class