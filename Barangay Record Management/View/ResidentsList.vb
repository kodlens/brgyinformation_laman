Public Class frmResidentsList


    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub btnAddResident_Click_1(sender As Object, e As EventArgs) Handles btnAddResident.Click
        insertNewForm(New frmResidentProfile)
    End Sub
End Class