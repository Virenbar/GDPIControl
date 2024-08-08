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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            PB = new System.Windows.Forms.ProgressBar();
            L_Done = new System.Windows.Forms.Label();
            L_Size = new System.Windows.Forms.Label();
            RB_AZ = new System.Windows.Forms.RadioButton();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            RB_AZ1 = new System.Windows.Forms.RadioButton();
            RB_AZ2 = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
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
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 97);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new System.Drawing.Size(384, 54);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PB
            // 
            tableLayoutPanel1.SetColumnSpan(PB, 2);
            PB.Dock = System.Windows.Forms.DockStyle.Top;
            PB.Location = new System.Drawing.Point(8, 8);
            PB.Name = "PB";
            PB.Size = new System.Drawing.Size(368, 23);
            PB.TabIndex = 0;
            // 
            // L_Done
            // 
            L_Done.AutoSize = true;
            L_Done.Location = new System.Drawing.Point(8, 34);
            L_Done.Name = "L_Done";
            L_Done.Size = new System.Drawing.Size(12, 15);
            L_Done.TabIndex = 1;
            L_Done.Text = "_";
            // 
            // L_Size
            // 
            L_Size.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            L_Size.AutoSize = true;
            L_Size.Location = new System.Drawing.Point(364, 34);
            L_Size.Name = "L_Size";
            L_Size.Size = new System.Drawing.Size(12, 15);
            L_Size.TabIndex = 1;
            L_Size.Text = "_";
            // 
            // RB_AZ
            // 
            RB_AZ.AutoSize = true;
            RB_AZ.Checked = true;
            RB_AZ.Location = new System.Drawing.Point(72, 3);
            RB_AZ.Name = "RB_AZ";
            RB_AZ.Size = new System.Drawing.Size(67, 19);
            RB_AZ.TabIndex = 1;
            RB_AZ.TabStop = true;
            RB_AZ.Text = "Original";
            RB_AZ.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(RB_AZ);
            flowLayoutPanel1.Controls.Add(RB_AZ1);
            flowLayoutPanel1.Controls.Add(RB_AZ2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(RB_AF);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 15);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(384, 50);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "AntiZapret";
            // 
            // RB_AZ1
            // 
            RB_AZ1.AutoSize = true;
            RB_AZ1.Location = new System.Drawing.Point(145, 3);
            RB_AZ1.Name = "RB_AZ1";
            RB_AZ1.Size = new System.Drawing.Size(67, 19);
            RB_AZ1.TabIndex = 1;
            RB_AZ1.TabStop = true;
            RB_AZ1.Text = "Mirror 1";
            RB_AZ1.UseVisualStyleBackColor = true;
            // 
            // RB_AZ2
            // 
            RB_AZ2.AutoSize = true;
            flowLayoutPanel1.SetFlowBreak(RB_AZ2, true);
            RB_AZ2.Location = new System.Drawing.Point(218, 3);
            RB_AZ2.Name = "RB_AZ2";
            RB_AZ2.Size = new System.Drawing.Size(67, 19);
            RB_AZ2.TabIndex = 1;
            RB_AZ2.TabStop = true;
            RB_AZ2.Text = "Mirror 2";
            RB_AZ2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 30);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "antifilter";
            // 
            // RB_AF
            // 
            RB_AF.AutoSize = true;
            RB_AF.Location = new System.Drawing.Point(60, 28);
            RB_AF.Name = "RB_AF";
            RB_AF.Size = new System.Drawing.Size(67, 19);
            RB_AF.TabIndex = 1;
            RB_AF.TabStop = true;
            RB_AF.Text = "Original";
            RB_AF.UseVisualStyleBackColor = true;
            // 
            // B_Download
            // 
            B_Download.AutoSize = true;
            B_Download.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            B_Download.Location = new System.Drawing.Point(308, 3);
            B_Download.Name = "B_Download";
            B_Download.Padding = new System.Windows.Forms.Padding(1);
            B_Download.Size = new System.Drawing.Size(73, 27);
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
            label1.Size = new System.Drawing.Size(92, 15);
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
            flowLayoutPanel2.Location = new System.Drawing.Point(0, 64);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(384, 33);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // FormBlacklist
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            ClientSize = new System.Drawing.Size(384, 151);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            ForeColor = System.Drawing.Color.Black;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(639, 202);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(400, 190);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}