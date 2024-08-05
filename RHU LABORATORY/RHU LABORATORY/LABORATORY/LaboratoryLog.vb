Imports MySql.Data.MySqlClient
Module LaboratoryLog

    Public Function AuthenticateLabPersonnel(Username As String, AccessCode As String) As Boolean
        Using connection As MySqlConnection = CreateConnection()
            Dim query As String = "SELECT COUNT(*) FROM laboratoryusers WHERE Username = @Username AND AccessCode = @AccessCode"
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
                MessageBox.Show("Error authenticating lab personnel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function

    Public Function GetLabPersonnelInfo(Username As String) As Tuple(Of String, String, String, String)
        Try
            Using connection As MySqlConnection = CreateConnection()
                Dim query As String = "SELECT LaboratoryUserID, FirstName, LastName, Laboratory FROM laboratoryusers WHERE Username = @Username"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Username", Username)

                connection.Open()

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim labPersonnelID As String = reader("LaboratoryUserID").ToString()
                    Dim firstName As String = reader("FirstName").ToString()
                    Dim lastName As String = reader("LastName").ToString()
                    Dim laboratory As String = reader("Laboratory").ToString()
                    Return Tuple.Create(labPersonnelID, firstName, lastName, laboratory)
                Else
                    Return Tuple.Create("", "", "", "")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching lab personnel information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Tuple.Create("", "", "", "")
        End Try
    End Function




    Public Function LabPersonnelLogin() As Boolean
        Try
            Dim Username As String = Laboratory_Login.UsernameLogin.Text
            Dim AccessCode As String = Laboratory_Login.AcesscodeLogin.Text

            If String.IsNullOrEmpty(Username) OrElse String.IsNullOrEmpty(AccessCode) Then
                MessageBox.Show("Login canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If

            If Not AuthenticateLabPersonnel(Username, AccessCode) Then
                MessageBox.Show("Login failed. Please check your Username and AccessCode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Dim labPersonnelInfo As Tuple(Of String, String, String, String) = GetLabPersonnelInfo(Username)

            If Not String.IsNullOrEmpty(labPersonnelInfo.Item2) AndAlso Not String.IsNullOrEmpty(labPersonnelInfo.Item3) Then
                Dim fullName As String = $"{labPersonnelInfo.Item2} {labPersonnelInfo.Item3}"
                Dim laboratoryName As String = labPersonnelInfo.Item4

                Laboratory_Panel.lblPersonInCharge.Text = fullName
                Laboratory_Panel.lblLaboratoryName.Text = laboratoryName

                TimeIn(fullName)

                Laboratory_Panel.Show()
                Laboratory_Login.Hide()

                Return True
            Else
                MessageBox.Show("Error fetching lab personnel information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during lab personnel login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function



    Public Sub LabPersonnelLogout()
        Try
            If Not String.IsNullOrEmpty(Laboratory_Panel.lblPersonInCharge.Text) Then
                TimeOut(Laboratory_Panel.lblPersonInCharge.Text)
            Else
                MessageBox.Show("Full name not available. Unable to logout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during lab personnel logout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
