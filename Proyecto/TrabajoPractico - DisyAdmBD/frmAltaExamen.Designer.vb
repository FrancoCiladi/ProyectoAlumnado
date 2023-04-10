<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaExamen
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
        Me.lblNroLegAlumno = New System.Windows.Forms.Label()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.lblturno = New System.Windows.Forms.Label()
        Me.lblNota = New System.Windows.Forms.Label()
        Me.dtpFechaInscripcion = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInscripcion = New System.Windows.Forms.Label()
        Me.mskNroLegAlumno = New System.Windows.Forms.MaskedTextBox()
        Me.cbxMateria = New System.Windows.Forms.ComboBox()
        Me.cbxTurno = New System.Windows.Forms.ComboBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.mskNota = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lblNroLegAlumno
        '
        Me.lblNroLegAlumno.AutoSize = True
        Me.lblNroLegAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroLegAlumno.Location = New System.Drawing.Point(25, 35)
        Me.lblNroLegAlumno.Name = "lblNroLegAlumno"
        Me.lblNroLegAlumno.Size = New System.Drawing.Size(171, 20)
        Me.lblNroLegAlumno.TabIndex = 6
        Me.lblNroLegAlumno.Text = "Nro. Legajo Alumno:"
        '
        'lblMateria
        '
        Me.lblMateria.AutoSize = True
        Me.lblMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMateria.Location = New System.Drawing.Point(25, 79)
        Me.lblMateria.Name = "lblMateria"
        Me.lblMateria.Size = New System.Drawing.Size(74, 20)
        Me.lblMateria.TabIndex = 7
        Me.lblMateria.Text = "Materia:"
        '
        'lblturno
        '
        Me.lblturno.AutoSize = True
        Me.lblturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblturno.Location = New System.Drawing.Point(25, 131)
        Me.lblturno.Name = "lblturno"
        Me.lblturno.Size = New System.Drawing.Size(60, 20)
        Me.lblturno.TabIndex = 8
        Me.lblturno.Text = "Turno:"
        '
        'lblNota
        '
        Me.lblNota.AutoSize = True
        Me.lblNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNota.Location = New System.Drawing.Point(25, 243)
        Me.lblNota.Name = "lblNota"
        Me.lblNota.Size = New System.Drawing.Size(52, 20)
        Me.lblNota.TabIndex = 10
        Me.lblNota.Text = "Nota:"
        '
        'dtpFechaInscripcion
        '
        Me.dtpFechaInscripcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInscripcion.Location = New System.Drawing.Point(187, 196)
        Me.dtpFechaInscripcion.MaxDate = New Date(2022, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaInscripcion.MinDate = New Date(2022, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaInscripcion.Name = "dtpFechaInscripcion"
        Me.dtpFechaInscripcion.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaInscripcion.TabIndex = 11
        Me.dtpFechaInscripcion.Value = New Date(2022, 10, 10, 0, 0, 0, 0)
        '
        'lblFechaInscripcion
        '
        Me.lblFechaInscripcion.AutoSize = True
        Me.lblFechaInscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaInscripcion.Location = New System.Drawing.Point(25, 196)
        Me.lblFechaInscripcion.Name = "lblFechaInscripcion"
        Me.lblFechaInscripcion.Size = New System.Drawing.Size(156, 20)
        Me.lblFechaInscripcion.TabIndex = 12
        Me.lblFechaInscripcion.Text = "Fecha Inscripcion:"
        '
        'mskNroLegAlumno
        '
        Me.mskNroLegAlumno.Location = New System.Drawing.Point(203, 34)
        Me.mskNroLegAlumno.Mask = "09999"
        Me.mskNroLegAlumno.Name = "mskNroLegAlumno"
        Me.mskNroLegAlumno.Size = New System.Drawing.Size(46, 20)
        Me.mskNroLegAlumno.TabIndex = 13
        '
        'cbxMateria
        '
        Me.cbxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMateria.FormattingEnabled = True
        Me.cbxMateria.Location = New System.Drawing.Point(105, 81)
        Me.cbxMateria.Name = "cbxMateria"
        Me.cbxMateria.Size = New System.Drawing.Size(174, 21)
        Me.cbxMateria.TabIndex = 14
        '
        'cbxTurno
        '
        Me.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTurno.FormattingEnabled = True
        Me.cbxTurno.Location = New System.Drawing.Point(105, 133)
        Me.cbxTurno.Name = "cbxTurno"
        Me.cbxTurno.Size = New System.Drawing.Size(174, 21)
        Me.cbxTurno.TabIndex = 15
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(87, 306)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(137, 50)
        Me.btnRegistrar.TabIndex = 18
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'mskNota
        '
        Me.mskNota.Location = New System.Drawing.Point(84, 242)
        Me.mskNota.Mask = "99"
        Me.mskNota.Name = "mskNota"
        Me.mskNota.Size = New System.Drawing.Size(39, 20)
        Me.mskNota.TabIndex = 19
        '
        'frmAltaExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 380)
        Me.Controls.Add(Me.mskNota)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.cbxTurno)
        Me.Controls.Add(Me.cbxMateria)
        Me.Controls.Add(Me.mskNroLegAlumno)
        Me.Controls.Add(Me.lblFechaInscripcion)
        Me.Controls.Add(Me.dtpFechaInscripcion)
        Me.Controls.Add(Me.lblNota)
        Me.Controls.Add(Me.lblturno)
        Me.Controls.Add(Me.lblMateria)
        Me.Controls.Add(Me.lblNroLegAlumno)
        Me.Name = "frmAltaExamen"
        Me.Text = "Alta Examen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNroLegAlumno As Label
    Friend WithEvents lblMateria As Label
    Friend WithEvents lblturno As Label
    Friend WithEvents lblNota As Label
    Friend WithEvents dtpFechaInscripcion As DateTimePicker
    Friend WithEvents lblFechaInscripcion As Label
    Friend WithEvents mskNroLegAlumno As MaskedTextBox
    Friend WithEvents cbxMateria As ComboBox
    Friend WithEvents cbxTurno As ComboBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents mskNota As MaskedTextBox
End Class
