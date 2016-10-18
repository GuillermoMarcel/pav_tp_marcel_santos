<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarCuenta
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
        Me.dgv_cuentas = New System.Windows.Forms.DataGridView()
        Me.txt_apellido = New System.Windows.Forms.Label()
        Me.txt_cuit = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        CType(Me.dgv_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_cuentas
        '
        Me.dgv_cuentas.AllowUserToAddRows = False
        Me.dgv_cuentas.AllowUserToDeleteRows = False
        Me.dgv_cuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_cuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cuentas.Enabled = False
        Me.dgv_cuentas.Location = New System.Drawing.Point(12, 25)
        Me.dgv_cuentas.MultiSelect = False
        Me.dgv_cuentas.Name = "dgv_cuentas"
        Me.dgv_cuentas.ReadOnly = True
        Me.dgv_cuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cuentas.Size = New System.Drawing.Size(443, 219)
        Me.dgv_cuentas.TabIndex = 3
        '
        'txt_apellido
        '
        Me.txt_apellido.AutoSize = True
        Me.txt_apellido.Location = New System.Drawing.Point(12, 9)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(149, 13)
        Me.txt_apellido.TabIndex = 4
        Me.txt_apellido.Text = "Apellido y nombre: Perez Juan"
        '
        'txt_cuit
        '
        Me.txt_cuit.AutoSize = True
        Me.txt_cuit.Location = New System.Drawing.Point(295, 9)
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(104, 13)
        Me.txt_cuit.TabIndex = 6
        Me.txt_cuit.Text = "CUIT: 20123124124"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(380, 250)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar.TabIndex = 7
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(12, 250)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 8
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(94, 251)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 9
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'frmConsultarCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 281)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.txt_cuit)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.dgv_cuentas)
        Me.Name = "frmConsultarCuenta"
        Me.Text = "Cuenta de Titular"
        CType(Me.dgv_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_cuentas As System.Windows.Forms.DataGridView
    Friend WithEvents txt_apellido As System.Windows.Forms.Label
    Friend WithEvents txt_cuit As System.Windows.Forms.Label
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
End Class
