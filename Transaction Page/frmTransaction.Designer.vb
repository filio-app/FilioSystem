﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransaction
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.grdTransaction = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.view = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblTotalTransactions = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.grdTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'grdTransaction
        '
        Me.grdTransaction.AllowCustomTheming = True
        Me.grdTransaction.AllowUserToAddRows = False
        Me.grdTransaction.AllowUserToDeleteRows = False
        Me.grdTransaction.AllowUserToResizeColumns = False
        Me.grdTransaction.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdTransaction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdTransaction.BackgroundColor = System.Drawing.Color.White
        Me.grdTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.grdTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTransaction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdTransaction.ColumnHeadersHeight = 50
        Me.grdTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdTransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column7, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column12, Me.Column2, Me.Column10, Me.Column16, Me.Column11, Me.Column9, Me.view, Me.Column15, Me.edit, Me.Column14, Me.delete, Me.Column13})
        Me.grdTransaction.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdTransaction.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdTransaction.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdTransaction.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdTransaction.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdTransaction.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.grdTransaction.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdTransaction.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdTransaction.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdTransaction.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.grdTransaction.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdTransaction.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.grdTransaction.CurrentTheme.Name = Nothing
        Me.grdTransaction.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.grdTransaction.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdTransaction.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdTransaction.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdTransaction.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.grdTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdTransaction.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdTransaction.EnableHeadersVisualStyles = False
        Me.grdTransaction.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdTransaction.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.grdTransaction.HeaderBgColor = System.Drawing.Color.Empty
        Me.grdTransaction.HeaderForeColor = System.Drawing.Color.White
        Me.grdTransaction.Location = New System.Drawing.Point(19, 17)
        Me.grdTransaction.MultiSelect = False
        Me.grdTransaction.Name = "grdTransaction"
        Me.grdTransaction.ReadOnly = True
        Me.grdTransaction.RowHeadersVisible = False
        Me.grdTransaction.RowHeadersWidth = 50
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTransaction.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdTransaction.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.grdTransaction.RowTemplate.Height = 70
        Me.grdTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTransaction.Size = New System.Drawing.Size(1140, 652)
        Me.grdTransaction.TabIndex = 1
        Me.grdTransaction.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
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
        Me.Column1.HeaderText = "File Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 127.9676!
        Me.Column3.HeaderText = "Date"
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
        Me.Column5.HeaderText = "Username"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Notes"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column12
        '
        Me.Column12.HeaderText = "Type"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "Borrower's Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "Returner's Name"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Column16
        '
        Me.Column16.HeaderText = "Borrower/Returner"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Department"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
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
        Me.edit.Visible = False
        Me.edit.Width = 25
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column14.FillWeight = 54.83167!
        Me.Column14.HeaderText = "Column14"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Visible = False
        Me.Column14.Width = 10
        '
        'delete
        '
        Me.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.delete.HeaderText = ""
        Me.delete.Image = Global.FilioSystem.My.Resources.Resources.delete_2
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        Me.delete.Visible = False
        Me.delete.Width = 25
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column13.HeaderText = ""
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Visible = False
        Me.Column13.Width = 10
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.TargetControl = Me.grdTransaction
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.BorderRadius = 10
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(31, 28)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(221, 48)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add New Transaction"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn1.FillWeight = 101.398!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.FilioSystem.My.Resources.Resources.view_3
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
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Visible = False
        Me.DataGridViewImageColumn2.Width = 25
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewImageColumn3.HeaderText = ""
        Me.DataGridViewImageColumn3.Image = Global.FilioSystem.My.Resources.Resources.delete_2
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.ReadOnly = True
        Me.DataGridViewImageColumn3.Width = 25
        '
        'lblTotalTransactions
        '
        Me.lblTotalTransactions.AutoSize = True
        Me.lblTotalTransactions.Font = New System.Drawing.Font("Inter SemiBold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblTotalTransactions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTotalTransactions.Location = New System.Drawing.Point(90, 686)
        Me.lblTotalTransactions.Name = "lblTotalTransactions"
        Me.lblTotalTransactions.Size = New System.Drawing.Size(151, 21)
        Me.lblTotalTransactions.TabIndex = 37
        Me.lblTotalTransactions.Text = "60 Transactions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(147, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 685)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Showing:"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel5.BorderRadius = 20
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.Controls.Add(Me.lblTotalTransactions)
        Me.Guna2Panel5.Controls.Add(Me.grdTransaction)
        Me.Guna2Panel5.Controls.Add(Me.Label1)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.White
        Me.Guna2Panel5.Location = New System.Drawing.Point(12, 88)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(1176, 722)
        Me.Guna2Panel5.TabIndex = 39
        '
        'txtSearch
        '
        Me.txtSearch.Animated = True
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtSearch.BorderRadius = 8
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Inter", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtSearch.IconLeftSize = New System.Drawing.Size(28, 28)
        Me.txtSearch.Location = New System.Drawing.Point(832, 23)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search file..."
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(339, 53)
        Me.txtSearch.TabIndex = 41
        '
        'frmTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 822)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTransaction"
        Me.Text = "frmTransaction"
        CType(Me.grdTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents grdTransaction As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents lblTotalTransactions As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents view As DataGridViewImageColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewImageColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents delete As DataGridViewImageColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
End Class
