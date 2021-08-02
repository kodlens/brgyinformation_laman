Imports MySql.Data.MySqlClient
Module DbConnection
    Public generalConnectionWarning As String
    Public Sub CreateDbConnection()
        Dim conn As New MySqlConnection

        Try
            conn.ConnectionString = "Server ='" & My.Settings.ServerAddress & "'; Username ='" & My.Settings.UserID & "';Password ='" & My.Settings.UserPassword & "'; Port ='" & My.Settings.ServerPort & "'; Database ='" & My.Settings.DatabaseName & "'"
            conn.Open()

        Catch ex As Exception
            'MsgBox("Failed to establish database connection!", MsgBoxStyle.Critical)
            generalConnectionWarning = "WALAY internet"

        End Try
    End Sub

End Module
