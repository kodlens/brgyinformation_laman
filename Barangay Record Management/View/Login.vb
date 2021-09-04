Public Class frmLogin

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            AcceptButton = btnLogin

        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Me.Hide()
        frmDashboard.Show()

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.Modifiers = Keys.Alt And e.KeyCode = Keys.Q Then
            Me.Hide()
            frmDatabaseSetting.Show()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''Load the previous database connection setting
        My.Settings.Reload()
    End Sub
End Class
