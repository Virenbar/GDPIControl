namespace GDPIControl
{
    partial class FormBlacklist
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PB = new System.Windows.Forms.ProgressBar();
            this.L_Done = new System.Windows.Forms.Label();
            this.L_Size = new System.Windows.Forms.Label();
            this.RB_AZ = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RB_AZM = new System.Windows.Forms.RadioButton();
            this.RB_AF = new System.Windows.Forms.RadioButton();
            this.B_Download = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.L_Done, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_Size, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 92);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PB, 2);
            this.PB.Dock = System.Windows.Forms.DockStyle.Top;
            this.PB.Location = new System.Drawing.Point(8, 8);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(318, 20);
            this.PB.TabIndex = 0;
            // 
            // L_Done
            // 
            this.L_Done.AutoSize = true;
            this.L_Done.Location = new System.Drawing.Point(8, 31);
            this.L_Done.Name = "L_Done";
            this.L_Done.Size = new System.Drawing.Size(12, 13);
            this.L_Done.TabIndex = 1;
            this.L_Done.Text = "_";
            // 
            // L_Size
            // 
            this.L_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Size.AutoSize = true;
            this.L_Size.Location = new System.Drawing.Point(314, 31);
            this.L_Size.Name = "L_Size";
            this.L_Size.Size = new System.Drawing.Size(12, 13);
            this.L_Size.TabIndex = 1;
            this.L_Size.Text = "_";
            // 
            // RB_AZ
            // 
            this.RB_AZ.AutoSize = true;
            this.RB_AZ.Checked = true;
            this.RB_AZ.Location = new System.Drawing.Point(3, 3);
            this.RB_AZ.Name = "RB_AZ";
            this.RB_AZ.Size = new System.Drawing.Size(79, 17);
            this.RB_AZ.TabIndex = 1;
            this.RB_AZ.TabStop = true;
            this.RB_AZ.Text = "AntiZapret";
            this.RB_AZ.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.RB_AZ);
            this.flowLayoutPanel1.Controls.Add(this.RB_AZM);
            this.flowLayoutPanel1.Controls.Add(this.RB_AF);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 23);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // RB_AZM
            // 
            this.RB_AZM.AutoSize = true;
            this.RB_AZM.Location = new System.Drawing.Point(88, 3);
            this.RB_AZM.Name = "RB_AZM";
            this.RB_AZM.Size = new System.Drawing.Size(119, 17);
            this.RB_AZM.TabIndex = 1;
            this.RB_AZM.TabStop = true;
            this.RB_AZM.Text = "AntiZapret (mirror)";
            this.RB_AZM.UseVisualStyleBackColor = true;
            // 
            // RB_AF
            // 
            this.RB_AF.AutoSize = true;
            this.RB_AF.Location = new System.Drawing.Point(213, 3);
            this.RB_AF.Name = "RB_AF";
            this.RB_AF.Size = new System.Drawing.Size(69, 17);
            this.RB_AF.TabIndex = 1;
            this.RB_AF.TabStop = true;
            this.RB_AF.Text = "antifilter";
            this.RB_AF.UseVisualStyleBackColor = true;
            // 
            // B_Download
            // 
            this.B_Download.AutoSize = true;
            this.B_Download.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Download.Location = new System.Drawing.Point(258, 3);
            this.B_Download.Name = "B_Download";
            this.B_Download.Padding = new System.Windows.Forms.Padding(1);
            this.B_Download.Size = new System.Drawing.Size(73, 25);
            this.B_Download.TabIndex = 3;
            this.B_Download.Text = "Download";
            this.B_Download.UseVisualStyleBackColor = true;
            this.B_Download.Click += new System.EventHandler(this.B_Download_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Blacklist Source:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.B_Download);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 61);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(334, 31);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // FormBlacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::GDPIControl.Properties.Settings.Default.BackColor;
            this.ClientSize = new System.Drawing.Size(334, 141);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::GDPIControl.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::GDPIControl.Properties.Settings.Default, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::GDPIControl.Properties.Settings.Default, "ForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = global::GDPIControl.Properties.Settings.Default.Font;
            this.ForeColor = global::GDPIControl.Properties.Settings.Default.ForeColor;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(220, 180);
            this.Name = "FormBlacklist";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blacklist Download";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBlacklist_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.Label L_Done;
        private System.Windows.Forms.Label L_Size;
        private System.Windows.Forms.RadioButton RB_AZ;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton RB_AZM;
        private System.Windows.Forms.RadioButton RB_AF;
        private System.Windows.Forms.Button B_Download;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}