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
        Dim observacion As String = InputBox("Ingrese observación")


    End Sub

    Private Sub lst_telefono_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lst_telefono.MouseDoubleClick
        Dim t As Telefono = lst_telefono.SelectedItem
        MsgBox(t.Observacion)
    End Sub
End Class