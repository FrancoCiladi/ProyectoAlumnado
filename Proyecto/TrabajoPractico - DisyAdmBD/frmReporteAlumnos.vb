Public Class frmReporteAlumnos
    Private Sub frmReporteAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim tabla As DataTable = New DataTable

        Recuperar(sqlInforme, tabla)

        ReportViewer1.LocalReport.ReportPath = "C:\Users\franc\Desktop\TrabajoPractico - DisyAdmBD\TrabajoPractico - DisyAdmBD\ReporteAlumnos.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", tabla))


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class