Imports MySql.Data.MySqlClient
Module HIV_Module

    Public Function HASLoginPage() As Boolean
        Try
            Dim Username As String = HIVLoginsetup.UsernameLogin.Text.Trim
            Dim AccessCode As String = HIVLoginsetup.AcesscodeLogin.Text.Trim

            If String.IsNullOrEmpty(Username) OrElse String.IsNullOrEmpty(AccessCode) Then
                MessageBox.Show("Login canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If Not String.Equals(AccessCode, My.Settings.SelectedAccessCodeHAS) Then
                MessageBox.Show("Invalid access code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim authResult As Tuple(Of Boolean, String) = AuthenticateDoctor(Username, AccessCode)

            If authResult.Item1 Then
                Dim doctorID As String = authResult.Item2
                Dim doctorInfo As Tuple(Of String, String, String) = GetDoctorInfo(Username)

                If Not String.IsNullOrEmpty(doctorInfo.Item2) AndAlso Not String.IsNullOrEmpty(doctorInfo.Item3) Then
                    Dim fullName As String = $"{doctorInfo.Item2} {doctorInfo.Item3}"
                    HAS_CLINIC.DoctorNameLBL.Text = fullName
                    HAS_CLINIC.DoctorIDLBL.Text = $"{doctorInfo.Item1}"

                    TimeIn(fullName)

                    HAS_CLINIC.ShowDialog()
                    HIVLoginsetup.Hide()
                    DoctorsPanel.Hide()

                    Return True
                Else
                    MessageBox.Show("Error fetching doctor information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Else
                MessageBox.Show(authResult.Item2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during doctor login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Sub HASLogoutPage()
        Try
            If Not String.IsNullOrEmpty(HAS_CLINIC.DoctorNameLBL.Text) Then
                TimeOut(HAS_CLINIC.DoctorNameLBL.Text)
            Else
                MessageBox.Show("Full name not available. Unable to logout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during logout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub









    Public Function AddTreatmentHAS(doctorName As String, patientID As String, hivAIDSStatus As String, stiStatus As String, hivAIDSMedication As String, stiMedication As String, healthStatus As String) As Boolean
        Try
            Dim sql As String = "INSERT INTO TreatmentRecordHAS (DoctorName, PatientID, HIV_AIDS_Status, STI_Status, HIV_AIDS_Medication, STI_Medication, HealthStatus, DateRecorded) VALUES (@DoctorName, @PatientID, @HIV_AIDS_Status, @STI_Status, @HIV_AIDS_Medication, @STI_Medication, @HealthStatus, CURRENT_TIMESTAMP)"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DoctorName", doctorName),
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@HIV_AIDS_Status", hivAIDSStatus),
            New MySqlParameter("@STI_Status", stiStatus),
            New MySqlParameter("@HIV_AIDS_Medication", hivAIDSMedication),
            New MySqlParameter("@STI_Medication", stiMedication),
            New MySqlParameter("@HealthStatus", healthStatus)
        }

            Dim rowsAffected As Integer = ExecuteNonQuery(sql, parameters)

            Return rowsAffected > 0
        Catch ex As Exception
            MessageBox.Show($"Error adding treatment record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function



    Public Function GetDistinctTreatmentHAS(patientID As String) As List(Of DateTime)
        Try
            Dim sql As String = "SELECT DISTINCT DateRecorded AS TreatmentDate FROM TreatmentRecordHAS WHERE PatientID = @PatientID ORDER BY TreatmentDate DESC"

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



    Public Function GetTreatmentRecordsByDateHAS(patientID As String, targetDate As DateTime) As DataTable
        Try
            Dim sql As String = "SELECT * FROM TreatmentRecordHAS WHERE PatientID = @PatientID AND DateRecorded = @TargetDate"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@TargetDate", targetDate)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving treatment_tb records by date: {ex.Message}")
            Return Nothing
        End Try
    End Function


    Public Function GetDistinctTreatmentDatesHAS(patientID As String) As List(Of DateTime)
        Try
            Dim sql As String = "SELECT DISTINCT DateRecorded FROM TreatmentRecordHAS WHERE PatientID = @PatientID ORDER BY DateRecorded DESC"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID)
        }

            Dim dateTable As DataTable = ExecuteQuery(sql, parameters)

            Dim distinctDates As New List(Of DateTime)
            For Each row As DataRow In dateTable.Rows
                distinctDates.Add(row.Field(Of DateTime)("DateRecorded"))
            Next

            Return distinctDates
        Catch ex As Exception
            Console.WriteLine($"Error retrieving distinct treatment_tb dates: {ex.Message}")
            Return New List(Of DateTime)()
        End Try
    End Function


End Module
