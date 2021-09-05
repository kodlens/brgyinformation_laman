Imports MySql.Data.MySqlClient

Public Class Login

    Public Function isAuth(ByVal user As String, ByVal pwd As String) As Boolean
        Try
            conOpen()
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
            conClose()
            Return flag
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
