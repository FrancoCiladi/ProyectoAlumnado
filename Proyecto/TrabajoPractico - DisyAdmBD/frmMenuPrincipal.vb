Public Class frmMenuPrincipal
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnAlumnos_Click(sender As Object, e As EventArgs) Handles btnAlumnos.Click
        frmAlumnos.ShowDialog()
    End Sub

    Private Sub btnProfesores_Click(sender As Object, e As EventArgs) Handles btnProfesores.Click
        frmProfesores.ShowDialog()
    End Sub

    Private Sub btnMaterias_Click(sender As Object, e As EventArgs) Handles btnMaterias.Click
        frmMaterias.ShowDialog()
    End Sub

    Private Sub btnExamenes_Click(sender As Object, e As EventArgs) Handles btnExamenes.Click
        frmExamenes.ShowDialog()
    End Sub

    Private Sub btnTurnos_Click(sender As Object, e As EventArgs) Handles btnTurnos.Click
        frmTurnos.ShowDialog()
    End Sub
End Class
