
Imports MySql.Data.MySqlClient

Public Class Nationality

    Public Sub all(ByVal cmb As ComboBox)
        conOpen()
        query = "select * from nationalities order by nationality asc"
        cmd = New MySqlCommand(query, con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            cmb.Items.Add(Convert.ToString(dr("nationality")))
        End While
        dr.Dispose()
        cmd.Dispose()
        conClose()

    End Sub




End Class
