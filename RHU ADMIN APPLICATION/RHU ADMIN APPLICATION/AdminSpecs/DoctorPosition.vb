Imports MySql.Data.MySqlClient
Public Class DoctorPosition
    Private Sub DoctorPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAllDoctorSpecializations()
    End Sub

    Private Sub btnAddDoctorSpecialization_Click(sender As Object, e As EventArgs) Handles btnAddDoctorSpecialization.Click
        Try

            Dim specialization As String = txtDoctorSpecialization.Text.Trim()

            If String.IsNullOrEmpty(specialization) Then
                MessageBox.Show("Please enter a doctor specialization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim result As String = AddDoctorSpecialization(specialization)
            MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtDoctorSpecialization.Clear()
            DisplayAllDoctorSpecializations()

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnUpdateDoctorSpecialization_Click(sender As Object, e As EventArgs) Handles btnUpdateDoctorSpecialization.Click
        Try
            Dim oldSpecialization As String = txtOldDoctorSpecialization.Text.Trim()
            Dim newSpecialization As String = txtNewDoctorSpecialization.Text.Trim()

            If String.IsNullOrEmpty(oldSpecialization) OrElse String.IsNullOrEmpty(newSpecialization) Then
                MessageBox.Show("Please enter both old and new doctor specialization names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim confirmationResult As DialogResult = MessageBox.Show($"Are you sure you want to update doctor specialization '{oldSpecialization}' to '{newSpecialization}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If confirmationResult = DialogResult.Yes Then
                Dim result As String = UpdateDoctorSpecialization(oldSpecialization, newSpecialization)
                MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

                DisplayAllDoctorSpecializations()

                txtOldDoctorSpecialization.Text = "POSITION"
                txtNewDoctorSpecialization.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DoctorSpecializationListBoxUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DoctorSpecializationListBoxUpdate.SelectedIndexChanged
        Try
            If DoctorSpecializationListBoxUpdate.SelectedIndices.Count > 0 Then
                Dim selectedIndex As Integer = DoctorSpecializationListBoxUpdate.SelectedIndices(0)
                txtOldDoctorSpecialization.Text = DoctorSpecializationListBoxUpdate.Items(selectedIndex).ToString()
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling doctor specialization selection: {ex.Message}")
        End Try
    End Sub

    Private Sub DeleteDoctorSpecialization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeleteDoctorSpecialization.SelectedIndexChanged
        Try
            If DeleteDoctorSpecialization.SelectedIndices.Count > 0 Then
                Dim selectedIndex As Integer = DeleteDoctorSpecialization.SelectedIndices(0)
                txtDELDoctorSpecialization.Text = DeleteDoctorSpecialization.Items(selectedIndex).ToString()
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling doctor specialization selection: {ex.Message}")
        End Try
    End Sub

    Private Sub btnDeleteDoctorSpecialization_Click(sender As Object, e As EventArgs) Handles btnDeleteDoctorSpecialization.Click
        Try
            Dim selectedSpecialization As String = txtDELDoctorSpecialization.Text

            If Not String.IsNullOrEmpty(selectedSpecialization) Then
                Dim confirmationResult As DialogResult = MessageBox.Show($"Are you sure you want to delete specialization '{selectedSpecialization}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmationResult = DialogResult.Yes Then
                    Dim deletionResult As String = DelDoctorSpecialization(selectedSpecialization)

                    MessageBox.Show(deletionResult, "Deletion Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    DisplayAllDoctorSpecializations()

                    txtDELDoctorSpecialization.Text = "POSITION"
                End If
            Else
                MessageBox.Show("Please select a specialization to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error deleting doctor specialization: {ex.Message}")
        End Try
    End Sub

    Public Function AddDoctorSpecialization(specialization As String) As String
        Try
            If Not IsSpecializationUnique(specialization, "DoctorSpecializations") Then
                Return "Doctor specialization already exists."
            End If

            Dim sql As String = "INSERT INTO DoctorSpecializations (Specialization) VALUES (@Specialization)"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Specialization", specialization)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Doctor specialization added successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error adding doctor specialization: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function
    Private Sub DisplayAllDoctorSpecializations()
        Try
            ListBoxDoctorSpecializations.Items.Clear()
            DoctorSpecializationListBoxUpdate.Items.Clear()
            DeleteDoctorSpecialization.Items.Clear()
            Dim doctorSpecializationsTable As DataTable = GetAllDoctorSpecializations()

            If doctorSpecializationsTable IsNot Nothing AndAlso doctorSpecializationsTable.Rows.Count > 0 Then
                For Each row As DataRow In doctorSpecializationsTable.Rows
                    ListBoxDoctorSpecializations.Items.Add(row("Specialization").ToString())
                    DoctorSpecializationListBoxUpdate.Items.Add(row("Specialization").ToString())
                    DeleteDoctorSpecialization.Items.Add(row("Specialization").ToString())
                Next
            Else
                ListBoxDoctorSpecializations.Items.Add("No Doctor Specializations found.")
                DoctorSpecializationListBoxUpdate.Items.Add("No Doctor Specializations found.")
                DeleteDoctorSpecialization.Items.Add("No Doctor Specializations found.")
            End If
        Catch ex As Exception
            Console.WriteLine($"Error displaying all doctor specializations: {ex.Message}")
        End Try
    End Sub



    Private Function IsSpecializationUnique(specialization As String, tableName As String) As Boolean

        Dim sql As String = $"SELECT COUNT(*) FROM {tableName} WHERE Specialization = @Specialization"
        Dim parameters As New List(Of MySqlParameter) From {
        New MySqlParameter("@Specialization", specialization)
    }

        Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))


        Return count = 0
    End Function

    Public Function UpdateDoctorSpecialization(oldSpecialization As String, newSpecialization As String) As String
        Try
            Dim sql As String = "UPDATE DoctorSpecializations SET Specialization = @NewSpecialization WHERE Specialization = @OldSpecialization"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@NewSpecialization", newSpecialization),
            New MySqlParameter("@OldSpecialization", oldSpecialization)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Doctor specialization updated successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error updating doctor specialization: {ex.Message}")
            Return $"An error occurred: {ex.Message}"
        End Try
    End Function
    Private Function DelDoctorSpecialization(specialization As String) As String
        Try
            If Not IsSpecializationExists(specialization, "DoctorSpecializations") Then
                Return "Doctor specialization does not exist."
            End If

            Dim sql As String = "DELETE FROM DoctorSpecializations WHERE Specialization = @Specialization"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Specialization", specialization)
        }

            ExecuteNonQuery(sql, parameters)

            Return "Doctor specialization deleted successfully!"
        Catch ex As Exception
            Console.WriteLine($"Error deleting doctor specialization: {ex.Message}")
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