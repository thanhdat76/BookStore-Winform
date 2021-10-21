
namespace BookStoreManagement.Managements
{
    partial class Payroll
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
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtThemGioLam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiemDanh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvThongTinNV = new System.Windows.Forms.DataGridView();
            this.codenv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namenv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sgl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lcb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.MNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtLuongLamThem = new System.Windows.Forms.MaskedTextBox();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTinhLuong);
            this.groupBox1.Controls.Add(this.btnTao);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.cmbMaNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbThang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo bảng lương";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnTinhLuong.Location = new System.Drawing.Point(293, 116);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(141, 30);
            this.btnTinhLuong.TabIndex = 6;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnTao.Location = new System.Drawing.Point(176, 116);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(80, 30);
            this.btnTao.TabIndex = 5;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnXem.Location = new System.Drawing.Point(315, 48);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(80, 28);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(137, 82);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(258, 28);
            this.cmbMaNV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhân viên";
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
            this.cmbThang.Location = new System.Drawing.Point(137, 48);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(170, 28);
            this.cmbThang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.dgvThongTinNV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1213, 310);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnThem);
            this.groupBox5.Controls.Add(this.txtThemGioLam);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtDiemDanh);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(8, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 278);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chấm công";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnThem.Location = new System.Drawing.Point(44, 201);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtThemGioLam
            // 
            this.txtThemGioLam.Location = new System.Drawing.Point(31, 146);
            this.txtThemGioLam.Name = "txtThemGioLam";
            this.txtThemGioLam.Size = new System.Drawing.Size(127, 22);
            this.txtThemGioLam.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thêm giờ làm";
            // 
            // txtDiemDanh
            // 
            this.txtDiemDanh.Location = new System.Drawing.Point(31, 72);
            this.txtDiemDanh.Name = "txtDiemDanh";
            this.txtDiemDanh.Size = new System.Drawing.Size(127, 22);
            this.txtDiemDanh.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Điểm danh";
            // 
            // dgvThongTinNV
            // 
            this.dgvThongTinNV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThongTinNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codenv,
            this.namenv,
            this.month,
            this.snl,
            this.sgl,
            this.lcb,
            this.llt});
            this.dgvThongTinNV.Location = new System.Drawing.Point(183, 37);
            this.dgvThongTinNV.Name = "dgvThongTinNV";
            this.dgvThongTinNV.RowHeadersWidth = 51;
            this.dgvThongTinNV.RowTemplate.Height = 24;
            this.dgvThongTinNV.Size = new System.Drawing.Size(1026, 267);
            this.dgvThongTinNV.TabIndex = 1;
            this.dgvThongTinNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinNV_CellContentClick);
            // 
            // codenv
            // 
            this.codenv.DataPropertyName = "MaNV";
            this.codenv.HeaderText = "Mã nhân viên";
            this.codenv.MinimumWidth = 6;
            this.codenv.Name = "codenv";
            this.codenv.Width = 90;
            // 
            // namenv
            // 
            this.namenv.DataPropertyName = "TenNV";
            this.namenv.HeaderText = "Tên nhân viên";
            this.namenv.MinimumWidth = 6;
            this.namenv.Name = "namenv";
            this.namenv.Width = 180;
            // 
            // month
            // 
            this.month.DataPropertyName = "Thang";
            this.month.HeaderText = "Tháng";
            this.month.MinimumWidth = 6;
            this.month.Name = "month";
            this.month.Width = 55;
            // 
            // snl
            // 
            this.snl.DataPropertyName = "SoNgayLam";
            this.snl.HeaderText = "Số ngày làm";
            this.snl.MinimumWidth = 6;
            this.snl.Name = "snl";
            this.snl.Width = 90;
            // 
            // sgl
            // 
            this.sgl.DataPropertyName = "SoGioLam";
            this.sgl.HeaderText = "Số giờ làm";
            this.sgl.MinimumWidth = 6;
            this.sgl.Name = "sgl";
            this.sgl.Width = 90;
            // 
            // lcb
            // 
            this.lcb.DataPropertyName = "LuongCoBan";
            this.lcb.HeaderText = "Lương cơ bản";
            this.lcb.MinimumWidth = 6;
            this.lcb.Name = "lcb";
            this.lcb.Width = 105;
            // 
            // llt
            // 
            this.llt.DataPropertyName = "LuongLamThem";
            this.llt.HeaderText = "Lương làm thêm";
            this.llt.MinimumWidth = 6;
            this.llt.Name = "llt";
            this.llt.Width = 105;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvBangLuong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(477, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(736, 324);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng lương";
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MNV,
            this.TNV,
            this.T,
            this.TL});
            this.dgvBangLuong.Location = new System.Drawing.Point(6, 26);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.RowHeadersWidth = 51;
            this.dgvBangLuong.RowTemplate.Height = 24;
            this.dgvBangLuong.Size = new System.Drawing.Size(726, 292);
            this.dgvBangLuong.TabIndex = 0;
            // 
            // MNV
            // 
            this.MNV.DataPropertyName = "MaNV";
            this.MNV.HeaderText = "Mã nhân viên";
            this.MNV.MinimumWidth = 6;
            this.MNV.Name = "MNV";
            this.MNV.Width = 105;
            // 
            // TNV
            // 
            this.TNV.DataPropertyName = "TenNV";
            this.TNV.HeaderText = "Tên nhân viên";
            this.TNV.MinimumWidth = 6;
            this.TNV.Name = "TNV";
            this.TNV.Width = 190;
            // 
            // T
            // 
            this.T.DataPropertyName = "Thang";
            this.T.HeaderText = "Tháng";
            this.T.MinimumWidth = 6;
            this.T.Name = "T";
            this.T.Width = 70;
            // 
            // TL
            // 
            this.TL.DataPropertyName = "TongLuong";
            this.TL.HeaderText = "Tổng lương";
            this.TL.MinimumWidth = 6;
            this.TL.Name = "TL";
            this.TL.Width = 125;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.txtLuongLamThem);
            this.groupBox4.Controls.Add(this.txtLuongCoBan);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 157);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sửa lương cơ bản";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnSua.Location = new System.Drawing.Point(173, 105);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 33);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtLuongLamThem
            // 
            this.txtLuongLamThem.Location = new System.Drawing.Point(221, 72);
            this.txtLuongLamThem.Name = "txtLuongLamThem";
            this.txtLuongLamThem.Size = new System.Drawing.Size(171, 27);
            this.txtLuongLamThem.TabIndex = 3;
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Location = new System.Drawing.Point(221, 30);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(171, 27);
            this.txtLuongCoBan.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lương làm thêm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lương cơ bản";
            // 
            // Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Payroll";
            this.Size = new System.Drawing.Size(1238, 640);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtThemGioLam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiemDanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvThongTinNV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.MaskedTextBox txtLuongLamThem;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn TL;
        private System.Windows.Forms.DataGridViewTextBoxColumn codenv;
        private System.Windows.Forms.DataGridViewTextBoxColumn namenv;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn snl;
        private System.Windows.Forms.DataGridViewTextBoxColumn sgl;
        private System.Windows.Forms.DataGridViewTextBoxColumn lcb;
        private System.Windows.Forms.DataGridViewTextBoxColumn llt;
    }
}
