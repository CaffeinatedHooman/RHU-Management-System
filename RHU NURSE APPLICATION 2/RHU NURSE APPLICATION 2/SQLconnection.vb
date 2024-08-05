Imports MySql.Data.MySqlClient
Module SQLconnection
    Private ReadOnly ConnectionString As String = "server=192.168.235.98;user id=root;database=RHUdatabase"

    Public Function CreateConnection() As MySqlConnection
        Dim connection As New MySqlConnection(ConnectionString)
        If connection.State = ConnectionState.Closed Then
            Return connection
        Else
            Throw New InvalidOperationException("Connection is already open.")
        End If
    End Function

    Public Sub CheckDatabaseConnection()
        Using connection As MySqlConnection = CreateConnection()
            Try
                connection.Open()
                MessageBox.Show("Connected to the database successfully.", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                HandleError("Could not connect to the database.", ex)
            End Try
        End Using
    End Sub

    Public Function ExecuteNonQuery(sql As String, Optional parameters As List(Of MySqlParameter) = Nothing) As Integer
        Using connection As MySqlConnection = CreateConnection()
            Using cmd As New MySqlCommand(sql, connection)
                Try
                    connection.Open()
                    AddParameters(cmd, parameters)
                    Return cmd.ExecuteNonQuery()
                Catch ex As Exception
                    Throw New Exception("Error executing non-query.", ex)
                End Try
            End Using
        End Using
    End Function

    Public Function ExecuteQuery(sql As String, Optional parameters As List(Of MySqlParameter) = Nothing) As DataTable
        Using connection As MySqlConnection = CreateConnection()
            Using cmd As New MySqlCommand(sql, connection)
                Try
                    connection.Open()
                    AddParameters(cmd, parameters)
                    Dim dt As New DataTable()
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                    Return dt
                Catch ex As Exception
                    Throw New Exception("Error executing query.", ex)
                End Try
            End Using
        End Using
    End Function

    Public Function ExecuteScalar(sql As String, Optional parameters As List(Of MySqlParameter) = Nothing) As Object
        Using connection As MySqlConnection = CreateConnection()
            Using cmd As New MySqlCommand(sql, connection)
                Try
                    connection.Open()
                    AddParameters(cmd, parameters)
                    Return cmd.ExecuteScalar()
                Catch ex As Exception
                    Throw New Exception("Error executing scalar query.", ex)
                End Try
            End Using
        End Using
    End Function

    Public Sub AddParameters(command As MySqlCommand, parameters As List(Of MySqlParameter))
        If parameters IsNot Nothing AndAlso parameters.Count > 0 Then
            command.Parameters.AddRange(parameters.ToArray())
        End If
    End Sub

    Private Sub HandleError(message As String, ex As Exception)
        MessageBox.Show(message & vbCrLf & ex.Message, "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function ExecuteReader(sql As String, parameters As List(Of MySqlParameter)) As DataTable
        Dim dataTable As New DataTable()

        Try
            Using connection As New MySqlConnection(ConnectionString)
                Using command As New MySqlCommand(sql, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    connection.Open()

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        dataTable.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception

            Console.WriteLine($"Error executing reader: {ex.Message}")
            Throw
        End Try

        Return dataTable
    End Function


    Public Sub TimeIn(Fullname As String)
        Try
            Using connection As MySqlConnection = CreateConnection()
                Dim query As String = "INSERT INTO timelogs (Fullname, TimeIn) VALUES (@Fullname, CURRENT_TIMESTAMP)"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Fullname", Fullname)

                connection.Open()
                cmd.ExecuteNonQuery()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error recording time-in: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub TimeOut(Fullname As String)
        Try
            Using connection As MySqlConnection = CreateConnection()
                Dim query As String = "UPDATE timelogs SET TimeOut = CURRENT_TIMESTAMP WHERE Fullname = @Fullname AND TimeOut IS NULL"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Fullname", Fullname)

                connection.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error recording time-out: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GeneratePatientID() As String
        Dim sql As String = "SELECT MAX(ID) FROM Patients"
        Dim maxID As Object = ExecuteScalar(sql)

        Dim counter As Integer = 1
        If maxID IsNot Nothing AndAlso Not DBNull.Value.Equals(maxID) Then
            counter = Convert.ToInt32(maxID) + 1
        End If

        Dim formattedID As String = "Patient" & counter.ToString("D4")
        Return formattedID
    End Function

End Module

