<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaCuenta
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
        Me.cbo_banco = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cbu = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sucursal = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nrocuenta = New System.Windows.Forms.TextBox()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbo_banco
        '
        Me.cbo_banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_banco.FormattingEnabled = True
        Me.cbo_banco.Location = New System.Drawing.Point(99, 12)
        Me.cbo_banco.Name = "cbo_banco"
        Me.cbo_banco.Size = New System.Drawing.Size(121, 21)
        Me.cbo_banco.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Banco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sucursal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CBU"
        '
        'txt_cbu
        '
        Me.txt_cbu.Location = New System.Drawing.Point(99, 91)
        Me.txt_cbu.Mask = "0000000000000000000000"
        Me.txt_cbu.Name = "txt_cbu"
        Me.txt_cbu.Size = New System.Drawing.Size(142, 20)
        Me.txt_cbu.TabIndex = 8
        Me.txt_cbu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_sucursal
        '
        Me.txt_sucursal.Location = New System.Drawing.Point(99, 39)
        Me.txt_sucursal.Mask = "000"
        Me.txt_sucursal.Name = "txt_sucursal"
        Me.txt_sucursal.Size = New System.Drawing.Size(29, 20)
        Me.txt_sucursal.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Numero Cuenta"
        '
        'txt_nrocuenta
        '
        Me.txt_nrocuenta.Location = New System.Drawing.Point(99, 65)
        Me.txt_nrocuenta.Name = "txt_nrocuenta"
        Me.txt_nrocuenta.Size = New System.Drawing.Size(100, 20)
        Me.txt_nrocuenta.TabIndex = 11
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_aceptar.Location = New System.Drawing.Point(124, 132)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 12
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(206, 131)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar.TabIndex = 13
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'frmNuevaCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 167)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.txt_nrocuenta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_sucursal)
        Me.Controls.Add(Me.txt_cbu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_banco)
        Me.Name = "frmNuevaCuenta"
        Me.Text = "Nueva Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_banco As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cbu As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_sucursal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nrocuenta As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
End Class
