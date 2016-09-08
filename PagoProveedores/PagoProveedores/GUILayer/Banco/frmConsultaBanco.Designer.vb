<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaBanco
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
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_modify = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.dgv_grid = New System.Windows.Forms.DataGridView()
        Me.btn_update = New System.Windows.Forms.Button()
        CType(Me.dgv_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(12, 12)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 23)
        Me.btn_new.TabIndex = 0
        Me.btn_new.Text = "Nuevo"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_modify
        '
        Me.btn_modify.Location = New System.Drawing.Point(93, 12)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(75, 23)
        Me.btn_modify.TabIndex = 0
        Me.btn_modify.Text = "Modificacion"
        Me.btn_modify.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(174, 12)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 0
        Me.btn_delete.Text = "Baja"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'dgv_grid
        '
        Me.dgv_grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_grid.Location = New System.Drawing.Point(12, 41)
        Me.dgv_grid.Name = "dgv_grid"
        Me.dgv_grid.Size = New System.Drawing.Size(488, 271)
        Me.dgv_grid.TabIndex = 1
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(425, 12)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 0
        Me.btn_update.Text = "Actualizar"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'ConsultaBancoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 324)
        Me.Controls.Add(Me.dgv_grid)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_modify)
        Me.Controls.Add(Me.btn_new)
        Me.Name = "ConsultaBancoForm"
        Me.Text = "Bancos"
        CType(Me.dgv_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_modify As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents dgv_grid As System.Windows.Forms.DataGridView
    Friend WithEvents btn_update As System.Windows.Forms.Button
End Class
