Public Class frmProveedorModificacion
    Private p As Proveedor
    Public Sub New(proveedor As Proveedor)
        InitializeComponent()
        p = proveedor
    End Sub
    Private Sub frmProveedorModificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_cuit.Text = p.Cuit
        txt_altura.Text = p.Direccion.Altura
        txt_direccion.Text = p.Direccion.Calle
        txt_razon_social.Text = p.RazonSocial
        txt_observacion.Text = p.Observacion
        lst_mail.DataSource = p.Mails
        lst_telefono.DataSource = p.Telefonos
    End Sub

    Private Sub btn_agregar_telefono_Click(sender As Object, e As EventArgs) Handles btn_agregar_telefono.Click
        Dim numero As String = InputBox("Ingrese número")
        If numero = String.Empty Then
            MsgBox("Error, número vacío")
            Return
        End If
        Dim observacion As String = InputBox("Ingrese observación")
        If MsgBox("¿Desea agregar un nuevo teléfono?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim telefonos As List(Of Telefono) = DBHProveedor.agregarTelefonoProveedor(p.Id, numero, observacion)
            lst_telefono.DataSource = telefonos
        End If
    End Sub

    Private Sub lst_telefono_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lst_telefono.MouseDoubleClick
        Dim t As Telefono = lst_telefono.SelectedItem
        MsgBox(t.Observacion)
    End Sub

    Private Sub lst_mail_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lst_mail.MouseDoubleClick
        Dim m As Mail = lst_mail.SelectedItem
        MsgBox(m.Observacion)
    End Sub

    Private Sub btn_agregar_mail_Click(sender As Object, e As EventArgs) Handles btn_agregar_mail.Click
        Dim mail As String = InputBox("Ingrese mail")
        If mail = String.Empty Then
            MsgBox("Error, mail vacío")
            Return
        End If
        Dim observacion As String = InputBox("Ingrese observación")
        If MsgBox("¿Desea agregar un nuevo mail?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Return
        Dim mails As List(Of Mail) = DBHProveedor.agregarMailProveedor(p.Id, mail, observacion)
        lst_mail.DataSource = mails
    End Sub

    Private Sub btn_edit_telefono_Click(sender As Object, e As EventArgs) Handles btn_edit_telefono.Click
        If lst_telefono.SelectedItem Is Nothing Then
            MsgBox("No hay teléfono seleccionado.")
            Return
        End If
        Dim telefono As Telefono = lst_telefono.SelectedItem
        Dim ntelefono As String = InputBox("Ingrese teléfono", DefaultResponse:=telefono.Telefono)
        If ntelefono = String.Empty Then
            MsgBox("Debe ingresar un teléfono")
            Return
        End If
        Dim nobservacion As String = InputBox("Ingrese observación", DefaultResponse:=telefono.Observacion)
        Dim r As MsgBoxResult =
            MsgBox("¿Desea confirmar modificacion?", MsgBoxStyle.YesNo)
        If r = MsgBoxResult.Yes Then
            lst_telefono.DataSource = DBHProveedor.modificarTelefonoProveedor(p.Id, telefono.Telefono, ntelefono, nobservacion)
        End If
    End Sub

    Private Sub btn_edit_mail_Click(sender As Object, e As EventArgs) Handles btn_edit_mail.Click
        If lst_mail.SelectedItem Is Nothing Then
            MsgBox("No hay mail seleccionado.")
            Return
        End If
        Dim mail As Mail = lst_mail.SelectedItem
        Dim nmail As String = InputBox("Ingrese mail", DefaultResponse:=mail.Mail)
        If nmail = String.Empty Then
            MsgBox("Debe ingresar un mail")
            Return
        End If
        Dim nobservacion As String = InputBox("Ingrese observación", DefaultResponse:=mail.Observacion)
        Dim r As MsgBoxResult =
            MsgBox("¿Desea confirmar modificacion?", MsgBoxStyle.YesNo)
        If r = MsgBoxResult.Yes Then
            lst_mail.DataSource = DBHProveedor.modificarMailProveedor(p.Id, mail.Mail, nmail, nobservacion)
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
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
        If DBHProveedor.confirmarModificacionProveedor(p.Id, txt_razon_social.Text, cuit, d, txt_observacion.Text) Then
            MsgBox("ÉXITO")
            Me.Close()
        End If

    End Sub

    Private Sub btn_borrar_telefono_Click(sender As Object, e As EventArgs) Handles btn_borrar_telefono.Click
        If lst_telefono.SelectedItem Is Nothing Then
            MsgBox("No hay teléfono seleccionado")
            Return
        End If
        Dim telefono As Telefono = lst_telefono.SelectedItem
        Dim r As New MsgBoxResult
        r = MsgBox("¿Desea eliminar este teléfono?", MsgBoxStyle.YesNo)
        If r = MsgBoxResult.No Then Return
        lst_telefono.DataSource = DBHProveedor.eliminarTelefonoProveedor(p.Id, telefono.Telefono)
    End Sub

    Private Sub btn_borrar_mail_Click(sender As Object, e As EventArgs) Handles btn_borrar_mail.Click
        If lst_mail.SelectedItem Is Nothing Then
            MsgBox("No hay mail seleccionado")
            Return
        End If
        Dim mail As Mail = lst_mail.SelectedItem
        Dim r As New MsgBoxResult
        r = MsgBox("¿Desea eliminar este mail?", MsgBoxStyle.YesNo)
        If r = MsgBoxResult.No Then Return
        lst_mail.DataSource = DBHProveedor.eliminarMailProveedor(p.Id, mail.Mail)
    End Sub


End Class