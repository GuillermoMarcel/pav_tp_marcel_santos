<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitularesConsulta
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
        Me.dgv_titulares = New System.Windows.Forms.DataGridView()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_modify = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_cuenta = New System.Windows.Forms.Button()
        CType(Me.dgv_titulares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_titulares
        '
        Me.dgv_titulares.AllowUserToAddRows = False
        Me.dgv_titulares.AllowUserToDeleteRows = False
        Me.dgv_titulares.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_titulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_titulares.Location = New System.Drawing.Point(11, 51)
        Me.dgv_titulares.Name = "dgv_titulares"
        Me.dgv_titulares.ReadOnly = True
        Me.dgv_titulares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_titulares.Size = New System.Drawing.Size(570, 214)
        Me.dgv_titulares.TabIndex = 6
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.Location = New System.Drawing.Point(506, 12)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 2
        Me.btn_update.Text = "Actualizar"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(197, 12)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Baja"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_modify
        '
        Me.btn_modify.Enabled = False
        Me.btn_modify.Location = New System.Drawing.Point(93, 12)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(98, 23)
        Me.btn_modify.TabIndex = 4
        Me.btn_modify.Text = "Ver / Modificar"
        Me.btn_modify.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(12, 12)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 23)
        Me.btn_new.TabIndex = 5
        Me.btn_new.Text = "Nuevo"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_cuenta
        '
        Me.btn_cuenta.Enabled = False
        Me.btn_cuenta.Location = New System.Drawing.Point(312, 12)
        Me.btn_cuenta.Name = "btn_cuenta"
        Me.btn_cuenta.Size = New System.Drawing.Size(75, 23)
        Me.btn_cuenta.TabIndex = 7
        Me.btn_cuenta.Text = "Cuentas"
        Me.btn_cuenta.UseVisualStyleBackColor = True
        '
        'frmTitularesConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 277)
        Me.Controls.Add(Me.btn_cuenta)
        Me.Controls.Add(Me.dgv_titulares)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_modify)
        Me.Controls.Add(Me.btn_new)
        Me.MinimumSize = New System.Drawing.Size(479, 238)
        Me.Name = "frmTitularesConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Titulares"
        CType(Me.dgv_titulares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_titulares As System.Windows.Forms.DataGridView
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_modify As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_cuenta As System.Windows.Forms.Button
End Class
