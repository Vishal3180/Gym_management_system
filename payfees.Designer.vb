<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payfees
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Date_pay = New System.Windows.Forms.DateTimePicker()
        Me.Txt_Pay_Date = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalFeesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayFeesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendingfeesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VishalDataSet4 = New vishal.vishalDataSet4()
        Me.RegistrationTableAdapter = New vishal.vishalDataSet4TableAdapters.RegistrationTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txtpendingfees = New System.Windows.Forms.TextBox()
        Me.Txtpayfees = New System.Windows.Forms.TextBox()
        Me.Txttotalfees = New System.Windows.Forms.TextBox()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VishalDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(177, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Pay Fees"
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(80, 432)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 31)
        Me.Submit.TabIndex = 11
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(232, 432)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 31)
        Me.Cancel.TabIndex = 12
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Date_pay
        '
        Me.Date_pay.Location = New System.Drawing.Point(451, 38)
        Me.Date_pay.Name = "Date_pay"
        Me.Date_pay.Size = New System.Drawing.Size(200, 20)
        Me.Date_pay.TabIndex = 14
        '
        'Txt_Pay_Date
        '
        Me.Txt_Pay_Date.AutoSize = True
        Me.Txt_Pay_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Pay_Date.Location = New System.Drawing.Point(408, 38)
        Me.Txt_Pay_Date.Name = "Txt_Pay_Date"
        Me.Txt_Pay_Date.Size = New System.Drawing.Size(37, 16)
        Me.Txt_Pay_Date.TabIndex = 15
        Me.Txt_Pay_Date.Text = "Date"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.TotalFeesDataGridViewTextBoxColumn, Me.PayFeesDataGridViewTextBoxColumn, Me.PendingfeesDataGridViewTextBoxColumn, Me.PayDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegistrationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(411, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(629, 330)
        Me.DataGridView1.TabIndex = 16
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'TotalFeesDataGridViewTextBoxColumn
        '
        Me.TotalFeesDataGridViewTextBoxColumn.DataPropertyName = "Total_Fees"
        Me.TotalFeesDataGridViewTextBoxColumn.HeaderText = "Total_Fees"
        Me.TotalFeesDataGridViewTextBoxColumn.Name = "TotalFeesDataGridViewTextBoxColumn"
        '
        'PayFeesDataGridViewTextBoxColumn
        '
        Me.PayFeesDataGridViewTextBoxColumn.DataPropertyName = "Pay_Fees"
        Me.PayFeesDataGridViewTextBoxColumn.HeaderText = "Pay_Fees"
        Me.PayFeesDataGridViewTextBoxColumn.Name = "PayFeesDataGridViewTextBoxColumn"
        '
        'PendingfeesDataGridViewTextBoxColumn
        '
        Me.PendingfeesDataGridViewTextBoxColumn.DataPropertyName = "Pending_fees"
        Me.PendingfeesDataGridViewTextBoxColumn.HeaderText = "Pending_fees"
        Me.PendingfeesDataGridViewTextBoxColumn.Name = "PendingfeesDataGridViewTextBoxColumn"
        '
        'PayDateDataGridViewTextBoxColumn
        '
        Me.PayDateDataGridViewTextBoxColumn.DataPropertyName = "Pay_Date"
        Me.PayDateDataGridViewTextBoxColumn.HeaderText = "Pay_Date"
        Me.PayDateDataGridViewTextBoxColumn.Name = "PayDateDataGridViewTextBoxColumn"
        '
        'RegistrationBindingSource
        '
        Me.RegistrationBindingSource.DataMember = "Registration"
        Me.RegistrationBindingSource.DataSource = Me.VishalDataSet4
        '
        'VishalDataSet4
        '
        Me.VishalDataSet4.DataSetName = "vishalDataSet4"
        Me.VishalDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistrationTableAdapter
        '
        Me.RegistrationTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Txtpendingfees)
        Me.Panel1.Controls.Add(Me.Txtpayfees)
        Me.Panel1.Controls.Add(Me.Txttotalfees)
        Me.Panel1.Controls.Add(Me.Txtname)
        Me.Panel1.Controls.Add(Me.Txtid)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 362)
        Me.Panel1.TabIndex = 17
        '
        'Txtpendingfees
        '
        Me.Txtpendingfees.Location = New System.Drawing.Point(153, 309)
        Me.Txtpendingfees.Name = "Txtpendingfees"
        Me.Txtpendingfees.Size = New System.Drawing.Size(207, 20)
        Me.Txtpendingfees.TabIndex = 19
        '
        'Txtpayfees
        '
        Me.Txtpayfees.Location = New System.Drawing.Point(153, 226)
        Me.Txtpayfees.Name = "Txtpayfees"
        Me.Txtpayfees.Size = New System.Drawing.Size(207, 20)
        Me.Txtpayfees.TabIndex = 18
        '
        'Txttotalfees
        '
        Me.Txttotalfees.Location = New System.Drawing.Point(153, 147)
        Me.Txttotalfees.Name = "Txttotalfees"
        Me.Txttotalfees.Size = New System.Drawing.Size(207, 20)
        Me.Txttotalfees.TabIndex = 17
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(153, 75)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(207, 20)
        Me.Txtname.TabIndex = 16
        '
        'Txtid
        '
        Me.Txtid.Location = New System.Drawing.Point(153, 20)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(100, 20)
        Me.Txtid.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Pending Fees"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Pay Fees"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Total Fees"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Id"
        '
        'payfees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1065, 482)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Txt_Pay_Date)
        Me.Controls.Add(Me.Date_pay)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Label6)
        Me.Name = "payfees"
        Me.Text = "payfees"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VishalDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Date_pay As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txt_Pay_Date As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VishalDataSet4 As vishal.vishalDataSet4
    Friend WithEvents RegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrationTableAdapter As vishal.vishalDataSet4TableAdapters.RegistrationTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalFeesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayFeesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PendingfeesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Txtpendingfees As System.Windows.Forms.TextBox
    Friend WithEvents Txtpayfees As System.Windows.Forms.TextBox
    Friend WithEvents Txttotalfees As System.Windows.Forms.TextBox
    Friend WithEvents Txtname As System.Windows.Forms.TextBox
    Friend WithEvents Txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
