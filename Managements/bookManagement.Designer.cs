
namespace BookStoreManagement.Managements
{
    partial class bookManagement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnBookManagement = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sáchToolStripMenuItem,
            this.phiếuNhậpToolStripMenuItem,
            this.danhSáchPhiếuNhậpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1228, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.sáchToolStripMenuItem.Text = "Sách";
            this.sáchToolStripMenuItem.Click += new System.EventHandler(this.sáchToolStripMenuItem_Click);
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            this.phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            this.phiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(150, 27);
            this.phiếuNhậpToolStripMenuItem.Text = "Phiếu nhập sách";
            this.phiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.phiếuNhậpToolStripMenuItem_Click);
            // 
            // danhSáchPhiếuNhậpToolStripMenuItem
            // 
            this.danhSáchPhiếuNhậpToolStripMenuItem.Name = "danhSáchPhiếuNhậpToolStripMenuItem";
            this.danhSáchPhiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(196, 27);
            this.danhSáchPhiếuNhậpToolStripMenuItem.Text = "Danh sách phiếu nhập";
            this.danhSáchPhiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhiếuNhậpToolStripMenuItem_Click);
            // 
            // pnBookManagement
            // 
            this.pnBookManagement.Location = new System.Drawing.Point(3, 41);
            this.pnBookManagement.Name = "pnBookManagement";
            this.pnBookManagement.Size = new System.Drawing.Size(1224, 760);
            this.pnBookManagement.TabIndex = 1;
            // 
            // bookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBookManagement);
            this.Controls.Add(this.menuStrip1);
            this.Name = "bookManagement";
            this.Size = new System.Drawing.Size(1228, 810);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.Panel pnBookManagement;
    }
}
