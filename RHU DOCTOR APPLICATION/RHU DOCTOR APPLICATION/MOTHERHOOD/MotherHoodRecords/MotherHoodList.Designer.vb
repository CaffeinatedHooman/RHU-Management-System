﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MotherHoodList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearchPregnancyTest = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchWithDate = New System.Windows.Forms.Button()
        Me.datePickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.datePickerStart = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchPatientTest = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PatientDataInformation = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.LabelRowCount = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PatientDataInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelRowCount)
        Me.Panel1.Controls.Add(Me.txtSearchPregnancyTest)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.SearchWithDate)
        Me.Panel1.Controls.Add(Me.datePickerEnd)
        Me.Panel1.Controls.Add(Me.datePickerStart)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.SearchPatientTest)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 150)
        Me.Panel1.TabIndex = 0
        '
        'txtSearchPregnancyTest
        '
        Me.txtSearchPregnancyTest.BackColor = System.Drawing.Color.Transparent
        Me.txtSearchPregnancyTest.BorderColor = System.Drawing.Color.Black
        Me.txtSearchPregnancyTest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtSearchPregnancyTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtSearchPregnancyTest.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchPregnancyTest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchPregnancyTest.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchPregnancyTest.ForeColor = System.Drawing.Color.Black
        Me.txtSearchPregnancyTest.ItemHeight = 30
        Me.txtSearchPregnancyTest.Items.AddRange(New Object() {"POSITIVE", "NEGATIVE"})
        Me.txtSearchPregnancyTest.Location = New System.Drawing.Point(43, 65)
        Me.txtSearchPregnancyTest.Name = "txtSearchPregnancyTest"
        Me.txtSearchPregnancyTest.Size = New System.Drawing.Size(220, 36)
        Me.txtSearchPregnancyTest.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(633, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "END DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(633, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "START DATE"
        '
        'SearchWithDate
        '
        Me.SearchWithDate.Location = New System.Drawing.Point(374, 61)
        Me.SearchWithDate.Name = "SearchWithDate"
        Me.SearchWithDate.Size = New System.Drawing.Size(180, 40)
        Me.SearchWithDate.TabIndex = 4
        Me.SearchWithDate.Text = "SEACH WITH DATE"
        Me.SearchWithDate.UseVisualStyleBackColor = True
        '
        'datePickerEnd
        '
        Me.datePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePickerEnd.Location = New System.Drawing.Point(750, 90)
        Me.datePickerEnd.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.datePickerEnd.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.datePickerEnd.MinimumSize = New System.Drawing.Size(4, 35)
        Me.datePickerEnd.Name = "datePickerEnd"
        Me.datePickerEnd.Size = New System.Drawing.Size(200, 35)
        Me.datePickerEnd.TabIndex = 3
        Me.datePickerEnd.Value = New Date(2024, 1, 1, 0, 0, 0, 0)
        '
        'datePickerStart
        '
        Me.datePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePickerStart.Location = New System.Drawing.Point(750, 40)
        Me.datePickerStart.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.datePickerStart.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.datePickerStart.MinimumSize = New System.Drawing.Size(4, 35)
        Me.datePickerStart.Name = "datePickerStart"
        Me.datePickerStart.Size = New System.Drawing.Size(200, 35)
        Me.datePickerStart.TabIndex = 3
        Me.datePickerStart.Value = New Date(2024, 1, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SEARCH PREGNANCY TEST PATIENTS"
        '
        'SearchPatientTest
        '
        Me.SearchPatientTest.Location = New System.Drawing.Point(278, 61)
        Me.SearchPatientTest.Name = "SearchPatientTest"
        Me.SearchPatientTest.Size = New System.Drawing.Size(90, 40)
        Me.SearchPatientTest.TabIndex = 1
        Me.SearchPatientTest.Text = "SEARCH"
        Me.SearchPatientTest.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.PatientDataInformation)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 150)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(984, 611)
        Me.Panel2.TabIndex = 1
        '
        'PatientDataInformation
        '
        Me.PatientDataInformation.AllowUserToAddRows = False
        Me.PatientDataInformation.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.PatientDataInformation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.PatientDataInformation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.PatientDataInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PatientDataInformation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PatientDataInformation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.PatientDataInformation.ColumnHeadersHeight = 25
        Me.PatientDataInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PatientDataInformation.DefaultCellStyle = DataGridViewCellStyle3
        Me.PatientDataInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PatientDataInformation.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PatientDataInformation.Location = New System.Drawing.Point(0, 0)
        Me.PatientDataInformation.Name = "PatientDataInformation"
        Me.PatientDataInformation.ReadOnly = True
        Me.PatientDataInformation.RowHeadersVisible = False
        Me.PatientDataInformation.Size = New System.Drawing.Size(984, 611)
        Me.PatientDataInformation.TabIndex = 0
        Me.PatientDataInformation.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid
        Me.PatientDataInformation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.PatientDataInformation.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.PatientDataInformation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.PatientDataInformation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.PatientDataInformation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.PatientDataInformation.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.PatientDataInformation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PatientDataInformation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.PatientDataInformation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.PatientDataInformation.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientDataInformation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.PatientDataInformation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.PatientDataInformation.ThemeStyle.HeaderStyle.Height = 25
        Me.PatientDataInformation.ThemeStyle.ReadOnly = True
        Me.PatientDataInformation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.PatientDataInformation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PatientDataInformation.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientDataInformation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.PatientDataInformation.ThemeStyle.RowsStyle.Height = 22
        Me.PatientDataInformation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PatientDataInformation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'LabelRowCount
        '
        Me.LabelRowCount.AutoSize = True
        Me.LabelRowCount.Location = New System.Drawing.Point(40, 104)
        Me.LabelRowCount.Name = "LabelRowCount"
        Me.LabelRowCount.Size = New System.Drawing.Size(12, 18)
        Me.LabelRowCount.TabIndex = 9
        Me.LabelRowCount.Text = "."
        '
        'MotherHoodList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 761)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "MotherHoodList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MotherHoodList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PatientDataInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PatientDataInformation As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents SearchPatientTest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents datePickerStart As DateTimePicker
    Friend WithEvents SearchWithDate As Button
    Friend WithEvents datePickerEnd As DateTimePicker
    Friend WithEvents txtSearchPregnancyTest As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelRowCount As Label
End Class
