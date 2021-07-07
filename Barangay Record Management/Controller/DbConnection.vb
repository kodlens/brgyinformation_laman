Imports MySql.Data.MySqlClient
Module DbConnection
    Public conn As New MySqlConnection
    Public sql As String
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public Sub CreateDbConnection()


        Try
            conn.ConnectionString = "Server= '" & My.Settings.ServerAddress & "';Port='" & My.Settings.ServerPort & "';Database='" & My.Settings.DatabaseName & "';Uid='" & My.Settings.UserID & "';Pwd='" & My.Settings.UserPassword & "'"

        Catch ex As Exception
            MsgBox("Failed to establish database connection!", MsgBoxStyle.Critical)

        End Try

    End Sub

End Module
