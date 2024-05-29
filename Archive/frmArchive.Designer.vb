<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArchive
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.grdArchivedFiles = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.lblTotalFiles = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.view = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.restore = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel5.SuspendLayout()
        CType(Me.grdArchivedFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel5.BorderRadius = 20
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Controls.Add(Me.grdArchivedFiles)
        Me.Guna2Panel5.Controls.Add(Me.lblTotalFiles)
        Me.Guna2Panel5.Controls.Add(Me.Label1)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.White
        Me.Guna2Panel5.Location = New System.Drawing.Point(19, 94)
        Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(1554, 874)
        Me.Guna2Panel5.TabIndex = 38
        '
        'grdArchivedFiles
        '
        Me.grdArchivedFiles.AllowCustomTheming = True
        Me.grdArchivedFiles.AllowUserToAddRows = False
        Me.grdArchivedFiles.AllowUserToDeleteRows = False
        Me.grdArchivedFiles.AllowUserToResizeColumns = False
        Me.grdArchivedFiles.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdArchivedFiles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdArchivedFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdArchivedFiles.BackgroundColor = System.Drawing.Color.White
        Me.grdArchivedFiles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdArchivedFiles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdArchivedFiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdArchivedFiles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdArchivedFiles.ColumnHeadersHeight = 50
        Me.grdArchivedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdArchivedFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column10, Me.Column9, Me.view, Me.Column15, Me.restore, Me.Column14, Me.delete, Me.Column13})
        Me.grdArchivedFiles.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdArchivedFiles.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdArchivedFiles.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdArchivedFiles.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdArchivedFiles.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdArchivedFiles.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.grdArchivedFiles.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdArchivedFiles.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdArchivedFiles.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdArchivedFiles.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grdArchivedFiles.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdArchivedFiles.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.grdArchivedFiles.CurrentTheme.Name = Nothing
        Me.grdArchivedFiles.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdArchivedFiles.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdArchivedFiles.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdArchivedFiles.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdArchivedFiles.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdArchivedFiles.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdArchivedFiles.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdArchivedFiles.EnableHeadersVisualStyles = False
        Me.grdArchivedFiles.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdArchivedFiles.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdArchivedFiles.HeaderBgColor = System.Drawing.Color.Empty
        Me.grdArchivedFiles.HeaderForeColor = System.Drawing.Color.White
        Me.grdArchivedFiles.Location = New System.Drawing.Point(24, 25)
        Me.grdArchivedFiles.Margin = New System.Windows.Forms.Padding(4)
        Me.grdArchivedFiles.MultiSelect = False
        Me.grdArchivedFiles.Name = "grdArchivedFiles"
        Me.grdArchivedFiles.ReadOnly = True
        Me.grdArchivedFiles.RowHeadersVisible = False
        Me.grdArchivedFiles.RowHeadersWidth = 50
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdArchivedFiles.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdArchivedFiles.RowTemplate.Height = 60
        Me.grdArchivedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdArchivedFiles.Size = New System.Drawing.Size(1507, 791)
        Me.grdArchivedFiles.TabIndex = 0
        Me.grdArchivedFiles.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'lblTotalFiles
        '
        Me.lblTotalFiles.AutoSize = True
        Me.lblTotalFiles.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTotalFiles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTotalFiles.Location = New System.Drawing.Point(121, 836)
        Me.lblTotalFiles.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalFiles.Name = "lblTotalFiles"
        Me.lblTotalFiles.Size = New System.Drawing.Size(80, 21)
        Me.lblTotalFiles.TabIndex = 35
        Me.lblTotalFiles.Text = "60 Files"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 835)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 21)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Showing:"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Inter", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblHeader.Location = New System.Drawing.Point(39, 32)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(209, 34)
        Me.lblHeader.TabIndex = 37
        Me.lblHeader.Text = "Archived Files "
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.FillWeight = 101.398!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.FilioSystem.My.Resources.Resources.view_3
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 25
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn2.FillWeight = 137.0792!
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.FilioSystem.My.Resources.Resources.edit_2
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Width = 25
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Image = Global.FilioSystem.My.Resources.Resources.delete_2
        Me.DataGridViewImageColumn3.MinimumWidth = 6
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Visible = False
        Me.DataGridViewImageColumn3.Width = 25
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column8.FillWeight = 21.39038!
        Me.Column8.HeaderText = ""
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 10
        '
        'Column7
        '
        Me.Column7.HeaderText = "id"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column1
        '
        Me.Column1.FillWeight = 127.9676!
        Me.Column1.HeaderText = "Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.FillWeight = 127.9676!
        Me.Column3.HeaderText = "Location"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column4.FillWeight = 127.9676!
        Me.Column4.HeaderText = "Status"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        Me.Column4.Width = 190
        '
        'Column5
        '
        Me.Column5.HeaderText = "Date added"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Date modified"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column10.HeaderText = "Date removed"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 350
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column9.HeaderText = ""
        Me.Column9.MinimumWidth = 6
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
        Me.view.MinimumWidth = 6
        Me.view.Name = "view"
        Me.view.ReadOnly = True
        Me.view.Width = 25
        '
        'Column15
        '
        Me.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column15.FillWeight = 101.398!
        Me.Column15.HeaderText = "Column15"
        Me.Column15.MinimumWidth = 6
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 10
        '
        'restore
        '
        Me.restore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.restore.FillWeight = 137.0792!
        Me.restore.HeaderText = ""
        Me.restore.Image = Global.FilioSystem.My.Resources.Resources.restore_2
        Me.restore.MinimumWidth = 6
        Me.restore.Name = "restore"
        Me.restore.ReadOnly = True
        Me.restore.Width = 25
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column14.FillWeight = 54.83167!
        Me.Column14.HeaderText = "Column14"
        Me.Column14.MinimumWidth = 6
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 10
        '
        'delete
        '
        Me.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.delete.HeaderText = ""
        Me.delete.Image = Global.FilioSystem.My.Resources.Resources.delete_2
        Me.delete.MinimumWidth = 6
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        Me.delete.Visible = False
        Me.delete.Width = 25
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column13.HeaderText = ""
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
        Me.Column13.Width = 10
        '
        'frmArchive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1600, 1012)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmArchive"
        Me.Text = "frmArchive"
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        CType(Me.grdArchivedFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents grdArchivedFiles As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents lblTotalFiles As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents lblHeader As Label
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents view As DataGridViewImageColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents restore As DataGridViewImageColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewImageColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
End Class
