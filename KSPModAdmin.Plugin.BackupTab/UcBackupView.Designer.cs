﻿namespace KSPModAdmin.Plugin.BackupTab
{
    partial class UcBackupView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBackupView));
            this.ttPlugin = new System.Windows.Forms.ToolTip(this.components);
            this.tbBackupPath = new System.Windows.Forms.TextBox();
            this.tsBackups = new System.Windows.Forms.ToolStrip();
            this.tsbRefreshBackupview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNewBackup = new System.Windows.Forms.ToolStripButton();
            this.tsbBackupSaves = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRemoveBackup = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveAllBackups = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslProcessing = new System.Windows.Forms.ToolStripLabel();
            this.tsbBackupOptions = new System.Windows.Forms.ToolStripButton();
            this.tsbAutoBackup = new System.Windows.Forms.ToolStripButton();
            this.tsbBackupOnStartup = new System.Windows.Forms.ToolStripButton();
            this.tsbBackupOnKSPLaunch = new System.Windows.Forms.ToolStripButton();
            this.grbBackups = new System.Windows.Forms.GroupBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.cbBackupOnKSPLaunch = new System.Windows.Forms.CheckBox();
            this.cbBackupOnStartup = new System.Windows.Forms.CheckBox();
            this.cbAutoBackup = new System.Windows.Forms.CheckBox();
            this.tbMaxBackupFiles = new KSPModAdmin.Core.Utils.Controls.TextBoxNumeric2();
            this.lblBackupTime = new System.Windows.Forms.Label();
            this.lblMaxBackupFiles = new System.Windows.Forms.Label();
            this.tbBackupIterval = new KSPModAdmin.Core.Utils.Controls.TextBoxNumeric2();
            this.lblBackupInterval = new System.Windows.Forms.Label();
            this.pnlSelectBackupPath = new System.Windows.Forms.Panel();
            this.lblSelectBackupPathFirst = new System.Windows.Forms.Label();
            this.tvBackups = new KSPModAdmin.Core.Utils.Controls.Aga.Controls.Tree.TreeViewAdv();
            this.btnRecoverBackup = new System.Windows.Forms.Button();
            this.btnOpenBackupDir = new System.Windows.Forms.Button();
            this.btnBackupPath = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tsBackups.SuspendLayout();
            this.grbBackups.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlSelectBackupPath.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBackupPath
            // 
            this.tbBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBackupPath.Location = new System.Drawing.Point(6, 12);
            this.tbBackupPath.Name = "tbBackupPath";
            this.tbBackupPath.ReadOnly = true;
            this.tbBackupPath.Size = new System.Drawing.Size(603, 20);
            this.tbBackupPath.TabIndex = 27;
            this.tbBackupPath.TabStop = false;
            // 
            // tsBackups
            // 
            this.tsBackups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRefreshBackupview,
            this.toolStripSeparator3,
            this.tsbNewBackup,
            this.tsbBackupSaves,
            this.toolStripSeparator1,
            this.tsbRemoveBackup,
            this.tsbRemoveAllBackups,
            this.toolStripSeparator2,
            this.tslProcessing,
            this.tsbBackupOptions,
            this.tsbAutoBackup,
            this.tsbBackupOnStartup,
            this.tsbBackupOnKSPLaunch});
            this.tsBackups.Location = new System.Drawing.Point(3, 16);
            this.tsBackups.Name = "tsBackups";
            this.tsBackups.Size = new System.Drawing.Size(669, 31);
            this.tsBackups.TabIndex = 37;
            this.tsBackups.Text = "toolStrip2";
            // 
            // tsbRefreshBackupview
            // 
            this.tsbRefreshBackupview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefreshBackupview.Image = global::KSPModAdmin.Plugin.BackupTab.Properties.Resources.refresh;
            this.tsbRefreshBackupview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRefreshBackupview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefreshBackupview.Name = "tsbRefreshBackupview";
            this.tsbRefreshBackupview.Size = new System.Drawing.Size(28, 28);
            this.tsbRefreshBackupview.Text = "toolStripButton1";
            this.tsbRefreshBackupview.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbNewBackup
            // 
            this.tsbNewBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewBackup.Image = global::KSPModAdmin.Plugin.BackupTab.Properties.Resources.data_add_24x24;
            this.tsbNewBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNewBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewBackup.Name = "tsbNewBackup";
            this.tsbNewBackup.Size = new System.Drawing.Size(28, 28);
            this.tsbNewBackup.Text = "toolStripButton3";
            this.tsbNewBackup.Click += new System.EventHandler(this.tsbNewBackup_Click);
            // 
            // tsbBackupSaves
            // 
            this.tsbBackupSaves.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBackupSaves.Image = global::KSPModAdmin.Plugin.BackupTab.Properties.Resources.data_floppy_disk_24x24;
            this.tsbBackupSaves.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBackupSaves.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBackupSaves.Name = "tsbBackupSaves";
            this.tsbBackupSaves.Size = new System.Drawing.Size(28, 28);
            this.tsbBackupSaves.Text = "toolStripButton4";
            this.tsbBackupSaves.Click += new System.EventHandler(this.tsbBackupSaves_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbRemoveBackup
            // 
            this.tsbRemoveBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveBackup.Image = global::KSPModAdmin.Plugin.BackupTab.Properties.Resources.data_delete_24x24;
            this.tsbRemoveBackup.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRemoveBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveBackup.Name = "tsbRemoveBackup";
            this.tsbRemoveBackup.Size = new System.Drawing.Size(28, 28);
            this.tsbRemoveBackup.Text = "toolStripButton5";
            this.tsbRemoveBackup.Click += new System.EventHandler(this.tsbRemoveBackup_Click);
            // 
            // tsbRemoveAllBackups
            // 
            this.tsbRemoveAllBackups.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveAllBackups.Image = global::KSPModAdmin.Plugin.BackupTab.Properties.Resources.data2_delete24x24;
            this.tsbRemoveAllBackups.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRemoveAllBackups.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveAllBackups.Name = "tsbRemoveAllBackups";
            this.tsbRemoveAllBackups.Size = new System.Drawing.Size(28, 28);
            this.tsbRemoveAllBackups.Text = "toolStripButton6";
            this.tsbRemoveAllBackups.Click += new System.EventHandler(this.tsbRemoveAllBackups_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tslProcessing
            // 
            this.tslProcessing.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslProcessing.Image = global::KSPModAdmin.Plugin.BackupTab.Properties.Resources.loader;
            this.tslProcessing.Name = "tslProcessing";
            this.tslProcessing.Size = new System.Drawing.Size(16, 28);
            this.tslProcessing.Visible = false;
            // 
            // tsbBackupOptions
            // 
            this.tsbBackupOptions.CheckOnClick = true;
            this.tsbBackupOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBackupOptions.Image = global::KSPModAdmin.Plugin.BackupTab.Properties.Resources.gear;
            this.tsbBackupOptions.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBackupOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBackupOptions.Name = "tsbBackupOptions";
            this.tsbBackupOptions.Size = new System.Drawing.Size(28, 28);
            this.tsbBackupOptions.Text = "toolStripButton1";
            this.tsbBackupOptions.CheckStateChanged += new System.EventHandler(this.tsbBackupOptions_CheckStateChanged);
            // 
            // tsbAutoBackup
            // 
            this.tsbAutoBackup.CheckOnClick = true;
            this.tsbAutoBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAutoBackup.Image = ((System.Drawing.Image)(resources.GetObject("tsbAutoBackup.Image")));
            this.tsbAutoBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAutoBackup.Name = "tsbAutoBackup";
            this.tsbAutoBackup.Size = new System.Drawing.Size(23, 28);
            this.tsbAutoBackup.Text = "toolStripButton1";
            this.tsbAutoBackup.CheckedChanged += new System.EventHandler(this.tsbAutoBackup_CheckedChanged);
            // 
            // tsbBackupOnStartup
            // 
            this.tsbBackupOnStartup.CheckOnClick = true;
            this.tsbBackupOnStartup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBackupOnStartup.Image = ((System.Drawing.Image)(resources.GetObject("tsbBackupOnStartup.Image")));
            this.tsbBackupOnStartup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBackupOnStartup.Name = "tsbBackupOnStartup";
            this.tsbBackupOnStartup.Size = new System.Drawing.Size(23, 28);
            this.tsbBackupOnStartup.Text = "toolStripButton2";
            this.tsbBackupOnStartup.CheckedChanged += new System.EventHandler(this.tsbBackupOnStartup_CheckedChanged);
            // 
            // tsbBackupOnKSPLaunch
            // 
            this.tsbBackupOnKSPLaunch.CheckOnClick = true;
            this.tsbBackupOnKSPLaunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBackupOnKSPLaunch.Image = ((System.Drawing.Image)(resources.GetObject("tsbBackupOnKSPLaunch.Image")));
            this.tsbBackupOnKSPLaunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBackupOnKSPLaunch.Name = "tsbBackupOnKSPLaunch";
            this.tsbBackupOnKSPLaunch.Size = new System.Drawing.Size(23, 28);
            this.tsbBackupOnKSPLaunch.Text = "toolStripButton3";
            this.tsbBackupOnKSPLaunch.CheckedChanged += new System.EventHandler(this.tsbBackupOnKSPLaunch_CheckedChanged);
            // 
            // grbBackups
            // 
            this.grbBackups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbBackups.Controls.Add(this.pnlOptions);
            this.grbBackups.Controls.Add(this.pnlSelectBackupPath);
            this.grbBackups.Controls.Add(this.tvBackups);
            this.grbBackups.Controls.Add(this.btnRecoverBackup);
            this.grbBackups.Controls.Add(this.tsBackups);
            this.grbBackups.Location = new System.Drawing.Point(0, 39);
            this.grbBackups.Name = "grbBackups";
            this.grbBackups.Size = new System.Drawing.Size(675, 468);
            this.grbBackups.TabIndex = 38;
            this.grbBackups.TabStop = false;
            this.grbBackups.Text = "Backups:";
            // 
            // pnlOptions
            // 
            this.pnlOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOptions.Controls.Add(this.tableLayoutPanel2);
            this.pnlOptions.Controls.Add(this.tableLayoutPanel1);
            this.pnlOptions.Controls.Add(this.cbBackupOnKSPLaunch);
            this.pnlOptions.Controls.Add(this.cbBackupOnStartup);
            this.pnlOptions.Controls.Add(this.cbAutoBackup);
            this.pnlOptions.Location = new System.Drawing.Point(16, 61);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(640, 348);
            this.pnlOptions.TabIndex = 40;
            this.pnlOptions.Visible = false;
            // 
            // cbBackupOnKSPLaunch
            // 
            this.cbBackupOnKSPLaunch.AutoSize = true;
            this.cbBackupOnKSPLaunch.Location = new System.Drawing.Point(17, 128);
            this.cbBackupOnKSPLaunch.Name = "cbBackupOnKSPLaunch";
            this.cbBackupOnKSPLaunch.Size = new System.Drawing.Size(137, 17);
            this.cbBackupOnKSPLaunch.TabIndex = 2;
            this.cbBackupOnKSPLaunch.Text = "Backup on KSP launch";
            this.cbBackupOnKSPLaunch.UseVisualStyleBackColor = true;
            this.cbBackupOnKSPLaunch.CheckedChanged += new System.EventHandler(this.cbBackupOnKSPLaunch_CheckedChanged);
            // 
            // cbBackupOnStartup
            // 
            this.cbBackupOnStartup.AutoSize = true;
            this.cbBackupOnStartup.Location = new System.Drawing.Point(17, 96);
            this.cbBackupOnStartup.Name = "cbBackupOnStartup";
            this.cbBackupOnStartup.Size = new System.Drawing.Size(181, 17);
            this.cbBackupOnStartup.TabIndex = 2;
            this.cbBackupOnStartup.Text = "Backup on KSP Mod Admin start";
            this.cbBackupOnStartup.UseVisualStyleBackColor = true;
            this.cbBackupOnStartup.CheckedChanged += new System.EventHandler(this.cbBackupOnStartup_CheckedChanged);
            // 
            // cbAutoBackup
            // 
            this.cbAutoBackup.AutoSize = true;
            this.cbAutoBackup.Location = new System.Drawing.Point(17, 17);
            this.cbAutoBackup.Name = "cbAutoBackup";
            this.cbAutoBackup.Size = new System.Drawing.Size(87, 17);
            this.cbAutoBackup.TabIndex = 2;
            this.cbAutoBackup.Text = "Auto backup";
            this.cbAutoBackup.UseVisualStyleBackColor = true;
            this.cbAutoBackup.CheckedChanged += new System.EventHandler(this.cbAutoBackup_CheckedChanged);
            // 
            // tbMaxBackupFiles
            // 
            this.tbMaxBackupFiles.AllowDecimalSeparator = false;
            this.tbMaxBackupFiles.AllowGroupSeparator = false;
            this.tbMaxBackupFiles.AllowNegativeSign = false;
            this.tbMaxBackupFiles.AllowSpace = false;
            this.tbMaxBackupFiles.Location = new System.Drawing.Point(149, 3);
            this.tbMaxBackupFiles.MaxLength = 2;
            this.tbMaxBackupFiles.Name = "tbMaxBackupFiles";
            this.tbMaxBackupFiles.Size = new System.Drawing.Size(23, 20);
            this.tbMaxBackupFiles.TabIndex = 1;
            this.tbMaxBackupFiles.Text = "5";
            // 
            // lblBackupTime
            // 
            this.lblBackupTime.AutoSize = true;
            this.lblBackupTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBackupTime.Location = new System.Drawing.Point(192, 0);
            this.lblBackupTime.Name = "lblBackupTime";
            this.lblBackupTime.Size = new System.Drawing.Size(43, 25);
            this.lblBackupTime.TabIndex = 0;
            this.lblBackupTime.Text = "minutes";
            this.lblBackupTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxBackupFiles
            // 
            this.lblMaxBackupFiles.AutoSize = true;
            this.lblMaxBackupFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaxBackupFiles.Location = new System.Drawing.Point(3, 0);
            this.lblMaxBackupFiles.Name = "lblMaxBackupFiles";
            this.lblMaxBackupFiles.Size = new System.Drawing.Size(140, 26);
            this.lblMaxBackupFiles.TabIndex = 0;
            this.lblMaxBackupFiles.Text = "Max. backup files:";
            this.lblMaxBackupFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBackupIterval
            // 
            this.tbBackupIterval.AllowDecimalSeparator = false;
            this.tbBackupIterval.AllowGroupSeparator = false;
            this.tbBackupIterval.AllowNegativeSign = false;
            this.tbBackupIterval.AllowSpace = false;
            this.tbBackupIterval.Location = new System.Drawing.Point(149, 3);
            this.tbBackupIterval.MaxLength = 4;
            this.tbBackupIterval.Name = "tbBackupIterval";
            this.tbBackupIterval.Size = new System.Drawing.Size(37, 20);
            this.tbBackupIterval.TabIndex = 1;
            this.tbBackupIterval.Text = "60";
            // 
            // lblBackupInterval
            // 
            this.lblBackupInterval.AutoSize = true;
            this.lblBackupInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBackupInterval.Location = new System.Drawing.Point(3, 0);
            this.lblBackupInterval.Name = "lblBackupInterval";
            this.lblBackupInterval.Size = new System.Drawing.Size(140, 25);
            this.lblBackupInterval.TabIndex = 0;
            this.lblBackupInterval.Text = "Backup interval:";
            this.lblBackupInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlSelectBackupPath
            // 
            this.pnlSelectBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelectBackupPath.BackColor = System.Drawing.Color.Transparent;
            this.pnlSelectBackupPath.Controls.Add(this.lblSelectBackupPathFirst);
            this.pnlSelectBackupPath.Location = new System.Drawing.Point(82, 176);
            this.pnlSelectBackupPath.Name = "pnlSelectBackupPath";
            this.pnlSelectBackupPath.Size = new System.Drawing.Size(517, 80);
            this.pnlSelectBackupPath.TabIndex = 39;
            // 
            // lblSelectBackupPathFirst
            // 
            this.lblSelectBackupPathFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectBackupPathFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectBackupPathFirst.Location = new System.Drawing.Point(3, 29);
            this.lblSelectBackupPathFirst.Name = "lblSelectBackupPathFirst";
            this.lblSelectBackupPathFirst.Size = new System.Drawing.Size(511, 23);
            this.lblSelectBackupPathFirst.TabIndex = 0;
            this.lblSelectBackupPathFirst.Text = "Please select a backup path first (Button in top right corner).";
            this.lblSelectBackupPathFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tvBackups
            // 
            this.tvBackups.BackColor = System.Drawing.SystemColors.Window;
            this.tvBackups.DefaultToolTipProvider = null;
            this.tvBackups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvBackups.DragDropMarkColor = System.Drawing.Color.Black;
            this.tvBackups.LineColor = System.Drawing.SystemColors.ControlDark;
            this.tvBackups.Location = new System.Drawing.Point(3, 47);
            this.tvBackups.Model = null;
            this.tvBackups.Name = "tvBackups";
            this.tvBackups.SelectedNode = null;
            this.tvBackups.ShowLines = false;
            this.tvBackups.ShowPlusMinus = false;
            this.tvBackups.Size = new System.Drawing.Size(669, 378);
            this.tvBackups.TabIndex = 38;
            this.tvBackups.Text = "treeViewAdv1";
            this.tvBackups.UseColumns = true;
            this.tvBackups.SelectionChanged += new System.EventHandler(this.tvBackups_SelectionChanged);
            // 
            // btnRecoverBackup
            // 
            this.btnRecoverBackup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRecoverBackup.Enabled = false;
            this.btnRecoverBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecoverBackup.Image = global::KSPModAdmin.Plugin.BackupTab.Properties.Resources.data_into_floppy_disk_24x24;
            this.btnRecoverBackup.Location = new System.Drawing.Point(3, 425);
            this.btnRecoverBackup.Name = "btnRecoverBackup";
            this.btnRecoverBackup.Size = new System.Drawing.Size(669, 40);
            this.btnRecoverBackup.TabIndex = 34;
            this.btnRecoverBackup.Text = " Recover selected Backup";
            this.btnRecoverBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecoverBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecoverBackup.UseVisualStyleBackColor = true;
            this.btnRecoverBackup.Click += new System.EventHandler(this.btnRecoverBackup_Click);
            // 
            // btnOpenBackupDir
            // 
            this.btnOpenBackupDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenBackupDir.Image = global::KSPModAdmin.Plugin.BackupTab.Properties.Resources.folder1;
            this.btnOpenBackupDir.Location = new System.Drawing.Point(615, 10);
            this.btnOpenBackupDir.Name = "btnOpenBackupDir";
            this.btnOpenBackupDir.Size = new System.Drawing.Size(25, 24);
            this.btnOpenBackupDir.TabIndex = 35;
            this.btnOpenBackupDir.UseVisualStyleBackColor = true;
            this.btnOpenBackupDir.Click += new System.EventHandler(this.btnOpenBackupDir_Click);
            // 
            // btnBackupPath
            // 
            this.btnBackupPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackupPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupPath.Image = global::KSPModAdmin.Plugin.BackupTab.Properties.Resources.folder_view;
            this.btnBackupPath.Location = new System.Drawing.Point(646, 9);
            this.btnBackupPath.Name = "btnBackupPath";
            this.btnBackupPath.Size = new System.Drawing.Size(25, 24);
            this.btnBackupPath.TabIndex = 29;
            this.btnBackupPath.UseVisualStyleBackColor = true;
            this.btnBackupPath.Click += new System.EventHandler(this.btnBackupPath_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblBackupInterval, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbBackupIterval, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBackupTime, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 25);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblMaxBackupFiles, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbMaxBackupFiles, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(634, 26);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // UcBackupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbBackups);
            this.Controls.Add(this.btnOpenBackupDir);
            this.Controls.Add(this.btnBackupPath);
            this.Controls.Add(this.tbBackupPath);
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "UcBackupView";
            this.Size = new System.Drawing.Size(675, 507);
            this.Load += new System.EventHandler(this.ucPluginView_Load);
            this.tsBackups.ResumeLayout(false);
            this.tsBackups.PerformLayout();
            this.grbBackups.ResumeLayout(false);
            this.grbBackups.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            this.pnlSelectBackupPath.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttPlugin;
        private System.Windows.Forms.Button btnOpenBackupDir;
        private System.Windows.Forms.Button btnRecoverBackup;
        public System.Windows.Forms.Button btnBackupPath;
        public System.Windows.Forms.TextBox tbBackupPath;
        private System.Windows.Forms.ToolStrip tsBackups;
        private System.Windows.Forms.ToolStripButton tsbNewBackup;
        private System.Windows.Forms.ToolStripButton tsbBackupSaves;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRemoveBackup;
        private System.Windows.Forms.ToolStripButton tsbRemoveAllBackups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tslProcessing;
        private System.Windows.Forms.GroupBox grbBackups;
        private Core.Utils.Controls.Aga.Controls.Tree.TreeViewAdv tvBackups;
        private System.Windows.Forms.Panel pnlSelectBackupPath;
        private System.Windows.Forms.Label lblSelectBackupPathFirst;
        private System.Windows.Forms.ToolStripButton tsbRefreshBackupview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbBackupOptions;
        private System.Windows.Forms.ToolStripButton tsbAutoBackup;
        private System.Windows.Forms.ToolStripButton tsbBackupOnStartup;
        private System.Windows.Forms.ToolStripButton tsbBackupOnKSPLaunch;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.CheckBox cbBackupOnKSPLaunch;
        private System.Windows.Forms.CheckBox cbBackupOnStartup;
        private System.Windows.Forms.CheckBox cbAutoBackup;
        private Core.Utils.Controls.TextBoxNumeric2 tbMaxBackupFiles;
        private System.Windows.Forms.Label lblBackupTime;
        private System.Windows.Forms.Label lblMaxBackupFiles;
        private Core.Utils.Controls.TextBoxNumeric2 tbBackupIterval;
        private System.Windows.Forms.Label lblBackupInterval;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
