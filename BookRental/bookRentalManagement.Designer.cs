
namespace BookStoreManagement.BookRental
{
    partial class bookRentalManagement
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
            this.tsmPhieuTS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDSUnpaid = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPaid = new System.Windows.Forms.ToolStripMenuItem();
            this.pnShowBookRental = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPhieuTS,
            this.tsmDSUnpaid,
            this.tsmPaid});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1228, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmPhieuTS
            // 
            this.tsmPhieuTS.Name = "tsmPhieuTS";
            this.tsmPhieuTS.Size = new System.Drawing.Size(146, 27);
            this.tsmPhieuTS.Text = "Phiếu thuê sách";
            this.tsmPhieuTS.Click += new System.EventHandler(this.tsmPhieuTS_Click);
            // 
            // tsmDSUnpaid
            // 
            this.tsmDSUnpaid.Name = "tsmDSUnpaid";
            this.tsmDSUnpaid.Size = new System.Drawing.Size(188, 27);
            this.tsmDSUnpaid.Text = "Danh sách đang thuê";
            this.tsmDSUnpaid.Click += new System.EventHandler(this.tsmDSUnpaid_Click);
            // 
            // tsmPaid
            // 
            this.tsmPaid.Name = "tsmPaid";
            this.tsmPaid.Size = new System.Drawing.Size(198, 27);
            this.tsmPaid.Text = "Danh sách hoàn thành";
            this.tsmPaid.Click += new System.EventHandler(this.tsmPaid_Click);
            // 
            // pnShowBookRental
            // 
            this.pnShowBookRental.Location = new System.Drawing.Point(3, 34);
            this.pnShowBookRental.Name = "pnShowBookRental";
            this.pnShowBookRental.Size = new System.Drawing.Size(1222, 770);
            this.pnShowBookRental.TabIndex = 1;
            // 
            // bookRentalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnShowBookRental);
            this.Controls.Add(this.menuStrip1);
            this.Name = "bookRentalManagement";
            this.Size = new System.Drawing.Size(1228, 810);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmPhieuTS;
        private System.Windows.Forms.ToolStripMenuItem tsmDSUnpaid;
        private System.Windows.Forms.ToolStripMenuItem tsmPaid;
        private System.Windows.Forms.Panel pnShowBookRental;
    }
}
