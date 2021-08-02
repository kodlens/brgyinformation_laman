<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.sideMenuPanel = New System.Windows.Forms.Panel()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.panelKagawad = New System.Windows.Forms.Panel()
        Me.btnKagawadReports = New System.Windows.Forms.Button()
        Me.btnWomens = New System.Windows.Forms.Button()
        Me.btnSenior = New System.Windows.Forms.Button()
        Me.btnLivelihood = New System.Windows.Forms.Button()
        Me.btnOSY = New System.Windows.Forms.Button()
        Me.btnBrgyOfficial = New System.Windows.Forms.Button()
        Me.panelBHW = New System.Windows.Forms.Panel()
        Me.btnBHWReports = New System.Windows.Forms.Button()
        Me.btnDiseases = New System.Windows.Forms.Button()
        Me.btnHealthcare = New System.Windows.Forms.Button()
        Me.btnCencus = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnBHW = New System.Windows.Forms.Button()
        Me.panelTreasurer = New System.Windows.Forms.Panel()
        Me.btnTreasReports = New System.Windows.Forms.Button()
        Me.btnCashflow = New System.Windows.Forms.Button()
        Me.btnTreasCedula = New System.Windows.Forms.Button()
        Me.btnTreasurer = New System.Windows.Forms.Button()
        Me.panelSecretary = New System.Windows.Forms.Panel()
        Me.btnSecReports = New System.Windows.Forms.Button()
        Me.btnSession = New System.Windows.Forms.Button()
        Me.btnSummon = New System.Windows.Forms.Button()
        Me.btnClearance = New System.Windows.Forms.Button()
        Me.btnIssuance = New System.Windows.Forms.Button()
        Me.btnResident = New System.Windows.Forms.Button()
        Me.btnSecretary = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labTime = New System.Windows.Forms.Label()
        Me.labDate = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.formPanel = New System.Windows.Forms.Panel()
        Me.sideMenuPanel.SuspendLayout()
        Me.panelKagawad.SuspendLayout()
        Me.panelBHW.SuspendLayout()
        Me.panelTreasurer.SuspendLayout()
        Me.panelSecretary.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'sideMenuPanel
        '
        Me.sideMenuPanel.AutoScroll = True
        Me.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.sideMenuPanel.Controls.Add(Me.btnOptions)
        Me.sideMenuPanel.Controls.Add(Me.panelKagawad)
        Me.sideMenuPanel.Controls.Add(Me.btnBrgyOfficial)
        Me.sideMenuPanel.Controls.Add(Me.panelBHW)
        Me.sideMenuPanel.Controls.Add(Me.btnBHW)
        Me.sideMenuPanel.Controls.Add(Me.panelTreasurer)
        Me.sideMenuPanel.Controls.Add(Me.btnTreasurer)
        Me.sideMenuPanel.Controls.Add(Me.panelSecretary)
        Me.sideMenuPanel.Controls.Add(Me.btnSecretary)
        Me.sideMenuPanel.Controls.Add(Me.Panel1)
        Me.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sideMenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.sideMenuPanel.Name = "sideMenuPanel"
        Me.sideMenuPanel.Size = New System.Drawing.Size(200, 768)
        Me.sideMenuPanel.TabIndex = 0
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOptions.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOptions.FlatAppearance.BorderSize = 0
        Me.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnOptions.Image = CType(resources.GetObject("btnOptions.Image"), System.Drawing.Image)
        Me.btnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOptions.Location = New System.Drawing.Point(0, 1324)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnOptions.Size = New System.Drawing.Size(183, 50)
        Me.btnOptions.TabIndex = 10
        Me.btnOptions.Text = "   Options"
        Me.btnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOptions.UseVisualStyleBackColor = False
        '
        'panelKagawad
        '
        Me.panelKagawad.Controls.Add(Me.btnKagawadReports)
        Me.panelKagawad.Controls.Add(Me.btnWomens)
        Me.panelKagawad.Controls.Add(Me.btnSenior)
        Me.panelKagawad.Controls.Add(Me.btnLivelihood)
        Me.panelKagawad.Controls.Add(Me.btnOSY)
        Me.panelKagawad.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelKagawad.Location = New System.Drawing.Point(0, 1122)
        Me.panelKagawad.Name = "panelKagawad"
        Me.panelKagawad.Size = New System.Drawing.Size(183, 202)
        Me.panelKagawad.TabIndex = 2
        '
        'btnKagawadReports
        '
        Me.btnKagawadReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnKagawadReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKagawadReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKagawadReports.FlatAppearance.BorderSize = 0
        Me.btnKagawadReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnKagawadReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnKagawadReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKagawadReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKagawadReports.Location = New System.Drawing.Point(0, 160)
        Me.btnKagawadReports.Name = "btnKagawadReports"
        Me.btnKagawadReports.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnKagawadReports.Size = New System.Drawing.Size(183, 40)
        Me.btnKagawadReports.TabIndex = 4
        Me.btnKagawadReports.Text = "Reports"
        Me.btnKagawadReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKagawadReports.UseVisualStyleBackColor = False
        '
        'btnWomens
        '
        Me.btnWomens.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnWomens.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWomens.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnWomens.FlatAppearance.BorderSize = 0
        Me.btnWomens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnWomens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnWomens.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWomens.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWomens.Location = New System.Drawing.Point(0, 120)
        Me.btnWomens.Name = "btnWomens"
        Me.btnWomens.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnWomens.Size = New System.Drawing.Size(183, 40)
        Me.btnWomens.TabIndex = 3
        Me.btnWomens.Text = "Womens Association"
        Me.btnWomens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWomens.UseVisualStyleBackColor = False
        '
        'btnSenior
        '
        Me.btnSenior.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSenior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSenior.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSenior.FlatAppearance.BorderSize = 0
        Me.btnSenior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSenior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSenior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSenior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSenior.Location = New System.Drawing.Point(0, 80)
        Me.btnSenior.Name = "btnSenior"
        Me.btnSenior.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnSenior.Size = New System.Drawing.Size(183, 40)
        Me.btnSenior.TabIndex = 2
        Me.btnSenior.Text = "Senior Citizen"
        Me.btnSenior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSenior.UseVisualStyleBackColor = False
        '
        'btnLivelihood
        '
        Me.btnLivelihood.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnLivelihood.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLivelihood.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLivelihood.FlatAppearance.BorderSize = 0
        Me.btnLivelihood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLivelihood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnLivelihood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLivelihood.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLivelihood.Location = New System.Drawing.Point(0, 40)
        Me.btnLivelihood.Name = "btnLivelihood"
        Me.btnLivelihood.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnLivelihood.Size = New System.Drawing.Size(183, 40)
        Me.btnLivelihood.TabIndex = 1
        Me.btnLivelihood.Text = "Livelihood"
        Me.btnLivelihood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLivelihood.UseVisualStyleBackColor = False
        '
        'btnOSY
        '
        Me.btnOSY.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnOSY.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOSY.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOSY.FlatAppearance.BorderSize = 0
        Me.btnOSY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOSY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnOSY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOSY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOSY.Location = New System.Drawing.Point(0, 0)
        Me.btnOSY.Name = "btnOSY"
        Me.btnOSY.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnOSY.Size = New System.Drawing.Size(183, 40)
        Me.btnOSY.TabIndex = 0
        Me.btnOSY.Text = "Out Of School Youth"
        Me.btnOSY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOSY.UseVisualStyleBackColor = False
        '
        'btnBrgyOfficial
        '
        Me.btnBrgyOfficial.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnBrgyOfficial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrgyOfficial.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBrgyOfficial.FlatAppearance.BorderSize = 0
        Me.btnBrgyOfficial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBrgyOfficial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnBrgyOfficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrgyOfficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrgyOfficial.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBrgyOfficial.Image = CType(resources.GetObject("btnBrgyOfficial.Image"), System.Drawing.Image)
        Me.btnBrgyOfficial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrgyOfficial.Location = New System.Drawing.Point(0, 1072)
        Me.btnBrgyOfficial.Name = "btnBrgyOfficial"
        Me.btnBrgyOfficial.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBrgyOfficial.Size = New System.Drawing.Size(183, 50)
        Me.btnBrgyOfficial.TabIndex = 8
        Me.btnBrgyOfficial.Text = "   Brgy Official"
        Me.btnBrgyOfficial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrgyOfficial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBrgyOfficial.UseVisualStyleBackColor = False
        '
        'panelBHW
        '
        Me.panelBHW.Controls.Add(Me.btnBHWReports)
        Me.panelBHW.Controls.Add(Me.btnDiseases)
        Me.panelBHW.Controls.Add(Me.btnHealthcare)
        Me.panelBHW.Controls.Add(Me.btnCencus)
        Me.panelBHW.Controls.Add(Me.btnInventory)
        Me.panelBHW.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBHW.Location = New System.Drawing.Point(0, 870)
        Me.panelBHW.Name = "panelBHW"
        Me.panelBHW.Size = New System.Drawing.Size(183, 202)
        Me.panelBHW.TabIndex = 6
        '
        'btnBHWReports
        '
        Me.btnBHWReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnBHWReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBHWReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBHWReports.FlatAppearance.BorderSize = 0
        Me.btnBHWReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBHWReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnBHWReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBHWReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBHWReports.Location = New System.Drawing.Point(0, 160)
        Me.btnBHWReports.Name = "btnBHWReports"
        Me.btnBHWReports.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnBHWReports.Size = New System.Drawing.Size(183, 40)
        Me.btnBHWReports.TabIndex = 4
        Me.btnBHWReports.Text = "Reports"
        Me.btnBHWReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBHWReports.UseVisualStyleBackColor = False
        '
        'btnDiseases
        '
        Me.btnDiseases.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnDiseases.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiseases.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDiseases.FlatAppearance.BorderSize = 0
        Me.btnDiseases.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDiseases.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnDiseases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiseases.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiseases.Location = New System.Drawing.Point(0, 120)
        Me.btnDiseases.Name = "btnDiseases"
        Me.btnDiseases.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnDiseases.Size = New System.Drawing.Size(183, 40)
        Me.btnDiseases.TabIndex = 3
        Me.btnDiseases.Text = "Diseases"
        Me.btnDiseases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiseases.UseVisualStyleBackColor = False
        '
        'btnHealthcare
        '
        Me.btnHealthcare.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnHealthcare.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHealthcare.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHealthcare.FlatAppearance.BorderSize = 0
        Me.btnHealthcare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnHealthcare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnHealthcare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHealthcare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHealthcare.Location = New System.Drawing.Point(0, 80)
        Me.btnHealthcare.Name = "btnHealthcare"
        Me.btnHealthcare.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnHealthcare.Size = New System.Drawing.Size(183, 40)
        Me.btnHealthcare.TabIndex = 2
        Me.btnHealthcare.Text = "Healthcare"
        Me.btnHealthcare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHealthcare.UseVisualStyleBackColor = False
        '
        'btnCencus
        '
        Me.btnCencus.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCencus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCencus.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCencus.FlatAppearance.BorderSize = 0
        Me.btnCencus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCencus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCencus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCencus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCencus.Location = New System.Drawing.Point(0, 40)
        Me.btnCencus.Name = "btnCencus"
        Me.btnCencus.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCencus.Size = New System.Drawing.Size(183, 40)
        Me.btnCencus.TabIndex = 1
        Me.btnCencus.Text = "Census"
        Me.btnCencus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCencus.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Location = New System.Drawing.Point(0, 0)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnInventory.Size = New System.Drawing.Size(183, 40)
        Me.btnInventory.TabIndex = 0
        Me.btnInventory.Text = "Medicine Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnBHW
        '
        Me.btnBHW.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnBHW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBHW.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBHW.FlatAppearance.BorderSize = 0
        Me.btnBHW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBHW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnBHW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBHW.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBHW.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBHW.Image = CType(resources.GetObject("btnBHW.Image"), System.Drawing.Image)
        Me.btnBHW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBHW.Location = New System.Drawing.Point(0, 820)
        Me.btnBHW.Name = "btnBHW"
        Me.btnBHW.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnBHW.Size = New System.Drawing.Size(183, 50)
        Me.btnBHW.TabIndex = 5
        Me.btnBHW.Text = "   BHW"
        Me.btnBHW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBHW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBHW.UseVisualStyleBackColor = False
        '
        'panelTreasurer
        '
        Me.panelTreasurer.Controls.Add(Me.btnTreasReports)
        Me.panelTreasurer.Controls.Add(Me.btnCashflow)
        Me.panelTreasurer.Controls.Add(Me.btnTreasCedula)
        Me.panelTreasurer.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTreasurer.Location = New System.Drawing.Point(0, 698)
        Me.panelTreasurer.Name = "panelTreasurer"
        Me.panelTreasurer.Size = New System.Drawing.Size(183, 122)
        Me.panelTreasurer.TabIndex = 4
        '
        'btnTreasReports
        '
        Me.btnTreasReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnTreasReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTreasReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTreasReports.FlatAppearance.BorderSize = 0
        Me.btnTreasReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTreasReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnTreasReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreasReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTreasReports.Location = New System.Drawing.Point(0, 80)
        Me.btnTreasReports.Name = "btnTreasReports"
        Me.btnTreasReports.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnTreasReports.Size = New System.Drawing.Size(183, 40)
        Me.btnTreasReports.TabIndex = 2
        Me.btnTreasReports.Text = "Reports"
        Me.btnTreasReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTreasReports.UseVisualStyleBackColor = False
        '
        'btnCashflow
        '
        Me.btnCashflow.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCashflow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCashflow.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCashflow.FlatAppearance.BorderSize = 0
        Me.btnCashflow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCashflow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnCashflow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCashflow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashflow.Location = New System.Drawing.Point(0, 40)
        Me.btnCashflow.Name = "btnCashflow"
        Me.btnCashflow.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnCashflow.Size = New System.Drawing.Size(183, 40)
        Me.btnCashflow.TabIndex = 1
        Me.btnCashflow.Text = "Cash Flow"
        Me.btnCashflow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashflow.UseVisualStyleBackColor = False
        '
        'btnTreasCedula
        '
        Me.btnTreasCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnTreasCedula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTreasCedula.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTreasCedula.FlatAppearance.BorderSize = 0
        Me.btnTreasCedula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTreasCedula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnTreasCedula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreasCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTreasCedula.Location = New System.Drawing.Point(0, 0)
        Me.btnTreasCedula.Name = "btnTreasCedula"
        Me.btnTreasCedula.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnTreasCedula.Size = New System.Drawing.Size(183, 40)
        Me.btnTreasCedula.TabIndex = 0
        Me.btnTreasCedula.Text = "Cedula"
        Me.btnTreasCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTreasCedula.UseVisualStyleBackColor = False
        '
        'btnTreasurer
        '
        Me.btnTreasurer.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnTreasurer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTreasurer.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTreasurer.FlatAppearance.BorderSize = 0
        Me.btnTreasurer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTreasurer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnTreasurer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTreasurer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTreasurer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTreasurer.Image = CType(resources.GetObject("btnTreasurer.Image"), System.Drawing.Image)
        Me.btnTreasurer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTreasurer.Location = New System.Drawing.Point(0, 648)
        Me.btnTreasurer.Name = "btnTreasurer"
        Me.btnTreasurer.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnTreasurer.Size = New System.Drawing.Size(183, 50)
        Me.btnTreasurer.TabIndex = 3
        Me.btnTreasurer.Text = "   Treasurer"
        Me.btnTreasurer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTreasurer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTreasurer.UseVisualStyleBackColor = False
        '
        'panelSecretary
        '
        Me.panelSecretary.Controls.Add(Me.btnSecReports)
        Me.panelSecretary.Controls.Add(Me.btnSession)
        Me.panelSecretary.Controls.Add(Me.btnSummon)
        Me.panelSecretary.Controls.Add(Me.btnClearance)
        Me.panelSecretary.Controls.Add(Me.btnIssuance)
        Me.panelSecretary.Controls.Add(Me.btnResident)
        Me.panelSecretary.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSecretary.Location = New System.Drawing.Point(0, 326)
        Me.panelSecretary.Name = "panelSecretary"
        Me.panelSecretary.Size = New System.Drawing.Size(183, 322)
        Me.panelSecretary.TabIndex = 2
        '
        'btnSecReports
        '
        Me.btnSecReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSecReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSecReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSecReports.FlatAppearance.BorderSize = 0
        Me.btnSecReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSecReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSecReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSecReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecReports.Location = New System.Drawing.Point(0, 200)
        Me.btnSecReports.Name = "btnSecReports"
        Me.btnSecReports.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnSecReports.Size = New System.Drawing.Size(183, 40)
        Me.btnSecReports.TabIndex = 10
        Me.btnSecReports.Text = "Reports"
        Me.btnSecReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSecReports.UseVisualStyleBackColor = False
        '
        'btnSession
        '
        Me.btnSession.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSession.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSession.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSession.FlatAppearance.BorderSize = 0
        Me.btnSession.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSession.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSession.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSession.Location = New System.Drawing.Point(0, 160)
        Me.btnSession.Name = "btnSession"
        Me.btnSession.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnSession.Size = New System.Drawing.Size(183, 40)
        Me.btnSession.TabIndex = 9
        Me.btnSession.Text = "Kasabutan"
        Me.btnSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSession.UseVisualStyleBackColor = False
        '
        'btnSummon
        '
        Me.btnSummon.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnSummon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSummon.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSummon.FlatAppearance.BorderSize = 0
        Me.btnSummon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSummon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSummon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSummon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummon.Location = New System.Drawing.Point(0, 120)
        Me.btnSummon.Name = "btnSummon"
        Me.btnSummon.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnSummon.Size = New System.Drawing.Size(183, 40)
        Me.btnSummon.TabIndex = 7
        Me.btnSummon.Text = "Summon"
        Me.btnSummon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummon.UseVisualStyleBackColor = False
        '
        'btnClearance
        '
        Me.btnClearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnClearance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClearance.FlatAppearance.BorderSize = 0
        Me.btnClearance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClearance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnClearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearance.Location = New System.Drawing.Point(0, 80)
        Me.btnClearance.Name = "btnClearance"
        Me.btnClearance.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnClearance.Size = New System.Drawing.Size(183, 40)
        Me.btnClearance.TabIndex = 4
        Me.btnClearance.Text = "Certification"
        Me.btnClearance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearance.UseVisualStyleBackColor = False
        '
        'btnIssuance
        '
        Me.btnIssuance.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnIssuance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIssuance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIssuance.FlatAppearance.BorderSize = 0
        Me.btnIssuance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIssuance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnIssuance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIssuance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIssuance.Location = New System.Drawing.Point(0, 40)
        Me.btnIssuance.Name = "btnIssuance"
        Me.btnIssuance.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnIssuance.Size = New System.Drawing.Size(183, 40)
        Me.btnIssuance.TabIndex = 3
        Me.btnIssuance.Text = "Clearance"
        Me.btnIssuance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIssuance.UseVisualStyleBackColor = False
        '
        'btnResident
        '
        Me.btnResident.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnResident.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResident.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnResident.FlatAppearance.BorderSize = 0
        Me.btnResident.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnResident.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResident.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResident.Location = New System.Drawing.Point(0, 0)
        Me.btnResident.Name = "btnResident"
        Me.btnResident.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnResident.Size = New System.Drawing.Size(183, 40)
        Me.btnResident.TabIndex = 2
        Me.btnResident.Text = "Resident"
        Me.btnResident.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResident.UseVisualStyleBackColor = False
        '
        'btnSecretary
        '
        Me.btnSecretary.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSecretary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSecretary.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSecretary.FlatAppearance.BorderSize = 0
        Me.btnSecretary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSecretary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSecretary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSecretary.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecretary.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSecretary.Image = CType(resources.GetObject("btnSecretary.Image"), System.Drawing.Image)
        Me.btnSecretary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSecretary.Location = New System.Drawing.Point(0, 276)
        Me.btnSecretary.Name = "btnSecretary"
        Me.btnSecretary.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnSecretary.Size = New System.Drawing.Size(183, 50)
        Me.btnSecretary.TabIndex = 2
        Me.btnSecretary.Text = "   Secretary"
        Me.btnSecretary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSecretary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSecretary.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 276)
        Me.Panel1.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(36, 206)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(110, 28)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(33, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Administrator"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(28, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 126)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'labTime
        '
        Me.labTime.AutoSize = True
        Me.labTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labTime.Location = New System.Drawing.Point(972, 21)
        Me.labTime.Name = "labTime"
        Me.labTime.Size = New System.Drawing.Size(167, 31)
        Me.labTime.TabIndex = 2
        Me.labTime.Text = "10:59:27 PM"
        '
        'labDate
        '
        Me.labDate.AutoSize = True
        Me.labDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.labDate.Location = New System.Drawing.Point(714, 21)
        Me.labDate.Name = "labDate"
        Me.labDate.Size = New System.Drawing.Size(236, 31)
        Me.labDate.TabIndex = 1
        Me.labDate.Text = "December 2, 2020"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.labDate)
        Me.Panel2.Controls.Add(Me.labTime)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1166, 77)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(31, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "DocuCentral "
        '
        'Timer1
        '
        '
        'formPanel
        '
        Me.formPanel.Location = New System.Drawing.Point(208, 88)
        Me.formPanel.Name = "formPanel"
        Me.formPanel.Size = New System.Drawing.Size(1147, 668)
        Me.formPanel.TabIndex = 3
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.formPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.sideMenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "              "
        Me.sideMenuPanel.ResumeLayout(False)
        Me.panelKagawad.ResumeLayout(False)
        Me.panelBHW.ResumeLayout(False)
        Me.panelTreasurer.ResumeLayout(False)
        Me.panelSecretary.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sideMenuPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labTime As Label
    Friend WithEvents labDate As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSecretary As Button
    Friend WithEvents panelKagawad As Panel
    Friend WithEvents btnWomens As Button
    Friend WithEvents btnSenior As Button
    Friend WithEvents btnLivelihood As Button
    Friend WithEvents btnOSY As Button
    Friend WithEvents btnBrgyOfficial As Button
    Friend WithEvents panelBHW As Panel
    Friend WithEvents btnBHWReports As Button
    Friend WithEvents btnDiseases As Button
    Friend WithEvents btnHealthcare As Button
    Friend WithEvents btnCencus As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnBHW As Button
    Friend WithEvents panelTreasurer As Panel
    Friend WithEvents btnTreasReports As Button
    Friend WithEvents btnCashflow As Button
    Friend WithEvents btnTreasCedula As Button
    Friend WithEvents btnTreasurer As Button
    Friend WithEvents panelSecretary As Panel
    Friend WithEvents btnSecReports As Button
    Friend WithEvents btnSummon As Button
    Friend WithEvents btnClearance As Button
    Friend WithEvents btnIssuance As Button
    Friend WithEvents btnResident As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnKagawadReports As Button
    Friend WithEvents formPanel As Panel
    Friend WithEvents btnSession As Button
End Class
