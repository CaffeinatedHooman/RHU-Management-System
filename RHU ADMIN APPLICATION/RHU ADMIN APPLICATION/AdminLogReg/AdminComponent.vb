Imports MySql.Data.MySqlClient


Module AdminComponent
    Public Function RegisterAdmin(adminID As String, firstName As String, lastName As String, gender As String, address As String, username As String, password As String) As Boolean

        Using connection As MySqlConnection = CreateConnection()
            Dim query As String = "INSERT INTO administrators (AdminID, FirstName, LastName, Gender, Address, Username, Password) VALUES (@adminID, @firstName, @lastName, @gender, @address, @username, @password)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@adminID", adminID)
            cmd.Parameters.AddWithValue("@firstName", firstName)
            cmd.Parameters.AddWithValue("@lastName", lastName)
            cmd.Parameters.AddWithValue("@gender", gender)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

            Try
                connection.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                Return rowsAffected > 0
            Catch ex As Exception
                MessageBox.Show("Error registering admin: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Public Function GenerateAdminID() As String
        Dim sql As String = "SELECT MAX(id) FROM administrators"
        Dim maxID As Object = ExecuteScalar(sql)

        Dim counter As Integer = 1
        If maxID IsNot Nothing AndAlso Not DBNull.Value.Equals(maxID) Then
            counter = Convert.ToInt32(maxID) + 1
        End If

        Dim formattedID As String = "ADMIN" & counter.ToString("D3")
        Return formattedID
    End Function

    Public Function AuthenticateAdmin(Username As String, Password As String) As Boolean
        Using connection As MySqlConnection = CreateConnection()
            Dim query As String = "SELECT COUNT(*) FROM administrators WHERE Username = @Username AND Password = @Password"
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
                MessageBox.Show("Error authenticating admin: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Public Function GetAdminInfo(Username As String) As Tuple(Of String, String)
        Try
            Using connection As MySqlConnection = CreateConnection()
                Dim query As String = "SELECT FirstName, LastName FROM administrators WHERE Username = @Username"
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
            MessageBox.Show("Error fetching admin information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Tuple.Create("", "")
        End Try
    End Function



    Public Sub LogoutAdmin()
        Try
            If Not String.IsNullOrEmpty(AdminPanel.AdminUser.Text) Then
                TimeOut(AdminPanel.AdminUser.Text)
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during logout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Module
