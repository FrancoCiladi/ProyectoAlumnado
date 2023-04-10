Public Class frmTurnos
    Private Sub frmTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim cadenaSQL As String
        Dim tabla As DataTable

        cadenaSQL = "select * from Turnos order by cod_turno asc"
        tabla = New DataTable()
        Recuperar(cadenaSQL, tabla)
        cbxTurno.DataSource = tabla
        cbxTurno.DisplayMember = "desc_turno"
        cbxTurno.ValueMember = "cod_turno"
        cbxTurno.DropDownStyle = ComboBoxStyle.DropDownList
        cbxTurno.SelectedIndex = 0

        cadenaSQL = "select * from materias order by cod_materia asc"
        tabla = New DataTable
        Recuperar(cadenaSQL, tabla)
        cbxMateria.DataSource = tabla
        cbxMateria.DisplayMember = "desc_mat"
        cbxMateria.ValueMember = "cod_materia"
        cbxMateria.DropDownStyle = ComboBoxStyle.DropDownList
        cbxMateria.SelectedIndex = 0

        cbxConsulta.Items.Add("Seleccione...")
        cbxConsulta.Items.Add("Ver alumnos inscriptos")
        cbxConsulta.Items.Add("Ver alumnos presentes en turnos")
        cbxConsulta.Items.Add("Ver porcentajes de alumnos aprobados")
        cbxConsulta.Items.Add("Ver materias, profesores y fechas de examen")
        cbxConsulta.SelectedIndex = 0

        chkTodosTurnos.Checked = True
        chkTodasMaterias.Checked = True

        CargarGrilla()

    End Sub

    Private Sub CargarGrilla()
        Dim cadenaSQL As String
        Dim tabla As DataTable
        Dim aluPresentes As Integer
        Dim aluAprobados As Integer
        Dim aluAprobadosPorc As Double
        tabla = New DataTable()

        dgvTurnos.AllowUserToAddRows = False
        dgvTurnos.AllowUserToDeleteRows = False


        Select Case cbxConsulta.SelectedIndex
            Case 0
                lblAux.Visible = False
                cadenaSQL = "select * from vista_turnos"
                Recuperar(cadenaSQL, tabla)
                dgvTurnos.DataSource = tabla
                dgvTurnos.Columns("cod_turno").Visible = False
                dgvTurnos.Columns("cod_materia").Visible = False
            Case 1
                lblAux.Visible = False
                If chkTodasMaterias.Checked And chkTodosTurnos.Checked Then
                    cadenaSQL = "select * from vista_alumnos_inscriptos"
                    Recuperar(cadenaSQL, tabla)
                    dgvTurnos.DataSource = tabla
                    dgvTurnos.Columns("cod_turno").Visible = False
                    dgvTurnos.Columns("cod_materia").Visible = False
                    If tabla.Rows.Count = 0 Then
                        MessageBox.Show("No se encontraron registros.")
                    End If
                Else
                    If chkTodosTurnos.Checked = False And chkTodasMaterias.Checked = False Then
                        cadenaSQL = "select * from vista_alumnos_inscriptos where cod_materia = '" & cbxMateria.SelectedValue & "' and cod_turno = '" & cbxTurno.SelectedValue & "'"
                        Recuperar(cadenaSQL, tabla)
                        dgvTurnos.DataSource = tabla
                        dgvTurnos.Columns("cod_turno").Visible = False
                        dgvTurnos.Columns("cod_materia").Visible = False
                        If tabla.Rows.Count = 0 Then
                            MessageBox.Show("No se encontraron registros.")
                        End If
                    Else
                        If chkTodasMaterias.Checked And chkTodosTurnos.Checked = False Then
                            cadenaSQL = "select * from vista_alumnos_inscriptos where cod_turno = '" & cbxTurno.SelectedValue & "'"
                            Recuperar(cadenaSQL, tabla)
                            dgvTurnos.DataSource = tabla
                            dgvTurnos.Columns("cod_turno").Visible = False
                            dgvTurnos.Columns("cod_materia").Visible = False
                            If tabla.Rows.Count = 0 Then
                                MessageBox.Show("No se encontraron registros.")
                            End If
                        Else
                            cadenaSQL = "select * from vista_alumnos_inscriptos where cod_materia = '" & cbxMateria.SelectedValue & "'"
                            Recuperar(cadenaSQL, tabla)
                            dgvTurnos.DataSource = tabla
                            dgvTurnos.Columns("cod_turno").Visible = False
                            dgvTurnos.Columns("cod_materia").Visible = False
                            If tabla.Rows.Count = 0 Then
                                MessageBox.Show("No se encontraron registros.")
                            End If
                        End If
                    End If
                End If
            Case 2
                If chkTodasMaterias.Checked And chkTodosTurnos.Checked Then
                    cadenaSQL = "select * from vista_alumnos_presentes"
                    Recuperar(cadenaSQL, tabla)
                    dgvTurnos.DataSource = tabla
                    dgvTurnos.Columns("cod_turno").Visible = False
                    dgvTurnos.Columns("cod_materia").Visible = False
                    If tabla.Rows.Count = 0 Then
                        MessageBox.Show("No se encontraron registros.")
                    Else
                        aluPresentes = tabla.Rows.Count
                        lblAux.Text = "Alumnos Presentes: " & aluPresentes.ToString
                        lblAux.Visible = True
                    End If
                Else
                    If chkTodasMaterias.Checked = False And chkTodosTurnos.Checked = False Then
                        cadenaSQL = "select * from vista_alumnos_presentes where cod_materia = '" & cbxMateria.SelectedValue & "' and cod_turno = '" & cbxTurno.SelectedValue & "'"
                        Recuperar(cadenaSQL, tabla)
                        dgvTurnos.DataSource = tabla
                        dgvTurnos.Columns("cod_turno").Visible = False
                        dgvTurnos.Columns("cod_materia").Visible = False
                        If tabla.Rows.Count = 0 Then
                            MessageBox.Show("No se encontraron registros.")
                        Else
                            aluPresentes = tabla.Rows.Count
                            lblAux.Text = "Alumnos Presentes: " & aluPresentes.ToString
                            lblAux.Visible = True
                        End If
                    Else
                        If chkTodasMaterias.Checked And chkTodosTurnos.Checked = False Then
                            cadenaSQL = "select * from vista_alumnos_presentes where cod_turno = '" & cbxTurno.SelectedValue & "'"
                            Recuperar(cadenaSQL, tabla)
                            dgvTurnos.DataSource = tabla
                            dgvTurnos.Columns("cod_turno").Visible = False
                            dgvTurnos.Columns("cod_materia").Visible = False
                            If tabla.Rows.Count = 0 Then
                                MessageBox.Show("No se encontraron registros.")
                            Else
                                aluPresentes = tabla.Rows.Count
                                lblAux.Text = "Alumnos Presentes: " & aluPresentes.ToString
                                lblAux.Visible = True
                            End If
                        Else
                            cadenaSQL = "select * from vista_alumnos_presentes where cod_materia = '" & cbxMateria.SelectedValue & "'"
                            Recuperar(cadenaSQL, tabla)
                            dgvTurnos.DataSource = tabla
                            dgvTurnos.Columns("cod_turno").Visible = False
                            dgvTurnos.Columns("cod_materia").Visible = False
                            If tabla.Rows.Count = 0 Then
                                MessageBox.Show("No se encontraron registros.")
                            Else
                                aluPresentes = tabla.Rows.Count
                                lblAux.Text = "Alumnos Presentes: " & aluPresentes.ToString
                                lblAux.Visible = True
                            End If
                        End If
                    End If
                End If
            Case 3
                lblAux.Visible = False
                If chkTodasMaterias.Checked And chkTodosTurnos.Checked Then
                    cadenaSQL = "select * from vista_alumnos_aprobados order by Nota desc"
                    Recuperar(cadenaSQL, tabla)
                    dgvTurnos.DataSource = tabla
                    dgvTurnos.Columns("cod_turno").Visible = False
                    dgvTurnos.Columns("cod_materia").Visible = False
                    If tabla.Rows.Count = 0 Then
                        MessageBox.Show("No se encontraron registros.")
                    Else
                        cadenaSQL = "select count(Alumno) as cant from vista_alumnos_aprobados"
                        Recuperar(cadenaSQL, tabla)
                        aluPresentes = Integer.Parse(tabla.Rows(0)("cant").ToString)
                        cadenaSQL = "select count(Alumno) as cant from vista_alumnos_aprobados where Nota >= 7"
                        Recuperar(cadenaSQL, tabla)
                        aluAprobados = Integer.Parse(tabla.Rows(0)("cant").ToString)
                        aluAprobadosPorc = ((aluAprobados / aluPresentes) * 100)
                        lblAux.Text = "Aprobados: " & aluAprobadosPorc.ToString("00.0") & "%"
                        lblAux.Visible = True
                    End If
                Else
                    If chkTodasMaterias.Checked = False And chkTodosTurnos.Checked = False Then
                        cadenaSQL = "select * from vista_alumnos_aprobados where cod_materia = '" & cbxMateria.SelectedValue & "' and cod_turno = '" & cbxTurno.SelectedValue & "' order by Nota desc"
                        Recuperar(cadenaSQL, tabla)
                        dgvTurnos.DataSource = tabla
                        dgvTurnos.Columns("cod_turno").Visible = False
                        dgvTurnos.Columns("cod_materia").Visible = False
                        If tabla.Rows.Count = 0 Then
                            MessageBox.Show("No se encontraron registros.")
                        Else
                            cadenaSQL = "select count(Alumno) as cant from vista_alumnos_aprobados where cod_materia = '" & cbxMateria.SelectedValue & "' and cod_turno = '" & cbxTurno.SelectedValue & "'"
                            Recuperar(cadenaSQL, tabla)
                            aluPresentes = Integer.Parse(tabla.Rows(0)("cant").ToString)
                            cadenaSQL = "select count(Alumno) as cant from vista_alumnos_aprobados where cod_materia = '" & cbxMateria.SelectedValue & "' and cod_turno = '" & cbxTurno.SelectedValue & "' and Nota >= 7"
                            Recuperar(cadenaSQL, tabla)
                            aluAprobados = Integer.Parse(tabla.Rows(0)("cant").ToString)
                            aluAprobadosPorc = ((aluAprobados / aluPresentes) * 100)
                            lblAux.Text = "Aprobados: " & aluAprobadosPorc.ToString("00.0") & "%"
                            lblAux.Visible = True
                        End If
                    Else
                        If chkTodasMaterias.Checked And chkTodosTurnos.Checked = False Then
                            cadenaSQL = "select * from vista_alumnos_aprobados where cod_turno = '" & cbxTurno.SelectedValue & "' order by Nota desc"
                            Recuperar(cadenaSQL, tabla)
                            dgvTurnos.DataSource = tabla
                            dgvTurnos.Columns("cod_turno").Visible = False
                            dgvTurnos.Columns("cod_materia").Visible = False
                            If tabla.Rows.Count = 0 Then
                                MessageBox.Show("No se encontraron registros.")
                            Else
                                cadenaSQL = "select count(Alumno) as cant from vista_alumnos_aprobados where cod_turno = '" & cbxTurno.SelectedValue & "'"
                                Recuperar(cadenaSQL, tabla)
                                aluPresentes = Integer.Parse(tabla.Rows(0)("cant").ToString)
                                cadenaSQL = "select count(Alumno) as cant from vista_alumnos_aprobados where cod_turno = '" & cbxTurno.SelectedValue & "' and Nota >= 7"
                                Recuperar(cadenaSQL, tabla)
                                aluAprobados = Integer.Parse(tabla.Rows(0)("cant").ToString)
                                aluAprobadosPorc = ((aluAprobados / aluPresentes) * 100)
                                lblAux.Text = "Aprobados: " & aluAprobadosPorc.ToString("00.0") & "%"
                                lblAux.Visible = True
                            End If
                        Else
                            cadenaSQL = "select * from vista_alumnos_aprobados where  cod_materia = '" & cbxMateria.SelectedValue & "' order by Nota desc"
                            Recuperar(cadenaSQL, tabla)
                            dgvTurnos.DataSource = tabla
                            dgvTurnos.Columns("cod_turno").Visible = False
                            dgvTurnos.Columns("cod_materia").Visible = False
                            If tabla.Rows.Count = 0 Then
                                MessageBox.Show("No se encontraron registros.")
                            Else
                                cadenaSQL = "select count(Alumno) as cant from vista_alumnos_aprobados where  cod_materia = '" & cbxMateria.SelectedValue & "'"
                                Recuperar(cadenaSQL, tabla)
                                aluPresentes = Integer.Parse(tabla.Rows(0)("cant").ToString)
                                cadenaSQL = "select count(Alumno) as cant from vista_alumnos_aprobados where  cod_materia = '" & cbxMateria.SelectedValue & "' and Nota >= 7"
                                Recuperar(cadenaSQL, tabla)
                                aluAprobados = Integer.Parse(tabla.Rows(0)("cant").ToString)
                                aluAprobadosPorc = ((aluAprobados / aluPresentes) * 100)
                                lblAux.Text = "Aprobados: " & aluAprobadosPorc.ToString("00.0") & "%"
                                lblAux.Visible = True
                            End If
                        End If
                    End If
                End If
            Case 4
                lblAux.Visible = False
                If chkTodosTurnos.Checked Then
                    cadenaSQL = "select * from vista_profesores_examenes order by cod_turno asc"
                    Recuperar(cadenaSQL, tabla)
                    dgvTurnos.DataSource = tabla
                    dgvTurnos.Columns("cod_turno").Visible = False
                    dgvTurnos.Columns("cod_materia").Visible = False
                    If tabla.Rows.Count = 0 Then
                        MessageBox.Show("No se encontraron registros.")
                    End If
                Else
                    cadenaSQL = "select * from vista_profesores_examenes where cod_turno = '" & cbxTurno.SelectedValue & "' order by cod_turno asc"
                    Recuperar(cadenaSQL, tabla)
                    dgvTurnos.DataSource = tabla
                    dgvTurnos.Columns("cod_turno").Visible = False
                    dgvTurnos.Columns("cod_materia").Visible = False
                    If tabla.Rows.Count = 0 Then
                        MessageBox.Show("No se encontraron registros.")
                    End If
                End If
        End Select

    End Sub

    Private Sub chkTodosTurnos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodosTurnos.CheckedChanged
        If chkTodosTurnos.Checked = True Then
            cbxTurno.Enabled = False
            chkTodosTurnos.Enabled = True
        Else
            cbxTurno.Enabled = True
            chkTodosTurnos.Checked = False
        End If
    End Sub



    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        CargarGrilla()
    End Sub

    Private Sub chkTodasMaterias_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodasMaterias.CheckedChanged
        If chkTodasMaterias.Checked Then
            cbxMateria.Enabled = False
        Else
            cbxMateria.Enabled = True
            chkTodasMaterias.Enabled = True
        End If
    End Sub

    Private Sub cbxConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxConsulta.SelectedIndexChanged
        If cbxConsulta.SelectedIndex = 4 Then
            cbxMateria.Enabled = False
            chkTodasMaterias.Enabled = False
        Else
            cbxMateria.Enabled = False
            chkTodasMaterias.Enabled = True
        End If
    End Sub
End Class