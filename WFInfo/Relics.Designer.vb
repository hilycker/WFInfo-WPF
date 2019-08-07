﻿Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Relics
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lith")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Meso")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Neo")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Axi")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Relics))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RelicTree3 = New WFInfo.DoubleBufferedTreeView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FilterText = New WFInfo.CustomTextBox()
        Me.VaultCheck = New System.Windows.Forms.CheckBox()
        Me.btnCollapse = New System.Windows.Forms.Button()
        Me.btnExpand = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RelicTree2 = New WFInfo.DoubleBufferedTreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SortSelection = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSwap = New System.Windows.Forms.Button()
        Me.RelicTree1 = New WFInfo.DoubleBufferedTreeView()
        Me.HideMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HideOpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.BottomResize = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RelicTree3)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.RelicTree2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.RelicTree1)
        Me.Panel1.Location = New System.Drawing.Point(0, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 394)
        Me.Panel1.TabIndex = 24
        '
        'RelicTree3
        '
        Me.RelicTree3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.RelicTree3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RelicTree3.CausesValidation = False
        Me.RelicTree3.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText
        Me.RelicTree3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RelicTree3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.RelicTree3.FullRowSelect = True
        Me.RelicTree3.ItemHeight = 16
        Me.RelicTree3.Location = New System.Drawing.Point(-1, 53)
        Me.RelicTree3.Name = "RelicTree3"
        Me.RelicTree3.Size = New System.Drawing.Size(473, 340)
        Me.RelicTree3.TabIndex = 26
        Me.RelicTree3.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.VaultCheck)
        Me.Panel3.Controls.Add(Me.btnCollapse)
        Me.Panel3.Controls.Add(Me.btnExpand)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(-1, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(456, 24)
        Me.Panel3.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel4.Controls.Add(Me.FilterText)
        Me.Panel4.Location = New System.Drawing.Point(234, -1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(221, 24)
        Me.Panel4.TabIndex = 28
        '
        'FilterText
        '
        Me.FilterText.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FilterText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FilterText.Font = New System.Drawing.Font("Tahoma", 11.5!)
        Me.FilterText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.FilterText.Location = New System.Drawing.Point(3, 3)
        Me.FilterText.MaxLength = 255
        Me.FilterText.Name = "FilterText"
        Me.FilterText.Size = New System.Drawing.Size(215, 19)
        Me.FilterText.TabIndex = 26
        Me.FilterText.Text = "Filter Terms..."
        Me.FilterText.WordWrap = False
        '
        'VaultCheck
        '
        Me.VaultCheck.AutoSize = True
        Me.VaultCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VaultCheck.Checked = True
        Me.VaultCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VaultCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VaultCheck.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.VaultCheck.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.VaultCheck.Location = New System.Drawing.Point(50, 0)
        Me.VaultCheck.Name = "VaultCheck"
        Me.VaultCheck.Size = New System.Drawing.Size(120, 21)
        Me.VaultCheck.TabIndex = 27
        Me.VaultCheck.Text = "Show Vaulted"
        '
        'btnCollapse
        '
        Me.btnCollapse.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnCollapse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCollapse.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCollapse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnCollapse.Location = New System.Drawing.Point(23, -1)
        Me.btnCollapse.Name = "btnCollapse"
        Me.btnCollapse.Size = New System.Drawing.Size(24, 24)
        Me.btnCollapse.TabIndex = 26
        Me.btnCollapse.Text = "-"
        Me.btnCollapse.UseCompatibleTextRendering = True
        Me.btnCollapse.UseVisualStyleBackColor = False
        '
        'btnExpand
        '
        Me.btnExpand.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnExpand.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnExpand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpand.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnExpand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnExpand.Location = New System.Drawing.Point(-1, -1)
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.Size = New System.Drawing.Size(25, 24)
        Me.btnExpand.TabIndex = 25
        Me.btnExpand.Text = "+"
        Me.btnExpand.UseCompatibleTextRendering = True
        Me.btnExpand.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(179, -3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 26)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Filter:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RelicTree2
        '
        Me.RelicTree2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.RelicTree2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RelicTree2.CausesValidation = False
        Me.RelicTree2.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText
        Me.RelicTree2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RelicTree2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.RelicTree2.FullRowSelect = True
        Me.RelicTree2.ItemHeight = 16
        Me.RelicTree2.Location = New System.Drawing.Point(-1, 53)
        Me.RelicTree2.Name = "RelicTree2"
        Me.RelicTree2.Size = New System.Drawing.Size(473, 340)
        Me.RelicTree2.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.SortSelection)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnSwap)
        Me.Panel2.Location = New System.Drawing.Point(-1, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(456, 32)
        Me.Panel2.TabIndex = 19
        '
        'SortSelection
        '
        Me.SortSelection.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.SortSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SortSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SortSelection.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.SortSelection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.SortSelection.FormattingEnabled = True
        Me.SortSelection.Items.AddRange(New Object() {"Name", "Intact Plat", "Radiant Plat", "Diff (Rad - Int)"})
        Me.SortSelection.Location = New System.Drawing.Point(292, 2)
        Me.SortSelection.Name = "SortSelection"
        Me.SortSelection.Size = New System.Drawing.Size(150, 26)
        Me.SortSelection.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(218, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 32)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Sort By:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSwap
        '
        Me.btnSwap.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnSwap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnSwap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSwap.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSwap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnSwap.Location = New System.Drawing.Point(-1, -1)
        Me.btnSwap.Name = "btnSwap"
        Me.btnSwap.Size = New System.Drawing.Size(209, 32)
        Me.btnSwap.TabIndex = 21
        Me.btnSwap.Text = "All Relics"
        Me.btnSwap.UseVisualStyleBackColor = False
        '
        'RelicTree1
        '
        Me.RelicTree1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.RelicTree1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RelicTree1.CausesValidation = False
        Me.RelicTree1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText
        Me.RelicTree1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RelicTree1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.RelicTree1.FullRowSelect = True
        Me.RelicTree1.ItemHeight = 16
        Me.RelicTree1.Location = New System.Drawing.Point(-1, 53)
        Me.RelicTree1.Name = "RelicTree1"
        TreeNode1.Name = "lith"
        TreeNode1.Text = "Lith"
        TreeNode2.Name = "meso"
        TreeNode2.Text = "Meso"
        TreeNode3.Name = "neo"
        TreeNode3.Text = "Neo"
        TreeNode4.Name = "axi"
        TreeNode4.Text = "Axi"
        Me.RelicTree1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Me.RelicTree1.Size = New System.Drawing.Size(473, 340)
        Me.RelicTree1.TabIndex = 18
        '
        'HideMenu
        '
        Me.HideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.HideMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HideMenu.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.HideMenu.Name = "HideMenu"
        Me.HideMenu.ShowImageMargin = False
        Me.HideMenu.ShowItemToolTips = False
        Me.HideMenu.Size = New System.Drawing.Size(36, 4)
        '
        'HideOpt
        '
        Me.HideOpt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.HideOpt.Name = "HideOpt"
        Me.HideOpt.ShowShortcutKeys = False
        Me.HideOpt.Size = New System.Drawing.Size(155, 22)
        Me.HideOpt.Text = "Hide"
        Me.HideOpt.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(425, -1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 27)
        Me.btnClose.TabIndex = 17
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "×"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pTitle
        '
        Me.pTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pTitle.Controls.Add(Me.pbIcon)
        Me.pTitle.Controls.Add(Me.lbTitle)
        Me.pTitle.Controls.Add(Me.btnClose)
        Me.pTitle.Location = New System.Drawing.Point(0, 0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(456, 27)
        Me.pTitle.TabIndex = 25
        '
        'pbIcon
        '
        Me.pbIcon.BackColor = System.Drawing.Color.Transparent
        Me.pbIcon.Image = Global.WFInfo.My.Resources.Resources.WFLogo
        Me.pbIcon.Location = New System.Drawing.Point(0, 0)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(25, 25)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIcon.TabIndex = 22
        Me.pbIcon.TabStop = False
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.BackColor = System.Drawing.Color.Transparent
        Me.lbTitle.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lbTitle.Location = New System.Drawing.Point(32, 3)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(50, 17)
        Me.lbTitle.TabIndex = 17
        Me.lbTitle.Text = "Relics"
        '
        'BottomResize
        '
        Me.BottomResize.BackColor = System.Drawing.Color.Transparent
        Me.BottomResize.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.BottomResize.ForeColor = System.Drawing.Color.Transparent
        Me.BottomResize.Location = New System.Drawing.Point(6, 414)
        Me.BottomResize.Name = "BottomResize"
        Me.BottomResize.Size = New System.Drawing.Size(444, 5)
        Me.BottomResize.TabIndex = 27
        '
        'Relics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(456, 420)
        Me.Controls.Add(Me.BottomResize)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Relics"
        Me.Text = "Relics"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        Me.pTitle.PerformLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbIcon As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents pTitle As Panel
    Friend WithEvents lbTitle As Label
    Friend WithEvents RelicTree1 As DoubleBufferedTreeView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSwap As Button
    Friend WithEvents HideMenu As ContextMenuStrip
    Friend WithEvents HideOpt As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents RelicTree2 As DoubleBufferedTreeView
    Friend WithEvents SortSelection As ComboBox
    Friend WithEvents BottomResize As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents RelicTree3 As DoubleBufferedTreeView
    Friend WithEvents btnExpand As Button
    Friend WithEvents btnCollapse As Button
    Friend WithEvents VaultCheck As CheckBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents FilterText As CustomTextBox
End Class
