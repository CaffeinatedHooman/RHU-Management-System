Imports MySql.Data.MySqlClient
Public Class NEW_LABARATORY

    Private Sub PopulateLaboratoryListBox()
        ListBoxLABARATORY.Items.Clear()

        Dim laboratoriesTable As DataTable = GetAllLaboratories()

        If laboratoriesTable IsNot Nothing AndAlso laboratoriesTable.Rows.Count > 0 Then
            For Each row As DataRow In laboratoriesTable.Rows
                Dim laboratoryName As String = row("LaboratoryName").ToString()
                ListBoxLABARATORY.Items.Add(laboratoryName)
            Next
        Else
            ListBoxLABARATORY.Items.Add("No laboratories found.")
        End If
    End Sub




    Private Sub btnAddLaboratory_Click(sender As Object, e As EventArgs) Handles btnAddLaboratory.Click
        Try
            ' Retrieve input values from the text boxes
            Dim laboratoryName As String = txtLaboratoryName.Text.Trim()
            Dim accessCode As String = txtLaboratoryAccessCode.Text.Trim()

            ' Validate input
            If String.IsNullOrEmpty(laboratoryName) Then
                MessageBox.Show("Please enter a laboratory name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If String.IsNullOrEmpty(accessCode) Then
                MessageBox.Show("Please enter an access code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check if access code is unique
            If Not IsLaboratoryAccessCodeUnique(accessCode) Then
                MessageBox.Show("Access code must be unique.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Add laboratory
            Dim resultMessage As String = AddLaboratory(laboratoryName, accessCode)
            MessageBox.Show(resultMessage, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtLaboratoryName.Clear()
            txtLaboratoryAccessCode.Clear()

            PopulateLaboratoryListBox()

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub NEW_LABARATORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateLaboratoryListBox()
    End Sub
End Class