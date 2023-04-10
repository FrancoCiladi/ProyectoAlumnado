<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfesoresReemplazo
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
        Me.dgvProfesorReemplazo = New System.Windows.Forms.DataGridView()
        Me.btnReemplazar = New System.Windows.Forms.Button()
        CType(Me.dgvProfesorReemplazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProfesorReemplazo
        '
        Me.dgvProfesorReemplazo.AllowUserToAddRows = False
        Me.dgvProfesorReemplazo.AllowUserToDeleteRows = False
        Me.dgvProfesorReemplazo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProfesorReemplazo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProfesorReemplazo.Location = New System.Drawing.Point(13, 12)
        Me.dgvProfesorReemplazo.Name = "dgvProfesorReemplazo"
        Me.dgvProfesorReemplazo.Size = New System.Drawing.Size(428, 441)
        Me.dgvProfesorReemplazo.TabIndex = 0
        '
        'btnReemplazar
        '
        Me.btnReemplazar.Location = New System.Drawing.Point(175, 470)
        Me.btnReemplazar.Name = "btnReemplazar"
        Me.btnReemplazar.Size = New System.Drawing.Size(88, 38)
        Me.btnReemplazar.TabIndex = 1
        Me.btnReemplazar.Text = "Reemplazar"
        Me.btnReemplazar.UseVisualStyleBackColor = True
        '
        'frmProfesoresReemplazo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 520)
        Me.Controls.Add(Me.btnReemplazar)
        Me.Controls.Add(Me.dgvProfesorReemplazo)
        Me.Name = "frmProfesoresReemplazo"
        Me.Text = "Profesores - Reemplazo"
        CType(Me.dgvProfesorReemplazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvProfesorReemplazo As DataGridView
    Friend WithEvents btnReemplazar As Button
End Class
