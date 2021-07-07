<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlotterList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlotterList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddBlotter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.closeButton = New System.Windows.Forms.PictureBox()
        Me.edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.incidentType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.incidentdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.incidentTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.complainant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recordedby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateRecorded = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddBlotter
        '
        Me.btnAddBlotter.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnAddBlotter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddBlotter.FlatAppearance.BorderSize = 0
        Me.btnAddBlotter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddBlotter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAddBlotter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBlotter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBlotter.Image = CType(resources.GetObject("btnAddBlotter.Image"), System.Drawing.Image)
        Me.btnAddBlotter.Location = New System.Drawing.Point(859, 6)
        Me.btnAddBlotter.Name = "btnAddBlotter"
        Me.btnAddBlotter.Size = New System.Drawing.Size(178, 35)
        Me.btnAddBlotter.TabIndex = 21
        Me.btnAddBlotter.Text = "  Add Blotter"
        Me.btnAddBlotter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddBlotter.UseVisualStyleBackColor = False
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.edit, Me.incidentType, Me.incidentdate, Me.incidentTime, Me.address, Me.status, Me.complainant, Me.recordedby, Me.dateRecorded})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(8, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 65
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 45
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1129, 613)
        Me.DataGridView1.TabIndex = 20
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Transparent
        Me.closeButton.BackgroundImage = CType(resources.GetObject("closeButton.BackgroundImage"), System.Drawing.Image)
        Me.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeButton.Location = New System.Drawing.Point(1111, 6)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(24, 24)
        Me.closeButton.TabIndex = 52
        Me.closeButton.TabStop = False
        '
        'edit
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        Me.edit.DefaultCellStyle = DataGridViewCellStyle2
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit.HeaderText = ""
        Me.edit.Name = "edit"
        Me.edit.Text = "Edit"
        Me.edit.UseColumnTextForButtonValue = True
        Me.edit.Width = 90
        '
        'incidentType
        '
        Me.incidentType.DataPropertyName = "incident_type"
        Me.incidentType.HeaderText = "Incident Type"
        Me.incidentType.Name = "incidentType"
        Me.incidentType.Width = 160
        '
        'incidentdate
        '
        Me.incidentdate.DataPropertyName = "incident_date"
        Me.incidentdate.HeaderText = "Incident Date"
        Me.incidentdate.Name = "incidentdate"
        Me.incidentdate.Width = 110
        '
        'incidentTime
        '
        Me.incidentTime.DataPropertyName = "incident_time"
        Me.incidentTime.HeaderText = "Incident Time"
        Me.incidentTime.Name = "incidentTime"
        Me.incidentTime.Width = 120
        '
        'address
        '
        Me.address.DataPropertyName = "incident_location"
        Me.address.HeaderText = "Incident Location"
        Me.address.Name = "address"
        Me.address.Width = 180
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.Width = 120
        '
        'complainant
        '
        Me.complainant.DataPropertyName = "complainant"
        Me.complainant.HeaderText = "Complainant"
        Me.complainant.Name = "complainant"
        Me.complainant.Width = 150
        '
        'recordedby
        '
        Me.recordedby.DataPropertyName = "recorded_by"
        Me.recordedby.HeaderText = "Recorded By"
        Me.recordedby.Name = "recordedby"
        Me.recordedby.Width = 120
        '
        'dateRecorded
        '
        Me.dateRecorded.DataPropertyName = "date_reported"
        Me.dateRecorded.HeaderText = "Date Recorded"
        Me.dateRecorded.Name = "dateRecorded"
        Me.dateRecorded.Width = 150
        '
        'frmBlotterList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 668)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.btnAddBlotter)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBlotterList"
        Me.Text = "BlotterList"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddBlotter As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents closeButton As PictureBox
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents incidentType As DataGridViewTextBoxColumn
    Friend WithEvents incidentdate As DataGridViewTextBoxColumn
    Friend WithEvents incidentTime As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents complainant As DataGridViewTextBoxColumn
    Friend WithEvents recordedby As DataGridViewTextBoxColumn
    Friend WithEvents dateRecorded As DataGridViewTextBoxColumn
End Class
