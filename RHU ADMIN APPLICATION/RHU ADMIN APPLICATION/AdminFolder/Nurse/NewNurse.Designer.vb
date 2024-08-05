<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewNurse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BoxAccessCode = New System.Windows.Forms.Label()
        Me.cmbNurseSpecializations = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ComboBoxClinicNames = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboNurseGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtNurseID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNurseUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNurseAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNurseContactNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNurseLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNurseFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnAddNurse = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.BoxAccessCode)
        Me.GroupBox1.Controls.Add(Me.cmbNurseSpecializations)
        Me.GroupBox1.Controls.Add(Me.ComboBoxClinicNames)
        Me.GroupBox1.Controls.Add(Me.cboNurseGender)
        Me.GroupBox1.Controls.Add(Me.txtNurseID)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtNurseUsername)
        Me.GroupBox1.Controls.Add(Me.txtNurseAddress)
        Me.GroupBox1.Controls.Add(Me.txtNurseContactNumber)
        Me.GroupBox1.Controls.Add(Me.txtNurseLastName)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtNurseFirstName)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.btnAddNurse)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(982, 459)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NEW NURSE"
        '
        'BoxAccessCode
        '
        Me.BoxAccessCode.AutoSize = True
        Me.BoxAccessCode.Location = New System.Drawing.Point(681, 321)
        Me.BoxAccessCode.Name = "BoxAccessCode"
        Me.BoxAccessCode.Size = New System.Drawing.Size(107, 18)
        Me.BoxAccessCode.TabIndex = 121
        Me.BoxAccessCode.Text = "AccessCode"
        '
        'cmbNurseSpecializations
        '
        Me.cmbNurseSpecializations.BackColor = System.Drawing.Color.Transparent
        Me.cmbNurseSpecializations.BorderColor = System.Drawing.Color.Black
        Me.cmbNurseSpecializations.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNurseSpecializations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNurseSpecializations.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNurseSpecializations.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNurseSpecializations.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNurseSpecializations.ForeColor = System.Drawing.Color.Black
        Me.cmbNurseSpecializations.ItemHeight = 30
        Me.cmbNurseSpecializations.Location = New System.Drawing.Point(220, 279)
        Me.cmbNurseSpecializations.Name = "cmbNurseSpecializations"
        Me.cmbNurseSpecializations.Size = New System.Drawing.Size(230, 36)
        Me.cmbNurseSpecializations.TabIndex = 81
        '
        'ComboBoxClinicNames
        '
        Me.ComboBoxClinicNames.BackColor = System.Drawing.Color.Transparent
        Me.ComboBoxClinicNames.BorderColor = System.Drawing.Color.Black
        Me.ComboBoxClinicNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxClinicNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxClinicNames.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxClinicNames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxClinicNames.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxClinicNames.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxClinicNames.ItemHeight = 30
        Me.ComboBoxClinicNames.Location = New System.Drawing.Point(684, 282)
        Me.ComboBoxClinicNames.Name = "ComboBoxClinicNames"
        Me.ComboBoxClinicNames.Size = New System.Drawing.Size(230, 36)
        Me.ComboBoxClinicNames.TabIndex = 80
        '
        'cboNurseGender
        '
        Me.cboNurseGender.BackColor = System.Drawing.Color.Transparent
        Me.cboNurseGender.BorderColor = System.Drawing.Color.Black
        Me.cboNurseGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboNurseGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNurseGender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboNurseGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboNurseGender.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cboNurseGender.ForeColor = System.Drawing.Color.Black
        Me.cboNurseGender.ItemHeight = 30
        Me.cboNurseGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cboNurseGender.Location = New System.Drawing.Point(220, 217)
        Me.cboNurseGender.Name = "cboNurseGender"
        Me.cboNurseGender.Size = New System.Drawing.Size(230, 36)
        Me.cboNurseGender.TabIndex = 79
        '
        'txtNurseID
        '
        Me.txtNurseID.AutoSize = True
        Me.txtNurseID.Location = New System.Drawing.Point(217, 56)
        Me.txtNurseID.Name = "txtNurseID"
        Me.txtNurseID.Size = New System.Drawing.Size(66, 18)
        Me.txtNurseID.TabIndex = 78
        Me.txtNurseID.Text = "NUR99"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(116, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 18)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "NURSE ID"
        '
        'txtNurseUsername
        '
        Me.txtNurseUsername.BorderColor = System.Drawing.Color.Black
        Me.txtNurseUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNurseUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNurseUsername.DefaultText = ""
        Me.txtNurseUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNurseUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNurseUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNurseUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNurseUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNurseUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNurseUsername.ForeColor = System.Drawing.Color.Black
        Me.txtNurseUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNurseUsername.Location = New System.Drawing.Point(684, 223)
        Me.txtNurseUsername.Name = "txtNurseUsername"
        Me.txtNurseUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNurseUsername.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNurseUsername.PlaceholderText = ""
        Me.txtNurseUsername.SelectedText = ""
        Me.txtNurseUsername.Size = New System.Drawing.Size(230, 35)
        Me.txtNurseUsername.TabIndex = 76
        '
        'txtNurseAddress
        '
        Me.txtNurseAddress.BorderColor = System.Drawing.Color.Black
        Me.txtNurseAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNurseAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNurseAddress.DefaultText = ""
        Me.txtNurseAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNurseAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNurseAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNurseAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNurseAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNurseAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNurseAddress.ForeColor = System.Drawing.Color.Black
        Me.txtNurseAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNurseAddress.Location = New System.Drawing.Point(684, 161)
        Me.txtNurseAddress.Name = "txtNurseAddress"
        Me.txtNurseAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNurseAddress.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNurseAddress.PlaceholderText = ""
        Me.txtNurseAddress.SelectedText = ""
        Me.txtNurseAddress.Size = New System.Drawing.Size(230, 35)
        Me.txtNurseAddress.TabIndex = 75
        '
        'txtNurseContactNumber
        '
        Me.txtNurseContactNumber.BorderColor = System.Drawing.Color.Black
        Me.txtNurseContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNurseContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNurseContactNumber.DefaultText = ""
        Me.txtNurseContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNurseContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNurseContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNurseContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNurseContactNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNurseContactNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNurseContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtNurseContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNurseContactNumber.Location = New System.Drawing.Point(684, 99)
        Me.txtNurseContactNumber.Name = "txtNurseContactNumber"
        Me.txtNurseContactNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNurseContactNumber.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNurseContactNumber.PlaceholderText = ""
        Me.txtNurseContactNumber.SelectedText = ""
        Me.txtNurseContactNumber.Size = New System.Drawing.Size(230, 35)
        Me.txtNurseContactNumber.TabIndex = 74
        '
        'txtNurseLastName
        '
        Me.txtNurseLastName.BorderColor = System.Drawing.Color.Black
        Me.txtNurseLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNurseLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNurseLastName.DefaultText = ""
        Me.txtNurseLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNurseLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNurseLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNurseLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNurseLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNurseLastName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNurseLastName.ForeColor = System.Drawing.Color.Black
        Me.txtNurseLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNurseLastName.Location = New System.Drawing.Point(220, 161)
        Me.txtNurseLastName.Name = "txtNurseLastName"
        Me.txtNurseLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNurseLastName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNurseLastName.PlaceholderText = ""
        Me.txtNurseLastName.SelectedText = ""
        Me.txtNurseLastName.Size = New System.Drawing.Size(230, 35)
        Me.txtNurseLastName.TabIndex = 73
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(510, 297)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 18)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "ASSIGN TO CLINIC"
        '
        'txtNurseFirstName
        '
        Me.txtNurseFirstName.BorderColor = System.Drawing.Color.Black
        Me.txtNurseFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNurseFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNurseFirstName.DefaultText = ""
        Me.txtNurseFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNurseFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNurseFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNurseFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNurseFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNurseFirstName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNurseFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtNurseFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNurseFirstName.Location = New System.Drawing.Point(220, 99)
        Me.txtNurseFirstName.Name = "txtNurseFirstName"
        Me.txtNurseFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNurseFirstName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNurseFirstName.PlaceholderText = ""
        Me.txtNurseFirstName.SelectedText = ""
        Me.txtNurseFirstName.Size = New System.Drawing.Size(230, 35)
        Me.txtNurseFirstName.TabIndex = 72
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(510, 235)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 18)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "USERNAME"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(68, 297)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(146, 18)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "SPECIALIZATION"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(510, 173)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 18)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "ADDRESS"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(68, 235)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 18)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "GENDER"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(510, 111)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 18)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "CONTACT NUMBER"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(68, 173)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 18)
        Me.Label20.TabIndex = 71
        Me.Label20.Text = "LAST NAME"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(68, 111)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 18)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "FIRST NAME"
        '
        'btnAddNurse
        '
        Me.btnAddNurse.Location = New System.Drawing.Point(714, 368)
        Me.btnAddNurse.Name = "btnAddNurse"
        Me.btnAddNurse.Size = New System.Drawing.Size(200, 35)
        Me.btnAddNurse.TabIndex = 63
        Me.btnAddNurse.Text = "SAVE ACCOUNT"
        Me.btnAddNurse.UseVisualStyleBackColor = True
        '
        'NewNurse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "NewNurse"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nurse Setup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbNurseSpecializations As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ComboBoxClinicNames As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboNurseGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtNurseID As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtNurseUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNurseAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNurseContactNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNurseLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtNurseFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btnAddNurse As Button
    Friend WithEvents BoxAccessCode As Label
End Class
