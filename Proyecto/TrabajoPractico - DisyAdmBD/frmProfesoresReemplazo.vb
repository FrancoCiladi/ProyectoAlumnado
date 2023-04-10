Public Class frmProfesoresReemplazo
    Private Sub frmProfesoresReemplazo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub CargarGrilla()
        Dim cadenaSQL As String
        Dim tabla As DataTable

        tabla = New DataTable()

        cadenaSQL = "select * from vista_profesor_reemplazo where nro_legajo_p <> " & nro_legajo_profesor_Selec & " order by Profesor asc"

        Recuperar(cadenaSQL, tabla)
        dgvProfesorReemplazo.DataSource = tabla
        dgvProfesorReemplazo.AllowUserToAddRows = False
        dgvProfesorReemplazo.AllowUserToDeleteRows = False
        dgvProfesorReemplazo.Columns("nro_legajo_p").Visible = False
        dgvProfesorReemplazo.Columns("cod_titulo").Visible = False

    End Sub


    Private Sub frmProfesoresReemplazo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CargarGrilla()
    End Sub

    Private Sub btnReemplazar_Click(sender As Object, e As EventArgs) Handles btnReemplazar.Click
        Dim cadenaSQL As String
        If Not dgvProfesorReemplazo.CurrentRow Is Nothing Then
            nro_legajo_profesorReemplazo_Selec = dgvProfesorReemplazo.CurrentRow.Cells("nro_legajo_p").Value
            cadenaSQL = "update Materias set nro_legajo_p = " & nro_legajo_profesorReemplazo_Selec & " where nro_legajo_p = " & nro_legajo_profesor_Selec
            Ejecutar(cadenaSQL)
            MessageBox.Show("Se asigno un reemplazo a la/s materias!", "Operacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class