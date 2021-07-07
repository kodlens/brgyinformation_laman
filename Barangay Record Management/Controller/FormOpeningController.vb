
Module FormOpeningController
    Private activeForm As New Form
    Public Sub insertNewForm(ByVal childForm As Form)

        If Not activeForm Is Nothing Then
            activeForm.Close()
            activeForm = childForm
            childForm.TopLevel = False
            childForm.Dock = DockStyle.Fill
            frmDashboard.formPanel.Controls.Add(childForm)
            frmDashboard.formPanel.Tag = childForm
            childForm.BringToFront()
            childForm.Show()

        End If

    End Sub

End Module
