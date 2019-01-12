<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.NewGameMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeveloperPictureBox = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.DeveloperInfoLabel = New System.Windows.Forms.Label()
        Me.DeveloperNameLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        CType(Me.DeveloperPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.Color.DarkBlue
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameMenuItem, Me.ResetMenuItem, Me.AboutMenuItem})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(650, 50)
        Me.MenuStrip.TabIndex = 1
        '
        'NewGameMenuItem
        '
        Me.NewGameMenuItem.AutoSize = False
        Me.NewGameMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewGameMenuItem.ForeColor = System.Drawing.Color.White
        Me.NewGameMenuItem.Name = "NewGameMenuItem"
        Me.NewGameMenuItem.Size = New System.Drawing.Size(122, 36)
        Me.NewGameMenuItem.Text = "New Game"
        '
        'ResetMenuItem
        '
        Me.ResetMenuItem.AutoSize = False
        Me.ResetMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ResetMenuItem.ForeColor = System.Drawing.Color.White
        Me.ResetMenuItem.Name = "ResetMenuItem"
        Me.ResetMenuItem.Size = New System.Drawing.Size(80, 36)
        Me.ResetMenuItem.Text = "Reset"
        '
        'AboutMenuItem
        '
        Me.AboutMenuItem.AutoSize = False
        Me.AboutMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutMenuItem.Name = "AboutMenuItem"
        Me.AboutMenuItem.Size = New System.Drawing.Size(100, 36)
        Me.AboutMenuItem.Text = "About"
        '
        'DeveloperPictureBox
        '
        Me.DeveloperPictureBox.Image = Global.TicTacToe.My.Resources.Resources.Karan
        Me.DeveloperPictureBox.Location = New System.Drawing.Point(40, 150)
        Me.DeveloperPictureBox.Name = "DeveloperPictureBox"
        Me.DeveloperPictureBox.Size = New System.Drawing.Size(250, 250)
        Me.DeveloperPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DeveloperPictureBox.TabIndex = 13
        Me.DeveloperPictureBox.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Red
        Me.CloseButton.BackgroundImage = Global.TicTacToe.My.Resources.Resources.Close
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CloseButton.FlatAppearance.BorderSize = 2
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(608, 10)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(32, 32)
        Me.CloseButton.TabIndex = 12
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'MinimizeButton
        '
        Me.MinimizeButton.BackColor = System.Drawing.Color.Orange
        Me.MinimizeButton.BackgroundImage = Global.TicTacToe.My.Resources.Resources.Minimize
        Me.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.MinimizeButton.FlatAppearance.BorderSize = 2
        Me.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeButton.Location = New System.Drawing.Point(566, 10)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(32, 32)
        Me.MinimizeButton.TabIndex = 11
        Me.MinimizeButton.UseVisualStyleBackColor = False
        '
        'DeveloperInfoLabel
        '
        Me.DeveloperInfoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeveloperInfoLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeveloperInfoLabel.ForeColor = System.Drawing.Color.DimGray
        Me.DeveloperInfoLabel.Location = New System.Drawing.Point(310, 200)
        Me.DeveloperInfoLabel.Name = "DeveloperInfoLabel"
        Me.DeveloperInfoLabel.Size = New System.Drawing.Size(300, 200)
        Me.DeveloperInfoLabel.TabIndex = 14
        Me.DeveloperInfoLabel.Text = resources.GetString("DeveloperInfoLabel.Text")
        Me.DeveloperInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeveloperNameLabel
        '
        Me.DeveloperNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeveloperNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeveloperNameLabel.Location = New System.Drawing.Point(350, 150)
        Me.DeveloperNameLabel.Name = "DeveloperNameLabel"
        Me.DeveloperNameLabel.Size = New System.Drawing.Size(250, 50)
        Me.DeveloperNameLabel.TabIndex = 15
        Me.DeveloperNameLabel.Text = "Karan Jaiswal"
        Me.DeveloperNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleLabel
        '
        Me.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.TitleLabel.Location = New System.Drawing.Point(200, 75)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(250, 50)
        Me.TitleLabel.TabIndex = 16
        Me.TitleLabel.Text = "Developer"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(650, 500)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.DeveloperNameLabel)
        Me.Controls.Add(Me.DeveloperInfoLabel)
        Me.Controls.Add(Me.DeveloperPictureBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.DeveloperPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents NewGameMenuItem As ToolStripMenuItem
    Friend WithEvents ResetMenuItem As ToolStripMenuItem
    Friend WithEvents AboutMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents DeveloperPictureBox As PictureBox
    Friend WithEvents DeveloperInfoLabel As Label
    Friend WithEvents DeveloperNameLabel As Label
    Friend WithEvents TitleLabel As Label
End Class
