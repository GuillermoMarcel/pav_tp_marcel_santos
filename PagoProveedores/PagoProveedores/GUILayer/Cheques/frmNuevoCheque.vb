Public Class frmNuevoCheque
    Private titulares As List(Of Titular)
    Private cuentaSeleccionada As Cuenta

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

    
    Private Sub btn_accept_Click(sender As Object, e As EventArgs) Handles btn_accept.Click
        If Not validar() Then Return
        Dim n As Integer = Integer.Parse(txt_nro.Text)
        Dim d As Decimal = Decimal.Parse(txt_monto.Text)
        Dim s As String = "Desea confirmar el cheque de " & d.ToString("C")
        If MsgBox(s, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim b As Boolean = DBHCheque.addCheque(n,
                                                   d,
                                                   dtp_emision.Value,
                                                   dtp_vencimiento.Value,
                                                   cb_cruzado.Checked,
                                                   txt_observaciones.Text,
                                                   cuentaSeleccionada)

            If b Then
                Me.Close()
                s = "Exito" & vbCrLf & "¿Desea agregar otro?"

                If MsgBox(s, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
                    Me.DialogResult = Windows.Forms.DialogResult.Retry
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If

            End If

        End If

    End Sub


    Private Function validarCuenta() As Boolean
        ' If cb_bancos.SelectedIndex = -1 Then Return False
        ' If cb_cuenta.SelectedIndex = -1 Then Return False
        ' If cb_titular.SelectedIndex = -1 Then Return False
        If TypeOf cb_cuenta.SelectedItem Is Cuenta And TypeOf cb_titular.SelectedItem Is Titular And cb_bancos.SelectedIndex <> -1 Then
            cuentaSeleccionada = cb_cuenta.SelectedItem
            Return True
        End If

        MsgBox("Debe seleccionar una cuenta valida", MsgBoxStyle.Critical)
        Return False
    End Function

    Private Function validar() As Boolean
        Dim d As Decimal
        Dim n As Integer
        Dim mensaje As String = String.Empty
        If Not Decimal.TryParse(txt_monto.Text, d) Then mensaje &= "El monto debe ser numerico"
        If d <= 0 Then mensaje &= "El monto debe ser positivo"
        If Not Integer.TryParse(txt_nro.Text, n) Then _
            mensaje &= "El numero de cheque tiene que ser numerico"

        If n.ToString.Length > 8 Then _
            mensaje &= "El numero de cheque no puede tener mas de 8 digitos"

        If mensaje = String.Empty Then
            Return True
        End If

        MsgBox(mensaje)
        Return False
    End Function

    Dim flag As Boolean = False
    Private Sub btn_confirm_cuenta_Click(sender As Object, e As EventArgs) Handles btn_confirm_cuenta.Click
        If validarCuenta() Then
            gp_cheque.Enabled = True
            btn_select_cuenta.Enabled = True
            gp_cuenta.Enabled = False
            If flag = False Then
                dtp_emision.Value = Now
                dtp_vencimiento.Value = Now.AddDays(1)
                flag = True
            End If
        End If
        'For Each c As Control In GroupBox2.Controls
        'c.Enabled = True
        ' Next
        ' End If
    End Sub

    Private Sub btn_select_cuenta_Click(sender As Object, e As EventArgs) Handles btn_select_cuenta.Click
        gp_cuenta.Enabled = True
        gp_cheque.Enabled = False
        cuentaSeleccionada = Nothing
    End Sub

    Private Sub dtp_emision_ValueChanged(sender As Object, e As EventArgs) Handles dtp_emision.ValueChanged
        dtp_vencimiento.MinDate = DirectCast(dtp_emision.Value, Date).AddDays(1)
        dtp_vencimiento.MaxDate = DirectCast(dtp_emision.Value, Date).AddDays(365)
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btn_new_titular_Click(sender As Object, e As EventArgs) Handles btn_new_titular.Click
        Dim f As New frmTitularesNuevo
        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim t As Titular = f.titular

        End If
    End Sub
End Class