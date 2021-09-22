Imports MySql.Data.MySqlClient

Public Class Pet


    Public Property Pet As String


    Public Sub fillComboBoxPerCon(ByVal cmb As ComboBox)
        cmb.Items.Clear()

        query = "select * from pets order by pet asc"
        cmd = New MySqlCommand(query, con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader

        'subject for refactoring
        While dr.Read
            cmb.Items.Add(Convert.ToString(dr("pet")))
        End While
        dr.Dispose()
        cmd.Dispose()

    End Sub


    Public Sub InsertPet()

    End Sub
End Class
