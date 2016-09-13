Public Class frmProveedorModificacion
    Private p As Proveedor
    Public Sub New(proveedor As Proveedor)
        InitializeComponent()
        p = proveedor
    End Sub
    Private Sub frmProveedorModificacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_cuit.Text = p.Cuit
        txt_direccion.Text = p.Direccion
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
End Class