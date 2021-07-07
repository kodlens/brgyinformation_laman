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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResidentsList))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middle_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nickname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.civilstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voterstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employmentstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.occupation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.religion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddResident = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(51, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete, Me.edit, Me.first_name, Me.middle_name, Me.last_name, Me.nickname, Me.gender, Me.civilstatus, Me.birthdate, Me.voterstatus, Me.purok, Me.employmentstatus, Me.occupation, Me.religion})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1147, 613)
        Me.DataGridView1.TabIndex = 1
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.Width = 75
        '
        'edit
        '
        Me.edit.HeaderText = ""
        Me.edit.Name = "edit"
        Me.edit.Width = 75
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
        'nickname
        '
        Me.nickname.HeaderText = "Alias"
        Me.nickname.Name = "nickname"
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
        'voterstatus
        '
        Me.voterstatus.HeaderText = "Voter"
        Me.voterstatus.Name = "voterstatus"
        Me.voterstatus.Width = 90
        '
        'purok
        '
        Me.purok.HeaderText = "Purok"
        Me.purok.Name = "purok"
        '
        'employmentstatus
        '
        Me.employmentstatus.HeaderText = "Employed"
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
        Me.btnAddResident.Location = New System.Drawing.Point(859, 12)
        Me.btnAddResident.Name = "btnAddResident"
        Me.btnAddResident.Size = New System.Drawing.Size(178, 35)
        Me.btnAddResident.TabIndex = 19
        Me.btnAddResident.Text = "  Add Resident"
        Me.btnAddResident.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddResident.UseVisualStyleBackColor = False
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
        Me.closeButton.TabIndex = 51
        Me.closeButton.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Search Resident"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(158, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(373, 26)
        Me.TextBox1.TabIndex = 53
        '
        'frmResidentsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 668)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.btnAddResident)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmResidentsList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Residents"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddResident As Button
    Friend WithEvents closeButton As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents first_name As DataGridViewTextBoxColumn
    Friend WithEvents middle_name As DataGridViewTextBoxColumn
    Friend WithEvents last_name As DataGridViewTextBoxColumn
    Friend WithEvents nickname As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents civilstatus As DataGridViewTextBoxColumn
    Friend WithEvents birthdate As DataGridViewTextBoxColumn
    Friend WithEvents voterstatus As DataGridViewTextBoxColumn
    Friend WithEvents purok As DataGridViewTextBoxColumn
    Friend WithEvents employmentstatus As DataGridViewTextBoxColumn
    Friend WithEvents occupation As DataGridViewTextBoxColumn
    Friend WithEvents religion As DataGridViewTextBoxColumn
End Class
