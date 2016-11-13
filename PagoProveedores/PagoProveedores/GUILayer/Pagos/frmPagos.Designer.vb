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
        Me.col_fecha_pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tipo_pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_numero_pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_monto_pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_proveedor_pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gr_Facturas = New System.Windows.Forms.GroupBox()
        Me.dgv_facturas_seleccionadas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_total_facturas = New System.Windows.Forms.Label()
        Me.btn_quitar_factura = New System.Windows.Forms.Button()
        Me.btn_agregar_factura = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_cheques_seleccionados = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_total_cheques = New System.Windows.Forms.Label()
        Me.btn_quitar_cheque = New System.Windows.Forms.Button()
        Me.btn_agregar_cheque = New System.Windows.Forms.Button()
        Me.dgv_cheques_cartera = New System.Windows.Forms.DataGridView()
        Me.col_vencimiento_cartera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cheque_cartera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_titular_cartera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_banco_cartera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_monto_cartera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nro_banco_cartera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nro_cuenta_cartera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_efectivo = New System.Windows.Forms.TextBox()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.txt_obs = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgv_facturas_pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gr_Facturas.SuspendLayout()
        CType(Me.dgv_facturas_seleccionadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_cheques_seleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_cheques_cartera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_aceptar.Location = New System.Drawing.Point(1024, 595)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 0
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.Location = New System.Drawing.Point(1105, 595)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 1
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'cbo_proveedor
        '
        Me.cbo_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_proveedor.FormattingEnabled = True
        Me.cbo_proveedor.Location = New System.Drawing.Point(86, 49)
        Me.cbo_proveedor.Name = "cbo_proveedor"
        Me.cbo_proveedor.Size = New System.Drawing.Size(121, 21)
        Me.cbo_proveedor.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Proveedor"
        '
        'dgv_facturas_pendientes
        '
        Me.dgv_facturas_pendientes.AllowUserToAddRows = False
        Me.dgv_facturas_pendientes.AllowUserToDeleteRows = False
        Me.dgv_facturas_pendientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_facturas_pendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_facturas_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas_pendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_fecha_pendiente, Me.col_tipo_pendiente, Me.col_numero_pendiente, Me.col_monto_pendiente, Me.col_proveedor_pendiente})
        Me.dgv_facturas_pendientes.Location = New System.Drawing.Point(17, 31)
        Me.dgv_facturas_pendientes.Name = "dgv_facturas_pendientes"
        Me.dgv_facturas_pendientes.ReadOnly = True
        Me.dgv_facturas_pendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_facturas_pendientes.Size = New System.Drawing.Size(545, 166)
        Me.dgv_facturas_pendientes.TabIndex = 5
        '
        'col_fecha_pendiente
        '
        Me.col_fecha_pendiente.HeaderText = "Fecha"
        Me.col_fecha_pendiente.Name = "col_fecha_pendiente"
        Me.col_fecha_pendiente.ReadOnly = True
        Me.col_fecha_pendiente.Width = 62
        '
        'col_tipo_pendiente
        '
        Me.col_tipo_pendiente.HeaderText = "Tipo"
        Me.col_tipo_pendiente.Name = "col_tipo_pendiente"
        Me.col_tipo_pendiente.ReadOnly = True
        Me.col_tipo_pendiente.Width = 53
        '
        'col_numero_pendiente
        '
        Me.col_numero_pendiente.HeaderText = "Número"
        Me.col_numero_pendiente.Name = "col_numero_pendiente"
        Me.col_numero_pendiente.ReadOnly = True
        Me.col_numero_pendiente.Width = 69
        '
        'col_monto_pendiente
        '
        Me.col_monto_pendiente.HeaderText = "Monto"
        Me.col_monto_pendiente.Name = "col_monto_pendiente"
        Me.col_monto_pendiente.ReadOnly = True
        Me.col_monto_pendiente.Width = 62
        '
        'col_proveedor_pendiente
        '
        Me.col_proveedor_pendiente.HeaderText = "proveedor"
        Me.col_proveedor_pendiente.Name = "col_proveedor_pendiente"
        Me.col_proveedor_pendiente.ReadOnly = True
        Me.col_proveedor_pendiente.Visible = False
        '
        'gr_Facturas
        '
        Me.gr_Facturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gr_Facturas.Controls.Add(Me.dgv_facturas_seleccionadas)
        Me.gr_Facturas.Controls.Add(Me.lbl_total_facturas)
        Me.gr_Facturas.Controls.Add(Me.btn_quitar_factura)
        Me.gr_Facturas.Controls.Add(Me.btn_agregar_factura)
        Me.gr_Facturas.Controls.Add(Me.dgv_facturas_pendientes)
        Me.gr_Facturas.Location = New System.Drawing.Point(15, 78)
        Me.gr_Facturas.Name = "gr_Facturas"
        Me.gr_Facturas.Size = New System.Drawing.Size(1163, 227)
        Me.gr_Facturas.TabIndex = 12
        Me.gr_Facturas.TabStop = False
        Me.gr_Facturas.Text = "Facturas"
        '
        'dgv_facturas_seleccionadas
        '
        Me.dgv_facturas_seleccionadas.AllowUserToAddRows = False
        Me.dgv_facturas_seleccionadas.AllowUserToDeleteRows = False
        Me.dgv_facturas_seleccionadas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_facturas_seleccionadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_facturas_seleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas_seleccionadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.dgv_facturas_seleccionadas.Location = New System.Drawing.Point(612, 31)
        Me.dgv_facturas_seleccionadas.Name = "dgv_facturas_seleccionadas"
        Me.dgv_facturas_seleccionadas.ReadOnly = True
        Me.dgv_facturas_seleccionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_facturas_seleccionadas.Size = New System.Drawing.Size(545, 166)
        Me.dgv_facturas_seleccionadas.TabIndex = 13
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 62
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 53
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Número"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 69
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 62
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "proveedor"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'lbl_total_facturas
        '
        Me.lbl_total_facturas.AutoSize = True
        Me.lbl_total_facturas.Location = New System.Drawing.Point(609, 200)
        Me.lbl_total_facturas.Name = "lbl_total_facturas"
        Me.lbl_total_facturas.Size = New System.Drawing.Size(61, 13)
        Me.lbl_total_facturas.TabIndex = 12
        Me.lbl_total_facturas.Text = "$10.000,00"
        '
        'btn_quitar_factura
        '
        Me.btn_quitar_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_quitar_factura.Location = New System.Drawing.Point(568, 107)
        Me.btn_quitar_factura.Name = "btn_quitar_factura"
        Me.btn_quitar_factura.Size = New System.Drawing.Size(38, 27)
        Me.btn_quitar_factura.TabIndex = 11
        Me.btn_quitar_factura.Text = "<"
        Me.btn_quitar_factura.UseVisualStyleBackColor = True
        '
        'btn_agregar_factura
        '
        Me.btn_agregar_factura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_factura.Location = New System.Drawing.Point(568, 74)
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
        Me.GroupBox2.Controls.Add(Me.dgv_cheques_seleccionados)
        Me.GroupBox2.Controls.Add(Me.lbl_total_cheques)
        Me.GroupBox2.Controls.Add(Me.btn_quitar_cheque)
        Me.GroupBox2.Controls.Add(Me.btn_agregar_cheque)
        Me.GroupBox2.Controls.Add(Me.dgv_cheques_cartera)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 307)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1165, 231)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cheques"
        '
        'dgv_cheques_seleccionados
        '
        Me.dgv_cheques_seleccionados.AllowUserToAddRows = False
        Me.dgv_cheques_seleccionados.AllowUserToDeleteRows = False
        Me.dgv_cheques_seleccionados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_cheques_seleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_cheques_seleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cheques_seleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgv_cheques_seleccionados.Location = New System.Drawing.Point(612, 29)
        Me.dgv_cheques_seleccionados.Name = "dgv_cheques_seleccionados"
        Me.dgv_cheques_seleccionados.ReadOnly = True
        Me.dgv_cheques_seleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cheques_seleccionados.Size = New System.Drawing.Size(545, 166)
        Me.dgv_cheques_seleccionados.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Vencimiento"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cheque"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 69
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido y Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 107
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Banco"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 63
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 62
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = ""
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = ""
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'lbl_total_cheques
        '
        Me.lbl_total_cheques.AutoSize = True
        Me.lbl_total_cheques.Location = New System.Drawing.Point(609, 198)
        Me.lbl_total_cheques.Name = "lbl_total_cheques"
        Me.lbl_total_cheques.Size = New System.Drawing.Size(55, 13)
        Me.lbl_total_cheques.TabIndex = 13
        Me.lbl_total_cheques.Text = "$9.000,00"
        '
        'btn_quitar_cheque
        '
        Me.btn_quitar_cheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_quitar_cheque.Location = New System.Drawing.Point(568, 105)
        Me.btn_quitar_cheque.Name = "btn_quitar_cheque"
        Me.btn_quitar_cheque.Size = New System.Drawing.Size(38, 27)
        Me.btn_quitar_cheque.TabIndex = 11
        Me.btn_quitar_cheque.Text = "<"
        Me.btn_quitar_cheque.UseVisualStyleBackColor = True
        '
        'btn_agregar_cheque
        '
        Me.btn_agregar_cheque.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar_cheque.Location = New System.Drawing.Point(568, 76)
        Me.btn_agregar_cheque.Name = "btn_agregar_cheque"
        Me.btn_agregar_cheque.Size = New System.Drawing.Size(38, 27)
        Me.btn_agregar_cheque.TabIndex = 10
        Me.btn_agregar_cheque.Text = ">"
        Me.btn_agregar_cheque.UseVisualStyleBackColor = True
        '
        'dgv_cheques_cartera
        '
        Me.dgv_cheques_cartera.AllowUserToAddRows = False
        Me.dgv_cheques_cartera.AllowUserToDeleteRows = False
        Me.dgv_cheques_cartera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_cheques_cartera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_cheques_cartera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cheques_cartera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_vencimiento_cartera, Me.col_cheque_cartera, Me.col_titular_cartera, Me.col_banco_cartera, Me.col_monto_cartera, Me.col_nro_banco_cartera, Me.col_nro_cuenta_cartera})
        Me.dgv_cheques_cartera.Location = New System.Drawing.Point(17, 29)
        Me.dgv_cheques_cartera.Name = "dgv_cheques_cartera"
        Me.dgv_cheques_cartera.ReadOnly = True
        Me.dgv_cheques_cartera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cheques_cartera.Size = New System.Drawing.Size(545, 166)
        Me.dgv_cheques_cartera.TabIndex = 5
        '
        'col_vencimiento_cartera
        '
        Me.col_vencimiento_cartera.HeaderText = "Vencimiento"
        Me.col_vencimiento_cartera.Name = "col_vencimiento_cartera"
        Me.col_vencimiento_cartera.ReadOnly = True
        Me.col_vencimiento_cartera.Width = 90
        '
        'col_cheque_cartera
        '
        Me.col_cheque_cartera.HeaderText = "Cheque"
        Me.col_cheque_cartera.Name = "col_cheque_cartera"
        Me.col_cheque_cartera.ReadOnly = True
        Me.col_cheque_cartera.Width = 69
        '
        'col_titular_cartera
        '
        Me.col_titular_cartera.HeaderText = "Apellido y Nombre"
        Me.col_titular_cartera.Name = "col_titular_cartera"
        Me.col_titular_cartera.ReadOnly = True
        Me.col_titular_cartera.Width = 107
        '
        'col_banco_cartera
        '
        Me.col_banco_cartera.HeaderText = "Banco"
        Me.col_banco_cartera.Name = "col_banco_cartera"
        Me.col_banco_cartera.ReadOnly = True
        Me.col_banco_cartera.Width = 63
        '
        'col_monto_cartera
        '
        Me.col_monto_cartera.HeaderText = "Monto"
        Me.col_monto_cartera.Name = "col_monto_cartera"
        Me.col_monto_cartera.ReadOnly = True
        Me.col_monto_cartera.Width = 62
        '
        'col_nro_banco_cartera
        '
        Me.col_nro_banco_cartera.HeaderText = ""
        Me.col_nro_banco_cartera.Name = "col_nro_banco_cartera"
        Me.col_nro_banco_cartera.ReadOnly = True
        Me.col_nro_banco_cartera.Visible = False
        '
        'col_nro_cuenta_cartera
        '
        Me.col_nro_cuenta_cartera.HeaderText = ""
        Me.col_nro_cuenta_cartera.Name = "col_nro_cuenta_cartera"
        Me.col_nro_cuenta_cartera.ReadOnly = True
        Me.col_nro_cuenta_cartera.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(499, 547)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Efectivo"
        '
        'txt_efectivo
        '
        Me.txt_efectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_efectivo.Location = New System.Drawing.Point(551, 544)
        Me.txt_efectivo.Name = "txt_efectivo"
        Me.txt_efectivo.Size = New System.Drawing.Size(100, 20)
        Me.txt_efectivo.TabIndex = 16
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Location = New System.Drawing.Point(214, 46)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(75, 23)
        Me.btn_actualizar.TabIndex = 17
        Me.btn_actualizar.Text = "Actualizar"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'txt_obs
        '
        Me.txt_obs.Location = New System.Drawing.Point(157, 544)
        Me.txt_obs.Multiline = True
        Me.txt_obs.Name = "txt_obs"
        Me.txt_obs.Size = New System.Drawing.Size(336, 72)
        Me.txt_obs.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 547)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Observacion"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(473, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(253, 35)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Pago a Proveedores"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 628)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_obs)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.txt_efectivo)
        Me.Controls.Add(Me.Label3)
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
        Me.MinimumSize = New System.Drawing.Size(1196, 649)
        Me.Name = "frmPagos"
        Me.Text = "Pagos"
        CType(Me.dgv_facturas_pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gr_Facturas.ResumeLayout(False)
        Me.gr_Facturas.PerformLayout()
        CType(Me.dgv_facturas_seleccionadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_cheques_seleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_cheques_cartera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents cbo_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_facturas_pendientes As System.Windows.Forms.DataGridView
    Friend WithEvents gr_Facturas As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_total_facturas As System.Windows.Forms.Label
    Friend WithEvents btn_quitar_factura As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_factura As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_total_cheques As System.Windows.Forms.Label
    Friend WithEvents btn_quitar_cheque As System.Windows.Forms.Button
    Friend WithEvents btn_agregar_cheque As System.Windows.Forms.Button
    Friend WithEvents dgv_cheques_cartera As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents dgv_cheques_seleccionados As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_vencimiento_cartera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_cheque_cartera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_titular_cartera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_banco_cartera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_monto_cartera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nro_banco_cartera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_nro_cuenta_cartera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_pendiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_tipo_pendiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_numero_pendiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_monto_pendiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_proveedor_pendiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgv_facturas_seleccionadas As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_obs As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
