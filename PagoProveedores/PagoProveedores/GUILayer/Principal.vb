Public Class frm_principal

    Private Sub btn_proveedor_Click(sender As Object, e As EventArgs) Handles btn_proveedor.Click
        frmProveedorConsulta.Show()
    End Sub

    Private Sub btn_banco_Click(sender As Object, e As EventArgs) Handles btn_banco.Click
        frmConsultaBanco.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rs As String = "alguien sa",
            dir = "calle nro",
            cuit = 1234
        Dim t As New Telefono With {.Numero = "125 412", .Observacion = ""}
        Dim m As New Mail With {.Direccion = "asf@asdf", .Observacion = ""}
        Dim lt As New List(Of Telefono)
        lt.Add(t)
        Dim lm As New List(Of Mail)
        lm.Add(m)

        DBHProveedor.addProveedor(rs, cuit, dir, "", lt, lm)


    End Sub
End Class