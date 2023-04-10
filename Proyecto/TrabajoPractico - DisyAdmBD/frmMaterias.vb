Public Class frmMaterias
    Private Sub frmMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub RegistrarMateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarMateriaToolStripMenuItem.Click
        Operacion = "ALTA"
        frmAltaMateria.ShowDialog()
    End Sub

    Private Sub ModificarMateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarMateriaToolStripMenuItem.Click

        If Not dgvMaterias.CurrentRow Is Nothing Then
            Operacion = "MODIFICAR"
            cod_materia_Selec = dgvMaterias.CurrentRow.Cells("cod_materia").Value
            frmAltaMateria.ShowDialog()
        End If

    End Sub
    Private Sub CargarGrilla()
        Dim cadenaSQL As String
        Dim tabla As DataTable

        tabla = New DataTable()

        If txtMateriaFiltrar.Text.Trim <> String.Empty Then
            cadenaSQL = "select * from vista_materias where desc_mat like '" & txtMateriaFiltrar.Text.Trim & "%' order by codigo asc"
        Else
            cadenaSQL = "select * from vista_materias order by codigo asc"
        End If
        sqlInforme = cadenaSQL

        Recuperar(cadenaSQL, tabla)
        dgvMaterias.DataSource = tabla
        dgvMaterias.AllowUserToAddRows = False
        dgvMaterias.AllowUserToDeleteRows = False

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        If ValidarFiltro(txtMateriaFiltrar.Text.Trim) Then
            CargarGrilla()
        Else
            MessageBox.Show("Ingreso un caracter no permitido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMateriaFiltrar.Focus()
        End If
    End Sub

    Private Sub frmMaterias_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CargarGrilla()
    End Sub

    Private Sub EliminarMateriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarMateriaToolStripMenuItem.Click
        Dim cadenaSQL As String
        Dim tabla As DataTable = New DataTable

        cod_materia_Selec = dgvMaterias.CurrentRow.Cells("codigo").Value


        cadenaSQL = "select * from examenes where cod_mat = '" & cod_materia_Selec & "'"
        Recuperar(cadenaSQL, tabla)
        If tabla.Rows.Count = 0 Then
            cadenaSQL = "delete from planificacion where cod_mat = '" & cod_materia_Selec & "'"
            Ejecutar(cadenaSQL)
            cadenaSQL = "delete from Materias where cod_materia = '" & cod_materia_Selec & "'"
            Ejecutar(cadenaSQL)
            MessageBox.Show("Materia eliminada con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            cadenaSQL = "delete from Examenes where cod_mat = '" & cod_materia_Selec & "'"
            Ejecutar(cadenaSQL)
            cadenaSQL = "delete from planificacion where cod_mat = '" & cod_materia_Selec & "'"
            Ejecutar(cadenaSQL)
            cadenaSQL = "delete from Materias where cod_materia = '" & cod_materia_Selec & "'"
            Ejecutar(cadenaSQL)
            MessageBox.Show("Materia eliminada con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        frmReporteMaterias.ShowDialog()
    End Sub
End Class