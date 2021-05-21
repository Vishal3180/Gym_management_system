Imports System.Data.Sql
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Attendance

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub tb()

        'Btnouttime.Text = DateTime.Now.TimeOfDay.ToString()
    End Sub
    Private Sub Attendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'BtnIntime.Text = DateTime.Now.TimeOfDay.ToString()
        'Btnouttime.Text = DateTime.Now.TimeOfDay.ToString()
        '    lbldate.Text = DateTime.Now.ToShortDateString()
        '    Try
        '        Dim row_count As Integer
        '        Dim con As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
        '        con.Open()
        '        Dim cmd2 As New SqlCommand("select count(Name) from Registration", con)
        '        row_count = IIf(IsDBNull(cmd2.ExecuteScalar), "", cmd2.ExecuteScalar)
        '        Dim cmd As New SqlCommand("select Name from Registration ", con)
        '        Dim adapter As New SqlDataAdapter(cmd)
        '        Dim table As New DataTable
        '        adapter.Fill(table)
        '        con.Close()
        '        Dim i As Integer = 0
        '        While i < row_count
        '            Cmboname.Items.Add(table.Rows(i)(0).ToString())
        '            i = i + 1

        '        End While
        '    Catch ex As Exception

        '    End Try
        'End Sub

        'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIntime.Click
        '    'BtnIntime.Text = DateTime.Now.TimeOfDay.ToString()
        '    'Try
        '    'Dim time As String = DateTime.Now.TimeOfDay.ToString()
        '    Dim dat As DateTime
        '    dat = txtdate.Value
        '    Dim sts As Integer = 1
        '    Dim sqlcon As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
        '    sqlcon.Open()
        '    Dim cmd As New SqlCommand("INSERT INTO Attendance(Name,ToDay_Date,In_Time,Status)VALUES('" + Cmboname.Text + "',Convert(DateTime,@dat,103),Convert(DateTime,@dat,103),'" + Convert.ToInt32(sts) + "')", sqlcon)
        '    cmd.Parameters.AddWithValue("@dat", dat)
        '    cmd.Parameters.AddWithValue("@dat", dat)
        '    cmd.ExecuteNonQuery()
        '    sqlcon.Close()

        '    ' Catch ex As Exception
        '    'MessageBox.Show(ex.Message)
        '    ' End Try
        'End Sub

        'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnouttime.Click
        '    Dim sqlcon As New SqlConnection
        '    Dim cmd As New SqlCommand

        '    sqlcon.ConnectionString = "Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True"
        '    sqlcon.Open()
        '    Dim query As String
        '    Dim READER As SqlDataReader
        '    query = "update  Attendance set Name='" + Btnouttime.Text + "'where id='" + txtdate.Text + "'"
        '    sqlcon.Close()


        'End Sub

        'Private Sub Cmboname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class