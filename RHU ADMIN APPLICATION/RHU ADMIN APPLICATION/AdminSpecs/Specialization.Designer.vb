<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Specialization
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaritalControl = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.NurseControl = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.DoctorControl = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(551, 333)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "MARITAL STATUS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 333)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "NURSE POSITION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 333)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "DOCTOR POSITION"
        '
        'MaritalControl
        '
        Me.MaritalControl.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MaritalControl.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.MaritalControl.HoverState.ImageSize = New System.Drawing.Size(100, 100)
        Me.MaritalControl.Image = Global.RHU_ADMIN_APPLICATION.My.Resources.Resources.relationship
        Me.MaritalControl.ImageOffset = New System.Drawing.Point(0, 0)
        Me.MaritalControl.ImageRotate = 0!
        Me.MaritalControl.ImageSize = New System.Drawing.Size(100, 100)
        Me.MaritalControl.Location = New System.Drawing.Point(569, 209)
        Me.MaritalControl.Margin = New System.Windows.Forms.Padding(4)
        Me.MaritalControl.Name = "MaritalControl"
        Me.MaritalControl.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.MaritalControl.Size = New System.Drawing.Size(120, 120)
        Me.MaritalControl.TabIndex = 10
        '
        'NurseControl
        '
        Me.NurseControl.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.NurseControl.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.NurseControl.HoverState.ImageSize = New System.Drawing.Size(100, 100)
        Me.NurseControl.Image = Global.RHU_ADMIN_APPLICATION.My.Resources.Resources.nurse_2_
        Me.NurseControl.ImageOffset = New System.Drawing.Point(0, 0)
        Me.NurseControl.ImageRotate = 0!
        Me.NurseControl.ImageSize = New System.Drawing.Size(100, 100)
        Me.NurseControl.Location = New System.Drawing.Point(336, 209)
        Me.NurseControl.Margin = New System.Windows.Forms.Padding(4)
        Me.NurseControl.Name = "NurseControl"
        Me.NurseControl.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.NurseControl.Size = New System.Drawing.Size(120, 120)
        Me.NurseControl.TabIndex = 11
        '
        'DoctorControl
        '
        Me.DoctorControl.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DoctorControl.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.DoctorControl.HoverState.ImageSize = New System.Drawing.Size(100, 100)
        Me.DoctorControl.Image = Global.RHU_ADMIN_APPLICATION.My.Resources.Resources.doctor_2_
        Me.DoctorControl.ImageOffset = New System.Drawing.Point(0, 0)
        Me.DoctorControl.ImageRotate = 0!
        Me.DoctorControl.ImageSize = New System.Drawing.Size(100, 100)
        Me.DoctorControl.Location = New System.Drawing.Point(102, 209)
        Me.DoctorControl.Margin = New System.Windows.Forms.Padding(4)
        Me.DoctorControl.Name = "DoctorControl"
        Me.DoctorControl.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.DoctorControl.Size = New System.Drawing.Size(120, 120)
        Me.DoctorControl.TabIndex = 12
        '
        'Specialization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaritalControl)
        Me.Controls.Add(Me.NurseControl)
        Me.Controls.Add(Me.DoctorControl)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Specialization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USER SETUP "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MaritalControl As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents NurseControl As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents DoctorControl As Guna.UI2.WinForms.Guna2ImageButton
End Class
