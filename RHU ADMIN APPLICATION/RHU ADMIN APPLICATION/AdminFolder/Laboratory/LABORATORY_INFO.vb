Imports MySql.Data.MySqlClient
Public Class LABORATORY_INFO
    Private Sub LABARATORY_INFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAllLaboratories()
    End Sub
    Private Sub DisplayAllLaboratories()
        Try
            Dim dataTable As DataTable = GetAllLaboratories()
            LaboratoryListBoxUpdate.Items.Clear()
            LaboratoryListDelete.Items.Clear()

            If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
                For Each row As DataRow In dataTable.Rows
                    Dim laboratoryName As String = row("LaboratoryName").ToString()
                    Dim accessCode As String = row("AccessCode").ToString()

                    LaboratoryListBoxUpdate.Items.Add(laboratoryName)
                    LaboratoryListDelete.Items.Add(laboratoryName)
                Next
            End If
        Catch ex As Exception
            Console.WriteLine($"Error displaying all laboratories: {ex.Message}")
            MessageBox.Show("An error occurred while retrieving laboratory data. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdateLaboratory_Click(sender As Object, e As EventArgs) Handles btnUpdateLaboratory.Click
        Try
            If LaboratoryListBoxUpdate.SelectedIndex <> -1 Then
                Dim oldLaboratoryName As String = LaboratoryListBoxUpdate.SelectedItem.ToString()
                Dim newLaboratoryName As String = txtNewLaboratoryName.Text
                Dim newAccessCode As String = txtNewAccessCode.Text

                If String.IsNullOrEmpty(newLaboratoryName) Or String.IsNullOrEmpty(newAccessCode) Then
                    MessageBox.Show("Please enter both laboratory name and access code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim confirmationResult As DialogResult = MessageBox.Show($"Are you sure you want to update laboratory '{oldLaboratoryName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmationResult = DialogResult.Yes Then
                    Dim resultMessage As String = UpdateLaboratory(oldLaboratoryName, newLaboratoryName, newAccessCode)
                    MessageBox.Show(resultMessage, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    DisplayAllLaboratories()

                    txtNewLaboratoryName.Clear()
                    txtNewAccessCode.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub LaboratoryListBoxUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LaboratoryListBoxUpdate.SelectedIndexChanged
        Try
            If LaboratoryListBoxUpdate.SelectedIndices.Count > 0 Then
                Dim selectedIndex As Integer = LaboratoryListBoxUpdate.SelectedIndices(0)
                txtOldLaboratoryName.Text = LaboratoryListBoxUpdate.Items(selectedIndex).ToString()

                Dim oldAccessCode As String = GetLaboratoryAccessCode(txtOldLaboratoryName.Text)
                lblOldAccessCode.Text = oldAccessCode
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling laboratory selection: {ex.Message}")
        End Try
    End Sub

    Private Sub LaboratoryListDelete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LaboratoryListDelete.SelectedIndexChanged
        Try
            If LaboratoryListDelete.SelectedIndices.Count > 0 Then
                Dim selectedIndex As Integer = LaboratoryListDelete.SelectedIndices(0)
                Dim selectedLaboratoryName As String = LaboratoryListDelete.Items(selectedIndex).ToString()

                lblDeleteLaboratoryName.Text = $"Laboratory Name: {selectedLaboratoryName}"
                lblDeleteAccessCode.Text = $"Access Code: {GetLaboratoryAccessCode(selectedLaboratoryName)}"
            End If
        Catch ex As Exception
            Console.WriteLine($"Error handling laboratory selection for deletion: {ex.Message}")
        End Try
    End Sub

    Private Sub btnDeleteLaboratory_Click(sender As Object, e As EventArgs) Handles btnDeleteLaboratory.Click
        Try
            Dim selectedLaboratoryName As String = lblDeleteLaboratoryName.Text.Replace("Laboratory Name: ", "")

            If Not String.IsNullOrEmpty(selectedLaboratoryName) Then
                Dim confirmationResult As DialogResult = MessageBox.Show($"Are you sure you want to delete laboratory '{selectedLaboratoryName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmationResult = DialogResult.Yes Then
                    Dim deletionResult As String = DeleteLaboratory(selectedLaboratoryName)
                    MessageBox.Show(deletionResult, "Deletion Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    DisplayAllLaboratories()

                    lblDeleteLaboratoryName.Text = "Laboratory Name:"
                    lblDeleteAccessCode.Text = "Access Code:"
                End If
            Else
                MessageBox.Show("Please select a laboratory to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error deleting laboratory: {ex.Message}")
        End Try
    End Sub



End Class