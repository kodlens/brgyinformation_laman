Imports MySql.Data.MySqlClient


Public Class WaterSource


    Public Sub fillComboBox(ByVal cmb As ComboBox)
        cmb.Items.Clear()

        conOpen()
        query = "select * from water_sources order by water_source asc"
        cmd = New MySqlCommand(query, con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader

        'subject for refactoring
        While dr.Read
            cmb.Items.Add(Convert.ToString(dr("water_source")))
        End While
        dr.Dispose()
        cmd.Dispose()
        conClose()
    End Sub

    Public Sub fillComboBoxPerCon(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        query = "select * from water_sources order by water_source asc"
        cmd = New MySqlCommand(query, con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader

        'subject for refactoring
        While dr.Read
            cmb.Items.Add(Convert.ToString(dr("water_source")))
        End While
        dr.Dispose()
        cmd.Dispose()

    End Sub


End Class
