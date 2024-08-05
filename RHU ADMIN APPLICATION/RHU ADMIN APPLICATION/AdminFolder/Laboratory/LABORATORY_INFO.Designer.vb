<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LABORATORY_INFO
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblOldAccessCode = New System.Windows.Forms.Label()
        Me.txtOldLaboratoryName = New System.Windows.Forms.Label()
        Me.txtNewLaboratoryName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewAccessCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdateLaboratory = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LaboratoryListBoxUpdate = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblDeleteAccessCode = New System.Windows.Forms.Label()
        Me.lblDeleteLaboratoryName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDeleteLaboratory = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LaboratoryListDelete = New System.Windows.Forms.ListBox()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage3)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(784, 461)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.Black
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.Black
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.Red
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 1
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "UPDATE CLINIC"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblOldAccessCode)
        Me.GroupBox2.Controls.Add(Me.txtOldLaboratoryName)
        Me.GroupBox2.Controls.Add(Me.txtNewLaboratoryName)
        Me.GroupBox2.Controls.Add(Me.txtNewAccessCode)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnUpdateLaboratory)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LaboratoryListBoxUpdate)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(770, 407)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UPDATE CLINIC"
        '
        'lblOldAccessCode
        '
        Me.lblOldAccessCode.AutoSize = True
        Me.lblOldAccessCode.Location = New System.Drawing.Point(40, 172)
        Me.lblOldAccessCode.Name = "lblOldAccessCode"
        Me.lblOldAccessCode.Size = New System.Drawing.Size(44, 18)
        Me.lblOldAccessCode.TabIndex = 24
        Me.lblOldAccessCode.Text = "OLD"
        '
        'txtOldLaboratoryName
        '
        Me.txtOldLaboratoryName.AutoSize = True
        Me.txtOldLaboratoryName.Location = New System.Drawing.Point(40, 100)
        Me.txtOldLaboratoryName.Name = "txtOldLaboratoryName"
        Me.txtOldLaboratoryName.Size = New System.Drawing.Size(44, 18)
        Me.txtOldLaboratoryName.TabIndex = 24
        Me.txtOldLaboratoryName.Text = "OLD"
        '
        'txtNewLaboratoryName
        '
        Me.txtNewLaboratoryName.Animated = True
        Me.txtNewLaboratoryName.BorderColor = System.Drawing.Color.Black
        Me.txtNewLaboratoryName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNewLaboratoryName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewLaboratoryName.DefaultText = ""
        Me.txtNewLaboratoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewLaboratoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewLaboratoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewLaboratoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewLaboratoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewLaboratoryName.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNewLaboratoryName.ForeColor = System.Drawing.Color.Black
        Me.txtNewLaboratoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewLaboratoryName.Location = New System.Drawing.Point(220, 80)
        Me.txtNewLaboratoryName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNewLaboratoryName.Name = "txtNewLaboratoryName"
        Me.txtNewLaboratoryName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewLaboratoryName.PlaceholderText = ""
        Me.txtNewLaboratoryName.SelectedText = ""
        Me.txtNewLaboratoryName.Size = New System.Drawing.Size(200, 38)
        Me.txtNewLaboratoryName.TabIndex = 22
        '
        'txtNewAccessCode
        '
        Me.txtNewAccessCode.Animated = True
        Me.txtNewAccessCode.BorderColor = System.Drawing.Color.Black
        Me.txtNewAccessCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewAccessCode.DefaultText = ""
        Me.txtNewAccessCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewAccessCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewAccessCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewAccessCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewAccessCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewAccessCode.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNewAccessCode.ForeColor = System.Drawing.Color.Black
        Me.txtNewAccessCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewAccessCode.Location = New System.Drawing.Point(220, 152)
        Me.txtNewAccessCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNewAccessCode.Name = "txtNewAccessCode"
        Me.txtNewAccessCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewAccessCode.PlaceholderText = ""
        Me.txtNewAccessCode.SelectedText = ""
        Me.txtNewAccessCode.Size = New System.Drawing.Size(200, 38)
        Me.txtNewAccessCode.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "CLINIC NAME NEW"
        '
        'btnUpdateLaboratory
        '
        Me.btnUpdateLaboratory.Location = New System.Drawing.Point(220, 223)
        Me.btnUpdateLaboratory.Name = "btnUpdateLaboratory"
        Me.btnUpdateLaboratory.Size = New System.Drawing.Size(200, 35)
        Me.btnUpdateLaboratory.TabIndex = 21
        Me.btnUpdateLaboratory.Text = "UPDATE CLINIC"
        Me.btnUpdateLaboratory.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "NEW ACCESS CODE"
        '
        'LaboratoryListBoxUpdate
        '
        Me.LaboratoryListBoxUpdate.Dock = System.Windows.Forms.DockStyle.Right
        Me.LaboratoryListBoxUpdate.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaboratoryListBoxUpdate.FormattingEnabled = True
        Me.LaboratoryListBoxUpdate.ItemHeight = 15
        Me.LaboratoryListBoxUpdate.Location = New System.Drawing.Point(467, 22)
        Me.LaboratoryListBoxUpdate.Name = "LaboratoryListBoxUpdate"
        Me.LaboratoryListBoxUpdate.ScrollAlwaysVisible = True
        Me.LaboratoryListBoxUpdate.Size = New System.Drawing.Size(300, 382)
        Me.LaboratoryListBoxUpdate.TabIndex = 13
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(776, 413)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DELETE CLINIC"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblDeleteAccessCode)
        Me.GroupBox3.Controls.Add(Me.lblDeleteLaboratoryName)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnDeleteLaboratory)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.LaboratoryListDelete)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(770, 407)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DELETE LABARATORY"
        '
        'lblDeleteAccessCode
        '
        Me.lblDeleteAccessCode.AutoSize = True
        Me.lblDeleteAccessCode.Location = New System.Drawing.Point(40, 172)
        Me.lblDeleteAccessCode.Name = "lblDeleteAccessCode"
        Me.lblDeleteAccessCode.Size = New System.Drawing.Size(18, 18)
        Me.lblDeleteAccessCode.TabIndex = 24
        Me.lblDeleteAccessCode.Text = "="
        '
        'lblDeleteLaboratoryName
        '
        Me.lblDeleteLaboratoryName.AutoSize = True
        Me.lblDeleteLaboratoryName.Location = New System.Drawing.Point(40, 100)
        Me.lblDeleteLaboratoryName.Name = "lblDeleteLaboratoryName"
        Me.lblDeleteLaboratoryName.Size = New System.Drawing.Size(18, 18)
        Me.lblDeleteLaboratoryName.TabIndex = 24
        Me.lblDeleteLaboratoryName.Text = "="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "LABORATORY NAME"
        '
        'btnDeleteLaboratory
        '
        Me.btnDeleteLaboratory.Location = New System.Drawing.Point(220, 223)
        Me.btnDeleteLaboratory.Name = "btnDeleteLaboratory"
        Me.btnDeleteLaboratory.Size = New System.Drawing.Size(200, 35)
        Me.btnDeleteLaboratory.TabIndex = 21
        Me.btnDeleteLaboratory.Text = "DELETE CLINIC"
        Me.btnDeleteLaboratory.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "ACCESS CODE"
        '
        'LaboratoryListDelete
        '
        Me.LaboratoryListDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.LaboratoryListDelete.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaboratoryListDelete.FormattingEnabled = True
        Me.LaboratoryListDelete.ItemHeight = 15
        Me.LaboratoryListDelete.Location = New System.Drawing.Point(467, 22)
        Me.LaboratoryListDelete.Name = "LaboratoryListDelete"
        Me.LaboratoryListDelete.ScrollAlwaysVisible = True
        Me.LaboratoryListDelete.Size = New System.Drawing.Size(300, 382)
        Me.LaboratoryListDelete.TabIndex = 13
        '
        'LABORATORY_INFO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "LABORATORY_INFO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LABARATORY_INFO"
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblOldAccessCode As Label
    Friend WithEvents txtOldLaboratoryName As Label
    Friend WithEvents txtNewLaboratoryName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewAccessCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdateLaboratory As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LaboratoryListBoxUpdate As ListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblDeleteAccessCode As Label
    Friend WithEvents lblDeleteLaboratoryName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDeleteLaboratory As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents LaboratoryListDelete As ListBox
End Class
