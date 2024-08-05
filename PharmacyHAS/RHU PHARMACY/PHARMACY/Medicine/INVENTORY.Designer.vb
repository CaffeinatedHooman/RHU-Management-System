<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INVENTORY
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2ImageButton3 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NewMedsVTN = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabViewMed = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MedicineInStockView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MedicineOutView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabViewMed.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.MedicineInStockView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.MedicineOutView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(497, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PHARMACY'S INVENTORY"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Guna2ImageButton3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.NewMedsVTN)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(852, 300)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(495, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "MEDICINE"
        '
        'Guna2ImageButton3
        '
        Me.Guna2ImageButton3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2ImageButton3.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton3.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton3.Image = Global.RHU_PHARMACY.My.Resources.Resources.vaccine
        Me.Guna2ImageButton3.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton3.ImageRotate = 0!
        Me.Guna2ImageButton3.ImageSize = New System.Drawing.Size(100, 100)
        Me.Guna2ImageButton3.Location = New System.Drawing.Point(487, 90)
        Me.Guna2ImageButton3.Name = "Guna2ImageButton3"
        Me.Guna2ImageButton3.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton3.Size = New System.Drawing.Size(100, 100)
        Me.Guna2ImageButton3.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(262, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 18)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "NEW MEDICINE"
        '
        'NewMedsVTN
        '
        Me.NewMedsVTN.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.NewMedsVTN.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.NewMedsVTN.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.NewMedsVTN.Image = Global.RHU_PHARMACY.My.Resources.Resources.medicine
        Me.NewMedsVTN.ImageOffset = New System.Drawing.Point(0, 0)
        Me.NewMedsVTN.ImageRotate = 0!
        Me.NewMedsVTN.ImageSize = New System.Drawing.Size(100, 100)
        Me.NewMedsVTN.Location = New System.Drawing.Point(278, 90)
        Me.NewMedsVTN.Name = "NewMedsVTN"
        Me.NewMedsVTN.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.NewMedsVTN.Size = New System.Drawing.Size(100, 100)
        Me.NewMedsVTN.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TabViewMed)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 400)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(852, 500)
        Me.Panel3.TabIndex = 2
        '
        'TabViewMed
        '
        Me.TabViewMed.Controls.Add(Me.TabPage1)
        Me.TabViewMed.Controls.Add(Me.TabPage2)
        Me.TabViewMed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabViewMed.Location = New System.Drawing.Point(0, 0)
        Me.TabViewMed.Name = "TabViewMed"
        Me.TabViewMed.SelectedIndex = 0
        Me.TabViewMed.Size = New System.Drawing.Size(852, 500)
        Me.TabViewMed.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MedicineInStockView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(844, 469)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "IN-STOCK"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MedicineInStockView
        '
        Me.MedicineInStockView.AllowUserToAddRows = False
        Me.MedicineInStockView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.MedicineInStockView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MedicineInStockView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MedicineInStockView.ColumnHeadersHeight = 35
        Me.MedicineInStockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MedicineInStockView.DefaultCellStyle = DataGridViewCellStyle3
        Me.MedicineInStockView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MedicineInStockView.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.MedicineInStockView.Location = New System.Drawing.Point(3, 3)
        Me.MedicineInStockView.Name = "MedicineInStockView"
        Me.MedicineInStockView.ReadOnly = True
        Me.MedicineInStockView.RowHeadersVisible = False
        Me.MedicineInStockView.Size = New System.Drawing.Size(838, 463)
        Me.MedicineInStockView.TabIndex = 0
        Me.MedicineInStockView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.MedicineInStockView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.MedicineInStockView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.MedicineInStockView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.MedicineInStockView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.MedicineInStockView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.MedicineInStockView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.MedicineInStockView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.MedicineInStockView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.MedicineInStockView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MedicineInStockView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineInStockView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.MedicineInStockView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.MedicineInStockView.ThemeStyle.HeaderStyle.Height = 35
        Me.MedicineInStockView.ThemeStyle.ReadOnly = True
        Me.MedicineInStockView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.MedicineInStockView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.MedicineInStockView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineInStockView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.MedicineInStockView.ThemeStyle.RowsStyle.Height = 22
        Me.MedicineInStockView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.MedicineInStockView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MedicineOutView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(844, 469)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "OUT OF STOCK"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MedicineOutView
        '
        Me.MedicineOutView.AllowUserToAddRows = False
        Me.MedicineOutView.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.MedicineOutView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MedicineOutView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.MedicineOutView.ColumnHeadersHeight = 35
        Me.MedicineOutView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MedicineOutView.DefaultCellStyle = DataGridViewCellStyle6
        Me.MedicineOutView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MedicineOutView.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.MedicineOutView.Location = New System.Drawing.Point(3, 3)
        Me.MedicineOutView.Name = "MedicineOutView"
        Me.MedicineOutView.ReadOnly = True
        Me.MedicineOutView.RowHeadersVisible = False
        Me.MedicineOutView.Size = New System.Drawing.Size(838, 463)
        Me.MedicineOutView.TabIndex = 0
        Me.MedicineOutView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White
        Me.MedicineOutView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.MedicineOutView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.MedicineOutView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.MedicineOutView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.MedicineOutView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.MedicineOutView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.MedicineOutView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.MedicineOutView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.MedicineOutView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MedicineOutView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineOutView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.MedicineOutView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.MedicineOutView.ThemeStyle.HeaderStyle.Height = 35
        Me.MedicineOutView.ThemeStyle.ReadOnly = True
        Me.MedicineOutView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.MedicineOutView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.MedicineOutView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineOutView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.MedicineOutView.ThemeStyle.RowsStyle.Height = 22
        Me.MedicineOutView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.MedicineOutView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'INVENTORY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(869, 661)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "INVENTORY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTORY"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.TabViewMed.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.MedicineInStockView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.MedicineOutView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabViewMed As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MedicineInStockView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents MedicineOutView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2ImageButton3 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label2 As Label
    Friend WithEvents NewMedsVTN As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label1 As Label
End Class
