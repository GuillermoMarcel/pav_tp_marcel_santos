Public Class frmTitularesNuevo

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Dim cuit As Long
        If Not txt_cuit.MaskFull Then
            If MsgBox("CUIT NO VALIDO ¿Quiere agregar CUIT vacio?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Return
            End If
            cuit = Nothing
        Else
            cuit = Long.Parse(txt_cuit.Text)
        End If
        ' If Not txt_cuit.MaskFull Then
        'MsgBox("CUIT INVALIDO, DEBE SER CON FORMATO 12_12345678_0")
        '  Return
        ' End If
        ' Dim cuit As Long
        '  cuit = Long.Parse(txt_cuit.Text)
        DBHTitular.addTitular(txt_nombre.Text, txt_apellido.Text, cuit, txt_direccion.Text)
        Me.Close()

    End Sub

    Private Sub frmTitularesNuevo_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_id.Text = DBHTitular.getMaxID + 1
    End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class