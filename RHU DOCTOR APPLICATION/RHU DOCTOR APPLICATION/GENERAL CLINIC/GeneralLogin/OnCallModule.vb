Imports MySql.Data.MySqlClient
Module OnCallModule
    Public Function GetPatientsInQueue(doctorID As String) As DataTable
        Try
            Dim sql As String = "SELECT PatientID, QueueNumber, QueueStatus FROM queue WHERE QueueStatus = 'Waiting' AND DoctorID = @DoctorID ORDER BY QueueNumber ASC"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DoctorID", doctorID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving patients in the queue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetPatientNameByID(patientID As String) As String
        Try

            Dim sql As String = "SELECT CONCAT(FirstName, ' ', LastName) FROM Patients WHERE PatientID = @PatientID"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@PatientID", patientID)
            }

            Dim result As Object = ExecuteScalar(sql, parameters)

            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                Return result.ToString()
            Else
                Return "Patient Name Not Found"
            End If
        Catch ex As Exception
            MessageBox.Show($"Error retrieving patient name by ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Error Retrieving Patient Name"
        End Try
    End Function

    Public Function GetPatientDetailsByName(patientName As String) As DataTable
        Try

            Dim sql As String = "SELECT * FROM Patients WHERE CONCAT(FirstName, ' ', LastName) = @PatientName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientName", patientName)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving patient details by name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function UpdateQueueStatus(doctorID As String, patientID As String, newStatus As String) As Boolean
        Try
            Dim sql As String = "UPDATE doctorqueue SET QueueStatus = @NewStatus, ExitTime = IF(@NewStatus = 'Done', CURRENT_TIMESTAMP, ExitTime) WHERE PatientID = @PatientID AND DoctorID = @DoctorID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DoctorID", doctorID),
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@NewStatus", newStatus)
        }

            Dim rowsAffected As Integer = ExecuteNonQuery(sql, parameters)

            If rowsAffected > 0 Then
                Return True
            Else
                MessageBox.Show("Failed to update queue status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show($"Error updating queue status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

























    Public Function AddTreatment(doctorName As String, patientID As String, findings As String, prescription As String, patientIllnessID As Integer) As String
        Try
            Dim sql As String = "INSERT INTO Treatment (DoctorName, PatientID, Findings, Prescription, PatientIllnessID, DateRecorded) VALUES (@DoctorName, @PatientID, @Findings, @Prescription, @PatientIllnessID, CURRENT_TIMESTAMP)"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DoctorName", doctorName),
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@Findings", findings),
            New MySqlParameter("@Prescription", prescription),
            New MySqlParameter("@PatientIllnessID", patientIllnessID)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Treatment record added successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error adding treatment record: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function


    Public Function GetLatestTreatment(patientID As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Treatment WHERE PatientID = @PatientID ORDER BY DateRecorded DESC LIMIT 1"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving latest treatment record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetLatestVitalSigns(patientID As String) As DataTable
        Try

            Dim sql As String = "SELECT * FROM VitalSigns WHERE PatientID = @PatientID ORDER BY Timestamp DESC LIMIT 1"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving latest vital signs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function











End Module
