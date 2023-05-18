<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim Animation1 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnBackup = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRestore = New Guna.UI2.WinForms.Guna2Button()
        Me.BunifuPagesSettings = New Bunifu.UI.WinForms.BunifuPages()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.panelLocation = New System.Windows.Forms.Panel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.panelBackupAndRestore = New System.Windows.Forms.Panel()
        Me.btnLocation = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBackupAndRestore = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelBack = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.BunifuPagesSettings.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.panelBackupAndRestore.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnBackup
        '
        Me.btnBackup.Animated = True
        Me.btnBackup.BorderRadius = 8
        Me.btnBackup.CustomImages.Image = Global.FilioSystem.My.Resources.Resources.database_export_custom
        Me.btnBackup.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBackup.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBackup.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnBackup.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnBackup.ForeColor = System.Drawing.Color.White
        Me.btnBackup.Location = New System.Drawing.Point(497, 236)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(160, 54)
        Me.btnBackup.TabIndex = 2
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.TextOffset = New System.Drawing.Point(12, 0)
        '
        'btnRestore
        '
        Me.btnRestore.Animated = True
        Me.btnRestore.BorderRadius = 8
        Me.btnRestore.CustomImages.Image = Global.FilioSystem.My.Resources.Resources.backup_restore_custom
        Me.btnRestore.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRestore.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRestore.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnRestore.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnRestore.ForeColor = System.Drawing.Color.White
        Me.btnRestore.Location = New System.Drawing.Point(700, 236)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(160, 54)
        Me.btnRestore.TabIndex = 3
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.TextOffset = New System.Drawing.Point(12, 0)
        '
        'BunifuPagesSettings
        '
        Me.BunifuPagesSettings.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.BunifuPagesSettings.AllowTransitions = True
        Me.BunifuPagesSettings.Controls.Add(Me.TabPage2)
        Me.BunifuPagesSettings.Controls.Add(Me.TabPage3)
        Me.BunifuPagesSettings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BunifuPagesSettings.Location = New System.Drawing.Point(0, 147)
        Me.BunifuPagesSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.BunifuPagesSettings.Multiline = True
        Me.BunifuPagesSettings.Name = "BunifuPagesSettings"
        Me.BunifuPagesSettings.Padding = New System.Drawing.Point(0, 0)
        Me.BunifuPagesSettings.Page = Me.TabPage3
        Me.BunifuPagesSettings.PageIndex = 1
        Me.BunifuPagesSettings.PageName = "TabPage3"
        Me.BunifuPagesSettings.PageTitle = "Backup and Restore"
        Me.BunifuPagesSettings.SelectedIndex = 0
        Me.BunifuPagesSettings.Size = New System.Drawing.Size(1392, 711)
        Me.BunifuPagesSettings.TabIndex = 4
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuPagesSettings.Transition = Animation1
        Me.BunifuPagesSettings.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.HorizSlide
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.panelLocation)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1384, 684)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Location"
        '
        'panelLocation
        '
        Me.panelLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.panelLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLocation.Location = New System.Drawing.Point(3, 3)
        Me.panelLocation.Margin = New System.Windows.Forms.Padding(0)
        Me.panelLocation.Name = "panelLocation"
        Me.panelLocation.Size = New System.Drawing.Size(1378, 678)
        Me.panelLocation.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.panelBackupAndRestore)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1384, 684)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Backup and Restore"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'panelBackupAndRestore
        '
        Me.panelBackupAndRestore.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.panelBackupAndRestore.Controls.Add(Me.btnRestore)
        Me.panelBackupAndRestore.Controls.Add(Me.btnBackup)
        Me.panelBackupAndRestore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBackupAndRestore.Location = New System.Drawing.Point(0, 0)
        Me.panelBackupAndRestore.Margin = New System.Windows.Forms.Padding(0)
        Me.panelBackupAndRestore.Name = "panelBackupAndRestore"
        Me.panelBackupAndRestore.Size = New System.Drawing.Size(1384, 684)
        Me.panelBackupAndRestore.TabIndex = 0
        '
        'btnLocation
        '
        Me.btnLocation.Animated = True
        Me.btnLocation.BorderRadius = 12
        Me.btnLocation.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnLocation.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnLocation.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLocation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLocation.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLocation.CustomImages.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnLocation.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnLocation.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLocation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLocation.FillColor = System.Drawing.Color.Transparent
        Me.btnLocation.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnLocation.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnLocation.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLocation.Location = New System.Drawing.Point(398, 46)
        Me.btnLocation.Name = "btnLocation"
        Me.btnLocation.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnLocation.Size = New System.Drawing.Size(280, 61)
        Me.btnLocation.TabIndex = 46
        Me.btnLocation.Text = "Location"
        '
        'btnBackupAndRestore
        '
        Me.btnBackupAndRestore.Animated = True
        Me.btnBackupAndRestore.BorderRadius = 12
        Me.btnBackupAndRestore.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnBackupAndRestore.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnBackupAndRestore.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnBackupAndRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackupAndRestore.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBackupAndRestore.CustomImages.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnBackupAndRestore.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnBackupAndRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBackupAndRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBackupAndRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackupAndRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBackupAndRestore.FillColor = System.Drawing.Color.Transparent
        Me.btnBackupAndRestore.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnBackupAndRestore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnBackupAndRestore.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnBackupAndRestore.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnBackupAndRestore.Location = New System.Drawing.Point(718, 46)
        Me.btnBackupAndRestore.Name = "btnBackupAndRestore"
        Me.btnBackupAndRestore.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnBackupAndRestore.Size = New System.Drawing.Size(280, 61)
        Me.btnBackupAndRestore.TabIndex = 48
        Me.btnBackupAndRestore.Text = "Backup && Restore"
        '
        'panelBack
        '
        Me.panelBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.panelBack.Location = New System.Drawing.Point(383, 35)
        Me.panelBack.Name = "panelBack"
        Me.panelBack.Size = New System.Drawing.Size(631, 84)
        Me.panelBack.TabIndex = 49
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 25
        Me.Guna2Elipse3.TargetControl = Me.panelBack
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1392, 858)
        Me.Controls.Add(Me.btnBackupAndRestore)
        Me.Controls.Add(Me.btnLocation)
        Me.Controls.Add(Me.BunifuPagesSettings)
        Me.Controls.Add(Me.panelBack)
        Me.Font = New System.Drawing.Font("Inter", 8.25!)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmSettings"
        Me.Text = "frmSettings"
        Me.BunifuPagesSettings.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.panelBackupAndRestore.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnBackup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRestore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BunifuPagesSettings As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnBackupAndRestore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLocation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelBackupAndRestore As Panel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents panelLocation As Panel
    Friend WithEvents panelBack As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
End Class
