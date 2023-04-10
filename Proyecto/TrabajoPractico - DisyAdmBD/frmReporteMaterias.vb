Public Class frmReporteMaterias
    Private Sub frmReporteMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim tabla As DataTable = New DataTable

        Recuperar(sqlInforme, tabla)

        ReportViewer1.LocalReport.ReportPath = "C:\Users\franc\Desktop\TrabajoPractico - DisyAdmBD\TrabajoPractico - DisyAdmBD\ReporteMaterias.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSetMaterias", tabla))



        Me.ReportViewer1.RefreshReport()
    End Sub
End Class