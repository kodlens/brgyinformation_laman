Imports MySql.Data.MySqlClient
Module DbConnection
    Public Sub CreateDbConnection()
        Dim conn As New MySqlConnection
        Try
            conn.ConnectionString = "Server ='" & My.Settings.ServerAddress & "'; Username ='" & My.Settings.UserID & "';Password ='" & My.Settings.UserPassword & "'; Port ='" & My.Settings.ServerPort & "'; Database ='" & My.Settings.DatabaseName & "'"

        Catch ex As Exception
            MsgBox("Failed to establish database connection!", MsgBoxStyle.Critical)

        End Try
    End Sub

End Module
