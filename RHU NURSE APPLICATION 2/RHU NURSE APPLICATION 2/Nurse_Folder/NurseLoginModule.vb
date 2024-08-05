
Imports MySql.Data.MySqlClient
Module NurseLoginModule
    Public Function AuthenticateNurse(Username As String, AccessCode As String) As Boolean

        Using connection As MySqlConnection = CreateConnection()
            Dim query As String = "SELECT COUNT(*) FROM nurses WHERE Username = @Username AND AccessCode = @AccessCode"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", Username)
            cmd.Parameters.AddWithValue("@AccessCode", AccessCode)

            Try
                connection.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show("Error authenticating nurse: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Public Function GetNurseInfo(Username As String) As Tuple(Of String, String)
        Try
            Using connection As MySqlConnection = CreateConnection()
                Dim query As String = "SELECT FirstName, LastName FROM nurses WHERE Username = @Username"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Username", Username)

                connection.Open()

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim firstName As String = reader("FirstName").ToString()
                    Dim lastName As String = reader("LastName").ToString()
                    Return Tuple.Create(firstName, lastName)
                Else
                    Return Tuple.Create("", "")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching nurse information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Tuple.Create("", "")
        End Try
    End Function

    Public Function NurseLogin() As Boolean
        Try
            Dim Username As String = NurseLoginForm.UsernameLogin.Text
            Dim AccessCode As String = NurseLoginForm.AcesscodeLogin.Text

            If String.IsNullOrEmpty(Username) OrElse String.IsNullOrEmpty(AccessCode) Then
                MessageBox.Show("Login canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If Not AuthenticateNurse(Username, AccessCode) Then
                MessageBox.Show("Login failed. Please check your Username and AccessCode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim nurseInfo As Tuple(Of String, String) = GetNurseInfo(Username)

            If Not String.IsNullOrEmpty(nurseInfo.Item1) AndAlso Not String.IsNullOrEmpty(nurseInfo.Item2) Then
                Dim fullName As String = $"{nurseInfo.Item1} {nurseInfo.Item2}"
                NursePanel.NurseNameLBL.Text = fullName

                TimeIn(fullName)

                NursePanel.Show()
                NurseLoginForm.Hide()

                Return True
            Else
                MessageBox.Show("Error fetching nurse information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during nurse login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub Logout()
        Try
            If Not String.IsNullOrEmpty(NursePanel.NurseNameLBL.Text) Then
                TimeOut(NursePanel.NurseNameLBL.Text)
            Else
                MessageBox.Show("Full name not available. Unable to logout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during logout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module

