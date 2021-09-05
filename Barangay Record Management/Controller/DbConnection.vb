Imports MySql.Data.MySqlClient
Module DbConnection
    Dim server As String = "localhost"
    Dim user As String = "root"
    Dim password As String = ""
    Dim database As String = "brgyinfo_laman"


    'public init
    Public con As MySqlConnection
    Public cmd As MySqlCommand
    Public query As String


    Dim conn As New MySqlConnection

    Public Sub CreateDbConnection()
        Try
            conn.ConnectionString = "Server ='" & server & "'; Username ='" & user & "';Password ='" & password & "';Database ='" & database & "'"
        Catch ex As Exception
            MsgBox("Failed to establish database connection!", MsgBoxStyle.Critical)
        End Try
    End Sub

    'extra connection
    'return connection as object
    Public Sub conOpen()
        con = New MySqlConnection("Server ='" & server & "'; Username ='" & user & "';Password ='" & password & "';Database ='" & database & "'")
        con.Open()
    End Sub

    Public Sub conClose()
        con.Dispose()
        con.Close()
    End Sub



End Module
