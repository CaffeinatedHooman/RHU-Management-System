Imports MySql.Data.MySqlClient
Module MedicineModule
    Public Function AddMedicine(medicineName As String, dosage As String, stockQuantity As Integer, category As String) As Boolean
        Try
            If Not IsMedicineDosageUnique(medicineName, dosage) Then
                MessageBox.Show("Medicine with this dosage already exists. Please enter a unique combination of medicine name and dosage.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            Dim sql As String = "INSERT INTO Medicine (MedicineName, Dosage, StockQuantity, Category) VALUES (@MedicineName, @Dosage, @StockQuantity, @Category)"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@MedicineName", medicineName),
            New MySqlParameter("@Dosage", dosage),
            New MySqlParameter("@StockQuantity", stockQuantity),
            New MySqlParameter("@Category", category)
        }
            ExecuteNonQuery(sql, parameters)
            Return True
        Catch ex As Exception
            MessageBox.Show($"Error adding medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function IsMedicineDosageUnique(medicineName As String, dosage As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Medicine WHERE MedicineName = @MedicineName AND Dosage = @Dosage"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@MedicineName", medicineName),
            New MySqlParameter("@Dosage", dosage)
        }
            Dim result As Object = ExecuteScalar(sql, parameters)
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Dim count As Integer = Convert.ToInt32(result)
                Return count = 0
            End If
        Catch ex As Exception
            MessageBox.Show($"Error checking medicine dosage uniqueness: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function


    Public Function SearchMedicineByName(medicineName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Medicine WHERE MedicineName = @MedicineName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@MedicineName", medicineName)
        }
            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function UpdateMedicineStock(medicineID As Integer, newStockQuantity As Integer) As Boolean
        Try
            Dim sql As String = "UPDATE Medicine SET StockQuantity = @NewStockQuantity WHERE MedicineID = @MedicineID"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@NewStockQuantity", newStockQuantity),
            New MySqlParameter("@MedicineID", medicineID)
        }
            ExecuteNonQuery(sql, parameters)
            Return True
        Catch ex As Exception
            MessageBox.Show($"Error updating medicine stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function SearchMedicineByCategory(category As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Medicine WHERE Category = @Category"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Category", category)
        }
            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for medicine by category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function IsMedicineNameUnique(medicineName As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Medicine WHERE MedicineName = @MedicineName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@MedicineName", medicineName)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Dim count As Integer = Convert.ToInt32(result)
                Return count = 0
            End If
        Catch ex As Exception
            MessageBox.Show($"Error checking medicine name uniqueness: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Public Function AddCategory(categoryName As String) As Boolean
        Try

            If Not IsCategoryUnique(categoryName) Then
                MessageBox.Show("Category already exists. Please enter a unique category name.", "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            Dim sql As String = "INSERT INTO Categories (CategoryName) VALUES (@CategoryName)"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@CategoryName", categoryName)
        }

            ExecuteNonQuery(sql, parameters)
            Return True
        Catch ex As Exception
            MessageBox.Show($"Error adding category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function SearchCategoryByName(categoryName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Categories WHERE CategoryName = @CategoryName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@CategoryName", categoryName)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function UpdateCategory(oldCategoryName As String, newCategoryName As String) As Boolean
        Try
            If Not IsCategoryUnique(newCategoryName) Then
                MessageBox.Show("Category name already exists. Please enter a unique name.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            Dim sql As String = "UPDATE Categories SET CategoryName = @NewCategoryName WHERE CategoryName = @OldCategoryName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@NewCategoryName", newCategoryName),
            New MySqlParameter("@OldCategoryName", oldCategoryName)
        }

            ExecuteNonQuery(sql, parameters)
            Return True
        Catch ex As Exception
            MessageBox.Show($"Error updating category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function DeleteCategory(categoryName As String) As Boolean
        Try
            Dim sql As String = "DELETE FROM Categories WHERE CategoryName = @CategoryName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@CategoryName", categoryName)
        }

            ExecuteNonQuery(sql, parameters)
            Return True
        Catch ex As Exception
            MessageBox.Show($"Error deleting category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function IsCategoryUnique(categoryName As String) As Boolean
        Try
            Dim sql As String = "SELECT COUNT(*) FROM Categories WHERE CategoryName = @CategoryName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@CategoryName", categoryName)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)

            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Dim count As Integer = Convert.ToInt32(result)
                Return count = 0
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show($"Error checking category uniqueness: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function SearchMedicine(keyword As String, minStockQuantity As Integer, category As String) As DataTable
        Try
            Dim sql As String = "SELECT MedicineName, Dosage, StockQuantity, Category FROM Medicine WHERE MedicineName LIKE @Keyword AND StockQuantity >= @MinStock AND Category = @Category"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@Keyword", $"%{keyword}%"),
            New MySqlParameter("@MinStock", minStockQuantity),
            New MySqlParameter("@Category", category)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetAllMedicines() As DataTable
        Try
            Dim sql As String = "SELECT * FROM Medicine"
            Return ExecuteQuery(sql)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving all medicines: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function SearchMedicineByNameLike(medicineName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Medicine WHERE MedicineName LIKE @MedicineName"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@MedicineName", $"%{medicineName}%")
        }
            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetMedicineID(medicineName As String, dosage As String) As Integer
        Try
            Dim sql As String = "SELECT MedicineID FROM Medicine WHERE MedicineName = @MedicineName AND Dosage = @Dosage"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@MedicineName", medicineName),
            New MySqlParameter("@Dosage", dosage)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToInt32(result)
            End If

            Return 0
        Catch ex As Exception
            MessageBox.Show($"Error retrieving medicine ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

    Public Sub SaveMedicineOutData(transactionID As Integer, transactionDate As DateTime, patientID As String)
        Dim insertQuery As String = "INSERT INTO medicineout (TransactionID, TransactionDate, PatientID) VALUES (@TransactionID, @TransactionDate, @PatientID)"

        Dim parameters As New List(Of MySqlParameter)()
        parameters.Add(New MySqlParameter("@TransactionID", transactionID))
        parameters.Add(New MySqlParameter("@TransactionDate", transactionDate))
        parameters.Add(New MySqlParameter("@PatientID", patientID))

        Try
            ExecuteNonQuery(insertQuery, parameters)
            'MessageBox.Show("Data saved to medicineout table successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            HandleError("Error saving data to medicineout table.", ex)
        End Try
    End Sub

    Public Sub SaveMedicineOutDetailsData(transactionID As Integer, medicineID As Integer, quantity As Integer)
        Dim insertQuery As String = "INSERT INTO medicineoutdetails (TransactionID, MedicineID, Quantity) VALUES (@TransactionID, @MedicineID, @Quantity)"

        Dim parameters As New List(Of MySqlParameter)()
        parameters.Add(New MySqlParameter("@TransactionID", transactionID))
        parameters.Add(New MySqlParameter("@MedicineID", medicineID))
        parameters.Add(New MySqlParameter("@Quantity", quantity))

        Dim updateQuery As String = "UPDATE Medicine SET StockQuantity = StockQuantity - @Quantity WHERE MedicineID = @MedicineID"

        Dim updateParameters As New List(Of MySqlParameter)()
        updateParameters.Add(New MySqlParameter("@Quantity", quantity))
        updateParameters.Add(New MySqlParameter("@MedicineID", medicineID))

        Try
            ExecuteNonQuery(insertQuery, parameters)
            ExecuteNonQuery(updateQuery, updateParameters)

            'MessageBox.Show($"Quantity deducted from stock for MedicineID {medicineID}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            HandleError("Error updating stock quantity.", ex)
        End Try
    End Sub

    Public Function GetPatientDetailsByID(patientID As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Patients WHERE PatientID = @PatientID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving patient details by ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Public Function SearchPatientsByFirstName(firstName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Patients WHERE FirstName LIKE @FirstName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", $"%{firstName}%")
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for patients by first name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function SearchPatientsByLastName(lastName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Patients WHERE LastName LIKE @LastName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@LastName", $"%{lastName}%")
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error searching for patients by last name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetPatientDetailsByName(firstName As String, lastName As String) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Patients WHERE FirstName = @FirstName AND LastName = @LastName"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@FirstName", firstName),
            New MySqlParameter("@LastName", lastName)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving patient details by name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetDistinctTreatmentDates(patientID As String) As List(Of DateTime)
        Try
            Dim sql As String = "SELECT DISTINCT DateRecorded AS TreatmentDate FROM Treatment WHERE PatientID = @PatientID ORDER BY TreatmentDate DESC"

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@PatientID", patientID)
            }

            Dim dateTable As DataTable = ExecuteQuery(sql, parameters)

            Dim distinctDates As New List(Of DateTime)
            For Each row As DataRow In dateTable.Rows
                distinctDates.Add(Convert.ToDateTime(row("TreatmentDate")))
            Next

            Return distinctDates
        Catch ex As Exception
            MessageBox.Show($"Error retrieving distinct treatment dates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New List(Of DateTime)()
        End Try
    End Function

    Public Function GetTreatmentRecordsByDate(patientID As String, targetDate As DateTime) As DataTable
        Try
            Dim sql As String = "SELECT * FROM Treatment WHERE PatientID = @PatientID AND DateRecorded = @TargetDate"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@TargetDate", targetDate)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            MessageBox.Show($"Error retrieving treatment records by date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Public Function GetIllnessNameByID(illnessID As Integer) As String
        Try
            Dim sql As String = "SELECT IllnessName FROM Illnesses WHERE IllnessID = @IllnessID"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@IllnessID", illnessID)
        }

            Dim result As Object = ExecuteScalar(sql, parameters)
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToString(result)
            End If
        Catch ex As Exception
            Console.WriteLine($"Error retrieving illness name by ID: {ex.Message}")
        End Try

        Return "Unknown"
    End Function

    Public Function GetTreatmentRecordsByDateHAS(patientID As String, targetDate As DateTime) As DataTable
        Try
            Dim sql As String = "SELECT * FROM TreatmentRecordHAS WHERE PatientID = @PatientID AND DateRecorded = @TargetDate"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID),
            New MySqlParameter("@TargetDate", targetDate)
        }

            Return ExecuteQuery(sql, parameters)
        Catch ex As Exception
            Console.WriteLine($"Error retrieving treatment_tb records by date: {ex.Message}")
            Return Nothing
        End Try
    End Function


    Public Function GetDistinctTreatmentDatesHAS(patientID As String) As List(Of DateTime)
        Try
            Dim sql As String = "SELECT DISTINCT DateRecorded FROM TreatmentRecordHAS WHERE PatientID = @PatientID ORDER BY DateRecorded DESC"
            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@PatientID", patientID)
        }

            Dim dateTable As DataTable = ExecuteQuery(sql, parameters)

            Dim distinctDates As New List(Of DateTime)
            For Each row As DataRow In dateTable.Rows
                distinctDates.Add(row.Field(Of DateTime)("DateRecorded"))
            Next

            Return distinctDates
        Catch ex As Exception
            Console.WriteLine($"Error retrieving distinct treatment_tb dates: {ex.Message}")
            Return New List(Of DateTime)()
        End Try
    End Function
End Module
