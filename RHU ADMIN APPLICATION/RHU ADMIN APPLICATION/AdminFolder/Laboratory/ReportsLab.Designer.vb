<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportsLab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.VTNsearchLab = New System.Windows.Forms.Button()
        Me.ComboBoxLaboratory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DateTimePickerRecordDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewLabResults = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnExportToExcel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewLabResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExportToExcel)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.VTNsearchLab)
        Me.Panel1.Controls.Add(Me.ComboBoxLaboratory)
        Me.Panel1.Controls.Add(Me.DateTimePickerRecordDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 100)
        Me.Panel1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(181, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "SEARCH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'VTNsearchLab
        '
        Me.VTNsearchLab.Location = New System.Drawing.Point(638, 57)
        Me.VTNsearchLab.Name = "VTNsearchLab"
        Me.VTNsearchLab.Size = New System.Drawing.Size(100, 30)
        Me.VTNsearchLab.TabIndex = 11
        Me.VTNsearchLab.Text = "SEARCH"
        Me.VTNsearchLab.UseVisualStyleBackColor = True
        '
        'ComboBoxLaboratory
        '
        Me.ComboBoxLaboratory.BackColor = System.Drawing.Color.Transparent
        Me.ComboBoxLaboratory.BorderColor = System.Drawing.Color.Black
        Me.ComboBoxLaboratory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxLaboratory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLaboratory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxLaboratory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxLaboratory.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxLaboratory.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxLaboratory.ItemHeight = 30
        Me.ComboBoxLaboratory.Location = New System.Drawing.Point(638, 18)
        Me.ComboBoxLaboratory.Name = "ComboBoxLaboratory"
        Me.ComboBoxLaboratory.Size = New System.Drawing.Size(225, 36)
        Me.ComboBoxLaboratory.TabIndex = 9
        '
        'DateTimePickerRecordDate
        '
        Me.DateTimePickerRecordDate.Checked = True
        Me.DateTimePickerRecordDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerRecordDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerRecordDate.Location = New System.Drawing.Point(181, 18)
        Me.DateTimePickerRecordDate.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerRecordDate.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerRecordDate.Name = "DateTimePickerRecordDate"
        Me.DateTimePickerRecordDate.Size = New System.Drawing.Size(200, 36)
        Me.DateTimePickerRecordDate.TabIndex = 8
        Me.DateTimePickerRecordDate.Value = New Date(2024, 4, 18, 8, 59, 36, 731)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(411, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SEARCH BY LABARATORY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 36)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SEARCH BY DATE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AND LAB. NAME" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridViewLabResults)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(884, 361)
        Me.Panel2.TabIndex = 1
        '
        'DataGridViewLabResults
        '
        Me.DataGridViewLabResults.AllowUserToAddRows = False
        Me.DataGridViewLabResults.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DataGridViewLabResults.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewLabResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLabResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewLabResults.ColumnHeadersHeight = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewLabResults.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewLabResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewLabResults.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewLabResults.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewLabResults.Name = "DataGridViewLabResults"
        Me.DataGridViewLabResults.ReadOnly = True
        Me.DataGridViewLabResults.RowHeadersVisible = False
        Me.DataGridViewLabResults.Size = New System.Drawing.Size(884, 361)
        Me.DataGridViewLabResults.TabIndex = 0
        Me.DataGridViewLabResults.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White
        Me.DataGridViewLabResults.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewLabResults.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridViewLabResults.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridViewLabResults.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridViewLabResults.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridViewLabResults.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewLabResults.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewLabResults.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewLabResults.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewLabResults.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewLabResults.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewLabResults.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewLabResults.ThemeStyle.HeaderStyle.Height = 30
        Me.DataGridViewLabResults.ThemeStyle.ReadOnly = True
        Me.DataGridViewLabResults.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewLabResults.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewLabResults.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewLabResults.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewLabResults.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridViewLabResults.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DataGridViewLabResults.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.Location = New System.Drawing.Point(744, 57)
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Size = New System.Drawing.Size(120, 30)
        Me.btnExportToExcel.TabIndex = 13
        Me.btnExportToExcel.Text = "DOWNLOAD"
        Me.btnExportToExcel.UseVisualStyleBackColor = True
        '
        'ReportsLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "ReportsLab"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportsLab"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridViewLabResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewLabResults As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents VTNsearchLab As Button
    Friend WithEvents ComboBoxLaboratory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DateTimePickerRecordDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExportToExcel As Button
End Class
