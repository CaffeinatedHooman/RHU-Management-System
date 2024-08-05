<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NEW_LABARATORY
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
        Me.ListBoxLABARATORY = New System.Windows.Forms.ListBox()
        Me.txtLaboratoryName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLaboratoryAccessCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddLaboratory = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.ListBoxLABARATORY)
        Me.GroupBox1.Controls.Add(Me.txtLaboratoryName)
        Me.GroupBox1.Controls.Add(Me.txtLaboratoryAccessCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnAddLaboratory)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 461)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NEW LABARATORY"
        '
        'ListBoxLABARATORY
        '
        Me.ListBoxLABARATORY.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBoxLABARATORY.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxLABARATORY.FormattingEnabled = True
        Me.ListBoxLABARATORY.ItemHeight = 15
        Me.ListBoxLABARATORY.Location = New System.Drawing.Point(481, 22)
        Me.ListBoxLABARATORY.Name = "ListBoxLABARATORY"
        Me.ListBoxLABARATORY.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBoxLABARATORY.Size = New System.Drawing.Size(300, 436)
        Me.ListBoxLABARATORY.TabIndex = 13
        '
        'txtLaboratoryName
        '
        Me.txtLaboratoryName.Animated = True
        Me.txtLaboratoryName.BorderColor = System.Drawing.Color.Black
        Me.txtLaboratoryName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLaboratoryName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLaboratoryName.DefaultText = ""
        Me.txtLaboratoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLaboratoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLaboratoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLaboratoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLaboratoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLaboratoryName.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtLaboratoryName.ForeColor = System.Drawing.Color.Black
        Me.txtLaboratoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLaboratoryName.Location = New System.Drawing.Point(218, 80)
        Me.txtLaboratoryName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLaboratoryName.MaxLength = 50
        Me.txtLaboratoryName.Name = "txtLaboratoryName"
        Me.txtLaboratoryName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLaboratoryName.PlaceholderText = ""
        Me.txtLaboratoryName.SelectedText = ""
        Me.txtLaboratoryName.Size = New System.Drawing.Size(200, 38)
        Me.txtLaboratoryName.TabIndex = 11
        '
        'txtLaboratoryAccessCode
        '
        Me.txtLaboratoryAccessCode.Animated = True
        Me.txtLaboratoryAccessCode.BorderColor = System.Drawing.Color.Black
        Me.txtLaboratoryAccessCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLaboratoryAccessCode.DefaultText = ""
        Me.txtLaboratoryAccessCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLaboratoryAccessCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLaboratoryAccessCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLaboratoryAccessCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLaboratoryAccessCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLaboratoryAccessCode.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtLaboratoryAccessCode.ForeColor = System.Drawing.Color.Black
        Me.txtLaboratoryAccessCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLaboratoryAccessCode.Location = New System.Drawing.Point(218, 152)
        Me.txtLaboratoryAccessCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLaboratoryAccessCode.Name = "txtLaboratoryAccessCode"
        Me.txtLaboratoryAccessCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLaboratoryAccessCode.PlaceholderText = ""
        Me.txtLaboratoryAccessCode.SelectedText = ""
        Me.txtLaboratoryAccessCode.Size = New System.Drawing.Size(200, 38)
        Me.txtLaboratoryAccessCode.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "LABARATORY NAME"
        '
        'btnAddLaboratory
        '
        Me.btnAddLaboratory.Location = New System.Drawing.Point(218, 226)
        Me.btnAddLaboratory.Name = "btnAddLaboratory"
        Me.btnAddLaboratory.Size = New System.Drawing.Size(200, 35)
        Me.btnAddLaboratory.TabIndex = 10
        Me.btnAddLaboratory.Text = "ADD LABARATORY"
        Me.btnAddLaboratory.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ACCESS CODE"
        '
        'NEW_LABARATORY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MinimizeBox = False
        Me.Name = "NEW_LABARATORY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NEW_LABARATORY"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBoxLABARATORY As ListBox
    Friend WithEvents txtLaboratoryName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLaboratoryAccessCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddLaboratory As Button
    Friend WithEvents Label2 As Label
End Class
