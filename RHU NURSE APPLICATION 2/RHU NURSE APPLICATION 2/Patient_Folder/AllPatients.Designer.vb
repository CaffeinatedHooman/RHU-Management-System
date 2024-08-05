<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllPatients
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllPatients))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintToPDF = New System.Windows.Forms.Button()
        Me.ComboBoxSearchOptions = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataGridViewPatients = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocumentPatient = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewPatient = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.dataGridViewPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PrintToPDF)
        Me.Panel1.Controls.Add(Me.ComboBoxSearchOptions)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(994, 150)
        Me.Panel1.TabIndex = 1
        '
        'PrintToPDF
        '
        Me.PrintToPDF.Location = New System.Drawing.Point(422, 30)
        Me.PrintToPDF.Name = "PrintToPDF"
        Me.PrintToPDF.Size = New System.Drawing.Size(200, 36)
        Me.PrintToPDF.TabIndex = 2
        Me.PrintToPDF.Text = "PRINT DATA"
        Me.PrintToPDF.UseVisualStyleBackColor = True
        '
        'ComboBoxSearchOptions
        '
        Me.ComboBoxSearchOptions.BackColor = System.Drawing.Color.Transparent
        Me.ComboBoxSearchOptions.BorderColor = System.Drawing.Color.Black
        Me.ComboBoxSearchOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSearchOptions.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxSearchOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxSearchOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxSearchOptions.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxSearchOptions.ItemHeight = 30
        Me.ComboBoxSearchOptions.Items.AddRange(New Object() {"Full Name Search", "Date Search", "General Search", "Display All"})
        Me.ComboBoxSearchOptions.Location = New System.Drawing.Point(216, 30)
        Me.ComboBoxSearchOptions.Name = "ComboBoxSearchOptions"
        Me.ComboBoxSearchOptions.Size = New System.Drawing.Size(200, 36)
        Me.ComboBoxSearchOptions.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SEARCH PATIENT BY"
        '
        'dataGridViewPatients
        '
        Me.dataGridViewPatients.AllowUserToAddRows = False
        Me.dataGridViewPatients.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dataGridViewPatients.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dataGridViewPatients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dataGridViewPatients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewPatients.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dataGridViewPatients.ColumnHeadersHeight = 20
        Me.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewPatients.DefaultCellStyle = DataGridViewCellStyle9
        Me.dataGridViewPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridViewPatients.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dataGridViewPatients.Location = New System.Drawing.Point(0, 150)
        Me.dataGridViewPatients.Name = "dataGridViewPatients"
        Me.dataGridViewPatients.ReadOnly = True
        Me.dataGridViewPatients.RowHeadersVisible = False
        Me.dataGridViewPatients.Size = New System.Drawing.Size(994, 611)
        Me.dataGridViewPatients.TabIndex = 2
        Me.dataGridViewPatients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.dataGridViewPatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dataGridViewPatients.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataGridViewPatients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataGridViewPatients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataGridViewPatients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataGridViewPatients.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dataGridViewPatients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dataGridViewPatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dataGridViewPatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataGridViewPatients.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataGridViewPatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dataGridViewPatients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataGridViewPatients.ThemeStyle.HeaderStyle.Height = 20
        Me.dataGridViewPatients.ThemeStyle.ReadOnly = True
        Me.dataGridViewPatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dataGridViewPatients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataGridViewPatients.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataGridViewPatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dataGridViewPatients.ThemeStyle.RowsStyle.Height = 22
        Me.dataGridViewPatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dataGridViewPatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocumentPatient
        '
        '
        'PrintPreviewPatient
        '
        Me.PrintPreviewPatient.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewPatient.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewPatient.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewPatient.Enabled = True
        Me.PrintPreviewPatient.Icon = CType(resources.GetObject("PrintPreviewPatient.Icon"), System.Drawing.Icon)
        Me.PrintPreviewPatient.Name = "PrintPreviewPatient"
        Me.PrintPreviewPatient.Visible = False
        '
        'AllPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(994, 761)
        Me.Controls.Add(Me.dataGridViewPatients)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1010, 800)
        Me.Name = "AllPatients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PATIENTS SEARCH"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dataGridViewPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PrintToPDF As Button
    Friend WithEvents ComboBoxSearchOptions As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dataGridViewPatients As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocumentPatient As Printing.PrintDocument
    Friend WithEvents PrintPreviewPatient As PrintPreviewDialog
End Class
