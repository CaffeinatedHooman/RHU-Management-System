<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorPosition
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
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnAddDoctorSpecialization = New System.Windows.Forms.Button()
        Me.txtDoctorSpecialization = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ListBoxDoctorSpecializations = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtOldDoctorSpecialization = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnUpdateDoctorSpecialization = New System.Windows.Forms.Button()
        Me.txtNewDoctorSpecialization = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DoctorSpecializationListBoxUpdate = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtDELDoctorSpecialization = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDeleteDoctorSpecialization = New System.Windows.Forms.Button()
        Me.DeleteDoctorSpecialization = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage3)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(684, 561)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.Black
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 0
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnAddDoctorSpecialization)
        Me.TabPage1.Controls.Add(Me.txtDoctorSpecialization)
        Me.TabPage1.Controls.Add(Me.ListBoxDoctorSpecializations)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(676, 513)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ADD NEW POSITION"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnAddDoctorSpecialization
        '
        Me.btnAddDoctorSpecialization.Location = New System.Drawing.Point(65, 165)
        Me.btnAddDoctorSpecialization.Name = "btnAddDoctorSpecialization"
        Me.btnAddDoctorSpecialization.Size = New System.Drawing.Size(175, 35)
        Me.btnAddDoctorSpecialization.TabIndex = 4
        Me.btnAddDoctorSpecialization.Text = "SAVE POSITION"
        Me.btnAddDoctorSpecialization.UseVisualStyleBackColor = True
        '
        'txtDoctorSpecialization
        '
        Me.txtDoctorSpecialization.BorderColor = System.Drawing.Color.Black
        Me.txtDoctorSpecialization.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDoctorSpecialization.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDoctorSpecialization.DefaultText = ""
        Me.txtDoctorSpecialization.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDoctorSpecialization.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDoctorSpecialization.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDoctorSpecialization.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDoctorSpecialization.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDoctorSpecialization.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDoctorSpecialization.ForeColor = System.Drawing.Color.Black
        Me.txtDoctorSpecialization.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDoctorSpecialization.Location = New System.Drawing.Point(53, 121)
        Me.txtDoctorSpecialization.Name = "txtDoctorSpecialization"
        Me.txtDoctorSpecialization.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDoctorSpecialization.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtDoctorSpecialization.PlaceholderText = ""
        Me.txtDoctorSpecialization.SelectedText = ""
        Me.txtDoctorSpecialization.Size = New System.Drawing.Size(222, 36)
        Me.txtDoctorSpecialization.TabIndex = 3
        '
        'ListBoxDoctorSpecializations
        '
        Me.ListBoxDoctorSpecializations.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBoxDoctorSpecializations.FormattingEnabled = True
        Me.ListBoxDoctorSpecializations.HorizontalScrollbar = True
        Me.ListBoxDoctorSpecializations.ItemHeight = 18
        Me.ListBoxDoctorSpecializations.Location = New System.Drawing.Point(421, 38)
        Me.ListBoxDoctorSpecializations.MultiColumn = True
        Me.ListBoxDoctorSpecializations.Name = "ListBoxDoctorSpecializations"
        Me.ListBoxDoctorSpecializations.ScrollAlwaysVisible = True
        Me.ListBoxDoctorSpecializations.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBoxDoctorSpecializations.Size = New System.Drawing.Size(252, 472)
        Me.ListBoxDoctorSpecializations.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 35)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(415, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "LIST OF EXISTING POSITION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NEW DOCTOR POSITION"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtOldDoctorSpecialization)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.btnUpdateDoctorSpecialization)
        Me.TabPage2.Controls.Add(Me.txtNewDoctorSpecialization)
        Me.TabPage2.Controls.Add(Me.DoctorSpecializationListBoxUpdate)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(676, 513)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "UPDATE POSITION"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtOldDoctorSpecialization
        '
        Me.txtOldDoctorSpecialization.AutoSize = True
        Me.txtOldDoctorSpecialization.Location = New System.Drawing.Point(151, 169)
        Me.txtOldDoctorSpecialization.Name = "txtOldDoctorSpecialization"
        Me.txtOldDoctorSpecialization.Size = New System.Drawing.Size(89, 18)
        Me.txtOldDoctorSpecialization.TabIndex = 12
        Me.txtOldDoctorSpecialization.Text = "POSITION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "SELECTED"
        '
        'btnUpdateDoctorSpecialization
        '
        Me.btnUpdateDoctorSpecialization.Location = New System.Drawing.Point(53, 201)
        Me.btnUpdateDoctorSpecialization.Name = "btnUpdateDoctorSpecialization"
        Me.btnUpdateDoctorSpecialization.Size = New System.Drawing.Size(175, 35)
        Me.btnUpdateDoctorSpecialization.TabIndex = 8
        Me.btnUpdateDoctorSpecialization.Text = "SAVE POSITION"
        Me.btnUpdateDoctorSpecialization.UseVisualStyleBackColor = True
        '
        'txtNewDoctorSpecialization
        '
        Me.txtNewDoctorSpecialization.BorderColor = System.Drawing.Color.Black
        Me.txtNewDoctorSpecialization.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewDoctorSpecialization.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewDoctorSpecialization.DefaultText = ""
        Me.txtNewDoctorSpecialization.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewDoctorSpecialization.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewDoctorSpecialization.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewDoctorSpecialization.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewDoctorSpecialization.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewDoctorSpecialization.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewDoctorSpecialization.ForeColor = System.Drawing.Color.Black
        Me.txtNewDoctorSpecialization.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewDoctorSpecialization.Location = New System.Drawing.Point(53, 121)
        Me.txtNewDoctorSpecialization.Name = "txtNewDoctorSpecialization"
        Me.txtNewDoctorSpecialization.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewDoctorSpecialization.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNewDoctorSpecialization.PlaceholderText = ""
        Me.txtNewDoctorSpecialization.SelectedText = ""
        Me.txtNewDoctorSpecialization.Size = New System.Drawing.Size(222, 36)
        Me.txtNewDoctorSpecialization.TabIndex = 7
        '
        'DoctorSpecializationListBoxUpdate
        '
        Me.DoctorSpecializationListBoxUpdate.Dock = System.Windows.Forms.DockStyle.Right
        Me.DoctorSpecializationListBoxUpdate.FormattingEnabled = True
        Me.DoctorSpecializationListBoxUpdate.HorizontalScrollbar = True
        Me.DoctorSpecializationListBoxUpdate.ItemHeight = 18
        Me.DoctorSpecializationListBoxUpdate.Location = New System.Drawing.Point(421, 38)
        Me.DoctorSpecializationListBoxUpdate.MultiColumn = True
        Me.DoctorSpecializationListBoxUpdate.Name = "DoctorSpecializationListBoxUpdate"
        Me.DoctorSpecializationListBoxUpdate.ScrollAlwaysVisible = True
        Me.DoctorSpecializationListBoxUpdate.Size = New System.Drawing.Size(252, 472)
        Me.DoctorSpecializationListBoxUpdate.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "NEW DOCTOR POSITION"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(670, 35)
        Me.Panel2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(415, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "LIST OF EXISTING POSITION"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtDELDoctorSpecialization)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.btnDeleteDoctorSpecialization)
        Me.TabPage3.Controls.Add(Me.DeleteDoctorSpecialization)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(676, 513)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DELETE POSITION"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtDELDoctorSpecialization
        '
        Me.txtDELDoctorSpecialization.AutoSize = True
        Me.txtDELDoctorSpecialization.Location = New System.Drawing.Point(151, 129)
        Me.txtDELDoctorSpecialization.Name = "txtDELDoctorSpecialization"
        Me.txtDELDoctorSpecialization.Size = New System.Drawing.Size(89, 18)
        Me.txtDELDoctorSpecialization.TabIndex = 9
        Me.txtDELDoctorSpecialization.Text = "POSITION"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "SELECTED"
        '
        'btnDeleteDoctorSpecialization
        '
        Me.btnDeleteDoctorSpecialization.Location = New System.Drawing.Point(65, 165)
        Me.btnDeleteDoctorSpecialization.Name = "btnDeleteDoctorSpecialization"
        Me.btnDeleteDoctorSpecialization.Size = New System.Drawing.Size(175, 35)
        Me.btnDeleteDoctorSpecialization.TabIndex = 8
        Me.btnDeleteDoctorSpecialization.Text = "DELETE POSITION"
        Me.btnDeleteDoctorSpecialization.UseVisualStyleBackColor = True
        '
        'DeleteDoctorSpecialization
        '
        Me.DeleteDoctorSpecialization.Dock = System.Windows.Forms.DockStyle.Right
        Me.DeleteDoctorSpecialization.FormattingEnabled = True
        Me.DeleteDoctorSpecialization.HorizontalScrollbar = True
        Me.DeleteDoctorSpecialization.ItemHeight = 18
        Me.DeleteDoctorSpecialization.Location = New System.Drawing.Point(421, 38)
        Me.DeleteDoctorSpecialization.MultiColumn = True
        Me.DeleteDoctorSpecialization.Name = "DeleteDoctorSpecialization"
        Me.DeleteDoctorSpecialization.ScrollAlwaysVisible = True
        Me.DeleteDoctorSpecialization.Size = New System.Drawing.Size(252, 472)
        Me.DeleteDoctorSpecialization.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(237, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DELETE DOCTOR POSITION"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(670, 35)
        Me.Panel3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(415, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "LIST OF EXISTING POSITION"
        '
        'DoctorPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "DoctorPosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DoctorSetup"
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ListBoxDoctorSpecializations As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddDoctorSpecialization As Button
    Friend WithEvents txtDoctorSpecialization As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUpdateDoctorSpecialization As Button
    Friend WithEvents txtNewDoctorSpecialization As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DoctorSpecializationListBoxUpdate As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDeleteDoctorSpecialization As Button
    Friend WithEvents DeleteDoctorSpecialization As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOldDoctorSpecialization As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDELDoctorSpecialization As Label
    Friend WithEvents Label8 As Label
End Class
