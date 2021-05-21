Public Class MaintanceFormDetail

    Private Sub MaintanceFormDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VishalDataSet8.Maintance' table. You can move, or remove it, as needed.
        Me.MaintanceTableAdapter.Fill(Me.VishalDataSet8.Maintance)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class