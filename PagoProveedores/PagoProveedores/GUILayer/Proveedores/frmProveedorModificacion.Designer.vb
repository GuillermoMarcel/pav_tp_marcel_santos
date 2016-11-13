<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedorModificacion
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
        Me.btn_borrar_mail = New System.Windows.Forms.Button()
        Me.txt_observacion = New System.Windows.Forms.RichTextBox()
        Me.txt_cuit = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lst_mail = New System.Windows.Forms.ListBox()
        Me.lst_telefono = New System.Windows.Forms.ListBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_razon_social = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_accept = New System.Windows.Forms.Button()
        Me.btn_edit_mail = New System.Windows.Forms.Button()
        Me.btn_edit_telefono = New System.Windows.Forms.Button()
        Me.btn_borrar_telefono = New System.Windows.Forms.Button()
        Me.btn_agregar_mail = New System.Windows.Forms.Button()
        Me.btn_agregar_telefono = New System.Windows.Forms.Button()
        Me.txt_altura = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_borrar_mail
        '
        Me.btn_borrar_mail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_borrar_mail.Location = New System.Drawing.Point(350, 360)
        Me.btn_borrar_mail.Name = "btn_borrar_mail"
        Me.btn_borrar_mail.Size = New System.Drawing.Size(28, 23)
        Me.btn_borrar_mail.TabIndex = 12
        Me.btn_borrar_mail.Text = "-"
        Me.btn_borrar_mail.UseVisualStyleBackColor = True
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(278, 115)
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(201, 58)
        Me.txt_observacion.TabIndex = 4
        Me.txt_observacion.Text = ""
        '
        'txt_cuit
        '
        Me.txt_cuit.Location = New System.Drawing.Point(278, 72)
        Me.txt_cuit.Mask = "00-00000000-0"
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(100, 20)
        Me.txt_cuit.TabIndex = 3
        Me.txt_cuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(275, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Mails"
        '
        'lst_mail
        '
        Me.lst_mail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lst_mail.FormattingEnabled = True
        Me.lst_mail.Location = New System.Drawing.Point(278, 191)
        Me.lst_mail.Name = "lst_mail"
        Me.lst_mail.Size = New System.Drawing.Size(201, 134)
        Me.lst_mail.TabIndex = 9
        '
        'lst_telefono
        '
        Me.lst_telefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lst_telefono.FormattingEnabled = True
        Me.lst_telefono.Location = New System.Drawing.Point(33, 191)
        Me.lst_telefono.Name = "lst_telefono"
        Me.lst_telefono.Size = New System.Drawing.Size(187, 134)
        Me.lst_telefono.TabIndex = 5
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(33, 115)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(187, 20)
        Me.txt_direccion.TabIndex = 1
        '
        'txt_razon_social
        '
        Me.txt_razon_social.Location = New System.Drawing.Point(33, 72)
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(187, 20)
        Me.txt_razon_social.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(275, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Observaciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Teléfonos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(275, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "CUIT"
        '
        'lbl_razon_social
        '
        Me.lbl_razon_social.AutoSize = True
        Me.lbl_razon_social.Location = New System.Drawing.Point(30, 57)
        Me.lbl_razon_social.Name = "lbl_razon_social"
        Me.lbl_razon_social.Size = New System.Drawing.Size(70, 13)
        Me.lbl_razon_social.TabIndex = 22
        Me.lbl_razon_social.Text = "Razón Social"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Location = New System.Drawing.Point(413, 395)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 14
        Me.btn_cancel.Text = "Cancelar"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_accept
        '
        Me.btn_accept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_accept.Location = New System.Drawing.Point(332, 395)
        Me.btn_accept.Name = "btn_accept"
        Me.btn_accept.Size = New System.Drawing.Size(75, 23)
        Me.btn_accept.TabIndex = 13
        Me.btn_accept.Text = "Aceptar"
        Me.btn_accept.UseVisualStyleBackColor = True
        '
        'btn_edit_mail
        '
        Me.btn_edit_mail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_edit_mail.BackgroundImage = Global.PagoProveedores.My.Resources.Resources.lapiz
        Me.btn_edit_mail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_edit_mail.Location = New System.Drawing.Point(278, 359)
        Me.btn_edit_mail.Name = "btn_edit_mail"
        Me.btn_edit_mail.Size = New System.Drawing.Size(33, 23)
        Me.btn_edit_mail.TabIndex = 10
        Me.btn_edit_mail.UseVisualStyleBackColor = True
        '
        'btn_edit_telefono
        '
        Me.btn_edit_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_edit_telefono.BackgroundImage = Global.PagoProveedores.My.Resources.Resources.lapiz
        Me.btn_edit_telefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_edit_telefono.Location = New System.Drawing.Point(120, 360)
        Me.btn_edit_telefono.Name = "btn_edit_telefono"
        Me.btn_edit_telefono.Size = New System.Drawing.Size(33, 23)
        Me.btn_edit_telefono.TabIndex = 6
        Me.btn_edit_telefono.UseVisualStyleBackColor = True
        '
        'btn_borrar_telefono
        '
        Me.btn_borrar_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_borrar_telefono.Location = New System.Drawing.Point(193, 360)
        Me.btn_borrar_telefono.Name = "btn_borrar_telefono"
        Me.btn_borrar_telefono.Size = New System.Drawing.Size(28, 23)
        Me.btn_borrar_telefono.TabIndex = 8
        Me.btn_borrar_telefono.Text = "-"
        Me.btn_borrar_telefono.UseVisualStyleBackColor = True
        '
        'btn_agregar_mail
        '
        Me.btn_agregar_mail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_mail.Location = New System.Drawing.Point(316, 360)
        Me.btn_agregar_mail.Name = "btn_agregar_mail"
        Me.btn_agregar_mail.Size = New System.Drawing.Size(28, 23)
        Me.btn_agregar_mail.TabIndex = 11
        Me.btn_agregar_mail.Text = "+"
        Me.btn_agregar_mail.UseVisualStyleBackColor = True
        '
        'btn_agregar_telefono
        '
        Me.btn_agregar_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_telefono.Location = New System.Drawing.Point(159, 360)
        Me.btn_agregar_telefono.Name = "btn_agregar_telefono"
        Me.btn_agregar_telefono.Size = New System.Drawing.Size(28, 23)
        Me.btn_agregar_telefono.TabIndex = 7
        Me.btn_agregar_telefono.Text = "+"
        Me.btn_agregar_telefono.UseVisualStyleBackColor = True
        '
        'txt_altura
        '
        Me.txt_altura.Location = New System.Drawing.Point(33, 154)
        Me.txt_altura.Name = "txt_altura"
        Me.txt_altura.Size = New System.Drawing.Size(188, 20)
        Me.txt_altura.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Altura"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(476, 35)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Modificación Proveedor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmProveedorModificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 430)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_altura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_edit_mail)
        Me.Controls.Add(Me.btn_edit_telefono)
        Me.Controls.Add(Me.btn_borrar_telefono)
        Me.Controls.Add(Me.btn_borrar_mail)
        Me.Controls.Add(Me.btn_agregar_mail)
        Me.Controls.Add(Me.btn_agregar_telefono)
        Me.Controls.Add(Me.txt_observacion)
        Me.Controls.Add(Me.txt_cuit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lst_mail)
        Me.Controls.Add(Me.lst_telefono)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_razon_social)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_razon_social)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_accept)
        Me.MinimumSize = New System.Drawing.Size(508, 361)
        Me.Name = "frmProveedorModificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Moficar Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_borrar_telefono As System.Windows.Forms.Button
    Friend WithEvents btn_borrar_mail As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_mail As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_telefono As System.Windows.Forms.Button
    Friend WithEvents txt_observacion As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_cuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lst_mail As System.Windows.Forms.ListBox
    Friend WithEvents lst_telefono As System.Windows.Forms.ListBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_razon_social As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_razon_social As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_accept As System.Windows.Forms.Button
    Friend WithEvents btn_edit_mail As System.Windows.Forms.Button
    Friend WithEvents btn_edit_telefono As System.Windows.Forms.Button
    Friend WithEvents txt_altura As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
