Imports System.Data.Sql
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Form1
    Dim total As Integer
    Dim sqlcon As New SqlConnection
    Dim cmd As New SqlCommand
    Dim command As SqlCommand
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
    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Try
            Dim member As String
            If RbYes.Checked = True Then
                member = "Yes"
            Else
                member = "No"
            End If

            Dim status As String = ""
            If txtmorning.Checked = True Then

                status = "Morning"
            End If
            If Txtevening.Checked = True Then

                status = "Evening"
            End If
            If txtmorning.Checked = True And Txtevening.Checked = True Then
                status = "Morning&Evening"
            End If

            Dim sqlcon As New SqlConnection("Data Source=DESKTOP-BDHSF78\SQLEXPRESS;Initial Catalog=vishal;Integrated Security=True")
            sqlcon.Open()
            Dim cmd As New SqlCommand("INSERT INTO Registration(Name,Address,Mob_no,Date,DOB,Total_Fees,Pay_Fees,Pending_fees,Batch_time,Membership,Time_Duration,Document_Verifiction,Pay_Date) VALUES('" + Txtname.Text + "' ,'" + Txtaddress.Text + "','" + Txtmobno.Text + "','" + txtdata.Value + "','" + txtdob.Value + "','" + Txttotalfees.Text + "','" + TxtPayfees.Text + "','" + Txtpendingfees.Text + "','" + status + "','" + member + "','" + Cmboxtimeduration.Text + "','" + Cmboxdocument.Text + "','" + txtdata.Value + "')", sqlcon)

            cmd.Connection = sqlcon

            cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = txtdob.Value
            cmd.Parameters.Add("@DATE", SqlDbType.DateTime).Value = txtdata.Value

            cmd.ExecuteNonQuery()
            MessageBox.Show("Data is Saved")
            clear()

            sqlcon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Close()

    End Sub

    Private Sub TxtPayfees_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPayfees.Leave
        Txtpendingfees.Text = (CInt(Txttotalfees.Text) - CInt(TxtPayfees.Text))
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Txtmobno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtmobno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                MessageBox.Show("Enter only number:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Txtmobno.Text = ""

            End If
        End If
    End Sub

    Private Sub RbYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbYes.CheckedChanged
        If RbYes.Checked = True Then
            Cmboxtimeduration.Enabled = True
        End If
    End Sub

    Private Sub RbNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbNo.CheckedChanged
        If RbNo.Checked = True Then
            Cmboxtimeduration.Enabled = False
            Cmboxtimeduration.Text = ""
        End If
    End Sub
End Class
