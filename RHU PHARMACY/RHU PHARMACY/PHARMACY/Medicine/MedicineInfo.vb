Imports MySql.Data.MySqlClient
Public Class MedicineInfo
    Private Sub MedicineInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function SearchMedicineByName(ByVal medicineName As String) As DataTable
        Dim searchResultTable As New DataTable()

        Try
            ' Construct the SQL query to search for medicine by name
            Dim sql As String = "SELECT MedicineID, MedicineName, Dosage, StockQuantity, Category FROM medicine WHERE MedicineName LIKE @MedicineName"

            ' Add a wildcard to search for partial matches
            Dim searchName As String = "%" & medicineName & "%"

            ' Execute the query with parameters
            Dim parameters As New List(Of MySqlParameter)()
            parameters.Add(New MySqlParameter("@MedicineName", searchName))

            searchResultTable = ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error searching for medicine by name: {ex.Message}")
        End Try

        Return searchResultTable
    End Function

    Private Sub btnSearchMedicine_Click(sender As Object, e As EventArgs) Handles btnSearchMedicine.Click
        Dim searchName As String = txtSearchMedicine.Text.Trim()

        If Not String.IsNullOrEmpty(searchName) Then
            DataGridViewSearchResults.Rows.Clear()

            Dim searchResultTable As DataTable = SearchMedicineByName(searchName)

            ' Check if search results are not empty
            If searchResultTable IsNot Nothing AndAlso searchResultTable.Rows.Count > 0 Then
                ' Iterate through each row in the search results and fill DataGridView
                For Each row As DataRow In searchResultTable.Rows
                    ' Add a new row to DataGridView and set cell values
                    Dim rowIndex As Integer = DataGridViewSearchResults.Rows.Add()
                    DataGridViewSearchResults.Rows(rowIndex).Cells("MedicineID").Value = row("MedicineID")
                    DataGridViewSearchResults.Rows(rowIndex).Cells("MedicineName").Value = row("MedicineName")
                    DataGridViewSearchResults.Rows(rowIndex).Cells("Dosage").Value = row("Dosage")
                    DataGridViewSearchResults.Rows(rowIndex).Cells("StockQuantity").Value = row("StockQuantity")
                    DataGridViewSearchResults.Rows(rowIndex).Cells("Category").Value = row("Category")
                Next
            Else
                MessageBox.Show("No medicine found with the given name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please enter a medicine name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub RefreshDataGridView()
        ' Clear existing rows in DataGridView
        DataGridViewSearchResults.Rows.Clear()

        ' Rebind the search results data to DataGridView
        Dim searchName As String = txtSearchMedicine.Text.Trim()

        If Not String.IsNullOrEmpty(searchName) Then
            Dim searchResultTable As DataTable = SearchMedicineByName(searchName)

            ' Check if search results are not empty
            If searchResultTable IsNot Nothing AndAlso searchResultTable.Rows.Count > 0 Then
                ' Iterate through each row in the search results and fill DataGridView
                For Each row As DataRow In searchResultTable.Rows
                    ' Add a new row to DataGridView and set cell values
                    Dim rowIndex As Integer = DataGridViewSearchResults.Rows.Add()
                    DataGridViewSearchResults.Rows(rowIndex).Cells("MedicineID").Value = row("MedicineID")
                    DataGridViewSearchResults.Rows(rowIndex).Cells("MedicineName").Value = row("MedicineName")
                    DataGridViewSearchResults.Rows(rowIndex).Cells("Dosage").Value = row("Dosage")
                    DataGridViewSearchResults.Rows(rowIndex).Cells("StockQuantity").Value = row("StockQuantity")
                    DataGridViewSearchResults.Rows(rowIndex).Cells("Category").Value = row("Category")
                Next
            Else
                MessageBox.Show("No medicine found with the given name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please enter a medicine name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub DataGridViewSearchResults_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSearchResults.CellDoubleClick
        ' Check if the double-clicked cell is within the data grid range
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso e.RowIndex < DataGridViewSearchResults.Rows.Count AndAlso e.ColumnIndex < DataGridViewSearchResults.Columns.Count Then
            ' Get the cell value
            Dim cellValue As String = DataGridViewSearchResults.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

            ' Get the column name
            Dim columnName As String = DataGridViewSearchResults.Columns(e.ColumnIndex).Name

            ' Show an input box to edit the cell value
            Dim newValue As String = InputBox("Enter new value:", "Edit Cell", cellValue)

            ' Update the cell value if the user entered a new value
            If Not String.IsNullOrEmpty(newValue) AndAlso newValue <> cellValue Then
                ' Update the cell value in the DataGridView
                DataGridViewSearchResults.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = newValue

                ' Update the cell value in the database
                UpdateCellValueInDatabase(newValue, columnName, e.RowIndex)

                ' Refresh the DataGridView to reflect the changes
                RefreshDataGridView()
            End If
        End If
    End Sub



    Private Sub UpdateCellValueInDatabase(ByVal newValue As String, ByVal columnName As String, ByVal rowIndex As Integer)
        Try
            Dim columnNameNormalized As String = columnName.Trim().ToLower()

            ' Exclude updating the primary key (ID) column
            If columnNameNormalized = "medicinename" OrElse columnNameNormalized = "dosage" OrElse columnNameNormalized = "stockquantity" OrElse columnNameNormalized = "category" Then
                Dim medicineID As Integer = Convert.ToInt32(DataGridViewSearchResults.Rows(rowIndex).Cells("MedicineID").Value)

                ' Construct the SQL update query dynamically based on the column name
                Dim sql As String = $"UPDATE medicine SET {columnName} = @NewValue WHERE MedicineID = @MedicineID"

                ' Create parameters for the query
                Dim parameters As New List(Of MySqlParameter)()
                parameters.Add(New MySqlParameter("@NewValue", newValue))
                parameters.Add(New MySqlParameter("@MedicineID", medicineID))

                ' Execute the update query
                ExecuteNonQuery(sql, parameters)

                ' Optionally, update the DataGridView directly here if needed
                DataGridViewSearchResults.Rows(rowIndex).Cells(columnName).Value = newValue

                MessageBox.Show("Cell value updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Cannot update the primary key (ID) column.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating cell value: " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class