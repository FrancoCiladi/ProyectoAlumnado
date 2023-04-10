<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnos
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
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.mnuAlumnos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RegistrarAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtAlumnoFiltrar = New System.Windows.Forms.TextBox()
        Me.lblAlumno = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuAlumnos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnos.ContextMenuStrip = Me.mnuAlumnos
        Me.dgvAlumnos.Location = New System.Drawing.Point(12, 81)
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.Size = New System.Drawing.Size(802, 351)
        Me.dgvAlumnos.TabIndex = 0
        '
        'mnuAlumnos
        '
        Me.mnuAlumnos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarAlumnoToolStripMenuItem, Me.ModificarAlumnoToolStripMenuItem, Me.EliminarAlumnoToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.mnuAlumnos.Name = "mnuAlumnos"
        Me.mnuAlumnos.Size = New System.Drawing.Size(181, 114)
        '
        'RegistrarAlumnoToolStripMenuItem
        '
        Me.RegistrarAlumnoToolStripMenuItem.Name = "RegistrarAlumnoToolStripMenuItem"
        Me.RegistrarAlumnoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrarAlumnoToolStripMenuItem.Text = "Registrar Alumno"
        '
        'ModificarAlumnoToolStripMenuItem
        '
        Me.ModificarAlumnoToolStripMenuItem.Name = "ModificarAlumnoToolStripMenuItem"
        Me.ModificarAlumnoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificarAlumnoToolStripMenuItem.Text = "Modificar Alumno"
        '
        'EliminarAlumnoToolStripMenuItem
        '
        Me.EliminarAlumnoToolStripMenuItem.Name = "EliminarAlumnoToolStripMenuItem"
        Me.EliminarAlumnoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarAlumnoToolStripMenuItem.Text = "Eliminar Alumno"
        '
        'txtAlumnoFiltrar
        '
        Me.txtAlumnoFiltrar.Location = New System.Drawing.Point(100, 26)
        Me.txtAlumnoFiltrar.Name = "txtAlumnoFiltrar"
        Me.txtAlumnoFiltrar.Size = New System.Drawing.Size(204, 20)
        Me.txtAlumnoFiltrar.TabIndex = 1
        '
        'lblAlumno
        '
        Me.lblAlumno.AutoSize = True
        Me.lblAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumno.Location = New System.Drawing.Point(12, 26)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Size = New System.Drawing.Size(74, 20)
        Me.lblAlumno.TabIndex = 2
        Me.lblAlumno.Text = "Alumno:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(340, 21)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(95, 33)
        Me.btnFiltrar.TabIndex = 3
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'frmAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 447)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.lblAlumno)
        Me.Controls.Add(Me.txtAlumnoFiltrar)
        Me.Controls.Add(Me.dgvAlumnos)
        Me.Name = "frmAlumnos"
        Me.Text = "Alumnos"
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuAlumnos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAlumnos As DataGridView
    Friend WithEvents txtAlumnoFiltrar As TextBox
    Friend WithEvents lblAlumno As Label
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents mnuAlumnos As ContextMenuStrip
    Friend WithEvents RegistrarAlumnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarAlumnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarAlumnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
End Class
