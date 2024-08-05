<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PharmacyPanel
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PharmacistNameLBL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.INVENTORYlbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ImageButton4 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.INVENTORYvtn = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.ClockTime = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 120)
        Me.Panel1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PHARMACIST PANEL"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblClock)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PharmacistNameLBL)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 461)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 100)
        Me.Panel2.TabIndex = 15
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(72, 70)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(65, 18)
        Me.lblClock.TabIndex = 4
        Me.lblClock.Text = "CLOCK"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "TIME"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "USERID"
        Me.Label8.Visible = False
        '
        'PharmacistNameLBL
        '
        Me.PharmacistNameLBL.AutoSize = True
        Me.PharmacistNameLBL.Location = New System.Drawing.Point(140, 10)
        Me.PharmacistNameLBL.Name = "PharmacistNameLBL"
        Me.PharmacistNameLBL.Size = New System.Drawing.Size(59, 18)
        Me.PharmacistNameLBL.TabIndex = 1
        Me.PharmacistNameLBL.Text = "NAME"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ID"
        Me.Label7.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PHARMACIST"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.INVENTORYlbl)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Guna2ImageButton4)
        Me.Panel3.Controls.Add(Me.INVENTORYvtn)
        Me.Panel3.Controls.Add(Me.Guna2ImageButton1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 120)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 341)
        Me.Panel3.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(546, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "REPORTS"
        '
        'INVENTORYlbl
        '
        Me.INVENTORYlbl.AutoSize = True
        Me.INVENTORYlbl.Location = New System.Drawing.Point(347, 213)
        Me.INVENTORYlbl.Name = "INVENTORYlbl"
        Me.INVENTORYlbl.Size = New System.Drawing.Size(108, 18)
        Me.INVENTORYlbl.TabIndex = 18
        Me.INVENTORYlbl.Text = "INVENTORY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "DISTRIBUTION"
        '
        'Guna2ImageButton4
        '
        Me.Guna2ImageButton4.BackColor = System.Drawing.Color.Snow
        Me.Guna2ImageButton4.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton4.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton4.Image = Global.RHU_PHARMACY.My.Resources.Resources.folder_2_
        Me.Guna2ImageButton4.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton4.ImageRotate = 0!
        Me.Guna2ImageButton4.ImageSize = New System.Drawing.Size(100, 100)
        Me.Guna2ImageButton4.Location = New System.Drawing.Point(532, 110)
        Me.Guna2ImageButton4.Name = "Guna2ImageButton4"
        Me.Guna2ImageButton4.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton4.Size = New System.Drawing.Size(100, 100)
        Me.Guna2ImageButton4.TabIndex = 14
        '
        'INVENTORYvtn
        '
        Me.INVENTORYvtn.BackColor = System.Drawing.Color.Snow
        Me.INVENTORYvtn.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.INVENTORYvtn.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.INVENTORYvtn.Image = Global.RHU_PHARMACY.My.Resources.Resources.inventory
        Me.INVENTORYvtn.ImageOffset = New System.Drawing.Point(0, 0)
        Me.INVENTORYvtn.ImageRotate = 0!
        Me.INVENTORYvtn.ImageSize = New System.Drawing.Size(100, 100)
        Me.INVENTORYvtn.Location = New System.Drawing.Point(350, 110)
        Me.INVENTORYvtn.Name = "INVENTORYvtn"
        Me.INVENTORYvtn.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.INVENTORYvtn.Size = New System.Drawing.Size(100, 100)
        Me.INVENTORYvtn.TabIndex = 15
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.BackColor = System.Drawing.Color.Snow
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Image = Global.RHU_PHARMACY.My.Resources.Resources.patient
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.ImageSize = New System.Drawing.Size(100, 100)
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(163, 110)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(100, 100)
        Me.Guna2ImageButton1.TabIndex = 16
        '
        'ClockTime
        '
        '
        'PharmacyPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "PharmacyPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PHARMACY PANEL"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents INVENTORYlbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2ImageButton4 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents INVENTORYvtn As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblClock As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PharmacistNameLBL As Label
    Friend WithEvents ClockTime As Timer
End Class
