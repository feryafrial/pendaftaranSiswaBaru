Imports Microsoft.Reporting.WinForms
Public Class frmLap

    Public Path As String
    Public DataReport As ReportDataSource

    Private Sub frmLap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.ReportPath = Path
        ReportViewer1.LocalReport.DataSources.Add(DataReport)
        ReportViewer1.LocalReport.Refresh()
    End Sub

End Class