Public Class frmAlumnos
    Private Sub frmAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub RegistrarAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarAlumnoToolStripMenuItem.Click
        Operacion = "ALTA"
        frmAltaAlumno.ShowDialog()
    End Sub

    Private Sub ModificarAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarAlumnoToolStripMenuItem.Click
        If Not dgvAlumnos.CurrentRow Is Nothing Then
            Operacion = "MODIFICAR"
            nro_legajo_alumno_Selec = dgvAlumnos.CurrentRow.Cells("nro_legajo_a").Value
            frmAltaAlumno.ShowDialog()
        End If
    End Sub


    Private Sub CargarGrilla()
        Dim cadenaSQL As String
        Dim tabla As DataTable

        tabla = New DataTable()

        If txtAlumnoFiltrar.Text.Trim <> String.Empty Then
            cadenaSQL = "select * from vista_alumnos where Alumno like '" & txtAlumnoFiltrar.Text.Trim & "%' order by Alumno asc"
        Else
            cadenaSQL = "select * from vista_alumnos order by Alumno asc"
        End If
        sqlInforme = cadenaSQL

        Recuperar(cadenaSQL, tabla)
        dgvAlumnos.DataSource = tabla
        dgvAlumnos.AllowUserToAddRows = False
        dgvAlumnos.AllowUserToDeleteRows = False
        dgvAlumnos.Columns("nro_legajo_a").Visible = False
        dgvAlumnos.Columns("sexo").Visible = False
        dgvAlumnos.Columns("est_civil").Visible = False
        dgvAlumnos.Columns("cod_doc").Visible = False
        dgvAlumnos.Columns("NroDoc").HeaderText = "Nro. Doc"
        dgvAlumnos.Columns("direccion").HeaderText = "Direccion"
        dgvAlumnos.Columns("Telefono").HeaderText = "Telefono"
        dgvAlumnos.Columns("email").HeaderText = "Email"
        dgvAlumnos.Columns("FechaNacimiento").HeaderText = "Fecha Nacimiento"


    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        If ValidarFiltro(txtAlumnoFiltrar.Text.Trim) Then
            CargarGrilla()
        Else
            MessageBox.Show("Ingreso un caracter no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAlumnoFiltrar.Focus()
        End If
    End Sub

    Private Sub frmAlumnos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CargarGrilla()
    End Sub

    Private Sub EliminarAlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarAlumnoToolStripMenuItem.Click
        Dim cadenaSQL As String
        nro_legajo_alumno_Selec = dgvAlumnos.CurrentRow.Cells("nro_legajo_a").Value

        cadenaSQL = "delete from examenes where nro_legajo_a = " & nro_legajo_alumno_Selec
        Ejecutar(cadenaSQL)
        cadenaSQL = "delete from alumnos where nro_legajo_a = " & nro_legajo_alumno_Selec
        Ejecutar(cadenaSQL)

        MessageBox.Show("Registro de alumno eliminado.", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        frmReporteAlumnos.ShowDialog()
    End Sub
End Class