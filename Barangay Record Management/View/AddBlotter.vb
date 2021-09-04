Imports MySql.Data.MySqlClient

Public Class frmAddBlotter
    Dim newComplainantID As Long
    Dim newNarrativeID As Long
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub checkIsResident_CheckedChanged(sender As Object, e As EventArgs) Handles checkIsResident.CheckedChanged

        If checkIsResident.Checked = True Then
            DisableResidentTxtbox(False)
            searchResidentGroup.Visible = True
            txtSearchResident.Focus()
        Else
            DisableResidentTxtbox(True)
            searchResidentGroup.Visible = False
        End If

    End Sub

    Private Sub frmAddBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchResidentGroup.Visible = False
        cbStatus.SelectedIndex = 1
        txtAge.Enabled = False
        GenerateNewBlotterNumber()
    End Sub

    Private Sub closeSearchGroup_Click(sender As Object, e As EventArgs) Handles closeSearchGroup.Click
        searchResidentGroup.Visible = False
        btnRecordBlotter.Enabled = True
        closeButton.Enabled = True
    End Sub
    Private Sub DisableResidentTxtbox(ByVal truthValue As Boolean)

        txtFirstName.Enabled = truthValue
        txtMiddleName.Enabled = truthValue
        txtLastName.Enabled = truthValue
        cbGender.Enabled = truthValue
        cbCivilStatus.Enabled = truthValue
        dtBirthdate.Enabled = truthValue
        txtAge.Enabled = truthValue
        txtPurok.Enabled = truthValue
        btnRecordBlotter.Enabled = truthValue
        closeButton.Enabled = truthValue
        txtMobileNumber.Enabled = truthValue
        txtOccupation.Enabled = truthValue

    End Sub
    Private Sub btnRecordBlotter_Click(sender As Object, e As EventArgs) Handles btnRecordBlotter.Click

        InsertBlotterComplainant()
        InsertNewNarrative()
        InsertNewBlotter()
        Me.Close()

        insertNewForm(New frmBlotterList)
        frmBlotterList.GetAllBlotter()

    End Sub
    Private Sub InsertBlotterComplainant()
        Dim conn As New MySqlConnection
        Dim sql As String
        Dim cmd As MySqlCommand
        Try
            sql = "INSERT INTO complainants(
                    case_type, case_id, first_name,middle_name, last_name, gender, civil_status, birthday, age, address, occupation, contact )
                    VALUES(@CaseType, @CaseID, @FName, @MName, @LName, @Gender, @CStatus, @BDay, @Age, @Adr, @Work, @CPNumber)
                   "

            CreateDbConnection()
            conn.Open()

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@CaseType", "blotter")
            cmd.Parameters.AddWithValue("@CaseID", txtBlotterNumber.Text)
            cmd.Parameters.AddWithValue("@FName", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@MName", txtMiddleName.Text)
            cmd.Parameters.AddWithValue("@LName", txtLastName.Text)
            cmd.Parameters.AddWithValue("@Gender", cbGender.SelectedItem)
            cmd.Parameters.AddWithValue("@CStatus", cbCivilStatus.SelectedItem)
            cmd.Parameters.AddWithValue("@BDay", dtBirthdate.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@Age", txtAge.Text)
            cmd.Parameters.AddWithValue("@Adr", txtPurok.Text)
            cmd.Parameters.AddWithValue("@Work", txtOccupation.Text)
            cmd.Parameters.AddWithValue("@CPNumber", txtMobileNumber.Text)
            cmd.ExecuteNonQuery()
            newComplainantID = cmd.LastInsertedId

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            conn.Close()

        End Try

    End Sub

    Private Sub dtBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtBirthdate.ValueChanged

        'Automatically calculate age

        Dim BirthYear As Integer
        Dim currentAge As Integer
        BirthYear = dtBirthdate.Value.Year
        currentAge = Today.Year - BirthYear

        If BirthYear > Today.Year Then
            txtAge.Text = "1"
        Else
            txtAge.Text = Integer.Parse(currentAge)
        End If

    End Sub
    Private Sub InsertNewBlotter()
        Dim conn As New MySqlConnection
        Dim sql As String
        Dim newBlotterID As Long
        Dim cmd As MySqlCommand
        Try
            sql = "INSERT INTO blotter(
                    blotterNo, complainant_id, incident_type,incident_location, incident_date, incident_time, detail_id, date_reported, recorded_by, status )
                    VALUES(@BlotterNo, @Complainant, @Type, @Location, @Date, @Time, @Details, @DateReported, @RecordedBy, @Status)
                   "

            CreateDbConnection()
            conn.Open()

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@BlotterNo", txtBlotterNumber.Text)
            cmd.Parameters.AddWithValue("@Complainant", newComplainantID)
            cmd.Parameters.AddWithValue("@Type", txtType.Text)
            cmd.Parameters.AddWithValue("@Location", txtLocation.Text)
            cmd.Parameters.AddWithValue("@Date", dtIncidentDate.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@Time", dtIncidentTime.Value.ToString("hh:mm:ss"))
            cmd.Parameters.AddWithValue("@Details", newNarrativeID)
            cmd.Parameters.AddWithValue("@DateReported", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"))
            cmd.Parameters.AddWithValue("@RecordedBy", txtUser.Text)
            cmd.Parameters.AddWithValue("@Status", cbStatus.SelectedItem)
            cmd.ExecuteNonQuery()
            newBlotterID = cmd.LastInsertedId

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            conn.Close()
        End Try

    End Sub
    Private Sub InsertNewNarrative()
        Dim conn As New MySqlConnection
        Dim sql As String
        Dim cmd As MySqlCommand
        Try
            sql = "INSERT INTO blotter_narrative(
                    blotterNo, narrative )
                    VALUES(@BlotterNo, @Narrative)
                   "
            CreateDbConnection()
            conn.Open()

            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@BlotterNo", txtBlotterNumber.Text)
            cmd.Parameters.AddWithValue("@Narrative", txtNarrative.Text)
            cmd.ExecuteNonQuery()
            newNarrativeID = cmd.LastInsertedId

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub GenerateNewBlotterNumber()
        Dim conn As New MySqlConnection
        Dim sql As String
        Dim cmd As MySqlCommand
        Dim dr As MySqlDataReader
        Dim previousNumber As Integer
        Try
            sql = "SELECT MAX(blotterNo) as newBlotterNumber
                    FROM blotter"
            CreateDbConnection()
            conn.Open()

            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                previousNumber = dr(0) + 1
                txtBlotterNumber.Text = Integer.Parse(previousNumber)

            End If

        Catch ex As Exception
        Finally
            conn.Close()
        End Try

    End Sub
End Class