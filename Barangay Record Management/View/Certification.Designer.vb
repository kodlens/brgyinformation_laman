<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCertification
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCertification))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.closeButton = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbClearanceType = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.orDate = New System.Windows.Forms.DateTimePicker()
        Me.txtORNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.crystalCertification = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.searchResidentGroup = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbCivilStatus = New System.Windows.Forms.ComboBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPurok = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middle_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.civilstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.closeSearchGroup = New System.Windows.Forms.PictureBox()
        Me.txtSearchResident = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.searchResidentGroup.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeSearchGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Transparent
        Me.closeButton.BackgroundImage = CType(resources.GetObject("closeButton.BackgroundImage"), System.Drawing.Image)
        Me.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeButton.Location = New System.Drawing.Point(1112, 12)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(24, 24)
        Me.closeButton.TabIndex = 52
        Me.closeButton.TabStop = False
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
        Me.btnSave.Location = New System.Drawing.Point(124, 604)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(179, 40)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = " Save/Preview"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.cbCivilStatus)
        Me.Panel1.Controls.Add(Me.cbGender)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtPurok)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAge)
        Me.Panel1.Controls.Add(Me.txtMiddleName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cbClearanceType)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtPurpose)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 668)
        Me.Panel1.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 16)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Select Clearance/Certification Type"
        '
        'cbClearanceType
        '
        Me.cbClearanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClearanceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClearanceType.FormattingEnabled = True
        Me.cbClearanceType.Items.AddRange(New Object() {"Barangay Clearance", "Barangay Certification", "Certificate of Indigency", "Construction Clearance", "Business Clearance"})
        Me.cbClearanceType.Location = New System.Drawing.Point(18, 32)
        Me.cbClearanceType.Name = "cbClearanceType"
        Me.cbClearanceType.Size = New System.Drawing.Size(285, 28)
        Me.cbClearanceType.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(18, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(285, 40)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Search Resident"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 398)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Purpose"
        '
        'txtPurpose
        '
        Me.txtPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.Location = New System.Drawing.Point(113, 393)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(190, 26)
        Me.txtPurpose.TabIndex = 1
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
        'crystalCertification
        '
        Me.crystalCertification.ActiveViewIndex = -1
        Me.crystalCertification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crystalCertification.Cursor = System.Windows.Forms.Cursors.Default
        Me.crystalCertification.Location = New System.Drawing.Point(339, 0)
        Me.crystalCertification.Name = "crystalCertification"
        Me.crystalCertification.ShowCloseButton = False
        Me.crystalCertification.ShowCopyButton = False
        Me.crystalCertification.ShowGroupTreeButton = False
        Me.crystalCertification.ShowLogo = False
        Me.crystalCertification.ShowParameterPanelButton = False
        Me.crystalCertification.ShowRefreshButton = False
        Me.crystalCertification.ShowTextSearchButton = False
        Me.crystalCertification.Size = New System.Drawing.Size(749, 644)
        Me.crystalCertification.TabIndex = 54
        Me.crystalCertification.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'searchResidentGroup
        '
        Me.searchResidentGroup.Controls.Add(Me.closeSearchGroup)
        Me.searchResidentGroup.Controls.Add(Me.txtSearchResident)
        Me.searchResidentGroup.Controls.Add(Me.Label15)
        Me.searchResidentGroup.Controls.Add(Me.DataGridView1)
        Me.searchResidentGroup.Location = New System.Drawing.Point(339, 0)
        Me.searchResidentGroup.Name = "searchResidentGroup"
        Me.searchResidentGroup.Size = New System.Drawing.Size(767, 644)
        Me.searchResidentGroup.TabIndex = 55
        Me.searchResidentGroup.TabStop = False
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.first_name, Me.middle_name, Me.last_name, Me.gender, Me.civilstatus, Me.age, Me.purok})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(20, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(729, 524)
        Me.DataGridView1.TabIndex = 75
        '
        'cbCivilStatus
        '
        Me.cbCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCivilStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCivilStatus.FormattingEnabled = True
        Me.cbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Separated", "Widow"})
        Me.cbCivilStatus.Location = New System.Drawing.Point(112, 277)
        Me.cbCivilStatus.Name = "cbCivilStatus"
        Me.cbCivilStatus.Size = New System.Drawing.Size(190, 28)
        Me.cbCivilStatus.TabIndex = 75
        '
        'cbGender
        '
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbGender.Location = New System.Drawing.Point(112, 240)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(190, 28)
        Me.cbGender.TabIndex = 74
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(19, 245)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 16)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Address"
        '
        'txtPurok
        '
        Me.txtPurok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurok.Location = New System.Drawing.Point(112, 345)
        Me.txtPurok.Name = "txtPurok"
        Me.txtPurok.Size = New System.Drawing.Size(190, 26)
        Me.txtPurok.TabIndex = 78
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Civil Status"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(112, 142)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(190, 26)
        Me.txtFirstName.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 16)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "First Name"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(112, 313)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(190, 26)
        Me.txtAge.TabIndex = 77
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(112, 175)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(190, 26)
        Me.txtMiddleName.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Last Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 180)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 16)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Middle Name"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(112, 208)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(190, 26)
        Me.txtLastName.TabIndex = 73
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
        'closeSearchGroup
        '
        Me.closeSearchGroup.BackColor = System.Drawing.Color.Transparent
        Me.closeSearchGroup.BackgroundImage = CType(resources.GetObject("closeSearchGroup.BackgroundImage"), System.Drawing.Image)
        Me.closeSearchGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.closeSearchGroup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeSearchGroup.Location = New System.Drawing.Point(725, 53)
        Me.closeSearchGroup.Name = "closeSearchGroup"
        Me.closeSearchGroup.Size = New System.Drawing.Size(24, 24)
        Me.closeSearchGroup.TabIndex = 78
        Me.closeSearchGroup.TabStop = False
        '
        'txtSearchResident
        '
        Me.txtSearchResident.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchResident.Location = New System.Drawing.Point(134, 53)
        Me.txtSearchResident.Name = "txtSearchResident"
        Me.txtSearchResident.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearchResident.Size = New System.Drawing.Size(479, 26)
        Me.txtSearchResident.TabIndex = 76
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(20, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(108, 16)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Search Resident"
        '
        'frmCertification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1148, 668)
        Me.Controls.Add(Me.searchResidentGroup)
        Me.Controls.Add(Me.crystalCertification)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.closeButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCertification"
        Me.Text = "Certification"
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.searchResidentGroup.ResumeLayout(False)
        Me.searchResidentGroup.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeSearchGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents closeButton As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPurpose As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents orDate As DateTimePicker
    Friend WithEvents txtORNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents crystalCertification As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label5 As Label
    Friend WithEvents cbClearanceType As ComboBox
    Friend WithEvents searchResidentGroup As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbCivilStatus As ComboBox
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPurok As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents first_name As DataGridViewTextBoxColumn
    Friend WithEvents middle_name As DataGridViewTextBoxColumn
    Friend WithEvents last_name As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents civilstatus As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents purok As DataGridViewTextBoxColumn
    Friend WithEvents closeSearchGroup As PictureBox
    Friend WithEvents txtSearchResident As TextBox
    Friend WithEvents Label15 As Label
End Class
