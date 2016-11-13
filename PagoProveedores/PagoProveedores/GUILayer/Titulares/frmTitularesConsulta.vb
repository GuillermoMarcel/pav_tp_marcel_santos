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
    ''' <summary>
    ''' Esta funcion devuelve simplemente el Id del titular seleccionado
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getCurrentId() As Integer
        Return dgv_titulares.CurrentRow.Cells("Id").Value
    End Function

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim id As String
        id = getCurrentId()
        If MsgBox("¿Realmente desea eliminar al Titular " & dgv_titulares.CurrentRow.Cells("Nombre").Value & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If DBHTitular.deleteTitular(id) Then
                MsgBox("Se ha eliminado el Titular con exito")
            End If
        End If
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
        Dim f As New frmConsultarCuenta(getCurrentId())
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
        Dim f As New frmTitularesModificacion(getCurrentId())
        'Modifico aca para que se pueda actualizar luego de agregar nuevo.
        If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
            actualizar()
        End If
    End Sub
End Class