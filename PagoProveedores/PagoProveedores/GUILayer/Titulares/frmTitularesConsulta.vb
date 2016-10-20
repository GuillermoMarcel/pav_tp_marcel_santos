Public Class frmTitularesConsulta

    Private Sub frmTitularesConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar()
    End Sub

    ''' <summary>
    ''' Este metodo para poder actualizar la tabla
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub actualizar()
        dgv_titulares.DataSource = DBHTitular.getTitulares
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim id As String
        id = dgv_titulares.CurrentRow.Cells("id_titular").Value

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        'Para que no queden rastros de una ventana vieja.
        Dim f As New frmTitularesNuevo
        'Modifico aca para que se pueda actualizar luego de agregar nuevo.
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            actualizar()
        End If
    End Sub

    Private Sub btn_cuenta_Click(sender As Object, e As EventArgs) Handles btn_cuenta.Click
        Dim f As New frmConsultarCuenta(dgv_titulares.CurrentRow.Cells.Item("id_titular").Value)
        f.ShowDialog()
    End Sub


    Private Sub dgv_titulares_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_titulares.SelectionChanged
        btn_cuenta.Enabled = True
        btn_modify.Enabled = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        actualizar()
    End Sub

    Private Sub btn_modify_Click(sender As Object, e As EventArgs) Handles btn_modify.Click
        Dim f As New frmTitularesModificacion(dgv_titulares.CurrentRow.Cells.Item("id_titular").Value)
        'Modifico aca para que se pueda actualizar luego de agregar nuevo.
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            actualizar()
        End If
    End Sub
End Class