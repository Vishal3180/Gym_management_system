<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datagripview
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
        Me.RegistrationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VishalDataSet1 = New vishal.vishalDataSet1()
        Me.RegistrationTableAdapter1 = New vishal.vishalDataSet1TableAdapters.RegistrationTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbNo = New System.Windows.Forms.RadioButton()
        Me.RbYes = New System.Windows.Forms.RadioButton()
        Me.Txtevening = New System.Windows.Forms.CheckBox()
        Me.txtmorning = New System.Windows.Forms.CheckBox()
        Me.Cmboxtimeduration = New System.Windows.Forms.ComboBox()
        Me.Cmboxdocument = New System.Windows.Forms.ComboBox()
        Me.txtdata = New System.Windows.Forms.DateTimePicker()
        Me.txtdob = New System.Windows.Forms.DateTimePicker()
        Me.Txtpendingfees = New System.Windows.Forms.TextBox()
        Me.TxtPayfees = New System.Windows.Forms.TextBox()
        Me.Txttotalfees = New System.Windows.Forms.TextBox()
        Me.Txtmobno = New System.Windows.Forms.TextBox()
        Me.Txtaddress = New System.Windows.Forms.TextBox()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.Txtid = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cancel = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtserch = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VishalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.MobnoDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.TotalFeesDataGridViewTextBoxColumn, Me.PayFeesDataGridViewTextBoxColumn, Me.PendingfeesDataGridViewTextBoxColumn, Me.BatchtimeDataGridViewTextBoxColumn, Me.MembershipDataGridViewTextBoxColumn, Me.TimeDurationDataGridViewTextBoxColumn, Me.DocumentverifictionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RegistrationBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(24, 489)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1126, 192)
        Me.DataGridView1.TabIndex = 0
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
        'RegistrationBindingSource1
        '
        Me.RegistrationBindingSource1.DataMember = "Registration"
        Me.RegistrationBindingSource1.DataSource = Me.VishalDataSet1
        '
        'VishalDataSet1
        '
        Me.VishalDataSet1.DataSetName = "vishalDataSet1"
        Me.VishalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistrationTableAdapter1
        '
        Me.RegistrationTableAdapter1.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.RbNo)
        Me.Panel1.Controls.Add(Me.RbYes)
        Me.Panel1.Controls.Add(Me.Txtevening)
        Me.Panel1.Controls.Add(Me.txtmorning)
        Me.Panel1.Controls.Add(Me.Cmboxtimeduration)
        Me.Panel1.Controls.Add(Me.Cmboxdocument)
        Me.Panel1.Controls.Add(Me.txtdata)
        Me.Panel1.Controls.Add(Me.txtdob)
        Me.Panel1.Controls.Add(Me.Txtpendingfees)
        Me.Panel1.Controls.Add(Me.TxtPayfees)
        Me.Panel1.Controls.Add(Me.Txttotalfees)
        Me.Panel1.Controls.Add(Me.Txtmobno)
        Me.Panel1.Controls.Add(Me.Txtaddress)
        Me.Panel1.Controls.Add(Me.Txtname)
        Me.Panel1.Controls.Add(Me.Txtid)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Id)
        Me.Panel1.Location = New System.Drawing.Point(24, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 349)
        Me.Panel1.TabIndex = 2
        '
        'RbNo
        '
        Me.RbNo.AutoSize = True
        Me.RbNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNo.Location = New System.Drawing.Point(997, 168)
        Me.RbNo.Name = "RbNo"
        Me.RbNo.Size = New System.Drawing.Size(44, 20)
        Me.RbNo.TabIndex = 29
        Me.RbNo.TabStop = True
        Me.RbNo.Text = "No"
        Me.RbNo.UseVisualStyleBackColor = True
        '
        'RbYes
        '
        Me.RbYes.AutoSize = True
        Me.RbYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbYes.Location = New System.Drawing.Point(912, 168)
        Me.RbYes.Name = "RbYes"
        Me.RbYes.Size = New System.Drawing.Size(50, 20)
        Me.RbYes.TabIndex = 28
        Me.RbYes.TabStop = True
        Me.RbYes.Text = "Yes"
        Me.RbYes.UseVisualStyleBackColor = True
        '
        'Txtevening
        '
        Me.Txtevening.AutoSize = True
        Me.Txtevening.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtevening.Location = New System.Drawing.Point(997, 90)
        Me.Txtevening.Name = "Txtevening"
        Me.Txtevening.Size = New System.Drawing.Size(76, 20)
        Me.Txtevening.TabIndex = 27
        Me.Txtevening.Text = "Evening"
        Me.Txtevening.UseVisualStyleBackColor = True
        '
        'txtmorning
        '
        Me.txtmorning.AutoSize = True
        Me.txtmorning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmorning.Location = New System.Drawing.Point(912, 90)
        Me.txtmorning.Name = "txtmorning"
        Me.txtmorning.Size = New System.Drawing.Size(75, 20)
        Me.txtmorning.TabIndex = 26
        Me.txtmorning.Text = "Morning"
        Me.txtmorning.UseVisualStyleBackColor = True
        '
        'Cmboxtimeduration
        '
        Me.Cmboxtimeduration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmboxtimeduration.FormattingEnabled = True
        Me.Cmboxtimeduration.Items.AddRange(New Object() {"1 Month", "3 Month", "6 Month", "12 Month"})
        Me.Cmboxtimeduration.Location = New System.Drawing.Point(931, 243)
        Me.Cmboxtimeduration.Name = "Cmboxtimeduration"
        Me.Cmboxtimeduration.Size = New System.Drawing.Size(121, 24)
        Me.Cmboxtimeduration.TabIndex = 25
        '
        'Cmboxdocument
        '
        Me.Cmboxdocument.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmboxdocument.FormattingEnabled = True
        Me.Cmboxdocument.Items.AddRange(New Object() {"Adhar card", "Pan card", "Driving Licence", "College Id", "Other "})
        Me.Cmboxdocument.Location = New System.Drawing.Point(121, 282)
        Me.Cmboxdocument.Name = "Cmboxdocument"
        Me.Cmboxdocument.Size = New System.Drawing.Size(225, 24)
        Me.Cmboxdocument.TabIndex = 24
        '
        'txtdata
        '
        Me.txtdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdata.Location = New System.Drawing.Point(866, 19)
        Me.txtdata.Name = "txtdata"
        Me.txtdata.Size = New System.Drawing.Size(207, 21)
        Me.txtdata.TabIndex = 23
        '
        'txtdob
        '
        Me.txtdob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdob.Location = New System.Drawing.Point(531, 90)
        Me.txtdob.Name = "txtdob"
        Me.txtdob.Size = New System.Drawing.Size(219, 21)
        Me.txtdob.TabIndex = 22
        '
        'Txtpendingfees
        '
        Me.Txtpendingfees.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpendingfees.Location = New System.Drawing.Point(531, 286)
        Me.Txtpendingfees.Name = "Txtpendingfees"
        Me.Txtpendingfees.Size = New System.Drawing.Size(118, 22)
        Me.Txtpendingfees.TabIndex = 21
        '
        'TxtPayfees
        '
        Me.TxtPayfees.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPayfees.Location = New System.Drawing.Point(531, 221)
        Me.TxtPayfees.Name = "TxtPayfees"
        Me.TxtPayfees.Size = New System.Drawing.Size(118, 22)
        Me.TxtPayfees.TabIndex = 20
        '
        'Txttotalfees
        '
        Me.Txttotalfees.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttotalfees.Location = New System.Drawing.Point(531, 154)
        Me.Txttotalfees.Name = "Txttotalfees"
        Me.Txttotalfees.Size = New System.Drawing.Size(118, 22)
        Me.Txttotalfees.TabIndex = 19
        '
        'Txtmobno
        '
        Me.Txtmobno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmobno.Location = New System.Drawing.Point(531, 20)
        Me.Txtmobno.MaxLength = 10
        Me.Txtmobno.Name = "Txtmobno"
        Me.Txtmobno.Size = New System.Drawing.Size(219, 22)
        Me.Txtmobno.TabIndex = 17
        '
        'Txtaddress
        '
        Me.Txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtaddress.Location = New System.Drawing.Point(121, 172)
        Me.Txtaddress.Multiline = True
        Me.Txtaddress.Name = "Txtaddress"
        Me.Txtaddress.Size = New System.Drawing.Size(225, 44)
        Me.Txtaddress.TabIndex = 15
        '
        'Txtname
        '
        Me.Txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtname.Location = New System.Drawing.Point(121, 95)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(225, 22)
        Me.Txtname.TabIndex = 14
        '
        'Txtid
        '
        Me.Txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtid.Location = New System.Drawing.Point(121, 24)
        Me.Txtid.Name = "Txtid"
        Me.Txtid.Size = New System.Drawing.Size(90, 22)
        Me.Txtid.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(815, 243)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 16)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Time_Duration"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(815, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 16)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Membership"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(815, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Batch_Time"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(815, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "DATE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(427, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Pending_Fees"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(427, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Pay_Fees"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(427, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total_Fees"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(427, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "DOB"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(427, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Mob_no"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 32)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Document" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Verifacation" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Name"
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id.Location = New System.Drawing.Point(29, 24)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(19, 16)
        Me.Id.TabIndex = 0
        Me.Id.Text = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(438, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Update / Delete  Members"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.cancel)
        Me.Panel2.Controls.Add(Me.Delete)
        Me.Panel2.Controls.Add(Me.Submit)
        Me.Panel2.Location = New System.Drawing.Point(24, 400)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1156, 36)
        Me.Panel2.TabIndex = 4
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Location = New System.Drawing.Point(712, 3)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(75, 30)
        Me.cancel.TabIndex = 6
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(560, 3)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 30)
        Me.Delete.TabIndex = 5
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(409, 3)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 30)
        Me.Submit.TabIndex = 4
        Me.Submit.Text = "Udate"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 453)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Search Members"
        '
        'Txtserch
        '
        Me.Txtserch.Location = New System.Drawing.Point(171, 454)
        Me.Txtserch.Name = "Txtserch"
        Me.Txtserch.Size = New System.Drawing.Size(284, 20)
        Me.Txtserch.TabIndex = 6
        '
        'datagripview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1219, 699)
        Me.Controls.Add(Me.Txtserch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "datagripview"
        Me.Text = "datagripview"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VishalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VishalDataSet1 As vishal.vishalDataSet1
    Friend WithEvents RegistrationBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrationTableAdapter1 As vishal.vishalDataSet1TableAdapters.RegistrationTableAdapter
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RbNo As System.Windows.Forms.RadioButton
    Friend WithEvents RbYes As System.Windows.Forms.RadioButton
    Friend WithEvents Txtevening As System.Windows.Forms.CheckBox
    Friend WithEvents txtmorning As System.Windows.Forms.CheckBox
    Friend WithEvents Cmboxtimeduration As System.Windows.Forms.ComboBox
    Friend WithEvents Cmboxdocument As System.Windows.Forms.ComboBox
    Friend WithEvents txtdata As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txtpendingfees As System.Windows.Forms.TextBox
    Friend WithEvents TxtPayfees As System.Windows.Forms.TextBox
    Friend WithEvents Txttotalfees As System.Windows.Forms.TextBox
    Friend WithEvents Txtmobno As System.Windows.Forms.TextBox
    Friend WithEvents Txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Txtname As System.Windows.Forms.TextBox
    Friend WithEvents Txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Id As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtserch As System.Windows.Forms.TextBox
End Class
