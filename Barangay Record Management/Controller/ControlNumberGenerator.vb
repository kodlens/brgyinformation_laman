Module ControlNumberGenerator

    Public Function ResidentClearanceControlNumber()

        Dim year As String = Now.Year.ToString
        Dim month As String = Date.Now.Month
        Dim clearancesuffix As String = "0000001"
        Dim clearanceprefix As String = "BRC"
        Dim FinalControl As String = clearanceprefix & "-" & year & month & clearancesuffix
        Return FinalControl

    End Function

    Public Function ConstructionClearanceControlNumber()

        Dim year As String = Now.Year.ToString
        Dim month As String = Date.Now.Month
        Dim clearancesuffix As String = "0000001"
        Dim clearanceprefix As String = "BCC"
        Dim FinalControl As String = clearanceprefix & "-" & year & month & clearancesuffix
        Return FinalControl

    End Function
    Public Function BusinessClearanceControlNumber()

        Dim year As String = Now.Year.ToString
        Dim month As String = Date.Now.Month
        Dim clearancesuffix As String = "0000001"
        Dim clearanceprefix As String = "BBC"
        Dim FinalControl As String = clearanceprefix & "-" & year & month & clearancesuffix
        Return FinalControl

    End Function
End Module
