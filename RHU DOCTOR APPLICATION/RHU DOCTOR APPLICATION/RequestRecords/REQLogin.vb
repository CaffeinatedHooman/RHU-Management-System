Public Class REQLogin
    Private Sub DocLoginVTB_Click(sender As Object, e As EventArgs) Handles DocLoginVTB.Click
        DoctorLogin2()
    End Sub
    Private Function DoctorLogin2() As Boolean
        Try
            Dim Username As String = UsernameLogin.Text.Trim
            Dim AccessCode As String = AcesscodeLogin.Text.Trim

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
                    DocumentsPanel.DoctorNameLBL.Text = fullName
                    DocumentsPanel.DoctorIDLBL.Text = $"{doctorInfo.Item1}"

                    DocumentsPanel.Show()
                    Me.Hide()

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


    Private Sub REQLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class