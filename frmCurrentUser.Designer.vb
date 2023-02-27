<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrentUser
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelChangePass = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.panelChangePass.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'panelChangePass
        '
        Me.panelChangePass.BackColor = System.Drawing.Color.White
        Me.panelChangePass.Controls.Add(Me.btnEdit)
        Me.panelChangePass.Controls.Add(Me.Label3)
        Me.panelChangePass.Controls.Add(Me.Guna2TextBox3)
        Me.panelChangePass.Controls.Add(Me.Label2)
        Me.panelChangePass.Controls.Add(Me.Guna2TextBox2)
        Me.panelChangePass.Controls.Add(Me.Label1)
        Me.panelChangePass.Controls.Add(Me.Guna2TextBox1)
        Me.panelChangePass.Controls.Add(Me.Label16)
        Me.panelChangePass.Controls.Add(Me.txtUsername)
        Me.panelChangePass.Location = New System.Drawing.Point(327, 162)
        Me.panelChangePass.Name = "panelChangePass"
        Me.panelChangePass.Size = New System.Drawing.Size(440, 435)
        Me.panelChangePass.TabIndex = 0
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 10
        Me.Guna2Elipse2.TargetControl = Me.panelChangePass
        '
        'txtUsername
        '
        Me.txtUsername.BorderRadius = 8
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtUsername.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtUsername.Location = New System.Drawing.Point(180, 79)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = ""
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(228, 41)
        Me.txtUsername.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Inter SemiBold", 12.0!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(21, 90)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 19)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter SemiBold", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 150)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Password"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderRadius = 8
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.Guna2TextBox1.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.Guna2TextBox1.Location = New System.Drawing.Point(180, 139)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(228, 41)
        Me.Guna2TextBox1.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter SemiBold", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 211)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 19)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Current Password"
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BorderRadius = 8
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.Guna2TextBox2.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.Guna2TextBox2.Location = New System.Drawing.Point(180, 200)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(228, 41)
        Me.Guna2TextBox2.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter SemiBold", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 272)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 19)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Confirm Password"
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.BorderRadius = 8
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = ""
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.Guna2TextBox3.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.Guna2TextBox3.Location = New System.Drawing.Point(180, 261)
        Me.Guna2TextBox3.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderText = ""
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.Size = New System.Drawing.Size(228, 41)
        Me.Guna2TextBox3.TabIndex = 76
        '
        'btnEdit
        '
        Me.btnEdit.BorderRadius = 8
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(323, 347)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(85, 45)
        Me.btnEdit.TabIndex = 78
        Me.btnEdit.Text = "Edit"
        '
        'frmCurrentUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 822)
        Me.Controls.Add(Me.panelChangePass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCurrentUser"
        Me.Text = "frmCurrentUser"
        Me.panelChangePass.ResumeLayout(False)
        Me.panelChangePass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents panelChangePass As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
End Class
