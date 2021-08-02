Public Class Clearances
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()

    End Sub

    Private Sub cbClearanceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClearanceType.SelectedIndexChanged

        If cbClearanceType.SelectedIndex = 0 Then
            panelResident.Show()
            txtSearchResident.Focus()
            btnPreview.Enabled = False
            labHeader.Text = "Barangay Clearance"
            txtControlNumber.Text = ResidentClearanceControlNumber()
        End If

    End Sub

    Private Sub Clearances_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelResident.Hide()

    End Sub

End Class