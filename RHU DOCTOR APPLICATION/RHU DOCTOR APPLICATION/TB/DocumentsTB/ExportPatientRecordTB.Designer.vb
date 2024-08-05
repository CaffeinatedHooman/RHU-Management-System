<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportPatientRecordTB
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ExportRecordVTN = New System.Windows.Forms.Button()
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
        Me.PatientExportData = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PatientExportData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ExportRecordVTN)
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
        Me.GroupBox1.Size = New System.Drawing.Size(1484, 350)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PATIENT INFORMATION"
        '
        'ExportRecordVTN
        '
        Me.ExportRecordVTN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ExportRecordVTN.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportRecordVTN.Location = New System.Drawing.Point(897, 31)
        Me.ExportRecordVTN.Name = "ExportRecordVTN"
        Me.ExportRecordVTN.Size = New System.Drawing.Size(200, 30)
        Me.ExportRecordVTN.TabIndex = 840
        Me.ExportRecordVTN.Text = "EXPORT RECORD"
        Me.ExportRecordVTN.UseVisualStyleBackColor = True
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
        Me.ComboBoxSearchOptions.Location = New System.Drawing.Point(407, 25)
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
        Me.ClearInfoExisting.Location = New System.Drawing.Point(688, 32)
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
        Me.PatientSeachList.Location = New System.Drawing.Point(1181, 22)
        Me.PatientSeachList.Name = "PatientSeachList"
        Me.PatientSeachList.Size = New System.Drawing.Size(300, 325)
        Me.PatientSeachList.Sorted = True
        Me.PatientSeachList.TabIndex = 811
        '
        'PatientExportData
        '
        Me.PatientExportData.AllowUserToAddRows = False
        Me.PatientExportData.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.PatientExportData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.PatientExportData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.PatientExportData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PatientExportData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.PatientExportData.ColumnHeadersHeight = 22
        Me.PatientExportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PatientExportData.DefaultCellStyle = DataGridViewCellStyle6
        Me.PatientExportData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PatientExportData.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PatientExportData.Location = New System.Drawing.Point(0, 350)
        Me.PatientExportData.Name = "PatientExportData"
        Me.PatientExportData.ReadOnly = True
        Me.PatientExportData.RowHeadersVisible = False
        Me.PatientExportData.Size = New System.Drawing.Size(1484, 411)
        Me.PatientExportData.TabIndex = 12
        Me.PatientExportData.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White
        Me.PatientExportData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.PatientExportData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.PatientExportData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.PatientExportData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.PatientExportData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.PatientExportData.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.PatientExportData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PatientExportData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.PatientExportData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.PatientExportData.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientExportData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.PatientExportData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.PatientExportData.ThemeStyle.HeaderStyle.Height = 22
        Me.PatientExportData.ThemeStyle.ReadOnly = True
        Me.PatientExportData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PatientExportData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.PatientExportData.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientExportData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.PatientExportData.ThemeStyle.RowsStyle.Height = 22
        Me.PatientExportData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.PatientExportData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'ExportPatientRecordTB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1484, 761)
        Me.Controls.Add(Me.PatientExportData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "ExportPatientRecordTB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExportPatientRecordTB"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PatientExportData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExportRecordVTN As Button
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
    Friend WithEvents PatientExportData As Guna.UI2.WinForms.Guna2DataGridView
End Class
