Imports MySql.Data.MySqlClient
Module LoginModule
    Public Function AuthenticatePharmacist(Username As String, Password As String) As Boolean

        Using connection As MySqlConnection = CreateConnection()
            Dim query As String = "SELECT COUNT(*) FROM pharmacist WHERE Username = @Username AND Password = @Password"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", Username)
            cmd.Parameters.AddWithValue("@Password", Password)

            Try
                connection.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show("Error authenticating Pharmacist: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Public Function GetPharmacistInfo(Username As String) As Tuple(Of String, String)
        Try
            Using connection As MySqlConnection = CreateConnection()
                Dim query As String = "SELECT FirstName, LastName FROM pharmacist WHERE Username = @Username"
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
            MessageBox.Show("Error fetching Pharmacist information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Tuple.Create("", "")
        End Try
    End Function

    Public Function PharmacistLogin() As Boolean
        Try
            Dim Username As String = PRC_Login.UsernameLogin.Text
            Dim Password As String = PRC_Login.AcesscodeLogin.Text

            If String.IsNullOrEmpty(Username) OrElse String.IsNullOrEmpty(Password) Then
                MessageBox.Show("Login canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If Not AuthenticatePharmacist(Username, Password) Then
                MessageBox.Show("Login failed. Please check your Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim PharmacistInfo As Tuple(Of String, String) = GetPharmacistInfo(Username)

            If Not String.IsNullOrEmpty(PharmacistInfo.Item1) AndAlso Not String.IsNullOrEmpty(PharmacistInfo.Item2) Then
                Dim fullName As String = $"{PharmacistInfo.Item1} {PharmacistInfo.Item2}"
                PharmacyPanel.PharmacistNameLBL.Text = fullName

                TimeIn(fullName)

                PharmacyPanel.Show()
                PRC_Login.Hide()

                Return True
            Else
                MessageBox.Show("Error fetching Pharmacist information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during Pharmacist login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub Logout()
        Try
            If Not String.IsNullOrEmpty(PharmacyPanel.PharmacistNameLBL.Text) Then
                TimeOut(PharmacyPanel.PharmacistNameLBL.Text)
            Else
                MessageBox.Show("Full name not available. Unable to logout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during logout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
