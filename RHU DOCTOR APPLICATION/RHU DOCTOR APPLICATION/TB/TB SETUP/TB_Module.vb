Imports MySql.Data.MySqlClient

Module TB_Module


    Public Function TBLoginPage() As Boolean
        Try
            Dim Username As String = TB_LoginForm.UsernameLogin.Text.Trim
            Dim AccessCode As String = TB_LoginForm.AcesscodeLogin.Text.Trim

            If String.IsNullOrEmpty(Username) OrElse String.IsNullOrEmpty(AccessCode) Then
                MessageBox.Show("Login canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If Not String.Equals(AccessCode, My.Settings.SelectedAccessCodeTB) Then
                MessageBox.Show("Invalid access code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim authResult As Tuple(Of Boolean, String) = AuthenticateDoctor(Username, AccessCode)

            If authResult.Item1 Then
                Dim doctorID As String = authResult.Item2
                Dim doctorInfo As Tuple(Of String, String, String) = GetDoctorInfo(Username)

                If Not String.IsNullOrEmpty(doctorInfo.Item2) AndAlso Not String.IsNullOrEmpty(doctorInfo.Item3) Then
                    Dim fullName As String = $"{doctorInfo.Item2} {doctorInfo.Item3}"
                    TB_CLINIC.DoctorNameLBL.Text = fullName
                    TB_CLINIC.DoctorIDLBL.Text = $"{doctorInfo.Item1}"

                    TimeIn(fullName)

                    TB_CLINIC.ShowDialog()
                    TB_LoginForm.Hide()
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

    Public Sub TBLogoutPage()
        Try
            If Not String.IsNullOrEmpty(TB_CLINIC.DoctorNameLBL.Text) Then
                TimeOut(TB_CLINIC.DoctorNameLBL.Text)
            Else
                MessageBox.Show("Full name not available. Unable to logout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during logout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Function AddTreatmentTB(doctorName As String, patientID As String, tbTest As String, patientHistory As String, patientComplains As String, medicalHistory As String, medications As String) As String
        Try
            Using connection As MySqlConnection = CreateConnection()
                Dim sql As String = "INSERT INTO treatment_tb (DoctorName, PatientID, TBTest, PatientHistory, PatientComplains, MedicalHistory, Medications, DateRecorded) " &
                               "VALUES (@DoctorName, @PatientID, @TBTest, @PatientHistory, @PatientComplains, @MedicalHistory, @Medications, CURRENT_TIMESTAMP)"

                Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@DoctorName", doctorName),
                New MySqlParameter("@PatientID", patientID),
                New MySqlParameter("@TBTest", tbTest),
                New MySqlParameter("@PatientHistory", patientHistory),
                New MySqlParameter("@PatientComplains", patientComplains),
                New MySqlParameter("@MedicalHistory", medicalHistory),
                New MySqlParameter("@Medications", medications)
            }

                ExecuteNonQuery(sql, parameters)
            End Using

            Return "Treatment record added successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error adding treatment_tb record: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function

    Public Function GetDistinctTreatmentTBDates(patientID As String) As List(Of DateTime)
        Try
            Dim sql As String = "SELECT DISTINCT DateRecorded FROM treatment_tb WHERE PatientID = @PatientID ORDER BY DateRecorded DESC"

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


    Public Function GetTreatmentTBRecordsByDate(patientID As String, targetDate As DateTime) As DataTable
        Try

            Dim sql As String = "SELECT * FROM treatment_tb  WHERE PatientID = @PatientID AND DateRecorded = @TargetDate"

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







End Module
