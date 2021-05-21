Imports System.Data.Sql
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class login

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Txtpassword.UseSystemPasswordChar = True Then
            Txtpassword.UseSystemPasswordChar = False
        Else
            Txtpassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub Btnlogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from login where username='" + Txtuser.Text + "' and password='" + Txtpassword.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)
        If (dt.Rows.Count > 0) Then
            MessageBox.Show(" You are Logined as " + dt.Rows(0)(1))

            mdi.ShowDialog()

        Else
            MessageBox.Show("User name & passwrod incorrect ")
        End If

        Txtuser.Text = ""
        Txtpassword.Text = ""
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class