Imports MySql.Data.MySqlClient

Public Class Resident

    Public Property ResidentId As Integer
    Public Property IsHead As Int16
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
    Public Property AgainstWhom As String
    Public Property IsSettled As Int16
    Public Property DateSettled As String
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
                "have_complain=@havecomplain, against_whom=@whom, is_settled=@issettled, date_settled=@when, if_not_why=@why, is_death_aid=@isaid; SELECT last_insert_id()"

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
                .AddWithValue("@whom", Me.AgainstWhom)
                .AddWithValue("@issettled", Me.IsSettled)

                'If Me.IsSettled > 0 Then
                '    .AddWithValue("@when", Me.DateSettled)
                'End If
                Dim dateSettiled As String = ""
                IIf(Me.IsSettled > 0, dateSettiled = Me.DateSettled, dateSettiled = "")
                .AddWithValue("@when", dateSettiled)
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
                For row As Integer = 0 To gridLength - 2
                    With cmd.Parameters
                        .AddWithValue("@resid", i)
                        .AddWithValue("@fname", Convert.ToString(Siblings.Rows(row).Cells(1).Value))
                        .AddWithValue("@mname", Convert.ToString(Siblings.Rows(row).Cells(2).Value))
                        .AddWithValue("@lname", Convert.ToString(Siblings.Rows(row).Cells(3).Value))
                        .AddWithValue("@sex", Convert.ToString(Siblings.Rows(row).Cells(4).Value))
                        .AddWithValue("@cstatus", Convert.ToString(Siblings.Rows(row).Cells(5).Value))
                        .AddWithValue("@bdate", Convert.ToString(Siblings.Rows(row).Cells(6).Value))
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
                        .AddWithValue("@respet", Convert.ToString(Pets.Rows(row).Cells(1).Value))
                        .AddWithValue("@nopet", Convert.ToString(Pets.Rows(row).Cells(2).Value))
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
            Throw
            ErrBox(ex.Message)

            Return 0
        End Try

    End Function

    Public Function Update(ByVal id As Integer) As Integer
        Dim i As Integer = 0
        'Try
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
                "have_complain=@havecomplain, against_whom=@whom, is_settled=@issettled, date_settled=@when, if_not_why=@why, is_death_aid=@isaid " &
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
                .AddWithValue("@whom", Me.AgainstWhom)
                .AddWithValue("@issettled", Me.IsSettled)
                If Me.IsSettled > 0 Then
                    .AddWithValue("@when", Me.DateSettled)
                Else
                    .AddWithValue("@when", "")
                End If

                .AddWithValue("@why", Me.IfNotWhy)
                .AddWithValue("@isaid", Me.IsAideMember)

                .AddWithValue("@id", id)
            End With
            i = cmd.ExecuteNonQuery
            cmd.Dispose()


            '---------------------------------------
            'update or insert data into database
            Dim gridLength = Siblings.Rows.Count 'initiate first before use, optimize performance, by santaromana (CITU-CS dean) :D
            If gridLength > 2 Then 'if grid is not empty

                Dim res_sibling_id As Integer = 0


                Dim isliving As Integer = 0
                For row As Integer = 0 To gridLength - 2

                If String.IsNullOrEmpty(Convert.ToString(Siblings.Rows(row).Cells(0).Value)) Then 'check if id has no value
                    'INSERT WILL EXECUTE
                    query = "INSERT INTO resident_siblings SET " &
                            "resident_id = @resid, lname=@lname, fname=@fname, mname=@mname, sex=@sex, " &
                            "civil_status=@cstatus, bdate=@bdate, is_living_with_you=@isliving; SELECT LAST_INSERT_ID();"
                    cmd = New MySqlCommand(query, con)
                    With cmd.Parameters
                        .AddWithValue("@resid", id)
                        .AddWithValue("@fname", Convert.ToString(Siblings.Rows(row).Cells(1).Value))
                        .AddWithValue("@mname", Convert.ToString(Siblings.Rows(row).Cells(2).Value))
                        .AddWithValue("@lname", Convert.ToString(Siblings.Rows(row).Cells(3).Value))
                        .AddWithValue("@sex", Convert.ToString(Siblings.Rows(row).Cells(4).Value))
                        .AddWithValue("@cstatus", Convert.ToString(Siblings.Rows(row).Cells(5).Value))
                        .AddWithValue("@bdate", Convert.ToString(Siblings.Rows(row).Cells(6).Value))
                        If Siblings.Rows(row).Cells(7).Value Then
                            isliving = 1
                        Else
                            isliving = 0
                        End If
                        .AddWithValue("@isliving", isliving)
                    End With
                    res_sibling_id = Convert.ToInt32(cmd.ExecuteScalar())
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
                        .AddWithValue("@fname", Convert.ToString(Siblings.Rows(row).Cells(1).Value))
                        .AddWithValue("@mname", Convert.ToString(Siblings.Rows(row).Cells(2).Value))
                            .AddWithValue("@lname", CStr(Siblings.Rows(row).Cells(3).Value))
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
                        .AddWithValue("@respet", Convert.ToString(Pets.Rows(row).Cells(1).Value))
                        .AddWithValue("@nopet", Convert.ToString(Pets.Rows(row).Cells(2).Value))
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
                        .AddWithValue("@respet", Convert.ToString(Pets.Rows(row).Cells(1).Value))
                        .AddWithValue("@nopet", Convert.ToString(Pets.Rows(row).Cells(2).Value))
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
        'Catch ex As Exception
        'Throw
        ' ErrBox(ex.Message)
        ' Return 0
        'End Try
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


    Public Sub GetData(ByVal id As Integer, paramSiblings As DataGridView, paramPets As DataGridView)
        'kay d man ka ma bind sa parameters..
        'ibutang tika sa parameters nlng
        Try
            conOpen()
            query = "SELECT * FROM residents WHERE resident_id = @id"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            Dim dt As New DataTable
            Dim adprtr As New MySqlDataAdapter(cmd)
            adprtr.Fill(dt)
            adprtr.Dispose()
            cmd.Dispose()

            query = "SELECT * FROM resident_siblings WHERE resident_id = @id"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            Dim dtSIblings As New DataTable
            adprtr = New MySqlDataAdapter(cmd)
            adprtr.Fill(dtSIblings)
            'Siblings = New DataGridView
            'Box.InfoBox(dtSIblings.Rows.Count)
            paramSiblings.AutoGenerateColumns = False
            paramSiblings.DataSource = dtSIblings
            adprtr.Dispose()
            cmd.Dispose()

            query = "SELECT * FROM resident_pets WHERE resident_id = @id"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                paramPets.Rows.Add()
            End While
            dr.Close()

            'paramPets.DataSource = dtPets
            cmd.Dispose()

            If dt.Rows.Count > 0 Then
                Me.ResidentId = CInt(dt.Rows(0)("resident_id"))
                Me.HouseHoldNo = Convert.ToString(dt.Rows(0)("household_no"))
                Me.FamilyNo = Convert.ToString(dt.Rows(0)("family_no"))
                Me.IsHead = Convert.ToInt16(dt.Rows(0)("is_head"))
                Me.Lname = Convert.ToString(dt.Rows(0)("lname"))
                Me.Fname = Convert.ToString(dt.Rows(0)("fname"))
                Me.Mname = Convert.ToString(dt.Rows(0)("mname"))
                Me.Suffix = Convert.ToString(dt.Rows(0)("suffix"))
                Me.Sex = Convert.ToString(dt.Rows(0)("sex"))
                Me.CiviStatus = Convert.ToString(dt.Rows(0)("civil_status"))
                Me.Religion = Convert.ToString(dt.Rows(0)("religion"))
                Me.Nationality = Convert.ToString(dt.Rows(0)("nationality"))
                Me.EmploymentStatus = Convert.ToString(dt.Rows(0)("employment_status"))
                Me.Occupation = Convert.ToString(dt.Rows(0)("occupation"))
                Me.AnnualIncome = Convert.ToString(dt.Rows(0)("annual_income"))
                Me.YearResidence = Convert.ToString(dt.Rows(0)("year_residence"))
                Me.BirthDate = Convert.ToString(dt.Rows(0)("bdate"))
                Me.PlaceOfBirth = Convert.ToString(dt.Rows(0)("place_of_birth"))
                Me.ContactNo = Convert.ToString(dt.Rows(0)("contact_no"))
                Me.Email = Convert.ToString(dt.Rows(0)("email"))
                Me.TypeValidId = Convert.ToString(dt.Rows(0)("type_valid_id"))
                Me.IdNo = Convert.ToString(dt.Rows(0)("id_no"))

                Me.PresentCountry = Convert.ToString(dt.Rows(0)("present_country"))
                Me.PresentProvince = Convert.ToString(dt.Rows(0)("present_province"))
                Me.PresentCity = Convert.ToString(dt.Rows(0)("present_city"))
                Me.PresentBarangay = Convert.ToString(dt.Rows(0)("present_barangay"))
                Me.PresentStreet = Convert.ToString(dt.Rows(0)("present_street"))

                Me.PermanentCountry = Convert.ToString(dt.Rows(0)("permanent_country"))
                Me.PermanentProvince = Convert.ToString(dt.Rows(0)("permanent_province"))
                Me.PermanentCity = Convert.ToString(dt.Rows(0)("permanent_city"))
                Me.PermanentBarangay = Convert.ToString(dt.Rows(0)("permanent_barangay"))
                Me.PermanentStreet = Convert.ToString(dt.Rows(0)("permanent_street"))

                Me.IsVoter = CInt(dt.Rows(0)("is_voter"))
                Me.VoterType = Convert.ToString(dt.Rows(0)("voter_type"))
                Me.IsSK = CInt(dt.Rows(0)("is_sk"))
                Me.PlaceRegistration = Convert.ToString(dt.Rows(0)("place_registration"))

                Me.WaterSource = CStr(dt.Rows(0)("water_source"))
                Me.Toilet = Convert.ToString(dt.Rows(0)("toilet"))
                Me.Garden = CStr(dt.Rows(0)("garden"))
                Me.Contraceptive = Convert.ToString(dt.Rows(0)("contraceptive"))

                Me.HaveComplain = CInt(dt.Rows(0)("have_complain"))
                Me.AgainstWhom = Convert.ToString(dt.Rows(0)("against_whom"))
                Me.IsSettled = CInt(dt.Rows(0)("is_settled"))
                Me.DateSettled = dt.Rows(0)("date_settled")

                Me.IfNotWhy = Convert.ToString(dt.Rows(0)("if_not_why"))
                Me.IsAideMember = CInt(dt.Rows(0)("is_death_aid"))

            End If

        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub




End Class
