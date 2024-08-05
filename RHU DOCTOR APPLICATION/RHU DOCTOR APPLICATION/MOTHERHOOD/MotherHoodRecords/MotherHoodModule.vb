Imports MySql.Data.MySqlClient
Module MotherHoodModule
    Public Function MotherHoodLoginPage() As Boolean
        Try
            Dim Username As String = MotherHoodLogin.UsernameLogin.Text.Trim
            Dim AccessCode As String = MotherHoodLogin.AcesscodeLogin.Text.Trim

            If String.IsNullOrEmpty(Username) OrElse String.IsNullOrEmpty(AccessCode) Then
                MessageBox.Show("Login canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If Not String.Equals(AccessCode, My.Settings.SelectedAccessCode) Then
                MessageBox.Show("Invalid access code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim authResult As Tuple(Of Boolean, String) = AuthenticateDoctor(Username, AccessCode)

            If authResult.Item1 Then
                Dim doctorID As String = authResult.Item2
                Dim doctorInfo As Tuple(Of String, String, String) = GetDoctorInfo(Username)

                If Not String.IsNullOrEmpty(doctorInfo.Item2) AndAlso Not String.IsNullOrEmpty(doctorInfo.Item3) Then
                    Dim fullName As String = $"{doctorInfo.Item2} {doctorInfo.Item3}"
                    MotherHoodClinic.DoctorNameLBL.Text = fullName
                    MotherHoodClinic.DoctorIDLBL.Text = $"{doctorInfo.Item1}"

                    TimeIn(fullName)

                    MotherHoodClinic.ShowDialog()
                    MotherHoodLogin.Hide()
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

    Public Sub MotherHoodLogoutPage()
        Try
            If Not String.IsNullOrEmpty(MotherHoodClinic.DoctorNameLBL.Text) Then
                TimeOut(MotherHoodClinic.DoctorNameLBL.Text)
            Else
                MessageBox.Show("Full name not available. Unable to logout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during logout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Function AddTreatmentMotherhood(doctorName As String, patientID As String, pregnancyTest As String, ultrasoundResult As String, patientComplains As String, patientHistory As String, pelvicResult As String, medications As String) As String
        Try
            Dim sql As String = "INSERT INTO TREATMENT_MOTHERHOOD (DoctorName, PatientID, PregnancyTest, ULTRASOUNDRESULT, PATIENTCOMPLAINS, PATIENTHISTORY, PELVICRESULT, MEDICATIONS, DateRecorded) VALUES (@DoctorName, @PatientID, @PregnancyTest, @UltrasoundResult, @PatientComplains, @PatientHistory, @PelvicResult, @Medications, CURRENT_TIMESTAMP)"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@DoctorName", doctorName),
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@PregnancyTest", pregnancyTest),
            New MySqlParameter("@UltrasoundResult", ultrasoundResult),
            New MySqlParameter("@PatientComplains", patientComplains),
            New MySqlParameter("@PatientHistory", patientHistory),
            New MySqlParameter("@PelvicResult", pelvicResult),
            New MySqlParameter("@Medications", medications)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Treatment Motherhood record added successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error adding treatment Motherhood record: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function



    Public Function GetDistinctTreatmentDateMotherHood(patientID As String) As List(Of DateTime)
        Try
            Dim sql As String = "SELECT DISTINCT DateRecorded AS TreatmentDate FROM treatment_motherhood WHERE PatientID = @PatientID ORDER BY TreatmentDate DESC"

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



    Public Function GetTreatmentMotherhoodRecordsByDate(patientID As String, targetDate As DateTime) As DataTable
        Try
            Dim sql As String = "SELECT * FROM treatment_motherhood WHERE PatientID = @PatientID AND DateRecorded = @TargetDate"

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
End Module
