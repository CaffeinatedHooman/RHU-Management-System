<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailyReportPatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DailyReportPatient))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClinicAndDateSearchVTN = New System.Windows.Forms.Button()
        Me.ComboBoxClinic = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PrintToPDF = New System.Windows.Forms.Button()
        Me.RefreshDateVTN = New System.Windows.Forms.Button()
        Me.SearchDateVTN = New System.Windows.Forms.Button()
        Me.dgvQueueDetailsDay = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocumentDetailsDay = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDetailsDay = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvQueueDetailsDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ClinicAndDateSearchVTN)
        Me.Panel1.Controls.Add(Me.ComboBoxClinic)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.PrintToPDF)
        Me.Panel1.Controls.Add(Me.RefreshDateVTN)
        Me.Panel1.Controls.Add(Me.SearchDateVTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 130)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "DAILY PATIENT REPORTS"
        '
        'ClinicAndDateSearchVTN
        '
        Me.ClinicAndDateSearchVTN.Location = New System.Drawing.Point(759, 12)
        Me.ClinicAndDateSearchVTN.Name = "ClinicAndDateSearchVTN"
        Me.ClinicAndDateSearchVTN.Size = New System.Drawing.Size(222, 60)
        Me.ClinicAndDateSearchVTN.TabIndex = 6
        Me.ClinicAndDateSearchVTN.Text = "SEARCH CLINIC NAME AND DATE"
        Me.ClinicAndDateSearchVTN.UseVisualStyleBackColor = True
        '
        'ComboBoxClinic
        '
        Me.ComboBoxClinic.BackColor = System.Drawing.Color.Transparent
        Me.ComboBoxClinic.BorderColor = System.Drawing.Color.Black
        Me.ComboBoxClinic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxClinic.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxClinic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxClinic.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxClinic.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxClinic.ItemHeight = 30
        Me.ComboBoxClinic.Location = New System.Drawing.Point(759, 84)
        Me.ComboBoxClinic.Name = "ComboBoxClinic"
        Me.ComboBoxClinic.Size = New System.Drawing.Size(222, 36)
        Me.ComboBoxClinic.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(118, 84)
        Me.DateTimePicker1.MinimumSize = New System.Drawing.Size(140, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 30)
        Me.DateTimePicker1.TabIndex = 3
        '
        'PrintToPDF
        '
        Me.PrintToPDF.Location = New System.Drawing.Point(12, 84)
        Me.PrintToPDF.Name = "PrintToPDF"
        Me.PrintToPDF.Size = New System.Drawing.Size(100, 30)
        Me.PrintToPDF.TabIndex = 0
        Me.PrintToPDF.Text = "PRINT"
        Me.PrintToPDF.UseVisualStyleBackColor = True
        '
        'RefreshDateVTN
        '
        Me.RefreshDateVTN.Location = New System.Drawing.Point(12, 48)
        Me.RefreshDateVTN.Name = "RefreshDateVTN"
        Me.RefreshDateVTN.Size = New System.Drawing.Size(100, 30)
        Me.RefreshDateVTN.TabIndex = 0
        Me.RefreshDateVTN.Text = "REFRESH"
        Me.RefreshDateVTN.UseVisualStyleBackColor = True
        '
        'SearchDateVTN
        '
        Me.SearchDateVTN.Location = New System.Drawing.Point(12, 12)
        Me.SearchDateVTN.Name = "SearchDateVTN"
        Me.SearchDateVTN.Size = New System.Drawing.Size(100, 30)
        Me.SearchDateVTN.TabIndex = 0
        Me.SearchDateVTN.Text = "SEARCH"
        Me.SearchDateVTN.UseVisualStyleBackColor = True
        '
        'dgvQueueDetailsDay
        '
        Me.dgvQueueDetailsDay.AllowUserToAddRows = False
        Me.dgvQueueDetailsDay.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvQueueDetailsDay.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvQueueDetailsDay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvQueueDetailsDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvQueueDetailsDay.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvQueueDetailsDay.ColumnHeadersHeight = 22
        Me.dgvQueueDetailsDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvQueueDetailsDay.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvQueueDetailsDay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvQueueDetailsDay.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvQueueDetailsDay.Location = New System.Drawing.Point(0, 130)
        Me.dgvQueueDetailsDay.Name = "dgvQueueDetailsDay"
        Me.dgvQueueDetailsDay.ReadOnly = True
        Me.dgvQueueDetailsDay.RowHeadersVisible = False
        Me.dgvQueueDetailsDay.Size = New System.Drawing.Size(984, 631)
        Me.dgvQueueDetailsDay.TabIndex = 2
        Me.dgvQueueDetailsDay.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White
        Me.dgvQueueDetailsDay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvQueueDetailsDay.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvQueueDetailsDay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvQueueDetailsDay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvQueueDetailsDay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvQueueDetailsDay.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvQueueDetailsDay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvQueueDetailsDay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.dgvQueueDetailsDay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvQueueDetailsDay.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvQueueDetailsDay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvQueueDetailsDay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvQueueDetailsDay.ThemeStyle.HeaderStyle.Height = 22
        Me.dgvQueueDetailsDay.ThemeStyle.ReadOnly = True
        Me.dgvQueueDetailsDay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvQueueDetailsDay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvQueueDetailsDay.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvQueueDetailsDay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvQueueDetailsDay.ThemeStyle.RowsStyle.Height = 22
        Me.dgvQueueDetailsDay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgvQueueDetailsDay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocumentDetailsDay
        '
        '
        'PrintPreviewDetailsDay
        '
        Me.PrintPreviewDetailsDay.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDetailsDay.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDetailsDay.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDetailsDay.Enabled = True
        Me.PrintPreviewDetailsDay.Icon = CType(resources.GetObject("PrintPreviewDetailsDay.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDetailsDay.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDetailsDay.Visible = False
        '
        'DailyReportPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 761)
        Me.Controls.Add(Me.dgvQueueDetailsDay)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "DailyReportPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DailyReportPatient"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvQueueDetailsDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PrintToPDF As Button
    Friend WithEvents RefreshDateVTN As Button
    Friend WithEvents SearchDateVTN As Button
    Friend WithEvents dgvQueueDetailsDay As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ComboBoxClinic As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ClinicAndDateSearchVTN As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocumentDetailsDay As Printing.PrintDocument
    Friend WithEvents PrintPreviewDetailsDay As PrintPreviewDialog
    Friend WithEvents Label1 As Label
End Class
