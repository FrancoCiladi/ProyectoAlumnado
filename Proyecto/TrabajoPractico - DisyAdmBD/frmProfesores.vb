Public Class frmProfesores
    Private Sub frmProfesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub RegistrarProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarProfesorToolStripMenuItem.Click
        Operacion = "ALTA"
        frmAltaProfesor.ShowDialog()
    End Sub

    Private Sub ModificarProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarProfesorToolStripMenuItem.Click
        If Not dgvProfesores.CurrentRow Is Nothing Then
            Operacion = "MODIFICAR"
            nro_legajo_profesor_Selec = dgvProfesores.CurrentRow.Cells("nro_legajo_p").Value
            frmAltaProfesor.ShowDialog()
        End If
    End Sub

    Private Sub CargarGrilla()
        Dim cadenaSQL As String
        Dim tabla As DataTable
        Dim col As DataGridViewLinkColumn  'necesario para hacer hyperlink a la columna 
        col = New DataGridViewLinkColumn
        tabla = New DataTable()

        If txtProfesorFiltrar.Text.Trim <> String.Empty Then
            cadenaSQL = "select * from Vista_Profesores where Profesor like '" & txtProfesorFiltrar.Text.Trim & "%' order by profesor asc"
        Else
            cadenaSQL = "select * from Vista_Profesores order by Profesor asc"
        End If
        sqlInforme = cadenaSQL

        Recuperar(cadenaSQL, tabla)
        dgvProfesores.DataSource = tabla
        dgvProfesores.AllowUserToAddRows = False
        dgvProfesores.AllowUserToDeleteRows = False
        dgvProfesores.Columns("nro_legajo_p").Visible = False
        dgvProfesores.Columns("sexo").Visible = False
        dgvProfesores.Columns("est_civil").Visible = False
        dgvProfesores.Columns("cod_doc").Visible = False
        dgvProfesores.Columns("cod_titulo").Visible = False
        dgvProfesores.Columns("telefono").Visible = False
        dgvProfesores.Columns("nro_doc").HeaderText = "Nro Doc"
        dgvProfesores.Columns("direccion").HeaderText = "Direccion"
        dgvProfesores.Columns("email").HeaderText = "Email"
        dgvProfesores.Columns("fec_nac").HeaderText = "Fecha Nacimiento"

        col.DataPropertyName = "Telefono" 'columna de la bd a la que va a estar enlazada, que campo va a recuperar de la bd
        col.Name = "Telefono"   'nombre que va a tener la columna 
        col.DisplayIndex = 1    'cambio el orden de la columna, por default siempre es al final
        dgvProfesores.Columns.Add(col)
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        If ValidarFiltro(txtProfesorFiltrar.Text.Trim) Then
            CargarGrilla()
        Else
            MessageBox.Show("Ingreso un caracter no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtProfesorFiltrar.Focus()
        End If
    End Sub

    Private Sub frmProfesores_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CargarGrilla()
    End Sub

    Private Sub EliminarProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarProfesorToolStripMenuItem.Click
        Dim cadenaSQL As String
        Dim tabla As DataTable = New DataTable
        nro_legajo_profesor_Selec = dgvProfesores.CurrentRow.Cells("nro_legajo_p").Value

        cadenaSQL = "select * from materias where nro_legajo_p = " & nro_legajo_profesor_Selec
        Recuperar(cadenaSQL, tabla)
        If tabla.Rows.Count = 0 Then
            cadenaSQL = "delete from profesores where nro_legajo_p = " & nro_legajo_profesor_Selec
            Ejecutar(cadenaSQL)
        Else
            MessageBox.Show("Debe seleccionar un reemplazo para su materia/s", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmProfesoresReemplazo.ShowDialog()
            cadenaSQL = "delete from profesores where nro_legajo_p = " & nro_legajo_profesor_Selec
            Ejecutar(cadenaSQL)
        End If



        MessageBox.Show("Registro de profesor eliminado.", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        frmReporteProfesores.ShowDialog()
    End Sub
End Class