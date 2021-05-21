Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Public Class critalreportdetailmembers
    Dim con As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")


    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Try
            con.Open()
            Dim ed As New showmemberditals 'crystal Report
            Dim cmd As New SqlCommand
            Dim query As String = "SELECT Name, Address, Mob_no, DOB, Date, Document_verifiction FROM Registration"
            Dim ad As New SqlDataAdapter
            Dim das As New gym() 'dataset
            cmd.Connection = con
            ad.SelectCommand = cmd
            cmd.CommandText = query
            cmd.CommandType = CommandType.Text
            ad.Fill(das, "Registration1")
            ed.SetDataSource(das)
            CrystalReportViewer1.ReportSource = ed
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class