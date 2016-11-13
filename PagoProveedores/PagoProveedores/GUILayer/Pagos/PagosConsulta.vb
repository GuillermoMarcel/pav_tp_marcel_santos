Public Class frmPagosConsulta

    Private Sub PagosConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarDGV()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        actualizarDGV()
    End Sub

    Private Sub actualizarDGV()
        dgv_pagos.DataSource = DBHProveedor.getPagos()
    End Sub
End Class