<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.cbo_proveedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_facturas_pendientes = New System.Windows.Forms.DataGridView()
        Me.dgv_facturas_seleccionadas = New System.Windows.Forms.DataGridView()
        Me.gr_Facturas = New System.Windows.Forms.GroupBox()
        Me.lbl_total_facturas = New System.Windows.Forms.Label()
        Me.btn_quitar_factura = New System.Windows.Forms.Button()
        Me.btn_agregar_factura = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_total_cheques = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btn_quitar_cheque = New System.Windows.Forms.Button()
        Me.btn_agregar_cheque = New System.Windows.Forms.Button()
        Me.dgv_cheques_cartera = New System.Windows.Forms.DataGridView()
        Me.dgv_cheques_seleccionados = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_efectivo = New System.Windows.Forms.TextBox()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        CType(Me.dgv_facturas_pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_facturas_seleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gr_Facturas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_cheques_cartera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_cheques_seleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_aceptar.Location = New System.Drawing.Point(745, 595)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 0
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.Location = New System.Drawing.Point(826, 595)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 1
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cbo_proveedor
        '
        Me.cbo_proveedor.FormattingEnabled = True
        Me.cbo_proveedor.Location = New System.Drawing.Point(86, 34)
        Me.cbo_proveedor.Name = "cbo_proveedor"
        Me.cbo_proveedor.Size = New System.Drawing.Size(121, 21)
        Me.cbo_proveedor.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Proveedor"
        '
        'dgv_facturas_pendientes
        '
        Me.dgv_facturas_pendientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_facturas_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas_pendientes.Location = New System.Drawing.Point(17, 31)
        Me.dgv_facturas_pendientes.Name = "dgv_facturas_pendientes"
        Me.dgv_facturas_pendientes.ReadOnly = True
        Me.dgv_facturas_pendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_facturas_pendientes.Size = New System.Drawing.Size(406, 166)
        Me.dgv_facturas_pendientes.TabIndex = 5
        '
        'dgv_facturas_seleccionadas
        '
        Me.dgv_facturas_seleccionadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_facturas_seleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas_seleccionadas.Location = New System.Drawing.Point(466, 31)
        Me.dgv_facturas_seleccionadas.Name = "dgv_facturas_seleccionadas"
        Me.dgv_facturas_seleccionadas.Size = New System.Drawing.Size(406, 166)
        Me.dgv_facturas_seleccionadas.TabIndex = 9
        '
        'gr_Facturas
        '
        Me.gr_Facturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gr_Facturas.Controls.Add(Me.lbl_total_facturas)
        Me.gr_Facturas.Controls.Add(Me.btn_quitar_factura)
        Me.gr_Facturas.Controls.Add(Me.btn_agregar_factura)
        Me.gr_Facturas.Controls.Add(Me.dgv_facturas_pendientes)
        Me.gr_Facturas.Controls.Add(Me.dgv_facturas_seleccionadas)
        Me.gr_Facturas.Location = New System.Drawing.Point(15, 78)
        Me.gr_Facturas.Name = "gr_Facturas"
        Me.gr_Facturas.Size = New System.Drawing.Size(889, 227)
        Me.gr_Facturas.TabIndex = 12
        Me.gr_Facturas.TabStop = False
        Me.gr_Facturas.Text = "Facturas"
        '
        'lbl_total_facturas
        '
        Me.lbl_total_facturas.AutoSize = True
        Me.lbl_total_facturas.Location = New System.Drawing.Point(463, 200)
        Me.lbl_total_facturas.Name = "lbl_total_facturas"
        Me.lbl_total_facturas.Size = New System.Drawing.Size(61, 13)
        Me.lbl_total_facturas.TabIndex = 12
        Me.lbl_total_facturas.Text = "$10.000,00"
        '
        'btn_quitar_factura
        '
        Me.btn_quitar_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_quitar_factura.Location = New System.Drawing.Point(426, 106)
        Me.btn_quitar_factura.Name = "btn_quitar_factura"
        Me.btn_quitar_factura.Size = New System.Drawing.Size(38, 27)
        Me.btn_quitar_factura.TabIndex = 11
        Me.btn_quitar_factura.Text = "<"
        Me.btn_quitar_factura.UseVisualStyleBackColor = True
        '
        'btn_agregar_factura
        '
        Me.btn_agregar_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_factura.Location = New System.Drawing.Point(426, 73)
        Me.btn_agregar_factura.Name = "btn_agregar_factura"
        Me.btn_agregar_factura.Size = New System.Drawing.Size(38, 27)
        Me.btn_agregar_factura.TabIndex = 10
        Me.btn_agregar_factura.Text = ">"
        Me.btn_agregar_factura.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lbl_total_cheques)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.btn_quitar_cheque)
        Me.GroupBox2.Controls.Add(Me.btn_agregar_cheque)
        Me.GroupBox2.Controls.Add(Me.dgv_cheques_cartera)
        Me.GroupBox2.Controls.Add(Me.dgv_cheques_seleccionados)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 307)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(889, 231)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cheques"
        '
        'lbl_total_cheques
        '
        Me.lbl_total_cheques.AutoSize = True
        Me.lbl_total_cheques.Location = New System.Drawing.Point(463, 205)
        Me.lbl_total_cheques.Name = "lbl_total_cheques"
        Me.lbl_total_cheques.Size = New System.Drawing.Size(55, 13)
        Me.lbl_total_cheques.TabIndex = 13
        Me.lbl_total_cheques.Text = "$9.000,00"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(301, 201)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 21)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Nuevo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btn_quitar_cheque
        '
        Me.btn_quitar_cheque.Location = New System.Drawing.Point(426, 108)
        Me.btn_quitar_cheque.Name = "btn_quitar_cheque"
        Me.btn_quitar_cheque.Size = New System.Drawing.Size(38, 27)
        Me.btn_quitar_cheque.TabIndex = 11
        Me.btn_quitar_cheque.Text = "<"
        Me.btn_quitar_cheque.UseVisualStyleBackColor = True
        '
        'btn_agregar_cheque
        '
        Me.btn_agregar_cheque.Location = New System.Drawing.Point(426, 79)
        Me.btn_agregar_cheque.Name = "btn_agregar_cheque"
        Me.btn_agregar_cheque.Size = New System.Drawing.Size(38, 27)
        Me.btn_agregar_cheque.TabIndex = 10
        Me.btn_agregar_cheque.Text = ">"
        Me.btn_agregar_cheque.UseVisualStyleBackColor = True
        '
        'dgv_cheques_cartera
        '
        Me.dgv_cheques_cartera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgv_cheques_cartera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cheques_cartera.Location = New System.Drawing.Point(17, 29)
        Me.dgv_cheques_cartera.Name = "dgv_cheques_cartera"
        Me.dgv_cheques_cartera.Size = New System.Drawing.Size(406, 166)
        Me.dgv_cheques_cartera.TabIndex = 5
        '
        'dgv_cheques_seleccionados
        '
        Me.dgv_cheques_seleccionados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_cheques_seleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cheques_seleccionados.Location = New System.Drawing.Point(466, 29)
        Me.dgv_cheques_seleccionados.Name = "dgv_cheques_seleccionados"
        Me.dgv_cheques_seleccionados.Size = New System.Drawing.Size(406, 166)
        Me.dgv_cheques_seleccionados.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 547)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Efectivo"
        '
        'txt_efectivo
        '
        Me.txt_efectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_efectivo.Location = New System.Drawing.Point(338, 544)
        Me.txt_efectivo.Name = "txt_efectivo"
        Me.txt_efectivo.Size = New System.Drawing.Size(100, 20)
        Me.txt_efectivo.TabIndex = 16
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Location = New System.Drawing.Point(214, 31)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(75, 23)
        Me.btn_actualizar.TabIndex = 17
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 628)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.txt_efectivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gr_Facturas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_proveedor)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(917, 653)
        Me.Name = "frmPagos"
        Me.Text = "Pagos"
        CType(Me.dgv_facturas_pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_facturas_seleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gr_Facturas.ResumeLayout(False)
        Me.gr_Facturas.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_cheques_cartera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_cheques_seleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents cbo_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_facturas_pendientes As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_facturas_seleccionadas As System.Windows.Forms.DataGridView
    Friend WithEvents gr_Facturas As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_total_facturas As System.Windows.Forms.Label
    Friend WithEvents btn_quitar_factura As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_factura As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_total_cheques As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btn_quitar_cheque As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_cheque As System.Windows.Forms.Button
    Friend WithEvents dgv_cheques_cartera As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_cheques_seleccionados As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
End Class
