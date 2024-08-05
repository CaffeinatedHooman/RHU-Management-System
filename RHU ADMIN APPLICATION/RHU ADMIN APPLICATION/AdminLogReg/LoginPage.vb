Public Class LoginPageAdmin

    Private Sub YourFormName_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.F7 Then

            Dim newForm As New RegisteAdmin()
            newForm.Show()
        End If
    End Sub

    Public Function AdminLogin() As Boolean
        Try
            Dim Username As String = AdminUsernameLogin.Text
            Dim Password As String = AdminPasswordLogin.Text

            If String.IsNullOrEmpty(Username) OrElse String.IsNullOrEmpty(Password) Then
                MessageBox.Show("Login canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If Not AuthenticateAdmin(Username, Password) Then
                MessageBox.Show("Login failed. Please check your Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim adminInfo As Tuple(Of String, String) = GetAdminInfo(Username)

            If Not String.IsNullOrEmpty(adminInfo.Item1) AndAlso Not String.IsNullOrEmpty(adminInfo.Item2) Then
                Dim fullName As String = $"{adminInfo.Item1} {adminInfo.Item2}"
                AdminPanel.AdminUser.Text = fullName

                TimeIn(fullName)

                AdminPanel.Show()
                Me.Hide()
                Return True
            Else
                MessageBox.Show("Error fetching admin information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during admin login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub LoginAdminRead_Click(sender As Object, e As EventArgs) Handles LoginAdminRead.Click
        AdminLogin()
    End Sub

    Private Sub LoginPageAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AccessCodeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AccessCodeCheck.CheckedChanged
        If AccessCodeCheck.Checked Then
            AdminPasswordLogin.PasswordChar = ControlChars.NullChar
        Else
            AdminPasswordLogin.PasswordChar = "⫸"
        End If
    End Sub
End Class
