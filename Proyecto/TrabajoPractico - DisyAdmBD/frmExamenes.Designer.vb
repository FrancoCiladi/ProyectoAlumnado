<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamenes
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
        Me.dgvExamenes = New System.Windows.Forms.DataGridView()
        Me.mnuExamenes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RegistrarExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarExamenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.cbxTurnoFiltrar = New System.Windows.Forms.ComboBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.btnTodos = New System.Windows.Forms.Button()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuExamenes.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvExamenes
        '
        Me.dgvExamenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExamenes.ContextMenuStrip = Me.mnuExamenes
        Me.dgvExamenes.Location = New System.Drawing.Point(12, 81)
        Me.dgvExamenes.Name = "dgvExamenes"
        Me.dgvExamenes.Size = New System.Drawing.Size(705, 443)
        Me.dgvExamenes.TabIndex = 0
        '
        'mnuExamenes
        '
        Me.mnuExamenes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarExamenToolStripMenuItem, Me.ModificarExamenToolStripMenuItem, Me.EliminarExamenToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.mnuExamenes.Name = "mnuExamenes"
        Me.mnuExamenes.Size = New System.Drawing.Size(181, 114)
        '
        'RegistrarExamenToolStripMenuItem
        '
        Me.RegistrarExamenToolStripMenuItem.Name = "RegistrarExamenToolStripMenuItem"
        Me.RegistrarExamenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrarExamenToolStripMenuItem.Text = "Registrar Examen"
        '
        'ModificarExamenToolStripMenuItem
        '
        Me.ModificarExamenToolStripMenuItem.Name = "ModificarExamenToolStripMenuItem"
        Me.ModificarExamenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificarExamenToolStripMenuItem.Text = "Modificar Examen"
        '
        'EliminarExamenToolStripMenuItem
        '
        Me.EliminarExamenToolStripMenuItem.Name = "EliminarExamenToolStripMenuItem"
        Me.EliminarExamenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarExamenToolStripMenuItem.Text = "Eliminar Examen"
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(12, 28)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(60, 20)
        Me.lblTurno.TabIndex = 4
        Me.lblTurno.Text = "Turno:"
        '
        'cbxTurnoFiltrar
        '
        Me.cbxTurnoFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTurnoFiltrar.FormattingEnabled = True
        Me.cbxTurnoFiltrar.Items.AddRange(New Object() {"Seleccione..."})
        Me.cbxTurnoFiltrar.Location = New System.Drawing.Point(92, 30)
        Me.cbxTurnoFiltrar.Name = "cbxTurnoFiltrar"
        Me.cbxTurnoFiltrar.Size = New System.Drawing.Size(200, 21)
        Me.cbxTurnoFiltrar.TabIndex = 5
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(319, 20)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(101, 38)
        Me.btnFiltrar.TabIndex = 6
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'btnTodos
        '
        Me.btnTodos.Location = New System.Drawing.Point(451, 20)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(101, 38)
        Me.btnTodos.TabIndex = 7
        Me.btnTodos.Text = "Todos"
        Me.btnTodos.UseVisualStyleBackColor = True
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'frmExamenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 536)
        Me.Controls.Add(Me.btnTodos)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.cbxTurnoFiltrar)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.dgvExamenes)
        Me.Name = "frmExamenes"
        Me.Text = "Examenes"
        CType(Me.dgvExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuExamenes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvExamenes As DataGridView
    Friend WithEvents lblTurno As Label
    Friend WithEvents cbxTurnoFiltrar As ComboBox
    Friend WithEvents mnuExamenes As ContextMenuStrip
    Friend WithEvents RegistrarExamenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarExamenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarExamenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents btnTodos As Button
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
End Class
