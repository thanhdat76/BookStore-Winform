
namespace BookStoreManagement.Managements
{
    partial class Revenue
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLBS = new System.Windows.Forms.Label();
            this.lbDTBS = new System.Windows.Forms.Label();
            this.lbDTCT = new System.Windows.Forms.Label();
            this.lbTNS = new System.Windows.Forms.Label();
            this.lbTLNV = new System.Windows.Forms.Label();
            this.laibansach = new System.Windows.Forms.Label();
            this.doanhthubansach = new System.Windows.Forms.Label();
            this.doanhthuchothue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTinhDoanhThu = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDoanhThu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(237, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin doanh thu tháng";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thang,
            this.tc,
            this.Tt,
            this.ln});
            this.dgvDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvDoanhThu.Location = new System.Drawing.Point(6, 26);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(977, 268);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // thang
            // 
            this.thang.DataPropertyName = "Thang";
            this.thang.HeaderText = "Tháng";
            this.thang.MinimumWidth = 6;
            this.thang.Name = "thang";
            this.thang.Width = 170;
            // 
            // tc
            // 
            this.tc.DataPropertyName = "TongChi";
            this.tc.HeaderText = "Tổng chi";
            this.tc.MinimumWidth = 6;
            this.tc.Name = "tc";
            this.tc.Width = 170;
            // 
            // Tt
            // 
            this.Tt.DataPropertyName = "TongThu";
            this.Tt.HeaderText = "Tổng thu";
            this.Tt.MinimumWidth = 6;
            this.Tt.Name = "Tt";
            this.Tt.Width = 170;
            // 
            // ln
            // 
            this.ln.DataPropertyName = "LoiNhuan";
            this.ln.HeaderText = "Lợi nhuận";
            this.ln.MinimumWidth = 6;
            this.ln.Name = "ln";
            this.ln.Width = 170;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLBS);
            this.groupBox2.Controls.Add(this.lbDTBS);
            this.groupBox2.Controls.Add(this.lbDTCT);
            this.groupBox2.Controls.Add(this.lbTNS);
            this.groupBox2.Controls.Add(this.lbTLNV);
            this.groupBox2.Controls.Add(this.laibansach);
            this.groupBox2.Controls.Add(this.doanhthubansach);
            this.groupBox2.Controls.Add(this.doanhthuchothue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1213, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết doanh thu";
            // 
            // lbLBS
            // 
            this.lbLBS.AutoSize = true;
            this.lbLBS.Location = new System.Drawing.Point(873, 180);
            this.lbLBS.Name = "lbLBS";
            this.lbLBS.Size = new System.Drawing.Size(18, 20);
            this.lbLBS.TabIndex = 11;
            this.lbLBS.Text = "0";
            // 
            // lbDTBS
            // 
            this.lbDTBS.AutoSize = true;
            this.lbDTBS.Location = new System.Drawing.Point(873, 128);
            this.lbDTBS.Name = "lbDTBS";
            this.lbDTBS.Size = new System.Drawing.Size(18, 20);
            this.lbDTBS.TabIndex = 10;
            this.lbDTBS.Text = "0";
            // 
            // lbDTCT
            // 
            this.lbDTCT.AutoSize = true;
            this.lbDTCT.Location = new System.Drawing.Point(873, 71);
            this.lbDTCT.Name = "lbDTCT";
            this.lbDTCT.Size = new System.Drawing.Size(18, 20);
            this.lbDTCT.TabIndex = 9;
            this.lbDTCT.Text = "0";
            // 
            // lbTNS
            // 
            this.lbTNS.AutoSize = true;
            this.lbTNS.Location = new System.Drawing.Point(443, 128);
            this.lbTNS.Name = "lbTNS";
            this.lbTNS.Size = new System.Drawing.Size(18, 20);
            this.lbTNS.TabIndex = 8;
            this.lbTNS.Text = "0";
            // 
            // lbTLNV
            // 
            this.lbTLNV.AutoSize = true;
            this.lbTLNV.Location = new System.Drawing.Point(443, 71);
            this.lbTLNV.Name = "lbTLNV";
            this.lbTLNV.Size = new System.Drawing.Size(18, 20);
            this.lbTLNV.TabIndex = 7;
            this.lbTLNV.Text = "0";
            // 
            // laibansach
            // 
            this.laibansach.AutoSize = true;
            this.laibansach.Location = new System.Drawing.Point(673, 180);
            this.laibansach.Name = "laibansach";
            this.laibansach.Size = new System.Drawing.Size(110, 20);
            this.laibansach.TabIndex = 6;
            this.laibansach.Text = "Lãi bán sách:";
            // 
            // doanhthubansach
            // 
            this.doanhthubansach.AutoSize = true;
            this.doanhthubansach.Location = new System.Drawing.Point(673, 128);
            this.doanhthubansach.Name = "doanhthubansach";
            this.doanhthubansach.Size = new System.Drawing.Size(164, 20);
            this.doanhthubansach.TabIndex = 5;
            this.doanhthubansach.Text = "Doanh thu bán sách:";
            // 
            // doanhthuchothue
            // 
            this.doanhthuchothue.AutoSize = true;
            this.doanhthuchothue.Location = new System.Drawing.Point(673, 71);
            this.doanhthuchothue.Name = "doanhthuchothue";
            this.doanhthuchothue.Size = new System.Drawing.Size(160, 20);
            this.doanhthuchothue.TabIndex = 4;
            this.doanhthuchothue.Text = "Doanh thu cho thuê:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tiền nhập sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trả lương nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(703, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Các khoản thu về:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Các khoản chi trả:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTinhDoanhThu);
            this.groupBox3.Controls.Add(this.btnTao);
            this.groupBox3.Controls.Add(this.btnXem);
            this.groupBox3.Controls.Add(this.cmbThang);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 300);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnTinhDoanhThu
            // 
            this.btnTinhDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnTinhDoanhThu.Location = new System.Drawing.Point(10, 193);
            this.btnTinhDoanhThu.Name = "btnTinhDoanhThu";
            this.btnTinhDoanhThu.Size = new System.Drawing.Size(196, 40);
            this.btnTinhDoanhThu.TabIndex = 3;
            this.btnTinhDoanhThu.Text = "Tính doanh thu";
            this.btnTinhDoanhThu.UseVisualStyleBackColor = false;
            this.btnTinhDoanhThu.Click += new System.EventHandler(this.btnTinhDoanhThu_Click);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnTao.Location = new System.Drawing.Point(111, 131);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(95, 40);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnXem.Location = new System.Drawing.Point(10, 131);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(95, 40);
            this.btnXem.TabIndex = 0;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cmbThang
            // 
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbThang.Location = new System.Drawing.Point(37, 75);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(110, 28);
            this.cmbThang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng:";
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Revenue";
            this.Size = new System.Drawing.Size(1238, 620);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTinhDoanhThu;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLBS;
        private System.Windows.Forms.Label lbDTBS;
        private System.Windows.Forms.Label lbDTCT;
        private System.Windows.Forms.Label lbTNS;
        private System.Windows.Forms.Label lbTLNV;
        private System.Windows.Forms.Label laibansach;
        private System.Windows.Forms.Label doanhthubansach;
        private System.Windows.Forms.Label doanhthuchothue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ln;
    }
}
