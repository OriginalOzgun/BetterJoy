namespace BetterJoyForCemu {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.console = new System.Windows.Forms.TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version_lbl = new System.Windows.Forms.Label();
            this.passiveScanBox = new System.Windows.Forms.CheckBox();
            this.donationLink = new System.Windows.Forms.LinkLabel();
            this.conCntrls = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.loc4 = new System.Windows.Forms.Button();
            this.loc3 = new System.Windows.Forms.Button();
            this.loc2 = new System.Windows.Forms.Button();
            this.loc1 = new System.Windows.Forms.Button();
            this.con4 = new System.Windows.Forms.Button();
            this.con3 = new System.Windows.Forms.Button();
            this.con2 = new System.Windows.Forms.Button();
            this.con1 = new System.Windows.Forms.Button();
            this.btnTip = new System.Windows.Forms.ToolTip(this.components);
            this.startInTrayBox = new System.Windows.Forms.CheckBox();
            this.btn_open3rdP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.settingsApply = new System.Windows.Forms.Button();
            this.AutoCalibrate = new System.Windows.Forms.Button();
            this.btn_reassign_open = new System.Windows.Forms.Button();
            this.pnlBottomControls = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenu.SuspendLayout();
            this.conCntrls.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.pnlBottomControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.console.Location = new System.Drawing.Point(4, 233);
            this.console.Margin = new System.Windows.Forms.Padding(4);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(356, 222);
            this.console.TabIndex = 2;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "Double click the tray icon to maximise!";
            this.notifyIcon.BalloonTipTitle = "BetterJoy";
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "BetterJoy";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(103, 28);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // version_lbl
            // 
            this.version_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.version_lbl.AutoSize = true;
            this.version_lbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.version_lbl.Location = new System.Drawing.Point(322, 16);
            this.version_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.version_lbl.Name = "version_lbl";
            this.version_lbl.Size = new System.Drawing.Size(35, 20);
            this.version_lbl.TabIndex = 2;
            this.version_lbl.Text = "v7.1";
            // 
            // passiveScanBox
            // 
            this.passiveScanBox.AutoSize = true;
            this.passiveScanBox.Checked = true;
            this.passiveScanBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.passiveScanBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.passiveScanBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passiveScanBox.Location = new System.Drawing.Point(7, 11);
            this.passiveScanBox.Margin = new System.Windows.Forms.Padding(4);
            this.passiveScanBox.Name = "passiveScanBox";
            this.passiveScanBox.Size = new System.Drawing.Size(121, 25);
            this.passiveScanBox.TabIndex = 4;
            this.passiveScanBox.Text = "Passive Scan";
            this.passiveScanBox.UseVisualStyleBackColor = true;
            this.passiveScanBox.CheckedChanged += new System.EventHandler(this.passiveScanBox_CheckedChanged);
            // 
            // donationLink
            // 
            this.donationLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.donationLink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.donationLink.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.donationLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.donationLink.Location = new System.Drawing.Point(0, 55);
            this.donationLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.donationLink.Name = "donationLink";
            this.donationLink.Size = new System.Drawing.Size(364, 45);
            this.donationLink.TabIndex = 5;
            this.donationLink.TabStop = true;
            this.donationLink.Text = "Donate";
            this.donationLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.donationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.donationLink_LinkClicked);
            this.donationLink.Click += new System.EventHandler(this.donationLink_Click);
            this.donationLink.MouseEnter += new System.EventHandler(this.donationLink_MouseEnter);
            this.donationLink.MouseLeave += new System.EventHandler(this.donationLink_MouseLeave);
            // 
            // conCntrls
            // 
            this.conCntrls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conCntrls.Controls.Add(this.tableLayoutPanel2);
            this.conCntrls.Location = new System.Drawing.Point(0, -3);
            this.conCntrls.Margin = new System.Windows.Forms.Padding(4);
            this.conCntrls.Name = "conCntrls";
            this.conCntrls.Padding = new System.Windows.Forms.Padding(4);
            this.conCntrls.Size = new System.Drawing.Size(358, 173);
            this.conCntrls.TabIndex = 0;
            this.conCntrls.TabStop = false;
            this.conCntrls.Text = "Connected Controllers";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.loc4, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.loc3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.loc2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.loc1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.con4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.con3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.con2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.con1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 145);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // loc4
            // 
            this.loc4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loc4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loc4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loc4.Location = new System.Drawing.Point(265, 76);
            this.loc4.Margin = new System.Windows.Forms.Padding(4);
            this.loc4.Name = "loc4";
            this.loc4.Size = new System.Drawing.Size(81, 65);
            this.loc4.TabIndex = 7;
            this.loc4.Text = "Locate";
            this.loc4.UseVisualStyleBackColor = true;
            // 
            // loc3
            // 
            this.loc3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loc3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loc3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loc3.Location = new System.Drawing.Point(178, 76);
            this.loc3.Margin = new System.Windows.Forms.Padding(4);
            this.loc3.Name = "loc3";
            this.loc3.Size = new System.Drawing.Size(79, 65);
            this.loc3.TabIndex = 6;
            this.loc3.Text = "Locate";
            this.loc3.UseVisualStyleBackColor = true;
            // 
            // loc2
            // 
            this.loc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loc2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loc2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loc2.Location = new System.Drawing.Point(91, 76);
            this.loc2.Margin = new System.Windows.Forms.Padding(4);
            this.loc2.Name = "loc2";
            this.loc2.Size = new System.Drawing.Size(79, 65);
            this.loc2.TabIndex = 5;
            this.loc2.Text = "Locate";
            this.loc2.UseVisualStyleBackColor = true;
            // 
            // loc1
            // 
            this.loc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loc1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loc1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loc1.Location = new System.Drawing.Point(4, 76);
            this.loc1.Margin = new System.Windows.Forms.Padding(4);
            this.loc1.Name = "loc1";
            this.loc1.Size = new System.Drawing.Size(79, 65);
            this.loc1.TabIndex = 4;
            this.loc1.Text = "Locate";
            this.loc1.UseVisualStyleBackColor = true;
            // 
            // con4
            // 
            this.con4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.con4.BackgroundImage = global::BetterJoyForCemu.Properties.Resources.cross;
            this.con4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.con4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.con4.Enabled = false;
            this.con4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.con4.FlatAppearance.BorderSize = 2;
            this.con4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.con4.Location = new System.Drawing.Point(265, 4);
            this.con4.Margin = new System.Windows.Forms.Padding(4);
            this.con4.Name = "con4";
            this.con4.Size = new System.Drawing.Size(81, 64);
            this.con4.TabIndex = 3;
            this.con4.TabStop = false;
            this.con4.UseVisualStyleBackColor = false;
            // 
            // con3
            // 
            this.con3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.con3.BackgroundImage = global::BetterJoyForCemu.Properties.Resources.cross;
            this.con3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.con3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.con3.Enabled = false;
            this.con3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.con3.FlatAppearance.BorderSize = 2;
            this.con3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.con3.Location = new System.Drawing.Point(178, 4);
            this.con3.Margin = new System.Windows.Forms.Padding(4);
            this.con3.Name = "con3";
            this.con3.Size = new System.Drawing.Size(79, 64);
            this.con3.TabIndex = 2;
            this.con3.TabStop = false;
            this.con3.UseVisualStyleBackColor = false;
            // 
            // con2
            // 
            this.con2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.con2.BackgroundImage = global::BetterJoyForCemu.Properties.Resources.cross;
            this.con2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.con2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.con2.Enabled = false;
            this.con2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.con2.FlatAppearance.BorderSize = 2;
            this.con2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.con2.Location = new System.Drawing.Point(91, 4);
            this.con2.Margin = new System.Windows.Forms.Padding(4);
            this.con2.Name = "con2";
            this.con2.Size = new System.Drawing.Size(79, 64);
            this.con2.TabIndex = 1;
            this.con2.TabStop = false;
            this.con2.UseVisualStyleBackColor = false;
            // 
            // con1
            // 
            this.con1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.con1.BackgroundImage = global::BetterJoyForCemu.Properties.Resources.cross;
            this.con1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.con1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.con1.Enabled = false;
            this.con1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.con1.FlatAppearance.BorderSize = 2;
            this.con1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.con1.Location = new System.Drawing.Point(4, 4);
            this.con1.Margin = new System.Windows.Forms.Padding(4);
            this.con1.Name = "con1";
            this.con1.Size = new System.Drawing.Size(79, 64);
            this.con1.TabIndex = 0;
            this.con1.TabStop = false;
            this.btnTip.SetToolTip(this.con1, "Click on Joycons to join/split them");
            this.con1.UseVisualStyleBackColor = false;
            // 
            // startInTrayBox
            // 
            this.startInTrayBox.AutoSize = true;
            this.startInTrayBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startInTrayBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startInTrayBox.Location = new System.Drawing.Point(136, 11);
            this.startInTrayBox.Margin = new System.Windows.Forms.Padding(4);
            this.startInTrayBox.Name = "startInTrayBox";
            this.startInTrayBox.Size = new System.Drawing.Size(118, 25);
            this.startInTrayBox.TabIndex = 6;
            this.startInTrayBox.Text = "Start in Tray";
            this.startInTrayBox.UseVisualStyleBackColor = true;
            this.startInTrayBox.CheckedChanged += new System.EventHandler(this.startInTrayBox_CheckedChanged);
            // 
            // btn_open3rdP
            // 
            this.btn_open3rdP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_open3rdP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_open3rdP.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_open3rdP.Location = new System.Drawing.Point(4, 4);
            this.btn_open3rdP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_open3rdP.Name = "btn_open3rdP";
            this.btn_open3rdP.Size = new System.Drawing.Size(111, 46);
            this.btn_open3rdP.TabIndex = 7;
            this.btn_open3rdP.Text = "Add Controllers";
            this.btn_open3rdP.UseVisualStyleBackColor = true;
            this.btn_open3rdP.Click += new System.EventHandler(this.btn_open3rdP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.settingsTable);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(456, 462);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // settingsTable
            // 
            this.settingsTable.AutoScroll = true;
            this.settingsTable.ColumnCount = 2;
            this.settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.21276F));
            this.settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.78724F));
            this.settingsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTable.Location = new System.Drawing.Point(3, 22);
            this.settingsTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsTable.Name = "settingsTable";
            this.settingsTable.RowCount = 2;
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTable.Size = new System.Drawing.Size(450, 438);
            this.settingsTable.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.settingsApply);
            this.rightPanel.Controls.Add(this.groupBox1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(364, 10);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(3, 2, 16, 2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(456, 559);
            this.rightPanel.TabIndex = 11;
            // 
            // settingsApply
            // 
            this.settingsApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsApply.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.settingsApply.Location = new System.Drawing.Point(103, 475);
            this.settingsApply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsApply.Name = "settingsApply";
            this.settingsApply.Size = new System.Drawing.Size(246, 58);
            this.settingsApply.TabIndex = 10;
            this.settingsApply.Text = "Apply";
            this.settingsApply.UseVisualStyleBackColor = true;
            this.settingsApply.Click += new System.EventHandler(this.settingsApply_Click);
            // 
            // AutoCalibrate
            // 
            this.AutoCalibrate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoCalibrate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AutoCalibrate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AutoCalibrate.Location = new System.Drawing.Point(242, 4);
            this.AutoCalibrate.Margin = new System.Windows.Forms.Padding(4);
            this.AutoCalibrate.Name = "AutoCalibrate";
            this.AutoCalibrate.Size = new System.Drawing.Size(112, 46);
            this.AutoCalibrate.TabIndex = 8;
            this.AutoCalibrate.Text = "Calibrate";
            this.AutoCalibrate.UseVisualStyleBackColor = true;
            this.AutoCalibrate.Click += new System.EventHandler(this.StartCalibrate);
            // 
            // btn_reassign_open
            // 
            this.btn_reassign_open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reassign_open.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_reassign_open.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_reassign_open.Location = new System.Drawing.Point(123, 4);
            this.btn_reassign_open.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reassign_open.Name = "btn_reassign_open";
            this.btn_reassign_open.Size = new System.Drawing.Size(111, 46);
            this.btn_reassign_open.TabIndex = 13;
            this.btn_reassign_open.Text = "Map Buttons";
            this.btn_reassign_open.UseVisualStyleBackColor = true;
            this.btn_reassign_open.Click += new System.EventHandler(this.btn_reassign_open_Click);
            // 
            // pnlBottomControls
            // 
            this.pnlBottomControls.Controls.Add(this.version_lbl);
            this.pnlBottomControls.Controls.Add(this.passiveScanBox);
            this.pnlBottomControls.Controls.Add(this.donationLink);
            this.pnlBottomControls.Controls.Add(this.startInTrayBox);
            this.pnlBottomControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomControls.Location = new System.Drawing.Point(0, 469);
            this.pnlBottomControls.Name = "pnlBottomControls";
            this.pnlBottomControls.Size = new System.Drawing.Size(364, 100);
            this.pnlBottomControls.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlButtons, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.console, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 459);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.tableLayoutPanel3);
            this.pnlButtons.Controls.Add(this.conCntrls);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(3, 3);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(358, 223);
            this.pnlButtons.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.AutoCalibrate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_open3rdP, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_reassign_open, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 169);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(358, 54);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(820, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlBottomControls);
            this.Controls.Add(this.rightPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(838, 616);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetterJoy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenu.ResumeLayout(false);
            this.conCntrls.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.pnlBottomControls.ResumeLayout(false);
            this.pnlBottomControls.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label version_lbl;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox passiveScanBox;
        private System.Windows.Forms.LinkLabel donationLink;
        private System.Windows.Forms.GroupBox conCntrls;
        private System.Windows.Forms.Button con1;
        private System.Windows.Forms.Button con4;
        private System.Windows.Forms.Button con3;
        private System.Windows.Forms.Button con2;
        private System.Windows.Forms.Button loc4;
        private System.Windows.Forms.Button loc3;
        private System.Windows.Forms.Button loc2;
        private System.Windows.Forms.Button loc1;
        private System.Windows.Forms.ToolTip btnTip;
        private System.Windows.Forms.CheckBox startInTrayBox;
        private System.Windows.Forms.Button btn_open3rdP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel settingsTable;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Button settingsApply;
        private System.Windows.Forms.Button AutoCalibrate;
        private System.Windows.Forms.Button btn_reassign_open;
        private System.Windows.Forms.Panel pnlBottomControls;
        internal System.Windows.Forms.TextBox console;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
