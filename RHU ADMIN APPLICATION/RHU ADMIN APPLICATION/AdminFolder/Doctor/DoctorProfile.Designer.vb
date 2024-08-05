<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorProfile
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShowPanelUpdate = New System.Windows.Forms.Button()
        Me.btnUpdateDoctor = New System.Windows.Forms.Button()
        Me.UpdateDoctorPanelField = New System.Windows.Forms.Panel()
        Me.txtNewAccessCode = New System.Windows.Forms.Label()
        Me.cmbNewDoctorClinic = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtNewLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbNewDoctorGender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtNewContactNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDoctorFirstName = New System.Windows.Forms.Label()
        Me.lblDoctorContactNumber = New System.Windows.Forms.Label()
        Me.lblDoctorLastName = New System.Windows.Forms.Label()
        Me.lblDoctorAddress = New System.Windows.Forms.Label()
        Me.lblDoctorGender = New System.Windows.Forms.Label()
        Me.lblDoctorUsername = New System.Windows.Forms.Label()
        Me.lblDoctorSpecialization = New System.Windows.Forms.Label()
        Me.lblDoctorClinic = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDoctorAccessCode = New System.Windows.Forms.Label()
        Me.lblDoctorID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ListBoxDoctorNames = New System.Windows.Forms.ListBox()
        Me.cmbNewDoctorSpecialization = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.UpdateDoctorPanelField.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ShowPanelUpdate)
        Me.GroupBox1.Controls.Add(Me.btnUpdateDoctor)
        Me.GroupBox1.Controls.Add(Me.UpdateDoctorPanelField)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.ListBoxDoctorNames)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1378, 755)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Doctor Profile"
        '
        'ShowPanelUpdate
        '
        Me.ShowPanelUpdate.Location = New System.Drawing.Point(912, 22)
        Me.ShowPanelUpdate.Name = "ShowPanelUpdate"
        Me.ShowPanelUpdate.Size = New System.Drawing.Size(157, 45)
        Me.ShowPanelUpdate.TabIndex = 126
        Me.ShowPanelUpdate.Text = "UPDATE INFORMATION?"
        Me.ShowPanelUpdate.UseVisualStyleBackColor = True
        '
        'btnUpdateDoctor
        '
        Me.btnUpdateDoctor.Location = New System.Drawing.Point(912, 73)
        Me.btnUpdateDoctor.Name = "btnUpdateDoctor"
        Me.btnUpdateDoctor.Size = New System.Drawing.Size(157, 45)
        Me.btnUpdateDoctor.TabIndex = 127
        Me.btnUpdateDoctor.Text = "UPADATE DOCTOR"
        Me.btnUpdateDoctor.UseVisualStyleBackColor = True
        Me.btnUpdateDoctor.Visible = False
        '
        'UpdateDoctorPanelField
        '
        Me.UpdateDoctorPanelField.Controls.Add(Me.txtNewAccessCode)
        Me.UpdateDoctorPanelField.Controls.Add(Me.cmbNewDoctorSpecialization)
        Me.UpdateDoctorPanelField.Controls.Add(Me.cmbNewDoctorClinic)
        Me.UpdateDoctorPanelField.Controls.Add(Me.txtNewLastName)
        Me.UpdateDoctorPanelField.Controls.Add(Me.txtNewUsername)
        Me.UpdateDoctorPanelField.Controls.Add(Me.txtNewFirstName)
        Me.UpdateDoctorPanelField.Controls.Add(Me.cmbNewDoctorGender)
        Me.UpdateDoctorPanelField.Controls.Add(Me.txtNewContactNumber)
        Me.UpdateDoctorPanelField.Controls.Add(Me.txtNewAddress)
        Me.UpdateDoctorPanelField.Controls.Add(Me.Label9)
        Me.UpdateDoctorPanelField.Controls.Add(Me.Label10)
        Me.UpdateDoctorPanelField.Controls.Add(Me.Label11)
        Me.UpdateDoctorPanelField.Controls.Add(Me.Label12)
        Me.UpdateDoctorPanelField.Controls.Add(Me.Label22)
        Me.UpdateDoctorPanelField.Controls.Add(Me.Label23)
        Me.UpdateDoctorPanelField.Controls.Add(Me.Label24)
        Me.UpdateDoctorPanelField.Controls.Add(Me.Label25)
        Me.UpdateDoctorPanelField.Location = New System.Drawing.Point(6, 388)
        Me.UpdateDoctorPanelField.Name = "UpdateDoctorPanelField"
        Me.UpdateDoctorPanelField.Size = New System.Drawing.Size(900, 300)
        Me.UpdateDoctorPanelField.TabIndex = 125
        Me.UpdateDoctorPanelField.Visible = False
        '
        'txtNewAccessCode
        '
        Me.txtNewAccessCode.AutoSize = True
        Me.txtNewAccessCode.Location = New System.Drawing.Point(642, 257)
        Me.txtNewAccessCode.Name = "txtNewAccessCode"
        Me.txtNewAccessCode.Size = New System.Drawing.Size(18, 18)
        Me.txtNewAccessCode.TabIndex = 148
        Me.txtNewAccessCode.Text = "="
        '
        'cmbNewDoctorClinic
        '
        Me.cmbNewDoctorClinic.BackColor = System.Drawing.Color.Transparent
        Me.cmbNewDoctorClinic.BorderColor = System.Drawing.Color.Black
        Me.cmbNewDoctorClinic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNewDoctorClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewDoctorClinic.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewDoctorClinic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewDoctorClinic.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNewDoctorClinic.ForeColor = System.Drawing.Color.Black
        Me.cmbNewDoctorClinic.ItemHeight = 30
        Me.cmbNewDoctorClinic.Location = New System.Drawing.Point(645, 218)
        Me.cmbNewDoctorClinic.Name = "cmbNewDoctorClinic"
        Me.cmbNewDoctorClinic.Size = New System.Drawing.Size(220, 36)
        Me.cmbNewDoctorClinic.TabIndex = 146
        '
        'txtNewLastName
        '
        Me.txtNewLastName.BorderColor = System.Drawing.Color.Black
        Me.txtNewLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewLastName.DefaultText = ""
        Me.txtNewLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewLastName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewLastName.ForeColor = System.Drawing.Color.Black
        Me.txtNewLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewLastName.Location = New System.Drawing.Point(191, 90)
        Me.txtNewLastName.MaxLength = 30
        Me.txtNewLastName.Name = "txtNewLastName"
        Me.txtNewLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewLastName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNewLastName.PlaceholderText = ""
        Me.txtNewLastName.SelectedText = ""
        Me.txtNewLastName.Size = New System.Drawing.Size(220, 36)
        Me.txtNewLastName.TabIndex = 140
        '
        'txtNewUsername
        '
        Me.txtNewUsername.BorderColor = System.Drawing.Color.Black
        Me.txtNewUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewUsername.DefaultText = ""
        Me.txtNewUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUsername.ForeColor = System.Drawing.Color.Black
        Me.txtNewUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewUsername.Location = New System.Drawing.Point(645, 154)
        Me.txtNewUsername.MaxLength = 30
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewUsername.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNewUsername.PlaceholderText = ""
        Me.txtNewUsername.SelectedText = ""
        Me.txtNewUsername.Size = New System.Drawing.Size(220, 36)
        Me.txtNewUsername.TabIndex = 141
        '
        'txtNewFirstName
        '
        Me.txtNewFirstName.BorderColor = System.Drawing.Color.Black
        Me.txtNewFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewFirstName.DefaultText = ""
        Me.txtNewFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewFirstName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtNewFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewFirstName.Location = New System.Drawing.Point(191, 26)
        Me.txtNewFirstName.MaxLength = 30
        Me.txtNewFirstName.Name = "txtNewFirstName"
        Me.txtNewFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewFirstName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNewFirstName.PlaceholderText = ""
        Me.txtNewFirstName.SelectedText = ""
        Me.txtNewFirstName.Size = New System.Drawing.Size(220, 36)
        Me.txtNewFirstName.TabIndex = 142
        '
        'cmbNewDoctorGender
        '
        Me.cmbNewDoctorGender.BackColor = System.Drawing.Color.Transparent
        Me.cmbNewDoctorGender.BorderColor = System.Drawing.Color.Black
        Me.cmbNewDoctorGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNewDoctorGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewDoctorGender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewDoctorGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewDoctorGender.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbNewDoctorGender.ForeColor = System.Drawing.Color.Black
        Me.cmbNewDoctorGender.ItemHeight = 30
        Me.cmbNewDoctorGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cmbNewDoctorGender.Location = New System.Drawing.Point(191, 154)
        Me.cmbNewDoctorGender.Name = "cmbNewDoctorGender"
        Me.cmbNewDoctorGender.Size = New System.Drawing.Size(220, 36)
        Me.cmbNewDoctorGender.TabIndex = 147
        '
        'txtNewContactNumber
        '
        Me.txtNewContactNumber.BorderColor = System.Drawing.Color.Black
        Me.txtNewContactNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewContactNumber.DefaultText = ""
        Me.txtNewContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewContactNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewContactNumber.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewContactNumber.ForeColor = System.Drawing.Color.Black
        Me.txtNewContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewContactNumber.Location = New System.Drawing.Point(645, 26)
        Me.txtNewContactNumber.MaxLength = 30
        Me.txtNewContactNumber.Name = "txtNewContactNumber"
        Me.txtNewContactNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewContactNumber.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNewContactNumber.PlaceholderText = ""
        Me.txtNewContactNumber.SelectedText = ""
        Me.txtNewContactNumber.Size = New System.Drawing.Size(220, 36)
        Me.txtNewContactNumber.TabIndex = 143
        '
        'txtNewAddress
        '
        Me.txtNewAddress.BorderColor = System.Drawing.Color.Black
        Me.txtNewAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewAddress.DefaultText = ""
        Me.txtNewAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewAddress.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewAddress.ForeColor = System.Drawing.Color.Black
        Me.txtNewAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewAddress.Location = New System.Drawing.Point(645, 90)
        Me.txtNewAddress.MaxLength = 30
        Me.txtNewAddress.Name = "txtNewAddress"
        Me.txtNewAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewAddress.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNewAddress.PlaceholderText = ""
        Me.txtNewAddress.SelectedText = ""
        Me.txtNewAddress.Size = New System.Drawing.Size(220, 36)
        Me.txtNewAddress.TabIndex = 144
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(468, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 18)
        Me.Label9.TabIndex = 139
        Me.Label9.Text = "ASSIGN TO CLINIC"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(468, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 18)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "USERNAME"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 18)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "POSITION"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(468, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 18)
        Me.Label12.TabIndex = 137
        Me.Label12.Text = "ADDRESS"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(36, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(111, 18)
        Me.Label22.TabIndex = 132
        Me.Label22.Text = "FIRST NAME"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(468, 44)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(168, 18)
        Me.Label23.TabIndex = 136
        Me.Label23.Text = "CONTACT NUMBER"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(36, 108)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(105, 18)
        Me.Label24.TabIndex = 135
        Me.Label24.Text = "LAST NAME"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(36, 172)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 18)
        Me.Label25.TabIndex = 133
        Me.Label25.Text = "GENDER"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDoctorFirstName)
        Me.Panel1.Controls.Add(Me.lblDoctorContactNumber)
        Me.Panel1.Controls.Add(Me.lblDoctorLastName)
        Me.Panel1.Controls.Add(Me.lblDoctorAddress)
        Me.Panel1.Controls.Add(Me.lblDoctorGender)
        Me.Panel1.Controls.Add(Me.lblDoctorUsername)
        Me.Panel1.Controls.Add(Me.lblDoctorSpecialization)
        Me.Panel1.Controls.Add(Me.lblDoctorClinic)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblDoctorAccessCode)
        Me.Panel1.Controls.Add(Me.lblDoctorID)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Location = New System.Drawing.Point(6, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 360)
        Me.Panel1.TabIndex = 2
        '
        'lblDoctorFirstName
        '
        Me.lblDoctorFirstName.AutoSize = True
        Me.lblDoctorFirstName.Location = New System.Drawing.Point(213, 92)
        Me.lblDoctorFirstName.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblDoctorFirstName.Name = "lblDoctorFirstName"
        Me.lblDoctorFirstName.Size = New System.Drawing.Size(18, 18)
        Me.lblDoctorFirstName.TabIndex = 144
        Me.lblDoctorFirstName.Text = "="
        '
        'lblDoctorContactNumber
        '
        Me.lblDoctorContactNumber.AutoSize = True
        Me.lblDoctorContactNumber.Location = New System.Drawing.Point(666, 92)
        Me.lblDoctorContactNumber.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblDoctorContactNumber.Name = "lblDoctorContactNumber"
        Me.lblDoctorContactNumber.Size = New System.Drawing.Size(18, 18)
        Me.lblDoctorContactNumber.TabIndex = 144
        Me.lblDoctorContactNumber.Text = "="
        '
        'lblDoctorLastName
        '
        Me.lblDoctorLastName.AutoSize = True
        Me.lblDoctorLastName.Location = New System.Drawing.Point(213, 154)
        Me.lblDoctorLastName.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblDoctorLastName.Name = "lblDoctorLastName"
        Me.lblDoctorLastName.Size = New System.Drawing.Size(18, 18)
        Me.lblDoctorLastName.TabIndex = 145
        Me.lblDoctorLastName.Text = "="
        '
        'lblDoctorAddress
        '
        Me.lblDoctorAddress.AutoSize = True
        Me.lblDoctorAddress.Location = New System.Drawing.Point(666, 154)
        Me.lblDoctorAddress.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblDoctorAddress.Name = "lblDoctorAddress"
        Me.lblDoctorAddress.Size = New System.Drawing.Size(18, 18)
        Me.lblDoctorAddress.TabIndex = 145
        Me.lblDoctorAddress.Text = "="
        '
        'lblDoctorGender
        '
        Me.lblDoctorGender.AutoSize = True
        Me.lblDoctorGender.Location = New System.Drawing.Point(213, 216)
        Me.lblDoctorGender.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblDoctorGender.Name = "lblDoctorGender"
        Me.lblDoctorGender.Size = New System.Drawing.Size(18, 18)
        Me.lblDoctorGender.TabIndex = 146
        Me.lblDoctorGender.Text = "="
        '
        'lblDoctorUsername
        '
        Me.lblDoctorUsername.AutoSize = True
        Me.lblDoctorUsername.Location = New System.Drawing.Point(666, 216)
        Me.lblDoctorUsername.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblDoctorUsername.Name = "lblDoctorUsername"
        Me.lblDoctorUsername.Size = New System.Drawing.Size(18, 18)
        Me.lblDoctorUsername.TabIndex = 146
        Me.lblDoctorUsername.Text = "="
        '
        'lblDoctorSpecialization
        '
        Me.lblDoctorSpecialization.AutoSize = True
        Me.lblDoctorSpecialization.Location = New System.Drawing.Point(217, 282)
        Me.lblDoctorSpecialization.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblDoctorSpecialization.Name = "lblDoctorSpecialization"
        Me.lblDoctorSpecialization.Size = New System.Drawing.Size(18, 18)
        Me.lblDoctorSpecialization.TabIndex = 147
        Me.lblDoctorSpecialization.Text = "="
        '
        'lblDoctorClinic
        '
        Me.lblDoctorClinic.AutoSize = True
        Me.lblDoctorClinic.Location = New System.Drawing.Point(670, 282)
        Me.lblDoctorClinic.MaximumSize = New System.Drawing.Size(220, 0)
        Me.lblDoctorClinic.Name = "lblDoctorClinic"
        Me.lblDoctorClinic.Size = New System.Drawing.Size(18, 18)
        Me.lblDoctorClinic.TabIndex = 147
        Me.lblDoctorClinic.Text = "="
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(499, 278)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 18)
        Me.Label14.TabIndex = 143
        Me.Label14.Text = "ASSIGN TO CLINIC"
        '
        'lblDoctorAccessCode
        '
        Me.lblDoctorAccessCode.AutoSize = True
        Me.lblDoctorAccessCode.Location = New System.Drawing.Point(670, 313)
        Me.lblDoctorAccessCode.Name = "lblDoctorAccessCode"
        Me.lblDoctorAccessCode.Size = New System.Drawing.Size(18, 18)
        Me.lblDoctorAccessCode.TabIndex = 142
        Me.lblDoctorAccessCode.Text = "="
        '
        'lblDoctorID
        '
        Me.lblDoctorID.AutoSize = True
        Me.lblDoctorID.Location = New System.Drawing.Point(175, 30)
        Me.lblDoctorID.Name = "lblDoctorID"
        Me.lblDoctorID.Size = New System.Drawing.Size(65, 18)
        Me.lblDoctorID.TabIndex = 141
        Me.lblDoctorID.Text = "DOC99"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(65, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 18)
        Me.Label13.TabIndex = 140
        Me.Label13.Text = "DOCTOR ID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(499, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 18)
        Me.Label15.TabIndex = 138
        Me.Label15.Text = "USERNAME"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(65, 278)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 18)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "POSITION"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(499, 154)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 18)
        Me.Label17.TabIndex = 136
        Me.Label17.Text = "ADDRESS"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(65, 216)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 18)
        Me.Label18.TabIndex = 135
        Me.Label18.Text = "GENDER"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(499, 92)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 18)
        Me.Label19.TabIndex = 134
        Me.Label19.Text = "CONTACT NUMBER"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(65, 154)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 18)
        Me.Label20.TabIndex = 139
        Me.Label20.Text = "LAST NAME"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(65, 92)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 18)
        Me.Label21.TabIndex = 133
        Me.Label21.Text = "FIRST NAME"
        '
        'ListBoxDoctorNames
        '
        Me.ListBoxDoctorNames.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBoxDoctorNames.FormattingEnabled = True
        Me.ListBoxDoctorNames.ItemHeight = 18
        Me.ListBoxDoctorNames.Location = New System.Drawing.Point(1075, 22)
        Me.ListBoxDoctorNames.MultiColumn = True
        Me.ListBoxDoctorNames.Name = "ListBoxDoctorNames"
        Me.ListBoxDoctorNames.ScrollAlwaysVisible = True
        Me.ListBoxDoctorNames.Size = New System.Drawing.Size(300, 730)
        Me.ListBoxDoctorNames.TabIndex = 1
        '
        'cmbNewDoctorSpecialization
        '
        Me.cmbNewDoctorSpecialization.BackColor = System.Drawing.Color.Transparent
        Me.cmbNewDoctorSpecialization.BorderColor = System.Drawing.Color.Black
        Me.cmbNewDoctorSpecialization.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNewDoctorSpecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewDoctorSpecialization.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewDoctorSpecialization.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbNewDoctorSpecialization.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNewDoctorSpecialization.ForeColor = System.Drawing.Color.Black
        Me.cmbNewDoctorSpecialization.ItemHeight = 30
        Me.cmbNewDoctorSpecialization.Location = New System.Drawing.Point(191, 218)
        Me.cmbNewDoctorSpecialization.Name = "cmbNewDoctorSpecialization"
        Me.cmbNewDoctorSpecialization.Size = New System.Drawing.Size(220, 36)
        Me.cmbNewDoctorSpecialization.TabIndex = 145
        '
        'DoctorProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1384, 761)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "DoctorProfile"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.UpdateDoctorPanelField.ResumeLayout(False)
        Me.UpdateDoctorPanelField.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListBoxDoctorNames As ListBox
    Friend WithEvents lblDoctorFirstName As Label
    Friend WithEvents lblDoctorContactNumber As Label
    Friend WithEvents lblDoctorLastName As Label
    Friend WithEvents lblDoctorAddress As Label
    Friend WithEvents lblDoctorGender As Label
    Friend WithEvents lblDoctorUsername As Label
    Friend WithEvents lblDoctorSpecialization As Label
    Friend WithEvents lblDoctorClinic As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblDoctorAccessCode As Label
    Friend WithEvents lblDoctorID As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents UpdateDoctorPanelField As Panel
    Friend WithEvents txtNewAccessCode As Label
    Friend WithEvents cmbNewDoctorClinic As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtNewLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbNewDoctorGender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtNewContactNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents ShowPanelUpdate As Button
    Friend WithEvents btnUpdateDoctor As Button
    Friend WithEvents cmbNewDoctorSpecialization As Guna.UI2.WinForms.Guna2ComboBox
End Class
