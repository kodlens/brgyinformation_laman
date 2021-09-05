Imports MySql.Data.MySqlClient
Public Class frmDashboard

    Private Sub frmAdministrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()
        labDate.Text = Date.Now.ToString("MMMM d, yyyy")
        HidePanels()
        HideSecondaryPanel()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labTime.Text = Date.Now.ToString("hh:mm:ss tt")


    End Sub

    Private Sub PanelVisibility()
        panelSecretary.Visible = False
        panelTreasurer.Visible = False
        panelBHW.Visible = False


    End Sub
    Private Sub HidePanels()
        If panelSecretary.Visible = True Then
            panelSecretary.Visible = False
        End If

        If panelTreasurer.Visible = True Then
            panelTreasurer.Visible = False
        End If

        If panelBHW.Visible = True Then
            panelBHW.Visible = False
        End If

    End Sub
    Private Sub ShowPanel(ByVal subPanel As Panel)

        If subPanel.Visible = False Then
            HidePanels()
            subPanel.Visible = True
        Else
            subPanel.Visible = False
        End If

    End Sub
    Private Sub HideSecondaryPanel()

        If panelSubClearance.Visible = True Then
            panelSubClearance.Visible = False
        End If
        If panelSubCertification.Visible = True Then
            panelSubCertification.Visible = False
        End If

    End Sub
    Private Sub ShowSecondaryPanel(ByVal subPanel As Panel)

        If subPanel.Visible = False Then
            HideSecondaryPanel()
            subPanel.Visible = True
        Else
            subPanel.Visible = False
        End If

    End Sub

    Private Sub btnSecretary_Click(sender As Object, e As EventArgs) Handles btnSecretary.Click
        ShowPanel(panelSecretary)
        HideSecondaryPanel()

    End Sub

    Private Sub btnResident_Click(sender As Object, e As EventArgs) Handles btnResident.Click
        insertNewForm(New ResidentList)
        HidePanels()
    End Sub

    Private Sub btnClearance_Click(sender As Object, e As EventArgs) Handles btnClearance.Click

        ShowSecondaryPanel(panelSubClearance)

    End Sub


    Private Sub btnTreasCedula_Click(sender As Object, e As EventArgs) Handles btnTreasCedula.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnCashflow_Click(sender As Object, e As EventArgs) Handles btnCashflow.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnTreasReports_Click(sender As Object, e As EventArgs) Handles btnDisbursement.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnCencus_Click(sender As Object, e As EventArgs) Handles btnCencus.Click
        insertNewForm(New ResidentProfile)

        HidePanels()
    End Sub

    Private Sub btnHealthcare_Click(sender As Object, e As EventArgs) Handles btnPreNatal.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnDiseases_Click(sender As Object, e As EventArgs) Handles btnImmunize.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnBHWReports_Click(sender As Object, e As EventArgs) Handles btnBHWReports.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnTreasurer_Click(sender As Object, e As EventArgs) Handles btnTreasurer.Click
        ShowPanel(panelTreasurer)
    End Sub

    Private Sub btnBHW_Click(sender As Object, e As EventArgs) Handles btnBHW.Click
        ShowPanel(panelBHW)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Me.Close()
        With frmLogin
            .Show()
            .txtUsername.Focus()
        End With
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        insertNewForm(New frmOptions)
        HidePanels()
    End Sub

    Private Sub btnCertification_Click(sender As Object, e As EventArgs) Handles btnCertification.Click
        ShowSecondaryPanel(panelSubCertification)
    End Sub

    Private Sub btnResidentClearance_Click(sender As Object, e As EventArgs) Handles btnResidentClearance.Click
        insertNewForm(New Clearances)
        HidePanels()
        HideSecondaryPanel()
    End Sub

    Private Sub frmDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmLogin.Show()
    End Sub
End Class