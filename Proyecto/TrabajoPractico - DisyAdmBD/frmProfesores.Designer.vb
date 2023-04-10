<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfesores
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
        Me.dgvProfesores = New System.Windows.Forms.DataGridView()
        Me.mnuProfesores = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RegistrarProfesorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarProfesorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarProfesorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtProfesorFiltrar = New System.Windows.Forms.TextBox()
        Me.lblProfesor = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvProfesores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuProfesores.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProfesores
        '
        Me.dgvProfesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProfesores.ContextMenuStrip = Me.mnuProfesores
        Me.dgvProfesores.Location = New System.Drawing.Point(13, 95)
        Me.dgvProfesores.Name = "dgvProfesores"
        Me.dgvProfesores.Size = New System.Drawing.Size(1091, 442)
        Me.dgvProfesores.TabIndex = 0
        '
        'mnuProfesores
        '
        Me.mnuProfesores.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarProfesorToolStripMenuItem, Me.ModificarProfesorToolStripMenuItem, Me.EliminarProfesorToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.mnuProfesores.Name = "mnuProfesores"
        Me.mnuProfesores.Size = New System.Drawing.Size(181, 114)
        '
        'RegistrarProfesorToolStripMenuItem
        '
        Me.RegistrarProfesorToolStripMenuItem.Name = "RegistrarProfesorToolStripMenuItem"
        Me.RegistrarProfesorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrarProfesorToolStripMenuItem.Text = "Registrar Profesor"
        '
        'ModificarProfesorToolStripMenuItem
        '
        Me.ModificarProfesorToolStripMenuItem.Name = "ModificarProfesorToolStripMenuItem"
        Me.ModificarProfesorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificarProfesorToolStripMenuItem.Text = "Modificar Profesor"
        '
        'EliminarProfesorToolStripMenuItem
        '
        Me.EliminarProfesorToolStripMenuItem.Name = "EliminarProfesorToolStripMenuItem"
        Me.EliminarProfesorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarProfesorToolStripMenuItem.Text = "Eliminar Profesor"
        '
        'txtProfesorFiltrar
        '
        Me.txtProfesorFiltrar.Location = New System.Drawing.Point(100, 34)
        Me.txtProfesorFiltrar.Name = "txtProfesorFiltrar"
        Me.txtProfesorFiltrar.Size = New System.Drawing.Size(204, 20)
        Me.txtProfesorFiltrar.TabIndex = 1
        '
        'lblProfesor
        '
        Me.lblProfesor.AutoSize = True
        Me.lblProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfesor.Location = New System.Drawing.Point(12, 34)
        Me.lblProfesor.Name = "lblProfesor"
        Me.lblProfesor.Size = New System.Drawing.Size(82, 20)
        Me.lblProfesor.TabIndex = 3
        Me.lblProfesor.Text = "Profesor:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(334, 27)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(95, 33)
        Me.btnFiltrar.TabIndex = 4
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'frmProfesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 549)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.lblProfesor)
        Me.Controls.Add(Me.txtProfesorFiltrar)
        Me.Controls.Add(Me.dgvProfesores)
        Me.Name = "frmProfesores"
        Me.Text = "Profesores"
        CType(Me.dgvProfesores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuProfesores.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProfesores As DataGridView
    Friend WithEvents txtProfesorFiltrar As TextBox
    Friend WithEvents lblProfesor As Label
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents mnuProfesores As ContextMenuStrip
    Friend WithEvents RegistrarProfesorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarProfesorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarProfesorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
End Class
