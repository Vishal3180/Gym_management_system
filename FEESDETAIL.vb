Imports System.Data.Sql
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class FEESDETAIL

    Sub reload()
        Dim con As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("Select Id,Name,Mob_no,Total_Fees,Pay_Fees,Pending_fees,Time_Duration,Pay_Date from Registration where Pending_fees>0", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub
    Private Sub FEESDETAIL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VishalDataSet7.Registration' table. You can move, or remove it, as needed.
        'Me.RegistrationTableAdapter.Fill(Me.VishalDataSet7.Registration)
        reload()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class