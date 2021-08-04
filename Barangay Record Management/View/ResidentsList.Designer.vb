<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResidentsList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResidentsList))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAddResident = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.labHeader = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.PictureBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
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
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete, Me.edit, Me.nickname, Me.first_name, Me.middle_name, Me.last_name, Me.purok, Me.gender, Me.civilstatus, Me.birthdate, Me.voterstatus, Me.employmentstatus, Me.occupation, Me.religion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(8, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1127, 550)
        Me.DataGridView1.TabIndex = 1
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
        Me.btnAddResident.Location = New System.Drawing.Point(973, 12)
        Me.btnAddResident.Name = "btnAddResident"
        Me.btnAddResident.Size = New System.Drawing.Size(162, 35)
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
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Search"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(78, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(373, 38)
        Me.TextBox1.TabIndex = 53
        '
        'labHeader
        '
        Me.labHeader.AutoSize = True
        Me.labHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labHeader.Location = New System.Drawing.Point(54, 9)
        Me.labHeader.Name = "labHeader"
        Me.labHeader.Size = New System.Drawing.Size(191, 31)
        Me.labHeader.TabIndex = 58
        Me.labHeader.Text = "Residents' List"
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
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(140, 15)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton1.TabIndex = 59
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "First Name"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(237, 15)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton2.TabIndex = 60
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Last Name"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(469, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 45)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label14.Enabled = False
        Me.Label14.Location = New System.Drawing.Point(14, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1120, 1)
        Me.Label14.TabIndex = 67
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
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(17, 15)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(107, 17)
        Me.RadioButton4.TabIndex = 62
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Resident Number"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'frmResidentsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 668)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.labHeader)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnAddResident)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmResidentsList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Residents"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddResident As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents labHeader As Label
    Friend WithEvents backButton As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
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
    Friend WithEvents RadioButton4 As RadioButton
End Class
