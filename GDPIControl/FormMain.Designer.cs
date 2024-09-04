namespace GDPIControl
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            TrayControl = new System.Windows.Forms.NotifyIcon(components);
            TrayMenu = new System.Windows.Forms.ContextMenuStrip(components);
            MI_Start = new System.Windows.Forms.ToolStripMenuItem();
            MI_Stop = new System.Windows.Forms.ToolStripMenuItem();
            MI_Show = new System.Windows.Forms.ToolStripMenuItem();
            MI_Close = new System.Windows.Forms.ToolStripMenuItem();
            FormMenu = new System.Windows.Forms.MenuStrip();
            MI_Settings = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            MI_Blacklist = new System.Windows.Forms.ToolStripMenuItem();
            MI_Userlist = new System.Windows.Forms.ToolStripMenuItem();
            MI_About = new System.Windows.Forms.ToolStripMenuItem();
            gDPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            B_Restart = new System.Windows.Forms.Button();
            B_Close = new System.Windows.Forms.Button();
            B_Start = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            checkBox3 = new System.Windows.Forms.CheckBox();
            BS_ControlSettings = new System.Windows.Forms.BindingSource(components);
            checkBox2 = new System.Windows.Forms.CheckBox();
            RB_Custom_1 = new System.Windows.Forms.RadioButton();
            RB_Custom_2 = new System.Windows.Forms.RadioButton();
            RB_Custom_3 = new System.Windows.Forms.RadioButton();
            RB_M1 = new System.Windows.Forms.RadioButton();
            RB_M2 = new System.Windows.Forms.RadioButton();
            RB_M3 = new System.Windows.Forms.RadioButton();
            RB_M4 = new System.Windows.Forms.RadioButton();
            RB_M5 = new System.Windows.Forms.RadioButton();
            RB_M6 = new System.Windows.Forms.RadioButton();
            B_Edit = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox2 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            groupBox3 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            RB_M7 = new System.Windows.Forms.RadioButton();
            RB_M8 = new System.Windows.Forms.RadioButton();
            RB_M9 = new System.Windows.Forms.RadioButton();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            TrayMenu.SuspendLayout();
            FormMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BS_ControlSettings).BeginInit();
            groupBox1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // TrayControl
            // 
            TrayControl.ContextMenuStrip = TrayMenu;
            TrayControl.Icon = (System.Drawing.Icon)resources.GetObject("TrayControl.Icon");
            TrayControl.Text = "GDPIControl";
            TrayControl.Visible = true;
            TrayControl.MouseClick += TrayControl_MouseClick;
            // 
            // TrayMenu
            // 
            TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MI_Start, MI_Stop, MI_Show, MI_Close });
            TrayMenu.Name = "TrayMenu";
            TrayMenu.Size = new System.Drawing.Size(173, 92);
            // 
            // MI_Start
            // 
            MI_Start.Image = Properties.Resources.GDPI_green;
            MI_Start.Name = "MI_Start";
            MI_Start.Size = new System.Drawing.Size(172, 22);
            MI_Start.Text = "Start GDPI";
            MI_Start.Click += MI_Start_Click;
            // 
            // MI_Stop
            // 
            MI_Stop.Image = Properties.Resources.GDPI_red;
            MI_Stop.Name = "MI_Stop";
            MI_Stop.Size = new System.Drawing.Size(172, 22);
            MI_Stop.Text = "Stop GDPI";
            MI_Stop.Click += MI_Stop_Click;
            // 
            // MI_Show
            // 
            MI_Show.Image = icons8.Settings16;
            MI_Show.Name = "MI_Show";
            MI_Show.Size = new System.Drawing.Size(172, 22);
            MI_Show.Text = "Show GDPIControl";
            MI_Show.Click += MI_Show_Click;
            // 
            // MI_Close
            // 
            MI_Close.Image = icons8.Shutdown16;
            MI_Close.Name = "MI_Close";
            MI_Close.Size = new System.Drawing.Size(172, 22);
            MI_Close.Text = "Close GDPIControl";
            MI_Close.Click += MI_Close_Click;
            // 
            // FormMenu
            // 
            FormMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MI_Settings, toolStripMenuItem3, MI_About, gDPIToolStripMenuItem });
            FormMenu.Location = new System.Drawing.Point(0, 0);
            FormMenu.Name = "FormMenu";
            FormMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            FormMenu.Size = new System.Drawing.Size(534, 24);
            FormMenu.TabIndex = 1;
            FormMenu.Text = "menuStrip1";
            // 
            // MI_Settings
            // 
            MI_Settings.Image = icons8.Settings16;
            MI_Settings.Name = "MI_Settings";
            MI_Settings.Size = new System.Drawing.Size(77, 20);
            MI_Settings.Text = "Settings";
            MI_Settings.Click += MI_Settings_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MI_Blacklist, MI_Userlist });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(64, 20);
            toolStripMenuItem3.Text = "Site Lists";
            // 
            // MI_Blacklist
            // 
            MI_Blacklist.Name = "MI_Blacklist";
            MI_Blacklist.Size = new System.Drawing.Size(158, 22);
            MI_Blacklist.Text = "Update Blacklist";
            MI_Blacklist.Click += MI_Blacklist_Click;
            // 
            // MI_Userlist
            // 
            MI_Userlist.Name = "MI_Userlist";
            MI_Userlist.Size = new System.Drawing.Size(158, 22);
            MI_Userlist.Text = "Open Userlist";
            MI_Userlist.Click += MI_Userlist_Click;
            // 
            // MI_About
            // 
            MI_About.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            MI_About.Image = icons8.Info16;
            MI_About.Name = "MI_About";
            MI_About.Size = new System.Drawing.Size(68, 20);
            MI_About.Text = "About";
            MI_About.Click += MI_About_Click;
            // 
            // gDPIToolStripMenuItem
            // 
            gDPIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { downloadToolStripMenuItem });
            gDPIToolStripMenuItem.Enabled = false;
            gDPIToolStripMenuItem.Name = "gDPIToolStripMenuItem";
            gDPIToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            gDPIToolStripMenuItem.Text = "GDPI";
            gDPIToolStripMenuItem.Visible = false;
            // 
            // downloadToolStripMenuItem
            // 
            downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            downloadToolStripMenuItem.Text = "Download";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(B_Restart, 0, 0);
            tableLayoutPanel1.Controls.Add(B_Close, 2, 0);
            tableLayoutPanel1.Controls.Add(B_Start, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 238);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(534, 33);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // B_Restart
            // 
            B_Restart.AutoSize = true;
            B_Restart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            B_Restart.Image = icons8.Replace16;
            B_Restart.Location = new System.Drawing.Point(3, 3);
            B_Restart.Name = "B_Restart";
            B_Restart.Padding = new System.Windows.Forms.Padding(1);
            B_Restart.Size = new System.Drawing.Size(100, 27);
            B_Restart.TabIndex = 7;
            B_Restart.Text = "Restart GDPI";
            B_Restart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            B_Restart.UseVisualStyleBackColor = true;
            B_Restart.Click += B_Restart_Click;
            // 
            // B_Close
            // 
            B_Close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            B_Close.AutoSize = true;
            B_Close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            B_Close.Image = icons8.Shutdown16;
            B_Close.Location = new System.Drawing.Point(398, 3);
            B_Close.Name = "B_Close";
            B_Close.Padding = new System.Windows.Forms.Padding(1);
            B_Close.Size = new System.Drawing.Size(133, 27);
            B_Close.TabIndex = 3;
            B_Close.Text = "Close GDPIControl";
            B_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            B_Close.UseVisualStyleBackColor = true;
            B_Close.Click += B_Close_Click;
            // 
            // B_Start
            // 
            B_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            B_Start.AutoSize = true;
            B_Start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            B_Start.Image = Properties.Resources.GDPI_green;
            B_Start.Location = new System.Drawing.Point(223, 3);
            B_Start.Name = "B_Start";
            B_Start.Padding = new System.Windows.Forms.Padding(1);
            B_Start.Size = new System.Drawing.Size(88, 27);
            B_Start.TabIndex = 1;
            B_Start.Text = "Start GDPI";
            B_Start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            B_Start.UseVisualStyleBackColor = true;
            B_Start.Click += B_Start_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(checkBox3);
            flowLayoutPanel1.Controls.Add(checkBox2);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            flowLayoutPanel1.Size = new System.Drawing.Size(534, 31);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", BS_ControlSettings, "UseBlacklist", true));
            checkBox3.Location = new System.Drawing.Point(6, 6);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(91, 19);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Use Blacklist";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // BS_ControlSettings
            // 
            BS_ControlSettings.DataSource = typeof(Model.ControlSettings);
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", BS_ControlSettings, "UseUserlist", true));
            checkBox2.Location = new System.Drawing.Point(103, 6);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(86, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Use Userlist";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // RB_Custom_1
            // 
            RB_Custom_1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            RB_Custom_1.AutoSize = true;
            RB_Custom_1.Location = new System.Drawing.Point(91, 6);
            RB_Custom_1.Name = "RB_Custom_1";
            RB_Custom_1.Size = new System.Drawing.Size(105, 19);
            RB_Custom_1.TabIndex = 6;
            RB_Custom_1.TabStop = true;
            RB_Custom_1.Text = "GDPI Settings 1";
            RB_Custom_1.UseVisualStyleBackColor = true;
            RB_Custom_1.CheckedChanged += RB_CheckedChanged;
            // 
            // RB_Custom_2
            // 
            RB_Custom_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            RB_Custom_2.AutoSize = true;
            RB_Custom_2.Location = new System.Drawing.Point(202, 6);
            RB_Custom_2.Name = "RB_Custom_2";
            RB_Custom_2.Size = new System.Drawing.Size(105, 19);
            RB_Custom_2.TabIndex = 6;
            RB_Custom_2.TabStop = true;
            RB_Custom_2.Text = "GDPI Settings 2";
            RB_Custom_2.UseVisualStyleBackColor = true;
            RB_Custom_2.CheckedChanged += RB_CheckedChanged;
            // 
            // RB_Custom_3
            // 
            RB_Custom_3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            RB_Custom_3.AutoSize = true;
            RB_Custom_3.Location = new System.Drawing.Point(313, 6);
            RB_Custom_3.Name = "RB_Custom_3";
            RB_Custom_3.Size = new System.Drawing.Size(105, 19);
            RB_Custom_3.TabIndex = 6;
            RB_Custom_3.TabStop = true;
            RB_Custom_3.Text = "GDPI Settings 3";
            RB_Custom_3.UseVisualStyleBackColor = true;
            RB_Custom_3.CheckedChanged += RB_CheckedChanged;
            // 
            // RB_M1
            // 
            RB_M1.AutoSize = true;
            RB_M1.Location = new System.Drawing.Point(3, 3);
            RB_M1.Name = "RB_M1";
            RB_M1.Size = new System.Drawing.Size(163, 19);
            RB_M1.TabIndex = 1;
            RB_M1.TabStop = true;
            RB_M1.Text = "-1 Most compatible mode";
            RB_M1.UseVisualStyleBackColor = true;
            RB_M1.CheckedChanged += RB_CheckedChanged;
            // 
            // RB_M2
            // 
            RB_M2.AutoSize = true;
            RB_M2.Location = new System.Drawing.Point(3, 53);
            RB_M2.Name = "RB_M2";
            RB_M2.Size = new System.Drawing.Size(262, 19);
            RB_M2.TabIndex = 2;
            RB_M2.TabStop = true;
            RB_M2.Text = "-2 Better speed for HTTPS yet still compatible";
            RB_M2.UseVisualStyleBackColor = true;
            RB_M2.CheckedChanged += RB_CheckedChanged;
            // 
            // RB_M3
            // 
            RB_M3.AutoSize = true;
            RB_M3.Location = new System.Drawing.Point(3, 28);
            RB_M3.Name = "RB_M3";
            RB_M3.Size = new System.Drawing.Size(213, 19);
            RB_M3.TabIndex = 3;
            RB_M3.TabStop = true;
            RB_M3.Text = "-3 Better speed for HTTP and HTTPS";
            RB_M3.UseVisualStyleBackColor = true;
            RB_M3.CheckedChanged += RB_CheckedChanged;
            // 
            // RB_M4
            // 
            RB_M4.AutoSize = true;
            RB_M4.Location = new System.Drawing.Point(3, 78);
            RB_M4.Name = "RB_M4";
            RB_M4.Size = new System.Drawing.Size(95, 19);
            RB_M4.TabIndex = 4;
            RB_M4.TabStop = true;
            RB_M4.Text = "-4 Best speed";
            RB_M4.UseVisualStyleBackColor = true;
            RB_M4.CheckedChanged += RB_CheckedChanged;
            // 
            // RB_M5
            // 
            RB_M5.AutoSize = true;
            RB_M5.Location = new System.Drawing.Point(3, 3);
            RB_M5.Name = "RB_M5";
            RB_M5.Size = new System.Drawing.Size(36, 19);
            RB_M5.TabIndex = 5;
            RB_M5.TabStop = true;
            RB_M5.Text = "-5";
            RB_M5.UseVisualStyleBackColor = true;
            RB_M5.CheckedChanged += RB_CheckedChanged;
            // 
            // RB_M6
            // 
            RB_M6.AutoSize = true;
            RB_M6.Location = new System.Drawing.Point(45, 3);
            RB_M6.Name = "RB_M6";
            RB_M6.Size = new System.Drawing.Size(36, 19);
            RB_M6.TabIndex = 6;
            RB_M6.TabStop = true;
            RB_M6.Text = "-6";
            RB_M6.UseVisualStyleBackColor = true;
            RB_M6.CheckedChanged += RB_CheckedChanged;
            // 
            // B_Edit
            // 
            B_Edit.AutoSize = true;
            B_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            B_Edit.Location = new System.Drawing.Point(3, 3);
            B_Edit.Name = "B_Edit";
            B_Edit.Size = new System.Drawing.Size(82, 25);
            B_Edit.TabIndex = 5;
            B_Edit.Text = "Edit Settings";
            B_Edit.UseVisualStyleBackColor = true;
            B_Edit.Click += B_Edit_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(flowLayoutPanel3);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(3, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(528, 53);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Custom settings";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(B_Edit);
            flowLayoutPanel3.Controls.Add(RB_Custom_1);
            flowLayoutPanel3.Controls.Add(RB_Custom_2);
            flowLayoutPanel3.Controls.Add(RB_Custom_3);
            flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(522, 31);
            flowLayoutPanel3.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(flowLayoutPanel4);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox2.Location = new System.Drawing.Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(274, 122);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "LEGACY modesets";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(RB_M1);
            flowLayoutPanel4.Controls.Add(RB_M3);
            flowLayoutPanel4.Controls.Add(RB_M2);
            flowLayoutPanel4.Controls.Add(RB_M4);
            flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel4.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new System.Drawing.Size(268, 100);
            flowLayoutPanel4.TabIndex = 7;
            flowLayoutPanel4.WrapContents = false;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(flowLayoutPanel5);
            groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox3.Location = new System.Drawing.Point(283, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(248, 72);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Modern modesets";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(RB_M5);
            flowLayoutPanel5.Controls.Add(RB_M6);
            flowLayoutPanel5.Controls.Add(RB_M7);
            flowLayoutPanel5.Controls.Add(RB_M8);
            flowLayoutPanel5.Controls.Add(RB_M9);
            flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel5.Location = new System.Drawing.Point(3, 19);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new System.Drawing.Size(242, 50);
            flowLayoutPanel5.TabIndex = 7;
            // 
            // RB_M7
            // 
            RB_M7.AutoSize = true;
            flowLayoutPanel5.SetFlowBreak(RB_M7, true);
            RB_M7.Location = new System.Drawing.Point(87, 3);
            RB_M7.Name = "RB_M7";
            RB_M7.Size = new System.Drawing.Size(36, 19);
            RB_M7.TabIndex = 6;
            RB_M7.TabStop = true;
            RB_M7.Text = "-7";
            RB_M7.UseVisualStyleBackColor = true;
            RB_M7.CheckedChanged += RB_CheckedChanged;
            // 
            // RB_M8
            // 
            RB_M8.AutoSize = true;
            RB_M8.Location = new System.Drawing.Point(3, 28);
            RB_M8.Name = "RB_M8";
            RB_M8.Size = new System.Drawing.Size(36, 19);
            RB_M8.TabIndex = 6;
            RB_M8.TabStop = true;
            RB_M8.Text = "-8";
            RB_M8.UseVisualStyleBackColor = true;
            RB_M8.CheckedChanged += RB_CheckedChanged;
            // 
            // RB_M9
            // 
            RB_M9.AutoSize = true;
            RB_M9.Location = new System.Drawing.Point(45, 28);
            RB_M9.Name = "RB_M9";
            RB_M9.Size = new System.Drawing.Size(84, 19);
            RB_M9.TabIndex = 6;
            RB_M9.TabStop = true;
            RB_M9.Text = "-9 (default)";
            RB_M9.UseVisualStyleBackColor = true;
            RB_M9.CheckedChanged += RB_CheckedChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox3, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 55);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(534, 187);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            ClientSize = new System.Drawing.Size(534, 271);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(FormMenu);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = FormMenu;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(650, 350);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(550, 310);
            Name = "FormMain";
            Text = "GDPIControl";
            FormClosing += FormMain_FormClosing;
            TrayMenu.ResumeLayout(false);
            FormMenu.ResumeLayout(false);
            FormMenu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BS_ControlSettings).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NotifyIcon TrayControl;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.MenuStrip FormMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button B_Close;
        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.ToolStripMenuItem MI_Userlist;
        private System.Windows.Forms.ToolStripMenuItem MI_Blacklist;
        private System.Windows.Forms.ToolStripMenuItem MI_About;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton RB_M1;
        private System.Windows.Forms.RadioButton RB_M2;
        private System.Windows.Forms.RadioButton RB_M3;
        private System.Windows.Forms.RadioButton RB_M4;
        private System.Windows.Forms.RadioButton RB_M5;
        private System.Windows.Forms.RadioButton RB_Custom_1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.BindingSource BS_ControlSettings;
        private System.Windows.Forms.ToolStripMenuItem MI_Start;
        private System.Windows.Forms.ToolStripMenuItem MI_Stop;
        private System.Windows.Forms.ToolStripMenuItem MI_Show;
        private System.Windows.Forms.ToolStripMenuItem MI_Close;
        private System.Windows.Forms.RadioButton RB_M6;
        private System.Windows.Forms.RadioButton RB_Custom_2;
        private System.Windows.Forms.Button B_Edit;
        private System.Windows.Forms.RadioButton RB_Custom_3;
        private System.Windows.Forms.Button B_Restart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton RB_M7;
        private System.Windows.Forms.RadioButton RB_M8;
        private System.Windows.Forms.RadioButton RB_M9;
        private System.Windows.Forms.ToolStripMenuItem gDPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_Settings;
    }
}