Imports System.Data.Sql
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Viewallmember
    Dim sqlcon As New SqlConnection
    Dim cmd As New SqlCommand
    Dim command As SqlCommand
    Private Sub Viewallmember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VishalDataSet6.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.VishalDataSet6.Registration)

    End Sub

    Private Sub Txtserch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtserch.TextChanged
        sqlcon.ConnectionString = "Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True"
        sqlcon.Open()
        Dim str As String = "select * from Registration where name like '" + Txtserch.Text + "%' "
        Dim da = New SqlDataAdapter(str, sqlcon)
        Dim ds As New DataSet
        da.Fill(ds, "Registration")

        DataGridView1.DataSource = ds.Tables("Registration")
        da.Dispose()
        sqlcon.Close()
    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        Me.Close()

    End Sub
End Class