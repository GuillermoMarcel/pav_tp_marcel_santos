<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoCheque
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_bancos = New System.Windows.Forms.ComboBox()
        Me.gp_cuenta = New System.Windows.Forms.GroupBox()
        Me.btn_new_cuenta = New System.Windows.Forms.Button()
        Me.btn_new_titular = New System.Windows.Forms.Button()
        Me.btn_confirm_cuenta = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_cuenta = New System.Windows.Forms.ComboBox()
        Me.cb_titular = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_nro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.dtp_emision = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtp_vencimiento = New System.Windows.Forms.DateTimePicker()
        Me.cb_cruzado = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.btn_accept = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.gp_cheque = New System.Windows.Forms.GroupBox()
        Me.btn_select_cuenta = New System.Windows.Forms.Button()
        Me.gp_cuenta.SuspendLayout()
        Me.gp_cheque.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nuevo Cheque"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seleccione el banco"
        '
        'cb_bancos
        '
        Me.cb_bancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_bancos.FormattingEnabled = True
        Me.cb_bancos.Location = New System.Drawing.Point(114, 19)
        Me.cb_bancos.Name = "cb_bancos"
        Me.cb_bancos.Size = New System.Drawing.Size(171, 21)
        Me.cb_bancos.TabIndex = 0
        '
        'gp_cuenta
        '
        Me.gp_cuenta.Controls.Add(Me.btn_new_cuenta)
        Me.gp_cuenta.Controls.Add(Me.btn_new_titular)
        Me.gp_cuenta.Controls.Add(Me.btn_confirm_cuenta)
        Me.gp_cuenta.Controls.Add(Me.Label4)
        Me.gp_cuenta.Controls.Add(Me.Label3)
        Me.gp_cuenta.Controls.Add(Me.Label2)
        Me.gp_cuenta.Controls.Add(Me.cb_cuenta)
        Me.gp_cuenta.Controls.Add(Me.cb_titular)
        Me.gp_cuenta.Controls.Add(Me.cb_bancos)
        Me.gp_cuenta.Location = New System.Drawing.Point(12, 72)
        Me.gp_cuenta.Name = "gp_cuenta"
        Me.gp_cuenta.Size = New System.Drawing.Size(442, 136)
        Me.gp_cuenta.TabIndex = 0
        Me.gp_cuenta.TabStop = False
        Me.gp_cuenta.Text = "Seleccion de cuenta"
        '
        'btn_new_cuenta
        '
        Me.btn_new_cuenta.Location = New System.Drawing.Point(291, 71)
        Me.btn_new_cuenta.Name = "btn_new_cuenta"
        Me.btn_new_cuenta.Size = New System.Drawing.Size(145, 23)
        Me.btn_new_cuenta.TabIndex = 4
        Me.btn_new_cuenta.Text = "Registrar Nueva Cuenta"
        Me.btn_new_cuenta.UseVisualStyleBackColor = True
        '
        'btn_new_titular
        '
        Me.btn_new_titular.Location = New System.Drawing.Point(291, 44)
        Me.btn_new_titular.Name = "btn_new_titular"
        Me.btn_new_titular.Size = New System.Drawing.Size(145, 23)
        Me.btn_new_titular.TabIndex = 2
        Me.btn_new_titular.Text = "Registrar Nuevo Titular"
        Me.btn_new_titular.UseVisualStyleBackColor = True
        '
        'btn_confirm_cuenta
        '
        Me.btn_confirm_cuenta.Location = New System.Drawing.Point(169, 100)
        Me.btn_confirm_cuenta.Name = "btn_confirm_cuenta"
        Me.btn_confirm_cuenta.Size = New System.Drawing.Size(116, 23)
        Me.btn_confirm_cuenta.TabIndex = 5
        Me.btn_confirm_cuenta.Text = "Confirmar Cuenta"
        Me.btn_confirm_cuenta.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Confirme la cuenta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Seleccione el Titular"
        '
        'cb_cuenta
        '
        Me.cb_cuenta.FormattingEnabled = True
        Me.cb_cuenta.Location = New System.Drawing.Point(114, 73)
        Me.cb_cuenta.Name = "cb_cuenta"
        Me.cb_cuenta.Size = New System.Drawing.Size(171, 21)
        Me.cb_cuenta.TabIndex = 3
        '
        'cb_titular
        '
        Me.cb_titular.FormattingEnabled = True
        Me.cb_titular.Location = New System.Drawing.Point(114, 46)
        Me.cb_titular.Name = "cb_titular"
        Me.cb_titular.Size = New System.Drawing.Size(171, 21)
        Me.cb_titular.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nro Cheque"
        '
        'txt_nro
        '
        Me.txt_nro.Location = New System.Drawing.Point(125, 21)
        Me.txt_nro.Name = "txt_nro"
        Me.txt_nro.Size = New System.Drawing.Size(200, 20)
        Me.txt_nro.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Monto"
        '
        'txt_monto
        '
        Me.txt_monto.Location = New System.Drawing.Point(125, 47)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(200, 20)
        Me.txt_monto.TabIndex = 1
        '
        'dtp_emision
        '
        Me.dtp_emision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_emision.Location = New System.Drawing.Point(125, 73)
        Me.dtp_emision.Name = "dtp_emision"
        Me.dtp_emision.Size = New System.Drawing.Size(200, 20)
        Me.dtp_emision.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Fecha de Emision"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Fecha de Vencimiento"
        '
        'dtp_vencimiento
        '
        Me.dtp_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_vencimiento.Location = New System.Drawing.Point(125, 99)
        Me.dtp_vencimiento.Name = "dtp_vencimiento"
        Me.dtp_vencimiento.Size = New System.Drawing.Size(200, 20)
        Me.dtp_vencimiento.TabIndex = 3
        '
        'cb_cruzado
        '
        Me.cb_cruzado.AutoSize = True
        Me.cb_cruzado.Location = New System.Drawing.Point(125, 125)
        Me.cb_cruzado.Name = "cb_cruzado"
        Me.cb_cruzado.Size = New System.Drawing.Size(65, 17)
        Me.cb_cruzado.TabIndex = 4
        Me.cb_cruzado.Text = "Cruzado"
        Me.cb_cruzado.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(331, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Observaciones"
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(331, 47)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(268, 72)
        Me.txt_observaciones.TabIndex = 5
        '
        'btn_accept
        '
        Me.btn_accept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_accept.Location = New System.Drawing.Point(529, 392)
        Me.btn_accept.Name = "btn_accept"
        Me.btn_accept.Size = New System.Drawing.Size(75, 23)
        Me.btn_accept.TabIndex = 6
        Me.btn_accept.Text = "Dale que va"
        Me.btn_accept.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Location = New System.Drawing.Point(610, 392)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.Text = "Me arrepenti"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'gp_cheque
        '
        Me.gp_cheque.Controls.Add(Me.Label5)
        Me.gp_cheque.Controls.Add(Me.Label9)
        Me.gp_cheque.Controls.Add(Me.txt_nro)
        Me.gp_cheque.Controls.Add(Me.txt_observaciones)
        Me.gp_cheque.Controls.Add(Me.Label6)
        Me.gp_cheque.Controls.Add(Me.cb_cruzado)
        Me.gp_cheque.Controls.Add(Me.Label7)
        Me.gp_cheque.Controls.Add(Me.dtp_vencimiento)
        Me.gp_cheque.Controls.Add(Me.txt_monto)
        Me.gp_cheque.Controls.Add(Me.dtp_emision)
        Me.gp_cheque.Controls.Add(Me.Label8)
        Me.gp_cheque.Enabled = False
        Me.gp_cheque.Location = New System.Drawing.Point(12, 214)
        Me.gp_cheque.Name = "gp_cheque"
        Me.gp_cheque.Size = New System.Drawing.Size(611, 169)
        Me.gp_cheque.TabIndex = 8
        Me.gp_cheque.TabStop = False
        Me.gp_cheque.Text = "Datos de cheque"
        '
        'btn_select_cuenta
        '
        Me.btn_select_cuenta.Enabled = False
        Me.btn_select_cuenta.Location = New System.Drawing.Point(461, 185)
        Me.btn_select_cuenta.Name = "btn_select_cuenta"
        Me.btn_select_cuenta.Size = New System.Drawing.Size(125, 23)
        Me.btn_select_cuenta.TabIndex = 9
        Me.btn_select_cuenta.Text = "Seleccion de cuenta"
        Me.btn_select_cuenta.UseVisualStyleBackColor = True
        '
        'frmNuevoCheque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 427)
        Me.Controls.Add(Me.btn_select_cuenta)
        Me.Controls.Add(Me.gp_cheque)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_accept)
        Me.Controls.Add(Me.gp_cuenta)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimumSize = New System.Drawing.Size(628, 412)
        Me.Name = "frmNuevoCheque"
        Me.Text = "Nuevo Cheque"
        Me.gp_cuenta.ResumeLayout(False)
        Me.gp_cuenta.PerformLayout()
        Me.gp_cheque.ResumeLayout(False)
        Me.gp_cheque.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_bancos As System.Windows.Forms.ComboBox
    Friend WithEvents gp_cuenta As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_titular As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_cuenta As System.Windows.Forms.ComboBox
    Friend WithEvents btn_new_cuenta As System.Windows.Forms.Button
    Friend WithEvents btn_new_titular As System.Windows.Forms.Button
    Friend WithEvents btn_confirm_cuenta As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_nro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_monto As System.Windows.Forms.TextBox
    Friend WithEvents dtp_emision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtp_vencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb_cruzado As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents btn_accept As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents gp_cheque As System.Windows.Forms.GroupBox
    Friend WithEvents btn_select_cuenta As System.Windows.Forms.Button
End Class
