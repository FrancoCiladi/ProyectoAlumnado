Public Class frmAltaMateria
    Private Sub frmAltaMateria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim cadenaSQL As String
        Dim tabla As DataTable

        cadenaSQL = "select * from Profesores order by ape_nomb asc"
        tabla = New DataTable()
        Recuperar(cadenaSQL, tabla)
        cbxProfesor.DataSource = tabla
        cbxProfesor.DisplayMember = "ape_nomb"
        cbxProfesor.ValueMember = "nro_legajo_p"
        cbxProfesor.DropDownStyle = ComboBoxStyle.DropDownList
        cbxProfesor.SelectedIndex = 0


        If Operacion = "MODIFICAR" Then
            cadenaSQL = "select * from materias where cod_materia = '" & cod_materia_Selec & "'"
            Recuperar(cadenaSQL, tabla)

            mskCodMat.Text = tabla.Rows(0)("cod_materia").ToString()
            txtDescMateria.Text = tabla.Rows(0)("desc_mat").ToString()
            txtDescCarrera.Text = tabla.Rows(0)("desc_carrera").ToString()
            cbxProfesor.SelectedValue = tabla.Rows(0)("nro_legajo_p").ToString()

        Else
            Operacion = "ALTA"

            mskCodMat.Text = String.Empty
            txtDescMateria.Text = String.Empty
            txtDescCarrera.Text = String.Empty
            cbxProfesor.SelectedIndex = 0
        End If

    End Sub

    Private Function Verificar() As Boolean
        Dim ok As Boolean = False
        Dim cadenaSQL As String
        Dim tabla As DataTable = New DataTable

        If (mskCodMat.MaskCompleted) Then
            If (txtDescMateria.Text.Trim <> String.Empty) Then
                If txtDescCarrera.Text.Trim <> String.Empty Then

                    If Operacion = "ALTA" Then
                        cadenaSQL = "select * from materias where cod_materia = 'MA" & mskCodMat.Text & "'"
                    Else
                        cadenaSQL = "select * from materias where cod_materia <> 'MA" & mskCodMat.Text & "' and desc_mat = '" & txtDescMateria.Text & "' and nro_legajo_p = " & cbxProfesor.SelectedValue
                    End If
                    Recuperar(cadenaSQL, tabla)
                    If tabla.Rows.Count = 0 Then
                        ok = True
                    Else
                        MessageBox.Show("Ya se encuentra registrada una materia con el cod. ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mskCodMat.Focus()
                    End If
                Else
                    MessageBox.Show("Debe completar la descripcion de carrera", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtDescCarrera.Focus()
                End If
            Else
                MessageBox.Show("Debe completar la descripcion de materia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDescMateria.Focus()
            End If
        Else
            MessageBox.Show("Debe completar el codigo de materia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mskCodMat.Focus()
        End If

        Return ok
    End Function

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim cadenaSQL As String

        If Verificar() Then
            If Operacion = "ALTA" Then
                cadenaSQL = "insert into Materias (cod_materia, desc_mat, desc_carrera, nro_legajo_p) values"
                cadenaSQL = cadenaSQL & " ('MA" & mskCodMat.Text & "', '" & txtDescMateria.Text & "', '" & txtDescCarrera.Text.ToUpper() & "', " & cbxProfesor.SelectedValue & ")"

                Ejecutar(cadenaSQL)

                MessageBox.Show("Carga Realizada con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cadenaSQL = "update Materias set cod_materia = 'MA" & mskCodMat.Text & "',"
                cadenaSQL = cadenaSQL & "desc_mat = '" & txtDescMateria.Text & "',"
                cadenaSQL = cadenaSQL & "desc_carrera = '" & txtDescCarrera.Text.ToUpper & "',"
                cadenaSQL = cadenaSQL & "nro_legajo_p = " & cbxProfesor.SelectedValue & ""
                cadenaSQL = cadenaSQL & " where cod_materia = '" & cod_materia_Selec & "'"

                Ejecutar(cadenaSQL)
                MessageBox.Show("Modificacion Realizada con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class