Public Class ResidentProfile
    Dim rel As New Religion
    Dim nat As New Nationality

    Dim address As New Addresses


    Dim dtSiblingDatePicker As DateTimePicker


    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        rel.all(cmbReligion)
        nat.all(cmbNationality)

        address.country(cmbPresentCountry)
        address.country(cmbPermanentCountry)

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
            txtFFirstName.Focus()

        End If
    End Sub

    Private Sub frmResidentProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'add datetime on datagrid
        dtSiblingDatePicker = New DateTimePicker
        dtSiblingDatePicker.Format = DateTimePickerFormat.Short
        dtSiblingDatePicker.Visible = False
        dtSiblingDatePicker.Width = 100
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

    Private Sub dtFBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtFBirthdate.ValueChanged
        ageCalculator(dtFBirthdate, txtFAge)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'FILTERING PRESENT ADDRESS
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

        If res.Save() > 0 Then
            InfoBox("Successfully saved!")
        End If
    End Sub

    Private Sub btnNext3_Click(sender As Object, e As EventArgs) Handles btnNext3.Click
        TabControl1.SelectedTab = tabAdditionalInformation
    End Sub

    Private Sub btnBack3_Click(sender As Object, e As EventArgs) Handles btnBack3.Click
        TabControl1.SelectedTab = tabContactAddress
    End Sub

    Private Sub btnBack4_Click(sender As Object, e As EventArgs) Handles btnBack4.Click
        TabControl1.SelectedTab = tabFamilyMembers
    End Sub

    Private Sub dtSiblingPicker_ValueChanged(sender As Object, e As EventArgs)
        dGridSibling.CurrentCell.Value = dtSiblingDatePicker.Value.ToString("d")
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
    End Sub

    Private Sub dGridSibling_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dGridSibling.CellBeginEdit
        If dGridSibling.CurrentCell.ColumnIndex = 6 Then
            dtSiblingDatePicker.Location = dGridSibling.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
            dtSiblingDatePicker.Visible = True
            dtSiblingDatePicker.Value = DateTime.Today
            'If dgSibling.CurrentCell.Value IsNot DBNull.Value Then
            '    'dtSiblingDatePicker.Value = CType(dgSibling.CurrentCell.Value, DateTime)
            'Else

            'End If

            ''continue ni kay error ni dere
        Else
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
        End If
        Try

        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub
End Class