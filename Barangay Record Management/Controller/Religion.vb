Imports MySql.Data.MySqlClient
Public Class Religion


    Public Religion As String

    Public Sub all(ByVal cmb As ComboBox)
        Try
            conOpen()
            query = "select * from religions order by religion asc"
            cmd = New MySqlCommand(query, con)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                cmb.Items.Add(Convert.ToString(dr("religion")))
            End While
            dr.Dispose()
            cmd.Dispose()
            conClose()
        Catch ex As Exception
            ErrBox(ex.Message)

        End Try


    End Sub


    Public Function Save() As Integer
        Dim i As Integer = 0
        Try
            conOpen()
            query = "INSERT INTO religions SET religion=@rel"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@rel", Me.Religion)
            i = cmd.ExecuteNonQuery()
            cmd.Dispose()
            conClose()
            Return i
        Catch ex As Exception
            ErrBox(ex.Message)
            Return 0
        End Try
    End Function

    Public Function Update(ByVal id As Integer) As Integer
        Dim i As Integer = 0
        Try
            conOpen()
            query = "UPDATE religions SET religion=@rel WHERE religion_id = @id"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@rel", Me.Religion)
            cmd.Parameters.AddWithValue("@id", id)
            i = cmd.ExecuteNonQuery()
            cmd.Dispose()
            conClose()
            Return i
        Catch ex As Exception
            ErrBox(ex.Message)
            Return 0
        End Try
    End Function

    Public Function Delete(ByVal id As Integer) As Integer
        Dim i As Integer = 0
        Try
            conOpen()
            query = "DELETE FROM religions WHERE religion_id = @id"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            i = cmd.ExecuteNonQuery()
            cmd.Dispose()
            conClose()
            Return i
        Catch ex As Exception
            ErrBox(ex.Message)
            Return 0
        End Try
    End Function
End Class
