﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFanartTVMediaSettingsHolder_Movie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFanartTVMediaSettingsHolder_Movie))
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.pnlSettingsMain = New System.Windows.Forms.Panel()
        Me.tblSettingsMain = New System.Windows.Forms.TableLayoutPanel()
        Me.gbScraperImagesOpts = New System.Windows.Forms.GroupBox()
        Me.tblScraperImagesOpts = New System.Windows.Forms.TableLayoutPanel()
        Me.chkScrapeLandscape = New System.Windows.Forms.CheckBox()
        Me.chkScrapeClearLogoOnlyHD = New System.Windows.Forms.CheckBox()
        Me.chkScrapeClearArtOnlyHD = New System.Windows.Forms.CheckBox()
        Me.chkScrapeClearArt = New System.Windows.Forms.CheckBox()
        Me.chkScrapeClearLogo = New System.Windows.Forms.CheckBox()
        Me.chkScrapeFanart = New System.Windows.Forms.CheckBox()
        Me.chkScrapeDiscArt = New System.Windows.Forms.CheckBox()
        Me.chkScrapeBanner = New System.Windows.Forms.CheckBox()
        Me.chkScrapePoster = New System.Windows.Forms.CheckBox()
        Me.gbScraperOpts = New System.Windows.Forms.GroupBox()
        Me.tblScraperOpts = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAPIHint = New System.Windows.Forms.Label()
        Me.lblAPIKey = New System.Windows.Forms.Label()
        Me.pbFANARTTV = New System.Windows.Forms.PictureBox()
        Me.txtApiKey = New System.Windows.Forms.TextBox()
        Me.btnUnlockAPI = New System.Windows.Forms.Button()
        Me.lblEMMAPI = New System.Windows.Forms.Label()
        Me.chkGetBlankImages = New System.Windows.Forms.CheckBox()
        Me.chkGetEnglishImages = New System.Windows.Forms.CheckBox()
        Me.chkPrefLanguageOnly = New System.Windows.Forms.CheckBox()
        Me.cbPrefLanguage = New System.Windows.Forms.ComboBox()
        Me.lblPrefLanguage = New System.Windows.Forms.Label()
        Me.pnlSettingsBottom = New System.Windows.Forms.Panel()
        Me.tblSettingsBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.pbIconBottom = New System.Windows.Forms.PictureBox()
        Me.lblInfoBottom = New System.Windows.Forms.Label()
        Me.pnlSettingsTop = New System.Windows.Forms.Panel()
        Me.tblSettingsTop = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.lblScraperOrder = New System.Windows.Forms.Label()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.chkEnabled = New System.Windows.Forms.CheckBox()
        Me.pnlSettings.SuspendLayout()
        Me.pnlSettingsMain.SuspendLayout()
        Me.tblSettingsMain.SuspendLayout()
        Me.gbScraperImagesOpts.SuspendLayout()
        Me.tblScraperImagesOpts.SuspendLayout()
        Me.gbScraperOpts.SuspendLayout()
        Me.tblScraperOpts.SuspendLayout()
        CType(Me.pbFANARTTV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSettingsBottom.SuspendLayout()
        Me.tblSettingsBottom.SuspendLayout()
        CType(Me.pbIconBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSettingsTop.SuspendLayout()
        Me.tblSettingsTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSettings
        '
        Me.pnlSettings.AutoSize = True
        Me.pnlSettings.Controls.Add(Me.pnlSettingsMain)
        Me.pnlSettings.Controls.Add(Me.pnlSettingsBottom)
        Me.pnlSettings.Controls.Add(Me.pnlSettingsTop)
        Me.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSettings.Location = New System.Drawing.Point(0, 0)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(452, 408)
        Me.pnlSettings.TabIndex = 0
        '
        'pnlSettingsMain
        '
        Me.pnlSettingsMain.AutoSize = True
        Me.pnlSettingsMain.Controls.Add(Me.tblSettingsMain)
        Me.pnlSettingsMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSettingsMain.Location = New System.Drawing.Point(0, 29)
        Me.pnlSettingsMain.Name = "pnlSettingsMain"
        Me.pnlSettingsMain.Size = New System.Drawing.Size(452, 342)
        Me.pnlSettingsMain.TabIndex = 98
        '
        'tblSettingsMain
        '
        Me.tblSettingsMain.AutoScroll = True
        Me.tblSettingsMain.AutoSize = True
        Me.tblSettingsMain.ColumnCount = 2
        Me.tblSettingsMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsMain.Controls.Add(Me.gbScraperImagesOpts, 0, 0)
        Me.tblSettingsMain.Controls.Add(Me.gbScraperOpts, 0, 1)
        Me.tblSettingsMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblSettingsMain.Location = New System.Drawing.Point(0, 0)
        Me.tblSettingsMain.Name = "tblSettingsMain"
        Me.tblSettingsMain.RowCount = 3
        Me.tblSettingsMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsMain.Size = New System.Drawing.Size(452, 342)
        Me.tblSettingsMain.TabIndex = 0
        '
        'gbScraperImagesOpts
        '
        Me.gbScraperImagesOpts.AutoSize = True
        Me.gbScraperImagesOpts.Controls.Add(Me.tblScraperImagesOpts)
        Me.gbScraperImagesOpts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbScraperImagesOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbScraperImagesOpts.Location = New System.Drawing.Point(3, 3)
        Me.gbScraperImagesOpts.Name = "gbScraperImagesOpts"
        Me.gbScraperImagesOpts.Size = New System.Drawing.Size(432, 136)
        Me.gbScraperImagesOpts.TabIndex = 96
        Me.gbScraperImagesOpts.TabStop = False
        Me.gbScraperImagesOpts.Text = "Images - Scraper specific"
        '
        'tblScraperImagesOpts
        '
        Me.tblScraperImagesOpts.AutoSize = True
        Me.tblScraperImagesOpts.ColumnCount = 3
        Me.tblScraperImagesOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperImagesOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperImagesOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperImagesOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblScraperImagesOpts.Controls.Add(Me.chkScrapeLandscape, 1, 2)
        Me.tblScraperImagesOpts.Controls.Add(Me.chkScrapeClearLogoOnlyHD, 0, 4)
        Me.tblScraperImagesOpts.Controls.Add(Me.chkScrapeClearArtOnlyHD, 0, 2)
        Me.tblScraperImagesOpts.Controls.Add(Me.chkScrapeClearArt, 0, 1)
        Me.tblScraperImagesOpts.Controls.Add(Me.chkScrapeClearLogo, 0, 3)
        Me.tblScraperImagesOpts.Controls.Add(Me.chkScrapeFanart, 1, 1)
        Me.tblScraperImagesOpts.Controls.Add(Me.chkScrapeDiscArt, 1, 0)
        Me.tblScraperImagesOpts.Controls.Add(Me.chkScrapeBanner, 0, 0)
        Me.tblScraperImagesOpts.Controls.Add(Me.chkScrapePoster, 1, 3)
        Me.tblScraperImagesOpts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblScraperImagesOpts.Location = New System.Drawing.Point(3, 18)
        Me.tblScraperImagesOpts.Name = "tblScraperImagesOpts"
        Me.tblScraperImagesOpts.RowCount = 6
        Me.tblScraperImagesOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperImagesOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperImagesOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperImagesOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperImagesOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperImagesOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperImagesOpts.Size = New System.Drawing.Size(426, 115)
        Me.tblScraperImagesOpts.TabIndex = 98
        '
        'chkScrapeLandscape
        '
        Me.chkScrapeLandscape.AutoSize = True
        Me.chkScrapeLandscape.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeLandscape.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapeLandscape.Location = New System.Drawing.Point(108, 49)
        Me.chkScrapeLandscape.Name = "chkScrapeLandscape"
        Me.chkScrapeLandscape.Size = New System.Drawing.Size(101, 17)
        Me.chkScrapeLandscape.TabIndex = 7
        Me.chkScrapeLandscape.Text = "Get Landscape"
        Me.chkScrapeLandscape.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeLandscape.UseVisualStyleBackColor = True
        '
        'chkScrapeClearLogoOnlyHD
        '
        Me.chkScrapeClearLogoOnlyHD.AutoSize = True
        Me.chkScrapeClearLogoOnlyHD.Enabled = False
        Me.chkScrapeClearLogoOnlyHD.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.chkScrapeClearLogoOnlyHD.Location = New System.Drawing.Point(3, 95)
        Me.chkScrapeClearLogoOnlyHD.Name = "chkScrapeClearLogoOnlyHD"
        Me.chkScrapeClearLogoOnlyHD.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.chkScrapeClearLogoOnlyHD.Size = New System.Drawing.Size(89, 17)
        Me.chkScrapeClearLogoOnlyHD.TabIndex = 8
        Me.chkScrapeClearLogoOnlyHD.Text = "Only HD"
        Me.chkScrapeClearLogoOnlyHD.UseVisualStyleBackColor = True
        '
        'chkScrapeClearArtOnlyHD
        '
        Me.chkScrapeClearArtOnlyHD.AutoSize = True
        Me.chkScrapeClearArtOnlyHD.Enabled = False
        Me.chkScrapeClearArtOnlyHD.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.chkScrapeClearArtOnlyHD.Location = New System.Drawing.Point(3, 49)
        Me.chkScrapeClearArtOnlyHD.Name = "chkScrapeClearArtOnlyHD"
        Me.chkScrapeClearArtOnlyHD.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.chkScrapeClearArtOnlyHD.Size = New System.Drawing.Size(89, 17)
        Me.chkScrapeClearArtOnlyHD.TabIndex = 9
        Me.chkScrapeClearArtOnlyHD.Text = "Only HD"
        Me.chkScrapeClearArtOnlyHD.UseVisualStyleBackColor = True
        '
        'chkScrapeClearArt
        '
        Me.chkScrapeClearArt.AutoSize = True
        Me.chkScrapeClearArt.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeClearArt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapeClearArt.Location = New System.Drawing.Point(3, 26)
        Me.chkScrapeClearArt.Name = "chkScrapeClearArt"
        Me.chkScrapeClearArt.Size = New System.Drawing.Size(88, 17)
        Me.chkScrapeClearArt.TabIndex = 4
        Me.chkScrapeClearArt.Text = "Get ClearArt"
        Me.chkScrapeClearArt.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeClearArt.UseVisualStyleBackColor = True
        '
        'chkScrapeClearLogo
        '
        Me.chkScrapeClearLogo.AutoSize = True
        Me.chkScrapeClearLogo.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeClearLogo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapeClearLogo.Location = New System.Drawing.Point(3, 72)
        Me.chkScrapeClearLogo.Name = "chkScrapeClearLogo"
        Me.chkScrapeClearLogo.Size = New System.Drawing.Size(99, 17)
        Me.chkScrapeClearLogo.TabIndex = 3
        Me.chkScrapeClearLogo.Text = "Get ClearLogo"
        Me.chkScrapeClearLogo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeClearLogo.UseVisualStyleBackColor = True
        '
        'chkScrapeFanart
        '
        Me.chkScrapeFanart.AutoSize = True
        Me.chkScrapeFanart.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeFanart.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapeFanart.Location = New System.Drawing.Point(108, 26)
        Me.chkScrapeFanart.Name = "chkScrapeFanart"
        Me.chkScrapeFanart.Size = New System.Drawing.Size(80, 17)
        Me.chkScrapeFanart.TabIndex = 1
        Me.chkScrapeFanart.Text = "Get Fanart"
        Me.chkScrapeFanart.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeFanart.UseVisualStyleBackColor = True
        '
        'chkScrapeDiscArt
        '
        Me.chkScrapeDiscArt.AutoSize = True
        Me.chkScrapeDiscArt.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeDiscArt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapeDiscArt.Location = New System.Drawing.Point(108, 3)
        Me.chkScrapeDiscArt.Name = "chkScrapeDiscArt"
        Me.chkScrapeDiscArt.Size = New System.Drawing.Size(83, 17)
        Me.chkScrapeDiscArt.TabIndex = 6
        Me.chkScrapeDiscArt.Text = "Get DiscArt"
        Me.chkScrapeDiscArt.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeDiscArt.UseVisualStyleBackColor = True
        '
        'chkScrapeBanner
        '
        Me.chkScrapeBanner.AutoSize = True
        Me.chkScrapeBanner.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeBanner.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapeBanner.Location = New System.Drawing.Point(3, 3)
        Me.chkScrapeBanner.Name = "chkScrapeBanner"
        Me.chkScrapeBanner.Size = New System.Drawing.Size(84, 17)
        Me.chkScrapeBanner.TabIndex = 2
        Me.chkScrapeBanner.Text = "Get Banner"
        Me.chkScrapeBanner.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapeBanner.UseVisualStyleBackColor = True
        '
        'chkScrapePoster
        '
        Me.chkScrapePoster.AutoSize = True
        Me.chkScrapePoster.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapePoster.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkScrapePoster.Location = New System.Drawing.Point(108, 72)
        Me.chkScrapePoster.Name = "chkScrapePoster"
        Me.chkScrapePoster.Size = New System.Drawing.Size(79, 17)
        Me.chkScrapePoster.TabIndex = 0
        Me.chkScrapePoster.Text = "Get Poster"
        Me.chkScrapePoster.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkScrapePoster.UseVisualStyleBackColor = True
        '
        'gbScraperOpts
        '
        Me.gbScraperOpts.AutoSize = True
        Me.gbScraperOpts.Controls.Add(Me.tblScraperOpts)
        Me.gbScraperOpts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbScraperOpts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gbScraperOpts.Location = New System.Drawing.Point(3, 145)
        Me.gbScraperOpts.Name = "gbScraperOpts"
        Me.gbScraperOpts.Size = New System.Drawing.Size(432, 183)
        Me.gbScraperOpts.TabIndex = 95
        Me.gbScraperOpts.TabStop = False
        Me.gbScraperOpts.Text = "Scraper Options"
        '
        'tblScraperOpts
        '
        Me.tblScraperOpts.AutoSize = True
        Me.tblScraperOpts.ColumnCount = 5
        Me.tblScraperOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperOpts.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblScraperOpts.Controls.Add(Me.lblAPIHint, 0, 2)
        Me.tblScraperOpts.Controls.Add(Me.lblAPIKey, 0, 0)
        Me.tblScraperOpts.Controls.Add(Me.pbFANARTTV, 3, 1)
        Me.tblScraperOpts.Controls.Add(Me.txtApiKey, 2, 1)
        Me.tblScraperOpts.Controls.Add(Me.btnUnlockAPI, 0, 1)
        Me.tblScraperOpts.Controls.Add(Me.lblEMMAPI, 2, 0)
        Me.tblScraperOpts.Controls.Add(Me.chkGetBlankImages, 2, 5)
        Me.tblScraperOpts.Controls.Add(Me.chkGetEnglishImages, 2, 4)
        Me.tblScraperOpts.Controls.Add(Me.chkPrefLanguageOnly, 2, 3)
        Me.tblScraperOpts.Controls.Add(Me.cbPrefLanguage, 1, 3)
        Me.tblScraperOpts.Controls.Add(Me.lblPrefLanguage, 0, 3)
        Me.tblScraperOpts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblScraperOpts.Location = New System.Drawing.Point(3, 18)
        Me.tblScraperOpts.Name = "tblScraperOpts"
        Me.tblScraperOpts.RowCount = 7
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperOpts.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblScraperOpts.Size = New System.Drawing.Size(426, 162)
        Me.tblScraperOpts.TabIndex = 98
        '
        'lblAPIHint
        '
        Me.lblAPIHint.AutoSize = True
        Me.tblScraperOpts.SetColumnSpan(Me.lblAPIHint, 4)
        Me.lblAPIHint.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblAPIHint.Location = New System.Drawing.Point(3, 49)
        Me.lblAPIHint.MaximumSize = New System.Drawing.Size(430, 0)
        Me.lblAPIHint.Name = "lblAPIHint"
        Me.lblAPIHint.Size = New System.Drawing.Size(407, 26)
        Me.lblAPIHint.TabIndex = 24
        Me.lblAPIHint.Text = "Using a Personal API Key reduces the time you have to wait for new images to show" & _
    " up from 7 days to 48 hours."
        '
        'lblAPIKey
        '
        Me.lblAPIKey.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAPIKey.AutoSize = True
        Me.tblScraperOpts.SetColumnSpan(Me.lblAPIKey, 2)
        Me.lblAPIKey.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPIKey.Location = New System.Drawing.Point(3, 3)
        Me.lblAPIKey.Name = "lblAPIKey"
        Me.lblAPIKey.Size = New System.Drawing.Size(141, 13)
        Me.lblAPIKey.TabIndex = 0
        Me.lblAPIKey.Text = "Fanart.tv Personal API Key:"
        '
        'pbFANARTTV
        '
        Me.pbFANARTTV.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbFANARTTV.Image = CType(resources.GetObject("pbFANARTTV.Image"), System.Drawing.Image)
        Me.pbFANARTTV.Location = New System.Drawing.Point(407, 26)
        Me.pbFANARTTV.Name = "pbFANARTTV"
        Me.pbFANARTTV.Size = New System.Drawing.Size(16, 16)
        Me.pbFANARTTV.TabIndex = 6
        Me.pbFANARTTV.TabStop = False
        '
        'txtApiKey
        '
        Me.txtApiKey.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtApiKey.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApiKey.Location = New System.Drawing.Point(171, 23)
        Me.txtApiKey.Name = "txtApiKey"
        Me.txtApiKey.Size = New System.Drawing.Size(230, 22)
        Me.txtApiKey.TabIndex = 1
        '
        'btnUnlockAPI
        '
        Me.btnUnlockAPI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tblScraperOpts.SetColumnSpan(Me.btnUnlockAPI, 2)
        Me.btnUnlockAPI.Location = New System.Drawing.Point(3, 23)
        Me.btnUnlockAPI.Name = "btnUnlockAPI"
        Me.btnUnlockAPI.Size = New System.Drawing.Size(162, 23)
        Me.btnUnlockAPI.TabIndex = 11
        Me.btnUnlockAPI.Text = "Use my own API key"
        Me.btnUnlockAPI.UseVisualStyleBackColor = True
        '
        'lblEMMAPI
        '
        Me.lblEMMAPI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEMMAPI.AutoSize = True
        Me.tblScraperOpts.SetColumnSpan(Me.lblEMMAPI, 2)
        Me.lblEMMAPI.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblEMMAPI.Location = New System.Drawing.Point(171, 3)
        Me.lblEMMAPI.Name = "lblEMMAPI"
        Me.lblEMMAPI.Size = New System.Drawing.Size(220, 13)
        Me.lblEMMAPI.TabIndex = 12
        Me.lblEMMAPI.Text = "Ember Media Manager Embedded API key"
        '
        'chkGetBlankImages
        '
        Me.chkGetBlankImages.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkGetBlankImages.AutoSize = True
        Me.tblScraperOpts.SetColumnSpan(Me.chkGetBlankImages, 2)
        Me.chkGetBlankImages.Enabled = False
        Me.chkGetBlankImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGetBlankImages.Location = New System.Drawing.Point(171, 142)
        Me.chkGetBlankImages.Name = "chkGetBlankImages"
        Me.chkGetBlankImages.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.chkGetBlankImages.Size = New System.Drawing.Size(160, 17)
        Me.chkGetBlankImages.TabIndex = 19
        Me.chkGetBlankImages.Text = "Also Get Blank Images"
        Me.chkGetBlankImages.UseVisualStyleBackColor = True
        '
        'chkGetEnglishImages
        '
        Me.chkGetEnglishImages.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkGetEnglishImages.AutoSize = True
        Me.tblScraperOpts.SetColumnSpan(Me.chkGetEnglishImages, 2)
        Me.chkGetEnglishImages.Enabled = False
        Me.chkGetEnglishImages.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGetEnglishImages.Location = New System.Drawing.Point(171, 119)
        Me.chkGetEnglishImages.Name = "chkGetEnglishImages"
        Me.chkGetEnglishImages.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.chkGetEnglishImages.Size = New System.Drawing.Size(169, 17)
        Me.chkGetEnglishImages.TabIndex = 17
        Me.chkGetEnglishImages.Text = "Also Get English Images"
        Me.chkGetEnglishImages.UseVisualStyleBackColor = True
        '
        'chkPrefLanguageOnly
        '
        Me.chkPrefLanguageOnly.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkPrefLanguageOnly.AutoSize = True
        Me.tblScraperOpts.SetColumnSpan(Me.chkPrefLanguageOnly, 2)
        Me.chkPrefLanguageOnly.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrefLanguageOnly.Location = New System.Drawing.Point(171, 94)
        Me.chkPrefLanguageOnly.Name = "chkPrefLanguageOnly"
        Me.chkPrefLanguageOnly.Size = New System.Drawing.Size(248, 17)
        Me.chkPrefLanguageOnly.TabIndex = 18
        Me.chkPrefLanguageOnly.Text = "Only Get Images for the Selected Language"
        Me.chkPrefLanguageOnly.UseVisualStyleBackColor = True
        '
        'cbPrefLanguage
        '
        Me.cbPrefLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbPrefLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPrefLanguage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cbPrefLanguage.FormattingEnabled = True
        Me.cbPrefLanguage.Items.AddRange(New Object() {"bg", "cs", "da", "de", "el", "en", "es", "fi", "fr", "he", "hu", "it", "nb", "nl", "no", "pl", "pt", "ru", "sk", "sv", "ta", "tr", "uk", "vi", "xx", "zh"})
        Me.cbPrefLanguage.Location = New System.Drawing.Point(120, 92)
        Me.cbPrefLanguage.Name = "cbPrefLanguage"
        Me.cbPrefLanguage.Size = New System.Drawing.Size(45, 21)
        Me.cbPrefLanguage.TabIndex = 8
        '
        'lblPrefLanguage
        '
        Me.lblPrefLanguage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblPrefLanguage.AutoSize = True
        Me.lblPrefLanguage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblPrefLanguage.Location = New System.Drawing.Point(3, 96)
        Me.lblPrefLanguage.Name = "lblPrefLanguage"
        Me.lblPrefLanguage.Size = New System.Drawing.Size(111, 13)
        Me.lblPrefLanguage.TabIndex = 7
        Me.lblPrefLanguage.Text = "Preferred Language:"
        '
        'pnlSettingsBottom
        '
        Me.pnlSettingsBottom.AutoSize = True
        Me.pnlSettingsBottom.Controls.Add(Me.tblSettingsBottom)
        Me.pnlSettingsBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlSettingsBottom.Location = New System.Drawing.Point(0, 371)
        Me.pnlSettingsBottom.Name = "pnlSettingsBottom"
        Me.pnlSettingsBottom.Size = New System.Drawing.Size(452, 37)
        Me.pnlSettingsBottom.TabIndex = 97
        '
        'tblSettingsBottom
        '
        Me.tblSettingsBottom.AutoSize = True
        Me.tblSettingsBottom.ColumnCount = 3
        Me.tblSettingsBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsBottom.Controls.Add(Me.pbIconBottom, 0, 0)
        Me.tblSettingsBottom.Controls.Add(Me.lblInfoBottom, 1, 0)
        Me.tblSettingsBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblSettingsBottom.Location = New System.Drawing.Point(0, 0)
        Me.tblSettingsBottom.Name = "tblSettingsBottom"
        Me.tblSettingsBottom.RowCount = 2
        Me.tblSettingsBottom.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsBottom.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsBottom.Size = New System.Drawing.Size(452, 37)
        Me.tblSettingsBottom.TabIndex = 98
        '
        'pbIconBottom
        '
        Me.pbIconBottom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbIconBottom.Image = CType(resources.GetObject("pbIconBottom.Image"), System.Drawing.Image)
        Me.pbIconBottom.Location = New System.Drawing.Point(3, 3)
        Me.pbIconBottom.Name = "pbIconBottom"
        Me.pbIconBottom.Size = New System.Drawing.Size(30, 31)
        Me.pbIconBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbIconBottom.TabIndex = 94
        Me.pbIconBottom.TabStop = False
        '
        'lblInfoBottom
        '
        Me.lblInfoBottom.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblInfoBottom.AutoSize = True
        Me.lblInfoBottom.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblInfoBottom.ForeColor = System.Drawing.Color.Blue
        Me.lblInfoBottom.Location = New System.Drawing.Point(39, 6)
        Me.lblInfoBottom.Name = "lblInfoBottom"
        Me.lblInfoBottom.Size = New System.Drawing.Size(205, 24)
        Me.lblInfoBottom.TabIndex = 3
        Me.lblInfoBottom.Text = "These settings are specific to this module." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please refer to the global settings " & _
    "for more options."
        Me.lblInfoBottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlSettingsTop
        '
        Me.pnlSettingsTop.AutoSize = True
        Me.pnlSettingsTop.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSettingsTop.Controls.Add(Me.tblSettingsTop)
        Me.pnlSettingsTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSettingsTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlSettingsTop.Name = "pnlSettingsTop"
        Me.pnlSettingsTop.Size = New System.Drawing.Size(452, 29)
        Me.pnlSettingsTop.TabIndex = 0
        '
        'tblSettingsTop
        '
        Me.tblSettingsTop.AutoSize = True
        Me.tblSettingsTop.ColumnCount = 5
        Me.tblSettingsTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblSettingsTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSettingsTop.Controls.Add(Me.btnDown, 4, 0)
        Me.tblSettingsTop.Controls.Add(Me.lblScraperOrder, 2, 0)
        Me.tblSettingsTop.Controls.Add(Me.btnUp, 3, 0)
        Me.tblSettingsTop.Controls.Add(Me.chkEnabled, 0, 0)
        Me.tblSettingsTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblSettingsTop.Location = New System.Drawing.Point(0, 0)
        Me.tblSettingsTop.Name = "tblSettingsTop"
        Me.tblSettingsTop.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.tblSettingsTop.RowCount = 2
        Me.tblSettingsTop.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsTop.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSettingsTop.Size = New System.Drawing.Size(452, 29)
        Me.tblSettingsTop.TabIndex = 99
        '
        'btnDown
        '
        Me.btnDown.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(426, 3)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(23, 23)
        Me.btnDown.TabIndex = 3
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'lblScraperOrder
        '
        Me.lblScraperOrder.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblScraperOrder.AutoSize = True
        Me.lblScraperOrder.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScraperOrder.Location = New System.Drawing.Point(333, 8)
        Me.lblScraperOrder.Name = "lblScraperOrder"
        Me.lblScraperOrder.Size = New System.Drawing.Size(58, 12)
        Me.lblScraperOrder.TabIndex = 1
        Me.lblScraperOrder.Text = "Scraper order"
        '
        'btnUp
        '
        Me.btnUp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(397, 3)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(23, 23)
        Me.btnUp.TabIndex = 2
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'chkEnabled
        '
        Me.chkEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.chkEnabled.AutoSize = True
        Me.chkEnabled.Location = New System.Drawing.Point(8, 6)
        Me.chkEnabled.Name = "chkEnabled"
        Me.chkEnabled.Size = New System.Drawing.Size(68, 17)
        Me.chkEnabled.TabIndex = 0
        Me.chkEnabled.Text = "Enabled"
        Me.chkEnabled.UseVisualStyleBackColor = True
        '
        'frmFanartTVMediaSettingsHolder_Movie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 408)
        Me.Controls.Add(Me.pnlSettings)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFanartTVMediaSettingsHolder_Movie"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scraper Setup"
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        Me.pnlSettingsMain.ResumeLayout(False)
        Me.pnlSettingsMain.PerformLayout()
        Me.tblSettingsMain.ResumeLayout(False)
        Me.tblSettingsMain.PerformLayout()
        Me.gbScraperImagesOpts.ResumeLayout(False)
        Me.gbScraperImagesOpts.PerformLayout()
        Me.tblScraperImagesOpts.ResumeLayout(False)
        Me.tblScraperImagesOpts.PerformLayout()
        Me.gbScraperOpts.ResumeLayout(False)
        Me.gbScraperOpts.PerformLayout()
        Me.tblScraperOpts.ResumeLayout(False)
        Me.tblScraperOpts.PerformLayout()
        CType(Me.pbFANARTTV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSettingsBottom.ResumeLayout(False)
        Me.pnlSettingsBottom.PerformLayout()
        Me.tblSettingsBottom.ResumeLayout(False)
        Me.tblSettingsBottom.PerformLayout()
        CType(Me.pbIconBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSettingsTop.ResumeLayout(False)
        Me.pnlSettingsTop.PerformLayout()
        Me.tblSettingsTop.ResumeLayout(False)
        Me.tblSettingsTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlSettings As System.Windows.Forms.Panel
    Friend WithEvents pnlSettingsTop As System.Windows.Forms.Panel
    Friend WithEvents chkEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents lblScraperOrder As System.Windows.Forms.Label
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents lblInfoBottom As System.Windows.Forms.Label
    Friend WithEvents pbIconBottom As System.Windows.Forms.PictureBox
    Friend WithEvents gbScraperOpts As System.Windows.Forms.GroupBox
    Friend WithEvents pbFANARTTV As System.Windows.Forms.PictureBox
    Friend WithEvents lblAPIKey As System.Windows.Forms.Label
    Friend WithEvents txtApiKey As System.Windows.Forms.TextBox
    Friend WithEvents gbScraperImagesOpts As System.Windows.Forms.GroupBox
    Friend WithEvents chkScrapePoster As System.Windows.Forms.CheckBox
    Friend WithEvents chkScrapeFanart As System.Windows.Forms.CheckBox
    Friend WithEvents cbPrefLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrefLanguage As System.Windows.Forms.Label
    Friend WithEvents chkScrapeLandscape As System.Windows.Forms.CheckBox
    Friend WithEvents chkScrapeDiscArt As System.Windows.Forms.CheckBox
    Friend WithEvents chkScrapeClearArt As System.Windows.Forms.CheckBox
    Friend WithEvents chkScrapeClearLogo As System.Windows.Forms.CheckBox
    Friend WithEvents chkScrapeBanner As System.Windows.Forms.CheckBox
    Friend WithEvents chkScrapeClearLogoOnlyHD As System.Windows.Forms.CheckBox
    Friend WithEvents chkScrapeClearArtOnlyHD As System.Windows.Forms.CheckBox
    Friend WithEvents chkGetBlankImages As System.Windows.Forms.CheckBox
    Friend WithEvents chkPrefLanguageOnly As System.Windows.Forms.CheckBox
    Friend WithEvents chkGetEnglishImages As System.Windows.Forms.CheckBox
    Friend WithEvents lblAPIHint As System.Windows.Forms.Label
    Friend WithEvents tblSettingsBottom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlSettingsBottom As System.Windows.Forms.Panel
    Friend WithEvents tblScraperImagesOpts As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblEMMAPI As System.Windows.Forms.Label
    Friend WithEvents btnUnlockAPI As System.Windows.Forms.Button
    Friend WithEvents tblScraperOpts As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlSettingsMain As System.Windows.Forms.Panel
    Friend WithEvents tblSettingsMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblSettingsTop As System.Windows.Forms.TableLayoutPanel

End Class