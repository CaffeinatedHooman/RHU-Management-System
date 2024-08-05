Imports System.Text.RegularExpressions
Public Class NewMedicine
    Private Sub btnAddMedicine_Click(sender As Object, e As EventArgs) Handles btnAddMedicine.Click
        Dim medicineName As String = txtMedicineName.Text.Trim()
        Dim dosage As String = txtDosage.Text.Trim()
        Dim stockQuantity As Integer
        If Integer.TryParse(txtStockQuantity.Text.Trim(), stockQuantity) Then
            Dim category As String = txtCategory.Text()

            Dim addedSuccessfully As Boolean = AddMedicine(medicineName, dosage, stockQuantity, category)

            If addedSuccessfully Then
                MessageBox.Show("Medicine added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
            Else
                'MessageBox.Show("Error adding medicine. Please check the input values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid stock quantity. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub txtInputNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDosage.KeyPress, txtStockQuantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMedicineName.KeyPress, txtCategory.KeyPress
        Dim regexPattern As String = "^[a-zA-Z\s]+$"
        If Not Regex.IsMatch(e.KeyChar.ToString(), regexPattern) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearFields()
        txtMedicineName.Clear()
        txtDosage.Clear()
        txtStockQuantity.Clear()
        txtCategory.Clear()
    End Sub

    Private Sub NewMedicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class