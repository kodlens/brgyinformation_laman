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
    Public Property Religion As String
    Public Property Nationality As String
    Public Property EmploymentStatus As String
    Public Property Occupation As String
    Public Property AnnualIncome As String

    Public YearResidence As String

    'CONTACT INFORMATION
    Public Property ContactNo As String
    Public Property Email As String
    Public Property TypeValidId As String
    Public Property IdNo As String



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

    'VOTERS INFORMATION

    Public Property IsVoter As Int16
    Public Property VoterType As String
    Public Property IsSK As Int16
    Public Property PlaceRegistration As String


    Public Property Siblings As DataGridView

    Public Property WaterSource As String
    Public Property Toilet As String
    Public Property Garden As String
    Public Property Pets As DataGridView
    Public Property Contraceptive As String

    Public Property HaveComplain As Int16
    Public Property AgainstWhome As String
    Public Property IsSettled As Int16
    Public Property DateSettled As Date
    Public Property IfNotWhy As String
    Public Property IsAideMember As Int16


    'local declaration
    Dim res_sibling_ids As ArrayList = New ArrayList
    Dim res_pets_ids As ArrayList = New ArrayList
    Dim res_sibling_ids_database As ArrayList = New ArrayList
    Dim res_pets_ids_database As ArrayList = New ArrayList

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
                "contact_no = @contact, email = @email, type_valid_id = @typeId, id_no = @idno, " &
                "present_country = @pre_country, present_province = @pre_province, present_city = @pre_city, present_barangay = @pre_brgy, present_street = @pre_street, " &
                "permanent_country = @per_country, permanent_province = @per_province, permanent_city = @per_city, permanent_barangay = @per_brgy, permanent_street = @per_street, " &
                "is_voter = @isvoter, voter_type = @voter_type, is_sk = @issk, place_registration = @placereg, " &
                "water_source=@wsource, toilet=@toilet, garden=@garden, contraceptive=@contraceptive, " &
                "have_complain=@havecomplain, against_whom=@whom, is_settled=@issettled, when=@when, if_not_why=@why, is_death_aid=@isaid; SELECT last_insert_id()"

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

                'contact
                .AddWithValue("@contact", Me.ContactNo)
                .AddWithValue("@email", Me.Email)
                .AddWithValue("@typeId", Me.TypeValidId)
                .AddWithValue("@idno", Me.IdNo)

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

                'voters info
                .AddWithValue("@isvoter", Me.IsVoter)
                .AddWithValue("@voter_type", Me.VoterType)
                .AddWithValue("@issk", Me.IsSK)
                .AddWithValue("@placereg", Me.PlaceRegistration)

                'additional info
                .AddWithValue("@wsource", Me.WaterSource)
                .AddWithValue("@toilet", Me.Toilet)
                .AddWithValue("@garden", Me.Garden)
                .AddWithValue("@contraceptive", Me.Contraceptive)

                'Survey info
                .AddWithValue("@havecomplain", Me.HaveComplain)
                .AddWithValue("@whom", Me.AgainstWhome)
                .AddWithValue("@issettled", Me.IsSettled)
                .AddWithValue("@when", Me.DateSettled)
                .AddWithValue("@why", Me.IfNotWhy)
                .AddWithValue("@isaid", Me.IsAideMember)


            End With
            i = Convert.ToInt32(cmd.ExecuteScalar)
            cmd.Dispose()

            Dim gridLength = Siblings.Rows.Count 'initiate first before use, optimize performance, by santaromana (CITU-CS dean) :D
            If gridLength > 1 Then
                'INSERT SIBLING TO DATABASE
                Dim res_sibling_id As Integer = 0
                query = "INSERT INTO resident_siblings SET " &
                    "resident_id = @resid, lname=@lname, fname=@fname, mname=@mname, sex=@sex, " &
                    "civil_status=@cstatus, bdate=@bdate, is_living_with_you=@isliving; SELECT LAST_INSERT_ID();"
                cmd = New MySqlCommand(query, con)
                Dim isliving = 0
                For row As Integer = 0 To gridLength - 1
                    With cmd.Parameters
                        .AddWithValue("@resid", i)
                        .AddWithValue("@lname", CStr(Siblings.Rows(row).Cells(3).Value))
                        .AddWithValue("@fname", CStr(Siblings.Rows(row).Cells(2).Value))
                        .AddWithValue("@mname", CStr(Siblings.Rows(row).Cells(1).Value))
                        .AddWithValue("@sex", CStr(Siblings.Rows(row).Cells(4).Value))
                        .AddWithValue("@cstatus", CStr(Siblings.Rows(row).Cells(5).Value))
                        .AddWithValue("@bdate", CStr(Siblings.Rows(row).Cells(6).Value))
                        If Siblings.Rows(row).Cells(7).Value Then
                            isliving = 1
                        Else
                            isliving = 0
                        End If
                        .AddWithValue("@isliving", isliving)
                    End With
                    res_sibling_id = CInt(cmd.ExecuteScalar())
                    cmd.Parameters.Clear()
                    Siblings.Rows(row).Cells(0).Value = res_sibling_id
                Next
                cmd.Dispose()
            End If

            'insert pet if any
            gridLength = Pets.Rows.Count 'initiate first before use, optimize performance, by santaromana (CITU-CS dean) :D
            If gridLength > 1 Then
                Dim resident_pet_id As Integer = 0

                'INSERT PETS TO DATABASE
                query = "INSERT INTO resident_pets SET " &
                    "resident_id = @resid, resident_pet=@respet, no_of_pet=@nopet; SELECT LAST_INSERT_ID()"
                cmd = New MySqlCommand(query, con)
                For row As Integer = 0 To gridLength - 1
                    With cmd.Parameters
                        .AddWithValue("@resid", i)
                        .AddWithValue("@respet", CStr(Pets.Rows(row).Cells(1).Value))
                        .AddWithValue("@nopet", CStr(Pets.Rows(row).Cells(2).Value))
                    End With
                    resident_pet_id = CInt(cmd.ExecuteScalar())
                    cmd.Parameters.Clear()
                    Pets.Rows(row).Cells(0).Value = resident_pet_id
                Next
                cmd.Dispose()
            End If


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
            query = "UPDATE residents SET " &
                "is_head = @ishead, " &
                "household_no = @household_no, family_no = @family_no, lname = @lname, fname = @fname, mname = @mname, " &
                "suffix = @suffix, sex = @sex, civil_status = @cstatus, " &
                "religion = @religion, nationality = @nationality, " &
                "employment_status = @employment, occupation = @occupation, annual_income = @annual_income, year_residence = @yr_residence, " &
                "bdate = @bdate, place_of_birth = @placebdate, " &
                "contact_no = @contact, email = @email, type_valid_id = @typeId, id_no = @idno, " &
                "present_country = @pre_country, present_province = @pre_province, present_city = @pre_city, present_barangay = @pre_brgy, present_street = @pre_street, " &
                "permanent_country = @per_country, permanent_province = @per_province, permanent_city = @per_city, permanent_barangay = @per_brgy, permanent_street = @per_street, " &
                "is_voter = @isvoter, voter_type = @voter_type, is_sk = @issk, place_registration = @placereg, " &
                "water_source=@wsource, toilet=@toilet, garden=@garden, contraceptive=@contraceptive, " &
                "have_complain=@havecomplain, against_whom=@whom, is_settled=@issettled, when=@when, if_not_why=@why, is_death_aid=@isaid " &
                "WHERE resident_id = @id;"
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

                'contact
                .AddWithValue("@contact", Me.ContactNo)
                .AddWithValue("@email", Me.Email)
                .AddWithValue("@typeId", Me.TypeValidId)
                .AddWithValue("@idno", Me.IdNo)

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

                'voters info
                .AddWithValue("@isvoter", Me.IsVoter)
                .AddWithValue("@voter_type", Me.VoterType)
                .AddWithValue("@issk", Me.IsSK)
                .AddWithValue("@placereg", Me.PlaceRegistration)

                'additional info
                .AddWithValue("@wsource", Me.WaterSource)
                .AddWithValue("@toilet", Me.Toilet)
                .AddWithValue("@garden", Me.Garden)
                .AddWithValue("@contraceptive", Me.Contraceptive)

                'survey info
                .AddWithValue("@havecomplain", Me.HaveComplain)
                .AddWithValue("@whom", Me.AgainstWhome)
                .AddWithValue("@issettled", Me.IsSettled)
                .AddWithValue("@when", Me.DateSettled)
                .AddWithValue("@why", Me.IfNotWhy)
                .AddWithValue("@isaid", Me.IsAideMember)

                .AddWithValue("@id", id)
            End With
            i = cmd.ExecuteNonQuery
            cmd.Dispose()


            '---------------------------------------
            'update or insert data into database
            Dim gridLength = Siblings.Rows.Count 'initiate first before use, optimize performance, by santaromana (CITU-CS dean) :D
            If gridLength > 1 Then 'if grid is not empty

                Dim res_sibling_id As Integer = 0


                Dim isliving As Integer = 0
                For row As Integer = 0 To gridLength - 1

                    If String.IsNullOrEmpty(CStr(Siblings.Rows(row).Cells(0).Value)) Then 'check if id has no value
                        'INSERT WILL EXECUTE
                        query = "INSERT INTO resident_siblings SET " &
                            "resident_id = @resid, lname=@lname, fname=@fname, mname=@mname, sex=@sex, " &
                            "civil_status=@cstatus, bdate=@bdate, is_living_with_you=@isliving; SELECT LAST_INSERT_ID();"
                        cmd = New MySqlCommand(query, con)
                        With cmd.Parameters
                            .AddWithValue("@resid", id)
                            .AddWithValue("@lname", CStr(Siblings.Rows(row).Cells(3).Value))
                            .AddWithValue("@fname", CStr(Siblings.Rows(row).Cells(2).Value))
                            .AddWithValue("@mname", CStr(Siblings.Rows(row).Cells(1).Value))
                            .AddWithValue("@sex", CStr(Siblings.Rows(row).Cells(4).Value))
                            .AddWithValue("@cstatus", CStr(Siblings.Rows(row).Cells(5).Value))
                            .AddWithValue("@bdate", CStr(Siblings.Rows(row).Cells(6).Value))
                            If Siblings.Rows(row).Cells(7).Value Then
                                isliving = 1
                            Else
                                isliving = 0
                            End If
                            .AddWithValue("@isliving", isliving)
                        End With
                        res_sibling_id = CInt(cmd.ExecuteScalar())
                        cmd.Parameters.Clear()
                        Siblings.Rows(row).Cells(0).Value = res_sibling_id
                        'after insert add in array list
                        res_sibling_ids.Add(res_sibling_id)
                    Else
                        'UPDATE WILL EXECUTE
                        res_sibling_id = CInt(Siblings.Rows(row).Cells(0).Value)
                        'save id in array
                        res_sibling_ids.Add(res_sibling_id)
                        query = "UPDATE resident_siblings SET " &
                           "resident_id = @resid, lname=@lname, fname=@fname, mname=@mname, sex=@sex, " &
                           "civil_status=@cstatus, bdate=@bdate, is_living_with_you=@isliving WHERE resident_sibling_id = @id"
                        cmd = New MySqlCommand(query, con)
                        With cmd.Parameters
                            .AddWithValue("@resid", id)
                            .AddWithValue("@lname", CStr(Siblings.Rows(row).Cells(3).Value))
                            .AddWithValue("@fname", CStr(Siblings.Rows(row).Cells(2).Value))
                            .AddWithValue("@mname", CStr(Siblings.Rows(row).Cells(1).Value))
                            .AddWithValue("@sex", CStr(Siblings.Rows(row).Cells(4).Value))
                            .AddWithValue("@cstatus", CStr(Siblings.Rows(row).Cells(5).Value))
                            .AddWithValue("@bdate", CStr(Siblings.Rows(row).Cells(6).Value))
                            If Siblings.Rows(row).Cells(7).Value Then
                                isliving = 1
                            Else
                                isliving = 0
                            End If
                            .AddWithValue("@isliving", isliving)
                            .AddWithValue("@id", res_sibling_id)
                        End With
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                    End If
                Next
                cmd.Dispose()
            End If
            'update siblings

            'delete siblings if there is missing
            'get all ids from databse and compare to dgrid ids
            query = "SELECT * FROM resident_siblings WHERE resident_id = @res_id"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@res_id", id)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                res_sibling_ids_database.Add(CInt(dr("resident_sibling_id")))
            End While
            dr.Close()
            cmd.Dispose()



            For row As Integer = 0 To res_sibling_ids_database.Count - 1
                'MsgBox(res_sibling_ids_database(row).ToString)

                If Not res_sibling_ids.Contains(res_sibling_ids_database(row)) Then
                    'MsgBox(res_sibling_ids_database(row).ToString)
                    cmd = New MySqlCommand("DELETE FROM resident_siblings WHERE resident_sibling_id = @res_sib_id", con)
                    cmd.Parameters.AddWithValue("@res_sib_id", res_sibling_ids_database(row))
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Next
            '--------------------------------------------------


            'update pets
            ''---------------------------------------------------
            gridLength = Pets.Rows.Count
            If gridLength > 1 Then 'if grid is not empty

                Dim res_pet_id As Integer = 0
                For row As Integer = 0 To gridLength - 1

                    If String.IsNullOrEmpty(CStr(Pets.Rows(row).Cells(0).Value)) Then 'check if id has no value
                        'INSERT WILL EXECUTE
                        query = "INSERT INTO resident_pets SET " &
                            "resident_id = @resid, resident_pet=@respet, no_of_pet=@nopet; SELECT LAST_INSERT_ID();"
                        cmd = New MySqlCommand(query, con)
                        With cmd.Parameters
                            .AddWithValue("@resid", id)
                            .AddWithValue("@respet", CStr(Pets.Rows(row).Cells(1).Value))
                            .AddWithValue("@nopet", CStr(Pets.Rows(row).Cells(2).Value))
                        End With
                        res_pet_id = CInt(cmd.ExecuteScalar())
                        cmd.Parameters.Clear()
                        Pets.Rows(row).Cells(0).Value = res_pet_id
                        res_pets_ids.Add(res_pet_id)
                    Else
                        'UPDATE WILL EXECUTE
                        res_pet_id = CInt(Pets.Rows(row).Cells(0).Value)
                        res_pets_ids.Add(res_pet_id)

                        query = "UPDATE resident_pets SET " &
                          "resident_id = @resid, resident_pet=@respet, no_of_pet=@nopet WHERE resident_pet_id = @id"
                        cmd = New MySqlCommand(query, con)
                        With cmd.Parameters
                            .AddWithValue("@resid", id)
                            .AddWithValue("@respet", CStr(Pets.Rows(row).Cells(1).Value))
                            .AddWithValue("@nopet", CStr(Pets.Rows(row).Cells(2).Value))
                            .AddWithValue("@id", res_pet_id)
                        End With
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                    End If
                Next
                cmd.Dispose()
            End If

            'delete pet if now exist
            'get all ids from databse and compare to dgrid ids
            query = "SELECT * FROM resident_pets WHERE resident_id = @res_id"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@res_id", id)

            dr = cmd.ExecuteReader
            While dr.Read
                res_pets_ids_database.Add(CInt(dr("resident_pet_id")))
            End While
            dr.Close()
            cmd.Dispose()


            For row As Integer = 0 To res_pets_ids_database.Count - 1

                If Not res_pets_ids.Contains(res_pets_ids_database(row)) Then
                    'MsgBox(res_sibling_ids_database(row).ToString)
                    cmd = New MySqlCommand("DELETE FROM resident_pets WHERE resident_pet_id = @respetid", con)
                    cmd.Parameters.AddWithValue("@respetid", res_pets_ids_database(row))
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                End If
            Next
            '----------------------------------------------------------

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
