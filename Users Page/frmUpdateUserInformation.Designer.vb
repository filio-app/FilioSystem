<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdateUserInformation
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.txtPhoneNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gBPersonalInfo = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtEmailAdd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnUpdateInfo = New Guna.UI2.WinForms.Guna2Button()
        Me.gBPersonalInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 40
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 40
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Animated = True
        Me.txtPhoneNo.BorderRadius = 8
        Me.txtPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhoneNo.DefaultText = ""
        Me.txtPhoneNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNo.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPhoneNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhoneNo.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtPhoneNo.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtPhoneNo.Location = New System.Drawing.Point(383, 94)
        Me.txtPhoneNo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNo.PlaceholderText = "Please fill in"
        Me.txtPhoneNo.SelectedText = ""
        Me.txtPhoneNo.Size = New System.Drawing.Size(302, 55)
        Me.txtPhoneNo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(379, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 19)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Phone No."
        '
        'txtLastName
        '
        Me.txtLastName.Animated = True
        Me.txtLastName.BorderRadius = 8
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtLastName.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtLastName.Location = New System.Drawing.Point(36, 218)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderText = "Please fill in"
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(302, 55)
        Me.txtLastName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Last Name"
        '
        'gBPersonalInfo
        '
        Me.gBPersonalInfo.BorderRadius = 6
        Me.gBPersonalInfo.Controls.Add(Me.txtEmailAdd)
        Me.gBPersonalInfo.Controls.Add(Me.Label6)
        Me.gBPersonalInfo.Controls.Add(Me.txtPhoneNo)
        Me.gBPersonalInfo.Controls.Add(Me.Label3)
        Me.gBPersonalInfo.Controls.Add(Me.txtLastName)
        Me.gBPersonalInfo.Controls.Add(Me.Label1)
        Me.gBPersonalInfo.Controls.Add(Me.txtFirstName)
        Me.gBPersonalInfo.Controls.Add(Me.Label2)
        Me.gBPersonalInfo.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.gBPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.gBPersonalInfo.Location = New System.Drawing.Point(22, 38)
        Me.gBPersonalInfo.Name = "gBPersonalInfo"
        Me.gBPersonalInfo.Size = New System.Drawing.Size(712, 321)
        Me.gBPersonalInfo.TabIndex = 39
        Me.gBPersonalInfo.Text = "Personal Information"
        '
        'txtEmailAdd
        '
        Me.txtEmailAdd.Animated = True
        Me.txtEmailAdd.BorderRadius = 8
        Me.txtEmailAdd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailAdd.DefaultText = ""
        Me.txtEmailAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailAdd.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtEmailAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailAdd.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtEmailAdd.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtEmailAdd.Location = New System.Drawing.Point(383, 218)
        Me.txtEmailAdd.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmailAdd.Name = "txtEmailAdd"
        Me.txtEmailAdd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailAdd.PlaceholderText = "Please fill in"
        Me.txtEmailAdd.SelectedText = ""
        Me.txtEmailAdd.Size = New System.Drawing.Size(302, 55)
        Me.txtEmailAdd.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(379, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 19)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Email Address"
        '
        'txtFirstName
        '
        Me.txtFirstName.Animated = True
        Me.txtFirstName.BorderRadius = 8
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtFirstName.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtFirstName.Location = New System.Drawing.Point(36, 94)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = "Please fill in"
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(302, 55)
        Me.txtFirstName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "First Name"
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 40
        '
        'btnUpdateInfo
        '
        Me.btnUpdateInfo.Animated = True
        Me.btnUpdateInfo.BorderRadius = 8
        Me.btnUpdateInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdateInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdateInfo.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnUpdateInfo.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnUpdateInfo.ForeColor = System.Drawing.Color.White
        Me.btnUpdateInfo.Location = New System.Drawing.Point(432, 385)
        Me.btnUpdateInfo.Name = "btnUpdateInfo"
        Me.btnUpdateInfo.Size = New System.Drawing.Size(302, 56)
        Me.btnUpdateInfo.TabIndex = 4
        Me.btnUpdateInfo.Text = "Update"
        '
        'frmUpdateUserInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(749, 469)
        Me.Controls.Add(Me.btnUpdateInfo)
        Me.Controls.Add(Me.gBPersonalInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdateUserInformation"
        Me.Text = "frmEditUser"
        Me.gBPersonalInfo.ResumeLayout(False)
        Me.gBPersonalInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents gBPersonalInfo As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtEmailAdd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPhoneNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnUpdateInfo As Guna.UI2.WinForms.Guna2Button
End Class
