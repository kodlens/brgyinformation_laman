Public Module Box


    Public Sub ErrBox(ByVal msg As String)
        MessageBox.Show(msg, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub InfoBox(ByVal msg As String)
        MessageBox.Show(msg, "INFORMATION!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub WarnBox(ByVal msg As String)
        MessageBox.Show(msg, "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Module
