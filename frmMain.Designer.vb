<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Utilities.BunifuPages.BunifuAnimatorNS.Animation = New Utilities.BunifuPages.BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelTopLogo = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.panelLeft = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnTransaction = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnCurrentUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFiles = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.panelTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.bunifuPagesMain = New Bunifu.UI.WinForms.BunifuPages()
        Me.dashboard = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.files = New System.Windows.Forms.TabPage()
        Me.panelFiles = New System.Windows.Forms.Panel()
        Me.transaction = New System.Windows.Forms.TabPage()
        Me.users = New System.Windows.Forms.TabPage()
        Me.panelUsers = New System.Windows.Forms.Panel()
        Me.history = New System.Windows.Forms.TabPage()
        Me.panelHistory = New System.Windows.Forms.Panel()
        Me.settings = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.currentUser = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelCurrentUser = New System.Windows.Forms.Panel()
        Me.hiddenPage = New System.Windows.Forms.TabPage()
        Me.panelTransaction = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelTopLogo.SuspendLayout()
        Me.panelLeft.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.panelMain.SuspendLayout()
        Me.bunifuPagesMain.SuspendLayout()
        Me.dashboard.SuspendLayout()
        Me.files.SuspendLayout()
        Me.transaction.SuspendLayout()
        Me.users.SuspendLayout()
        Me.history.SuspendLayout()
        Me.settings.SuspendLayout()
        Me.currentUser.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'panelTopLogo
        '
        Me.panelTopLogo.Controls.Add(Me.PictureBox1)
        Me.panelTopLogo.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panelTopLogo.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.panelTopLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTopLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelTopLogo.Name = "panelTopLogo"
        Me.panelTopLogo.Size = New System.Drawing.Size(300, 91)
        Me.panelTopLogo.TabIndex = 2
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1647, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'panelLeft
        '
        Me.panelLeft.BackColor = System.Drawing.Color.White
        Me.panelLeft.Controls.Add(Me.btnTransaction)
        Me.panelLeft.Controls.Add(Me.btnHistory)
        Me.panelLeft.Controls.Add(Me.Guna2Separator2)
        Me.panelLeft.Controls.Add(Me.btnCurrentUser)
        Me.panelLeft.Controls.Add(Me.btnLogout)
        Me.panelLeft.Controls.Add(Me.Guna2Separator1)
        Me.panelLeft.Controls.Add(Me.btnSettings)
        Me.panelLeft.Controls.Add(Me.Label1)
        Me.panelLeft.Controls.Add(Me.btnUsers)
        Me.panelLeft.Controls.Add(Me.btnFiles)
        Me.panelLeft.Controls.Add(Me.btnDashboard)
        Me.panelLeft.Controls.Add(Me.panelTopLogo)
        Me.panelLeft.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panelLeft.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLeft.Location = New System.Drawing.Point(0, 37)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(300, 919)
        Me.panelLeft.TabIndex = 1
        '
        'btnTransaction
        '
        Me.btnTransaction.Animated = True
        Me.btnTransaction.BorderRadius = 8
        Me.btnTransaction.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnTransaction.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnTransaction.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransaction.CustomImages.CheckedImage = Global.FilioSystem.My.Resources.Resources.transaction_checked1
        Me.btnTransaction.CustomImages.HoveredImage = Global.FilioSystem.My.Resources.Resources.transaction_checked1
        Me.btnTransaction.CustomImages.Image = Global.FilioSystem.My.Resources.Resources.transaction_default2
        Me.btnTransaction.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTransaction.CustomImages.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnTransaction.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnTransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTransaction.FillColor = System.Drawing.Color.Transparent
        Me.btnTransaction.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnTransaction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnTransaction.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnTransaction.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnTransaction.Location = New System.Drawing.Point(23, 288)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnTransaction.Size = New System.Drawing.Size(254, 61)
        Me.btnTransaction.TabIndex = 9
        Me.btnTransaction.Text = "Transaction"
        Me.btnTransaction.TextOffset = New System.Drawing.Point(4, 2)
        '
        'btnHistory
        '
        Me.btnHistory.Animated = True
        Me.btnHistory.BorderRadius = 8
        Me.btnHistory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnHistory.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnHistory.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistory.CustomImages.CheckedImage = Global.FilioSystem.My.Resources.Resources.history_checked1
        Me.btnHistory.CustomImages.HoveredImage = Global.FilioSystem.My.Resources.Resources.history_checked1
        Me.btnHistory.CustomImages.Image = Global.FilioSystem.My.Resources.Resources.history_default1
        Me.btnHistory.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHistory.CustomImages.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnHistory.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHistory.FillColor = System.Drawing.Color.Transparent
        Me.btnHistory.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnHistory.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnHistory.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnHistory.Location = New System.Drawing.Point(23, 424)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnHistory.Size = New System.Drawing.Size(254, 61)
        Me.btnHistory.TabIndex = 8
        Me.btnHistory.Text = "History"
        Me.btnHistory.TextOffset = New System.Drawing.Point(-13, 2)
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Guna2Separator2.FillThickness = 2
        Me.Guna2Separator2.Location = New System.Drawing.Point(19, 731)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(262, 10)
        Me.Guna2Separator2.TabIndex = 7
        '
        'btnCurrentUser
        '
        Me.btnCurrentUser.Animated = True
        Me.btnCurrentUser.BorderRadius = 8
        Me.btnCurrentUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnCurrentUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnCurrentUser.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnCurrentUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCurrentUser.CustomImages.CheckedImage = Global.FilioSystem.My.Resources.Resources.user_checked1
        Me.btnCurrentUser.CustomImages.HoveredImage = Global.FilioSystem.My.Resources.Resources.user_checked1
        Me.btnCurrentUser.CustomImages.Image = Global.FilioSystem.My.Resources.Resources.user_default1
        Me.btnCurrentUser.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCurrentUser.CustomImages.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnCurrentUser.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnCurrentUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCurrentUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCurrentUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCurrentUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCurrentUser.FillColor = System.Drawing.Color.Transparent
        Me.btnCurrentUser.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnCurrentUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnCurrentUser.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnCurrentUser.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnCurrentUser.Location = New System.Drawing.Point(23, 757)
        Me.btnCurrentUser.Name = "btnCurrentUser"
        Me.btnCurrentUser.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnCurrentUser.Size = New System.Drawing.Size(254, 61)
        Me.btnCurrentUser.TabIndex = 6
        Me.btnCurrentUser.Text = "test12"
        Me.btnCurrentUser.TextOffset = New System.Drawing.Point(-26, 2)
        Me.btnCurrentUser.Visible = False
        '
        'btnLogout
        '
        Me.btnLogout.Animated = True
        Me.btnLogout.BorderRadius = 8
        Me.btnLogout.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnLogout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.CustomImages.CheckedImage = Global.FilioSystem.My.Resources.Resources.logout_checked1
        Me.btnLogout.CustomImages.HoveredImage = Global.FilioSystem.My.Resources.Resources.logout_checked1
        Me.btnLogout.CustomImages.Image = Global.FilioSystem.My.Resources.Resources.logout_default1
        Me.btnLogout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.CustomImages.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnLogout.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnLogout.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLogout.Location = New System.Drawing.Point(23, 827)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnLogout.Size = New System.Drawing.Size(254, 61)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextOffset = New System.Drawing.Point(-22, 2)
        Me.btnLogout.Visible = False
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Guna2Separator1.FillThickness = 2
        Me.Guna2Separator1.Location = New System.Drawing.Point(19, 86)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(262, 10)
        Me.Guna2Separator1.TabIndex = 4
        '
        'btnSettings
        '
        Me.btnSettings.Animated = True
        Me.btnSettings.BorderRadius = 8
        Me.btnSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnSettings.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.CustomImages.CheckedImage = Global.FilioSystem.My.Resources.Resources.settings_checked1
        Me.btnSettings.CustomImages.HoveredImage = Global.FilioSystem.My.Resources.Resources.settings_checked1
        Me.btnSettings.CustomImages.Image = Global.FilioSystem.My.Resources.Resources.settings_default1
        Me.btnSettings.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSettings.CustomImages.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnSettings.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSettings.FillColor = System.Drawing.Color.Transparent
        Me.btnSettings.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnSettings.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSettings.Location = New System.Drawing.Point(23, 491)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnSettings.Size = New System.Drawing.Size(254, 61)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextOffset = New System.Drawing.Point(-10, 2)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(41, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MENU"
        '
        'btnUsers
        '
        Me.btnUsers.Animated = True
        Me.btnUsers.BorderRadius = 8
        Me.btnUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnUsers.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsers.CustomImages.CheckedImage = Global.FilioSystem.My.Resources.Resources.user_mng_checked1
        Me.btnUsers.CustomImages.HoveredImage = Global.FilioSystem.My.Resources.Resources.user_mng_checked1
        Me.btnUsers.CustomImages.Image = Global.FilioSystem.My.Resources.Resources.user_mng_default1
        Me.btnUsers.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsers.CustomImages.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnUsers.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUsers.FillColor = System.Drawing.Color.Transparent
        Me.btnUsers.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnUsers.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnUsers.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnUsers.Location = New System.Drawing.Point(23, 356)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnUsers.Size = New System.Drawing.Size(254, 61)
        Me.btnUsers.TabIndex = 2
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextOffset = New System.Drawing.Point(-20, 2)
        '
        'btnFiles
        '
        Me.btnFiles.Animated = True
        Me.btnFiles.BorderRadius = 8
        Me.btnFiles.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnFiles.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnFiles.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiles.CustomImages.CheckedImage = Global.FilioSystem.My.Resources.Resources.folder_checked2
        Me.btnFiles.CustomImages.HoveredImage = Global.FilioSystem.My.Resources.Resources.folder_checked2
        Me.btnFiles.CustomImages.Image = Global.FilioSystem.My.Resources.Resources.folder_default2
        Me.btnFiles.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnFiles.CustomImages.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnFiles.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnFiles.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFiles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFiles.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFiles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFiles.FillColor = System.Drawing.Color.Transparent
        Me.btnFiles.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnFiles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnFiles.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnFiles.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnFiles.Location = New System.Drawing.Point(23, 220)
        Me.btnFiles.Name = "btnFiles"
        Me.btnFiles.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnFiles.Size = New System.Drawing.Size(254, 61)
        Me.btnFiles.TabIndex = 1
        Me.btnFiles.Text = "Files"
        Me.btnFiles.TextOffset = New System.Drawing.Point(-26, 2)
        '
        'btnDashboard
        '
        Me.btnDashboard.Animated = True
        Me.btnDashboard.BorderRadius = 8
        Me.btnDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnDashboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.CustomImages.CheckedImage = Global.FilioSystem.My.Resources.Resources.dashboard_checked1
        Me.btnDashboard.CustomImages.HoveredImage = Global.FilioSystem.My.Resources.Resources.dashboard_checked1
        Me.btnDashboard.CustomImages.Image = Global.FilioSystem.My.Resources.Resources.dashboard_default2
        Me.btnDashboard.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.CustomImages.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnDashboard.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashboard.FillColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnDashboard.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnDashboard.Location = New System.Drawing.Point(23, 152)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDashboard.Size = New System.Drawing.Size(254, 61)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextOffset = New System.Drawing.Point(3, 2)
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.panelTop
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.White
        Me.panelTop.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.panelTop.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.panelTop.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1700, 37)
        Me.panelTop.TabIndex = 3
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1600, 5)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 2
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2Panel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(300, 922)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1400, 34)
        Me.Guna2Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "© Filio. Copyright 2023"
        '
        'panelMain
        '
        Me.panelMain.Controls.Add(Me.bunifuPagesMain)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(300, 37)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(0)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1400, 885)
        Me.panelMain.TabIndex = 5
        '
        'bunifuPagesMain
        '
        Me.bunifuPagesMain.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.bunifuPagesMain.AllowTransitions = False
        Me.bunifuPagesMain.Controls.Add(Me.dashboard)
        Me.bunifuPagesMain.Controls.Add(Me.files)
        Me.bunifuPagesMain.Controls.Add(Me.transaction)
        Me.bunifuPagesMain.Controls.Add(Me.users)
        Me.bunifuPagesMain.Controls.Add(Me.history)
        Me.bunifuPagesMain.Controls.Add(Me.settings)
        Me.bunifuPagesMain.Controls.Add(Me.currentUser)
        Me.bunifuPagesMain.Controls.Add(Me.hiddenPage)
        Me.bunifuPagesMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bunifuPagesMain.Location = New System.Drawing.Point(0, 0)
        Me.bunifuPagesMain.Multiline = True
        Me.bunifuPagesMain.Name = "bunifuPagesMain"
        Me.bunifuPagesMain.Padding = New System.Drawing.Point(0, 0)
        Me.bunifuPagesMain.Page = Me.history
        Me.bunifuPagesMain.PageIndex = 4
        Me.bunifuPagesMain.PageName = "history"
        Me.bunifuPagesMain.PageTitle = "history"
        Me.bunifuPagesMain.SelectedIndex = 0
        Me.bunifuPagesMain.Size = New System.Drawing.Size(1400, 885)
        Me.bunifuPagesMain.TabIndex = 0
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.bunifuPagesMain.Transition = Animation1
        Me.bunifuPagesMain.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom
        '
        'dashboard
        '
        Me.dashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dashboard.Controls.Add(Me.Label8)
        Me.dashboard.Controls.Add(Me.Panel1)
        Me.dashboard.Location = New System.Drawing.Point(4, 4)
        Me.dashboard.Name = "dashboard"
        Me.dashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.dashboard.Size = New System.Drawing.Size(1392, 858)
        Me.dashboard.TabIndex = 0
        Me.dashboard.Text = "dashboard"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Inter", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label8.Location = New System.Drawing.Point(52, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 26)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "dashboard"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(596, 379)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 1
        '
        'files
        '
        Me.files.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.files.Controls.Add(Me.panelFiles)
        Me.files.Location = New System.Drawing.Point(4, 4)
        Me.files.Name = "files"
        Me.files.Padding = New System.Windows.Forms.Padding(3)
        Me.files.Size = New System.Drawing.Size(1392, 858)
        Me.files.TabIndex = 1
        Me.files.Text = "files"
        '
        'panelFiles
        '
        Me.panelFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelFiles.Location = New System.Drawing.Point(3, 3)
        Me.panelFiles.Margin = New System.Windows.Forms.Padding(0)
        Me.panelFiles.Name = "panelFiles"
        Me.panelFiles.Size = New System.Drawing.Size(1386, 853)
        Me.panelFiles.TabIndex = 0
        '
        'transaction
        '
        Me.transaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.transaction.Controls.Add(Me.panelTransaction)
        Me.transaction.Location = New System.Drawing.Point(4, 4)
        Me.transaction.Name = "transaction"
        Me.transaction.Size = New System.Drawing.Size(1392, 858)
        Me.transaction.TabIndex = 6
        Me.transaction.Text = "transaction"
        '
        'users
        '
        Me.users.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.users.Controls.Add(Me.panelUsers)
        Me.users.Location = New System.Drawing.Point(4, 4)
        Me.users.Name = "users"
        Me.users.Padding = New System.Windows.Forms.Padding(3)
        Me.users.Size = New System.Drawing.Size(1392, 858)
        Me.users.TabIndex = 3
        Me.users.Text = "users"
        '
        'panelUsers
        '
        Me.panelUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelUsers.Location = New System.Drawing.Point(3, 3)
        Me.panelUsers.Margin = New System.Windows.Forms.Padding(0)
        Me.panelUsers.Name = "panelUsers"
        Me.panelUsers.Size = New System.Drawing.Size(1386, 853)
        Me.panelUsers.TabIndex = 1
        '
        'history
        '
        Me.history.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.history.Controls.Add(Me.panelHistory)
        Me.history.Location = New System.Drawing.Point(4, 4)
        Me.history.Name = "history"
        Me.history.Padding = New System.Windows.Forms.Padding(3)
        Me.history.Size = New System.Drawing.Size(1392, 858)
        Me.history.TabIndex = 2
        Me.history.Text = "history"
        '
        'panelHistory
        '
        Me.panelHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelHistory.Location = New System.Drawing.Point(3, 3)
        Me.panelHistory.Margin = New System.Windows.Forms.Padding(0)
        Me.panelHistory.Name = "panelHistory"
        Me.panelHistory.Size = New System.Drawing.Size(1386, 852)
        Me.panelHistory.TabIndex = 1
        '
        'settings
        '
        Me.settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.settings.Controls.Add(Me.Label4)
        Me.settings.Controls.Add(Me.Panel4)
        Me.settings.Location = New System.Drawing.Point(4, 4)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(1392, 858)
        Me.settings.TabIndex = 4
        Me.settings.Text = "settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Inter", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.Location = New System.Drawing.Point(576, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "settings"
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(596, 379)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 100)
        Me.Panel4.TabIndex = 1
        '
        'currentUser
        '
        Me.currentUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.currentUser.Controls.Add(Me.Label3)
        Me.currentUser.Controls.Add(Me.panelCurrentUser)
        Me.currentUser.Location = New System.Drawing.Point(4, 4)
        Me.currentUser.Name = "currentUser"
        Me.currentUser.Size = New System.Drawing.Size(1392, 858)
        Me.currentUser.TabIndex = 5
        Me.currentUser.Text = "currentUser"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.Location = New System.Drawing.Point(44, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "currentUser"
        '
        'panelCurrentUser
        '
        Me.panelCurrentUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCurrentUser.Location = New System.Drawing.Point(0, 0)
        Me.panelCurrentUser.Margin = New System.Windows.Forms.Padding(0)
        Me.panelCurrentUser.Name = "panelCurrentUser"
        Me.panelCurrentUser.Size = New System.Drawing.Size(1392, 859)
        Me.panelCurrentUser.TabIndex = 1
        '
        'hiddenPage
        '
        Me.hiddenPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.hiddenPage.Location = New System.Drawing.Point(4, 4)
        Me.hiddenPage.Name = "hiddenPage"
        Me.hiddenPage.Size = New System.Drawing.Size(1392, 858)
        Me.hiddenPage.TabIndex = 7
        Me.hiddenPage.Text = "hiddenPage"
        '
        'panelTransaction
        '
        Me.panelTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTransaction.Location = New System.Drawing.Point(0, 0)
        Me.panelTransaction.Margin = New System.Windows.Forms.Padding(0)
        Me.panelTransaction.Name = "panelTransaction"
        Me.panelTransaction.Size = New System.Drawing.Size(1392, 859)
        Me.panelTransaction.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.FilioSystem.My.Resources.Resources.app_version1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(1291, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 30)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.FilioSystem.My.Resources.Resources.filio_logo1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(45, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 47)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1700, 956)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.panelLeft)
        Me.Controls.Add(Me.panelTop)
        Me.Font = New System.Drawing.Font("Inter", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.panelTopLogo.ResumeLayout(False)
        Me.panelLeft.ResumeLayout(False)
        Me.panelLeft.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.panelMain.ResumeLayout(False)
        Me.bunifuPagesMain.ResumeLayout(False)
        Me.dashboard.ResumeLayout(False)
        Me.dashboard.PerformLayout()
        Me.files.ResumeLayout(False)
        Me.transaction.ResumeLayout(False)
        Me.users.ResumeLayout(False)
        Me.history.ResumeLayout(False)
        Me.settings.ResumeLayout(False)
        Me.settings.PerformLayout()
        Me.currentUser.ResumeLayout(False)
        Me.currentUser.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents panelLeft As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents panelTopLogo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFiles As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents panelTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCurrentUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelMain As Panel
    Friend WithEvents bunifuPagesMain As Bunifu.UI.WinForms.BunifuPages
    Friend WithEvents dashboard As TabPage
    Friend WithEvents files As TabPage
    Friend WithEvents history As TabPage
    Friend WithEvents users As TabPage
    Friend WithEvents settings As TabPage
    Friend WithEvents currentUser As TabPage
    Friend WithEvents panelFiles As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelUsers As Panel
    Friend WithEvents panelHistory As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panelCurrentUser As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTransaction As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents transaction As TabPage
    Friend WithEvents hiddenPage As TabPage
    Friend WithEvents panelTransaction As Panel
End Class
