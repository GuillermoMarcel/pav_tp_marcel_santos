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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo_cheque = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_banco
        '
        Me.btn_banco.Location = New System.Drawing.Point(6, 19)
        Me.btn_banco.Name = "btn_banco"
        Me.btn_banco.Size = New System.Drawing.Size(138, 23)
        Me.btn_banco.TabIndex = 0
        Me.btn_banco.Text = "Administrar Bancos"
        Me.btn_banco.UseVisualStyleBackColor = True
        '
        'btn_proveedor
        '
        Me.btn_proveedor.Location = New System.Drawing.Point(6, 19)
        Me.btn_proveedor.Name = "btn_proveedor"
        Me.btn_proveedor.Size = New System.Drawing.Size(138, 23)
        Me.btn_proveedor.TabIndex = 1
        Me.btn_proveedor.Text = "Administrar Proveedores"
        Me.btn_proveedor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Test Proveedor 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_titulares
        '
        Me.btn_titulares.Location = New System.Drawing.Point(6, 48)
        Me.btn_titulares.Name = "btn_titulares"
        Me.btn_titulares.Size = New System.Drawing.Size(138, 23)
        Me.btn_titulares.TabIndex = 3
        Me.btn_titulares.Text = "Administrar Titulares"
        Me.btn_titulares.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Nueva Factura"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_cheques
        '
        Me.btn_cheques.Location = New System.Drawing.Point(6, 19)
        Me.btn_cheques.Name = "btn_cheques"
        Me.btn_cheques.Size = New System.Drawing.Size(138, 23)
        Me.btn_cheques.TabIndex = 5
        Me.btn_cheques.Text = "Administrar Cheques"
        Me.btn_cheques.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_banco)
        Me.GroupBox1.Controls.Add(Me.btn_titulares)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 155)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bancos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(264, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 155)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Temporales"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.btn_proveedor)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 173)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(246, 155)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Proveedores"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_nuevo_cheque)
        Me.GroupBox4.Controls.Add(Me.btn_cheques)
        Me.GroupBox4.Location = New System.Drawing.Point(264, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(246, 155)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cheques"
        '
        'btn_nuevo_cheque
        '
        Me.btn_nuevo_cheque.Location = New System.Drawing.Point(6, 48)
        Me.btn_nuevo_cheque.Name = "btn_nuevo_cheque"
        Me.btn_nuevo_cheque.Size = New System.Drawing.Size(138, 23)
        Me.btn_nuevo_cheque.TabIndex = 5
        Me.btn_nuevo_cheque.Text = "Registrar Cheque Nuevo"
        Me.btn_nuevo_cheque.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Reporte Proveedores"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 347)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_principal"
        Me.Text = "Menu Principal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_banco As System.Windows.Forms.Button
    Friend WithEvents btn_proveedor As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_titulares As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_cheques As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_nuevo_cheque As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
