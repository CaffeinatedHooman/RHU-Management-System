<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NursePosition
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
        Me.btnAddNurseSpecialization = New System.Windows.Forms.Button()
        Me.txtNurseSpecialization = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ListBoxNurseSpecializations = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtOldNurseSpecialization = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnUpdateNurseSpecialization = New System.Windows.Forms.Button()
        Me.txtNewNurseSpecialization = New Guna.UI2.WinForms.Guna2TextBox()
        Me.NurseSpecializationListBoxUpdate = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtDELNurseSpecialization = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnDeleteNurseSpecialization = New System.Windows.Forms.Button()
        Me.NurseSpecializationDelete = New System.Windows.Forms.ListBox()
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
        Me.Guna2TabControl1.TabIndex = 1
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnAddNurseSpecialization)
        Me.TabPage1.Controls.Add(Me.txtNurseSpecialization)
        Me.TabPage1.Controls.Add(Me.ListBoxNurseSpecializations)
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
        'btnAddNurseSpecialization
        '
        Me.btnAddNurseSpecialization.Location = New System.Drawing.Point(65, 165)
        Me.btnAddNurseSpecialization.Name = "btnAddNurseSpecialization"
        Me.btnAddNurseSpecialization.Size = New System.Drawing.Size(175, 35)
        Me.btnAddNurseSpecialization.TabIndex = 4
        Me.btnAddNurseSpecialization.Text = "SAVE POSITION"
        Me.btnAddNurseSpecialization.UseVisualStyleBackColor = True
        '
        'txtNurseSpecialization
        '
        Me.txtNurseSpecialization.BorderColor = System.Drawing.Color.Black
        Me.txtNurseSpecialization.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNurseSpecialization.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNurseSpecialization.DefaultText = ""
        Me.txtNurseSpecialization.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNurseSpecialization.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNurseSpecialization.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNurseSpecialization.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNurseSpecialization.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNurseSpecialization.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNurseSpecialization.ForeColor = System.Drawing.Color.Black
        Me.txtNurseSpecialization.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNurseSpecialization.Location = New System.Drawing.Point(53, 121)
        Me.txtNurseSpecialization.Name = "txtNurseSpecialization"
        Me.txtNurseSpecialization.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNurseSpecialization.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNurseSpecialization.PlaceholderText = ""
        Me.txtNurseSpecialization.SelectedText = ""
        Me.txtNurseSpecialization.Size = New System.Drawing.Size(222, 36)
        Me.txtNurseSpecialization.TabIndex = 3
        '
        'ListBoxNurseSpecializations
        '
        Me.ListBoxNurseSpecializations.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBoxNurseSpecializations.FormattingEnabled = True
        Me.ListBoxNurseSpecializations.HorizontalScrollbar = True
        Me.ListBoxNurseSpecializations.ItemHeight = 18
        Me.ListBoxNurseSpecializations.Location = New System.Drawing.Point(421, 38)
        Me.ListBoxNurseSpecializations.MultiColumn = True
        Me.ListBoxNurseSpecializations.Name = "ListBoxNurseSpecializations"
        Me.ListBoxNurseSpecializations.ScrollAlwaysVisible = True
        Me.ListBoxNurseSpecializations.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBoxNurseSpecializations.Size = New System.Drawing.Size(252, 472)
        Me.ListBoxNurseSpecializations.TabIndex = 2
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
        Me.Label1.Size = New System.Drawing.Size(195, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NEW NURSE POSITION"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtOldNurseSpecialization)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.btnUpdateNurseSpecialization)
        Me.TabPage2.Controls.Add(Me.txtNewNurseSpecialization)
        Me.TabPage2.Controls.Add(Me.NurseSpecializationListBoxUpdate)
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
        'txtOldNurseSpecialization
        '
        Me.txtOldNurseSpecialization.AutoSize = True
        Me.txtOldNurseSpecialization.Location = New System.Drawing.Point(151, 175)
        Me.txtOldNurseSpecialization.Name = "txtOldNurseSpecialization"
        Me.txtOldNurseSpecialization.Size = New System.Drawing.Size(89, 18)
        Me.txtOldNurseSpecialization.TabIndex = 10
        Me.txtOldNurseSpecialization.Text = "POSITION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "SELECTED"
        '
        'btnUpdateNurseSpecialization
        '
        Me.btnUpdateNurseSpecialization.Location = New System.Drawing.Point(53, 220)
        Me.btnUpdateNurseSpecialization.Name = "btnUpdateNurseSpecialization"
        Me.btnUpdateNurseSpecialization.Size = New System.Drawing.Size(175, 35)
        Me.btnUpdateNurseSpecialization.TabIndex = 8
        Me.btnUpdateNurseSpecialization.Text = "UPDATE POSITION"
        Me.btnUpdateNurseSpecialization.UseVisualStyleBackColor = True
        '
        'txtNewNurseSpecialization
        '
        Me.txtNewNurseSpecialization.BorderColor = System.Drawing.Color.Black
        Me.txtNewNurseSpecialization.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewNurseSpecialization.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewNurseSpecialization.DefaultText = ""
        Me.txtNewNurseSpecialization.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewNurseSpecialization.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewNurseSpecialization.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewNurseSpecialization.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewNurseSpecialization.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewNurseSpecialization.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewNurseSpecialization.ForeColor = System.Drawing.Color.Black
        Me.txtNewNurseSpecialization.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewNurseSpecialization.Location = New System.Drawing.Point(53, 131)
        Me.txtNewNurseSpecialization.Name = "txtNewNurseSpecialization"
        Me.txtNewNurseSpecialization.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewNurseSpecialization.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtNewNurseSpecialization.PlaceholderText = ""
        Me.txtNewNurseSpecialization.SelectedText = ""
        Me.txtNewNurseSpecialization.Size = New System.Drawing.Size(222, 36)
        Me.txtNewNurseSpecialization.TabIndex = 7
        '
        'NurseSpecializationListBoxUpdate
        '
        Me.NurseSpecializationListBoxUpdate.Dock = System.Windows.Forms.DockStyle.Right
        Me.NurseSpecializationListBoxUpdate.FormattingEnabled = True
        Me.NurseSpecializationListBoxUpdate.HorizontalScrollbar = True
        Me.NurseSpecializationListBoxUpdate.ItemHeight = 18
        Me.NurseSpecializationListBoxUpdate.Location = New System.Drawing.Point(421, 38)
        Me.NurseSpecializationListBoxUpdate.MultiColumn = True
        Me.NurseSpecializationListBoxUpdate.Name = "NurseSpecializationListBoxUpdate"
        Me.NurseSpecializationListBoxUpdate.ScrollAlwaysVisible = True
        Me.NurseSpecializationListBoxUpdate.Size = New System.Drawing.Size(252, 472)
        Me.NurseSpecializationListBoxUpdate.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(226, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "UPDATE NURSE POSITION"
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
        Me.TabPage3.Controls.Add(Me.txtDELNurseSpecialization)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.btnDeleteNurseSpecialization)
        Me.TabPage3.Controls.Add(Me.NurseSpecializationDelete)
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
        'txtDELNurseSpecialization
        '
        Me.txtDELNurseSpecialization.AutoSize = True
        Me.txtDELNurseSpecialization.Location = New System.Drawing.Point(151, 130)
        Me.txtDELNurseSpecialization.Name = "txtDELNurseSpecialization"
        Me.txtDELNurseSpecialization.Size = New System.Drawing.Size(89, 18)
        Me.txtDELNurseSpecialization.TabIndex = 12
        Me.txtDELNurseSpecialization.Text = "POSITION"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 18)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "SELECTED"
        '
        'btnDeleteNurseSpecialization
        '
        Me.btnDeleteNurseSpecialization.Location = New System.Drawing.Point(53, 170)
        Me.btnDeleteNurseSpecialization.Name = "btnDeleteNurseSpecialization"
        Me.btnDeleteNurseSpecialization.Size = New System.Drawing.Size(175, 35)
        Me.btnDeleteNurseSpecialization.TabIndex = 8
        Me.btnDeleteNurseSpecialization.Text = "DELETE POSITION"
        Me.btnDeleteNurseSpecialization.UseVisualStyleBackColor = True
        '
        'NurseSpecializationDelete
        '
        Me.NurseSpecializationDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.NurseSpecializationDelete.FormattingEnabled = True
        Me.NurseSpecializationDelete.HorizontalScrollbar = True
        Me.NurseSpecializationDelete.ItemHeight = 18
        Me.NurseSpecializationDelete.Location = New System.Drawing.Point(421, 38)
        Me.NurseSpecializationDelete.MultiColumn = True
        Me.NurseSpecializationDelete.Name = "NurseSpecializationDelete"
        Me.NurseSpecializationDelete.ScrollAlwaysVisible = True
        Me.NurseSpecializationDelete.Size = New System.Drawing.Size(252, 472)
        Me.NurseSpecializationDelete.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DELETE NURSE POSITION"
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
        'NursePosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "NursePosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NurseSetup"
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
    Friend WithEvents btnAddNurseSpecialization As Button
    Friend WithEvents txtNurseSpecialization As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ListBoxNurseSpecializations As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnUpdateNurseSpecialization As Button
    Friend WithEvents txtNewNurseSpecialization As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NurseSpecializationListBoxUpdate As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnDeleteNurseSpecialization As Button
    Friend WithEvents NurseSpecializationDelete As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOldNurseSpecialization As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDELNurseSpecialization As Label
    Friend WithEvents Label9 As Label
End Class
