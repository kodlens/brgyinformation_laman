Imports MySql.Data.MySqlClient


Module Address
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim query As String

    'this module will populate combobox

    Public Sub country(ByVal cmb As ComboBox)


        con = DbConnection.con
        con.Open()

        query = "select * from countries order by country asc"
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        Dim comboSource As New Dictionary(Of String, String)()
        'subject for refactoring
        While dr.Read
            ' cmb.Items.Add(Convert.ToString(dr("province")))
            comboSource.Add(Convert.ToString(dr("country_id")), Convert.ToString(dr("country")))
        End While
        dr.Dispose()
        cmd.Dispose()

        cmb.DataSource = New BindingSource(comboSource, Nothing)
        cmb.DisplayMember = "Value"
        cmb.ValueMember = "Key"

        'get the value
        ' Dim key As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Key
        'Dim value As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Value

        con.Dispose()
        con.Close()
    End Sub


    Public Sub province(ByVal country As String, ByVal cmb As ComboBox)
        Dim country_id As Integer

        con = DbConnection.con
        con.Open()


        query = "select * from countries where country = @country"
        cmd = New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@country", country)
        country_id = Convert.ToInt32(cmd.ExecuteScalar)
        cmd.Dispose()


        query = "select * from provinces where country_id = @c_id"
        With cmd.Parameters
            .AddWithValue("@c_id", country_id)
        End With
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        Dim comboSource As New Dictionary(Of String, String)()
        'subject for refactoring
        While dr.Read
            ' cmb.Items.Add(Convert.ToString(dr("province")))
            comboSource.Add(Convert.ToString(dr("provCode")), Convert.ToString(dr("province")))
        End While
        dr.Dispose()
        cmd.Dispose()

        cmb.DataSource = New BindingSource(comboSource, Nothing)
        cmb.DisplayMember = "Value"
        cmb.ValueMember = "Key"

        'get the value
        ' Dim key As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Key
        'Dim value As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Value

        con.Dispose()
        con.Close()
    End Sub



End Module
