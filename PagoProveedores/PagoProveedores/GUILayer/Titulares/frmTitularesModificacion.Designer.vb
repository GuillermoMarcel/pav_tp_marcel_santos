<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitularesModificacion
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
        Me.cb_cuitnull = New System.Windows.Forms.CheckBox()
        Me.txt_altura = New System.Windows.Forms.TextBox()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.txt_cuit = New System.Windows.Forms.MaskedTextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_id_titular = New System.Windows.Forms.Label()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.dgv_cuentas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_modif = New System.Windows.Forms.Button()
        CType(Me.dgv_cuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_cuitnull
        '
        Me.cb_cuitnull.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_cuitnull.AutoSize = True
        Me.cb_cuitnull.Location = New System.Drawing.Point(373, 90)
        Me.cb_cuitnull.Name = "cb_cuitnull"
        Me.cb_cuitnull.Size = New System.Drawing.Size(81, 17)
        Me.cb_cuitnull.TabIndex = 24
        Me.cb_cuitnull.Text = "No Ingresar"
        Me.cb_cuitnull.UseVisualStyleBackColor = True
        '
        'txt_altura
        '
        Me.txt_altura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_altura.Location = New System.Drawing.Point(373, 114)
        Me.txt_altura.Name = "txt_altura"
        Me.txt_altura.Size = New System.Drawing.Size(57, 20)
        Me.txt_altura.TabIndex = 17
        '
        'txt_calle
        '
        Me.txt_calle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_calle.Location = New System.Drawing.Point(70, 114)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(297, 20)
        Me.txt_calle.TabIndex = 16
        '
        'txt_cuit
        '
        Me.txt_cuit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cuit.Location = New System.Drawing.Point(70, 88)
        Me.txt_cuit.Mask = "00-00000000-0"
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(297, 20)
        Me.txt_cuit.TabIndex = 15
        Me.txt_cuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.Location = New System.Drawing.Point(421, 326)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 19
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_aceptar.Enabled = False
        Me.btn_aceptar.Location = New System.Drawing.Point(340, 326)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 18
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "CUIT"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre"
        '
        'txt_apellido
        '
        Me.txt_apellido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_apellido.Location = New System.Drawing.Point(70, 62)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(297, 20)
        Me.txt_apellido.TabIndex = 14
        '
        'txt_nombre
        '
        Me.txt_nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre.Location = New System.Drawing.Point(70, 36)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(297, 20)
        Me.txt_nombre.TabIndex = 13
        '
        'txt_id_titular
        '
        Me.txt_id_titular.AutoSize = True
        Me.txt_id_titular.Location = New System.Drawing.Point(67, 9)
        Me.txt_id_titular.Name = "txt_id_titular"
        Me.txt_id_titular.Size = New System.Drawing.Size(30, 13)
        Me.txt_id_titular.TabIndex = 25
        Me.txt_id_titular.Text = "ID: 0"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_eliminar.Location = New System.Drawing.Point(141, 268)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 28
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_agregar.Location = New System.Drawing.Point(60, 268)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 27
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
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
        Me.dgv_cuentas.Location = New System.Drawing.Point(12, 160)
        Me.dgv_cuentas.MultiSelect = False
        Me.dgv_cuentas.Name = "dgv_cuentas"
        Me.dgv_cuentas.ReadOnly = True
        Me.dgv_cuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_cuentas.Size = New System.Drawing.Size(486, 102)
        Me.dgv_cuentas.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Cuentas"
        '
        'btn_modif
        '
        Me.btn_modif.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modif.Location = New System.Drawing.Point(423, 12)
        Me.btn_modif.Name = "btn_modif"
        Me.btn_modif.Size = New System.Drawing.Size(75, 23)
        Me.btn_modif.TabIndex = 30
        Me.btn_modif.Text = "Modificar"
        Me.btn_modif.UseVisualStyleBackColor = True
        '
        'frmTitularesModificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 361)
        Me.Controls.Add(Me.btn_modif)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_cuentas)
        Me.Controls.Add(Me.txt_id_titular)
        Me.Controls.Add(Me.cb_cuitnull)
        Me.Controls.Add(Me.txt_altura)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_cuit)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_nombre)
        Me.MinimumSize = New System.Drawing.Size(433, 333)
        Me.Name = "frmTitularesModificacion"
        Me.Text = "Modificar Titular"
        CType(Me.dgv_cuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_cuitnull As System.Windows.Forms.CheckBox
    Friend WithEvents txt_altura As System.Windows.Forms.TextBox
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents txt_cuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_id_titular As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents dgv_cuentas As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_modif As System.Windows.Forms.Button
End Class
