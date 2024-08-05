<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicineInfo
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridViewSearchResults = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.MedicineID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dosage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSearchMedicine = New System.Windows.Forms.Button()
        Me.txtSearchMedicine = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridViewSearchResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(734, 511)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(726, 481)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "MEDICINE INFO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridViewSearchResults)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 355)
        Me.Panel2.TabIndex = 1
        '
        'DataGridViewSearchResults
        '
        Me.DataGridViewSearchResults.AllowUserToAddRows = False
        Me.DataGridViewSearchResults.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridViewSearchResults.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewSearchResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewSearchResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewSearchResults.ColumnHeadersHeight = 30
        Me.DataGridViewSearchResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicineID, Me.MedicineName, Me.Dosage, Me.StockQuantity, Me.Category})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewSearchResults.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewSearchResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewSearchResults.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewSearchResults.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewSearchResults.Name = "DataGridViewSearchResults"
        Me.DataGridViewSearchResults.RowHeadersVisible = False
        Me.DataGridViewSearchResults.Size = New System.Drawing.Size(720, 355)
        Me.DataGridViewSearchResults.TabIndex = 0
        Me.DataGridViewSearchResults.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White
        Me.DataGridViewSearchResults.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewSearchResults.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridViewSearchResults.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridViewSearchResults.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridViewSearchResults.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridViewSearchResults.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewSearchResults.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewSearchResults.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewSearchResults.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewSearchResults.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewSearchResults.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewSearchResults.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewSearchResults.ThemeStyle.HeaderStyle.Height = 30
        Me.DataGridViewSearchResults.ThemeStyle.ReadOnly = False
        Me.DataGridViewSearchResults.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewSearchResults.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewSearchResults.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewSearchResults.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewSearchResults.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridViewSearchResults.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DataGridViewSearchResults.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'MedicineID
        '
        Me.MedicineID.HeaderText = "Medicine ID"
        Me.MedicineID.Name = "MedicineID"
        Me.MedicineID.Visible = False
        '
        'MedicineName
        '
        Me.MedicineName.HeaderText = "Medicine Name"
        Me.MedicineName.Name = "MedicineName"
        '
        'Dosage
        '
        Me.Dosage.HeaderText = "Dosage"
        Me.Dosage.Name = "Dosage"
        '
        'StockQuantity
        '
        Me.StockQuantity.HeaderText = "Stock Quantity"
        Me.StockQuantity.Name = "StockQuantity"
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnSearchMedicine)
        Me.Panel1.Controls.Add(Me.txtSearchMedicine)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(720, 120)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(120, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(483, 42)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "MEDICINE INFORMATION"
        '
        'btnSearchMedicine
        '
        Me.btnSearchMedicine.Location = New System.Drawing.Point(453, 65)
        Me.btnSearchMedicine.Name = "btnSearchMedicine"
        Me.btnSearchMedicine.Size = New System.Drawing.Size(150, 36)
        Me.btnSearchMedicine.TabIndex = 1
        Me.btnSearchMedicine.Text = "SEARCH "
        Me.btnSearchMedicine.UseVisualStyleBackColor = True
        '
        'txtSearchMedicine
        '
        Me.txtSearchMedicine.BorderColor = System.Drawing.Color.Black
        Me.txtSearchMedicine.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchMedicine.DefaultText = ""
        Me.txtSearchMedicine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchMedicine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchMedicine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchMedicine.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtSearchMedicine.ForeColor = System.Drawing.Color.Black
        Me.txtSearchMedicine.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchMedicine.Location = New System.Drawing.Point(127, 65)
        Me.txtSearchMedicine.Name = "txtSearchMedicine"
        Me.txtSearchMedicine.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchMedicine.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtSearchMedicine.PlaceholderText = "SEARCH MEDICINE "
        Me.txtSearchMedicine.SelectedText = ""
        Me.txtSearchMedicine.Size = New System.Drawing.Size(200, 36)
        Me.txtSearchMedicine.TabIndex = 0
        '
        'MedicineInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(734, 511)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MedicineInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MedicineInfo"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridViewSearchResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearchMedicine As Button
    Friend WithEvents txtSearchMedicine As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewSearchResults As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents MedicineID As DataGridViewTextBoxColumn
    Friend WithEvents MedicineName As DataGridViewTextBoxColumn
    Friend WithEvents Dosage As DataGridViewTextBoxColumn
    Friend WithEvents StockQuantity As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
End Class
