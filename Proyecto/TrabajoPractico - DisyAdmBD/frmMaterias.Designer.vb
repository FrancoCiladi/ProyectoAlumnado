<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterias
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvMaterias = New System.Windows.Forms.DataGridView()
        Me.mnuMaterias = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RegistrarMateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarMateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarMateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.txtMateriaFiltrar = New System.Windows.Forms.TextBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMaterias.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMaterias
        '
        Me.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterias.ContextMenuStrip = Me.mnuMaterias
        Me.dgvMaterias.Location = New System.Drawing.Point(13, 76)
        Me.dgvMaterias.Name = "dgvMaterias"
        Me.dgvMaterias.Size = New System.Drawing.Size(669, 362)
        Me.dgvMaterias.TabIndex = 0
        '
        'mnuMaterias
        '
        Me.mnuMaterias.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarMateriaToolStripMenuItem, Me.ModificarMateriaToolStripMenuItem, Me.EliminarMateriaToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.mnuMaterias.Name = "mnuMaterias"
        Me.mnuMaterias.Size = New System.Drawing.Size(181, 114)
        '
        'RegistrarMateriaToolStripMenuItem
        '
        Me.RegistrarMateriaToolStripMenuItem.Name = "RegistrarMateriaToolStripMenuItem"
        Me.RegistrarMateriaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrarMateriaToolStripMenuItem.Text = "Registrar Materia"
        '
        'ModificarMateriaToolStripMenuItem
        '
        Me.ModificarMateriaToolStripMenuItem.Name = "ModificarMateriaToolStripMenuItem"
        Me.ModificarMateriaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificarMateriaToolStripMenuItem.Text = "Modificar Materia"
        '
        'EliminarMateriaToolStripMenuItem
        '
        Me.EliminarMateriaToolStripMenuItem.Name = "EliminarMateriaToolStripMenuItem"
        Me.EliminarMateriaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarMateriaToolStripMenuItem.Text = "Eliminar Materia"
        '
        'lblMateria
        '
        Me.lblMateria.AutoSize = True
        Me.lblMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMateria.Location = New System.Drawing.Point(12, 25)
        Me.lblMateria.Name = "lblMateria"
        Me.lblMateria.Size = New System.Drawing.Size(74, 20)
        Me.lblMateria.TabIndex = 4
        Me.lblMateria.Text = "Materia:"
        '
        'txtMateriaFiltrar
        '
        Me.txtMateriaFiltrar.Location = New System.Drawing.Point(92, 27)
        Me.txtMateriaFiltrar.Name = "txtMateriaFiltrar"
        Me.txtMateriaFiltrar.Size = New System.Drawing.Size(204, 20)
        Me.txtMateriaFiltrar.TabIndex = 5
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(320, 20)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(95, 33)
        Me.btnFiltrar.TabIndex = 6
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'frmMaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 450)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.txtMateriaFiltrar)
        Me.Controls.Add(Me.lblMateria)
        Me.Controls.Add(Me.dgvMaterias)
        Me.Name = "frmMaterias"
        Me.Text = "Materias"
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMaterias.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMaterias As DataGridView
    Friend WithEvents lblMateria As Label
    Friend WithEvents txtMateriaFiltrar As TextBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents mnuMaterias As ContextMenuStrip
    Friend WithEvents RegistrarMateriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarMateriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarMateriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
End Class
