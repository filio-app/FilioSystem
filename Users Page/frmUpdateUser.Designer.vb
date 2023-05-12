<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateUser
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
        Dim Animation2 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateUser))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnUpdateUserInfo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdateUserPassword = New Guna.UI2.WinForms.Guna2Button()
        Me.BunifuPagesUser = New Bunifu.UI.WinForms.BunifuPages()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.panelUserInfo = New System.Windows.Forms.Panel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.panelUserPass = New System.Windows.Forms.Panel()
        Me.panelBack = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        Me.BunifuPagesUser.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.panelBack.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 40
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.lblHeader)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(757, 71)
        Me.Guna2Panel1.TabIndex = 43
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderRadius = 8
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Gainsboro
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(695, 15)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 18
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Inter", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(33, 19)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(186, 34)
        Me.lblHeader.TabIndex = 16
        Me.lblHeader.Text = "Update User"
        '
        'btnUpdateUserInfo
        '
        Me.btnUpdateUserInfo.Animated = True
        Me.btnUpdateUserInfo.BorderRadius = 8
        Me.btnUpdateUserInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnUpdateUserInfo.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnUpdateUserInfo.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnUpdateUserInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateUserInfo.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUpdateUserInfo.CustomImages.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnUpdateUserInfo.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnUpdateUserInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateUserInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateUserInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateUserInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateUserInfo.FillColor = System.Drawing.Color.Transparent
        Me.btnUpdateUserInfo.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnUpdateUserInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnUpdateUserInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnUpdateUserInfo.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnUpdateUserInfo.Location = New System.Drawing.Point(12, 11)
        Me.btnUpdateUserInfo.Name = "btnUpdateUserInfo"
        Me.btnUpdateUserInfo.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnUpdateUserInfo.Size = New System.Drawing.Size(280, 61)
        Me.btnUpdateUserInfo.TabIndex = 45
        Me.btnUpdateUserInfo.Text = "User Information"
        '
        'btnUpdateUserPassword
        '
        Me.btnUpdateUserPassword.Animated = True
        Me.btnUpdateUserPassword.BorderRadius = 8
        Me.btnUpdateUserPassword.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnUpdateUserPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnUpdateUserPassword.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnUpdateUserPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateUserPassword.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUpdateUserPassword.CustomImages.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnUpdateUserPassword.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnUpdateUserPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateUserPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateUserPassword.FillColor = System.Drawing.Color.Transparent
        Me.btnUpdateUserPassword.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnUpdateUserPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnUpdateUserPassword.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnUpdateUserPassword.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnUpdateUserPassword.Location = New System.Drawing.Point(317, 11)
        Me.btnUpdateUserPassword.Name = "btnUpdateUserPassword"
        Me.btnUpdateUserPassword.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnUpdateUserPassword.Size = New System.Drawing.Size(280, 61)
        Me.btnUpdateUserPassword.TabIndex = 44
        Me.btnUpdateUserPassword.Text = "User Password"
        '
        'BunifuPagesUser
        '
        Me.BunifuPagesUser.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.BunifuPagesUser.AllowTransitions = True
        Me.BunifuPagesUser.Controls.Add(Me.TabPage1)
        Me.BunifuPagesUser.Controls.Add(Me.TabPage2)
        Me.BunifuPagesUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuPagesUser.Location = New System.Drawing.Point(0, 169)
        Me.BunifuPagesUser.Multiline = True
        Me.BunifuPagesUser.Name = "BunifuPagesUser"
        Me.BunifuPagesUser.Page = Me.TabPage2
        Me.BunifuPagesUser.PageIndex = 1
        Me.BunifuPagesUser.PageName = "TabPage2"
        Me.BunifuPagesUser.PageTitle = "User Pass"
        Me.BunifuPagesUser.SelectedIndex = 0
        Me.BunifuPagesUser.Size = New System.Drawing.Size(757, 469)
        Me.BunifuPagesUser.TabIndex = 46
        Animation2.AnimateOnlyDifferences = False
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.BunifuPagesUser.Transition = Animation2
        Me.BunifuPagesUser.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.panelUserInfo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(749, 443)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'panelUserInfo
        '
        Me.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelUserInfo.Location = New System.Drawing.Point(0, 0)
        Me.panelUserInfo.Name = "panelUserInfo"
        Me.panelUserInfo.Size = New System.Drawing.Size(749, 443)
        Me.panelUserInfo.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.panelUserPass)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(749, 443)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User Pass"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'panelUserPass
        '
        Me.panelUserPass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelUserPass.Location = New System.Drawing.Point(0, 0)
        Me.panelUserPass.Name = "panelUserPass"
        Me.panelUserPass.Size = New System.Drawing.Size(749, 443)
        Me.panelUserPass.TabIndex = 0
        '
        'panelBack
        '
        Me.panelBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.panelBack.Controls.Add(Me.btnUpdateUserInfo)
        Me.panelBack.Controls.Add(Me.btnUpdateUserPassword)
        Me.panelBack.Location = New System.Drawing.Point(74, 79)
        Me.panelBack.Name = "panelBack"
        Me.panelBack.Size = New System.Drawing.Size(612, 84)
        Me.panelBack.TabIndex = 50
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 25
        Me.Guna2Elipse2.TargetControl = Me.panelBack
        '
        'frmUpdateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(757, 638)
        Me.Controls.Add(Me.BunifuPagesUser)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.panelBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdateUser"
        Me.Text = "frmUpdateUser"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.BunifuPagesUser.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.panelBack.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnUpdateUserInfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdateUserPassword As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BunifuPagesUser As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents panelUserInfo As Panel
    Friend WithEvents panelUserPass As Panel
    Friend WithEvents panelBack As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
End Class
