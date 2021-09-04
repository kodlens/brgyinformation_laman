Imports MySql.Data.MySqlClient

Public Class frmBlotterList
    Private Sub btnAddBlotter_Click(sender As Object, e As EventArgs) Handles btnAddBlotter.Click
        insertNewForm(New frmAddBlotter)

    End Sub

    Private Sub frmBlotterList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetAllBlotter()
    End Sub
    Public Sub GetAllBlotter()
        Dim conn As New MySqlConnection
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim dt As New DataTable
        Try
            sql = "SELECT b.incident_type, b.incident_date, b.incident_time, b.incident_location, b.status, CONCAT(c.first_name,' ', LEFT(c.middle_name,1),'. ', c.last_name) AS complainant, b.recorded_by, b.date_reported
                    FROM blotter b
                    INNER JOIN complainants c
                    WHERE b.blotterNo = c.case_id
                    ORDER BY b.status"

            CreateDbConnection()
            conn.Open()

            cmd = New MySqlCommand(sql, conn)
            Dim da As New MySqlDataAdapter(cmd)

            dt.Clear()
            da.Fill(dt)
            da.Dispose()
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
End Class