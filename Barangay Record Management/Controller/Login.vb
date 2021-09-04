Imports MySql.Data.MySqlClient

Public Class Login
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim query As String

    Public Function isAuth(ByVal user As String, ByVal pwd As String) As Boolean
        Try
            con = DbConnection.con
            con.Open()

            query = "select * from users where username = @user and password = sha1(@pwd)"
            cmd = New MySqlCommand(query, con)
            With cmd.Parameters
                .AddWithValue("@user", user)
                .AddWithValue("@pwd", pwd)
            End With
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader
            Dim flag As Boolean = dr.Read
            dr.Dispose()
            cmd.Dispose()
            con.Dispose()
            con.Close()
            Return flag
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
