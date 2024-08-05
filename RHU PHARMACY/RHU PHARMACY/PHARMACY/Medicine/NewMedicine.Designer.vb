<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMedicine
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMedicineName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDosage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStockQuantity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCategory = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAddMedicine = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MEDICINE NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DOSAGE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "QUANTITY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "CATEGORY"
        '
        'txtMedicineName
        '
        Me.txtMedicineName.BorderColor = System.Drawing.Color.Black
        Me.txtMedicineName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMedicineName.DefaultText = ""
        Me.txtMedicineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMedicineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMedicineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMedicineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMedicineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMedicineName.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtMedicineName.ForeColor = System.Drawing.Color.Black
        Me.txtMedicineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMedicineName.Location = New System.Drawing.Point(233, 172)
        Me.txtMedicineName.Name = "txtMedicineName"
        Me.txtMedicineName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMedicineName.PlaceholderText = ""
        Me.txtMedicineName.SelectedText = ""
        Me.txtMedicineName.Size = New System.Drawing.Size(250, 36)
        Me.txtMedicineName.TabIndex = 5
        '
        'txtDosage
        '
        Me.txtDosage.BorderColor = System.Drawing.Color.Black
        Me.txtDosage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDosage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDosage.DefaultText = ""
        Me.txtDosage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDosage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDosage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDosage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDosage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDosage.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtDosage.ForeColor = System.Drawing.Color.Black
        Me.txtDosage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDosage.Location = New System.Drawing.Point(233, 226)
        Me.txtDosage.MaxLength = 4
        Me.txtDosage.Name = "txtDosage"
        Me.txtDosage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDosage.PlaceholderText = ""
        Me.txtDosage.SelectedText = ""
        Me.txtDosage.Size = New System.Drawing.Size(250, 36)
        Me.txtDosage.TabIndex = 5
        '
        'txtStockQuantity
        '
        Me.txtStockQuantity.BorderColor = System.Drawing.Color.Black
        Me.txtStockQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStockQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStockQuantity.DefaultText = ""
        Me.txtStockQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStockQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStockQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStockQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStockQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStockQuantity.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtStockQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtStockQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStockQuantity.Location = New System.Drawing.Point(233, 280)
        Me.txtStockQuantity.MaxLength = 4
        Me.txtStockQuantity.Name = "txtStockQuantity"
        Me.txtStockQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStockQuantity.PlaceholderText = ""
        Me.txtStockQuantity.SelectedText = ""
        Me.txtStockQuantity.Size = New System.Drawing.Size(250, 36)
        Me.txtStockQuantity.TabIndex = 5
        '
        'txtCategory
        '
        Me.txtCategory.BorderColor = System.Drawing.Color.Black
        Me.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategory.DefaultText = ""
        Me.txtCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategory.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtCategory.ForeColor = System.Drawing.Color.Black
        Me.txtCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCategory.Location = New System.Drawing.Point(233, 334)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCategory.PlaceholderText = ""
        Me.txtCategory.SelectedText = ""
        Me.txtCategory.Size = New System.Drawing.Size(250, 36)
        Me.txtCategory.TabIndex = 5
        '
        'btnAddMedicine
        '
        Me.btnAddMedicine.BackColor = System.Drawing.Color.White
        Me.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddMedicine.Location = New System.Drawing.Point(353, 425)
        Me.btnAddMedicine.Name = "btnAddMedicine"
        Me.btnAddMedicine.Size = New System.Drawing.Size(130, 35)
        Me.btnAddMedicine.TabIndex = 8
        Me.btnAddMedicine.Text = "ADD MEDICINE"
        Me.btnAddMedicine.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(150, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(296, 42)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "NEW MEDICINE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(489, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 27)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "mg"
        '
        'NewMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.RHU_PHARMACY.My.Resources.Resources._2010_i121_044_isometric_gastroenterology_set_01_03
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAddMedicine)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtStockQuantity)
        Me.Controls.Add(Me.txtDosage)
        Me.Controls.Add(Me.txtMedicineName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewMedicine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewMedicine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMedicineName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDosage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStockQuantity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCategory As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAddMedicine As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
