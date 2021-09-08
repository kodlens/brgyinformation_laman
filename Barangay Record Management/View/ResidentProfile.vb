Public Class ResidentProfile
    Dim rel As New Religion
    Dim nat As New Nationality

    Dim dtSiblingDatePicker As DateTimePicker


    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        rel.all(cmbReligion)
        nat.all(cmbNationality)
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

        'add datetime on datagrid
        dtSiblingDatePicker = New DateTimePicker
        dtSiblingDatePicker.Format = DateTimePickerFormat.Short
        dtSiblingDatePicker.Visible = False
        dtSiblingDatePicker.Width = 100
        dgSibling.Controls.Add(dtSiblingDatePicker)
        AddHandler dtSiblingDatePicker.ValueChanged, AddressOf dtSiblingPicker_ValueChanged

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

    'datepicker for bdate

    Private Sub dtSibling_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgSibling.CellBeginEdit
        Try
            If dgSibling.CurrentCell.ColumnIndex = 6 Then
                dtSiblingDatePicker.Location = dgSibling.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
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
        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub

    Private Sub dtSibling_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgSibling.CellEndEdit
        Try
            If dgSibling.CurrentCell.ColumnIndex = 6 Then
                dgSibling.CurrentCell.Value = dtSiblingDatePicker.Value.ToString("d")

            End If
        Catch ex As Exception
            ErrBox(ex.Message)
        End Try
    End Sub

    Private Sub dtSiblingPicker_ValueChanged(sender As Object, e As EventArgs)
        dgSibling.CurrentCell.Value = dtSiblingDatePicker.Value.ToString("d")
    End Sub
End Class