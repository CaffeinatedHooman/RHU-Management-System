Module ClinicSetup3M
    Public Function Clinic3LoginPage() As Boolean
        Try
            Dim Username As String = Clinic3Login.UsernameLogin.Text.Trim
            Dim AccessCode As String = Clinic3Login.AcesscodeLogin.Text.Trim

            If String.IsNullOrEmpty(Username) OrElse String.IsNullOrEmpty(AccessCode) Then
                MessageBox.Show("Login canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If Not String.Equals(AccessCode, My.Settings.SelectedAccessCodeClinic3) Then
                MessageBox.Show("Invalid access code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    Clinic3Login.Hide()
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
    Public Sub Clinic3LogoutPage()
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
End Module
