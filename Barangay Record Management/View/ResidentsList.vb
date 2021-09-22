Public Class ResidentList
    Dim res As New Resident


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadData()

    End Sub

    Public Sub LoadData()
        res.All(dtGridResident)
    End Sub
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

    Private Sub NewResidentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewResidentToolStripMenuItem.Click
        btnAddResident_Click_1(sender, e)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim diagResult As DialogResult = MessageBox.Show("Are you sure you want to delete this data?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If diagResult = DialogResult.Yes Then
            res.Delete(CInt(Me.dtGridResident.SelectedRows(0).Cells(0).Value))
            Box.InfoBox("Deleted successfully")
            LoadData()
        End If
    End Sub
End Class