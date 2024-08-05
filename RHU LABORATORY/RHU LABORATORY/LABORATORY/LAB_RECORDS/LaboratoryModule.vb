Imports MySql.Data.MySqlClient
Imports System.IO

Module LaboratoryModule
    Public Function AddLaboratoryResult(patientID As String, resultDescription As String, labResultImage As Byte(), inChargePerson As String, recordDate As DateTime, laboratoryName As String) As String
        Try
            Dim sql As String = "INSERT INTO LaboratoryResults (PatientID, ResultDescription, LabResultImage, InChargePerson, RecordDate, LaboratoryName) VALUES (@PatientID, @ResultDescription, @LabResultImage, @InChargePerson, @RecordDate, @LaboratoryName)"

            Using connection As MySqlConnection = CreateConnection()
                Using cmd As New MySqlCommand(sql, connection)
                    connection.Open()

                    cmd.Parameters.AddWithValue("@PatientID", patientID)
                    cmd.Parameters.AddWithValue("@ResultDescription", resultDescription)
                    cmd.Parameters.AddWithValue("@LabResultImage", labResultImage)
                    cmd.Parameters.AddWithValue("@InChargePerson", inChargePerson)
                    cmd.Parameters.AddWithValue("@RecordDate", recordDate)
                    cmd.Parameters.AddWithValue("@LaboratoryName", laboratoryName)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        Return "Laboratory result added successfully!"
                    Else
                        Return "Failed to add laboratory result. No rows affected."
                    End If
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine($"Error adding laboratory result: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function


    Public Function GetDistinctLabResultDates(patientID As String) As List(Of DateTime)
        Try
            Dim sql As String = "SELECT DISTINCT RecordDate AS LabResultDate FROM LaboratoryResults WHERE PatientID = @PatientID ORDER BY LabResultDate DESC"

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@PatientID", patientID)
            }

            Dim dateTable As DataTable = ExecuteQuery(sql, parameters)

            Dim distinctDates As New List(Of DateTime)
            For Each row As DataRow In dateTable.Rows
                distinctDates.Add(Convert.ToDateTime(row("LabResultDate")))
            Next

            Return distinctDates
        Catch ex As Exception
            MessageBox.Show($"Error retrieving distinct lab result dates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New List(Of DateTime)()
        End Try
    End Function

    Public Function GetLabResultsByDate(patientID As String, targetDate As DateTime) As DataTable
        Try
            Dim sql As String = "SELECT * FROM LaboratoryResults WHERE PatientID = @PatientID AND RecordDate = @TargetDate"

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@PatientID", patientID),
                New MySqlParameter("@TargetDate", targetDate)
            }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving lab results by date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function


    Public Function GetPatientDetailsByID(patientID As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Patients WHERE PatientID = @PatientID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving patient details by ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function SearchPatientsByFirstName(firstName As String) As DataTable
        Try
            Dim sql As String = "SELECT PatientID, FirstName, LastName FROM Patients WHERE FirstName LIKE @FirstName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", $"%{firstName}%")
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for patients by first name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function SearchPatientsByLastName(lastName As String) As DataTable
        Try
            Dim sql As String = "SELECT PatientID, FirstName, LastName FROM Patients WHERE LastName LIKE @LastName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LastName", $"%{lastName}%")
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for patients by last name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function


    Public Function GetPatientDetailsByName(firstName As String, lastName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Patients WHERE FirstName = @FirstName AND LastName = @LastName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving patient details by name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function



End Module
