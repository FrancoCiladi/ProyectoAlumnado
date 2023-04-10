<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTurnos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvTurnos = New System.Windows.Forms.DataGridView()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.cbxTurno = New System.Windows.Forms.ComboBox()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.cbxMateria = New System.Windows.Forms.ComboBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.lblConsulta = New System.Windows.Forms.Label()
        Me.cbxConsulta = New System.Windows.Forms.ComboBox()
        Me.chkTodasMaterias = New System.Windows.Forms.CheckBox()
        Me.chkTodosTurnos = New System.Windows.Forms.CheckBox()
        Me.lblAux = New System.Windows.Forms.Label()
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTurnos
        '
        Me.dgvTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTurnos.Location = New System.Drawing.Point(12, 143)
        Me.dgvTurnos.Name = "dgvTurnos"
        Me.dgvTurnos.Size = New System.Drawing.Size(1049, 492)
        Me.dgvTurnos.TabIndex = 0
        '
        'lblTurno
        '
        Me.lblTurno.AutoSize = True
        Me.lblTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.Location = New System.Drawing.Point(30, 85)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(60, 20)
        Me.lblTurno.TabIndex = 4
        Me.lblTurno.Text = "Turno:"
        '
        'cbxTurno
        '
        Me.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTurno.FormattingEnabled = True
        Me.cbxTurno.Location = New System.Drawing.Point(96, 87)
        Me.cbxTurno.Name = "cbxTurno"
        Me.cbxTurno.Size = New System.Drawing.Size(204, 21)
        Me.cbxTurno.TabIndex = 5
        '
        'lblMateria
        '
        Me.lblMateria.AutoSize = True
        Me.lblMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMateria.Location = New System.Drawing.Point(384, 87)
        Me.lblMateria.Name = "lblMateria"
        Me.lblMateria.Size = New System.Drawing.Size(74, 20)
        Me.lblMateria.TabIndex = 6
        Me.lblMateria.Text = "Materia:"
        '
        'cbxMateria
        '
        Me.cbxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMateria.FormattingEnabled = True
        Me.cbxMateria.Location = New System.Drawing.Point(464, 89)
        Me.cbxMateria.Name = "cbxMateria"
        Me.cbxMateria.Size = New System.Drawing.Size(204, 21)
        Me.cbxMateria.TabIndex = 7
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(907, 12)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(154, 109)
        Me.btnFiltrar.TabIndex = 8
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'lblConsulta
        '
        Me.lblConsulta.AutoSize = True
        Me.lblConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsulta.Location = New System.Drawing.Point(5, 30)
        Me.lblConsulta.Name = "lblConsulta"
        Me.lblConsulta.Size = New System.Drawing.Size(85, 20)
        Me.lblConsulta.TabIndex = 9
        Me.lblConsulta.Text = "Consulta:"
        '
        'cbxConsulta
        '
        Me.cbxConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxConsulta.FormattingEnabled = True
        Me.cbxConsulta.Location = New System.Drawing.Point(96, 32)
        Me.cbxConsulta.Name = "cbxConsulta"
        Me.cbxConsulta.Size = New System.Drawing.Size(254, 21)
        Me.cbxConsulta.TabIndex = 10
        '
        'chkTodasMaterias
        '
        Me.chkTodasMaterias.AutoSize = True
        Me.chkTodasMaterias.Location = New System.Drawing.Point(694, 92)
        Me.chkTodasMaterias.Name = "chkTodasMaterias"
        Me.chkTodasMaterias.Size = New System.Drawing.Size(56, 17)
        Me.chkTodasMaterias.TabIndex = 11
        Me.chkTodasMaterias.Text = "Todas"
        Me.chkTodasMaterias.UseVisualStyleBackColor = True
        '
        'chkTodosTurnos
        '
        Me.chkTodosTurnos.AutoSize = True
        Me.chkTodosTurnos.Location = New System.Drawing.Point(322, 89)
        Me.chkTodosTurnos.Name = "chkTodosTurnos"
        Me.chkTodosTurnos.Size = New System.Drawing.Size(56, 17)
        Me.chkTodosTurnos.TabIndex = 12
        Me.chkTodosTurnos.Text = "Todos"
        Me.chkTodosTurnos.UseVisualStyleBackColor = True
        '
        'lblAux
        '
        Me.lblAux.AutoSize = True
        Me.lblAux.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAux.Location = New System.Drawing.Point(356, 32)
        Me.lblAux.Name = "lblAux"
        Me.lblAux.Size = New System.Drawing.Size(39, 20)
        Me.lblAux.TabIndex = 14
        Me.lblAux.Text = "Aux"
        Me.lblAux.Visible = False
        '
        'frmTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 647)
        Me.Controls.Add(Me.lblAux)
        Me.Controls.Add(Me.chkTodosTurnos)
        Me.Controls.Add(Me.chkTodasMaterias)
        Me.Controls.Add(Me.cbxConsulta)
        Me.Controls.Add(Me.lblConsulta)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.cbxMateria)
        Me.Controls.Add(Me.lblMateria)
        Me.Controls.Add(Me.cbxTurno)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.dgvTurnos)
        Me.Name = "frmTurnos"
        Me.Text = "Turnos"
        CType(Me.dgvTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTurnos As DataGridView
    Friend WithEvents lblTurno As Label
    Friend WithEvents cbxTurno As ComboBox
    Friend WithEvents lblMateria As Label
    Friend WithEvents cbxMateria As ComboBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents lblConsulta As Label
    Friend WithEvents cbxConsulta As ComboBox
    Friend WithEvents chkTodasMaterias As CheckBox
    Friend WithEvents chkTodosTurnos As CheckBox
    Friend WithEvents lblAux As Label
End Class
