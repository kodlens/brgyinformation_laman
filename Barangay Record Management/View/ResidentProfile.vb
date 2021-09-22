Public Class ResidentProfile
    Dim rel As New Religion
    Dim nat As New Nationality
    Dim waterSource As New WaterSource
    Dim toilet As New Toilet
    Dim garden As New Garden
    Dim pet As New Pet
    Dim contraceptive As New Contraceptive

    Dim address As New Addresses
    Dim dtSiblingDatePicker As DateTimePicker

    Dim maskBoxColumn As New MaskedTextBox

    Dim returnId As Integer

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        'fill combobox using 1 connection only
        conOpen()
        rel.fillComboBoxPerCon(cmbReligion)
        nat.fillComboBoxPerCon(cmbNationality)
        waterSource.fillComboBoxPerCon(cmbWaterSource)
        toilet.fillComboBoxPerCon(cmbToilet)
        garden.fillComboBoxPerCon(cmbGarden)
        address.countryPerCon(cmbPresentCountry)
        address.countryPerCon(cmbPermanentCountry)
        pet.fillComboBoxPerCon(cmbPet)
        contraceptive.fillComboBoxPerCon(cmbContraceptive)
        conClose()


        'maskBoxColumn.Visible = False
        'maskBoxColumn.ValidatingType = GetType(Date)
        'dGridSibling.Controls.Add(maskBoxColumn)

    End Sub


    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        TabControl1.SelectedTab = tabContactAddress
    End Sub

    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        TabControl1.SelectedTab = tabProfile
    End Sub

    Private Sub tbnNext2_Click(sender As Object, e As EventArgs) Handles tbnNext2.Click
        TabControl1.SelectedTab = tabFamilyMembers
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
        insertNewForm(New ResidentList)
    End Sub

    Private Sub dtHBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtBdate.ValueChanged
        ageCalculator(dtBdate, txtAge)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        If TabControl1.SelectedTab.Name = "tabProfile" Then
            txtHSerialNumber.Focus()
            rbHead.Checked = True
        ElseIf TabControl1.SelectedTab.Name = "tabAdditionalInfo" Then
            txtContactNumber.Focus()
        ElseIf TabControl1.SelectedTab.Name = "tabFamilyMembers" Then
            txtSiblingFname.Focus()

        End If
    End Sub

    Private Sub frmResidentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'add datetime on datagrid
        dtSiblingDatePicker = New DateTimePicker
        dtSiblingDatePicker.Format = DateTimePickerFormat.Short
        dtSiblingDatePicker.Visible = False
        dtSiblingDatePicker.Width = 120
        dGridSibling.Controls.Add(dtSiblingDatePicker)
        AddHandler dtSiblingDatePicker.ValueChanged, AddressOf dtSiblingPicker_ValueChanged


        txtHSerialNumber.Focus()
        rbHead.Checked = True
        frmDashboard.GeneralHeading.Text = "Resident Profile"

        'init data

    End Sub
    Private Sub ageCalculator(ByVal dtPicker As DateTimePicker, ByVal ageBox As TextBox)

        Dim birthYear As Integer
        Dim currentAge As Integer
        Dim currentYear As Integer = Now.Year
        birthYear = dtPicker.Value.Year

        currentAge = currentYear - birthYear

        If dtPicker.Value.Month > Date.Now.Month Then
            ageBox.Text = CStr(currentAge - 1)
        Else
            ageBox.Text = CStr(currentAge)
        End If

    End Sub

    Private Sub dtFBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtSiblingBdate.ValueChanged
        ageCalculator(dtSiblingBdate, txtFAge)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'FILTERING PRESENT ADDRESS
        If String.IsNullOrEmpty(txtLastname.Text) Then
            WarnBox("Please input lastname.")
            Return
        End If
        If String.IsNullOrEmpty(txtFirstname.Text) Then
            WarnBox("Please input firstname.")
            Return
        End If
        If String.IsNullOrEmpty(txtMiddlename.Text) Then
            WarnBox("Please input middlename.")
            Return
        End If

        If String.IsNullOrEmpty(cmbPresentCountry.Text) Then
            WarnBox("Please select Present Country.")
            Return
        End If
        If String.IsNullOrEmpty(cmbPresentProvince.Text) Then
            WarnBox("Please select Present Province.")
            Return
        End If
        If String.IsNullOrEmpty(cmbPresentCity.Text) Then
            WarnBox("Please select Present City.")
            Return
        End If
        If String.IsNullOrEmpty(cmbPresentBarangay.Text) Then
            WarnBox("Please select Present Barangay.")
            Return
        End If

        'FILTERING PERMANENT ADDRESS
        If String.IsNullOrEmpty(cmbPermanentCountry.Text) Then
            WarnBox("Please select Permanent Country.")
            Return
        End If
        If String.IsNullOrEmpty(cmbPermanentProvince.Text) Then
            WarnBox("Please select Permanent Province.")
            Return
        End If
        If String.IsNullOrEmpty(cmbPermanentCity.Text) Then
            WarnBox("Please select Permanent City.")
            Return
        End If
        If String.IsNullOrEmpty(cmbPermanentBarangay.Text) Then
            WarnBox("Please select Permanent Barangay.")
            Return
        End If

        'Save if data validated
        If Me.returnId > 0 Then
            UpdateResident()
        Else
            InsertResident()

        End If



    End Sub

    Sub InsertResident()
        Dim res As New Resident
        If rbHead.Checked Then
            res.IsHead = 1
        Else
            res.IsHead = 0
        End If

        res.Lname = Me.txtLastname.Text.Trim
        res.Fname = Me.txtFirstname.Text.Trim
        res.Mname = Me.txtMiddlename.Text.Trim
        res.Suffix = Me.txtSuffix.Text.Trim
        res.Sex = Me.cmbSex.Text
        res.CiviStatus = Me.cmbCivilStatus.Text
        res.Religion = Me.cmbReligion.Text
        res.Nationality = Me.cmbNationality.Text
        res.EmploymentStatus = Me.cmbEmploymentStatus.Text
        res.Occupation = Me.txtOccupation.Text
        res.AnnualIncome = Me.txtAnnualIncome.Text
        res.YearResidence = Me.txtYearResidency.Text
        res.BirthDate = Me.dtBdate.Value.ToString("yyyy-MM-dd")
        res.PlaceOfBirth = Me.txtPlaceBirth.Text

        'CONTACT INFO
        res.ContactNo = txtContactNumber.Text
        res.Email = txtEmailAddress.Text
        res.TypeValidId = txtValidID.Text
        res.IdNo = txtIDNumber.Text

        'PRESENT ADDRESS
        res.PresentCountry = Me.cmbPresentCountry.Text
        res.PresentProvince = Me.cmbPresentProvince.Text
        res.PresentCity = Me.cmbPresentCity.Text
        res.PresentBarangay = Me.cmbPresentBarangay.Text
        res.PresentStreet = Me.txtPresentStreet.Text

        'PERMANENT ADDRESS
        res.PermanentCountry = Me.cmbPermanentCountry.Text
        res.PermanentProvince = Me.cmbPermanentProvince.Text
        res.PermanentCity = Me.cmbPermanentCity.Text
        res.PermanentBarangay = Me.cmbPermanentBarangay.Text
        res.PermanentStreet = Me.txtPermanentStreet.Text

        'VOTERS INFO
        Dim isvoter As Int16
        If cmbIsVoter.Text = "YES" Then
            isvoter = 1
        Else
            isvoter = 0
        End If
        res.IsVoter = isvoter
        res.VoterType = Me.cmbVoterType.Text

        Dim issk As Int16
        If cmbIsSK.Text = "YES" Then
            issk = 1
        Else
            issk = 0
        End If
        res.IsSK = issk

        res.PlaceRegistration = Me.txtPlaceReg.Text

        'bind datagridSibling
        res.Siblings = Me.dGridSibling

        'additional Info
        res.WaterSource = cmbWaterSource.Text
        res.Toilet = cmbToilet.Text
        res.Garden = cmbGarden.Text
        res.Contraceptive = cmbContraceptive.Text

        res.Pets = dgridPets

        returnId = res.Save()
        txtResidentId.Text = "RES-" + returnId.ToString("000000")
        InfoBox("Successfully saved!")

    End Sub

    Sub UpdateResident()
        'update here
        Dim res As New Resident
        If rbHead.Checked Then
            res.IsHead = 1
        Else
            res.IsHead = 0
        End If

        res.Lname = Me.txtLastname.Text.Trim
        res.Fname = Me.txtFirstname.Text.Trim
        res.Mname = Me.txtMiddlename.Text.Trim
        res.Suffix = Me.txtSuffix.Text.Trim
        res.Sex = Me.cmbSex.Text
        res.CiviStatus = Me.cmbCivilStatus.Text
        res.Religion = Me.cmbReligion.Text
        res.Nationality = Me.cmbNationality.Text
        res.EmploymentStatus = Me.cmbEmploymentStatus.Text
        res.Occupation = Me.txtOccupation.Text
        res.AnnualIncome = Me.txtAnnualIncome.Text
        res.YearResidence = Me.txtYearResidency.Text
        res.BirthDate = Me.dtBdate.Value.ToString("yyyy-MM-dd")
        res.PlaceOfBirth = Me.txtPlaceBirth.Text

        'CONTACT INFO
        res.ContactNo = txtContactNumber.Text
        res.Email = txtEmailAddress.Text
        res.TypeValidId = txtValidID.Text
        res.IdNo = txtIDNumber.Text

        'PRESENT ADDRESS
        res.PresentCountry = Me.cmbPresentCountry.Text
        res.PresentProvince = Me.cmbPresentProvince.Text
        res.PresentCity = Me.cmbPresentCity.Text
        res.PresentBarangay = Me.cmbPresentBarangay.Text
        res.PresentStreet = Me.txtPresentStreet.Text

        'PERMANENT ADDRESS
        res.PermanentCountry = Me.cmbPermanentCountry.Text
        res.PermanentProvince = Me.cmbPermanentProvince.Text
        res.PermanentCity = Me.cmbPermanentCity.Text
        res.PermanentBarangay = Me.cmbPermanentBarangay.Text
        res.PermanentStreet = Me.txtPermanentStreet.Text

        'VOTERS INFO
        Dim isvoter As Int16
        If cmbIsVoter.Text = "YES" Then
            isvoter = 1
        Else
            isvoter = 0
        End If
        res.IsVoter = isvoter
        res.VoterType = Me.cmbVoterType.Text

        Dim issk As Int16
        If cmbIsSK.Text = "YES" Then
            issk = 1
        Else
            issk = 0
        End If
        res.IsSK = issk

        res.PlaceRegistration = Me.txtPlaceReg.Text

        'bind datagridSibling
        res.Siblings = Me.dGridSibling

        'additional Info
        res.WaterSource = cmbWaterSource.Text
        res.Toilet = cmbToilet.Text
        res.Garden = cmbGarden.Text
        res.Contraceptive = cmbContraceptive.Text

        res.Pets = dgridPets

        res.Update(returnId)
        InfoBox("Successfully updated!")
    End Sub

    Private Sub btnNext3_Click(sender As Object, e As EventArgs) Handles btnNext3.Click
        TabControl1.SelectedTab = tabAdditionalInformation
    End Sub

    Private Sub btnNext4_Click(sender As Object, e As EventArgs) Handles btnNext4.Click
        TabControl1.SelectedTab = tabSurvey
    End Sub

    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click
        TabControl1.SelectedTab = tabContactAddress
    End Sub

    Private Sub btnBack4_Click(sender As Object, e As EventArgs) Handles btnBack4.Click
        TabControl1.SelectedTab = tabFamilyMembers
    End Sub
    Private Sub btnBack5_Click(sender As Object, e As EventArgs) Handles btnBack5.Click
        TabControl1.SelectedTab = tabAdditionalInformation
    End Sub


    Private Sub cmbPresentCoutnry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPresentCountry.SelectedIndexChanged
        Try
            address.province(Me.cmbPresentCountry.Text, Me.cmbPresentProvince)
        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbPresentProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPresentProvince.SelectedIndexChanged
        Try
            address.cities(Me.cmbPresentProvince.Text, cmbPresentCity)
        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbPresentCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPresentCity.SelectedIndexChanged
        Try
            address.barangays(Me.cmbPresentProvince.Text, Me.cmbPresentCity.Text, cmbPresentBarangay)
        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbPermanentCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPermanentCountry.SelectedIndexChanged
        Try
            address.province(Me.cmbPermanentCountry.Text, Me.cmbPermanentProvince)
        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbPermanentProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPermanentProvince.SelectedIndexChanged
        Try
            address.cities(Me.cmbPermanentProvince.Text, cmbPermanentCity)
        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbPermanentCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPermanentCity.SelectedIndexChanged
        Try
            address.barangays(Me.cmbPermanentProvince.Text, Me.cmbPermanentCity.Text, cmbPermanentBarangay)
        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub

    Private Sub checkIsSameWithPresentAddress_CheckedChanged(sender As Object, e As EventArgs) Handles checkIsSameWithPresentAddress.CheckedChanged
        If checkIsSameWithPresentAddress.Checked Then
            cmbPermanentCountry.Text = cmbPresentCountry.Text
            cmbPermanentProvince.Text = cmbPresentProvince.Text
            cmbPermanentCity.Text = cmbPresentCity.Text
            cmbPermanentBarangay.Text = cmbPresentBarangay.Text
            txtPermanentStreet.Text = txtPresentStreet.Text
        Else
            cmbPermanentCountry.SelectedIndex = -1
            cmbPermanentProvince.SelectedIndex = -1
            cmbPermanentCity.SelectedIndex = -1
            cmbPermanentBarangay.SelectedIndex = -1
            txtPermanentStreet.Text = ""
        End If
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click
        Me.txtFirstname.Text = "ETIENNE WAYNE"
        txtLastname.Text = "AMPARADO"
        txtMiddlename.Text = "NAMOCATCAT"
        txtSuffix.Text = "TEST"
        cmbSex.Text = "MALE"
        cmbCivilStatus.Text = "SINGLE"
        cmbReligion.Text = "Bible Baptist Church"
        cmbNationality.Text = "FILIPINO"
        cmbEmploymentStatus.Text = "EMPLOYED"
        txtOccupation.Text = "IT PROGRAMMER"
        txtAnnualIncome.Text = "11000"
        txtYearResidency.Text = "1 YEAR"
        txtPlaceBirth.Text = "BAROY, LANAO DEL NORTE"

        txtContactNumber.Text = "09167789585"
        txtEmailAddress.Text = "et@yahoo.com"
        txtValidID.Text = "DRIVER LICENSE"
        txtIDNumber.Text = "K09-1234-214"

        cmbIsVoter.Text = "YES"
        cmbVoterType.Text = "OLD"
        cmbIsSK.Text = "NO"
        txtPlaceReg.Text = "MALORO, TANGUB CITY"

        cmbPresentCountry.Text = "PHILIPPINES"
        cmbPresentProvince.Text = "MISAMIS OCCIDENTAL"
        cmbPresentCity.Text = "TANGUB CITY"
        cmbPresentBarangay.Text = "GARANG"
        txtPresentStreet.Text = "P-SAMPLE LANG"


        'add row datagrid sample data
        Me.dGridSibling.Rows.Add({Nothing, "JAY AR", "B", "DOCOY", "MALE", "MARRIED", "04/08/2020", True})

        Me.dGridSibling.Rows.Add({Nothing, "JUNREY", "M", "SANTARITA", "MALE", "MARRIED", "24/05/1995", False})

        Me.dGridSibling.Rows.Add({Nothing, "ALBERT", "B", "ALIA", "MALE", "SINGLE", "20/08/1990", True})

        Me.dGridSibling.Rows.Add({Nothing, "JADE ANN", "C", "FLORIZA", "FEMALE", "SINGLE", "16/10/1993", True})

    End Sub


    Private Sub dGridSibling_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dGridSibling.CellBeginEdit

        If dGridSibling.CurrentCell.ColumnIndex = 6 Then
            'maskBoxColumn.Mask = "00/00/0000"

            'Dim rect As Rectangle = dGridSibling.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
            'maskBoxColumn.Location = rect.Location
            'maskBoxColumn.Size = rect.Size
            'maskBoxColumn.Text = ""

            'If dGridSibling(e.ColumnIndex, e.RowIndex) IsNot Nothing Then
            '    maskBoxColumn.Text = CStr(dGridSibling(e.ColumnIndex, e.RowIndex).Value)
            'End If
            'maskBoxColumn.Visible = True
            ''continue ni kay error ni dere
            'DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper

            'IF DATAGRID IS DATEPICKER
            'dtSiblingDatePicker.Visible = True

            Dim rect As Rectangle = dGridSibling.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)

            dtSiblingDatePicker.Value = DateTime.Today.ToShortDateString
            dtSiblingDatePicker.Location = rect.Location
            dtSiblingDatePicker.Size = New Size(rect.Width, rect.Height)
            dtSiblingDatePicker.Visible = True

            If dGridSibling.CurrentCell.Value IsNot Nothing Then
                dtSiblingDatePicker.Text = dGridSibling.CurrentCell.Value.ToString
                dtSiblingDatePicker.Focus()
            Else
                dtSiblingDatePicker.Value = DateTime.Today
            End If
        Else
            'maskBoxColumn.Visible = False
            dtSiblingDatePicker.Visible = False
        End If
        Try

        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub

    Private Sub dGridSibling_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dGridSibling.CellEndEdit
        If dGridSibling.CurrentCell.ColumnIndex = 6 Then
            dGridSibling.CurrentCell.Value = dtSiblingDatePicker.Value.ToString("d")
            'If maskBoxColumn.Visible Then
            '    dGridSibling.CurrentCell.Value = maskBoxColumn.Text
            '    maskBoxColumn.Visible = False

            'End If
        End If


        Try

        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub

    Private Sub dGridSibling_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dGridSibling.EditingControlShowing
        'set all textbox in grid to UpperCase
        If dGridSibling.CurrentCell.ColumnIndex = 1 Or dGridSibling.CurrentCell.ColumnIndex = 2 Or dGridSibling.CurrentCell.ColumnIndex = 3 Then
            If TypeOf e.Control Is TextBox Then
                DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
            End If
        End If

    End Sub
    Private Sub dtSiblingPicker_ValueChanged(sender As Object, e As EventArgs)
        dGridSibling.CurrentCell.Value = dtSiblingDatePicker.Text
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim diag As DialogResult = MessageBox.Show("Add another resident?", "NEW?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If diag = DialogResult.Yes Then
            Me.Clear()
        End If
    End Sub

    Sub Clear()
        returnId = 0
        txtResidentId.Text = ""
        txtLastname.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtSuffix.Text = ""
        cmbSex.SelectedIndex = -1
        cmbCivilStatus.SelectedIndex = -1
        cmbReligion.SelectedIndex = -1
        cmbNationality.SelectedIndex = -1
        cmbEmploymentStatus.SelectedIndex = -1
        txtOccupation.Text = ""
        txtAnnualIncome.Text = ""
        txtYearResidency.Text = ""
        txtPlaceBirth.Text = ""

        txtContactNumber.Text = ""
        txtEmailAddress.Text = ""
        txtValidID.Text = ""
        txtIDNumber.Text = ""

        cmbPresentCountry.SelectedIndex = -1
        cmbPresentProvince.SelectedIndex = -1
        cmbPresentCity.SelectedIndex = -1
        cmbPresentBarangay.SelectedIndex = -1
        txtPresentStreet.Text = ""

        cmbPermanentCountry.SelectedIndex = -1
        cmbPermanentProvince.SelectedIndex = -1
        cmbPermanentCity.SelectedIndex = -1
        cmbPermanentBarangay.SelectedIndex = -1
        txtPermanentStreet.Text = ""

        cmbIsVoter.SelectedIndex = -1
        cmbVoterType.SelectedIndex = -1
        cmbIsSK.SelectedIndex = -1
        txtPlaceReg.Text = ""

        txtSiblingLname.Text = ""
        txtSiblingFname.Text = ""
        txtSiblingFname.Text = ""
        cmbSiblingSex.SelectedIndex = -1
        cmbSiblingCivilStatus.SelectedIndex = -1
        cmbSiblingIsLiving.SelectedIndex = -1

        dGridSibling.Rows.Clear()

        cmbWaterSource.SelectedIndex = -1
        cmbToilet.SelectedIndex = -1
        cmbGarden.SelectedIndex = -1
        cmbPet.SelectedIndex = -1
        cmbContraceptive.SelectedIndex = -1

        dgridPets.Rows.Clear()

        cmbHaveComplain.SelectedIndex = -1
        txtAgainstWhom.Text = ""
        cmbIsSettled.SelectedIndex = -1
        txtIfNotWhy.Text = ""
        cmbIsDeathMember.SelectedIndex = -1


    End Sub

    Private Sub btnAddFamlyMember_Click(sender As Object, e As EventArgs) Handles btnAddFamlyMember.Click
        Dim islving As Boolean = False

        If Not String.IsNullOrEmpty(txtSiblingFname.Text) Then

            If String.IsNullOrEmpty(txtSiblingLname.Text) Then
                Box.WarnBox("Please add sibling lastname.")
                Return
            End If
            If String.IsNullOrEmpty(cmbSiblingSex.Text) Then
                Box.WarnBox("Please select sibling sex.")
                Return
            End If
            If String.IsNullOrEmpty(cmbSiblingCivilStatus.Text) Then
                Box.WarnBox("Please select sibling civil status.")
                Return
            End If
            If String.IsNullOrEmpty(cmbSiblingIsLiving.Text) Then
                Box.WarnBox("Please select sibling sex.")
                Return
            End If
        End If


        If cmbSiblingIsLiving.Text = "YES" Then
            islving = True
        Else
            islving = False
        End If

        Me.dGridSibling.Rows.Add({Nothing, txtSiblingLname.Text, txtSiblingMname.Text, txtSiblingFname.Text, cmbSiblingSex.Text, cmbSiblingCivilStatus.Text, dtSiblingBdate.Value.ToString("dd/mm/yyyy"), islving})
    End Sub

    Private Sub btnAddPet_Click(sender As Object, e As EventArgs) Handles btnAddPet.Click
        If cmbPet.SelectedIndex = -1 Then
            Box.WarnBox("Please select pet.")
            Return
        Else
            If txtNumericNoOfPet.Value < 1 Then
                Box.WarnBox("No of pet is invalid.")
                Return
            End If
        End If
        Dim found As Boolean = False
        If dgridPets.Rows.Count > 1 Then
            For row As Integer = 0 To dgridPets.Rows.Count - 1
                If CStr(dgridPets.Rows(row).Cells(1).Value) = cmbPet.Text Then
                    dgridPets.Rows(row).Cells(1).Value = cmbPet.Text
                    dgridPets.Rows(row).Cells(2).Value = txtNumericNoOfPet.Value
                    found = True
                    Exit For
                End If
            Next
            If Not found Then
                dgridPets.Rows.Add({Nothing, cmbPet.Text, txtNumericNoOfPet.Value})
            End If

        Else
            dgridPets.Rows.Add({Nothing, cmbPet.Text, txtNumericNoOfPet.Value})
        End If

        cmbPet.SelectedIndex = -1
        txtNumericNoOfPet.Value = 0

    End Sub


End Class