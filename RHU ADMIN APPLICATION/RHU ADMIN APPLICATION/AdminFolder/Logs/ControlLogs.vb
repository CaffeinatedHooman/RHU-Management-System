Imports MySql.Data.MySqlClient
Module ControlLogs
    Public Function GetLogs() As DataTable
        Try
            Using connection As MySqlConnection = CreateConnection()
                connection.Open()

                Dim query As String = "SELECT Fullname, TimeIn, TimeOut FROM timelogs"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                adapter.Fill(dataTable)

                Return dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting logs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetLogsByMonth(searchText As String) As DataTable
        Try
            Using connection As MySqlConnection = CreateConnection()
                connection.Open()

                Dim query As String = "SELECT Fullname, TimeIn, TimeOut FROM timelogs WHERE TimeIn LIKE @DateTimeLogsSearch OR TimeOut LIKE @DateTimeLogsSearch"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                adapter.SelectCommand.Parameters.AddWithValue("@DateTimeLogsSearch", $"%{searchText}%")

                adapter.Fill(dataTable)

                Return dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting logs by month: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetLogsByFullName(fullName As String) As DataTable
        Try
            Using connection As MySqlConnection = CreateConnection()
                connection.Open()

                Dim query As String = "SELECT Fullname, TimeIn, TimeOut FROM timelogs WHERE Fullname LIKE @FullNameSearch"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                adapter.SelectCommand.Parameters.AddWithValue("@FullNameSearch", $"%{fullName}%")

                adapter.Fill(dataTable)

                Return dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting logs by full name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function SearchPatientsByDate(searchDate As String) As DataTable
        Try
            Using connection As MySqlConnection = CreateConnection()
                connection.Open()

                Dim query As String = "SELECT Fullname, TimeIn, TimeOut FROM timelogs WHERE DATE(TimeIn) = @SearchDate OR DATE(TimeOut) = @SearchDate"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                Dim parsedDate As DateTime
                If DateTime.TryParse(searchDate, parsedDate) Then
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchDate", parsedDate.Date)
                    adapter.Fill(dataTable)
                Else
                    MessageBox.Show("Invalid date format. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                Return dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching patients by date: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function




End Module
