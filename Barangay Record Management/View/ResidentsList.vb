Public Class frmResidentsList
    Private Sub btnAddResident_Click_1(sender As Object, e As EventArgs) Handles btnAddResident.Click
        insertNewForm(New frmResidentProfile)
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
    End Sub
End Class