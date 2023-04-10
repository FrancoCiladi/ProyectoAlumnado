<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaProfesor
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
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.cbxTipoDoc = New System.Windows.Forms.ComboBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.txtApyNomProfesor = New System.Windows.Forms.TextBox()
        Me.lblEstCivil = New System.Windows.Forms.Label()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblNroDoc = New System.Windows.Forms.Label()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.lblApyNom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxTitulo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCasado = New System.Windows.Forms.RadioButton()
        Me.rbSoltero = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbMasculino = New System.Windows.Forms.RadioButton()
        Me.rbFemenino = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(510, 299)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(195, 57)
        Me.btnRegistrar.TabIndex = 43
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNac.Location = New System.Drawing.Point(134, 268)
        Me.dtpFechaNac.MaxDate = New Date(2022, 10, 8, 0, 0, 0, 0)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(105, 20)
        Me.dtpFechaNac.TabIndex = 40
        Me.dtpFechaNac.Value = New Date(2022, 10, 8, 0, 0, 0, 0)
        '
        'cbxTipoDoc
        '
        Me.cbxTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoDoc.FormattingEnabled = True
        Me.cbxTipoDoc.Location = New System.Drawing.Point(192, 90)
        Me.cbxTipoDoc.Name = "cbxTipoDoc"
        Me.cbxTipoDoc.Size = New System.Drawing.Size(165, 21)
        Me.cbxTipoDoc.TabIndex = 38
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(547, 151)
        Me.txtTelefono.MaxLength = 50
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(223, 20)
        Me.txtTelefono.TabIndex = 37
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(547, 92)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(223, 20)
        Me.txtEmail.TabIndex = 36
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(134, 212)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(223, 20)
        Me.txtDireccion.TabIndex = 35
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(134, 149)
        Me.txtNroDoc.MaxLength = 50
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(223, 20)
        Me.txtNroDoc.TabIndex = 34
        '
        'txtApyNomProfesor
        '
        Me.txtApyNomProfesor.Location = New System.Drawing.Point(192, 40)
        Me.txtApyNomProfesor.MaxLength = 50
        Me.txtApyNomProfesor.Name = "txtApyNomProfesor"
        Me.txtApyNomProfesor.Size = New System.Drawing.Size(230, 20)
        Me.txtApyNomProfesor.TabIndex = 33
        '
        'lblEstCivil
        '
        Me.lblEstCivil.AutoSize = True
        Me.lblEstCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstCivil.Location = New System.Drawing.Point(461, 38)
        Me.lblEstCivil.Name = "lblEstCivil"
        Me.lblEstCivil.Size = New System.Drawing.Size(83, 20)
        Me.lblEstCivil.TabIndex = 32
        Me.lblEstCivil.Text = "Est. Civil:"
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.Location = New System.Drawing.Point(28, 268)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(100, 20)
        Me.lblFechaNac.TabIndex = 31
        Me.lblFechaNac.Text = "Fecha Nac:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(469, 211)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(54, 20)
        Me.lblSexo.TabIndex = 30
        Me.lblSexo.Text = "Sexo:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(460, 149)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(84, 20)
        Me.lblTelefono.TabIndex = 29
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(461, 90)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(58, 20)
        Me.lblEmail.TabIndex = 28
        Me.lblEmail.Text = "Email:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(28, 210)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(89, 20)
        Me.lblDireccion.TabIndex = 27
        Me.lblDireccion.Text = "Direccion:"
        '
        'lblNroDoc
        '
        Me.lblNroDoc.AutoSize = True
        Me.lblNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroDoc.Location = New System.Drawing.Point(28, 147)
        Me.lblNroDoc.Name = "lblNroDoc"
        Me.lblNroDoc.Size = New System.Drawing.Size(84, 20)
        Me.lblNroDoc.TabIndex = 26
        Me.lblNroDoc.Text = "Nro. Doc:"
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDoc.Location = New System.Drawing.Point(28, 88)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(145, 20)
        Me.lblTipoDoc.TabIndex = 25
        Me.lblTipoDoc.Text = "Tipo Documento:"
        '
        'lblApyNom
        '
        Me.lblApyNom.AutoSize = True
        Me.lblApyNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApyNom.Location = New System.Drawing.Point(28, 40)
        Me.lblApyNom.Name = "lblApyNom"
        Me.lblApyNom.Size = New System.Drawing.Size(158, 20)
        Me.lblApyNom.TabIndex = 24
        Me.lblApyNom.Text = "Apellido y Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Titulo:"
        '
        'cbxTitulo
        '
        Me.cbxTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTitulo.FormattingEnabled = True
        Me.cbxTitulo.Location = New System.Drawing.Point(105, 335)
        Me.cbxTitulo.Name = "cbxTitulo"
        Me.cbxTitulo.Size = New System.Drawing.Size(165, 21)
        Me.cbxTitulo.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.rbCasado)
        Me.GroupBox1.Controls.Add(Me.rbSoltero)
        Me.GroupBox1.Location = New System.Drawing.Point(550, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 53)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'rbCasado
        '
        Me.rbCasado.AutoSize = True
        Me.rbCasado.Location = New System.Drawing.Point(6, 22)
        Me.rbCasado.Name = "rbCasado"
        Me.rbCasado.Size = New System.Drawing.Size(72, 17)
        Me.rbCasado.TabIndex = 26
        Me.rbCasado.TabStop = True
        Me.rbCasado.Text = "Casado/a"
        Me.rbCasado.UseVisualStyleBackColor = True
        '
        'rbSoltero
        '
        Me.rbSoltero.AutoSize = True
        Me.rbSoltero.Location = New System.Drawing.Point(84, 22)
        Me.rbSoltero.Name = "rbSoltero"
        Me.rbSoltero.Size = New System.Drawing.Size(69, 17)
        Me.rbSoltero.TabIndex = 27
        Me.rbSoltero.TabStop = True
        Me.rbSoltero.Text = "Soltero/a"
        Me.rbSoltero.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.rbMasculino)
        Me.GroupBox2.Controls.Add(Me.rbFemenino)
        Me.GroupBox2.Location = New System.Drawing.Point(547, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 53)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.Location = New System.Drawing.Point(6, 22)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbMasculino.TabIndex = 26
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "Masculino"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(84, 22)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(71, 17)
        Me.rbFemenino.TabIndex = 27
        Me.rbFemenino.TabStop = True
        Me.rbFemenino.Text = "Femenino"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'frmAltaProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 394)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbxTitulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.dtpFechaNac)
        Me.Controls.Add(Me.cbxTipoDoc)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNroDoc)
        Me.Controls.Add(Me.txtApyNomProfesor)
        Me.Controls.Add(Me.lblEstCivil)
        Me.Controls.Add(Me.lblFechaNac)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblNroDoc)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Controls.Add(Me.lblApyNom)
        Me.Name = "frmAltaProfesor"
        Me.Text = "Alta Profesor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegistrar As Button
    Friend WithEvents dtpFechaNac As DateTimePicker
    Friend WithEvents cbxTipoDoc As ComboBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNroDoc As TextBox
    Friend WithEvents txtApyNomProfesor As TextBox
    Friend WithEvents lblEstCivil As Label
    Friend WithEvents lblFechaNac As Label
    Friend WithEvents lblSexo As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblNroDoc As Label
    Friend WithEvents lblTipoDoc As Label
    Friend WithEvents lblApyNom As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxTitulo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCasado As RadioButton
    Friend WithEvents rbSoltero As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbMasculino As RadioButton
    Friend WithEvents rbFemenino As RadioButton
End Class
