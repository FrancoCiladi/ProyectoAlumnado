Public Class frmAltaProfesor
    Private Sub frmAltaProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim cadenaSQL As String
        Dim tabla As DataTable

        cadenaSQL = "select * from Tipo_Doc order by cod_doc asc"
        tabla = New DataTable()
        Recuperar(cadenaSQL, tabla)
        cbxTipoDoc.DataSource = tabla
        cbxTipoDoc.DisplayMember = "desc_doc"
        cbxTipoDoc.ValueMember = "cod_doc"
        cbxTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList
        cbxTipoDoc.SelectedIndex = 0

        cadenaSQL = "select * from Titulos order by cod_titulos asc"
        tabla = New DataTable()
        Recuperar(cadenaSQL, tabla)
        cbxTitulo.DataSource = tabla
        cbxTitulo.DisplayMember = "desc_titulo"
        cbxTitulo.ValueMember = "cod_titulos"
        cbxTitulo.DropDownStyle = ComboBoxStyle.DropDownList
        cbxTitulo.SelectedIndex = 0

        dtpFechaNac.MaxDate = DateTime.Today
        dtpFechaNac.Value = DateTime.Today

        If Operacion = "MODIFICAR" Then
            cadenaSQL = "select * from profesores where nro_legajo_p = " & nro_legajo_profesor_Selec
            Recuperar(cadenaSQL, tabla)

            txtApyNomProfesor.Text = tabla.Rows(0)("ape_nomb").ToString()
            cbxTipoDoc.SelectedValue = tabla.Rows(0)("cod_doc").ToString()
            txtNroDoc.Text = tabla.Rows(0)("nro_doc").ToString()
            txtDireccion.Text = tabla.Rows(0)("direccion").ToString()
            dtpFechaNac.Value = tabla.Rows(0)("fec_nac").ToString()
            txtEmail.Text = tabla.Rows(0)("email").ToString()
            txtTelefono.Text = tabla.Rows(0)("telefono").ToString()
            cbxTitulo.SelectedValue = tabla.Rows(0)("cod_titulo").ToString()
            If tabla.Rows(0)("sexo").ToString() = "M" Then
                rbMasculino.Checked = True
            Else
                rbFemenino.Checked = True
            End If

        Else
            Operacion = "ALTA"

            txtApyNomProfesor.Text = String.Empty
            cbxTipoDoc.SelectedIndex = 0
            txtNroDoc.Text = String.Empty
            txtDireccion.Text = String.Empty
            dtpFechaNac.Value = DateTime.Today
            cbxTitulo.SelectedIndex = 0
            rbCasado.Checked = True
            txtEmail.Text = String.Empty
            txtTelefono.Text = String.Empty
            rbMasculino.Checked = True
        End If

    End Sub

    Private Function Verificar() As Boolean
        Dim ok As Boolean = False
        Dim cadenaSQL As String
        Dim tabla As DataTable = New DataTable

        If (txtApyNomProfesor.Text.Trim <> String.Empty) Then
            If (txtNroDoc.Text.Trim <> String.Empty) Then
                If (txtDireccion.Text.Trim <> String.Empty) Then

                    If Operacion = "ALTA" Then
                        cadenaSQL = "select * from profesores where cod_doc = '" & cbxTipoDoc.SelectedValue & "' and nro_doc = " & txtNroDoc.Text & ""
                    Else
                        cadenaSQL = "select * from profesores where cod_doc = '" & cbxTipoDoc.SelectedValue & "' and nro_doc = " & txtNroDoc.Text & " and nro_legajo_p <> " & nro_legajo_profesor_Selec
                    End If
                    Recuperar(cadenaSQL, tabla)
                    If tabla.Rows.Count = 0 Then
                        ok = True
                    Else
                        MessageBox.Show("Ya se encuentra registrado/a un profesor con DNI y Tipo Doc identicos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    MessageBox.Show("Debe completar la direccion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtDireccion.Focus()
                End If
            Else
                MessageBox.Show("Debe completar el nro. de documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNroDoc.Focus()
            End If
        Else
            MessageBox.Show("Debe completar el apellido y nombre del profesor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtApyNomProfesor.Focus()
        End If

        Return ok
    End Function

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim cadenaSQL As String

        If Verificar() Then
            If Operacion = "ALTA" Then
                cadenaSQL = "insert into profesores (ape_nomb,nro_doc,direccion,cod_doc,fec_nac,cod_titulo,sexo,est_civil,email,telefono) values"
                cadenaSQL = cadenaSQL & "( '" & txtApyNomProfesor.Text & "', '" & txtNroDoc.Text & "', '" & txtDireccion.Text & "', '" & cbxTipoDoc.SelectedValue & "', '" & dtpFechaNac.Value.ToShortDateString() & "', '" & cbxTitulo.SelectedValue & "',"
                If rbMasculino.Checked Then
                    cadenaSQL = cadenaSQL & "'M',"
                    If rbCasado.Checked = True Then
                        cadenaSQL = cadenaSQL & "'CASADO',"
                    Else
                        cadenaSQL = cadenaSQL & "'SOLTERO',"
                    End If
                Else
                    cadenaSQL = cadenaSQL & "'F',"
                    If rbCasado.Checked = True = 0 Then
                        cadenaSQL = cadenaSQL & "'CASADA',"
                    Else
                        cadenaSQL = cadenaSQL & "'SOLTERA',"
                    End If
                End If
                If txtEmail.Text <> String.Empty Then
                    cadenaSQL = cadenaSQL & " '" & txtEmail.Text & "', "
                Else
                    cadenaSQL = cadenaSQL & "NULL,"
                End If
                If txtTelefono.Text <> String.Empty Then
                    cadenaSQL = cadenaSQL & " '" & txtTelefono.Text & "') "
                Else
                    cadenaSQL = cadenaSQL & "NULL)"
                End If

                Ejecutar(cadenaSQL)

                MessageBox.Show("Carga Realizada con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cadenaSQL = "update profesores set ape_nomb = '" & txtApyNomProfesor.Text & "',"
                cadenaSQL = cadenaSQL & "nro_doc = '" & txtNroDoc.Text & "',"
                cadenaSQL = cadenaSQL & "direccion = '" & txtDireccion.Text & "',"
                cadenaSQL = cadenaSQL & "cod_doc = '" & cbxTipoDoc.SelectedValue & "',"
                cadenaSQL = cadenaSQL & "fec_nac = '" & dtpFechaNac.Value.ToShortDateString() & "',"
                cadenaSQL = cadenaSQL & "cod_titulo = '" & cbxTitulo.SelectedValue & "',"
                If rbMasculino.Checked Then
                    cadenaSQL = cadenaSQL & "sexo = 'M',"
                    If rbCasado.Checked = True Then
                        cadenaSQL = cadenaSQL & "est_civil = 'CASADO',"
                    Else
                        cadenaSQL = cadenaSQL & "est_civil = 'SOLTERO',"
                    End If
                Else
                    cadenaSQL = cadenaSQL & "sexo = 'F',"
                    If rbCasado.Checked = True Then
                        cadenaSQL = cadenaSQL & "est_civil = 'CASADA',"
                    Else
                        cadenaSQL = cadenaSQL & "est_civil = 'SOLTERA',"
                    End If
                End If
                If txtEmail.Text <> String.Empty Then
                    cadenaSQL = cadenaSQL & "email = '" & txtEmail.Text & "', "
                Else
                    cadenaSQL = cadenaSQL & "email = NULL,"
                End If
                If txtTelefono.Text <> String.Empty Then
                    cadenaSQL = cadenaSQL & "telefono =  '" & txtTelefono.Text & "' "
                Else
                    cadenaSQL = cadenaSQL & "NULL"
                End If
                cadenaSQL = cadenaSQL & "where nro_legajo_p = " & nro_legajo_profesor_Selec

                Ejecutar(cadenaSQL)

                MessageBox.Show("Modificacion Realizada con exito!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub
End Class