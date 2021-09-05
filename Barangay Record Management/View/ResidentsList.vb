Public Class ResidentList
    Private Sub btnAddResident_Click_1(sender As Object, e As EventArgs) Handles btnAddResident.Click
        insertNewForm(New ResidentProfile)
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
    End Sub

    Private Sub frmResidentsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Focus()
        rbResidentNumber.Checked = True
        frmDashboard.GeneralHeading.Text = "Resident List"
    End Sub
End Class