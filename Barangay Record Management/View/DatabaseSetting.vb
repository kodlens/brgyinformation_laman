Imports MySql.Data.MySqlClient
Public Class frmDatabaseSetting
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click

        Me.Close()
        With frmLogin
            .Show()
            .txtUsername.Focus()
        End With

    End Sub
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        Dim conn As New MySqlConnection
        Dim isClick As Boolean = True

        Try
                conn.ConnectionString = "Server='" & txtServer.Text & "';Port='" & txtPort.Text & "';Database='" & txtDBName.Text & "';Uid='" & _txtUsername.Text & "';Pwd='" & txtPassword.Text & "'"
                conn.Open()

            If conn.State = ConnectionState.Open Then
                labStatus.Text = "Successfully Connected"
                btnTest.Text = "Save Settings"
                btnTest.Visible = False

                btnSave.Visible = True
                btnSave.Location = New Point(0, 293)

            End If

        Catch ex As Exception
                labStatus.Text = "Failed to Connect!"
            Finally
            conn.Close()
        End Try

    End Sub

    Private Sub IsTextboxDisabled(ByVal isTrue As Boolean)

        txtServer.Enabled = isTrue
        txtPort.Enabled = isTrue
        txtDBName.Enabled = isTrue
        txtUsername.Enabled = isTrue
        txtPassword.Enabled = isTrue
        btnTest.Enabled = isTrue

    End Sub

    Private Sub frmDatabaseSetting_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.Modifiers = Keys.Alt And e.KeyCode = Keys.E Then
            IsTextboxDisabled(True)

        End If

    End Sub

    Private Sub frmDatabaseSetting_Load(sender As Object, e As EventArgs) Handles Me.Load

        IsTextboxDisabled(False)
        btnSave.Visible = False
        Me.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        With My.Settings

            .ServerAddress = txtServer.Text
            .ServerPort = txtPort.Text
            .DatabaseName = txtDBName.Text
            .UserID = txtUsername.Text
            .UserPassword = txtPassword.Text

            .Save()
            .Reload()

        End With
        Application.Restart()

    End Sub

    Private Sub txtPort_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPort.KeyPress

        ''Just Digits
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        ''Allow Backspace
        If e.KeyChar = Convert.ToChar(8) Then
            e.Handled = False
        End If

        ''Allow Enter Key
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = False
        End If

    End Sub
End Class