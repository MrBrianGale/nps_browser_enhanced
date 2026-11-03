namespace NPS
{
    partial class NPSBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties2 = new PresentationControls.CheckBoxProperties();
            mnuMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            reloadToolStripMenuItem = new ToolStripMenuItem();
            ts_changeLog = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            downloadUpdateToolStripMenuItem = new ToolStripMenuItem();
            downloadToolStripMenuItem = new ToolStripMenuItem();
            changelogToolStripMenuItem = new ToolStripMenuItem();
            showDescriptionPanelToolStripMenuItem = new ToolStripMenuItem();
            libraryToolStripMenuItem = new ToolStripMenuItem();
            iGDBToolStripMenuItem = new ToolStripMenuItem();
            tESTToolStripMenuItem = new ToolStripMenuItem();
            lstTitles = new ListView();
            colTitleID = new ColumnHeader();
            colRegion = new ColumnHeader();
            colTitle = new ColumnHeader();
            colType = new ColumnHeader();
            colDLCs = new ColumnHeader();
            colLastModified = new ColumnHeader();
            lstTitlesMenuStrip = new ContextMenuStrip(components);
            downloadAndUnpackToolStripMenuItem = new ToolStripMenuItem();
            showTitleDlcToolStripMenuItem = new ToolStripMenuItem();
            downloadAllDlcsToolStripMenuItem = new ToolStripMenuItem();
            downloadAllToolStripMenuItem = new ToolStripMenuItem();
            downloadAllWithPatchesToolStripMenuItem = new ToolStripMenuItem();
            checkForPatchesToolStripMenuItem = new ToolStripMenuItem();
            toggleDownloadedToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            txtSearch = new TextBox();
            btnDownload = new Button();
            rbnGames = new RadioButton();
            rbnDLC = new RadioButton();
            label4 = new Label();
            ptbCover = new PictureBox();
            label5 = new Label();
            lstDownloadStatusMenuStrip = new ContextMenuStrip(components);
            pauseToolStripMenuItem = new ToolStripMenuItem();
            resumeToolStripMenuItem = new ToolStripMenuItem();
            cancelToolStripMenuItem = new ToolStripMenuItem();
            retryUnpackToolStripMenuItem = new ToolStripMenuItem();
            clearCompletedToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            lnkOpenRenaScene = new LinkLabel();
            pnlMain = new Panel();
            splMain = new SplitContainer();
            splList = new SplitContainer();
            pnlSearch = new Panel();
            cmbType = new PresentationControls.CheckBoxComboBox();
            cmbRegion = new PresentationControls.CheckBoxComboBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            lblCount = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rbnAvatars = new RadioButton();
            rbnThemes = new RadioButton();
            rbnUpdates = new RadioButton();
            lGameCount = new Label();
            btnNextInfo = new Button();
            groupBox1 = new GroupBox();
            lScreenshotCount = new Label();
            tbSummary = new RichTextBox();
            tbGenres = new TextBox();
            tbGameMode = new TextBox();
            tbPlatforms = new TextBox();
            tbGameName = new TextBox();
            bNextSS = new Button();
            bPrevSS = new Button();
            pbScreenshots = new PictureBox();
            lSummary = new Label();
            lGenres = new Label();
            lGameMode = new Label();
            lPlatforms = new Label();
            lGameName = new Label();
            imgCover = new PictureBox();
            btnPrevInfo = new Button();
            rbnDownloaded = new RadioButton();
            rbnUndownloaded = new RadioButton();
            rbnAll = new RadioButton();
            chkUnless = new CheckBox();
            chkHideDownloaded = new CheckBox();
            lb_ps3licenseType = new Label();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            ResumeAll = new Button();
            button5 = new Button();
            PauseAll = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            lstDownloadStatus = new ListViewEmbeddedControls.ListViewEx();
            colDownloadTitle = new ColumnHeader();
            colDownloadSpeed = new ColumnHeader();
            colDownloadStatus = new ColumnHeader();
            colDownloadProgress = new ColumnHeader();
            colDownloadError = new ColumnHeader();
            mnuMain.SuspendLayout();
            lstTitlesMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbCover).BeginInit();
            lstDownloadStatusMenuStrip.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splMain).BeginInit();
            splMain.Panel1.SuspendLayout();
            splMain.Panel2.SuspendLayout();
            splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splList).BeginInit();
            splList.Panel1.SuspendLayout();
            splList.Panel2.SuspendLayout();
            splList.SuspendLayout();
            pnlSearch.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbScreenshots).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, downloadUpdateToolStripMenuItem, showDescriptionPanelToolStripMenuItem, libraryToolStripMenuItem, iGDBToolStripMenuItem });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(1385, 24);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, reloadToolStripMenuItem, ts_changeLog, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Image = Properties.Resources.menu_options;
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(133, 22);
            optionsToolStripMenuItem.Text = "Options";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // reloadToolStripMenuItem
            // 
            reloadToolStripMenuItem.Image = Properties.Resources.menu_reload;
            reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            reloadToolStripMenuItem.Size = new Size(133, 22);
            reloadToolStripMenuItem.Text = "Sync cache";
            reloadToolStripMenuItem.Click += Sync;
            // 
            // ts_changeLog
            // 
            ts_changeLog.Name = "ts_changeLog";
            ts_changeLog.Size = new Size(133, 22);
            ts_changeLog.Text = "Changelog";
            ts_changeLog.Click += ts_changeLog_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.menu_exit;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(133, 22);
            exitToolStripMenuItem.Tag = "Exit";
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // downloadUpdateToolStripMenuItem
            // 
            downloadUpdateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { downloadToolStripMenuItem, changelogToolStripMenuItem });
            downloadUpdateToolStripMenuItem.Name = "downloadUpdateToolStripMenuItem";
            downloadUpdateToolStripMenuItem.Size = new Size(113, 20);
            downloadUpdateToolStripMenuItem.Text = "Download update";
            downloadUpdateToolStripMenuItem.Visible = false;
            // 
            // downloadToolStripMenuItem
            // 
            downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            downloadToolStripMenuItem.Size = new Size(132, 22);
            downloadToolStripMenuItem.Text = "Download";
            downloadToolStripMenuItem.Click += downloadUpdateToolStripMenuItem_Click;
            // 
            // changelogToolStripMenuItem
            // 
            changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            changelogToolStripMenuItem.Size = new Size(132, 22);
            changelogToolStripMenuItem.Text = "Changelog";
            changelogToolStripMenuItem.Click += changelogToolStripMenuItem_Click;
            // 
            // showDescriptionPanelToolStripMenuItem
            // 
            showDescriptionPanelToolStripMenuItem.Name = "showDescriptionPanelToolStripMenuItem";
            showDescriptionPanelToolStripMenuItem.Size = new Size(111, 20);
            showDescriptionPanelToolStripMenuItem.Text = "Description panel";
            showDescriptionPanelToolStripMenuItem.Click += ShowDescriptionPanel;
            // 
            // libraryToolStripMenuItem
            // 
            libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
            libraryToolStripMenuItem.Size = new Size(55, 20);
            libraryToolStripMenuItem.Text = "Library";
            libraryToolStripMenuItem.Click += libraryToolStripMenuItem_Click;
            // 
            // iGDBToolStripMenuItem
            // 
            iGDBToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tESTToolStripMenuItem });
            iGDBToolStripMenuItem.Name = "iGDBToolStripMenuItem";
            iGDBToolStripMenuItem.Size = new Size(45, 20);
            iGDBToolStripMenuItem.Text = "IGDB";
            // 
            // tESTToolStripMenuItem
            // 
            tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
            tESTToolStripMenuItem.Size = new Size(171, 22);
            tESTToolStripMenuItem.Text = "Refresh Game Info";
            tESTToolStripMenuItem.Click += tESTToolStripMenuItem_Click_1;
            // 
            // lstTitles
            // 
            lstTitles.Columns.AddRange(new ColumnHeader[] { colTitleID, colRegion, colTitle, colType, colDLCs, colLastModified });
            lstTitles.ContextMenuStrip = lstTitlesMenuStrip;
            lstTitles.Dock = DockStyle.Fill;
            lstTitles.FullRowSelect = true;
            lstTitles.Location = new Point(0, 52);
            lstTitles.Name = "lstTitles";
            lstTitles.Size = new Size(722, 368);
            lstTitles.Sorting = SortOrder.Ascending;
            lstTitles.TabIndex = 1;
            lstTitles.UseCompatibleStateImageBehavior = false;
            lstTitles.View = View.Details;
            lstTitles.ColumnClick += lstTitles_ColumnClick;
            lstTitles.SelectedIndexChanged += lstTitles_SelectedIndexChanged;
            lstTitles.KeyDown += lstTitles_KeyDown;
            lstTitles.MouseClick += lstTitles_MouseClick;
            // 
            // colTitleID
            // 
            colTitleID.Text = "Title ID";
            colTitleID.Width = 80;
            // 
            // colRegion
            // 
            colRegion.Text = "Region";
            colRegion.Width = 50;
            // 
            // colTitle
            // 
            colTitle.Text = "Title";
            colTitle.Width = 393;
            // 
            // colType
            // 
            colType.Text = "Type";
            // 
            // colDLCs
            // 
            colDLCs.Text = "DLCs";
            // 
            // colLastModified
            // 
            colLastModified.Text = "Last Modified";
            colLastModified.Width = 144;
            // 
            // lstTitlesMenuStrip
            // 
            lstTitlesMenuStrip.Items.AddRange(new ToolStripItem[] { downloadAndUnpackToolStripMenuItem, showTitleDlcToolStripMenuItem, downloadAllDlcsToolStripMenuItem, downloadAllToolStripMenuItem, downloadAllWithPatchesToolStripMenuItem, checkForPatchesToolStripMenuItem, toggleDownloadedToolStripMenuItem, toolStripMenuItem1 });
            lstTitlesMenuStrip.Name = "contextMenuStrip2";
            lstTitlesMenuStrip.Size = new Size(207, 180);
            // 
            // downloadAndUnpackToolStripMenuItem
            // 
            downloadAndUnpackToolStripMenuItem.Image = Properties.Resources.menu_unpack;
            downloadAndUnpackToolStripMenuItem.Name = "downloadAndUnpackToolStripMenuItem";
            downloadAndUnpackToolStripMenuItem.Size = new Size(206, 22);
            downloadAndUnpackToolStripMenuItem.Text = "Download and Unpack";
            downloadAndUnpackToolStripMenuItem.Click += btnDownload_Click;
            // 
            // showTitleDlcToolStripMenuItem
            // 
            showTitleDlcToolStripMenuItem.Image = Properties.Resources.menu_show_dlc;
            showTitleDlcToolStripMenuItem.Name = "showTitleDlcToolStripMenuItem";
            showTitleDlcToolStripMenuItem.Size = new Size(206, 22);
            showTitleDlcToolStripMenuItem.Text = "Show Title DLCs";
            showTitleDlcToolStripMenuItem.Click += showTitleDlcToolStripMenuItem_Click;
            // 
            // downloadAllDlcsToolStripMenuItem
            // 
            downloadAllDlcsToolStripMenuItem.Image = Properties.Resources.menu_download_dlc;
            downloadAllDlcsToolStripMenuItem.Name = "downloadAllDlcsToolStripMenuItem";
            downloadAllDlcsToolStripMenuItem.Size = new Size(206, 22);
            downloadAllDlcsToolStripMenuItem.Text = "Download All DLCs";
            downloadAllDlcsToolStripMenuItem.Click += downloadAllDlcsToolStripMenuItem_Click;
            // 
            // downloadAllToolStripMenuItem
            // 
            downloadAllToolStripMenuItem.Name = "downloadAllToolStripMenuItem";
            downloadAllToolStripMenuItem.Size = new Size(206, 22);
            downloadAllToolStripMenuItem.Text = "Download All";
            downloadAllToolStripMenuItem.Click += downloadAllToolStripMenuItem_Click;
            // 
            // downloadAllWithPatchesToolStripMenuItem
            // 
            downloadAllWithPatchesToolStripMenuItem.Name = "downloadAllWithPatchesToolStripMenuItem";
            downloadAllWithPatchesToolStripMenuItem.Size = new Size(206, 22);
            downloadAllWithPatchesToolStripMenuItem.Text = "Download All w/ Patches";
            downloadAllWithPatchesToolStripMenuItem.Click += downloadAllWithPatchesToolStripMenuItem_Click;
            // 
            // checkForPatchesToolStripMenuItem
            // 
            checkForPatchesToolStripMenuItem.Name = "checkForPatchesToolStripMenuItem";
            checkForPatchesToolStripMenuItem.Size = new Size(206, 22);
            checkForPatchesToolStripMenuItem.Text = "Check for patches";
            checkForPatchesToolStripMenuItem.Click += checkForPatchesToolStripMenuItem_Click;
            // 
            // toggleDownloadedToolStripMenuItem
            // 
            toggleDownloadedToolStripMenuItem.Name = "toggleDownloadedToolStripMenuItem";
            toggleDownloadedToolStripMenuItem.Size = new Size(206, 22);
            toggleDownloadedToolStripMenuItem.Text = "Toggle Download Mark";
            toggleDownloadedToolStripMenuItem.Click += toggleDownloadedToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(206, 22);
            toolStripMenuItem1.Text = "Download CompPack";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(411, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnDownload
            // 
            btnDownload.Image = Properties.Resources.menu_download;
            btnDownload.Location = new Point(0, 95);
            btnDownload.Margin = new Padding(0);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(218, 23);
            btnDownload.TabIndex = 3;
            btnDownload.Text = "Download and Unpack";
            btnDownload.TextAlign = ContentAlignment.MiddleRight;
            btnDownload.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // rbnGames
            // 
            rbnGames.AutoSize = true;
            rbnGames.Checked = true;
            rbnGames.Enabled = false;
            rbnGames.Location = new Point(69, 3);
            rbnGames.Name = "rbnGames";
            rbnGames.Size = new Size(61, 19);
            rbnGames.TabIndex = 8;
            rbnGames.TabStop = true;
            rbnGames.Text = "Games";
            rbnGames.UseVisualStyleBackColor = true;
            rbnGames.CheckedChanged += rbnGames_CheckedChanged;
            // 
            // rbnDLC
            // 
            rbnDLC.AutoSize = true;
            rbnDLC.Enabled = false;
            rbnDLC.Location = new Point(206, 3);
            rbnDLC.Name = "rbnDLC";
            rbnDLC.Size = new Size(47, 19);
            rbnDLC.TabIndex = 9;
            rbnDLC.Text = "DLC";
            rbnDLC.UseVisualStyleBackColor = true;
            rbnDLC.CheckedChanged += rbnDLC_CheckedChanged;
            // 
            // label4
            // 
            label4.Location = new Point(3, 3);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Size = new Size(60, 17);
            label4.TabIndex = 11;
            label4.Text = "Browse for:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ptbCover
            // 
            ptbCover.ImageLocation = "";
            ptbCover.Location = new Point(2, 121);
            ptbCover.Margin = new Padding(3, 3, 3, 0);
            ptbCover.Name = "ptbCover";
            ptbCover.Size = new Size(211, 211);
            ptbCover.SizeMode = PictureBoxSizeMode.Zoom;
            ptbCover.TabIndex = 12;
            ptbCover.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.Location = new Point(3, 335);
            label5.Margin = new Padding(3, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(638, 65);
            label5.TabIndex = 13;
            // 
            // lstDownloadStatusMenuStrip
            // 
            lstDownloadStatusMenuStrip.Items.AddRange(new ToolStripItem[] { pauseToolStripMenuItem, resumeToolStripMenuItem, cancelToolStripMenuItem, retryUnpackToolStripMenuItem, clearCompletedToolStripMenuItem });
            lstDownloadStatusMenuStrip.Name = "contextMenuStrip1";
            lstDownloadStatusMenuStrip.Size = new Size(164, 116);
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Image = Properties.Resources.menu_pause;
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.Size = new Size(163, 22);
            pauseToolStripMenuItem.Text = "Pause";
            pauseToolStripMenuItem.Click += pauseToolStripMenuItem_Click;
            // 
            // resumeToolStripMenuItem
            // 
            resumeToolStripMenuItem.Image = Properties.Resources.menu_resume;
            resumeToolStripMenuItem.Margin = new Padding(1);
            resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            resumeToolStripMenuItem.Size = new Size(163, 22);
            resumeToolStripMenuItem.Text = "Resume";
            resumeToolStripMenuItem.Click += resumeToolStripMenuItem_Click;
            // 
            // cancelToolStripMenuItem
            // 
            cancelToolStripMenuItem.Image = Properties.Resources.menu_cancel;
            cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            cancelToolStripMenuItem.Size = new Size(163, 22);
            cancelToolStripMenuItem.Text = "Cancel";
            cancelToolStripMenuItem.Click += cancelToolStripMenuItem_Click;
            // 
            // retryUnpackToolStripMenuItem
            // 
            retryUnpackToolStripMenuItem.Image = Properties.Resources.menu_retry;
            retryUnpackToolStripMenuItem.Name = "retryUnpackToolStripMenuItem";
            retryUnpackToolStripMenuItem.Size = new Size(163, 22);
            retryUnpackToolStripMenuItem.Text = "Retry Unpack";
            retryUnpackToolStripMenuItem.Click += retryUnpackToolStripMenuItem_Click;
            // 
            // clearCompletedToolStripMenuItem
            // 
            clearCompletedToolStripMenuItem.Image = Properties.Resources.menu_clear;
            clearCompletedToolStripMenuItem.Name = "clearCompletedToolStripMenuItem";
            clearCompletedToolStripMenuItem.Size = new Size(163, 22);
            clearCompletedToolStripMenuItem.Text = "Clear Completed";
            clearCompletedToolStripMenuItem.Click += clearCompletedToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Interval = 500;
            timer2.Tick += timer2_Tick;
            // 
            // lnkOpenRenaScene
            // 
            lnkOpenRenaScene.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lnkOpenRenaScene.Location = new Point(2, 403);
            lnkOpenRenaScene.Margin = new Padding(3, 3, 3, 0);
            lnkOpenRenaScene.Name = "lnkOpenRenaScene";
            lnkOpenRenaScene.Size = new Size(641, 17);
            lnkOpenRenaScene.TabIndex = 17;
            lnkOpenRenaScene.TabStop = true;
            lnkOpenRenaScene.Text = "Open Google (screens)";
            lnkOpenRenaScene.Visible = false;
            lnkOpenRenaScene.LinkClicked += lnkOpenRenaScene_LinkClicked;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(splMain);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 24);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(6);
            pnlMain.Size = new Size(1385, 699);
            pnlMain.TabIndex = 18;
            // 
            // splMain
            // 
            splMain.Dock = DockStyle.Fill;
            splMain.Location = new Point(6, 6);
            splMain.Name = "splMain";
            splMain.Orientation = Orientation.Horizontal;
            // 
            // splMain.Panel1
            // 
            splMain.Panel1.Controls.Add(splList);
            // 
            // splMain.Panel2
            // 
            splMain.Panel2.Controls.Add(splitContainer1);
            splMain.Size = new Size(1373, 687);
            splMain.SplitterDistance = 420;
            splMain.TabIndex = 18;
            // 
            // splList
            // 
            splList.Dock = DockStyle.Fill;
            splList.Location = new Point(0, 0);
            splList.Name = "splList";
            // 
            // splList.Panel1
            // 
            splList.Panel1.Controls.Add(lstTitles);
            splList.Panel1.Controls.Add(pnlSearch);
            // 
            // splList.Panel2
            // 
            splList.Panel2.Controls.Add(groupBox1);
            splList.Panel2.Controls.Add(rbnDownloaded);
            splList.Panel2.Controls.Add(rbnUndownloaded);
            splList.Panel2.Controls.Add(rbnAll);
            splList.Panel2.Controls.Add(chkUnless);
            splList.Panel2.Controls.Add(chkHideDownloaded);
            splList.Panel2.Controls.Add(lb_ps3licenseType);
            splList.Panel2.Controls.Add(btnDownload);
            splList.Panel2.Controls.Add(ptbCover);
            splList.Panel2.Controls.Add(panel1);
            splList.Panel2.Controls.Add(lnkOpenRenaScene);
            splList.Panel2.Controls.Add(label5);
            splList.Panel2.Paint += splList_Panel2_Paint;
            splList.Size = new Size(1373, 420);
            splList.SplitterDistance = 722;
            splList.TabIndex = 18;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(cmbType);
            pnlSearch.Controls.Add(cmbRegion);
            pnlSearch.Controls.Add(flowLayoutPanel3);
            pnlSearch.Controls.Add(flowLayoutPanel1);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(722, 52);
            pnlSearch.TabIndex = 17;
            // 
            // cmbType
            // 
            cmbType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxProperties1.AutoSize = true;
            checkBoxProperties1.ForeColor = SystemColors.ControlText;
            cmbType.CheckBoxProperties = checkBoxProperties1;
            cmbType.DisplayMemberSingleItem = "";
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(420, 3);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(152, 23);
            cmbType.TabIndex = 20;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // cmbRegion
            // 
            cmbRegion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBoxProperties2.AutoSize = true;
            checkBoxProperties2.ForeColor = SystemColors.ControlText;
            cmbRegion.CheckBoxProperties = checkBoxProperties2;
            cmbRegion.DisplayMemberSingleItem = "";
            cmbRegion.FormattingEnabled = true;
            cmbRegion.Location = new Point(578, 3);
            cmbRegion.MaxDropDownItems = 5;
            cmbRegion.Name = "cmbRegion";
            cmbRegion.Size = new Size(138, 23);
            cmbRegion.TabIndex = 19;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel3.Controls.Add(lblCount);
            flowLayoutPanel3.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel3.Location = new Point(563, 26);
            flowLayoutPanel3.Margin = new Padding(3, 0, 3, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(156, 23);
            flowLayoutPanel3.TabIndex = 18;
            // 
            // lblCount
            // 
            lblCount.Location = new Point(3, 3);
            lblCount.Margin = new Padding(3);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(150, 17);
            lblCount.TabIndex = 11;
            lblCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(rbnGames);
            flowLayoutPanel1.Controls.Add(rbnAvatars);
            flowLayoutPanel1.Controls.Add(rbnDLC);
            flowLayoutPanel1.Controls.Add(rbnThemes);
            flowLayoutPanel1.Controls.Add(rbnUpdates);
            flowLayoutPanel1.Location = new Point(3, 26);
            flowLayoutPanel1.Margin = new Padding(3, 0, 0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(557, 23);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // rbnAvatars
            // 
            rbnAvatars.AutoSize = true;
            rbnAvatars.Enabled = false;
            rbnAvatars.Location = new Point(136, 3);
            rbnAvatars.Name = "rbnAvatars";
            rbnAvatars.Size = new Size(64, 19);
            rbnAvatars.TabIndex = 13;
            rbnAvatars.Text = "Avatars";
            rbnAvatars.UseVisualStyleBackColor = true;
            rbnAvatars.Visible = false;
            rbnAvatars.CheckedChanged += rbnAvatars_CheckedChanged;
            // 
            // rbnThemes
            // 
            rbnThemes.AutoSize = true;
            rbnThemes.Enabled = false;
            rbnThemes.Location = new Point(259, 3);
            rbnThemes.Name = "rbnThemes";
            rbnThemes.Size = new Size(67, 19);
            rbnThemes.TabIndex = 10;
            rbnThemes.Text = "Themes";
            rbnThemes.UseVisualStyleBackColor = true;
            rbnThemes.CheckedChanged += rbnThemes_CheckedChanged;
            // 
            // rbnUpdates
            // 
            rbnUpdates.AutoSize = true;
            rbnUpdates.Enabled = false;
            rbnUpdates.Location = new Point(332, 3);
            rbnUpdates.Name = "rbnUpdates";
            rbnUpdates.Size = new Size(68, 19);
            rbnUpdates.TabIndex = 12;
            rbnUpdates.Text = "Updates";
            rbnUpdates.UseVisualStyleBackColor = true;
            rbnUpdates.Visible = false;
            rbnUpdates.CheckedChanged += rbnUpdates_CheckedChanged;
            // 
            // lGameCount
            // 
            lGameCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lGameCount.AutoSize = true;
            lGameCount.Location = new Point(1121, 9);
            lGameCount.Name = "lGameCount";
            lGameCount.Size = new Size(97, 15);
            lGameCount.TabIndex = 43;
            lGameCount.Text = "Game Data 0 of 0";
            // 
            // btnNextInfo
            // 
            btnNextInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNextInfo.Location = new Point(1330, 5);
            btnNextInfo.Name = "btnNextInfo";
            btnNextInfo.Size = new Size(31, 23);
            btnNextInfo.TabIndex = 42;
            btnNextInfo.Text = ">";
            btnNextInfo.UseVisualStyleBackColor = true;
            btnNextInfo.Click += btnNextInfo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lScreenshotCount);
            groupBox1.Controls.Add(tbSummary);
            groupBox1.Controls.Add(tbGenres);
            groupBox1.Controls.Add(tbGameMode);
            groupBox1.Controls.Add(tbPlatforms);
            groupBox1.Controls.Add(tbGameName);
            groupBox1.Controls.Add(bNextSS);
            groupBox1.Controls.Add(bPrevSS);
            groupBox1.Controls.Add(pbScreenshots);
            groupBox1.Controls.Add(lSummary);
            groupBox1.Controls.Add(lGenres);
            groupBox1.Controls.Add(lGameMode);
            groupBox1.Controls.Add(lPlatforms);
            groupBox1.Controls.Add(lGameName);
            groupBox1.Controls.Add(imgCover);
            groupBox1.Location = new Point(231, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 414);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game Info";
            // 
            // lScreenshotCount
            // 
            lScreenshotCount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lScreenshotCount.AutoSize = true;
            lScreenshotCount.Location = new Point(164, 377);
            lScreenshotCount.Name = "lScreenshotCount";
            lScreenshotCount.Size = new Size(97, 15);
            lScreenshotCount.TabIndex = 41;
            lScreenshotCount.Text = "Screenshot 0 of 0";
            // 
            // tbSummary
            // 
            tbSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSummary.BorderStyle = BorderStyle.FixedSingle;
            tbSummary.Location = new Point(73, 123);
            tbSummary.Name = "tbSummary";
            tbSummary.ReadOnly = true;
            tbSummary.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            tbSummary.Size = new Size(321, 36);
            tbSummary.TabIndex = 40;
            tbSummary.Text = "";
            // 
            // tbGenres
            // 
            tbGenres.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbGenres.Location = new Point(88, 96);
            tbGenres.Name = "tbGenres";
            tbGenres.ReadOnly = true;
            tbGenres.ScrollBars = ScrollBars.Horizontal;
            tbGenres.Size = new Size(306, 23);
            tbGenres.TabIndex = 38;
            // 
            // tbGameMode
            // 
            tbGameMode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbGameMode.Location = new Point(88, 66);
            tbGameMode.Name = "tbGameMode";
            tbGameMode.ReadOnly = true;
            tbGameMode.Size = new Size(306, 23);
            tbGameMode.TabIndex = 37;
            // 
            // tbPlatforms
            // 
            tbPlatforms.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPlatforms.Location = new Point(194, 42);
            tbPlatforms.Name = "tbPlatforms";
            tbPlatforms.ReadOnly = true;
            tbPlatforms.ScrollBars = ScrollBars.Horizontal;
            tbPlatforms.Size = new Size(200, 23);
            tbPlatforms.TabIndex = 36;
            // 
            // tbGameName
            // 
            tbGameName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbGameName.Location = new Point(194, 13);
            tbGameName.Name = "tbGameName";
            tbGameName.ReadOnly = true;
            tbGameName.Size = new Size(200, 23);
            tbGameName.TabIndex = 35;
            // 
            // bNextSS
            // 
            bNextSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bNextSS.Location = new Point(373, 377);
            bNextSS.Name = "bNextSS";
            bNextSS.Size = new Size(31, 23);
            bNextSS.TabIndex = 34;
            bNextSS.Text = ">";
            bNextSS.UseVisualStyleBackColor = true;
            bNextSS.Click += bNextSS_Click;
            // 
            // bPrevSS
            // 
            bPrevSS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            bPrevSS.Location = new Point(6, 377);
            bPrevSS.Name = "bPrevSS";
            bPrevSS.Size = new Size(35, 23);
            bPrevSS.TabIndex = 33;
            bPrevSS.Text = "<";
            bPrevSS.UseVisualStyleBackColor = true;
            bPrevSS.Click += bPrevSS_Click;
            // 
            // pbScreenshots
            // 
            pbScreenshots.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbScreenshots.Location = new Point(9, 175);
            pbScreenshots.Name = "pbScreenshots";
            pbScreenshots.Size = new Size(395, 198);
            pbScreenshots.SizeMode = PictureBoxSizeMode.Zoom;
            pbScreenshots.TabIndex = 32;
            pbScreenshots.TabStop = false;
            // 
            // lSummary
            // 
            lSummary.AutoSize = true;
            lSummary.Location = new Point(6, 126);
            lSummary.Name = "lSummary";
            lSummary.Size = new Size(61, 15);
            lSummary.TabIndex = 31;
            lSummary.Text = "Summary:";
            // 
            // lGenres
            // 
            lGenres.AutoSize = true;
            lGenres.Location = new Point(9, 96);
            lGenres.Name = "lGenres";
            lGenres.Size = new Size(49, 15);
            lGenres.TabIndex = 30;
            lGenres.Text = "Genres: ";
            // 
            // lGameMode
            // 
            lGameMode.AutoSize = true;
            lGameMode.Location = new Point(6, 66);
            lGameMode.Name = "lGameMode";
            lGameMode.Size = new Size(78, 15);
            lGameMode.TabIndex = 29;
            lGameMode.Text = "Game Mode: ";
            // 
            // lPlatforms
            // 
            lPlatforms.AutoSize = true;
            lPlatforms.Location = new Point(112, 45);
            lPlatforms.Name = "lPlatforms";
            lPlatforms.Size = new Size(64, 15);
            lPlatforms.TabIndex = 28;
            lPlatforms.Text = "Platforms: ";
            // 
            // lGameName
            // 
            lGameName.AutoSize = true;
            lGameName.Location = new Point(112, 13);
            lGameName.Name = "lGameName";
            lGameName.Size = new Size(76, 15);
            lGameName.TabIndex = 26;
            lGameName.Text = "Game Name:";
            // 
            // imgCover
            // 
            imgCover.Location = new Point(6, 13);
            imgCover.Name = "imgCover";
            imgCover.Size = new Size(100, 50);
            imgCover.SizeMode = PictureBoxSizeMode.Zoom;
            imgCover.TabIndex = 25;
            imgCover.TabStop = false;
            // 
            // btnPrevInfo
            // 
            btnPrevInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrevInfo.Location = new Point(963, 5);
            btnPrevInfo.Name = "btnPrevInfo";
            btnPrevInfo.Size = new Size(35, 23);
            btnPrevInfo.TabIndex = 41;
            btnPrevInfo.Text = "<";
            btnPrevInfo.UseVisualStyleBackColor = true;
            btnPrevInfo.Click += btnPrevInfo_Click;
            // 
            // rbnDownloaded
            // 
            rbnDownloaded.AutoSize = true;
            rbnDownloaded.Location = new Point(133, 0);
            rbnDownloaded.Name = "rbnDownloaded";
            rbnDownloaded.Size = new Size(92, 19);
            rbnDownloaded.TabIndex = 24;
            rbnDownloaded.Text = "Downloaded";
            rbnDownloaded.UseVisualStyleBackColor = true;
            rbnDownloaded.CheckedChanged += rbnDownloaded_CheckedChanged;
            // 
            // rbnUndownloaded
            // 
            rbnUndownloaded.AutoSize = true;
            rbnUndownloaded.Location = new Point(35, 0);
            rbnUndownloaded.Name = "rbnUndownloaded";
            rbnUndownloaded.Size = new Size(106, 19);
            rbnUndownloaded.TabIndex = 23;
            rbnUndownloaded.Text = "Undownloaded";
            rbnUndownloaded.UseVisualStyleBackColor = true;
            rbnUndownloaded.CheckedChanged += rbnUndownloaded_CheckedChanged;
            // 
            // rbnAll
            // 
            rbnAll.AutoSize = true;
            rbnAll.Checked = true;
            rbnAll.Location = new Point(0, 0);
            rbnAll.Name = "rbnAll";
            rbnAll.Size = new Size(39, 19);
            rbnAll.TabIndex = 22;
            rbnAll.TabStop = true;
            rbnAll.Text = "All";
            rbnAll.UseVisualStyleBackColor = true;
            rbnAll.CheckedChanged += rbnAll_CheckedChanged;
            // 
            // chkUnless
            // 
            chkUnless.Anchor = AnchorStyles.Top;
            chkUnless.AutoSize = true;
            chkUnless.Enabled = false;
            chkUnless.Location = new Point(2, 25);
            chkUnless.Name = "chkUnless";
            chkUnless.Size = new Size(110, 19);
            chkUnless.TabIndex = 21;
            chkUnless.Text = "Unless new DLC";
            chkUnless.UseVisualStyleBackColor = true;
            chkUnless.CheckedChanged += chkUnless_CheckedChanged;
            // 
            // chkHideDownloaded
            // 
            chkHideDownloaded.Anchor = AnchorStyles.Top;
            chkHideDownloaded.AutoSize = true;
            chkHideDownloaded.Location = new Point(118, 25);
            chkHideDownloaded.Name = "chkHideDownloaded";
            chkHideDownloaded.Size = new Size(120, 19);
            chkHideDownloaded.TabIndex = 20;
            chkHideDownloaded.Text = "Hide downloaded";
            chkHideDownloaded.UseVisualStyleBackColor = true;
            chkHideDownloaded.Visible = false;
            chkHideDownloaded.CheckedChanged += chkHideDownloaded_CheckedChanged;
            // 
            // lb_ps3licenseType
            // 
            lb_ps3licenseType.AutoSize = true;
            lb_ps3licenseType.Location = new Point(3, 379);
            lb_ps3licenseType.Name = "lb_ps3licenseType";
            lb_ps3licenseType.Size = new Size(0, 15);
            lb_ps3licenseType.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.Location = new Point(2, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 30);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lGameCount);
            splitContainer1.Panel1.Controls.Add(ResumeAll);
            splitContainer1.Panel1.Controls.Add(btnNextInfo);
            splitContainer1.Panel1.Controls.Add(button5);
            splitContainer1.Panel1.Controls.Add(btnPrevInfo);
            splitContainer1.Panel1.Controls.Add(PauseAll);
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lstDownloadStatus);
            splitContainer1.Size = new Size(1373, 263);
            splitContainer1.SplitterDistance = 33;
            splitContainer1.TabIndex = 15;
            // 
            // ResumeAll
            // 
            ResumeAll.Image = Properties.Resources.menu_resume;
            ResumeAll.Location = new Point(225, 2);
            ResumeAll.Margin = new Padding(0);
            ResumeAll.Name = "ResumeAll";
            ResumeAll.Size = new Size(93, 28);
            ResumeAll.TabIndex = 1;
            ResumeAll.Text = "Resume All";
            ResumeAll.TextAlign = ContentAlignment.MiddleRight;
            ResumeAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            ResumeAll.UseVisualStyleBackColor = true;
            ResumeAll.Click += ResumeAllBtnClick;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.opened_folder;
            button5.Location = new Point(183, 2);
            button5.Name = "button5";
            button5.Size = new Size(39, 28);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // PauseAll
            // 
            PauseAll.Image = Properties.Resources.menu_pause;
            PauseAll.Location = new Point(324, 2);
            PauseAll.Margin = new Padding(0);
            PauseAll.Name = "PauseAll";
            PauseAll.Size = new Size(93, 28);
            PauseAll.TabIndex = 0;
            PauseAll.Text = "Pause All";
            PauseAll.TextAlign = ContentAlignment.MiddleRight;
            PauseAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            PauseAll.UseVisualStyleBackColor = true;
            PauseAll.Click += PauseAllBtnClick;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.menu_clear;
            button4.Location = new Point(138, 2);
            button4.Name = "button4";
            button4.Size = new Size(39, 28);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += clearCompletedToolStripMenuItem_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.menu_cancel;
            button3.Location = new Point(93, 2);
            button3.Name = "button3";
            button3.Size = new Size(39, 28);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += cancelToolStripMenuItem_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.menu_pause;
            button2.Location = new Point(48, 2);
            button2.Name = "button2";
            button2.Size = new Size(39, 28);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += pauseToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.menu_resume;
            button1.Location = new Point(3, 2);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(39, 28);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += resumeToolStripMenuItem_Click;
            // 
            // lstDownloadStatus
            // 
            lstDownloadStatus.Columns.AddRange(new ColumnHeader[] { colDownloadTitle, colDownloadSpeed, colDownloadStatus, colDownloadProgress, colDownloadError });
            lstDownloadStatus.Dock = DockStyle.Fill;
            lstDownloadStatus.FullRowSelect = true;
            lstDownloadStatus.Location = new Point(0, 0);
            lstDownloadStatus.Name = "lstDownloadStatus";
            lstDownloadStatus.Size = new Size(1373, 226);
            lstDownloadStatus.TabIndex = 14;
            lstDownloadStatus.UseCompatibleStateImageBehavior = false;
            lstDownloadStatus.View = View.Details;
            lstDownloadStatus.KeyDown += lstDownloadStatus_KeyDown;
            // 
            // colDownloadTitle
            // 
            colDownloadTitle.Text = "Title";
            colDownloadTitle.Width = 457;
            // 
            // colDownloadSpeed
            // 
            colDownloadSpeed.Text = "Speed";
            colDownloadSpeed.Width = 112;
            // 
            // colDownloadStatus
            // 
            colDownloadStatus.Text = "Status";
            colDownloadStatus.Width = 100;
            // 
            // colDownloadProgress
            // 
            colDownloadProgress.Text = "Progress";
            colDownloadProgress.Width = 366;
            // 
            // colDownloadError
            // 
            colDownloadError.Text = "Error Message";
            colDownloadError.Width = 200;
            // 
            // NPSBrowser
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1385, 723);
            Controls.Add(pnlMain);
            Controls.Add(mnuMain);
            MinimumSize = new Size(800, 600);
            Name = "NPSBrowser";
            Text = "NPS Browser";
            FormClosing += NPSBrowser_FormClosing;
            Load += NoPayStationBrowser_Load;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            lstTitlesMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbCover).EndInit();
            lstDownloadStatusMenuStrip.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            splMain.Panel1.ResumeLayout(false);
            splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splMain).EndInit();
            splMain.ResumeLayout(false);
            splList.Panel1.ResumeLayout(false);
            splList.Panel2.ResumeLayout(false);
            splList.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splList).EndInit();
            splList.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbScreenshots).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCover).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        #region Windows Form Designer generated code


        #endregion

        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ListView lstTitles;
        private System.Windows.Forms.ColumnHeader colTitleID;
        private System.Windows.Forms.ColumnHeader colRegion;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.RadioButton rbnGames;
        private System.Windows.Forms.RadioButton rbnDLC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptbCover;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip lstDownloadStatusMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retryUnpackToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ListViewEmbeddedControls.ListViewEx lstDownloadStatus;
        private System.Windows.Forms.ColumnHeader colDownloadTitle;
        private System.Windows.Forms.ColumnHeader colDownloadSpeed;
        private System.Windows.Forms.ColumnHeader colDownloadStatus;
        private System.Windows.Forms.ToolStripMenuItem clearCompletedToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader colDLCs;
        private System.Windows.Forms.ToolStripMenuItem downloadUpdateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip lstTitlesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showTitleDlcToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader colLastModified;
        private System.Windows.Forms.ToolStripMenuItem downloadAllDlcsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadAllWithPatchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadAndUnpackToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkOpenRenaScene;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.SplitContainer splList;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.Button ResumeAll;
        private System.Windows.Forms.Button PauseAll;
        private System.Windows.Forms.ColumnHeader colDownloadProgress;
        private PresentationControls.CheckBoxComboBox cmbRegion;
        private PresentationControls.CheckBoxComboBox cmbType;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ToolStripMenuItem showDescriptionPanelToolStripMenuItem;
        private System.Windows.Forms.Label lb_ps3licenseType;
        private System.Windows.Forms.RadioButton rbnThemes;
        private System.Windows.Forms.RadioButton rbnUpdates;
        private System.Windows.Forms.RadioButton rbnAvatars;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem ts_changeLog;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForPatchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleDownloadedToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkHideDownloaded;
        private System.Windows.Forms.CheckBox chkUnless;
        private System.Windows.Forms.RadioButton rbnDownloaded;
        private System.Windows.Forms.RadioButton rbnUndownloaded;
        private System.Windows.Forms.RadioButton rbnAll;
        private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem iGDBToolStripMenuItem;
        private ToolStripMenuItem tESTToolStripMenuItem;
        private Label lGameName;
        private PictureBox imgCover;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label lGameMode;
        private Label lPlatforms;
        private Label lGenres;
        private Label lSummary;
        private Button bNextSS;
        private Button bPrevSS;
        private PictureBox pbScreenshots;
        private RichTextBox tbSummary;
        private TextBox tbGenres;
        private TextBox tbGameMode;
        private TextBox tbPlatforms;
        private TextBox tbGameName;
        private Button btnNextInfo;
        private Button btnPrevInfo;
        private Label lGameCount;
        private Label lScreenshotCount;
        private ColumnHeader colDownloadError;
    }
}
