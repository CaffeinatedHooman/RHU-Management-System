Imports MySql.Data.MySqlClient
Public Class INVENTORY
    Private Sub INVENTORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMedicinesIntoDataGridView()
    End Sub
    Private Sub LoadMedicinesIntoDataGridView()
        Try
            Dim medicinesTable As DataTable = GetAllMedicines()

            If medicinesTable IsNot Nothing AndAlso medicinesTable.Rows.Count > 0 Then
                Dim zeroStockRows = medicinesTable.AsEnumerable().Where(Function(row) row.Field(Of Integer)("StockQuantity") = 0)
                If zeroStockRows.Any() Then
                    Dim zeroStockMedicines = zeroStockRows.CopyToDataTable()
                    MedicineOutView.DataSource = zeroStockMedicines
                Else
                    MedicineOutView.DataSource = Nothing
                End If

                Dim nonZeroStockMedicines = medicinesTable.AsEnumerable().Where(Function(row) row.Field(Of Integer)("StockQuantity") > 0).CopyToDataTable()
                MedicineInStockView.DataSource = nonZeroStockMedicines
            Else
                MedicineOutView.DataSource = Nothing
                MedicineInStockView.DataSource = Nothing
                MessageBox.Show("No medicines found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading medicines into DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RestockMedicine(medicineName As String, currentStockQuantity As Integer, restockQuantity As Integer)
        Try
            ' Update the stock quantity of the selected medicine by the restock quantity
            Dim sql As String = "UPDATE Medicine SET StockQuantity = StockQuantity + @RestockQuantity WHERE MedicineName = @MedicineName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@RestockQuantity", restockQuantity),
            New MySqlParameter("@MedicineName", medicineName)
        }
            ExecuteNonQuery(sql, parameters)

            ' Calculate the new stock quantity after restocking
            Dim newStockQuantity As Integer = currentStockQuantity + restockQuantity

            ' Update the DataGridView to reflect the new stock quantity
            Dim rowToUpdate As DataGridViewRow = MedicineOutView.Rows _
            .Cast(Of DataGridViewRow)() _
            .FirstOrDefault(Function(row) row.Cells("MedicineName").Value.ToString() = medicineName)

            If rowToUpdate IsNot Nothing Then
                rowToUpdate.Cells("StockQuantity").Value = newStockQuantity
            End If

            MessageBox.Show($"Successfully restocked {restockQuantity} units of {medicineName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadMedicinesIntoDataGridView()
        Catch ex As Exception
            MessageBox.Show($"Error restocking medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadMedicineOutView()
        Try
            Dim sql As String = "SELECT MedicineName, Dosage, StockQuantity, Category FROM Medicine"
            Dim medicineTable As DataTable = ExecuteQuery(sql)

            If medicineTable IsNot Nothing Then
                MedicineOutView.DataSource = medicineTable
            Else
                MessageBox.Show("No data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading medicine data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MedicineOutView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MedicineOutView.CellDoubleClick
        ' Check if the double-clicked cell is valid (not a header cell and within range)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso e.RowIndex < MedicineOutView.Rows.Count Then
            ' Get the selected row and extract necessary information
            Dim selectedRow = MedicineOutView.Rows(e.RowIndex)
            Dim medicineName As String = selectedRow.Cells("MedicineName").Value.ToString()
            Dim currentStockQuantity As Integer = Convert.ToInt32(selectedRow.Cells("StockQuantity").Value)

            ' Ask the user for restock quantity
            Dim restockInput As String = InputBox("Enter the quantity to restock for " & medicineName & ":", "Restock Medicine", "0")
            Dim restockQuantity As Integer
            If Integer.TryParse(restockInput, restockQuantity) Then
                ' Perform restocking (you will implement this part)
                RestockMedicine(medicineName, currentStockQuantity, restockQuantity)
            Else
                MessageBox.Show("Invalid restock quantity. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub MedicineInStockView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MedicineInStockView.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso e.RowIndex < MedicineInStockView.Rows.Count Then
            Dim selectedRow = MedicineInStockView.Rows(e.RowIndex)
            Dim medicineID As Integer = Convert.ToInt32(selectedRow.Cells("MedicineID").Value)
            Dim medicineName As String = selectedRow.Cells("MedicineName").Value.ToString()
            Dim currentStockQuantity As Integer = Convert.ToInt32(selectedRow.Cells("StockQuantity").Value)


            Dim restockInput As String = InputBox("Enter the quantity to restock for " & medicineName & ":", "Restock Medicine", "0")
            Dim restockQuantity As Integer
            If Integer.TryParse(restockInput, restockQuantity) AndAlso restockQuantity > 0 Then
                Dim newStockQuantity As Integer = currentStockQuantity + restockQuantity

                Try
                    UpdateStockQuantityInDatabase(medicineID, newStockQuantity)

                    LoadMedicinesIntoDataGridView()

                    MessageBox.Show($"{restockQuantity} units of {medicineName} successfully restocked. New stock quantity: {newStockQuantity}", "Restock Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"Error restocking {medicineName}: {ex.Message}", "Restock Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Invalid restock quantity. Please enter a valid number greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Private Sub UpdateStockQuantityInDatabase(medicineID As Integer, newStockQuantity As Integer)
        Dim sql As String = "UPDATE Medicine SET StockQuantity = @NewStockQuantity WHERE MedicineID = @MedicineID"
        Dim parameters As New List(Of MySqlParameter)()
        parameters.Add(New MySqlParameter("@NewStockQuantity", newStockQuantity))
        parameters.Add(New MySqlParameter("@MedicineID", medicineID))

        Try
            ExecuteNonQuery(sql, parameters)
            MessageBox.Show("Stock quantity updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Error updating stock quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub NewMedsVTN_Click(sender As Object, e As EventArgs) Handles NewMedsVTN.Click
        NewMedicine.Show()
    End Sub

    Private Sub Guna2ImageButton3_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton3.Click
        MedicineInfo.Show()
    End Sub
End Class