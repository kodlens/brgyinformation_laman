Public Class Clearances
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()

    End Sub

    Private Sub Clearances_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtSearchResident.Focus()
        btnPreview.Enabled = False
        frmDashboard.GeneralHeading.Text = "Barangay Clearance"
        txtControlNumber.Text = ResidentClearanceControlNumber()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        CreateDbConnection()
    End Sub
End Class