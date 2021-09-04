Public Class frmResidentProfile
    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        TabControl1.SelectedTab = tabAdditionalInfo
    End Sub

    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        TabControl1.SelectedTab = tabProfile
    End Sub

    Private Sub tbnNext2_Click(sender As Object, e As EventArgs) Handles tbnNext2.Click
        TabControl1.SelectedTab = tabFamilyMembers
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()

    End Sub

    Private Sub dtHBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtHBirthdate.ValueChanged
        ageCalculator(dtHBirthdate, txtHAge)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        If TabControl1.SelectedTab.Name = "tabProfile" Then
            txtHSerialNumber.Focus()
            rbHead.Checked = True
        ElseIf TabControl1.SelectedTab.Name = "tabAdditionalInfo" Then
            txtContactNumber.Focus()
        ElseIf TabControl1.SelectedTab.Name = "tabFamilyMembers" Then
            txtFFirstName.Focus()

        End If
    End Sub

    Private Sub frmResidentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHSerialNumber.Focus()
        rbHead.Checked = True
        frmDashboard.GeneralHeading.Text = "Resident Profile"
    End Sub
    Private Sub ageCalculator(ByVal dtPicker As DateTimePicker, ByVal ageBox As TextBox)

        Dim birthYear As Integer
        Dim currentAge As Integer
        Dim currentYear As Integer = Now.Year
        birthYear = dtPicker.Value.Year

        currentAge = currentYear - birthYear

        If dtPicker.Value.Month > Date.Now.Month Then
            ageBox.Text = CStr(currentAge - 1)
        Else
            ageBox.Text = CStr(currentAge)
        End If

    End Sub

    Private Sub dtFBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtFBirthdate.ValueChanged
        ageCalculator(dtFBirthdate, txtFAge)
    End Sub
End Class