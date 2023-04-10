Public Class frmExamenes
    Private Sub frmExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim cadenaSQL As String
        Dim tabla As DataTable

        cadenaSQL = "select * from turnos order by cod_turno asc"
        tabla = New DataTable()
        Recuperar(cadenaSQL, tabla)
        cbxTurnoFiltrar.DataSource = tabla
        cbxTurnoFiltrar.DisplayMember = "desc_turno"
        cbxTurnoFiltrar.ValueMember = "cod_turno"
        cbxTurnoFiltrar.SelectedIndex = 0



    End Sub

    Private Sub RegistrarExamenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarExamenToolStripMenuItem.Click
        Operacion = "ALTA"
        frmAltaExamen.ShowDialog()
    End Sub

    Private Sub ModificarExamenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarExamenToolStripMenuItem.Click
        If Not dgvExamenes.CurrentRow Is Nothing Then
            Operacion = "MODIFICAR"

            cod_materia_Selec = dgvExamenes.CurrentRow.Cells("cod_mat").Value
            cod_turno_Selec = dgvExamenes.CurrentRow.Cells("cod_turno").Value
            nro_legajo_alumno_Selec = dgvExamenes.CurrentRow.Cells("nro_legajo_a").Value
            año_Selec = dgvExamenes.CurrentRow.Cells("año").Value

            frmAltaExamen.ShowDialog()
        End If
    End Sub

    Private Sub CargarGrilla()
        Dim cadenaSQL As String
        Dim tabla As DataTable

        tabla = New DataTable()

        cadenaSQL = "select * from vista_examenes order by cod_turno asc"
        sqlInforme = cadenaSQL

        Recuperar(cadenaSQL, tabla)
        dgvExamenes.DataSource = tabla
        dgvExamenes.AllowUserToAddRows = False
        dgvExamenes.AllowUserToDeleteRows = False
        dgvExamenes.Columns("nro_legajo_a").Visible = False
        dgvExamenes.Columns("cod_turno").Visible = False
        dgvExamenes.Columns("cod_mat").Visible = False
        dgvExamenes.Columns("año").Visible = False
        dgvExamenes.Columns("fecha_inscripcion").HeaderText = "Fecha Inscripcion"
        dgvExamenes.Columns("nota").HeaderText = "Nota"
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim cadenaSQL As String
        Dim tabla As DataTable
        Dim aux As String

        aux = cbxTurnoFiltrar.SelectedValue
        tabla = New DataTable()


        If aux = "TN001" Then
            cadenaSQL = "select * from vista_examenes where cod_turno = '" & cbxTurnoFiltrar.SelectedValue & "'"
        Else
            If aux = "TN002" Then
                cadenaSQL = "select * from vista_examenes where cod_turno = '" & cbxTurnoFiltrar.SelectedValue & "'"
            Else
                If aux = "TN003" Then
                    cadenaSQL = "select * from vista_examenes where cod_turno = '" & cbxTurnoFiltrar.SelectedValue & "'"
                Else
                    cadenaSQL = "select * from vista_examenes where cod_turno = '" & cbxTurnoFiltrar.SelectedValue & "'"
                End If
            End If
        End If

        Recuperar(cadenaSQL, tabla)
        dgvExamenes.DataSource = tabla
        dgvExamenes.AllowUserToAddRows = False
        dgvExamenes.AllowUserToDeleteRows = False
        dgvExamenes.Columns("nro_legajo_a").Visible = False
        dgvExamenes.Columns("cod_turno").Visible = False
        dgvExamenes.Columns("cod_mat").Visible = False
    End Sub

    Private Sub frmExamenes_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CargarGrilla()
    End Sub

    Private Sub btnTodos_Click(sender As Object, e As EventArgs) Handles btnTodos.Click
        CargarGrilla()
    End Sub

    Private Sub EliminarExamenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarExamenToolStripMenuItem.Click
        Dim cadenaSQL As String

        cod_materia_Selec = dgvExamenes.CurrentRow.Cells("cod_mat").Value
        cod_turno_Selec = dgvExamenes.CurrentRow.Cells("cod_turno").Value
        nro_legajo_alumno_Selec = dgvExamenes.CurrentRow.Cells("nro_legajo_a").Value
        año_Selec = dgvExamenes.CurrentRow.Cells("año").Value

        cadenaSQL = "delete from examenes where cod_mat = '" & cod_materia_Selec & "' and cod_turno = '" & cod_turno_Selec & "' and año = " & año_Selec & " and nro_legajo_a = " & nro_legajo_alumno_Selec
        Ejecutar(cadenaSQL)
        MessageBox.Show("Examen eliminado!.", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        frmReporteExamenes.ShowDialog()
    End Sub
End Class