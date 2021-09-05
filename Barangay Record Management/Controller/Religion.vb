Imports MySql.Data.MySqlClient
Public Class Religion

    Public Sub all(ByVal cmb As ComboBox)
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

    End Sub
End Class
