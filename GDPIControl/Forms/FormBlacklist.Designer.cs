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
            Properties.Settings settings1 = new Properties.Settings();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            PB = new System.Windows.Forms.ProgressBar();
            L_Done = new System.Windows.Forms.Label();
            L_Size = new System.Windows.Forms.Label();
            RB_AZ = new System.Windows.Forms.RadioButton();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            RB_AZ1 = new System.Windows.Forms.RadioButton();
            RB_AZ2 = new System.Windows.Forms.RadioButton();
            RB_AF = new System.Windows.Forms.RadioButton();
            B_Download = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(PB, 0, 0);
            tableLayoutPanel1.Controls.Add(L_Done, 0, 1);
            tableLayoutPanel1.Controls.Add(L_Size, 1, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 92);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(384, 49);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PB
            // 
            tableLayoutPanel1.SetColumnSpan(PB, 2);
            PB.Dock = System.Windows.Forms.DockStyle.Top;
            PB.Location = new System.Drawing.Point(8, 8);
            PB.Name = "PB";
            PB.Size = new System.Drawing.Size(368, 20);
            PB.TabIndex = 0;
            // 
            // L_Done
            // 
            L_Done.AutoSize = true;
            L_Done.Location = new System.Drawing.Point(8, 31);
            L_Done.Name = "L_Done";
            L_Done.Size = new System.Drawing.Size(12, 13);
            L_Done.TabIndex = 1;
            L_Done.Text = "_";
            // 
            // L_Size
            // 
            L_Size.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            L_Size.AutoSize = true;
            L_Size.Location = new System.Drawing.Point(364, 31);
            L_Size.Name = "L_Size";
            L_Size.Size = new System.Drawing.Size(12, 13);
            L_Size.TabIndex = 1;
            L_Size.Text = "_";
            // 
            // RB_AZ
            // 
            RB_AZ.AutoSize = true;
            RB_AZ.Checked = true;
            RB_AZ.Location = new System.Drawing.Point(3, 3);
            RB_AZ.Name = "RB_AZ";
            RB_AZ.Size = new System.Drawing.Size(79, 17);
            RB_AZ.TabIndex = 1;
            RB_AZ.TabStop = true;
            RB_AZ.Text = "AntiZapret";
            RB_AZ.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(RB_AZ);
            flowLayoutPanel1.Controls.Add(RB_AZ1);
            flowLayoutPanel1.Controls.Add(RB_AZ2);
            flowLayoutPanel1.Controls.Add(RB_AF);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 13);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(384, 46);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // RB_AZ1
            // 
            RB_AZ1.AutoSize = true;
            RB_AZ1.Location = new System.Drawing.Point(88, 3);
            RB_AZ1.Name = "RB_AZ1";
            RB_AZ1.Size = new System.Drawing.Size(128, 17);
            RB_AZ1.TabIndex = 1;
            RB_AZ1.TabStop = true;
            RB_AZ1.Text = "AntiZapret (mirror 1)";
            RB_AZ1.UseVisualStyleBackColor = true;
            // 
            // RB_AZ2
            // 
            RB_AZ2.AutoSize = true;
            RB_AZ2.Location = new System.Drawing.Point(222, 3);
            RB_AZ2.Name = "RB_AZ2";
            RB_AZ2.Size = new System.Drawing.Size(128, 17);
            RB_AZ2.TabIndex = 1;
            RB_AZ2.TabStop = true;
            RB_AZ2.Text = "AntiZapret (mirror 2)";
            RB_AZ2.UseVisualStyleBackColor = true;
            // 
            // RB_AF
            // 
            RB_AF.AutoSize = true;
            RB_AF.Location = new System.Drawing.Point(3, 26);
            RB_AF.Name = "RB_AF";
            RB_AF.Size = new System.Drawing.Size(69, 17);
            RB_AF.TabIndex = 1;
            RB_AF.TabStop = true;
            RB_AF.Text = "antifilter";
            RB_AF.UseVisualStyleBackColor = true;
            // 
            // B_Download
            // 
            B_Download.AutoSize = true;
            B_Download.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            B_Download.Location = new System.Drawing.Point(308, 3);
            B_Download.Name = "B_Download";
            B_Download.Padding = new System.Windows.Forms.Padding(1);
            B_Download.Size = new System.Drawing.Size(73, 25);
            B_Download.TabIndex = 3;
            B_Download.Text = "Download";
            B_Download.UseVisualStyleBackColor = true;
            B_Download.Click += B_Download_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 13);
            label1.TabIndex = 4;
            label1.Text = "Blacklist Source:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(B_Download);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 61);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(384, 31);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // FormBlacklist
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            ClientSize = new System.Drawing.Size(384, 141);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            settings1.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            settings1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            settings1.ForeColor = System.Drawing.Color.Black;
            settings1.SettingsKey = "";
            DataBindings.Add(new System.Windows.Forms.Binding("Font", settings1, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            DataBindings.Add(new System.Windows.Forms.Binding("BackColor", settings1, "BackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", settings1, "ForeColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.Black;
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(550, 180);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(400, 180);
            Name = "FormBlacklist";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Blacklist Download";
            FormClosed += FormBlacklist_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.Label L_Done;
        private System.Windows.Forms.Label L_Size;
        private System.Windows.Forms.RadioButton RB_AZ;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton RB_AF;
        private System.Windows.Forms.Button B_Download;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton RB_AZ1;
        private System.Windows.Forms.RadioButton RB_AZ2;
    }
}