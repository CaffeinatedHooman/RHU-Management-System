<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserLogs))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintToPDF = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxSearchOptions = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.datagridviewLogs = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.PrintDialogLogs = New System.Windows.Forms.PrintDialog()
        Me.PrintDocumentLogs = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewLogs = New System.Windows.Forms.PrintPreviewDialog()
        Me.RefreshVTN = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.datagridviewLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RefreshVTN)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PrintToPDF)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBoxSearchOptions)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 200)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(656, 37)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "USERS TIMEIN AND TIMEOUT REPORT "
        '
        'PrintToPDF
        '
        Me.PrintToPDF.Location = New System.Drawing.Point(351, 102)
        Me.PrintToPDF.Name = "PrintToPDF"
        Me.PrintToPDF.Size = New System.Drawing.Size(135, 36)
        Me.PrintToPDF.TabIndex = 3
        Me.PrintToPDF.Text = "PRINT PDF"
        Me.PrintToPDF.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SEARCH BY"
        '
        'ComboBoxSearchOptions
        '
        Me.ComboBoxSearchOptions.BackColor = System.Drawing.Color.Transparent
        Me.ComboBoxSearchOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSearchOptions.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxSearchOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxSearchOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxSearchOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ComboBoxSearchOptions.ItemHeight = 30
        Me.ComboBoxSearchOptions.Items.AddRange(New Object() {"Full Name Search", "Date Search"})
        Me.ComboBoxSearchOptions.Location = New System.Drawing.Point(137, 102)
        Me.ComboBoxSearchOptions.Name = "ComboBoxSearchOptions"
        Me.ComboBoxSearchOptions.Size = New System.Drawing.Size(208, 36)
        Me.ComboBoxSearchOptions.TabIndex = 0
        '
        'datagridviewLogs
        '
        Me.datagridviewLogs.AllowUserToAddRows = False
        Me.datagridviewLogs.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.datagridviewLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridviewLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridviewLogs.ColumnHeadersHeight = 20
        Me.datagridviewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridviewLogs.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagridviewLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewLogs.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.datagridviewLogs.Location = New System.Drawing.Point(0, 200)
        Me.datagridviewLogs.Name = "datagridviewLogs"
        Me.datagridviewLogs.ReadOnly = True
        Me.datagridviewLogs.RowHeadersVisible = False
        Me.datagridviewLogs.Size = New System.Drawing.Size(984, 561)
        Me.datagridviewLogs.TabIndex = 1
        Me.datagridviewLogs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.datagridviewLogs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagridviewLogs.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagridviewLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagridviewLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagridviewLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagridviewLogs.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagridviewLogs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.datagridviewLogs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.datagridviewLogs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagridviewLogs.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridviewLogs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.datagridviewLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagridviewLogs.ThemeStyle.HeaderStyle.Height = 20
        Me.datagridviewLogs.ThemeStyle.ReadOnly = True
        Me.datagridviewLogs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagridviewLogs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagridviewLogs.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridviewLogs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.datagridviewLogs.ThemeStyle.RowsStyle.Height = 22
        Me.datagridviewLogs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.datagridviewLogs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'PrintDialogLogs
        '
        Me.PrintDialogLogs.UseEXDialog = True
        '
        'PrintDocumentLogs
        '
        '
        'PrintPreviewLogs
        '
        Me.PrintPreviewLogs.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewLogs.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewLogs.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewLogs.Enabled = True
        Me.PrintPreviewLogs.Icon = CType(resources.GetObject("PrintPreviewLogs.Icon"), System.Drawing.Icon)
        Me.PrintPreviewLogs.Name = "PrintPreviewLogs"
        Me.PrintPreviewLogs.Visible = False
        '
        'RefreshVTN
        '
        Me.RefreshVTN.Location = New System.Drawing.Point(492, 102)
        Me.RefreshVTN.Name = "RefreshVTN"
        Me.RefreshVTN.Size = New System.Drawing.Size(100, 36)
        Me.RefreshVTN.TabIndex = 6
        Me.RefreshVTN.Text = "REFRESH"
        Me.RefreshVTN.UseVisualStyleBackColor = True
        '
        'UserLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 761)
        Me.Controls.Add(Me.datagridviewLogs)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "UserLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserLogs"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datagridviewLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents datagridviewLogs As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxSearchOptions As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents PrintToPDF As Button
    Friend WithEvents PrintDialogLogs As PrintDialog
    Friend WithEvents PrintDocumentLogs As Printing.PrintDocument
    Friend WithEvents PrintPreviewLogs As PrintPreviewDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents RefreshVTN As Button
End Class
