Imports MySql.Data.MySqlClient

Public Class Resident

    Public Property IsHead As Integer
    Public Property HouseHoldNo As String
    Public Property FamilyNo As String
    Public Property Lname As String
    Public Property Fname As String
    Public Property Mname As String
    Public Property Suffix As String
    Public Property Sex As String
    Public Property CiviStatus As String
    Public Property BirthDate As String
    Public Property PlaceOfBirth As String


    'PRESENT ADDRESS
    Public Property PresentCountry As String
    Public Property PresentProvince As String
    Public Property PresentCity As String
    Public Property PresentBarangay As String
    Public Property PresentStreet As String

    'PERMANENT ADDRESS
    Public Property PermanentCountry As String
    Public Property PermanentProvince As String
    Public Property PermanentCity As String
    Public Property PermanentBarangay As String
    Public Property PermanentStreet As String


    Public Property Religion As String
    Public Property Nationality As String
    Public Property EmploymentStatus As String
    Public Property Occupation As String
    Public Property AnnualIncome As String

    Public YearResidence As String



    Public Function Save() As Integer

        Dim i As Integer = 0
        Try
            conOpen()
            query = "INSERT INTO residents SET " &
                "is_head = @ishead, " &
                "household_no = @household_no, family_no = @family_no, lname = @lname, fname = @fname, mname = @mname, " &
                "suffix = @suffix, sex = @sex, civil_status = @cstatus, " &
                "religion = @religion, nationality = @nationality, " &
                "employment_status = @employment, occupation = @occupation, annual_income = @annual_income, year_residence = @yr_residence, " &
                "bdate = @bdate, place_of_birth = @placebdate, " &
                "present_country = @pre_country, present_province = @pre_province, present_city = @pre_city, present_barangay = @pre_brgy, present_street = @pre_street, " &
                "permanent_country = @per_country, permanent_province = @per_province, permanent_city = @per_city, permanent_barangay = @per_brgy, permanent_street = @per_street"

            cmd = New MySqlCommand(query, con)
            With cmd.Parameters
                .AddWithValue("@ishead", Me.IsHead)
                .AddWithValue("@household_no", Me.HouseHoldNo)
                .AddWithValue("@family_no", Me.FamilyNo)
                .AddWithValue("@lname", Me.Lname)
                .AddWithValue("@fname", Me.Fname)
                .AddWithValue("@mname", Me.Mname)
                .AddWithValue("@suffix", Me.Suffix)
                .AddWithValue("@sex", Me.Sex)
                .AddWithValue("@cstatus", Me.CiviStatus)
                .AddWithValue("@religion", Me.Religion)
                .AddWithValue("@nationality", Me.Nationality)
                .AddWithValue("@employment", Me.EmploymentStatus)
                .AddWithValue("@occupation", Me.Occupation)
                .AddWithValue("@annual_income", Me.AnnualIncome)
                .AddWithValue("@yr_residence", Me.YearResidence)
                .AddWithValue("@bdate", Me.BirthDate)
                .AddWithValue("@placebdate", Me.PlaceOfBirth)

                'present address
                .AddWithValue("@pre_country", Me.PresentCountry)
                .AddWithValue("@pre_province", Me.PresentProvince)
                .AddWithValue("@pre_city", Me.PresentCity)
                .AddWithValue("@pre_brgy", Me.PresentBarangay)
                .AddWithValue("@pre_street", Me.PresentStreet)

                'permament address
                .AddWithValue("@per_country", Me.PermanentCountry)
                .AddWithValue("@per_province", Me.PermanentProvince)
                .AddWithValue("@per_city", Me.PermanentCity)
                .AddWithValue("@per_brgy", Me.PermanentBarangay)
                .AddWithValue("@per_street", Me.PermanentStreet)

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
            query = "UPDATE residents SET" &
                "household_no = @household_no, family_no = @family_no, lname = @lname, @fname  = @fname, mname = @mname," &
                "suffix = @suffix, sex = @sex, civil_status = @cstatus, religion = @religion, nationality = @nationality," &
                "employment_status = @employment, @occupation = @occupation, @annual_income = @annual_income, @year_residence = @yr_residence WHERE resident_id = @id"
            cmd = New MySqlCommand(query, con)
            With cmd.Parameters
                .AddWithValue("@household_no", Me.HouseHoldNo)
                .AddWithValue("@family_no", Me.FamilyNo)
                .AddWithValue("@lname", Me.Lname)
                .AddWithValue("@fname", Me.Fname)
                .AddWithValue("@mname", Me.Mname)
                .AddWithValue("@suffix", Me.Suffix)
                .AddWithValue("@sex", Me.Sex)
                .AddWithValue("@cstatus", Me.CiviStatus)
                .AddWithValue("@bdate", Me.BirthDate)
                .AddWithValue("@religion", Me.Religion)
                .AddWithValue("@nationality", Me.Nationality)
                .AddWithValue("@employment", Me.EmploymentStatus)
                .AddWithValue("@occupation", Me.Occupation)
                .AddWithValue("@annual_income", Me.AnnualIncome)
                .AddWithValue("@yr_residence", Me.YearResidence)
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
            query = "SELECT * FROM residents ORDER BY lname ASC"
            cmd = New MySqlCommand(query, con)
            Dim dt As New DataTable
            Dim adprtr As New MySqlDataAdapter(cmd)
            adprtr.Fill(dt)
            adprtr.Dispose()
            cmd.Dispose()

            grid.AutoGenerateColumns = False
            grid.DataSource = dt

        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub

End Class
