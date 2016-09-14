Public Class frmProveedorConsulta

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        actualizar()
    End Sub

    Private Sub actualizar()
        Dim t As DataTable = DBHProveedor.getProveedores()
        Me.dgv_proveedores.DataSource = t
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        frmProveedorNuevo.ShowDialog()
        actualizar()
    End Sub

    Private Sub frmProveedorConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar()
    End Sub

    Private Sub btn_modify_Click(sender As Object, e As EventArgs) Handles btn_modify.Click
        Dim curid As Integer = dgv_proveedores.CurrentRow.Cells("id_proveedor").Value
        Dim f As New frmProveedorModificacion(DBHProveedor.modificarProveedor(curid))
        f.ShowDialog()
        actualizar()
    End Sub
End Class