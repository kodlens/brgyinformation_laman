<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatabaseSetting))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDBName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.PictureBox()
        Me.labStatus = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(25, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Server Address"
        '
        'txtServer
        '
        Me.txtServer.BackColor = System.Drawing.Color.White
        Me.txtServer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Barangay_Record_Management.My.MySettings.Default, "ServerAddress", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtServer.Location = New System.Drawing.Point(28, 93)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(172, 24)
        Me.txtServer.TabIndex = 0
        Me.txtServer.Text = Global.Barangay_Record_Management.My.MySettings.Default.ServerAddress
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(25, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Port"
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.Color.White
        Me.txtPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Barangay_Record_Management.My.MySettings.Default, "ServerPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPort.Location = New System.Drawing.Point(28, 140)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(63, 24)
        Me.txtPort.TabIndex = 1
        Me.txtPort.Text = Global.Barangay_Record_Management.My.MySettings.Default.ServerPort
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(25, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "UserName"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Barangay_Record_Management.My.MySettings.Default, "UserID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUsername.Location = New System.Drawing.Point(28, 187)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(172, 24)
        Me.txtUsername.TabIndex = 3
        Me.txtUsername.Text = Global.Barangay_Record_Management.My.MySettings.Default.UserID
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(94, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Database Name"
        '
        'txtDBName
        '
        Me.txtDBName.BackColor = System.Drawing.Color.White
        Me.txtDBName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Barangay_Record_Management.My.MySettings.Default, "DatabaseName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtDBName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDBName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDBName.Location = New System.Drawing.Point(97, 140)
        Me.txtDBName.Name = "txtDBName"
        Me.txtDBName.Size = New System.Drawing.Size(103, 24)
        Me.txtDBName.TabIndex = 2
        Me.txtDBName.Text = Global.Barangay_Record_Management.My.MySettings.Default.DatabaseName
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(25, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Barangay_Record_Management.My.MySettings.Default, "UserPassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.Location = New System.Drawing.Point(28, 235)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(172, 24)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.Text = Global.Barangay_Record_Management.My.MySettings.Default.UserPassword
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnTest.FlatAppearance.BorderSize = 0
        Me.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(0, 293)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(231, 56)
        Me.btnTest.TabIndex = 5
        Me.btnTest.Text = "Test Connection"
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.Transparent
        Me.closeButton.BackgroundImage = CType(resources.GetObject("closeButton.BackgroundImage"), System.Drawing.Image)
        Me.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeButton.Location = New System.Drawing.Point(464, 12)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(24, 24)
        Me.closeButton.TabIndex = 16
        Me.closeButton.TabStop = False
        '
        'labStatus
        '
        Me.labStatus.AutoSize = True
        Me.labStatus.BackColor = System.Drawing.Color.Transparent
        Me.labStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labStatus.ForeColor = System.Drawing.Color.Gold
        Me.labStatus.Location = New System.Drawing.Point(25, 33)
        Me.labStatus.Name = "labStatus"
        Me.labStatus.Size = New System.Drawing.Size(134, 20)
        Me.labStatus.TabIndex = 17
        Me.labStatus.Text = "Database Setting"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(237, 293)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(231, 56)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save Setting"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmDatabaseSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(500, 350)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.labStatus)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDBName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtServer)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatabaseSetting"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatabaseSetting"
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtServer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDBName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnTest As Button
    Friend WithEvents closeButton As PictureBox
    Friend WithEvents labStatus As Label
    Friend WithEvents btnSave As Button
End Class
