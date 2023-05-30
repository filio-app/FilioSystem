<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewTransaction
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIssuedBy = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtDate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.txtNotes = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFileName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.lblBRName = New System.Windows.Forms.Label()
        Me.txtBRName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDepartment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStatus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 40
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(337, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 19)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Issued by"
        '
        'txtIssuedBy
        '
        Me.txtIssuedBy.Animated = True
        Me.txtIssuedBy.BorderRadius = 8
        Me.txtIssuedBy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIssuedBy.DefaultText = ""
        Me.txtIssuedBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIssuedBy.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtIssuedBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIssuedBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIssuedBy.Enabled = False
        Me.txtIssuedBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIssuedBy.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtIssuedBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIssuedBy.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtIssuedBy.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtIssuedBy.Location = New System.Drawing.Point(341, 229)
        Me.txtIssuedBy.Margin = New System.Windows.Forms.Padding(5)
        Me.txtIssuedBy.Name = "txtIssuedBy"
        Me.txtIssuedBy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIssuedBy.PlaceholderText = "Please fill in"
        Me.txtIssuedBy.SelectedText = ""
        Me.txtIssuedBy.Size = New System.Drawing.Size(268, 55)
        Me.txtIssuedBy.TabIndex = 57
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lbl.Location = New System.Drawing.Point(25, 205)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(45, 19)
        Me.lbl.TabIndex = 56
        Me.lbl.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.Animated = True
        Me.txtDate.BorderRadius = 8
        Me.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate.DefaultText = ""
        Me.txtDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDate.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDate.Enabled = False
        Me.txtDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDate.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDate.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtDate.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtDate.Location = New System.Drawing.Point(29, 229)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDate.PlaceholderText = "Please fill in"
        Me.txtDate.SelectedText = ""
        Me.txtDate.Size = New System.Drawing.Size(268, 55)
        Me.txtDate.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "File name"
        '
        'cmbType
        '
        Me.cmbType.AutoCompleteCustomSource.AddRange(New String() {"Issued"})
        Me.cmbType.BackColor = System.Drawing.Color.Transparent
        Me.cmbType.BorderRadius = 8
        Me.cmbType.DisabledState.FillColor = System.Drawing.Color.White
        Me.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Enabled = False
        Me.cmbType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbType.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbType.ItemHeight = 49
        Me.cmbType.Items.AddRange(New Object() {"Issue", "Return"})
        Me.cmbType.Location = New System.Drawing.Point(376, 55)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(168, 55)
        Me.cmbType.StartIndex = 0
        Me.cmbType.TabIndex = 54
        Me.cmbType.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(337, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 19)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(25, 534)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Notes"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderRadius = 8
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Gainsboro
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(562, 21)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 17
        '
        'txtNotes
        '
        Me.txtNotes.Animated = True
        Me.txtNotes.BorderRadius = 8
        Me.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNotes.DefaultText = ""
        Me.txtNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNotes.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNotes.Enabled = False
        Me.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNotes.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNotes.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtNotes.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtNotes.Location = New System.Drawing.Point(29, 558)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNotes.PlaceholderText = "Please fill in"
        Me.txtNotes.SelectedText = ""
        Me.txtNotes.Size = New System.Drawing.Size(578, 289)
        Me.txtNotes.TabIndex = 49
        '
        'txtFileName
        '
        Me.txtFileName.Animated = True
        Me.txtFileName.BorderRadius = 8
        Me.txtFileName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFileName.DefaultText = ""
        Me.txtFileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFileName.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtFileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFileName.Enabled = False
        Me.txtFileName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFileName.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtFileName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFileName.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtFileName.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtFileName.Location = New System.Drawing.Point(29, 121)
        Me.txtFileName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFileName.PlaceholderText = "Please fill in"
        Me.txtFileName.SelectedText = ""
        Me.txtFileName.Size = New System.Drawing.Size(578, 55)
        Me.txtFileName.TabIndex = 46
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Inter", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(39, 21)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(342, 34)
        Me.lblHeader.TabIndex = 16
        Me.lblHeader.Text = "Transaction Information"
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 40
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(641, 71)
        Me.Guna2Panel1.TabIndex = 48
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 40
        '
        'lblBRName
        '
        Me.lblBRName.AutoSize = True
        Me.lblBRName.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblBRName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblBRName.Location = New System.Drawing.Point(25, 312)
        Me.lblBRName.Name = "lblBRName"
        Me.lblBRName.Size = New System.Drawing.Size(140, 19)
        Me.lblBRName.TabIndex = 60
        Me.lblBRName.Text = "Borrower's Name"
        '
        'txtBRName
        '
        Me.txtBRName.Animated = True
        Me.txtBRName.BorderRadius = 8
        Me.txtBRName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBRName.DefaultText = ""
        Me.txtBRName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBRName.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtBRName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBRName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBRName.Enabled = False
        Me.txtBRName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBRName.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBRName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBRName.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtBRName.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtBRName.Location = New System.Drawing.Point(29, 336)
        Me.txtBRName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBRName.Name = "txtBRName"
        Me.txtBRName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBRName.PlaceholderText = "Please fill in"
        Me.txtBRName.SelectedText = ""
        Me.txtBRName.Size = New System.Drawing.Size(256, 55)
        Me.txtBRName.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Inter", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(25, 417)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Department"
        '
        'txtDepartment
        '
        Me.txtDepartment.Animated = True
        Me.txtDepartment.BorderRadius = 8
        Me.txtDepartment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDepartment.DefaultText = ""
        Me.txtDepartment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDepartment.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtDepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDepartment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDepartment.Enabled = False
        Me.txtDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDepartment.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDepartment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDepartment.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtDepartment.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtDepartment.Location = New System.Drawing.Point(29, 441)
        Me.txtDepartment.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDepartment.PlaceholderText = "Please fill in"
        Me.txtDepartment.SelectedText = ""
        Me.txtDepartment.Size = New System.Drawing.Size(578, 55)
        Me.txtDepartment.TabIndex = 61
        '
        'txtStatus
        '
        Me.txtStatus.Animated = True
        Me.txtStatus.BorderRadius = 8
        Me.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStatus.DefaultText = ""
        Me.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStatus.DisabledState.FillColor = System.Drawing.Color.White
        Me.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStatus.Enabled = False
        Me.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatus.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStatus.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtStatus.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtStatus.Location = New System.Drawing.Point(341, 338)
        Me.txtStatus.Margin = New System.Windows.Forms.Padding(5)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStatus.PlaceholderText = "Please fill in"
        Me.txtStatus.SelectedText = ""
        Me.txtStatus.Size = New System.Drawing.Size(268, 55)
        Me.txtStatus.TabIndex = 63
        '
        'frmViewTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(641, 882)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.lblBRName)
        Me.Controls.Add(Me.txtBRName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIssuedBy)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmViewTransaction"
        Me.Text = "frmViewTransaction"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIssuedBy As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl As Label
    Friend WithEvents txtDate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNotes As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFileName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDepartment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblBRName As Label
    Friend WithEvents txtBRName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStatus As Guna.UI2.WinForms.Guna2TextBox
End Class
