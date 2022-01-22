namespace GDPIControl
{
    partial class FormAbout
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LL_GDPI = new System.Windows.Forms.LinkLabel();
            this.LL_WinDivert = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LL_Control = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.L_Version = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LL_Icons = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 106);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.LL_GDPI);
            this.flowLayoutPanel2.Controls.Add(this.LL_WinDivert);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(59, 69);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(267, 34);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // LL_GDPI
            // 
            this.LL_GDPI.AutoSize = true;
            this.LL_GDPI.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.LL_GDPI.Location = new System.Drawing.Point(3, 0);
            this.LL_GDPI.Name = "LL_GDPI";
            this.LL_GDPI.Size = new System.Drawing.Size(133, 17);
            this.LL_GDPI.TabIndex = 3;
            this.LL_GDPI.TabStop = true;
            this.LL_GDPI.Text = "GoodbyeDPI by ValdikSS";
            this.LL_GDPI.UseCompatibleTextRendering = true;
            this.LL_GDPI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_GDPI_LinkClicked);
            // 
            // LL_WinDivert
            // 
            this.LL_WinDivert.AutoSize = true;
            this.LL_WinDivert.LinkArea = new System.Windows.Forms.LinkArea(0, 9);
            this.LL_WinDivert.Location = new System.Drawing.Point(3, 17);
            this.LL_WinDivert.Name = "LL_WinDivert";
            this.LL_WinDivert.Size = new System.Drawing.Size(107, 17);
            this.LL_WinDivert.TabIndex = 3;
            this.LL_WinDivert.TabStop = true;
            this.LL_WinDivert.Text = "WinDivert by basil00";
            this.LL_WinDivert.UseCompatibleTextRendering = true;
            this.LL_WinDivert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_WinDivert_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.LL_Control);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.L_Version);
            this.flowLayoutPanel1.Controls.Add(this.LL_Icons);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(59, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 60);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // LL_Control
            // 
            this.LL_Control.AutoSize = true;
            this.LL_Control.LinkArea = new System.Windows.Forms.LinkArea(0, 11);
            this.LL_Control.Location = new System.Drawing.Point(3, 0);
            this.LL_Control.Name = "LL_Control";
            this.LL_Control.Size = new System.Drawing.Size(129, 17);
            this.LL_Control.TabIndex = 3;
            this.LL_Control.TabStop = true;
            this.LL_Control.Text = "GDPIControl by Virenbar";
            this.LL_Control.UseCompatibleTextRendering = true;
            this.LL_Control.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Control_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Small tray application for controlling GoodbyeDPI";
            // 
            // L_Version
            // 
            this.L_Version.AutoSize = true;
            this.L_Version.Location = new System.Drawing.Point(3, 30);
            this.L_Version.Name = "L_Version";
            this.L_Version.Size = new System.Drawing.Size(14, 13);
            this.L_Version.TabIndex = 3;
            this.L_Version.Text = "V";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GDPIControl.Properties.Resources.GDPI;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(9);
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LL_Icons
            // 
            this.LL_Icons.AutoSize = true;
            this.LL_Icons.LinkArea = new System.Windows.Forms.LinkArea(9, 6);
            this.LL_Icons.Location = new System.Drawing.Point(3, 43);
            this.LL_Icons.Name = "LL_Icons";
            this.LL_Icons.Size = new System.Drawing.Size(83, 17);
            this.LL_Icons.TabIndex = 4;
            this.LL_Icons.TabStop = true;
            this.LL_Icons.Text = "Icons by Icons8";
            this.LL_Icons.UseCompatibleTextRendering = true;
            this.LL_Icons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_Icons_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(329, 183);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 222);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(259, 179);
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About GDPIControl";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Version;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.LinkLabel LL_GDPI;
        private System.Windows.Forms.LinkLabel LL_WinDivert;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel LL_Control;
        private System.Windows.Forms.LinkLabel LL_Icons;
    }
}