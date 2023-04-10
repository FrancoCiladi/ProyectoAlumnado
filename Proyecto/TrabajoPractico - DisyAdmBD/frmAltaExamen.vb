Public Class frmAltaExamen
    Private Sub frmAltaExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim cadenaSQL As String
        Dim tabla As DataTable

        cadenaSQL = "select * from Materias order by cod_materia asc"
        tabla = New DataTable()
        Recuperar(cadenaSQL, tabla)
        cbxMateria.DataSource = tabla
        cbxMateria.DisplayMember = "desc_mat"
        cbxMateria.ValueMember = "cod_materia"
        cbxMateria.DropDownStyle = ComboBoxStyle.DropDownList
        cbxMateria.SelectedIndex = 0

        cadenaSQL = "select * from Turnos order by cod_turno asc"
        tabla = New DataTable()
        Recuperar(cadenaSQL, tabla)
        cbxTurno.DataSource = tabla
        cbxTurno.DisplayMember = "desc_turno"
        cbxTurno.ValueMember = "cod_turno"
        cbxTurno.DropDownStyle = ComboBoxStyle.DropDownList
        cbxTurno.SelectedIndex = 0

        dtpFechaInscripcion.MaxDate = DateTime.Today
        dtpFechaInscripcion.Value = DateTime.Today

        If Operacion = "ALTA" Then
            mskNroLegAlumno.Text = String.Empty
            cbxMateria.SelectedIndex = 0
            cbxTurno.SelectedIndex = 0
            dtpFechaInscripcion.Value = DateTime.Today
            mskNota.Text = String.Empty
        Else
            cadenaSQL = "select * from examenes where nro_legajo_a = " & nro_legajo_alumno_Selec & " and año = " & año_Selec & " and cod_mat = '" & cod_materia_Selec & "' and cod_turno = '" & cod_turno_Selec & "'"
            Recuperar(cadenaSQL, tabla)

            mskNroLegAlumno.Text = tabla.Rows(0)("nro_legajo_a").ToString
            cbxMateria.SelectedValue = tabla.Rows(0)("cod_mat").ToString
            cbxTurno.SelectedValue = tabla.Rows(0)("cod_turno").ToString
            dtpFechaInscripcion.Value = tabla.Rows(0)("fecha_inscripcion").ToString
            mskNota.Text = tabla.Rows(0)("nota").ToString
        End If
    End Sub

    Private Function Verificar() As Boolean
        Dim ok As Boolean = False
        Dim cadenaSQL As String
        Dim tabla As DataTable = New DataTable

        If VerificarPlanificacionExamen() Then

            If mskNroLegAlumno.MaskCompleted Then
                If Operacion = "ALTA" Then
                    cadenaSQL = "select * from examenes where nro_legajo_a = " & mskNroLegAlumno.Text & " and año = 2022 and cod_mat = '" & cbxMateria.SelectedValue & "' and cod_turno = '" & cbxTurno.SelectedValue & "'"
                Else
                    cadenaSQL = "select * from examenes where nro_legajo_a = " & mskNroLegAlumno.Text & " and año = 2022 and cod_mat = '" & cbxMateria.SelectedValue & "' and cod_turno = '" & cbxTurno.SelectedValue & "' and nota <> '" & mskNota.Text & "'"
                End If
                Recuperar(cadenaSQL, tabla)
                If tabla.Rows.Count = 0 Then
                    If Operacion = "ALTA" Then
                        cadenaSQL = "select * from examenes where nro_legajo_a = " & mskNroLegAlumno.Text & " and cod_mat = '" & cbxMateria.SelectedValue & "' and nota <= 6"
                        Recuperar(cadenaSQL, tabla)
                        If tabla.Rows.Count = 0 Then
                            ok = True
                        Else
                            MessageBox.Show("El alumno ya aprobo la materia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        ok = True
                    End If
                Else
                    MessageBox.Show("Ya se encuentra registrado un examen con esos datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Debe completar el nro. de legajo del alumno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                mskNroLegAlumno.Focus()
            End If

        End If
        Return ok
    End Function

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim cadenaSQL As String

        If Verificar() Then
            If Operacion = "ALTA" Then
                cadenaSQL = "insert into examenes (nro_legajo_a, cod_mat, cod_turno, año, fecha_inscripcion, nota) values "
                cadenaSQL = cadenaSQL & " ( " & mskNroLegAlumno.Text & ", '" & cbxMateria.SelectedValue & "', '" & cbxTurno.SelectedValue & "', 2022, '" & dtpFechaInscripcion.Value.ToShortDateString() & "', "
                If mskNota.Text.Trim = String.Empty Then
                    cadenaSQL = cadenaSQL & "NULL)"
                Else
                    cadenaSQL = cadenaSQL & " " & mskNota.Text & ")"
                End If

                Ejecutar(cadenaSQL)
                MessageBox.Show("Examen cargado con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cadenaSQL = "update examenes set nro_legajo_a = " & mskNroLegAlumno.Text & ","
                cadenaSQL = cadenaSQL & "cod_mat = '" & cbxMateria.SelectedValue & "',"
                cadenaSQL = cadenaSQL & "cod_turno = '" & cbxTurno.SelectedValue & "',"
                cadenaSQL = cadenaSQL & "año = 2022,"
                cadenaSQL = cadenaSQL & "fecha_inscripcion = '" & dtpFechaInscripcion.Value.ToShortDateString() & "',"
                If mskNota.Text.Trim <> String.Empty Then
                    cadenaSQL = cadenaSQL & "nota = " & mskNota.Text & " "
                Else
                    cadenaSQL = cadenaSQL & "nota= NULL "
                End If
                cadenaSQL = cadenaSQL & " where nro_legajo_a = " & nro_legajo_alumno_Selec & " and año = " & año_Selec & " and cod_mat = '" & cod_materia_Selec & "' and cod_turno = '" & cod_turno_Selec & "'"
                Ejecutar(cadenaSQL)
                MessageBox.Show("Examen modificado con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Private Function VerificarPlanificacionExamen() As Boolean
        Dim ok As Boolean
        Dim cadenaSQL As String
        Dim tabla As DataTable = New DataTable
        Dim fecha_ins As DateTime
        Dim fecha_exa As DateTime

        cadenaSQL = "select * from planificacion where cod_mat = '" & cbxMateria.SelectedValue & "' and cod_turno = '" & cbxTurno.SelectedValue & "'"
        Recuperar(cadenaSQL, tabla)
        If tabla.Rows.Count = 1 Then
            fecha_exa = tabla.Rows(0)("fecha_examen").ToString
            fecha_ins = dtpFechaInscripcion.Value
            If DateTime.Compare(fecha_ins, fecha_exa) < 0 Then
                ok = True
            Else
                MessageBox.Show("La fecha de inscripcion debe ser anterior al examen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No se encuentra habilitado un examen para la materia y turnos elegidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return ok
    End Function


End Class