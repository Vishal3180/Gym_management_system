Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Public Class showregistraion

    Private Sub showregistraion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Try
            Dim con As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
            con.Open()
            Dim ed As New Registration() 'crystal Report
            Dim cmd As New SqlCommand
            Dim query As String = "SELECT Name, Mob_no, Date, Total_Fees, Pending_fees FROM Registration"
            Dim ad As New SqlDataAdapter
            Dim das As New gym() 'dataset
            cmd.Connection = con
            ad.SelectCommand = cmd
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text
            ad.Fill(das, "Registration")
            ed.SetDataSource(das)
            CrystalReportViewer1.ReportSource = ed
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class