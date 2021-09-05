<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResidentList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResidentList))
        Me.dtGridResident = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.nickname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middle_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.civilstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voterstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employmentstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.occupation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.religion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddResident = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.backButton = New System.Windows.Forms.PictureBox()
        Me.rbFirstName = New System.Windows.Forms.RadioButton()
        Me.rbLastName = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbResidentNumber = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.dtGridResident, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtGridResident
        '
        Me.dtGridResident.AllowUserToAddRows = False
        Me.dtGridResident.AllowUserToDeleteRows = False
        Me.dtGridResident.AllowUserToResizeColumns = False
        Me.dtGridResident.AllowUserToResizeRows = False
        Me.dtGridResident.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtGridResident.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtGridResident.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtGridResident.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtGridResident.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtGridResident.ColumnHeadersHeight = 40
        Me.dtGridResident.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete, Me.edit, Me.nickname, Me.first_name, Me.middle_name, Me.last_name, Me.purok, Me.gender, Me.civilstatus, Me.birthdate, Me.voterstatus, Me.employmentstatus, Me.occupation, Me.religion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtGridResident.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtGridResident.EnableHeadersVisualStyles = False
        Me.dtGridResident.Location = New System.Drawing.Point(8, 119)
        Me.dtGridResident.Name = "dtGridResident"
        Me.dtGridResident.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtGridResident.RowHeadersVisible = False
        Me.dtGridResident.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtGridResident.ShowEditingIcon = False
        Me.dtGridResident.Size = New System.Drawing.Size(1146, 599)
        Me.dtGridResident.TabIndex = 1
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.Width = 50
        '
        'edit
        '
        Me.edit.HeaderText = ""
        Me.edit.Name = "edit"
        Me.edit.Width = 50
        '
        'nickname
        '
        Me.nickname.HeaderText = "Resident No."
        Me.nickname.Name = "nickname"
        Me.nickname.Width = 120
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
        'purok
        '
        Me.purok.HeaderText = "Purok"
        Me.purok.Name = "purok"
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
        Me.birthdate.HeaderText = "Age"
        Me.birthdate.Name = "birthdate"
        '
        'voterstatus
        '
        Me.voterstatus.HeaderText = "isRegVoter"
        Me.voterstatus.Name = "voterstatus"
        Me.voterstatus.Width = 90
        '
        'employmentstatus
        '
        Me.employmentstatus.HeaderText = "Years Residing"
        Me.employmentstatus.Name = "employmentstatus"
        Me.employmentstatus.Width = 90
        '
        'occupation
        '
        Me.occupation.HeaderText = "Occupation"
        Me.occupation.Name = "occupation"
        '
        'religion
        '
        Me.religion.HeaderText = "Religion"
        Me.religion.Name = "religion"
        '
        'btnAddResident
        '
        Me.btnAddResident.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnAddResident.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddResident.FlatAppearance.BorderSize = 0
        Me.btnAddResident.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddResident.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAddResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddResident.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddResident.Image = CType(resources.GetObject("btnAddResident.Image"), System.Drawing.Image)
        Me.btnAddResident.Location = New System.Drawing.Point(973, 8)
        Me.btnAddResident.Name = "btnAddResident"
        Me.btnAddResident.Size = New System.Drawing.Size(180, 43)
        Me.btnAddResident.TabIndex = 19
        Me.btnAddResident.Text = "  Add Resident"
        Me.btnAddResident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddResident.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Search by"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Info
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(438, 74)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(716, 38)
        Me.txtSearch.TabIndex = 53
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.Transparent
        Me.backButton.BackgroundImage = CType(resources.GetObject("backButton.BackgroundImage"), System.Drawing.Image)
        Me.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.backButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backButton.Location = New System.Drawing.Point(8, 9)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(40, 33)
        Me.backButton.TabIndex = 57
        Me.backButton.TabStop = False
        '
        'rbFirstName
        '
        Me.rbFirstName.AutoSize = True
        Me.rbFirstName.Location = New System.Drawing.Point(141, 17)
        Me.rbFirstName.Name = "rbFirstName"
        Me.rbFirstName.Size = New System.Drawing.Size(75, 17)
        Me.rbFirstName.TabIndex = 59
        Me.rbFirstName.TabStop = True
        Me.rbFirstName.Text = "First Name"
        Me.rbFirstName.UseVisualStyleBackColor = True
        '
        'rbLastName
        '
        Me.rbLastName.AutoSize = True
        Me.rbLastName.Location = New System.Drawing.Point(238, 17)
        Me.rbLastName.Name = "rbLastName"
        Me.rbLastName.Size = New System.Drawing.Size(76, 17)
        Me.rbLastName.TabIndex = 60
        Me.rbLastName.TabStop = True
        Me.rbLastName.Text = "Last Name"
        Me.rbLastName.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbResidentNumber)
        Me.GroupBox1.Controls.Add(Me.rbFirstName)
        Me.GroupBox1.Controls.Add(Me.rbLastName)
        Me.GroupBox1.Location = New System.Drawing.Point(98, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 45)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'rbResidentNumber
        '
        Me.rbResidentNumber.AutoSize = True
        Me.rbResidentNumber.Location = New System.Drawing.Point(18, 17)
        Me.rbResidentNumber.Name = "rbResidentNumber"
        Me.rbResidentNumber.Size = New System.Drawing.Size(107, 17)
        Me.rbResidentNumber.TabIndex = 62
        Me.rbResidentNumber.TabStop = True
        Me.rbResidentNumber.Text = "Resident Number"
        Me.rbResidentNumber.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label14.Enabled = False
        Me.Label14.Location = New System.Drawing.Point(13, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1140, 1)
        Me.Label14.TabIndex = 67
        '
        'ResidentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1166, 730)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAddResident)
        Me.Controls.Add(Me.dtGridResident)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ResidentList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Residents"
        CType(Me.dtGridResident, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtGridResident As DataGridView
    Friend WithEvents btnAddResident As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents backButton As PictureBox
    Friend WithEvents rbFirstName As RadioButton
    Friend WithEvents rbLastName As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents nickname As DataGridViewTextBoxColumn
    Friend WithEvents first_name As DataGridViewTextBoxColumn
    Friend WithEvents middle_name As DataGridViewTextBoxColumn
    Friend WithEvents last_name As DataGridViewTextBoxColumn
    Friend WithEvents purok As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents civilstatus As DataGridViewTextBoxColumn
    Friend WithEvents birthdate As DataGridViewTextBoxColumn
    Friend WithEvents voterstatus As DataGridViewTextBoxColumn
    Friend WithEvents employmentstatus As DataGridViewTextBoxColumn
    Friend WithEvents occupation As DataGridViewTextBoxColumn
    Friend WithEvents religion As DataGridViewTextBoxColumn
    Friend WithEvents rbResidentNumber As RadioButton
End Class
