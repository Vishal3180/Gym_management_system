Imports System.Data.Sql
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Maintance
    Dim sqlcon As New SqlConnection
    Dim cmd As New SqlCommand
    Dim command As SqlCommand
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub addequipement()
        
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlcon As New SqlConnection
        Dim cmd As New SqlCommand

        sqlcon.ConnectionString = "Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True"
        sqlcon.Open()
        cmd.Connection = sqlcon
        cmd.CommandText = "insert into Maintance(Name,Damages,Amount,Date) values('" + Cmboname.Text + "', '" + Txtdamage.Text + "','" + Txtamount.Text + "','" + txtdate.Value + "')"
        cmd.Parameters.AddWithValue("@Date", Convert.ToDateTime(txtdate.Value))

        cmd.ExecuteNonQuery()

        sqlcon.Close()
        MessageBox.Show("Data is successfuly..!!!")
    End Sub

    Private Sub Cmboname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmboname.SelectedIndexChanged
        addequipement()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Maintance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim row_count As Integer
            Dim con As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
            con.Open()
            Dim cmd2 As New SqlCommand("select count(Name) from equipment", con)
            row_count = IIf(IsDBNull(cmd2.ExecuteScalar), "", cmd2.ExecuteScalar)
            Dim cmd As New SqlCommand("select Name from equipment ", con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            Dim i As Integer = 0
            While i < row_count
                Cmboname.Items.Add(table.Rows(i)(0).ToString())
                i = i + 1

            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class