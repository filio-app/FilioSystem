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
        Me.BunifuToolTip1 = New Bunifu.UI.WinForms.BunifuToolTip(Me.components)
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SuspendLayout()
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
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel5.BorderRadius = 20
        Me.Guna2Panel5.BorderThickness = 1
        Me.Guna2Panel5.FillColor = System.Drawing.Color.White
        Me.Guna2Panel5.Location = New System.Drawing.Point(279, 40)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(1162, 703)
        Me.Guna2Panel5.TabIndex = 38
        Me.BunifuToolTip1.SetToolTip(Me.Guna2Panel5, "")
        Me.BunifuToolTip1.SetToolTipIcon(Me.Guna2Panel5, Nothing)
        Me.BunifuToolTip1.SetToolTipTitle(Me.Guna2Panel5, "")
        '
        'DataGridView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1801, 857)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Name = "DataGridView"
        Me.Text = "DataGridView"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuToolTip1 As Bunifu.UI.WinForms.BunifuToolTip
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
End Class
