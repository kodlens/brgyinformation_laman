Public Class frmCertification
    Private Sub frmCertification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        orDate.Format = DateTimePickerFormat.Custom
        orDate.CustomFormat = "yyyy-MM-dd"

        txtFirstName.Enabled = False
        txtMiddleName.Enabled = False
        txtLastName.Enabled = False
        'txtCivilStatus.Enabled = False
        txtPurok.Enabled = False
        txtPurpose.Focus()

    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub cbClearanceType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClearanceType.SelectedIndexChanged
        If cbClearanceType.SelectedIndex = 0 Then
            ''generate barangay clearance crystal report
        ElseIf cbClearanceType.SelectedIndex = 1 Then
            ''generate barangay certification crystal report
        ElseIf cbClearanceType.SelectedIndex = 2 Then
            ''generate certificate of indigency crystal report
        ElseIf cbClearanceType.SelectedItem = 3 Then
            ''generate barangay business permit
        End If
    End Sub


    Private Sub txtORNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtORNumber.KeyPress
        ''Just Digits
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        ''Allow Backspace
        If e.KeyChar = Convert.ToChar(8) Then
            e.Handled = False
        End If

        ''Allow Enter Key
        If e.KeyChar = Convert.ToChar(13) Then
            e.Handled = False
        End If
    End Sub
End Class