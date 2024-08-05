Imports MySql.Data.MySqlClient
Module PatientHistories

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
    Public Function GetVitalSignsByDate(patientID As String, targetDate As DateTime) As DataTable
        Try
            Dim sql As String = "SELECT * FROM VitalSigns WHERE PatientID = @PatientID AND Timestamp = @TargetDate"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@TargetDate", targetDate)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving vital signs by date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
    Public Function GetTreatmentRecordsByDate(patientID As String, targetDate As DateTime) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Treatment WHERE PatientID = @PatientID AND DateRecorded = @TargetDate"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@TargetDate", targetDate)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving treatment records by date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
    Public Function GetDistinctVitalSignDates(patientID As String) As List(Of DateTime)
        Try
            Dim sql As String = "SELECT DISTINCT Timestamp AS VitalSignDate FROM VitalSigns WHERE PatientID = @PatientID ORDER BY VitalSignDate DESC"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID)
        }

            Dim dateTable As DataTable = ExecuteQuery(sql, parameters)

            Dim distinctDates As New List(Of DateTime)
            For Each row As DataRow In dateTable.Rows
                distinctDates.Add(row.Field(Of DateTime)("VitalSignDate"))
            Next

            Return distinctDates
        Catch ex As Exception
            MessageBox.Show($"Error retrieving distinct vital sign dates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New List(Of DateTime)()
        End Try
    End Function
    Public Function GetDistinctTreatmentDates(patientID As String) As List(Of DateTime)
        Try
            Dim sql As String = "SELECT DISTINCT DateRecorded AS TreatmentDate FROM Treatment WHERE PatientID = @PatientID ORDER BY TreatmentDate DESC"

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@PatientID", patientID)
            }

            Dim dateTable As DataTable = ExecuteQuery(sql, parameters)

            Dim distinctDates As New List(Of DateTime)
            For Each row As DataRow In dateTable.Rows
                distinctDates.Add(Convert.ToDateTime(row("TreatmentDate")))
            Next

            Return distinctDates
        Catch ex As Exception
            MessageBox.Show($"Error retrieving distinct treatment dates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New List(Of DateTime)()
        End Try
    End Function

    Public Function GetIllnessNameByID(illnessID As Integer) As String
        Try
            Dim sql As String = "SELECT IllnessName FROM Illnesses WHERE IllnessID = @IllnessID"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@IllnessID", illnessID)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToString(result)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error retrieving illness name by ID: {ex.Message}")
        End Try

        Return "Unknown"
    End Function

    Public Function GetIllnessName(searchText As String) As String
        Try
            Dim sql As String = "SELECT IllnessName FROM illnesses WHERE IllnessName LIKE @SearchText"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@SearchText", $"%{searchText}%")
            }

            Dim result As Object = ExecuteScalar(sql, parameters)
            Return If(result IsNot Nothing AndAlso Not IsDBNull(result), result.ToString(), "")
        Catch ex As Exception
            Throw New Exception($"Error getting illness name: {ex.Message}", ex)
        End Try
    End Function

    Public Function GetIllnessIDByName(illnessName As String) As Integer
        Try
            Dim sql As String = "SELECT IllnessID FROM Illnesses WHERE IllnessName = @IllnessName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@IllnessName", illnessName)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToInt32(result)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error retrieving illness ID by name: {ex.Message}")
        End Try

        Return -1
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
End Module
