Imports MySql.Data.MySqlClient

Public Class Resident
    Public HouseHoldNo, FamilyNo, Lname, Fname, Mname, Sex, CiviStatus, Religion, Nationality As String



    Public Function Save() As Integer
        Dim i As Integer = 0
        Try
            conOpen()
            query = "INSERT INTO residents SET" &
                "household_no = @household_no, family_no = @family_no, lname = @lname, @fname  = @fname, mname = @mname," &
                "sex = @sex, civil_status = @cstatus, religion = @religion, nationality = @nationality"
            cmd = New MySqlCommand(query, con)
            With cmd.Parameters
                .AddWithValue("@household_no", Me.HouseHoldNo)
                .AddWithValue("@family_no", Me.FamilyNo)
                .AddWithValue("@lname", Me.Lname)
                .AddWithValue("@fname", Me.Fname)
                .AddWithValue("@mname", Me.Mname)
                .AddWithValue("@sex", Me.Sex)
                .AddWithValue("@cstatus", Me.CiviStatus)
                .AddWithValue("@religion", Me.Religion)
                .AddWithValue("@nationality", Me.Nationality)
            End With
            i = cmd.ExecuteNonQuery
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
            query = "INSERT INTO residents SET" &
                "household_no = @household_no, family_no = @family_no, lname = @lname, @fname  = @fname, mname = @mname," &
                "sex = @sex, civil_status = @cstatus, religion = @religion, nationality = @nationality WHERE resident_id = @id"
            cmd = New MySqlCommand(query, con)
            With cmd.Parameters
                .AddWithValue("@household_no", Me.HouseHoldNo)
                .AddWithValue("@family_no", Me.FamilyNo)
                .AddWithValue("@lname", Me.Lname)
                .AddWithValue("@fname", Me.Fname)
                .AddWithValue("@mname", Me.Mname)
                .AddWithValue("@sex", Me.Sex)
                .AddWithValue("@cstatus", Me.CiviStatus)
                .AddWithValue("@religion", Me.Religion)
                .AddWithValue("@nationality", Me.Nationality)
                .AddWithValue("@id", id)
            End With
            i = cmd.ExecuteNonQuery
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
            query = "DELETE FROM residents WHERE resident_id = @id"
            cmd = New MySqlCommand(query, con)
            With cmd.Parameters
                .AddWithValue("@id", id)
            End With
            i = cmd.ExecuteNonQuery
            cmd.Dispose()
            conClose()

            Return i
        Catch ex As Exception
            ErrBox(ex.Message)
            Return 0
        End Try
    End Function

    Public Sub All(ByVal grid As DataGridView)
        Try
            conOpen()
            query = "SELET * FROM residents ORDER BY lname ASC"
            cmd = New MySqlCommand(query, con)
            Dim dt As New DataTable
            Dim adprtr As New MySqlDataAdapter(cmd)
            adprtr.Fill(dt)
            adprtr.Dispose()
            cmd.Dispose()

            grid.DataSource = dt
        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub

End Class
