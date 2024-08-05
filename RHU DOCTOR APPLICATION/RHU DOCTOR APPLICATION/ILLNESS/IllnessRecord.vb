Imports MySql.Data.MySqlClient
Public Class IllnessRecord
    Private Sub IllnessRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayIllnesses()
        DisplayIllnessesBox()
    End Sub
    Public Function GetAllIllnesses() As DataTable
        Try
            Dim sql As String = "SELECT IllnessName FROM illnesses"
            Return ExecuteQuery(sql, Nothing)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving illness names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Private Sub DisplayIllnessesBox()
        Try

            Dim illnessesTable As DataTable = GetAllIllnesses()

            If illnessesTable IsNot Nothing AndAlso illnessesTable.Rows.Count > 0 Then
                DataGridView1.DataSource = illnessesTable

                LIstIllnessBox.Items.Clear()
                For Each row As DataRow In illnessesTable.Rows
                    LIstIllnessBox.Items.Add(row("IllnessName").ToString())
                Next
            Else
                MessageBox.Show("No illness names found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error displaying illness names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAddIllness_Click(sender As Object, e As EventArgs) Handles btnAddIllness.Click
        Try
            Dim newIllnessName As String = txtNewIllness.Text.Trim()

            If String.IsNullOrEmpty(newIllnessName) Then
                MessageBox.Show("Please enter a valid illness name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If Not CheckIllnessNameUnique(newIllnessName) Then
                MessageBox.Show("Illness name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If AddIllnessName(newIllnessName) Then
                MessageBox.Show("New illness name added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNewIllness.Clear()
                DisplayIllnessesBox()
            Else
                MessageBox.Show("Failed to add new illness name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error adding new illness name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Function AddIllnessName(illnessName As String) As Boolean
        Try
            If Not CheckIllnessNameUnique(illnessName) Then
                MessageBox.Show("Illness name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            Dim sql As String = "INSERT INTO illnesses (IllnessName) VALUES (@IllnessName)"

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@IllnessName", illnessName)
            }

            Dim rowsAffected As Integer = ExecuteNonQuery(sql, parameters)

            Return rowsAffected > 0
        Catch ex As Exception
            MessageBox.Show($"Error inserting illness name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function CheckIllnessNameUnique(illnessName As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM illnesses WHERE IllnessName = @IllnessName"
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@IllnessName", illnessName)
            }

            Dim count As Integer = Convert.ToInt32(ExecuteScalar(sql, parameters))

            ' If count is 0, the illness name is unique
            Return count = 0
        Catch ex As Exception
            MessageBox.Show($"Error checking uniqueness of illness name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Private Sub DisplayIllnesses()
        Try
            ' Call the GetAllIllnesses function to retrieve the illness names
            Dim illnessesTable As DataTable = GetAllIllnesses()

            If illnessesTable IsNot Nothing AndAlso illnessesTable.Rows.Count > 0 Then
                ' Bind the DataTable to the DataGridView
                DataGridView1.DataSource = illnessesTable
            Else
                MessageBox.Show("No illness names found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error displaying illness names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class