Imports MySql.Data.MySqlClient


Public Class Contraceptive


    Public Sub fillComboBoxPerCon(ByVal cmb As ComboBox)
        cmb.Items.Clear()


        query = "select * from contraceptives order by contraceptive asc"
        cmd = New MySqlCommand(query, con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader

        'subject for refactoring
        While dr.Read
            cmb.Items.Add(Convert.ToString(dr("contraceptive")))
        End While
        dr.Dispose()
        cmd.Dispose()

    End Sub
End Class
