Public Class frmNuevoCheque
    Private titulares As List(Of Titular)

    Private Sub frmNuevoCheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_bancos.DisplayMember = "nombre"
        cb_bancos.ValueMember = "nro_banco"
        cb_bancos.DataSource = DBHBanco.getBancos

    End Sub


    Private Sub cb_bancos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_bancos.SelectedIndexChanged
        If cb_bancos.SelectedIndex = -1 Then Return
        titulares = DBHTitular.getTitulareDeBanco(cb_bancos.SelectedValue)

        If titulares.Count = 0 Then
            MsgBox("Ningun titular registrado en ese banco")
            cb_cuenta.Enabled = False
            cb_titular.Enabled = False
            cb_titular.DataSource = {"(ninguno)"}
            cb_cuenta.DataSource = {"(ninguno)"}
        Else
            cb_cuenta.Enabled = True
            cb_titular.Enabled = True
            cb_titular.DataSource = titulares
        End If

        'cb_titular.DisplayMember = "nombreCompleto" '
    End Sub

    Private Sub cb_titular_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_titular.SelectedIndexChanged
        If cb_titular.SelectedIndex = -1 Then Return
        If titulares.Count = 0 Then Return
        Dim t As Titular = cb_titular.SelectedItem
        cb_cuenta.DataSource = t.cuentas
        cb_cuenta.DisplayMember = "NroCuenta"

    End Sub

    
End Class