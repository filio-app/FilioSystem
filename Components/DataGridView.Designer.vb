<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGridView
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdFiles = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.view = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuToolTip1 = New Bunifu.UI.WinForms.BunifuToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grdFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdFiles
        '
        Me.grdFiles.AllowCustomTheming = True
        Me.grdFiles.AllowUserToAddRows = False
        Me.grdFiles.AllowUserToDeleteRows = False
        Me.grdFiles.AllowUserToResizeColumns = False
        Me.grdFiles.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdFiles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdFiles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.grdFiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdFiles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdFiles.ColumnHeadersHeight = 50
        Me.grdFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column9, Me.view, Me.Column15, Me.edit, Me.Column14, Me.delete, Me.Column13})
        Me.grdFiles.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdFiles.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdFiles.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdFiles.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdFiles.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdFiles.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.grdFiles.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdFiles.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdFiles.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdFiles.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grdFiles.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdFiles.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.grdFiles.CurrentTheme.Name = Nothing
        Me.grdFiles.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdFiles.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdFiles.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdFiles.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdFiles.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdFiles.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdFiles.EnableHeadersVisualStyles = False
        Me.grdFiles.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdFiles.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdFiles.HeaderBgColor = System.Drawing.Color.Empty
        Me.grdFiles.HeaderForeColor = System.Drawing.Color.White
        Me.grdFiles.Location = New System.Drawing.Point(324, 148)
        Me.grdFiles.MultiSelect = False
        Me.grdFiles.Name = "grdFiles"
        Me.grdFiles.ReadOnly = True
        Me.grdFiles.RowHeadersVisible = False
        Me.grdFiles.RowHeadersWidth = 50
        Me.grdFiles.RowTemplate.Height = 40
        Me.grdFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdFiles.Size = New System.Drawing.Size(1153, 561)
        Me.grdFiles.TabIndex = 1
        Me.grdFiles.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        Me.BunifuToolTip1.SetToolTip(Me.grdFiles, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.grdFiles, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.grdFiles, "")
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column8.FillWeight = 21.39038!
        Me.Column8.HeaderText = ""
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 10
        '
        'Column7
        '
        Me.Column7.HeaderText = "id"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column1
        '
        Me.Column1.FillWeight = 127.9676!
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.FillWeight = 127.9676!
        Me.Column3.HeaderText = "Location"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 127.9676!
        Me.Column4.HeaderText = "Status"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Date added"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Date modified"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column9.HeaderText = ""
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 10
        '
        'view
        '
        Me.view.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.view.FillWeight = 101.398!
        Me.view.HeaderText = ""
        Me.view.Image = Global.FilioSystem.My.Resources.Resources.view_3
        Me.view.Name = "view"
        Me.view.ReadOnly = True
        Me.view.Width = 25
        '
        'Column15
        '
        Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column15.FillWeight = 101.398!
        Me.Column15.HeaderText = "Column15"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 10
        '
        'edit
        '
        Me.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.edit.FillWeight = 137.0792!
        Me.edit.HeaderText = ""
        Me.edit.Image = Global.FilioSystem.My.Resources.Resources.edit_2
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        Me.edit.Width = 25
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column14.FillWeight = 54.83167!
        Me.Column14.HeaderText = "Column14"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 10
        '
        'delete
        '
        Me.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.delete.HeaderText = ""
        Me.delete.Image = Global.FilioSystem.My.Resources.Resources.delete_2
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        Me.delete.Width = 25
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column13.HeaderText = ""
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 10
        '
        'BunifuToolTip1
        '
        Me.BunifuToolTip1.Active = True
        Me.BunifuToolTip1.AlignTextWithTitle = False
        Me.BunifuToolTip1.AllowAutoClose = False
        Me.BunifuToolTip1.AllowFading = True
        Me.BunifuToolTip1.AutoCloseDuration = 5000
        Me.BunifuToolTip1.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro
        Me.BunifuToolTip1.ClickToShowDisplayControl = False
        Me.BunifuToolTip1.ConvertNewlinesToBreakTags = True
        Me.BunifuToolTip1.DisplayControl = Nothing
        Me.BunifuToolTip1.EntryAnimationSpeed = 350
        Me.BunifuToolTip1.ExitAnimationSpeed = 200
        Me.BunifuToolTip1.GenerateAutoCloseDuration = False
        Me.BunifuToolTip1.IconMargin = 6
        Me.BunifuToolTip1.InitialDelay = 0
        Me.BunifuToolTip1.Name = "BunifuToolTip1"
        Me.BunifuToolTip1.Opacity = 1.0R
        Me.BunifuToolTip1.OverrideToolTipTitles = False
        Me.BunifuToolTip1.Padding = New System.Windows.Forms.Padding(10)
        Me.BunifuToolTip1.ReshowDelay = 100
        Me.BunifuToolTip1.ShowAlways = True
        Me.BunifuToolTip1.ShowBorders = False
        Me.BunifuToolTip1.ShowIcons = True
        Me.BunifuToolTip1.ShowShadows = True
        Me.BunifuToolTip1.Tag = Nothing
        Me.BunifuToolTip1.TextFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuToolTip1.TextMargin = 2
        Me.BunifuToolTip1.TitleFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuToolTip1.TitleForeColor = System.Drawing.Color.Black
        Me.BunifuToolTip1.ToolTipPosition = New System.Drawing.Point(0, 0)
        Me.BunifuToolTip1.ToolTipTitle = "tset"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1577, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.BunifuToolTip1.SetToolTip(Me.Button1, "sdfsf" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sdffsf" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fsdf")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Button1, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Button1, "")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1801, 857)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grdFiles)
        Me.Name = "DataGridView"
        Me.Text = "DataGridView"
        CType(Me.grdFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdFiles As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents view As DataGridViewImageColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewImageColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewImageColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents BunifuToolTip1 As Bunifu.UI.WinForms.BunifuToolTip
    Friend WithEvents Button1 As Button
End Class
