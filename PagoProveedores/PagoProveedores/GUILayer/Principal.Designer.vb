<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal
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
        Me.btn_banco = New System.Windows.Forms.Button()
        Me.btn_proveedor = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_titulares = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_cheques = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_banco
        '
        Me.btn_banco.Location = New System.Drawing.Point(13, 32)
        Me.btn_banco.Name = "btn_banco"
        Me.btn_banco.Size = New System.Drawing.Size(75, 23)
        Me.btn_banco.TabIndex = 0
        Me.btn_banco.Text = "Bancos"
        Me.btn_banco.UseVisualStyleBackColor = True
        '
        'btn_proveedor
        '
        Me.btn_proveedor.Location = New System.Drawing.Point(95, 31)
        Me.btn_proveedor.Name = "btn_proveedor"
        Me.btn_proveedor.Size = New System.Drawing.Size(75, 23)
        Me.btn_proveedor.TabIndex = 1
        Me.btn_proveedor.Text = "Proveedores"
        Me.btn_proveedor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 189)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Test Proveedor 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_titulares
        '
        Me.btn_titulares.Location = New System.Drawing.Point(176, 32)
        Me.btn_titulares.Name = "btn_titulares"
        Me.btn_titulares.Size = New System.Drawing.Size(75, 23)
        Me.btn_titulares.TabIndex = 3
        Me.btn_titulares.Text = "Titulares"
        Me.btn_titulares.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Nueva Factura"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_cheques
        '
        Me.btn_cheques.Location = New System.Drawing.Point(257, 32)
        Me.btn_cheques.Name = "btn_cheques"
        Me.btn_cheques.Size = New System.Drawing.Size(75, 23)
        Me.btn_cheques.TabIndex = 5
        Me.btn_cheques.Text = "Cheques"
        Me.btn_cheques.UseVisualStyleBackColor = True
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 273)
        Me.Controls.Add(Me.btn_cheques)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_titulares)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_proveedor)
        Me.Controls.Add(Me.btn_banco)
        Me.Name = "frm_principal"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_banco As System.Windows.Forms.Button
    Friend WithEvents btn_proveedor As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_titulares As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_cheques As System.Windows.Forms.Button
End Class
