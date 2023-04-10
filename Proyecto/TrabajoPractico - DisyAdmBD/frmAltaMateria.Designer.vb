<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaMateria
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
        Me.lblApyNom = New System.Windows.Forms.Label()
        Me.mskCodMat = New System.Windows.Forms.MaskedTextBox()
        Me.lblDescMateria = New System.Windows.Forms.Label()
        Me.txtDescMateria = New System.Windows.Forms.TextBox()
        Me.txtDescCarrera = New System.Windows.Forms.TextBox()
        Me.lblDescCarrera = New System.Windows.Forms.Label()
        Me.lblProfesor = New System.Windows.Forms.Label()
        Me.cbxProfesor = New System.Windows.Forms.ComboBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblApyNom
        '
        Me.lblApyNom.AutoSize = True
        Me.lblApyNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApyNom.Location = New System.Drawing.Point(12, 24)
        Me.lblApyNom.Name = "lblApyNom"
        Me.lblApyNom.Size = New System.Drawing.Size(116, 20)
        Me.lblApyNom.TabIndex = 5
        Me.lblApyNom.Text = "Cod. Materia:"
        '
        'mskCodMat
        '
        Me.mskCodMat.Location = New System.Drawing.Point(144, 24)
        Me.mskCodMat.Mask = "000"
        Me.mskCodMat.Name = "mskCodMat"
        Me.mskCodMat.Size = New System.Drawing.Size(39, 20)
        Me.mskCodMat.TabIndex = 6
        '
        'lblDescMateria
        '
        Me.lblDescMateria.AutoSize = True
        Me.lblDescMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescMateria.Location = New System.Drawing.Point(12, 76)
        Me.lblDescMateria.Name = "lblDescMateria"
        Me.lblDescMateria.Size = New System.Drawing.Size(125, 20)
        Me.lblDescMateria.TabIndex = 7
        Me.lblDescMateria.Text = "Desc. Materia:"
        '
        'txtDescMateria
        '
        Me.txtDescMateria.Location = New System.Drawing.Point(144, 75)
        Me.txtDescMateria.MaxLength = 30
        Me.txtDescMateria.Name = "txtDescMateria"
        Me.txtDescMateria.Size = New System.Drawing.Size(223, 20)
        Me.txtDescMateria.TabIndex = 8
        '
        'txtDescCarrera
        '
        Me.txtDescCarrera.Location = New System.Drawing.Point(144, 132)
        Me.txtDescCarrera.MaxLength = 30
        Me.txtDescCarrera.Name = "txtDescCarrera"
        Me.txtDescCarrera.Size = New System.Drawing.Size(223, 20)
        Me.txtDescCarrera.TabIndex = 10
        '
        'lblDescCarrera
        '
        Me.lblDescCarrera.AutoSize = True
        Me.lblDescCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescCarrera.Location = New System.Drawing.Point(12, 133)
        Me.lblDescCarrera.Name = "lblDescCarrera"
        Me.lblDescCarrera.Size = New System.Drawing.Size(125, 20)
        Me.lblDescCarrera.TabIndex = 9
        Me.lblDescCarrera.Text = "Desc. Carrera:"
        '
        'lblProfesor
        '
        Me.lblProfesor.AutoSize = True
        Me.lblProfesor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfesor.Location = New System.Drawing.Point(31, 192)
        Me.lblProfesor.Name = "lblProfesor"
        Me.lblProfesor.Size = New System.Drawing.Size(82, 20)
        Me.lblProfesor.TabIndex = 11
        Me.lblProfesor.Text = "Profesor:"
        '
        'cbxProfesor
        '
        Me.cbxProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProfesor.FormattingEnabled = True
        Me.cbxProfesor.Location = New System.Drawing.Point(144, 194)
        Me.cbxProfesor.Name = "cbxProfesor"
        Me.cbxProfesor.Size = New System.Drawing.Size(223, 21)
        Me.cbxProfesor.TabIndex = 12
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(144, 249)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(113, 49)
        Me.btnRegistrar.TabIndex = 13
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'frmAltaMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 321)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.cbxProfesor)
        Me.Controls.Add(Me.lblProfesor)
        Me.Controls.Add(Me.txtDescCarrera)
        Me.Controls.Add(Me.lblDescCarrera)
        Me.Controls.Add(Me.txtDescMateria)
        Me.Controls.Add(Me.lblDescMateria)
        Me.Controls.Add(Me.mskCodMat)
        Me.Controls.Add(Me.lblApyNom)
        Me.Name = "frmAltaMateria"
        Me.Text = "Alta Materia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblApyNom As Label
    Friend WithEvents mskCodMat As MaskedTextBox
    Friend WithEvents lblDescMateria As Label
    Friend WithEvents txtDescMateria As TextBox
    Friend WithEvents txtDescCarrera As TextBox
    Friend WithEvents lblDescCarrera As Label
    Friend WithEvents lblProfesor As Label
    Friend WithEvents cbxProfesor As ComboBox
    Friend WithEvents btnRegistrar As Button
End Class
