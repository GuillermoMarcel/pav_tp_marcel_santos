Public Class frm_principal

    Private Sub btn_proveedor_Click(sender As Object, e As EventArgs) Handles btn_proveedor.Click
        frmProveedorConsulta.Show()
    End Sub

    Private Sub btn_banco_Click(sender As Object, e As EventArgs) Handles btn_banco.Click
        frmConsultaBanco.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmds As String() = {
            "INSERT INTO Proveedores (razon_social) VALUES('aasd')",
            "DECLARE @PID INT = @@IDENTITY",
            "INSERT INTO Proveedor_Mails (id_proveedor, mail) VALUES (@PID, 'asdf@qq.com')",
            "INSERT INTO Proveedor_Mails (id_proveedor, mail) VALUES (@PID, '456@qq.com')"
        }
        If DBConn.executeTransaction(cmds) Then
            MsgBox("exito")
        Else
            MsgBox(DBConn.lastex.Message)
        End If

    End Sub
End Class