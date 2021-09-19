Imports MySql.Data.MySqlClient



Public Class Garden



    Public Sub fillComboBox(ByVal cmb As ComboBox)
        cmb.Items.Clear()

        conOpen()
        query = "select * from gardens order by garden asc"
        cmd = New MySqlCommand(query, con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader

        'subject for refactoring
        While dr.Read
            cmb.Items.Add(Convert.ToString(dr("garden")))
        End While
        dr.Dispose()
        cmd.Dispose()
        conClose()
    End Sub

    Public Sub fillComboBoxPerCon(ByVal cmb As ComboBox)
        cmb.Items.Clear()


        query = "select * from gardens order by garden asc"
        cmd = New MySqlCommand(query, con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader

        'subject for refactoring
        While dr.Read
            cmb.Items.Add(Convert.ToString(dr("garden")))
        End While
        dr.Dispose()
        cmd.Dispose()

    End Sub
End Class
