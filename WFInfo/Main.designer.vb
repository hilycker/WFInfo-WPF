﻿Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.lbWiki = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbWikiDate = New System.Windows.Forms.Label()
        Me.lbEqmt = New System.Windows.Forms.Label()
        Me.lbEqmtDate = New System.Windows.Forms.Label()
        Me.lbMarketDate = New System.Windows.Forms.Label()
        Me.lbMarket = New System.Windows.Forms.Label()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pTitle = New System.Windows.Forms.Panel()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.tUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.trayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.trayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.trayShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.trayRelics = New System.Windows.Forms.ToolStripMenuItem()
        Me.trayEquipment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.trayExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbHome = New System.Windows.Forms.PictureBox()
        Me.pbEqmt = New System.Windows.Forms.PictureBox()
        Me.pbSettings = New System.Windows.Forms.PictureBox()
        Me.pbRelic = New System.Windows.Forms.PictureBox()
        Me.pbSideBar = New System.Windows.Forms.PictureBox()
        Me.OutOfDate = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pTitle.SuspendLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.trayMenu.SuspendLayout()
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEqmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRelic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSideBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lbStatus)
        Me.Panel1.Controls.Add(Me.lbWiki)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbWikiDate)
        Me.Panel1.Controls.Add(Me.lbEqmt)
        Me.Panel1.Controls.Add(Me.lbEqmtDate)
        Me.Panel1.Controls.Add(Me.lbMarketDate)
        Me.Panel1.Controls.Add(Me.lbMarket)
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 106)
        Me.Panel1.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "TEST"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lbStatus
        '
        Me.lbStatus.BackColor = System.Drawing.Color.Transparent
        Me.lbStatus.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lbStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lbStatus.Location = New System.Drawing.Point(48, 85)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(256, 19)
        Me.lbStatus.TabIndex = 30
        Me.lbStatus.Text = "Loading..."
        Me.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbWiki
        '
        Me.lbWiki.BackColor = System.Drawing.Color.Transparent
        Me.lbWiki.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWiki.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lbWiki.Location = New System.Drawing.Point(30, 59)
        Me.lbWiki.Name = "lbWiki"
        Me.lbWiki.Size = New System.Drawing.Size(120, 18)
        Me.lbWiki.TabIndex = 27
        Me.lbWiki.Text = "Wiki Data:"
        Me.lbWiki.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-1, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(2)
        Me.Label2.Size = New System.Drawing.Size(305, 21)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Status: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbWikiDate
        '
        Me.lbWikiDate.BackColor = System.Drawing.Color.Transparent
        Me.lbWikiDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWikiDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lbWikiDate.Location = New System.Drawing.Point(156, 59)
        Me.lbWikiDate.Name = "lbWikiDate"
        Me.lbWikiDate.Size = New System.Drawing.Size(120, 18)
        Me.lbWikiDate.TabIndex = 26
        Me.lbWikiDate.Text = "Loading..."
        '
        'lbEqmt
        '
        Me.lbEqmt.BackColor = System.Drawing.Color.Transparent
        Me.lbEqmt.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEqmt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lbEqmt.Location = New System.Drawing.Point(30, 34)
        Me.lbEqmt.Name = "lbEqmt"
        Me.lbEqmt.Size = New System.Drawing.Size(120, 18)
        Me.lbEqmt.TabIndex = 25
        Me.lbEqmt.Text = "Drop Data:"
        Me.lbEqmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbEqmtDate
        '
        Me.lbEqmtDate.BackColor = System.Drawing.Color.Transparent
        Me.lbEqmtDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEqmtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lbEqmtDate.Location = New System.Drawing.Point(156, 34)
        Me.lbEqmtDate.Name = "lbEqmtDate"
        Me.lbEqmtDate.Size = New System.Drawing.Size(120, 18)
        Me.lbEqmtDate.TabIndex = 24
        Me.lbEqmtDate.Text = "Loading..."
        '
        'lbMarketDate
        '
        Me.lbMarketDate.BackColor = System.Drawing.Color.Transparent
        Me.lbMarketDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMarketDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lbMarketDate.Location = New System.Drawing.Point(156, 9)
        Me.lbMarketDate.Name = "lbMarketDate"
        Me.lbMarketDate.Size = New System.Drawing.Size(120, 18)
        Me.lbMarketDate.TabIndex = 22
        Me.lbMarketDate.Text = "Loading..."
        '
        'lbMarket
        '
        Me.lbMarket.BackColor = System.Drawing.Color.Transparent
        Me.lbMarket.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMarket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lbMarket.Location = New System.Drawing.Point(30, 9)
        Me.lbMarket.Name = "lbMarket"
        Me.lbMarket.Size = New System.Drawing.Size(120, 18)
        Me.lbMarket.TabIndex = 21
        Me.lbMarket.Text = "Market Data:"
        Me.lbMarket.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.BackColor = System.Drawing.Color.Transparent
        Me.lbVersion.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lbVersion.Location = New System.Drawing.Point(88, 7)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(38, 12)
        Me.lbVersion.TabIndex = 7
        Me.lbVersion.Text = "vX.X.X"
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.BackColor = System.Drawing.Color.Transparent
        Me.lbTitle.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lbTitle.Location = New System.Drawing.Point(31, 3)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(58, 17)
        Me.lbTitle.TabIndex = 6
        Me.lbTitle.Text = "WFInfo"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(303, -1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 27)
        Me.btnClose.TabIndex = 22
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "×"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pTitle
        '
        Me.pTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pTitle.Controls.Add(Me.btnHide)
        Me.pTitle.Controls.Add(Me.lbVersion)
        Me.pTitle.Controls.Add(Me.btnClose)
        Me.pTitle.Controls.Add(Me.pbIcon)
        Me.pTitle.Controls.Add(Me.lbTitle)
        Me.pTitle.Location = New System.Drawing.Point(0, 0)
        Me.pTitle.Name = "pTitle"
        Me.pTitle.Size = New System.Drawing.Size(334, 27)
        Me.pTitle.TabIndex = 6
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btnHide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnHide.Location = New System.Drawing.Point(274, -1)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(30, 27)
        Me.btnHide.TabIndex = 25
        Me.btnHide.TabStop = False
        Me.btnHide.Text = "━"
        Me.btnHide.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'pbIcon
        '
        Me.pbIcon.BackColor = System.Drawing.Color.Transparent
        Me.pbIcon.Image = Global.WFInfo.My.Resources.Resources.WFLogo
        Me.pbIcon.Location = New System.Drawing.Point(0, -1)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(25, 25)
        Me.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIcon.TabIndex = 23
        Me.pbIcon.TabStop = False
        '
        'tUpdate
        '
        Me.tUpdate.Enabled = True
        Me.tUpdate.Interval = 300000
        '
        'trayIcon
        '
        Me.trayIcon.ContextMenuStrip = Me.trayMenu
        Me.trayIcon.Icon = CType(resources.GetObject("trayIcon.Icon"), System.Drawing.Icon)
        Me.trayIcon.Text = "WFInfo"
        '
        'trayMenu
        '
        Me.trayMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.trayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.trayShow, Me.trayRelics, Me.trayEquipment, Me.ToolStripSeparator1, Me.trayExit})
        Me.trayMenu.Name = "trayMenu"
        Me.trayMenu.ShowImageMargin = False
        Me.trayMenu.Size = New System.Drawing.Size(108, 98)
        '
        'trayShow
        '
        Me.trayShow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.trayShow.Name = "trayShow"
        Me.trayShow.Size = New System.Drawing.Size(107, 22)
        Me.trayShow.Text = "Show"
        Me.trayShow.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'trayRelics
        '
        Me.trayRelics.Name = "trayRelics"
        Me.trayRelics.Size = New System.Drawing.Size(107, 22)
        Me.trayRelics.Text = "Relics"
        '
        'trayEquipment
        '
        Me.trayEquipment.Name = "trayEquipment"
        Me.trayEquipment.Size = New System.Drawing.Size(107, 22)
        Me.trayEquipment.Text = "Equipment"
        Me.trayEquipment.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(104, 6)
        '
        'trayExit
        '
        Me.trayExit.Name = "trayExit"
        Me.trayExit.Size = New System.Drawing.Size(107, 22)
        Me.trayExit.Text = "Exit"
        '
        'pbHome
        '
        Me.pbHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.pbHome.Image = Global.WFInfo.My.Resources.Resources.home
        Me.pbHome.Location = New System.Drawing.Point(305, 30)
        Me.pbHome.Name = "pbHome"
        Me.pbHome.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.pbHome.Size = New System.Drawing.Size(28, 21)
        Me.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHome.TabIndex = 17
        Me.pbHome.TabStop = False
        '
        'pbEqmt
        '
        Me.pbEqmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.pbEqmt.Image = Global.WFInfo.My.Resources.Resources.foundry
        Me.pbEqmt.Location = New System.Drawing.Point(305, 80)
        Me.pbEqmt.Name = "pbEqmt"
        Me.pbEqmt.Padding = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.pbEqmt.Size = New System.Drawing.Size(28, 21)
        Me.pbEqmt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEqmt.TabIndex = 16
        Me.pbEqmt.TabStop = False
        '
        'pbSettings
        '
        Me.pbSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.pbSettings.Image = Global.WFInfo.My.Resources.Resources.Settings
        Me.pbSettings.Location = New System.Drawing.Point(305, 105)
        Me.pbSettings.Name = "pbSettings"
        Me.pbSettings.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.pbSettings.Size = New System.Drawing.Size(28, 21)
        Me.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSettings.TabIndex = 15
        Me.pbSettings.TabStop = False
        '
        'pbRelic
        '
        Me.pbRelic.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.pbRelic.Image = Global.WFInfo.My.Resources.Resources.Relic
        Me.pbRelic.Location = New System.Drawing.Point(305, 55)
        Me.pbRelic.Name = "pbRelic"
        Me.pbRelic.Padding = New System.Windows.Forms.Padding(9, 0, 8, 0)
        Me.pbRelic.Size = New System.Drawing.Size(28, 21)
        Me.pbRelic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRelic.TabIndex = 14
        Me.pbRelic.TabStop = False
        '
        'pbSideBar
        '
        Me.pbSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.pbSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbSideBar.Location = New System.Drawing.Point(304, 25)
        Me.pbSideBar.Name = "pbSideBar"
        Me.pbSideBar.Size = New System.Drawing.Size(30, 106)
        Me.pbSideBar.TabIndex = 18
        Me.pbSideBar.TabStop = False
        '
        'OutOfDate
        '
        Me.OutOfDate.AutoPopDelay = 5000
        Me.OutOfDate.InitialDelay = 200
        Me.OutOfDate.ReshowDelay = 100
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(334, 131)
        Me.Controls.Add(Me.pbHome)
        Me.Controls.Add(Me.pbEqmt)
        Me.Controls.Add(Me.pbSettings)
        Me.Controls.Add(Me.pbRelic)
        Me.Controls.Add(Me.pbSideBar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "WFInfo"
        Me.Panel1.ResumeLayout(False)
        Me.pTitle.ResumeLayout(False)
        Me.pTitle.PerformLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.trayMenu.ResumeLayout(False)
        CType(Me.pbHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEqmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRelic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSideBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbSideBar As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbTitle As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents pbIcon As PictureBox
    Friend WithEvents pTitle As Panel
    Friend WithEvents lbVersion As Label
    Friend WithEvents tUpdate As Timer
    Friend WithEvents trayIcon As NotifyIcon
    Friend WithEvents btnHide As Button
    Friend WithEvents trayMenu As ContextMenuStrip
    Friend WithEvents trayShow As ToolStripMenuItem
    Friend WithEvents trayRelics As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents trayExit As ToolStripMenuItem
    Friend WithEvents trayEquipment As ToolStripMenuItem
    Friend WithEvents lbMarketDate As Label
    Friend WithEvents lbMarket As Label
    Friend WithEvents lbEqmt As Label
    Friend WithEvents lbEqmtDate As Label
    Friend WithEvents lbWiki As Label
    Friend WithEvents lbWikiDate As Label
    Friend WithEvents pbRelic As PictureBox
    Friend WithEvents pbSettings As PictureBox
    Friend WithEvents pbEqmt As PictureBox
    Friend WithEvents pbHome As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbStatus As Label
    Friend WithEvents OutOfDate As ToolTip
    Friend WithEvents Button1 As Button
End Class
