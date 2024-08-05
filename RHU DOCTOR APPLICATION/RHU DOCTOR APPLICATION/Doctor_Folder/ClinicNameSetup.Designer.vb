<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClinicNameSetup
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnChangeName = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ClininNameSet = New System.Windows.Forms.Label()
        Me.LbLSelectedAccessCodeClinic1 = New System.Windows.Forms.Label()
        Me.btnSaveAccessCode = New System.Windows.Forms.Button()
        Me.cmbClinics = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 100)
        Me.Panel1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 100)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(584, 461)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.ClininNameSet)
        Me.TabPage2.Controls.Add(Me.LbLSelectedAccessCodeClinic1)
        Me.TabPage2.Controls.Add(Me.btnSaveAccessCode)
        Me.TabPage2.Controls.Add(Me.cmbClinics)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(576, 428)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CLINIC 1"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(676, 628)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "CLINIC2"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(676, 628)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "CLINIC3"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.White
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(676, 628)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "CLINIC4"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.White
        Me.TabPage6.Controls.Add(Me.Button1)
        Me.TabPage6.Controls.Add(Me.btnChangeName)
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(676, 628)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "CLINIC5"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(519, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "DOCTORPANEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnChangeName
        '
        Me.btnChangeName.Location = New System.Drawing.Point(353, 92)
        Me.btnChangeName.Name = "btnChangeName"
        Me.btnChangeName.Size = New System.Drawing.Size(130, 43)
        Me.btnChangeName.TabIndex = 1
        Me.btnChangeName.Text = "ChangeName"
        Me.btnChangeName.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(676, 628)
        Me.TabPage1.TabIndex = 6
        Me.TabPage1.Text = "CLINIC6"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ClininNameSet
        '
        Me.ClininNameSet.AutoSize = True
        Me.ClininNameSet.Location = New System.Drawing.Point(222, 45)
        Me.ClininNameSet.Name = "ClininNameSet"
        Me.ClininNameSet.Size = New System.Drawing.Size(133, 17)
        Me.ClininNameSet.TabIndex = 18
        Me.ClininNameSet.Text = "Clinic One Setup"
        '
        'LbLSelectedAccessCodeClinic1
        '
        Me.LbLSelectedAccessCodeClinic1.AutoSize = True
        Me.LbLSelectedAccessCodeClinic1.Location = New System.Drawing.Point(229, 328)
        Me.LbLSelectedAccessCodeClinic1.Name = "LbLSelectedAccessCodeClinic1"
        Me.LbLSelectedAccessCodeClinic1.Size = New System.Drawing.Size(117, 17)
        Me.LbLSelectedAccessCodeClinic1.TabIndex = 17
        Me.LbLSelectedAccessCodeClinic1.Text = "ACCESS CODE"
        Me.LbLSelectedAccessCodeClinic1.Visible = False
        '
        'btnSaveAccessCode
        '
        Me.btnSaveAccessCode.Location = New System.Drawing.Point(169, 349)
        Me.btnSaveAccessCode.Name = "btnSaveAccessCode"
        Me.btnSaveAccessCode.Size = New System.Drawing.Size(239, 35)
        Me.btnSaveAccessCode.TabIndex = 16
        Me.btnSaveAccessCode.Text = "SAVE CLINIC ACCESS"
        Me.btnSaveAccessCode.UseVisualStyleBackColor = True
        '
        'cmbClinics
        '
        Me.cmbClinics.BackColor = System.Drawing.Color.Transparent
        Me.cmbClinics.BorderColor = System.Drawing.Color.Black
        Me.cmbClinics.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbClinics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClinics.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbClinics.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbClinics.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClinics.ForeColor = System.Drawing.Color.Black
        Me.cmbClinics.ItemHeight = 30
        Me.cmbClinics.Location = New System.Drawing.Point(169, 76)
        Me.cmbClinics.Name = "cmbClinics"
        Me.cmbClinics.Size = New System.Drawing.Size(239, 36)
        Me.cmbClinics.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CLINIC NAME'S SETUP"
        '
        'ClinicNameSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ClinicNameSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClinicNameSetup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents btnChangeName As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents ClininNameSet As Label
    Friend WithEvents LbLSelectedAccessCodeClinic1 As Label
    Friend WithEvents btnSaveAccessCode As Button
    Friend WithEvents cmbClinics As Guna.UI2.WinForms.Guna2ComboBox
End Class
