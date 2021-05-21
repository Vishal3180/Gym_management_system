Imports System.Data.Sql
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class datagripview
    Dim total As Integer
    Dim sqlcon As New SqlConnection
    Dim cmd As New SqlCommand
    Dim command As SqlCommand
    Private Sub datagripview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VishalDataSet1.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter1.Fill(Me.VishalDataSet1.Registration)
        'TODO: This line of code loads data into the 'VishalDataSet.Registration' table. You can move, or remove it, as needed.
    End Sub
    Sub clear()
        Txtid.Text = ""
        Txtname.Text = ""
        Txtaddress.Text = ""
        Txtmobno.Text = ""
        Txttotalfees.Text = ""
        TxtPayfees.Text = ""
        Txtpendingfees.Text = ""
        RbYes.Checked = False
        RbNo.Checked = False
        txtmorning.Checked = False
        Txtevening.Checked = False
        Cmboxdocument.Text = ""
        Cmboxtimeduration.Text = ""
    End Sub
    Sub reload()
        Dim con As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("Select * from Registration", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Txtid.Enabled = False
        Try
            Dim i As Integer = e.RowIndex
            Dim selectedRow As New DataGridViewRow
            selectedRow = DataGridView1.Rows(i)
            Txtid.Text = selectedRow.Cells(0).Value.ToString
            Txtname.Text = selectedRow.Cells(1).Value.ToString
            Txtaddress.Text = selectedRow.Cells(2).Value.ToString
            Txtmobno.Text = selectedRow.Cells(3).Value.ToString
            txtdata.Value = selectedRow.Cells(4).Value.ToString
            txtdob.Value = selectedRow.Cells(5).Value.ToString

            Txttotalfees.Text = selectedRow.Cells(6).Value.ToString
           
            TxtPayfees.Text = selectedRow.Cells(7).Value.ToString
            Txtpendingfees.Text = selectedRow.Cells(8).Value.ToString

            Dim status As String
            status = selectedRow.Cells(9).Value.ToString
            If status = "Morning" Then
                txtmorning.Checked = True
            Else
                txtmorning.Checked = False
            End If

            If status = "Evening" Then
                Txtevening.Checked = True
            Else
                Txtevening.Checked = False
            End If

            If status = "Morning&Evening" Then
                txtmorning.Checked = True
                Txtevening.Checked = True
            End If

            Dim member As String
            member = selectedRow.Cells(10).Value.ToString
            If member = "Yes" Then
                RbYes.Checked = True
            Else
                RbNo.Checked = True
            End If
            Cmboxtimeduration.Text = selectedRow.Cells(11).Value.ToString
            Cmboxdocument.Text = selectedRow.Cells(12).Value.ToString

            reload()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        Try
            Dim con As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
            con.Open()
            Dim cmd As New SqlCommand("delete from Registration where Id=@Id", con)
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Txtid.Text
            cmd.ExecuteNonQuery()
            MessageBox.Show("Date is deleted..!!")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Close()

    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Dim member As String
        If RbYes.Checked = True Then
            member = "Yes"
        Else
            member = "No"
        End If

        Dim status As String = ""
        If txtmorning.Checked = True Then

            status = "Morning"
            'Else
            '    txtmorning.Text = False
        End If
        If Txtevening.Checked = True Then

            status = "Evening"
            'Else
            '    Txtevening.Text = False
        End If
        If txtmorning.Checked = True And Txtevening.Checked = True Then
            status = "Morning&Evening"
        End If
        Dim con As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("update Registration set Name='" + Txtname.Text + "' ,Address='" + Txtaddress.Text + "',MOb_no='" + Txtmobno.Text + "',Date='" + txtdata.Value + "',DOB='" + txtdob.Value + "',Total_Fees='" + Txttotalfees.Text + "',Pay_Fees='" + TxtPayfees.Text + "',Pending_fees='" + Txtpendingfees.Text + "',Batch_time='" + status + "',Membership='" + member + "',Time_Duration='" + Cmboxtimeduration.Text + "',Document_verifiction='" + Cmboxdocument.Text + "' where Id=@id", con)
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Txtid.Text

        cmd.ExecuteNonQuery()
        MessageBox.Show("Date is updated...!!!")
        reload()

        con.Close()



    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtserch.TextChanged
        sqlcon.ConnectionString = "Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True"
        sqlcon.Open()
        Dim str As String = "select * from Registration where name like '" + Txtserch.Text + "%' "
        Dim da = New SqlDataAdapter(str, sqlcon)
        Dim ds As New DataSet
        da.Fill(ds, "Registration")

        DataGridView1.DataSource = ds.Tables("Registration")
        da.Dispose()
        sqlcon.Close()

        clear()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Txtmobno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtmobno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                MessageBox.Show("Enter only number:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Txtmobno.Text = ""

            End If
        End If
    End Sub

    Private Sub RbNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbNo.CheckedChanged
        If RbNo.Checked = True Then
            Cmboxtimeduration.Enabled = False
            Cmboxtimeduration.Text = ""
        End If
    End Sub

    Private Sub RbYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbYes.CheckedChanged
        If RbYes.Checked = True Then
            Cmboxtimeduration.Enabled = True
        End If
    End Sub
End Class