<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clearances
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clearances))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.backButton = New System.Windows.Forms.PictureBox()
        Me.labHeader = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbClearanceType = New System.Windows.Forms.ComboBox()
        Me.panelResident = New System.Windows.Forms.Panel()
        Me.txtControlNumber = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtSearchResident = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middle_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.orDate = New System.Windows.Forms.DateTimePicker()
        Me.txtORNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelResident.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.Transparent
        Me.backButton.BackgroundImage = CType(resources.GetObject("backButton.BackgroundImage"), System.Drawing.Image)
        Me.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.backButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backButton.Location = New System.Drawing.Point(12, 12)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(40, 33)
        Me.backButton.TabIndex = 53
        Me.backButton.TabStop = False
        '
        'labHeader
        '
        Me.labHeader.AutoSize = True
        Me.labHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labHeader.Location = New System.Drawing.Point(58, 12)
        Me.labHeader.Name = "labHeader"
        Me.labHeader.Size = New System.Drawing.Size(138, 31)
        Me.labHeader.TabIndex = 54
        Me.labHeader.Text = "Clearance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(634, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 16)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Select Clearance Type"
        '
        'cbClearanceType
        '
        Me.cbClearanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClearanceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClearanceType.FormattingEnabled = True
        Me.cbClearanceType.Items.AddRange(New Object() {"Resident Clearance", "Construction Clearance", "Business Clearance"})
        Me.cbClearanceType.Location = New System.Drawing.Point(803, 28)
        Me.cbClearanceType.Name = "cbClearanceType"
        Me.cbClearanceType.Size = New System.Drawing.Size(317, 28)
        Me.cbClearanceType.TabIndex = 6
        '
        'panelResident
        '
        Me.panelResident.BackColor = System.Drawing.SystemColors.Window
        Me.panelResident.Controls.Add(Me.txtControlNumber)
        Me.panelResident.Controls.Add(Me.Label13)
        Me.panelResident.Controls.Add(Me.btnSave)
        Me.panelResident.Controls.Add(Me.btnPreview)
        Me.panelResident.Controls.Add(Me.GroupBox1)
        Me.panelResident.Controls.Add(Me.Label1)
        Me.panelResident.Controls.Add(Me.TextBox2)
        Me.panelResident.Controls.Add(Me.Label4)
        Me.panelResident.Controls.Add(Me.TextBox1)
        Me.panelResident.Controls.Add(Me.txtFirstName)
        Me.panelResident.Controls.Add(Me.Label2)
        Me.panelResident.Controls.Add(Me.txtMiddleName)
        Me.panelResident.Controls.Add(Me.Label3)
        Me.panelResident.Controls.Add(Me.Label11)
        Me.panelResident.Controls.Add(Me.txtLastName)
        Me.panelResident.Controls.Add(Me.txtSearchResident)
        Me.panelResident.Controls.Add(Me.DataGridView1)
        Me.panelResident.Controls.Add(Me.Label15)
        Me.panelResident.Location = New System.Drawing.Point(12, 78)
        Me.panelResident.Name = "panelResident"
        Me.panelResident.Size = New System.Drawing.Size(1108, 578)
        Me.panelResident.TabIndex = 65
        '
        'txtControlNumber
        '
        Me.txtControlNumber.Enabled = False
        Me.txtControlNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtControlNumber.Location = New System.Drawing.Point(162, 21)
        Me.txtControlNumber.Name = "txtControlNumber"
        Me.txtControlNumber.Size = New System.Drawing.Size(224, 26)
        Me.txtControlNumber.TabIndex = 100
        Me.txtControlNumber.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(23, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 18)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Control Number:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(26, 484)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(140, 40)
        Me.btnSave.TabIndex = 99
        Me.btnSave.Text = " Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreview.FlatAppearance.BorderSize = 0
        Me.btnPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreview.Location = New System.Drawing.Point(241, 484)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(145, 40)
        Me.btnPreview.TabIndex = 5
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 322)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 145)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Official Receipt Details"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(109, 72)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(225, 26)
        Me.DateTimePicker1.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(109, 40)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(225, 26)
        Me.TextBox3.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "OR Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 16)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "OR Date"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(109, 104)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(225, 26)
        Me.TextBox4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Purpose"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(116, 200)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(270, 100)
        Me.TextBox2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Purok"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(116, 168)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(270, 26)
        Me.TextBox1.TabIndex = 95
        Me.TextBox1.TabStop = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(116, 70)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(270, 26)
        Me.txtFirstName.TabIndex = 7
        Me.txtFirstName.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "First Name"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Enabled = False
        Me.txtMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(116, 103)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(270, 26)
        Me.txtMiddleName.TabIndex = 8
        Me.txtMiddleName.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Last Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 16)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Middle Name"
        '
        'txtLastName
        '
        Me.txtLastName.Enabled = False
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(116, 136)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(270, 26)
        Me.txtLastName.TabIndex = 9
        Me.txtLastName.TabStop = False
        '
        'txtSearchResident
        '
        Me.txtSearchResident.BackColor = System.Drawing.SystemColors.Info
        Me.txtSearchResident.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchResident.Location = New System.Drawing.Point(532, 21)
        Me.txtSearchResident.Name = "txtSearchResident"
        Me.txtSearchResident.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearchResident.Size = New System.Drawing.Size(556, 26)
        Me.txtSearchResident.TabIndex = 0
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.first_name, Me.middle_name, Me.last_name, Me.ctc, Me.purok})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(421, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(667, 489)
        Me.DataGridView1.TabIndex = 5
        Me.DataGridView1.TabStop = False
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
        Me.middle_name.Width = 150
        '
        'last_name
        '
        Me.last_name.HeaderText = "Last Name"
        Me.last_name.Name = "last_name"
        Me.last_name.Width = 150
        '
        'ctc
        '
        Me.ctc.HeaderText = "CTC"
        Me.ctc.Name = "ctc"
        Me.ctc.Width = 110
        '
        'purok
        '
        Me.purok.HeaderText = "Purok"
        Me.purok.Name = "purok"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(418, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(108, 16)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "Search Resident"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.orDate)
        Me.GroupBox2.Controls.Add(Me.txtORNumber)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 453)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 145)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Official Receipt Details"
        '
        'orDate
        '
        Me.orDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.orDate.Location = New System.Drawing.Point(109, 72)
        Me.orDate.Name = "orDate"
        Me.orDate.Size = New System.Drawing.Size(150, 26)
        Me.orDate.TabIndex = 3
        '
        'txtORNumber
        '
        Me.txtORNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORNumber.Location = New System.Drawing.Point(109, 40)
        Me.txtORNumber.Name = "txtORNumber"
        Me.txtORNumber.Size = New System.Drawing.Size(150, 26)
        Me.txtORNumber.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "OR Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "OR Date"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(109, 104)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(150, 26)
        Me.txtAmount.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label14.Enabled = False
        Me.Label14.Location = New System.Drawing.Point(12, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1108, 1)
        Me.Label14.TabIndex = 66
        '
        'Clearances
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 668)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.panelResident)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbClearanceType)
        Me.Controls.Add(Me.labHeader)
        Me.Controls.Add(Me.backButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clearances"
        Me.Text = "Clearances"
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelResident.ResumeLayout(False)
        Me.panelResident.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backButton As PictureBox
    Friend WithEvents labHeader As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbClearanceType As ComboBox
    Friend WithEvents panelResident As Panel
    Friend WithEvents txtSearchResident As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents orDate As DateTimePicker
    Friend WithEvents txtORNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnPreview As Button
    Friend WithEvents first_name As DataGridViewTextBoxColumn
    Friend WithEvents middle_name As DataGridViewTextBoxColumn
    Friend WithEvents last_name As DataGridViewTextBoxColumn
    Friend WithEvents ctc As DataGridViewTextBoxColumn
    Friend WithEvents purok As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As Button
    Friend WithEvents txtControlNumber As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
