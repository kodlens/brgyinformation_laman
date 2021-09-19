Imports MySql.Data.MySqlClient


Class Addresses

    'this module will populate combobox

    'Public Sub countryKey(ByVal cmb As ComboBox)


    '    con = DbConnection.con
    '    con.Open()

    '    query = "select * from countries order by country asc"
    '    Dim dr As MySqlDataReader
    '    dr = cmd.ExecuteReader
    '    Dim comboSource As New Dictionary(Of String, String)()
    '    'subject for refactoring
    '    While dr.Read
    '        ' cmb.Items.Add(Convert.ToString(dr("province")))
    '        comboSource.Add(Convert.ToString(dr("country_id")), Convert.ToString(dr("country")))
    '    End While
    '    dr.Dispose()
    '    cmd.Dispose()

    '    cmb.DataSource = New BindingSource(comboSource, Nothing)
    '    cmb.DisplayMember = "Value"
    '    cmb.ValueMember = "Key"

    '    'get the value
    '    ' Dim key As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Key
    '    'Dim value As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Value

    '    con.Dispose()
    '    con.Close()
    'End Sub


    'Public Sub provinceKey(ByVal country As String, ByVal cmb As ComboBox)
    '    Dim country_id As Integer

    '    con = DbConnection.con
    '    con.Open()


    '    query = "select * from countries where country = @country"
    '    cmd = New MySqlCommand(query, con)
    '    cmd.Parameters.AddWithValue("@country", country)
    '    country_id = Convert.ToInt32(cmd.ExecuteScalar)
    '    cmd.Dispose()


    '    query = "select * from provinces where country_id = @c_id"
    '    With cmd.Parameters
    '        .AddWithValue("@c_id", country_id)
    '    End With
    '    Dim dr As MySqlDataReader
    '    dr = cmd.ExecuteReader
    '    Dim comboSource As New Dictionary(Of String, String)()
    '    'subject for refactoring
    '    While dr.Read
    '        ' cmb.Items.Add(Convert.ToString(dr("province")))
    '        comboSource.Add(Convert.ToString(dr("provCode")), Convert.ToString(dr("province")))
    '    End While
    '    dr.Dispose()
    '    cmd.Dispose()

    '    cmb.DataSource = New BindingSource(comboSource, Nothing)
    '    cmb.DisplayMember = "Value"
    '    cmb.ValueMember = "Key"

    '    'get the value
    '    ' Dim key As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Key
    '    'Dim value As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Value

    '    con.Dispose()
    '    con.Close()
    'End Sub
    'per Connection


    Public Sub country(ByVal cmb As ComboBox)
        cmb.Items.Clear()

        conOpen()
        query = "select * from countries order by country asc"
        cmd = New MySqlCommand(query, con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader

        'subject for refactoring
        While dr.Read
            cmb.Items.Add(Convert.ToString(dr("country")))
        End While
        dr.Dispose()
        cmd.Dispose()
        conClose()
    End Sub



    Public Sub countryPerCon(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        query = "select * from countries order by country asc"
        cmd = New MySqlCommand(query, con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader

        'subject for refactoring
        While dr.Read
            cmb.Items.Add(Convert.ToString(dr("country")))
        End While
        dr.Dispose()
        cmd.Dispose()

    End Sub

    Public Sub province(ByVal country As String, ByVal cmb As ComboBox)
        cmb.Items.Clear()
        conOpen()
        query = "SELECT * FROM provinces a JOIN countries b on a.country_id = b.country_id WHERE b.country = @c order by a.provDesc ASC"
        cmd = New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@c", country)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        'subject for refactoring
        While dr.Read
            cmb.Items.Add(Convert.ToString(dr("provDesc")))
        End While
        dr.Dispose()
        cmd.Dispose()
        conClose()
    End Sub

    Public Sub cities(ByVal province As String, ByVal cmb As ComboBox)
        cmb.Items.Clear()

        conOpen()
        query = "SELECT * FROM cities a JOIN provinces b on a.provCode = b.provCode WHERE b.provDesc = @provdesc order by a.citymunDesc asc"
        cmd = New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@provdesc", province)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        'subject for refactoring
        While dr.Read
            cmb.Items.Add(Convert.ToString(dr("citymunDesc")))
        End While
        dr.Dispose()
        cmd.Dispose()
        conClose()
    End Sub

    Public Sub barangays(ByVal province As String,
                      ByVal city As String, ByVal cmb As ComboBox)
        cmb.Items.Clear()

        conOpen()
        query = "SELECT * FROM barangays a JOIN cities b ON a.citymunCode = b.citymunCode " &
            "JOIN provinces c ON b.provCode = c.provCode " &
            "WHERE b.citymunDesc = @city AND c.provDesc = @prov"
        cmd = New MySqlCommand(query, con)
        cmd.Parameters.AddWithValue("@city", city)
        cmd.Parameters.AddWithValue("@prov", province)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader
        'subject for refactoring
        While dr.Read
            cmb.Items.Add(Convert.ToString(dr("brgyDesc")))
        End While
        dr.Dispose()
        cmd.Dispose()
        conClose()
    End Sub



End Class
