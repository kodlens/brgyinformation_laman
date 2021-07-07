Public Class frmOptions
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub frmOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelSearch.Visible = False
        panelPurok.Visible = False

        If txtPresident.Text.Length > 0 Then

        End If





    End Sub

    Private Sub checkIfRegistered_CheckedChanged(sender As Object, e As EventArgs) Handles checkIfRegistered.CheckedChanged

        panelSearch.Location = New Point(438, 33)

        If checkIfRegistered.Checked Then
            btnAddUser.Enabled = False
            txtFirstName.Enabled = False
            txtMiddleName.Enabled = False
            txtLastName.Enabled = False
            panelSearch.Visible = True
            txtSearch.Focus()
        Else

            txtFirstName.Enabled = True
            txtMiddleName.Enabled = True
            txtLastName.Enabled = True
            panelSearch.Visible = False
        End If
    End Sub

    Private Sub closeYellowBtn_Click(sender As Object, e As EventArgs) Handles closeYellowBtn.Click
        panelSearch.Visible = False
        btnAddUser.Enabled = True
        txtUsername.Focus()
        txtSearch.Text = ""
    End Sub

    Private Sub checkPurok_CheckedChanged(sender As Object, e As EventArgs) Handles checkPurok.CheckedChanged

        panelPurok.Location = New Point(438, 35)

        If checkPurok.Checked Then
            btnAddPurok.Enabled = False
            panelPurok.Visible = True
            txtSearch.Focus()
        Else
            panelSearch.Visible = False
        End If
    End Sub

    Private Sub closeSearch_Click(sender As Object, e As EventArgs) Handles closeSearch.Click
        panelPurok.Visible = False
        btnAddPurok.Enabled = True
        TextBox1.Text = ""
    End Sub
End Class