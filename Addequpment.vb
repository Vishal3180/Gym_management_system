Imports System.Data.Sql
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Addequpment
    Dim sqlcon As New SqlConnection
    Dim cmd As New SqlCommand
    Dim command As SqlCommand
    Sub refresh_table()
        Txtid.Text = ""
        Txtname.Text = ""
        Txtperunitcost.Text = ""
        Txtquantity.Text = ""
        Txttotolcost.Text = ""
    End Sub
    Private Sub Addequpment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VishalDataSet5.equipment' table. You can move, or remove it, as needed.
        Me.EquipmentTableAdapter.Fill(Me.VishalDataSet5.equipment)

    End Sub
    Sub reload()
        Txtid.Enabled = False

        Dim con As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("Select * from equipment", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Txtid.Enabled = False

        Txttotolcost.Text = Txtquantity.Text * Txtperunitcost.Text

        Dim sqlcon As New SqlConnection
        Dim cmd As New SqlCommand

        sqlcon.ConnectionString = "Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True"
        sqlcon.Open()
        cmd.Connection = sqlcon
        cmd.CommandText = "insert into equipment values('" + Txtname.Text + "' ,'" + Txtquantity.Text + "', '" + Txtperunitcost.Text + "','" + Txttotolcost.Text + "')"
        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = Txtquantity.Text
        cmd.Parameters.Add("@Per_Unit_Cost", SqlDbType.Float).Value = Txtperunitcost.Text
        cmd.Parameters.Add("@Total_Cost", SqlDbType.Float).Value = Txttotolcost.Text

        cmd.ExecuteNonQuery()

        sqlcon.Close()
        MessageBox.Show("Data is successfuly..!!!")
        reload()
        refresh_table()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            sqlcon.ConnectionString = "Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True"
            sqlcon.Open()
            Dim query As String
            Dim READER As SqlDataReader
            query = "update  equipment set Name='" + Txtname.Text + "',Quantity='" + Txtquantity.Text + "',Per_Unit_Cost='" + Txtperunitcost.Text + "',Total_Cost='" + Txttotolcost.Text + "'where id='" + Txtid.Text + "'"
            command = New SqlCommand(query, sqlcon)
            READER = command.ExecuteReader
            sqlcon.Close()
            MessageBox.Show("Data is updated successfully...!!")
            reload()
            refresh_table()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try
            sqlcon.ConnectionString = "Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True"
            sqlcon.Open()
            Dim query As String
            Dim READER As SqlDataReader
            query = "Delete from  equipment where id='" + Txtid.Text + "'"
            command = New SqlCommand(query, sqlcon)
            READER = command.ExecuteReader
            sqlcon.Close()

            MessageBox.Show("Data is Deleted successfully..!!")
            reload()
            refresh_table()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Txtid.Enabled = False
        Try
            Dim i As Integer = e.RowIndex
            Dim selectedRow As New DataGridViewRow
            selectedRow = DataGridView1.Rows(i)
            Txtid.Text = selectedRow.Cells(0).Value.ToString
            Txtname.Text = selectedRow.Cells(1).Value.ToString
            Txtquantity.Text = selectedRow.Cells(2).Value.ToString
            Txtperunitcost.Text = selectedRow.Cells(3).Value.ToString
            Txttotolcost.Text = selectedRow.Cells(4).Value.ToString


        Catch EX As Exception
            MessageBox.Show(EX.Message)
        End Try

    End Sub

    Private Sub Txtquantity_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtquantity.Leave
        Txttotolcost.Text = Txtquantity.Text * Txtperunitcost.Text
    End Sub
End Class