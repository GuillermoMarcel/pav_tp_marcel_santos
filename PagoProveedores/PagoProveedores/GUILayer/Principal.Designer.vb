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
        Me.Button1.Text = "Test Proveedor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
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
End Class
