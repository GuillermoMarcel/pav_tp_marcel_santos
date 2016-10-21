Public Class frmProveedorNuevo
    Private mails As List(Of Mail)
    Private telefonos As List(Of Telefono)

    Private Sub frmProveedorNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mails = New List(Of Mail)
        telefonos = New List(Of Telefono)

        Dim bs1 As New BindingSource(mails, "Mail")
        lst_mail.DataSource = bs1


        Dim bs2 As New BindingSource
        bs2.DataSource = telefonos
        lst_telefono.DataSource = bs2
        lst_telefono.DisplayMember = "Telefono"

    End Sub

    Private Sub btn_telefono_Click(sender As Object, e As EventArgs) Handles btn_agregar_telefono.Click
        Dim tel As New Telefono
        tel.Telefono = InputBox("Ingrese teléfono")
        tel.Observacion = InputBox("Ingrese observación")
        lst_telefono.DataSource = Nothing
        telefonos.Add(tel)
        lst_telefono.Refresh()
        lst_telefono.DataSource = telefonos
    End Sub

    Private Sub btn_mail_Click(sender As Object, e As EventArgs) Handles btn_agregar_mail.Click
        Dim mail As New Mail
        mail.Mail = InputBox("Ingrese Mail")
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
        If txt_razon_social Is Nothing Then
            MsgBox("La razón social no puede ser vacía", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim cuit As Long
        If Not txt_cuit.MaskFull Then
            If MsgBox("CUIT NO VALIDO ¿Quiere agregar CUIT vacio?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Return
            End If
            cuit = Nothing
        Else
            cuit = Long.Parse(txt_cuit.Text)
        End If
        Dim altura As Integer
        If Not Integer.TryParse(txt_altura.Text, altura) Then
            MsgBox("La altura debe ser numerica")
            Return
        End If
        Dim d As New Direccion(txt_direccion.Text, altura)
        Dim b As Boolean = DBHProveedor.addProveedor(txt_razon_social.Text, cuit,
                                  d, txt_observacion.Text, telefonos, mails)

        If b Then
            MsgBox("Se ha agregado un nuevo PROVEEDOR")
            Me.Close()
        Else
            MsgBox(DBConn.lastex.Message)
        End If

    End Sub

    Private Sub lst_telefono_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lst_telefono.MouseDoubleClick
        Dim t As Telefono = lst_telefono.SelectedItem
        MsgBox(t.Observacion)
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub lst_mail_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lst_mail.MouseDoubleClick
        Dim m As Mail = lst_mail.SelectedItem
        MsgBox(m.Observacion)
    End Sub

    Private Sub btn_edit_telefono_Click(sender As Object, e As EventArgs) Handles btn_edit_telefono.Click
        Dim t As Telefono = lst_telefono.SelectedItem
        If t Is Nothing Then
            MsgBox("No hay ninguno seleccionado")
            Return
        End If
        lst_telefono.DataSource = Nothing
        t.Telefono = InputBox("Ingrese un numero", DefaultResponse:=t.Telefono)
        lst_telefono.DataSource = telefonos
    End Sub

    Private Sub btn_edit_mail_Click(sender As Object, e As EventArgs) Handles btn_edit_mail.Click
        Dim m As Mail = lst_mail.SelectedItem
        If m Is Nothing Then
            MsgBox("No hay ninguno seleccionado")
            Return
        End If
        lst_mail.DataSource = Nothing
        m.Mail = InputBox("Ingrese un mail", DefaultResponse:=m.Mail)
        lst_mail.DataSource = telefonos
    End Sub
End Class