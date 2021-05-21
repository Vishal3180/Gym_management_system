Imports System.Data.Sql
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class payfees
    Dim sqlcon As New SqlConnection
    Dim cmd As New SqlCommand
    Dim command As SqlCommand
    Sub reload()
        Dim con As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("Select Id,Name,Total_Fees,Pay_Fees,Pending_fees,Pay_Date from Registration where Pending_fees>0", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub

    Private Sub payfees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VishalDataSet4.Registration' table. You can move, or remove it, as needed.
        ' Me.RegistrationTableAdapter.Fill(Me.VishalDataSet4.Registration)
        reload()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Dim con As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("update Registration set Name='" + Txtname.Text + "',Total_Fees='" + Txttotalfees.Text + "',Pay_Fees='" + Txtpayfees.Text + "',Pending_fees='" + Txtpendingfees.Text + "',Pay_Date='" + Date_pay.Value + "'where Id=@id", con)
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Txtid.Text

        cmd.ExecuteNonQuery()
        MessageBox.Show("Date is updated...!!!")
        reload()
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
       
    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Txtid.Enabled = False
        Txtpayfees.Text = ""

        Try
            Dim i As Integer = e.RowIndex
            Dim selectedRow As New DataGridViewRow
            selectedRow = DataGridView1.Rows(i)
            Txtid.Text = selectedRow.Cells(0).Value.ToString
            Txtname.Text = selectedRow.Cells(1).Value.ToString
            Txttotalfees.Text = selectedRow.Cells(2).Value.ToString
            Txtpendingfees.Text = selectedRow.Cells(4).Value.ToString
            Date_pay.Text = selectedRow.Cells(5).Value.ToString


        Catch EX As Exception
            MessageBox.Show(EX.Message)
        End Try
    End Sub

    Private Sub Txtpayfees_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpayfees.Leave
        Txtpendingfees.Text = (CInt(Txtpendingfees.Text) - CInt(Txtpayfees.Text))
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class