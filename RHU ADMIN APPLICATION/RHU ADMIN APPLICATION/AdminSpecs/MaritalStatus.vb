Imports MySql.Data.MySqlClient
Public Class MaritalStatus
    Private Sub MaritalStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAllMaritalStatuses()
    End Sub

    Private Sub DisplayAllMaritalStatuses()
        Try
            ListBoxMaritalStatuses.Items.Clear()
            MaritalStatusListBoxUpdate.Items.Clear()
            MaritalStatusDelete.Items.Clear()
            Dim maritalStatusesTable As DataTable = GetAllMaritalStatuses()

            If maritalStatusesTable IsNot Nothing AndAlso maritalStatusesTable.Rows.Count > 0 Then
                For Each row As DataRow In maritalStatusesTable.Rows
                    ListBoxMaritalStatuses.Items.Add(row("MaritalStatusName").ToString())
                    MaritalStatusListBoxUpdate.Items.Add(row("MaritalStatusName").ToString())
                    MaritalStatusDelete.Items.Add(row("MaritalStatusName").ToString())
                Next
            Else
                ListBoxMaritalStatuses.Items.Add("No Marital Statuses found.")
                MaritalStatusListBoxUpdate.Items.Add("No Marital Statuses found.")
                MaritalStatusDelete.Items.Add("No Marital Statuses found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error displaying all marital statuses: {ex.Message}")
        End Try
    End Sub

    Private Sub btnAddMaritalStatus_Click(sender As Object, e As EventArgs) Handles btnAddMaritalStatus.Click
        Try

            Dim maritalStatus As String = txtMaritalStatus.Text.Trim()

            If String.IsNullOrEmpty(maritalStatus) Then
                MessageBox.Show("Please enter a marital status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim result As String = AddMaritalStatus(maritalStatus)
            MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtMaritalStatus.Clear()
            DisplayAllMaritalStatuses()

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MaritalStatusListBoxUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaritalStatusListBoxUpdate.SelectedIndexChanged
        Try
            If MaritalStatusListBoxUpdate.SelectedIndices.Count > 0 Then
                Dim selectedIndex As Integer = MaritalStatusListBoxUpdate.SelectedIndices(0)
                txtOldMaritalStatus.Text = MaritalStatusListBoxUpdate.Items(selectedIndex).ToString()
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling marital status selection: {ex.Message}")
        End Try
    End Sub

    Private Sub btnUpdateMaritalStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateMaritalStatus.Click
        Try
            Dim oldMaritalStatus As String = txtOldMaritalStatus.Text.Trim()
            Dim newMaritalStatus As String = txtNewMaritalStatus.Text.Trim()

            If String.IsNullOrEmpty(oldMaritalStatus) OrElse String.IsNullOrEmpty(newMaritalStatus) Then
                MessageBox.Show("Please enter both old and new marital status names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim confirmationResult As DialogResult = MessageBox.Show($"Are you sure you want to update marital status '{oldMaritalStatus}' to '{newMaritalStatus}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


            If confirmationResult = DialogResult.Yes Then

                Dim result As String = UpdateMaritalStatus(oldMaritalStatus, newMaritalStatus)
                MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)


                DisplayAllMaritalStatuses()


                txtOldMaritalStatus.Text = "MaritalStatus"
                txtNewMaritalStatus.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function UpdateMaritalStatus(oldMaritalStatusName As String, newMaritalStatusName As String) As String
        Try
            Dim sql As String = "UPDATE MaritalStatus SET MaritalStatusName = @NewMaritalStatusName WHERE MaritalStatusName = @OldMaritalStatusName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@NewMaritalStatusName", newMaritalStatusName),
            New MySqlParameter("@OldMaritalStatusName", oldMaritalStatusName)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Marital status updated successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error updating marital status: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function

    Public Function AddMaritalStatus(MaritalStatusName As String) As String
        Try

            If Not IsValueUnique(MaritalStatusName, "MaritalStatus", "MaritalStatusName") Then
                Return "Marital status already exists."
            End If

            Dim sql As String = "INSERT INTO MaritalStatus (MaritalStatusName) VALUES (@MaritalStatusName)"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@MaritalStatusName", MaritalStatusName)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Marital status added successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error adding marital status: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function

    Private Function IsValueUnique(value As String, tableName As String, columnName As String) As Boolean

        Dim sql As String = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @{columnName}"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter($"@{columnName}", value)
    }

        Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))


        Return count = 0
    End Function



    Private Sub MaritalStatusDelete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaritalStatusDelete.SelectedIndexChanged
        Try
            If MaritalStatusDelete.SelectedIndices.Count > 0 Then
                Dim selectedIndex As Integer = MaritalStatusDelete.SelectedIndices(0)
                txtDELMaritalStatus.Text = MaritalStatusDelete.Items(selectedIndex).ToString()
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling marital status selection: {ex.Message}")
        End Try
    End Sub

    Private Sub btnDeleteMaritalStatus_Click(sender As Object, e As EventArgs) Handles btnDeleteMaritalStatus.Click
        Try
            Dim selectedMaritalStatus As String = txtDELMaritalStatus.Text

            If Not String.IsNullOrEmpty(selectedMaritalStatus) Then
                Dim confirmationResult As DialogResult = MessageBox.Show($"Are you sure you want to delete marital status '{selectedMaritalStatus}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmationResult = DialogResult.Yes Then
                    Dim deletionResult As String = DeleteMaritalStatus(selectedMaritalStatus)

                    MessageBox.Show(deletionResult, "Deletion Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    DisplayAllMaritalStatuses()

                    txtDELMaritalStatus.Text = "MARITAL"
                End If
            Else
                MessageBox.Show("Please select a marital status to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error deleting marital status: {ex.Message}")
        End Try
    End Sub

    Private Function DeleteMaritalStatus(maritalStatus As String) As String
        Try
            If Not IsMaritalStatusExists(maritalStatus, "maritalstatus") Then
                Return "Marital status does not exist."
            End If

            Dim sql As String = "DELETE FROM maritalstatus WHERE MaritalStatusName = @MaritalStatusName"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@MaritalStatusName", maritalStatus)
            }

            ExecuteNonQuery(sql, parameters)

            Return "Marital status deleted successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error deleting marital status: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function

    Private Function IsMaritalStatusExists(maritalStatus As String, tableName As String) As Boolean
        Try
            Dim sql As String = $"SELECT COUNT(*) FROM {tableName} WHERE MaritalStatusName = @MaritalStatusName"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@MaritalStatusName", maritalStatus)
            }

            Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))

            Return count > 0
        Catch ex As Exception
            Console.WriteLine($"Error checking if marital status exists: {ex.Message}")
            Return False
        End Try
    End Function

End Class