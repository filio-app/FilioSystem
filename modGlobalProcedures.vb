Imports MySql.Data.MySqlClient

Module modGlobalProcedures

    Public Function fncConnectToDatabse() As Boolean

        Try
            serverName = "localhost"
            dbName = "filio_system"
            dbUserName = "root"
            dbPassword = "filio"
            port = "3306"

            If conFilioSys.State = ConnectionState.Closed Then
                conFilioSys = New MySqlConnection
                strConnectionString = "SERVER=" & serverName & ";" _
                                  & "DATABASE=" & dbName & ";" _
                                  & "USERNAME=" & dbUserName & ";" _
                                  & "PASSWORD=" & dbPassword & ";" _
                                  & "PORT=" & port

                conFilioSys.ConnectionString = strConnectionString
                conFilioSys.Open()
                Command.Connection = conFilioSys
                Return True
            Else
                conFilioSys.Close()
                Return False

            End If

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        Return False
    End Function

    Public Sub chkDatabaseConnection()
        If fncConnectToDatabse() = True Then
        Else
            conFilioSys.Open()
        End If

    End Sub


End Module
