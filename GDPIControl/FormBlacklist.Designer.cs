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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.L_Done, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.L_Size, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PB
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PB, 2);
            this.PB.Dock = System.Windows.Forms.DockStyle.Top;
            this.PB.Location = new System.Drawing.Point(3, 3);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(228, 23);
            this.PB.TabIndex = 0;
            // 
            // L_Done
            // 
            this.L_Done.AutoSize = true;
            this.L_Done.Location = new System.Drawing.Point(3, 29);
            this.L_Done.Name = "L_Done";
            this.L_Done.Size = new System.Drawing.Size(12, 15);
            this.L_Done.TabIndex = 1;
            this.L_Done.Text = "_";
            // 
            // L_Size
            // 
            this.L_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Size.AutoSize = true;
            this.L_Size.Location = new System.Drawing.Point(219, 29);
            this.L_Size.Name = "L_Size";
            this.L_Size.Size = new System.Drawing.Size(12, 15);
            this.L_Size.TabIndex = 1;
            this.L_Size.Text = "_";
            // 
            // FormBlacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 61);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 100);
            this.Name = "FormBlacklist";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blacklist download";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBlacklist_FormClosed);
            this.Load += new System.EventHandler(this.FormBlacklist_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.Label L_Done;
        private System.Windows.Forms.Label L_Size;
    }
}