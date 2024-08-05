Imports MySql.Data.MySqlClient
Public Class NursePosition
    Private Sub NursePosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAllNurseSpecializations()
    End Sub


    Private Sub btnAddNurseSpecialization_Click(sender As Object, e As EventArgs) Handles btnAddNurseSpecialization.Click
        Try

            Dim specialization As String = txtNurseSpecialization.Text.Trim()

            If String.IsNullOrEmpty(specialization) Then
                MessageBox.Show("Please enter a nurse specialization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim result As String = AddNurseSpecialization(specialization)
            MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtNurseSpecialization.Clear()
            DisplayAllNurseSpecializations()

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateNurseSpecialization_Click(sender As Object, e As EventArgs) Handles btnUpdateNurseSpecialization.Click
        Try
            Dim oldSpecialization As String = txtOldNurseSpecialization.Text.Trim()
            Dim newSpecialization As String = txtNewNurseSpecialization.Text.Trim()

            If String.IsNullOrEmpty(oldSpecialization) OrElse String.IsNullOrEmpty(newSpecialization) Then
                MessageBox.Show("Please enter both old and new nurse specialization names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim confirmationResult As DialogResult = MessageBox.Show($"Are you sure you want to update nurse specialization '{oldSpecialization}' to '{newSpecialization}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmationResult = DialogResult.Yes Then
                Dim result As String = UpdateNurseSpecialization(oldSpecialization, newSpecialization)
                MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

                DisplayAllNurseSpecializations()

                txtOldNurseSpecialization.Text = "NurseSpecialization"
                txtNewNurseSpecialization.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NurseSpecializationListBoxUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NurseSpecializationListBoxUpdate.SelectedIndexChanged
        Try
            If NurseSpecializationListBoxUpdate.SelectedIndices.Count > 0 Then
                Dim selectedIndex As Integer = NurseSpecializationListBoxUpdate.SelectedIndices(0)
                txtOldNurseSpecialization.Text = NurseSpecializationListBoxUpdate.Items(selectedIndex).ToString()
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling nurse specialization selection: {ex.Message}")
        End Try
    End Sub

    Private Sub NurseSpecializationDelete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NurseSpecializationDelete.SelectedIndexChanged
        Try
            If NurseSpecializationDelete.SelectedIndices.Count > 0 Then
                Dim selectedIndex As Integer = NurseSpecializationDelete.SelectedIndices(0)
                txtDELNurseSpecialization.Text = NurseSpecializationDelete.Items(selectedIndex).ToString()
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling nurse specialization selection: {ex.Message}")
        End Try
    End Sub

    Private Sub btnDeleteNurseSpecialization_Click(sender As Object, e As EventArgs) Handles btnDeleteNurseSpecialization.Click
        Try
            Dim selectedSpecialization As String = txtDELNurseSpecialization.Text

            If Not String.IsNullOrEmpty(selectedSpecialization) Then
                Dim confirmationResult As DialogResult = MessageBox.Show($"Are you sure you want to delete specialization '{selectedSpecialization}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmationResult = DialogResult.Yes Then
                    Dim deletionResult As String = DeleteNurseSpecialization(selectedSpecialization)

                    MessageBox.Show(deletionResult, "Deletion Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    DisplayAllNurseSpecializations()

                    txtDELNurseSpecialization.Text = "POSITION"
                End If
            Else
                MessageBox.Show("Please select a specialization to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error deleting nurse specialization: {ex.Message}")
        End Try
    End Sub


    Private Sub DisplayAllNurseSpecializations()
        Try
            ListBoxNurseSpecializations.Items.Clear()
            NurseSpecializationListBoxUpdate.Items.Clear()
            NurseSpecializationDelete.Items.Clear()
            Dim nurseSpecializationsTable As DataTable = GetAllNurseSpecializations()

            If nurseSpecializationsTable IsNot Nothing AndAlso nurseSpecializationsTable.Rows.Count > 0 Then
                For Each row As DataRow In nurseSpecializationsTable.Rows
                    ListBoxNurseSpecializations.Items.Add(row("Specialization").ToString())
                    NurseSpecializationListBoxUpdate.Items.Add(row("Specialization").ToString())
                    NurseSpecializationDelete.Items.Add(row("Specialization").ToString())
                Next
            Else
                ListBoxNurseSpecializations.Items.Add("No Nurse Specializations found.")
                NurseSpecializationListBoxUpdate.Items.Add("No Nurse Specializations found.")
                NurseSpecializationDelete.Items.Add("No Nurse Specializations found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error displaying all nurse specializations: {ex.Message}")
        End Try
    End Sub
    Private Function AddNurseSpecialization(specialization As String) As String
        Try
            If Not IsSpecializationUnique(specialization, "NurseSpecializations") Then
                Return "Nurse specialization already exists."
            End If

            Dim sql As String = "INSERT INTO NurseSpecializations (Specialization) VALUES (@Specialization)"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Specialization", specialization)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Nurse specialization added successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error adding nurse specialization: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function

    Private Function IsSpecializationUnique(specialization As String, tableName As String) As Boolean

        Dim sql As String = $"SELECT COUNT(*) FROM {tableName} WHERE Specialization = @Specialization"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@Specialization", specialization)
    }

        Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))


        Return count = 0
    End Function



    Private Function UpdateNurseSpecialization(oldSpecialization As String, newSpecialization As String) As String
        Try
            Dim sql As String = "UPDATE NurseSpecializations SET Specialization = @NewSpecialization WHERE Specialization = @OldSpecialization"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@NewSpecialization", newSpecialization),
            New MySqlParameter("@OldSpecialization", oldSpecialization)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Nurse specialization updated successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error updating nurse specialization: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function
    Private Function DeleteNurseSpecialization(specialization As String) As String
        Try
            If Not IsSpecializationExists(specialization, "NurseSpecializations") Then
                Return "Nurse specialization does not exist."
            End If

            Dim sql As String = "DELETE FROM NurseSpecializations WHERE Specialization = @Specialization"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Specialization", specialization)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Nurse specialization deleted successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error deleting nurse specialization: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function

    Private Function IsSpecializationExists(specialization As String, tableName As String) As Boolean
        Try
            Dim sql As String = $"SELECT COUNT(*) FROM {tableName} WHERE Specialization = @Specialization"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Specialization", specialization)
        }

            Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))

            Return count > 0
        Catch ex As Exception
            Console.WriteLine($"Error checking if specialization exists: {ex.Message}")
            Return False
        End Try
    End Function




End Class