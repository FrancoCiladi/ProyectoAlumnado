<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Me.btnAlumnos = New System.Windows.Forms.Button()
        Me.btnProfesores = New System.Windows.Forms.Button()
        Me.btnMaterias = New System.Windows.Forms.Button()
        Me.btnExamenes = New System.Windows.Forms.Button()
        Me.btnTurnos = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAlumnos
        '
        Me.btnAlumnos.Location = New System.Drawing.Point(30, 31)
        Me.btnAlumnos.Name = "btnAlumnos"
        Me.btnAlumnos.Size = New System.Drawing.Size(132, 45)
        Me.btnAlumnos.TabIndex = 0
        Me.btnAlumnos.Text = "Alumnos"
        Me.btnAlumnos.UseVisualStyleBackColor = True
        '
        'btnProfesores
        '
        Me.btnProfesores.Location = New System.Drawing.Point(229, 31)
        Me.btnProfesores.Name = "btnProfesores"
        Me.btnProfesores.Size = New System.Drawing.Size(132, 45)
        Me.btnProfesores.TabIndex = 1
        Me.btnProfesores.Text = "Profesores"
        Me.btnProfesores.UseVisualStyleBackColor = True
        '
        'btnMaterias
        '
        Me.btnMaterias.Location = New System.Drawing.Point(30, 148)
        Me.btnMaterias.Name = "btnMaterias"
        Me.btnMaterias.Size = New System.Drawing.Size(132, 45)
        Me.btnMaterias.TabIndex = 2
        Me.btnMaterias.Text = "Materias"
        Me.btnMaterias.UseVisualStyleBackColor = True
        '
        'btnExamenes
        '
        Me.btnExamenes.Location = New System.Drawing.Point(229, 148)
        Me.btnExamenes.Name = "btnExamenes"
        Me.btnExamenes.Size = New System.Drawing.Size(132, 45)
        Me.btnExamenes.TabIndex = 3
        Me.btnExamenes.Text = "Examenes"
        Me.btnExamenes.UseVisualStyleBackColor = True
        '
        'btnTurnos
        '
        Me.btnTurnos.Location = New System.Drawing.Point(30, 267)
        Me.btnTurnos.Name = "btnTurnos"
        Me.btnTurnos.Size = New System.Drawing.Size(132, 45)
        Me.btnTurnos.TabIndex = 4
        Me.btnTurnos.Text = "Turnos"
        Me.btnTurnos.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(229, 267)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(132, 45)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnTurnos)
        Me.Controls.Add(Me.btnExamenes)
        Me.Controls.Add(Me.btnMaterias)
        Me.Controls.Add(Me.btnProfesores)
        Me.Controls.Add(Me.btnAlumnos)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAlumnos As Button
    Friend WithEvents btnProfesores As Button
    Friend WithEvents btnMaterias As Button
    Friend WithEvents btnExamenes As Button
    Friend WithEvents btnTurnos As Button
    Friend WithEvents btnSalir As Button
End Class
