<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBlotter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddBlotter))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBlotterNumber = New System.Windows.Forms.TextBox()
        Me.closeButton = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.cbCivilStatus = New System.Windows.Forms.ComboBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.checkIsResident = New System.Windows.Forms.CheckBox()
        Me.dtBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPurok = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtNarrative = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtIncidentTime = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtIncidentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnRecordBlotter = New System.Windows.Forms.Button()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.searchResidentGroup = New System.Windows.Forms.GroupBox()
        Me.closeSearchGroup = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middle_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.civilstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearchResident = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.searchResidentGroup.SuspendLayout()
        CType(Me.closeSearchGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(432, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 16)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Blotter Number"
        '
        'txtBlotterNumber
        '
        Me.txtBlotterNumber.Enabled = False
        Me.txtBlotterNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBlotterNumber.Location = New System.Drawing.Point(544, 15)
        Me.txtBlotterNumber.Name = "txtBlotterNumber"
        Me.txtBlotterNumber.Size = New System.Drawing.Size(125, 29)
        Me.txtBlotterNumber.TabIndex = 57
        Me.txtBlotterNumber.Text = "202001"
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Transparent
        Me.closeButton.BackgroundImage = CType(resources.GetObject("closeButton.BackgroundImage"), System.Drawing.Image)
        Me.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeButton.Location = New System.Drawing.Point(1111, 12)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(24, 24)
        Me.closeButton.TabIndex = 58
        Me.closeButton.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtMobileNumber)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtOccupation)
        Me.GroupBox1.Controls.Add(Me.cbCivilStatus)
        Me.GroupBox1.Controls.Add(Me.cbGender)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.checkIsResident)
        Me.GroupBox1.Controls.Add(Me.dtBirthdate)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPurok)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtMiddleName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 401)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Complainant Details"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 354)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 16)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Mobile Number"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNumber.Location = New System.Drawing.Point(123, 349)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(235, 26)
        Me.txtMobileNumber.TabIndex = 10
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(17, 322)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 16)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "Occupation"
        '
        'txtOccupation
        '
        Me.txtOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupation.Location = New System.Drawing.Point(123, 317)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(235, 26)
        Me.txtOccupation.TabIndex = 9
        '
        'cbCivilStatus
        '
        Me.cbCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCivilStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCivilStatus.FormattingEnabled = True
        Me.cbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widow"})
        Me.cbCivilStatus.Location = New System.Drawing.Point(123, 187)
        Me.cbCivilStatus.Name = "cbCivilStatus"
        Me.cbCivilStatus.Size = New System.Drawing.Size(235, 28)
        Me.cbCivilStatus.TabIndex = 5
        '
        'cbGender
        '
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(123, 150)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(235, 28)
        Me.cbGender.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(17, 155)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 16)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Gender"
        '
        'checkIsResident
        '
        Me.checkIsResident.AutoSize = True
        Me.checkIsResident.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkIsResident.Location = New System.Drawing.Point(123, 26)
        Me.checkIsResident.Name = "checkIsResident"
        Me.checkIsResident.Size = New System.Drawing.Size(169, 20)
        Me.checkIsResident.TabIndex = 0
        Me.checkIsResident.Text = "Is Complainant a Resident?"
        Me.checkIsResident.UseVisualStyleBackColor = True
        '
        'dtBirthdate
        '
        Me.dtBirthdate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBirthdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBirthdate.Location = New System.Drawing.Point(123, 223)
        Me.dtBirthdate.Name = "dtBirthdate"
        Me.dtBirthdate.Size = New System.Drawing.Size(235, 24)
        Me.dtBirthdate.TabIndex = 6
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(17, 227)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(66, 16)
        Me.Label31.TabIndex = 64
        Me.Label31.Text = "Birth Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Address"
        '
        'txtPurok
        '
        Me.txtPurok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurok.Location = New System.Drawing.Point(123, 285)
        Me.txtPurok.Name = "txtPurok"
        Me.txtPurok.Size = New System.Drawing.Size(235, 26)
        Me.txtPurok.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Civil Status"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(123, 52)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(235, 26)
        Me.txtFirstName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 16)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Age"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "First Name"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(123, 253)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(235, 26)
        Me.txtAge.TabIndex = 7
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(123, 85)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(235, 26)
        Me.txtMiddleName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Middle Name"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(123, 118)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(235, 26)
        Me.txtLastName.TabIndex = 3
        '
        'txtNarrative
        '
        Me.txtNarrative.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNarrative.Location = New System.Drawing.Point(428, 76)
        Me.txtNarrative.Multiline = True
        Me.txtNarrative.Name = "txtNarrative"
        Me.txtNarrative.Size = New System.Drawing.Size(683, 497)
        Me.txtNarrative.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(425, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Incident Narrative"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtType)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtIncidentTime)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dtIncidentDate)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtLocation)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(36, 438)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(386, 186)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Incident Details"
        '
        'txtType
        '
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(138, 33)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(220, 26)
        Me.txtType.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 16)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Incident Type"
        '
        'dtIncidentTime
        '
        Me.dtIncidentTime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtIncidentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtIncidentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtIncidentTime.Location = New System.Drawing.Point(138, 136)
        Me.dtIncidentTime.Name = "dtIncidentTime"
        Me.dtIncidentTime.Size = New System.Drawing.Size(220, 24)
        Me.dtIncidentTime.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Time"
        '
        'dtIncidentDate
        '
        Me.dtIncidentDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtIncidentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtIncidentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIncidentDate.Location = New System.Drawing.Point(138, 103)
        Me.dtIncidentDate.Name = "dtIncidentDate"
        Me.dtIncidentDate.Size = New System.Drawing.Size(220, 24)
        Me.dtIncidentDate.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Date of Incident"
        '
        'txtLocation
        '
        Me.txtLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Location = New System.Drawing.Point(138, 68)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(220, 26)
        Me.txtLocation.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 16)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Place of Incident"
        '
        'btnRecordBlotter
        '
        Me.btnRecordBlotter.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnRecordBlotter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecordBlotter.FlatAppearance.BorderSize = 0
        Me.btnRecordBlotter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRecordBlotter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnRecordBlotter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecordBlotter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecordBlotter.Image = CType(resources.GetObject("btnRecordBlotter.Image"), System.Drawing.Image)
        Me.btnRecordBlotter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecordBlotter.Location = New System.Drawing.Point(919, 588)
        Me.btnRecordBlotter.Name = "btnRecordBlotter"
        Me.btnRecordBlotter.Size = New System.Drawing.Size(204, 47)
        Me.btnRecordBlotter.TabIndex = 15
        Me.btnRecordBlotter.Text = "Record Blotter"
        Me.btnRecordBlotter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecordBlotter.UseVisualStyleBackColor = False
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(522, 598)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(170, 26)
        Me.txtUser.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(428, 604)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Recorded By"
        '
        'searchResidentGroup
        '
        Me.searchResidentGroup.Controls.Add(Me.closeSearchGroup)
        Me.searchResidentGroup.Controls.Add(Me.DataGridView1)
        Me.searchResidentGroup.Controls.Add(Me.txtSearchResident)
        Me.searchResidentGroup.Controls.Add(Me.Label15)
        Me.searchResidentGroup.Location = New System.Drawing.Point(427, 55)
        Me.searchResidentGroup.Name = "searchResidentGroup"
        Me.searchResidentGroup.Size = New System.Drawing.Size(695, 527)
        Me.searchResidentGroup.TabIndex = 73
        Me.searchResidentGroup.TabStop = False
        '
        'closeSearchGroup
        '
        Me.closeSearchGroup.BackColor = System.Drawing.Color.Transparent
        Me.closeSearchGroup.BackgroundImage = CType(resources.GetObject("closeSearchGroup.BackgroundImage"), System.Drawing.Image)
        Me.closeSearchGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.closeSearchGroup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeSearchGroup.Location = New System.Drawing.Point(659, 28)
        Me.closeSearchGroup.Name = "closeSearchGroup"
        Me.closeSearchGroup.Size = New System.Drawing.Size(24, 24)
        Me.closeSearchGroup.TabIndex = 74
        Me.closeSearchGroup.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.first_name, Me.middle_name, Me.last_name, Me.gender, Me.civilstatus, Me.birthdate, Me.age, Me.purok})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(6, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(683, 427)
        Me.DataGridView1.TabIndex = 74
        '
        'first_name
        '
        Me.first_name.HeaderText = "First Name"
        Me.first_name.Name = "first_name"
        Me.first_name.Width = 150
        '
        'middle_name
        '
        Me.middle_name.HeaderText = "Middle Name"
        Me.middle_name.Name = "middle_name"
        Me.middle_name.Width = 130
        '
        'last_name
        '
        Me.last_name.HeaderText = "Last Name"
        Me.last_name.Name = "last_name"
        Me.last_name.Width = 150
        '
        'gender
        '
        Me.gender.HeaderText = "Gender"
        Me.gender.Name = "gender"
        Me.gender.Width = 90
        '
        'civilstatus
        '
        Me.civilstatus.HeaderText = "Civil Status"
        Me.civilstatus.Name = "civilstatus"
        '
        'birthdate
        '
        Me.birthdate.HeaderText = "Birthdate"
        Me.birthdate.Name = "birthdate"
        '
        'age
        '
        Me.age.HeaderText = "Age"
        Me.age.Name = "age"
        '
        'purok
        '
        Me.purok.HeaderText = "Purok"
        Me.purok.Name = "purok"
        '
        'txtSearchResident
        '
        Me.txtSearchResident.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchResident.Location = New System.Drawing.Point(133, 28)
        Me.txtSearchResident.Name = "txtSearchResident"
        Me.txtSearchResident.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearchResident.Size = New System.Drawing.Size(479, 26)
        Me.txtSearchResident.TabIndex = 65
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(108, 16)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Search Resident"
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Settled", "Unresolved", "Pending", "Forwarded"})
        Me.cbStatus.Location = New System.Drawing.Point(744, 15)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(153, 28)
        Me.cbStatus.TabIndex = 67
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(685, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 16)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "Status"
        '
        'frmAddBlotter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 668)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.searchResidentGroup)
        Me.Controls.Add(Me.btnRecordBlotter)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNarrative)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBlotterNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddBlotter"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Blotter"
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.searchResidentGroup.ResumeLayout(False)
        Me.searchResidentGroup.PerformLayout()
        CType(Me.closeSearchGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents txtBlotterNumber As TextBox
    Friend WithEvents closeButton As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPurok As TextBox
    Friend WithEvents checkIsResident As CheckBox
    Friend WithEvents dtBirthdate As DateTimePicker
    Friend WithEvents Label31 As Label
    Friend WithEvents txtNarrative As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtType As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtIncidentTime As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents dtIncidentDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnRecordBlotter As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents searchResidentGroup As GroupBox
    Friend WithEvents txtSearchResident As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents first_name As DataGridViewTextBoxColumn
    Friend WithEvents middle_name As DataGridViewTextBoxColumn
    Friend WithEvents last_name As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents civilstatus As DataGridViewTextBoxColumn
    Friend WithEvents birthdate As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents purok As DataGridViewTextBoxColumn
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents cbCivilStatus As ComboBox
    Friend WithEvents closeSearchGroup As PictureBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMobileNumber As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtOccupation As TextBox
End Class
