Imports MySql.Data.MySqlClient
Public Class frmDashboard

    Private Sub frmAdministrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()
        labDate.Text = Date.Now.ToString("MMMM d, yyyy")
        HidePanels()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labTime.Text = Date.Now.ToString("hh:mm:ss tt")


    End Sub

    Private Sub PanelVisibility()
        panelSecretary.Visible = False
        panelTreasurer.Visible = False
        panelBHW.Visible = False
        panelKagawad.Visible = False

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

        If panelKagawad.Visible = True Then
            panelKagawad.Visible = False
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

    Private Sub btnSecretary_Click(sender As Object, e As EventArgs) Handles btnSecretary.Click
        ShowPanel(panelSecretary)
    End Sub

    Private Sub btnResident_Click(sender As Object, e As EventArgs) Handles btnResident.Click
        insertNewForm(New frmResidentsList)

        HidePanels()
    End Sub

    Private Sub btnCertification_Click(sender As Object, e As EventArgs) Handles btnIssuance.Click
        insertNewForm(New Clearances)

        HidePanels()
    End Sub

    Private Sub btnClearance_Click(sender As Object, e As EventArgs) Handles btnClearance.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnSecCedula_Click(sender As Object, e As EventArgs)
        ''code here

        HidePanels()
    End Sub

    Private Sub btnBlotter_Click(sender As Object, e As EventArgs)
        insertNewForm(New frmBlotterList)

        HidePanels()
    End Sub

    Private Sub btnSummon_Click(sender As Object, e As EventArgs) Handles btnSummon.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnOrdinance_Click(sender As Object, e As EventArgs)
        ''code here

        HidePanels()
    End Sub

    Private Sub btnSession_Click(sender As Object, e As EventArgs) Handles btnSession.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnSecReports_Click(sender As Object, e As EventArgs) Handles btnSecReports.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnTreasCedula_Click(sender As Object, e As EventArgs) Handles btnTreasCedula.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnCashflow_Click(sender As Object, e As EventArgs) Handles btnCashflow.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnTreasReports_Click(sender As Object, e As EventArgs) Handles btnTreasReports.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnCencus_Click(sender As Object, e As EventArgs) Handles btnCencus.Click
        insertNewForm(New frmResidentProfile)

        HidePanels()
    End Sub

    Private Sub btnHealthcare_Click(sender As Object, e As EventArgs) Handles btnHealthcare.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnDiseases_Click(sender As Object, e As EventArgs) Handles btnDiseases.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnBHWReports_Click(sender As Object, e As EventArgs) Handles btnBHWReports.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnOSY_Click(sender As Object, e As EventArgs) Handles btnOSY.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnLivelihood_Click(sender As Object, e As EventArgs) Handles btnLivelihood.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnSenior_Click(sender As Object, e As EventArgs) Handles btnSenior.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnWomens_Click(sender As Object, e As EventArgs) Handles btnWomens.Click
        ''code here

        HidePanels()
    End Sub

    Private Sub btnTreasurer_Click(sender As Object, e As EventArgs) Handles btnTreasurer.Click
        ShowPanel(panelTreasurer)
    End Sub

    Private Sub btnBHW_Click(sender As Object, e As EventArgs) Handles btnBHW.Click
        ShowPanel(panelBHW)
    End Sub

    Private Sub btnBrgyOfficial_Click(sender As Object, e As EventArgs) Handles btnBrgyOfficial.Click
        ShowPanel(panelKagawad)
    End Sub

    Private Sub btnKagawadReports_Click(sender As Object, e As EventArgs) Handles btnKagawadReports.Click
        ''code here

        HidePanels()
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

End Class