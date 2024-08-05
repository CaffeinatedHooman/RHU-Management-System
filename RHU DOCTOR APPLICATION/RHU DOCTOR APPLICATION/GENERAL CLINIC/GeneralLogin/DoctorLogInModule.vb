Imports MySql.Data.MySqlClient


Module DoctorLogInModule
    Public Function GetDoctorInfo(Username As String) As Tuple(Of String, String, String)
        Try
            Using connection As MySqlConnection = CreateConnection()
                Dim query As String = "SELECT DoctorID, FirstName, LastName FROM doctors WHERE Username = @Username"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Username", Username)

                connection.Open()

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim doctorID As String = reader("DoctorID").ToString()
                    Dim firstName As String = reader("FirstName").ToString()
                    Dim lastName As String = reader("LastName").ToString()
                    Return Tuple.Create(doctorID, firstName, lastName)
                Else
                    Return Tuple.Create("", "", "")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching doctor information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Tuple.Create("", "", "")
        End Try
    End Function


    Public Function AuthenticateDoctor(Username As String, AccessCode As String) As Tuple(Of Boolean, String)
        Using connection As MySqlConnection = CreateConnection()
            Dim query As String = "SELECT COUNT(*), DoctorID FROM doctors WHERE Username = @Username AND AccessCode = @AccessCode"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", Username)
            cmd.Parameters.AddWithValue("@AccessCode", AccessCode)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim count As Integer = Convert.ToInt32(reader(0))
                    Dim doctorID As String = reader("DoctorID").ToString()

                    If count > 0 Then
                        Return Tuple.Create(True, doctorID)
                    Else
                        Return Tuple.Create(False, "Authentication failed. Please check your Username and AccessCode.")
                    End If
                Else
                    Return Tuple.Create(False, "Error reading authentication result.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error authenticating doctor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Tuple.Create(False, "An error occurred during authentication.")
            End Try
        End Using
    End Function


    Public Function DoctorLogin() As Boolean
        Try
            Dim Username As String = DoctorLoginForm.UsernameLogin.Text.Trim
            Dim AccessCode As String = DoctorLoginForm.AcesscodeLogin.Text.Trim

            If String.IsNullOrEmpty(Username) OrElse String.IsNullOrEmpty(AccessCode) Then
                MessageBox.Show("Login canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            Dim authResult As Tuple(Of Boolean, String) = AuthenticateDoctor(Username, AccessCode)

            If authResult.Item1 Then
                Dim doctorID As String = authResult.Item2
                Dim doctorInfo As Tuple(Of String, String, String) = GetDoctorInfo(Username)

                If Not String.IsNullOrEmpty(doctorInfo.Item2) AndAlso Not String.IsNullOrEmpty(doctorInfo.Item3) Then
                    Dim fullName As String = $"{doctorInfo.Item2} {doctorInfo.Item3}"
                    GeneralDoctorPanel.DoctorNameLBL.Text = fullName
                    GeneralDoctorPanel.DoctorIDLBL.Text = $"{doctorInfo.Item1}"

                    TimeIn(fullName)

                    GeneralDoctorPanel.ShowDialog()
                    DoctorLoginForm.Hide()
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


    Public Sub DoctorLogout()
        Try
            If Not String.IsNullOrEmpty(GeneralDoctorPanel.DoctorNameLBL.Text) Then
                TimeOut(GeneralDoctorPanel.DoctorNameLBL.Text)
            Else
                MessageBox.Show("Full name not available. Unable to logout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during logout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Function GetAllClinics() As DataTable
        Try
            Dim sql As String = "SELECT ClinicName FROM Clinic"
            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            Console.WriteLine($"Error getting all clinics: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Function GetAccessCodeByClinicName(clinicName As String) As String
        Try
            Dim sql As String = "SELECT AccessCode FROM Clinic WHERE ClinicName = @ClinicName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@ClinicName", clinicName)
        }

            Dim resultTable As DataTable = ExecuteQuery(sql, parameters)

            If resultTable IsNot Nothing AndAlso resultTable.Rows.Count > 0 Then
                Return resultTable.Rows(0)("AccessCode").ToString()
            Else
                Return "Access code not found"
            End If
        Catch ex As Exception
            Console.WriteLine($"Error getting access code by clinic name: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function

End Module
