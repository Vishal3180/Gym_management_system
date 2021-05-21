<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewallmember
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalFeesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayFeesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendingfeesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchtimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembershipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDurationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocumentverifictionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VishalDataSet6 = New vishal.vishalDataSet6()
        Me.RegistrationTableAdapter = New vishal.vishalDataSet6TableAdapters.RegistrationTableAdapter()
        Me.Txtserch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VishalDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.MobnoDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.TotalFeesDataGridViewTextBoxColumn, Me.PayFeesDataGridViewTextBoxColumn, Me.PendingfeesDataGridViewTextBoxColumn, Me.BatchtimeDataGridViewTextBoxColumn, Me.MembershipDataGridViewTextBoxColumn, Me.TimeDurationDataGridViewTextBoxColumn, Me.DocumentverifictionDataGridViewTextBoxColumn, Me.PayDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegistrationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(23, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1317, 629)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'MobnoDataGridViewTextBoxColumn
        '
        Me.MobnoDataGridViewTextBoxColumn.DataPropertyName = "Mob_no"
        Me.MobnoDataGridViewTextBoxColumn.HeaderText = "Mob_no"
        Me.MobnoDataGridViewTextBoxColumn.Name = "MobnoDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
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
        'BatchtimeDataGridViewTextBoxColumn
        '
        Me.BatchtimeDataGridViewTextBoxColumn.DataPropertyName = "Batch_time"
        Me.BatchtimeDataGridViewTextBoxColumn.HeaderText = "Batch_time"
        Me.BatchtimeDataGridViewTextBoxColumn.Name = "BatchtimeDataGridViewTextBoxColumn"
        '
        'MembershipDataGridViewTextBoxColumn
        '
        Me.MembershipDataGridViewTextBoxColumn.DataPropertyName = "Membership"
        Me.MembershipDataGridViewTextBoxColumn.HeaderText = "Membership"
        Me.MembershipDataGridViewTextBoxColumn.Name = "MembershipDataGridViewTextBoxColumn"
        '
        'TimeDurationDataGridViewTextBoxColumn
        '
        Me.TimeDurationDataGridViewTextBoxColumn.DataPropertyName = "Time_Duration"
        Me.TimeDurationDataGridViewTextBoxColumn.HeaderText = "Time_Duration"
        Me.TimeDurationDataGridViewTextBoxColumn.Name = "TimeDurationDataGridViewTextBoxColumn"
        '
        'DocumentverifictionDataGridViewTextBoxColumn
        '
        Me.DocumentverifictionDataGridViewTextBoxColumn.DataPropertyName = "Document_verifiction"
        Me.DocumentverifictionDataGridViewTextBoxColumn.HeaderText = "Document_verifiction"
        Me.DocumentverifictionDataGridViewTextBoxColumn.Name = "DocumentverifictionDataGridViewTextBoxColumn"
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
        Me.RegistrationBindingSource.DataSource = Me.VishalDataSet6
        '
        'VishalDataSet6
        '
        Me.VishalDataSet6.DataSetName = "vishalDataSet6"
        Me.VishalDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistrationTableAdapter
        '
        Me.RegistrationTableAdapter.ClearBeforeFill = True
        '
        'Txtserch
        '
        Me.Txtserch.Location = New System.Drawing.Point(170, 10)
        Me.Txtserch.Name = "Txtserch"
        Me.Txtserch.Size = New System.Drawing.Size(284, 20)
        Me.Txtserch.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Search Members"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(504, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "View All Members "
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(508, 714)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 10
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Viewallmember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtserch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Viewallmember"
        Me.Text = "Viewallmember"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VishalDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VishalDataSet6 As vishal.vishalDataSet6
    Friend WithEvents RegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrationTableAdapter As vishal.vishalDataSet6TableAdapters.RegistrationTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalFeesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayFeesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PendingfeesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BatchtimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MembershipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeDurationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DocumentverifictionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PayDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Txtserch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.Button
End Class
