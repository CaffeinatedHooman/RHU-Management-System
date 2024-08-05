<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DistributionMedicine
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxSearchOptions = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.PatientSeachList = New System.Windows.Forms.ListBox()
        Me.lblMN = New System.Windows.Forms.Label()
        Me.lblPhilhealthID = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblMiddlename = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblMS = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtIllnessLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtDateRecordedPast = New System.Windows.Forms.Label()
        Me.txtDoctorNamePast = New System.Windows.Forms.Label()
        Me.txtPrescriptionPast = New System.Windows.Forms.Label()
        Me.txtFindingsPast = New System.Windows.Forms.Label()
        Me.ListBoxTreatment = New System.Windows.Forms.ListBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSaveData = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTransactionID = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewSelectedMeds = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.selectedMedicineID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selectedMedicineName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selectedDosage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewMedicine = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.MedicineID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicineName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dosage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSearchMeds = New System.Windows.Forms.Button()
        Me.MedicineNameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridViewSelectedMeds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridViewMedicine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ComboBoxSearchOptions)
        Me.GroupBox1.Controls.Add(Me.PatientSeachList)
        Me.GroupBox1.Controls.Add(Me.lblMN)
        Me.GroupBox1.Controls.Add(Me.lblPhilhealthID)
        Me.GroupBox1.Controls.Add(Me.lblDOB)
        Me.GroupBox1.Controls.Add(Me.lblMiddlename)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.lblLastname)
        Me.GroupBox1.Controls.Add(Me.lblMS)
        Me.GroupBox1.Controls.Add(Me.lblGender)
        Me.GroupBox1.Controls.Add(Me.lblFirstname)
        Me.GroupBox1.Controls.Add(Me.lblPatientID)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1478, 300)
        Me.GroupBox1.TabIndex = 5
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
        Me.ComboBoxSearchOptions.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ComboBoxSearchOptions.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxSearchOptions.ItemHeight = 30
        Me.ComboBoxSearchOptions.Items.AddRange(New Object() {"First Name Search", "Last Name Search"})
        Me.ComboBoxSearchOptions.Location = New System.Drawing.Point(940, 21)
        Me.ComboBoxSearchOptions.Name = "ComboBoxSearchOptions"
        Me.ComboBoxSearchOptions.Size = New System.Drawing.Size(220, 36)
        Me.ComboBoxSearchOptions.TabIndex = 859
        '
        'PatientSeachList
        '
        Me.PatientSeachList.Dock = System.Windows.Forms.DockStyle.Right
        Me.PatientSeachList.FormattingEnabled = True
        Me.PatientSeachList.HorizontalScrollbar = True
        Me.PatientSeachList.ItemHeight = 17
        Me.PatientSeachList.Location = New System.Drawing.Point(1190, 21)
        Me.PatientSeachList.Name = "PatientSeachList"
        Me.PatientSeachList.Size = New System.Drawing.Size(285, 276)
        Me.PatientSeachList.TabIndex = 858
        '
        'lblMN
        '
        Me.lblMN.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMN.AutoSize = True
        Me.lblMN.BackColor = System.Drawing.Color.White
        Me.lblMN.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMN.Location = New System.Drawing.Point(581, 230)
        Me.lblMN.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblMN.Name = "lblMN"
        Me.lblMN.Size = New System.Drawing.Size(18, 18)
        Me.lblMN.TabIndex = 856
        Me.lblMN.Text = "="
        '
        'lblPhilhealthID
        '
        Me.lblPhilhealthID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPhilhealthID.AutoSize = True
        Me.lblPhilhealthID.BackColor = System.Drawing.Color.White
        Me.lblPhilhealthID.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhilhealthID.Location = New System.Drawing.Point(938, 231)
        Me.lblPhilhealthID.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblPhilhealthID.Name = "lblPhilhealthID"
        Me.lblPhilhealthID.Size = New System.Drawing.Size(18, 18)
        Me.lblPhilhealthID.TabIndex = 855
        Me.lblPhilhealthID.Text = "="
        '
        'lblDOB
        '
        Me.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDOB.AutoSize = True
        Me.lblDOB.BackColor = System.Drawing.Color.White
        Me.lblDOB.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(581, 187)
        Me.lblDOB.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(18, 18)
        Me.lblDOB.TabIndex = 854
        Me.lblDOB.Text = "="
        '
        'lblMiddlename
        '
        Me.lblMiddlename.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMiddlename.AutoSize = True
        Me.lblMiddlename.BackColor = System.Drawing.Color.White
        Me.lblMiddlename.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddlename.Location = New System.Drawing.Point(581, 143)
        Me.lblMiddlename.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblMiddlename.Name = "lblMiddlename"
        Me.lblMiddlename.Size = New System.Drawing.Size(18, 18)
        Me.lblMiddlename.TabIndex = 853
        Me.lblMiddlename.Text = "="
        '
        'lblAge
        '
        Me.lblAge.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.White
        Me.lblAge.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(938, 188)
        Me.lblAge.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(18, 18)
        Me.lblAge.TabIndex = 852
        Me.lblAge.Text = "="
        '
        'lblLastname
        '
        Me.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLastname.AutoSize = True
        Me.lblLastname.BackColor = System.Drawing.Color.White
        Me.lblLastname.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.Location = New System.Drawing.Point(938, 143)
        Me.lblLastname.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(18, 18)
        Me.lblLastname.TabIndex = 857
        Me.lblLastname.Text = "="
        '
        'lblMS
        '
        Me.lblMS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblMS.AutoSize = True
        Me.lblMS.BackColor = System.Drawing.Color.White
        Me.lblMS.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMS.Location = New System.Drawing.Point(210, 231)
        Me.lblMS.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblMS.Name = "lblMS"
        Me.lblMS.Size = New System.Drawing.Size(18, 18)
        Me.lblMS.TabIndex = 851
        Me.lblMS.Text = "="
        '
        'lblGender
        '
        Me.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.White
        Me.lblGender.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(210, 187)
        Me.lblGender.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(18, 18)
        Me.lblGender.TabIndex = 850
        Me.lblGender.Text = "="
        '
        'lblFirstname
        '
        Me.lblFirstname.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.BackColor = System.Drawing.Color.White
        Me.lblFirstname.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.Location = New System.Drawing.Point(210, 143)
        Me.lblFirstname.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(18, 18)
        Me.lblFirstname.TabIndex = 849
        Me.lblFirstname.Text = "="
        '
        'lblPatientID
        '
        Me.lblPatientID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.BackColor = System.Drawing.Color.White
        Me.lblPatientID.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientID.Location = New System.Drawing.Point(179, 53)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(114, 18)
        Me.lblPatientID.TabIndex = 848
        Me.lblPatientID.Text = "RHU-PATIENT"
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(51, 187)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 17)
        Me.Label19.TabIndex = 847
        Me.Label19.Text = "GENDER"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(51, 231)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(140, 17)
        Me.Label21.TabIndex = 845
        Me.Label21.Text = "MARITAL STATUS"
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(790, 231)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(142, 18)
        Me.Label22.TabIndex = 846
        Me.Label22.Text = "PHILHEALTH ID"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(419, 230)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(156, 18)
        Me.Label23.TabIndex = 844
        Me.Label23.Text = "MOBILE NUMBER"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(790, 188)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(42, 18)
        Me.Label26.TabIndex = 842
        Me.Label26.Text = "AGE"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(419, 187)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(138, 18)
        Me.Label27.TabIndex = 843
        Me.Label27.Text = "DATE OF BIRTH"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(790, 143)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(105, 18)
        Me.Label28.TabIndex = 839
        Me.Label28.Text = "LAST NAME"
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(419, 143)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(133, 18)
        Me.Label29.TabIndex = 841
        Me.Label29.Text = "MIDDLE NAME"
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(51, 143)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(98, 17)
        Me.Label30.TabIndex = 840
        Me.Label30.Text = "FIRST NAME"
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(50, 50)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(123, 22)
        Me.Label31.TabIndex = 838
        Me.Label31.Text = "PATIENT-ID"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.txtIllnessLabel)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Controls.Add(Me.txtDateRecordedPast)
        Me.GroupBox5.Controls.Add(Me.txtDoctorNamePast)
        Me.GroupBox5.Controls.Add(Me.txtPrescriptionPast)
        Me.GroupBox5.Controls.Add(Me.txtFindingsPast)
        Me.GroupBox5.Controls.Add(Me.ListBoxTreatment)
        Me.GroupBox5.Controls.Add(Me.Label41)
        Me.GroupBox5.Controls.Add(Me.Label42)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox5.Location = New System.Drawing.Point(3, 303)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1478, 300)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DOCTORS DIAGNOSIS HISTORY"
        '
        'txtIllnessLabel
        '
        Me.txtIllnessLabel.AutoSize = True
        Me.txtIllnessLabel.Location = New System.Drawing.Point(790, 82)
        Me.txtIllnessLabel.MaximumSize = New System.Drawing.Size(300, 200)
        Me.txtIllnessLabel.Name = "txtIllnessLabel"
        Me.txtIllnessLabel.Size = New System.Drawing.Size(18, 17)
        Me.txtIllnessLabel.TabIndex = 514
        Me.txtIllnessLabel.Text = "="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(790, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 513
        Me.Label1.Text = "ILLNESS"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(51, 273)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(158, 17)
        Me.Label45.TabIndex = 512
        Me.Label45.Text = "DOCTOR INCHARGE"
        '
        'txtDateRecordedPast
        '
        Me.txtDateRecordedPast.AutoSize = True
        Me.txtDateRecordedPast.Location = New System.Drawing.Point(790, 273)
        Me.txtDateRecordedPast.MaximumSize = New System.Drawing.Size(300, 200)
        Me.txtDateRecordedPast.Name = "txtDateRecordedPast"
        Me.txtDateRecordedPast.Size = New System.Drawing.Size(18, 17)
        Me.txtDateRecordedPast.TabIndex = 509
        Me.txtDateRecordedPast.Text = "="
        '
        'txtDoctorNamePast
        '
        Me.txtDoctorNamePast.AutoSize = True
        Me.txtDoctorNamePast.Location = New System.Drawing.Point(215, 273)
        Me.txtDoctorNamePast.MaximumSize = New System.Drawing.Size(300, 200)
        Me.txtDoctorNamePast.Name = "txtDoctorNamePast"
        Me.txtDoctorNamePast.Size = New System.Drawing.Size(18, 17)
        Me.txtDoctorNamePast.TabIndex = 509
        Me.txtDoctorNamePast.Text = "="
        '
        'txtPrescriptionPast
        '
        Me.txtPrescriptionPast.AutoSize = True
        Me.txtPrescriptionPast.Location = New System.Drawing.Point(419, 82)
        Me.txtPrescriptionPast.MaximumSize = New System.Drawing.Size(300, 200)
        Me.txtPrescriptionPast.Name = "txtPrescriptionPast"
        Me.txtPrescriptionPast.Size = New System.Drawing.Size(18, 17)
        Me.txtPrescriptionPast.TabIndex = 509
        Me.txtPrescriptionPast.Text = "="
        '
        'txtFindingsPast
        '
        Me.txtFindingsPast.AutoSize = True
        Me.txtFindingsPast.Location = New System.Drawing.Point(51, 82)
        Me.txtFindingsPast.MaximumSize = New System.Drawing.Size(300, 200)
        Me.txtFindingsPast.Name = "txtFindingsPast"
        Me.txtFindingsPast.Size = New System.Drawing.Size(18, 17)
        Me.txtFindingsPast.TabIndex = 509
        Me.txtFindingsPast.Text = "="
        '
        'ListBoxTreatment
        '
        Me.ListBoxTreatment.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBoxTreatment.FormattingEnabled = True
        Me.ListBoxTreatment.HorizontalScrollbar = True
        Me.ListBoxTreatment.ItemHeight = 17
        Me.ListBoxTreatment.Location = New System.Drawing.Point(1190, 21)
        Me.ListBoxTreatment.Name = "ListBoxTreatment"
        Me.ListBoxTreatment.Size = New System.Drawing.Size(285, 276)
        Me.ListBoxTreatment.TabIndex = 508
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(419, 63)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(114, 17)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "PRESCRIPTION"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(51, 63)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(78, 17)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "FINDINGS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSaveData)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblTransactionID)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 603)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1478, 500)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prescription Medication "
        '
        'btnSaveData
        '
        Me.btnSaveData.Location = New System.Drawing.Point(860, 439)
        Me.btnSaveData.Name = "btnSaveData"
        Me.btnSaveData.Size = New System.Drawing.Size(200, 55)
        Me.btnSaveData.TabIndex = 518
        Me.btnSaveData.Text = "DISPENCE MEDICINE"
        Me.btnSaveData.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(857, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 17)
        Me.Label2.TabIndex = 517
        Me.Label2.Text = "TRANSACTION ID"
        '
        'lblTransactionID
        '
        Me.lblTransactionID.AutoSize = True
        Me.lblTransactionID.Location = New System.Drawing.Point(1002, 42)
        Me.lblTransactionID.Name = "lblTransactionID"
        Me.lblTransactionID.Size = New System.Drawing.Size(59, 17)
        Me.lblTransactionID.TabIndex = 516
        Me.lblTransactionID.Text = "ID-TRC"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridViewSelectedMeds)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Location = New System.Drawing.Point(423, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(428, 476)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dispense"
        '
        'DataGridViewSelectedMeds
        '
        Me.DataGridViewSelectedMeds.AllowUserToAddRows = False
        Me.DataGridViewSelectedMeds.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridViewSelectedMeds.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewSelectedMeds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.DataGridViewSelectedMeds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewSelectedMeds.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewSelectedMeds.ColumnHeadersHeight = 25
        Me.DataGridViewSelectedMeds.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selectedMedicineID, Me.selectedMedicineName, Me.selectedDosage, Me.quantity})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewSelectedMeds.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewSelectedMeds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewSelectedMeds.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewSelectedMeds.Location = New System.Drawing.Point(3, 21)
        Me.DataGridViewSelectedMeds.Name = "DataGridViewSelectedMeds"
        Me.DataGridViewSelectedMeds.ReadOnly = True
        Me.DataGridViewSelectedMeds.RowHeadersVisible = False
        Me.DataGridViewSelectedMeds.Size = New System.Drawing.Size(422, 452)
        Me.DataGridViewSelectedMeds.TabIndex = 0
        Me.DataGridViewSelectedMeds.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White
        Me.DataGridViewSelectedMeds.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewSelectedMeds.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridViewSelectedMeds.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridViewSelectedMeds.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridViewSelectedMeds.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridViewSelectedMeds.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewSelectedMeds.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewSelectedMeds.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewSelectedMeds.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewSelectedMeds.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewSelectedMeds.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewSelectedMeds.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewSelectedMeds.ThemeStyle.HeaderStyle.Height = 25
        Me.DataGridViewSelectedMeds.ThemeStyle.ReadOnly = True
        Me.DataGridViewSelectedMeds.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewSelectedMeds.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewSelectedMeds.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewSelectedMeds.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewSelectedMeds.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridViewSelectedMeds.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DataGridViewSelectedMeds.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'selectedMedicineID
        '
        Me.selectedMedicineID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.selectedMedicineID.HeaderText = "MedicineID"
        Me.selectedMedicineID.Name = "selectedMedicineID"
        Me.selectedMedicineID.ReadOnly = True
        Me.selectedMedicineID.Visible = False
        Me.selectedMedicineID.Width = 114
        '
        'selectedMedicineName
        '
        Me.selectedMedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.selectedMedicineName.HeaderText = "MEDICINE"
        Me.selectedMedicineName.Name = "selectedMedicineName"
        Me.selectedMedicineName.ReadOnly = True
        '
        'selectedDosage
        '
        Me.selectedDosage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.selectedDosage.HeaderText = "DOSAGE(MG)"
        Me.selectedDosage.Name = "selectedDosage"
        Me.selectedDosage.ReadOnly = True
        Me.selectedDosage.Width = 129
        '
        'quantity
        '
        Me.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.quantity.HeaderText = "QTY."
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 68
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridViewMedicine)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(3, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(420, 476)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Medicine"
        '
        'DataGridViewMedicine
        '
        Me.DataGridViewMedicine.AllowUserToAddRows = False
        Me.DataGridViewMedicine.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewMedicine.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMedicine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewMedicine.ColumnHeadersHeight = 25
        Me.DataGridViewMedicine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedicineID, Me.MedicineName, Me.Dosage, Me.StockQuantity})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewMedicine.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewMedicine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewMedicine.GridColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DataGridViewMedicine.Location = New System.Drawing.Point(3, 101)
        Me.DataGridViewMedicine.Name = "DataGridViewMedicine"
        Me.DataGridViewMedicine.ReadOnly = True
        Me.DataGridViewMedicine.RowHeadersVisible = False
        Me.DataGridViewMedicine.Size = New System.Drawing.Size(414, 372)
        Me.DataGridViewMedicine.TabIndex = 1
        Me.DataGridViewMedicine.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Light
        Me.DataGridViewMedicine.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.DataGridViewMedicine.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridViewMedicine.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridViewMedicine.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridViewMedicine.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridViewMedicine.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewMedicine.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.DataGridViewMedicine.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.DataGridViewMedicine.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewMedicine.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewMedicine.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewMedicine.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewMedicine.ThemeStyle.HeaderStyle.Height = 25
        Me.DataGridViewMedicine.ThemeStyle.ReadOnly = True
        Me.DataGridViewMedicine.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewMedicine.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewMedicine.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewMedicine.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewMedicine.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridViewMedicine.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DataGridViewMedicine.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'MedicineID
        '
        Me.MedicineID.HeaderText = "MedicineID"
        Me.MedicineID.Name = "MedicineID"
        Me.MedicineID.ReadOnly = True
        Me.MedicineID.Visible = False
        '
        'MedicineName
        '
        Me.MedicineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MedicineName.HeaderText = "Medicine Name"
        Me.MedicineName.Name = "MedicineName"
        Me.MedicineName.ReadOnly = True
        '
        'Dosage
        '
        Me.Dosage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Dosage.HeaderText = "Dosage"
        Me.Dosage.Name = "Dosage"
        Me.Dosage.ReadOnly = True
        Me.Dosage.Width = 90
        '
        'StockQuantity
        '
        Me.StockQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StockQuantity.HeaderText = "Stocks"
        Me.StockQuantity.Name = "StockQuantity"
        Me.StockQuantity.ReadOnly = True
        Me.StockQuantity.Width = 84
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSearchMeds)
        Me.Panel1.Controls.Add(Me.MedicineNameTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 80)
        Me.Panel1.TabIndex = 0
        '
        'btnSearchMeds
        '
        Me.btnSearchMeds.Location = New System.Drawing.Point(318, 22)
        Me.btnSearchMeds.Name = "btnSearchMeds"
        Me.btnSearchMeds.Size = New System.Drawing.Size(83, 36)
        Me.btnSearchMeds.TabIndex = 517
        Me.btnSearchMeds.Text = "SEARCH"
        Me.btnSearchMeds.UseVisualStyleBackColor = True
        '
        'MedicineNameTextBox
        '
        Me.MedicineNameTextBox.BorderColor = System.Drawing.Color.Black
        Me.MedicineNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MedicineNameTextBox.DefaultText = ""
        Me.MedicineNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.MedicineNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MedicineNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MedicineNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MedicineNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedicineNameTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.MedicineNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedicineNameTextBox.Location = New System.Drawing.Point(13, 22)
        Me.MedicineNameTextBox.MaxLength = 50
        Me.MedicineNameTextBox.Name = "MedicineNameTextBox"
        Me.MedicineNameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MedicineNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MedicineNameTextBox.PlaceholderText = "SEARCH MEDICINE"
        Me.MedicineNameTextBox.SelectedText = ""
        Me.MedicineNameTextBox.Size = New System.Drawing.Size(300, 36)
        Me.MedicineNameTextBox.TabIndex = 516
        '
        'DistributionMedicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1501, 661)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DistributionMedicine"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DistributionMedicine"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridViewSelectedMeds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridViewMedicine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxSearchOptions As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents PatientSeachList As ListBox
    Friend WithEvents lblMN As Label
    Friend WithEvents lblPhilhealthID As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblMiddlename As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblMS As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblFirstname As Label
    Friend WithEvents lblPatientID As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtIllnessLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents txtDateRecordedPast As Label
    Friend WithEvents txtDoctorNamePast As Label
    Friend WithEvents txtPrescriptionPast As Label
    Friend WithEvents txtFindingsPast As Label
    Friend WithEvents ListBoxTreatment As ListBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridViewMedicine As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearchMeds As Button
    Friend WithEvents MedicineNameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridViewSelectedMeds As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents MedicineID As DataGridViewTextBoxColumn
    Friend WithEvents MedicineName As DataGridViewTextBoxColumn
    Friend WithEvents Dosage As DataGridViewTextBoxColumn
    Friend WithEvents StockQuantity As DataGridViewTextBoxColumn
    Friend WithEvents lblTransactionID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSaveData As Button
    Friend WithEvents selectedMedicineID As DataGridViewTextBoxColumn
    Friend WithEvents selectedMedicineName As DataGridViewTextBoxColumn
    Friend WithEvents selectedDosage As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
End Class
