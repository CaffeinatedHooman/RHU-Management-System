<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OldPatient
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
        Me.ComboBoxSearchOptions = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.ClearInfoExisting = New System.Windows.Forms.Button()
        Me.lblMN = New System.Windows.Forms.Label()
        Me.lblCitizenship = New System.Windows.Forms.Label()
        Me.lblPhilhealthID = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblReligon = New System.Windows.Forms.Label()
        Me.lblMiddlename = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblMS = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.PatientSeachList = New System.Windows.Forms.ListBox()
        Me.GroupBoxVital = New System.Windows.Forms.GroupBox()
        Me.cmbDoctors = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SaveVitals = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblClinicName = New System.Windows.Forms.Label()
        Me.lblSelectedDoctorID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiagnosis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHeight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPulseRate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtWeight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRespirationRate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBloodPressure = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBodyTemp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxVital.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ComboBoxSearchOptions)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.ClearInfoExisting)
        Me.GroupBox1.Controls.Add(Me.lblMN)
        Me.GroupBox1.Controls.Add(Me.lblCitizenship)
        Me.GroupBox1.Controls.Add(Me.lblPhilhealthID)
        Me.GroupBox1.Controls.Add(Me.lblDOB)
        Me.GroupBox1.Controls.Add(Me.lblReligon)
        Me.GroupBox1.Controls.Add(Me.lblMiddlename)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.lblLastname)
        Me.GroupBox1.Controls.Add(Me.lblMS)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.lblFirstname)
        Me.GroupBox1.Controls.Add(Me.lblPatientID)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.PatientSeachList)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1384, 350)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PATIENT INFORMATION"
        '
        'ComboBoxSearchOptions
        '
        Me.ComboBoxSearchOptions.BackColor = System.Drawing.Color.Transparent
        Me.ComboBoxSearchOptions.BorderColor = System.Drawing.Color.Black
        Me.ComboBoxSearchOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSearchOptions.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxSearchOptions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxSearchOptions.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxSearchOptions.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxSearchOptions.ItemHeight = 30
        Me.ComboBoxSearchOptions.Items.AddRange(New Object() {"First Name Search", "Last Name Search"})
        Me.ComboBoxSearchOptions.Location = New System.Drawing.Point(496, 25)
        Me.ComboBoxSearchOptions.Name = "ComboBoxSearchOptions"
        Me.ComboBoxSearchOptions.Size = New System.Drawing.Size(239, 36)
        Me.ComboBoxSearchOptions.TabIndex = 839
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.White
        Me.lblAddress.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(195, 265)
        Me.lblAddress.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(18, 18)
        Me.lblAddress.TabIndex = 829
        Me.lblAddress.Text = "="
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClearInfoExisting
        '
        Me.ClearInfoExisting.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ClearInfoExisting.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearInfoExisting.Location = New System.Drawing.Point(749, 30)
        Me.ClearInfoExisting.Name = "ClearInfoExisting"
        Me.ClearInfoExisting.Size = New System.Drawing.Size(200, 30)
        Me.ClearInfoExisting.TabIndex = 838
        Me.ClearInfoExisting.Text = "CLEAR INFORMATION"
        Me.ClearInfoExisting.UseVisualStyleBackColor = True
        '
        'lblMN
        '
        Me.lblMN.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMN.AutoSize = True
        Me.lblMN.BackColor = System.Drawing.Color.White
        Me.lblMN.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMN.Location = New System.Drawing.Point(566, 265)
        Me.lblMN.MaximumSize = New System.Drawing.Size(150, 200)
        Me.lblMN.Name = "lblMN"
        Me.lblMN.Size = New System.Drawing.Size(18, 18)
        Me.lblMN.TabIndex = 836
        Me.lblMN.Text = "="
        '
        'lblCitizenship
        '
        Me.lblCitizenship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCitizenship.AutoSize = True
        Me.lblCitizenship.BackColor = System.Drawing.Color.White
        Me.lblCitizenship.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCitizenship.Location = New System.Drawing.Point(566, 221)
        Me.lblCitizenship.MaximumSize = New System.Drawing.Size(150, 200)
        Me.lblCitizenship.Name = "lblCitizenship"
        Me.lblCitizenship.Size = New System.Drawing.Size(18, 18)
        Me.lblCitizenship.TabIndex = 835
        Me.lblCitizenship.Text = "="
        '
        'lblPhilhealthID
        '
        Me.lblPhilhealthID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPhilhealthID.AutoSize = True
        Me.lblPhilhealthID.BackColor = System.Drawing.Color.White
        Me.lblPhilhealthID.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhilhealthID.Location = New System.Drawing.Point(894, 265)
        Me.lblPhilhealthID.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblPhilhealthID.Name = "lblPhilhealthID"
        Me.lblPhilhealthID.Size = New System.Drawing.Size(18, 18)
        Me.lblPhilhealthID.TabIndex = 834
        Me.lblPhilhealthID.Text = "="
        '
        'lblDOB
        '
        Me.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDOB.AutoSize = True
        Me.lblDOB.BackColor = System.Drawing.Color.White
        Me.lblDOB.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(566, 177)
        Me.lblDOB.MaximumSize = New System.Drawing.Size(150, 200)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(18, 18)
        Me.lblDOB.TabIndex = 833
        Me.lblDOB.Text = "="
        '
        'lblReligon
        '
        Me.lblReligon.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblReligon.AutoSize = True
        Me.lblReligon.BackColor = System.Drawing.Color.White
        Me.lblReligon.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReligon.Location = New System.Drawing.Point(894, 221)
        Me.lblReligon.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblReligon.Name = "lblReligon"
        Me.lblReligon.Size = New System.Drawing.Size(18, 18)
        Me.lblReligon.TabIndex = 832
        Me.lblReligon.Text = "="
        '
        'lblMiddlename
        '
        Me.lblMiddlename.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMiddlename.AutoSize = True
        Me.lblMiddlename.BackColor = System.Drawing.Color.White
        Me.lblMiddlename.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddlename.Location = New System.Drawing.Point(566, 133)
        Me.lblMiddlename.MaximumSize = New System.Drawing.Size(150, 200)
        Me.lblMiddlename.Name = "lblMiddlename"
        Me.lblMiddlename.Size = New System.Drawing.Size(18, 18)
        Me.lblMiddlename.TabIndex = 831
        Me.lblMiddlename.Text = "="
        '
        'lblAge
        '
        Me.lblAge.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.White
        Me.lblAge.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(894, 177)
        Me.lblAge.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(18, 18)
        Me.lblAge.TabIndex = 830
        Me.lblAge.Text = "="
        '
        'lblLastname
        '
        Me.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLastname.AutoSize = True
        Me.lblLastname.BackColor = System.Drawing.Color.White
        Me.lblLastname.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.Location = New System.Drawing.Point(894, 132)
        Me.lblLastname.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(18, 18)
        Me.lblLastname.TabIndex = 837
        Me.lblLastname.Text = "="
        '
        'lblMS
        '
        Me.lblMS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMS.AutoSize = True
        Me.lblMS.BackColor = System.Drawing.Color.White
        Me.lblMS.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMS.Location = New System.Drawing.Point(195, 221)
        Me.lblMS.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblMS.Name = "lblMS"
        Me.lblMS.Size = New System.Drawing.Size(18, 18)
        Me.lblMS.TabIndex = 828
        Me.lblMS.Text = "="
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.White
        Me.lblGender.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(195, 177)
        Me.lblGender.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(18, 18)
        Me.lblGender.TabIndex = 827
        Me.lblGender.Text = "="
        '
        'lblFirstname
        '
        Me.lblFirstname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.BackColor = System.Drawing.Color.White
        Me.lblFirstname.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.Location = New System.Drawing.Point(195, 133)
        Me.lblFirstname.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(18, 18)
        Me.lblFirstname.TabIndex = 826
        Me.lblFirstname.Text = "="
        '
        'lblPatientID
        '
        Me.lblPatientID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.BackColor = System.Drawing.Color.White
        Me.lblPatientID.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.Location = New System.Drawing.Point(164, 43)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(114, 18)
        Me.lblPatientID.TabIndex = 825
        Me.lblPatientID.Text = "RHU-PATIENT"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(36, 177)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 18)
        Me.Label19.TabIndex = 824
        Me.Label19.Text = "GENDER"
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(36, 265)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 18)
        Me.Label20.TabIndex = 821
        Me.Label20.Text = "ADDRESS"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(36, 221)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(153, 18)
        Me.Label21.TabIndex = 822
        Me.Label21.Text = "MARITAL STATUS"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(746, 265)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(142, 18)
        Me.Label22.TabIndex = 823
        Me.Label22.Text = "PHILHEALTH ID"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(404, 265)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(156, 18)
        Me.Label23.TabIndex = 820
        Me.Label23.Text = "MOBILE NUMBER"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(746, 221)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(91, 18)
        Me.Label24.TabIndex = 816
        Me.Label24.Text = "RELIGION"
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(404, 221)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(115, 18)
        Me.Label25.TabIndex = 817
        Me.Label25.Text = "CITIZENSHIP"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(746, 177)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 18)
        Me.Label26.TabIndex = 818
        Me.Label26.Text = "AGE"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(404, 177)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(138, 18)
        Me.Label27.TabIndex = 819
        Me.Label27.Text = "DATE OF BIRTH"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(746, 132)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(105, 18)
        Me.Label28.TabIndex = 813
        Me.Label28.Text = "LAST NAME"
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(404, 133)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(133, 18)
        Me.Label29.TabIndex = 815
        Me.Label29.Text = "MIDDLE NAME"
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(36, 133)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(111, 18)
        Me.Label30.TabIndex = 814
        Me.Label30.Text = "FIRST NAME"
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(35, 40)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(123, 22)
        Me.Label31.TabIndex = 812
        Me.Label31.Text = "PATIENT-ID"
        '
        'PatientSeachList
        '
        Me.PatientSeachList.Dock = System.Windows.Forms.DockStyle.Right
        Me.PatientSeachList.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientSeachList.ForeColor = System.Drawing.Color.Black
        Me.PatientSeachList.FormattingEnabled = True
        Me.PatientSeachList.HorizontalScrollbar = True
        Me.PatientSeachList.ItemHeight = 17
        Me.PatientSeachList.Location = New System.Drawing.Point(1081, 22)
        Me.PatientSeachList.Name = "PatientSeachList"
        Me.PatientSeachList.Size = New System.Drawing.Size(300, 325)
        Me.PatientSeachList.Sorted = True
        Me.PatientSeachList.TabIndex = 811
        '
        'GroupBoxVital
        '
        Me.GroupBoxVital.BackColor = System.Drawing.Color.White
        Me.GroupBoxVital.Controls.Add(Me.cmbDoctors)
        Me.GroupBoxVital.Controls.Add(Me.SaveVitals)
        Me.GroupBoxVital.Controls.Add(Me.Label3)
        Me.GroupBoxVital.Controls.Add(Me.Label16)
        Me.GroupBoxVital.Controls.Add(Me.lblClinicName)
        Me.GroupBoxVital.Controls.Add(Me.lblSelectedDoctorID)
        Me.GroupBoxVital.Controls.Add(Me.Label1)
        Me.GroupBoxVital.Controls.Add(Me.txtDiagnosis)
        Me.GroupBoxVital.Controls.Add(Me.Label2)
        Me.GroupBoxVital.Controls.Add(Me.txtHeight)
        Me.GroupBoxVital.Controls.Add(Me.txtPulseRate)
        Me.GroupBoxVital.Controls.Add(Me.txtWeight)
        Me.GroupBoxVital.Controls.Add(Me.txtRespirationRate)
        Me.GroupBoxVital.Controls.Add(Me.txtBloodPressure)
        Me.GroupBoxVital.Controls.Add(Me.txtBodyTemp)
        Me.GroupBoxVital.Controls.Add(Me.Label5)
        Me.GroupBoxVital.Controls.Add(Me.Label6)
        Me.GroupBoxVital.Controls.Add(Me.Label7)
        Me.GroupBoxVital.Controls.Add(Me.Label15)
        Me.GroupBoxVital.Controls.Add(Me.Label17)
        Me.GroupBoxVital.Controls.Add(Me.Label18)
        Me.GroupBoxVital.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxVital.Enabled = False
        Me.GroupBoxVital.Location = New System.Drawing.Point(0, 350)
        Me.GroupBoxVital.Name = "GroupBoxVital"
        Me.GroupBoxVital.Size = New System.Drawing.Size(1384, 411)
        Me.GroupBoxVital.TabIndex = 5
        Me.GroupBoxVital.TabStop = False
        Me.GroupBoxVital.Text = "VITAL SIGNS"
        '
        'cmbDoctors
        '
        Me.cmbDoctors.BackColor = System.Drawing.Color.Transparent
        Me.cmbDoctors.BorderColor = System.Drawing.Color.Black
        Me.cmbDoctors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDoctors.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDoctors.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDoctors.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoctors.ForeColor = System.Drawing.Color.Black
        Me.cmbDoctors.ItemHeight = 30
        Me.cmbDoctors.Location = New System.Drawing.Point(960, 61)
        Me.cmbDoctors.Name = "cmbDoctors"
        Me.cmbDoctors.Size = New System.Drawing.Size(250, 36)
        Me.cmbDoctors.TabIndex = 528
        '
        'SaveVitals
        '
        Me.SaveVitals.Enabled = False
        Me.SaveVitals.Location = New System.Drawing.Point(1009, 336)
        Me.SaveVitals.Name = "SaveVitals"
        Me.SaveVitals.Size = New System.Drawing.Size(200, 40)
        Me.SaveVitals.TabIndex = 527
        Me.SaveVitals.Text = "SEND TO DOCTOR"
        Me.SaveVitals.UseVisualStyleBackColor = True
        Me.SaveVitals.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(925, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(339, 18)
        Me.Label3.TabIndex = 526
        Me.Label3.Text = "SELECT DOCTOR TO CHECKUP PATIENT"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(228, 230)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 12)
        Me.Label16.TabIndex = 524
        Me.Label16.Text = "WEIGHT BY KG"
        '
        'lblClinicName
        '
        Me.lblClinicName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblClinicName.AutoSize = True
        Me.lblClinicName.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClinicName.Location = New System.Drawing.Point(1216, 60)
        Me.lblClinicName.MaximumSize = New System.Drawing.Size(150, 150)
        Me.lblClinicName.Name = "lblClinicName"
        Me.lblClinicName.Size = New System.Drawing.Size(65, 18)
        Me.lblClinicName.TabIndex = 523
        Me.lblClinicName.Text = "CLINIC"
        '
        'lblSelectedDoctorID
        '
        Me.lblSelectedDoctorID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSelectedDoctorID.AutoSize = True
        Me.lblSelectedDoctorID.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDoctorID.Location = New System.Drawing.Point(855, 61)
        Me.lblSelectedDoctorID.MaximumSize = New System.Drawing.Size(100, 100)
        Me.lblSelectedDoctorID.Name = "lblSelectedDoctorID"
        Me.lblSelectedDoctorID.Size = New System.Drawing.Size(57, 18)
        Me.lblSelectedDoctorID.TabIndex = 523
        Me.lblSelectedDoctorID.Text = "DOC-ID"
        Me.lblSelectedDoctorID.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(583, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 12)
        Me.Label1.TabIndex = 522
        Me.Label1.Text = "HEIGHT BY CM"
        '
        'txtDiagnosis
        '
        Me.txtDiagnosis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtDiagnosis.Animated = True
        Me.txtDiagnosis.BorderColor = System.Drawing.Color.Black
        Me.txtDiagnosis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiagnosis.DefaultText = ""
        Me.txtDiagnosis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDiagnosis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDiagnosis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDiagnosis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDiagnosis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDiagnosis.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiagnosis.ForeColor = System.Drawing.Color.Black
        Me.txtDiagnosis.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDiagnosis.Location = New System.Drawing.Point(230, 265)
        Me.txtDiagnosis.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDiagnosis.MaxLength = 500
        Me.txtDiagnosis.Multiline = True
        Me.txtDiagnosis.Name = "txtDiagnosis"
        Me.txtDiagnosis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiagnosis.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtDiagnosis.PlaceholderText = ""
        Me.txtDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDiagnosis.SelectedText = ""
        Me.txtDiagnosis.Size = New System.Drawing.Size(505, 111)
        Me.txtDiagnosis.TabIndex = 521
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 18)
        Me.Label2.TabIndex = 520
        Me.Label2.Text = "PATIENT SYSMTOPMS"
        '
        'txtHeight
        '
        Me.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtHeight.Animated = True
        Me.txtHeight.BorderColor = System.Drawing.Color.Black
        Me.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHeight.DefaultText = ""
        Me.txtHeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtHeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtHeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHeight.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtHeight.ForeColor = System.Drawing.Color.Black
        Me.txtHeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHeight.Location = New System.Drawing.Point(585, 192)
        Me.txtHeight.MaxLength = 10
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHeight.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtHeight.PlaceholderText = ""
        Me.txtHeight.SelectedText = ""
        Me.txtHeight.Size = New System.Drawing.Size(150, 35)
        Me.txtHeight.TabIndex = 517
        '
        'txtPulseRate
        '
        Me.txtPulseRate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtPulseRate.Animated = True
        Me.txtPulseRate.BorderColor = System.Drawing.Color.Black
        Me.txtPulseRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPulseRate.DefaultText = ""
        Me.txtPulseRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPulseRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPulseRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPulseRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPulseRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPulseRate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtPulseRate.ForeColor = System.Drawing.Color.Black
        Me.txtPulseRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPulseRate.Location = New System.Drawing.Point(585, 125)
        Me.txtPulseRate.MaxLength = 10
        Me.txtPulseRate.Name = "txtPulseRate"
        Me.txtPulseRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPulseRate.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPulseRate.PlaceholderText = ""
        Me.txtPulseRate.SelectedText = ""
        Me.txtPulseRate.Size = New System.Drawing.Size(150, 35)
        Me.txtPulseRate.TabIndex = 518
        '
        'txtWeight
        '
        Me.txtWeight.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtWeight.Animated = True
        Me.txtWeight.BorderColor = System.Drawing.Color.Black
        Me.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWeight.DefaultText = ""
        Me.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtWeight.ForeColor = System.Drawing.Color.Black
        Me.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWeight.Location = New System.Drawing.Point(230, 192)
        Me.txtWeight.MaxLength = 10
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWeight.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtWeight.PlaceholderText = ""
        Me.txtWeight.SelectedText = ""
        Me.txtWeight.Size = New System.Drawing.Size(150, 35)
        Me.txtWeight.TabIndex = 515
        '
        'txtRespirationRate
        '
        Me.txtRespirationRate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRespirationRate.Animated = True
        Me.txtRespirationRate.BorderColor = System.Drawing.Color.Black
        Me.txtRespirationRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRespirationRate.DefaultText = ""
        Me.txtRespirationRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRespirationRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRespirationRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRespirationRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRespirationRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespirationRate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtRespirationRate.ForeColor = System.Drawing.Color.Black
        Me.txtRespirationRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespirationRate.Location = New System.Drawing.Point(230, 125)
        Me.txtRespirationRate.MaxLength = 10
        Me.txtRespirationRate.Name = "txtRespirationRate"
        Me.txtRespirationRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRespirationRate.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtRespirationRate.PlaceholderText = ""
        Me.txtRespirationRate.SelectedText = ""
        Me.txtRespirationRate.Size = New System.Drawing.Size(150, 35)
        Me.txtRespirationRate.TabIndex = 516
        '
        'txtBloodPressure
        '
        Me.txtBloodPressure.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBloodPressure.Animated = True
        Me.txtBloodPressure.BorderColor = System.Drawing.Color.Black
        Me.txtBloodPressure.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBloodPressure.DefaultText = ""
        Me.txtBloodPressure.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBloodPressure.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBloodPressure.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBloodPressure.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBloodPressure.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBloodPressure.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtBloodPressure.ForeColor = System.Drawing.Color.Black
        Me.txtBloodPressure.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBloodPressure.Location = New System.Drawing.Point(585, 59)
        Me.txtBloodPressure.MaxLength = 10
        Me.txtBloodPressure.Name = "txtBloodPressure"
        Me.txtBloodPressure.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBloodPressure.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtBloodPressure.PlaceholderText = ""
        Me.txtBloodPressure.SelectedText = ""
        Me.txtBloodPressure.Size = New System.Drawing.Size(150, 35)
        Me.txtBloodPressure.TabIndex = 519
        '
        'txtBodyTemp
        '
        Me.txtBodyTemp.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtBodyTemp.Animated = True
        Me.txtBodyTemp.BorderColor = System.Drawing.Color.Black
        Me.txtBodyTemp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBodyTemp.DefaultText = ""
        Me.txtBodyTemp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBodyTemp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBodyTemp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBodyTemp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBodyTemp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBodyTemp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtBodyTemp.ForeColor = System.Drawing.Color.Black
        Me.txtBodyTemp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBodyTemp.Location = New System.Drawing.Point(230, 58)
        Me.txtBodyTemp.MaxLength = 10
        Me.txtBodyTemp.Name = "txtBodyTemp"
        Me.txtBodyTemp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBodyTemp.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtBodyTemp.PlaceholderText = ""
        Me.txtBodyTemp.SelectedText = ""
        Me.txtBodyTemp.Size = New System.Drawing.Size(150, 35)
        Me.txtBodyTemp.TabIndex = 514
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(404, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 511
        Me.Label5.Text = "HEIGHT"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(404, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 18)
        Me.Label6.TabIndex = 512
        Me.Label6.Text = "BLOOOD PRESSURE"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 509
        Me.Label7.Text = "WEIGHT"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(36, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(171, 18)
        Me.Label15.TabIndex = 510
        Me.Label15.Text = "RESPIRATION RATE"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(404, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 18)
        Me.Label17.TabIndex = 508
        Me.Label17.Text = "PULSE RATE"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(36, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(188, 18)
        Me.Label18.TabIndex = 513
        Me.Label18.Text = "BODY TEMPERATURE"
        '
        'OldPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1384, 761)
        Me.Controls.Add(Me.GroupBoxVital)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "OldPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OldPatient"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxVital.ResumeLayout(False)
        Me.GroupBoxVital.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxSearchOptions As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents ClearInfoExisting As Button
    Friend WithEvents lblMN As Label
    Friend WithEvents lblCitizenship As Label
    Friend WithEvents lblPhilhealthID As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblReligon As Label
    Friend WithEvents lblMiddlename As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblMS As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblFirstname As Label
    Friend WithEvents lblPatientID As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents PatientSeachList As ListBox
    Friend WithEvents GroupBoxVital As GroupBox
    Friend WithEvents SaveVitals As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblClinicName As Label
    Friend WithEvents lblSelectedDoctorID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiagnosis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHeight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPulseRate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtWeight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRespirationRate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBloodPressure As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBodyTemp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbDoctors As Guna.UI2.WinForms.Guna2ComboBox
End Class
