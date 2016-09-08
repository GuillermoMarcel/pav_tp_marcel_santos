Public Class frmProveedorNuevo
    Private mails As List(Of Mail)
    Private telefonos As List(Of Telefono)

    Private Sub frmProveedorNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mails = New List(Of Mail)
        telefonos = New List(Of Telefono)

        Dim bs1 As New BindingSource(mails, "Direccion")
        lst_mail.DataSource = bs1


        Dim bs2 As New BindingSource
        bs2.DataSource = telefonos
        lst_telefono.DataSource = bs2
        lst_telefono.DisplayMember = "Numero"

    End Sub

    Private Sub btn_telefono_Click(sender As Object, e As EventArgs) Handles btn_agregar_telefono.Click
        Dim tel As New Telefono
        tel.Numero = InputBox("Ingrese teléfono")
        tel.Observacion = InputBox("Ingrese observación")
        lst_telefono.DataSource = Nothing
        telefonos.Add(tel)
        lst_telefono.Refresh()
        lst_telefono.DataSource = telefonos
    End Sub

    Private Sub btn_mail_Click(sender As Object, e As EventArgs) Handles btn_agregar_mail.Click
        Dim mail As New Mail
        mail.Direccion = InputBox("Ingrese Mail")
        mail.Observacion = InputBox("Ingrese observación")
        lst_mail.DataSource = Nothing
        mails.Add(mail)
        lst_mail.DataSource = mails
    End Sub

    Private Sub btn_borrar_telefono_Click(sender As Object, e As EventArgs) Handles btn_borrar_telefono.Click
        Dim tel As Telefono = lst_telefono.SelectedItem
        lst_telefono.DataSource = Nothing
        telefonos.Remove(tel)
        lst_telefono.DataSource = telefonos
    End Sub

    Private Sub btn_borrar_mail_Click(sender As Object, e As EventArgs) Handles btn_borrar_mail.Click
        Dim mail As Mail = lst_mail.SelectedItem
        'lst_mail.DataSource = Nothing
        mails.Remove(mail)
        'lst_mail.DataSource = mails
    End Sub

    Private Sub btn_accept_Click(sender As Object, e As EventArgs) Handles btn_accept.Click
        Dim b As Boolean = DBHProveedor.addProveedor(txt_razon_social.Text, 1234,
                                  txt_direccion.Text, txt_observacion.Text, telefonos, mails)

        If b Then
            MsgBox("Se ha agregado un nuevo PROVEEDOR")
        Else
            MsgBox(DBConn.lastex.Message)
        End If
    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class