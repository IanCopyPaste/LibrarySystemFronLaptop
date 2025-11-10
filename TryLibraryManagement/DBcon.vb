Imports MySql.Data.MySqlClient
Module DBcon
    Public con As New MySqlConnection("server = localhost; user = root; password = ; database = lib")
    Public Sub dbConOpen()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Sub dbConClose()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
End Module
