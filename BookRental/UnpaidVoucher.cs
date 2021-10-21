using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagement.BookRental
{
    public partial class UnpaidVoucher : UserControl
    {

        Connect.connectDB db = new Connect.connectDB();
        string con_str = "Data Source=DESKTOP-V2HKTR2\\SQLEXPRESS; Initial Catalog=BOOK_MANAGEMENT; User ID=sa; Password=1;";

        public UnpaidVoucher()
        {
            InitializeComponent();
            GetData();
        }

        void GetData()
        {
            try
            {
                //string query1 = "Select MaPT, MaNV, MaKH, NgayLap, NgayTra, TrangThai, TongTien from PhieuNhap";
                string query1 = "Select * from PhieuThue WHERE TrangThai = 'unpaid'";

                DataSet ds1 = db.getData(query1, "PhieuThue", null);

                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvDanhSachPT.DataSource = ds1.Tables["PhieuThue"];
                // ValueMember, DisplayMember
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvDanhSachPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                //Chuyển từ ngày trong sql sang string và chuyển sang kiểu datetime
                string NT = dgvDanhSachPT.Rows[idx].Cells["NgayTra"].Value.ToString();
                DateTime myNT = DateTime.Parse(NT);

                //Lấy ngày hiện tại
                DateTime myDateTime = DateTime.Now;

                //Trừ ngày chênh lệch
                TimeSpan interval = myDateTime - myNT;

                if (interval.Days > 1)
                    lbTreHan.Text = interval.Days.ToString();
                else
                    lbTreHan.Text = 0.ToString();

                txtMaPT.Text = dgvDanhSachPT.Rows[idx].Cells["MaPT"].Value.ToString();
                string MaPT = dgvDanhSachPT.Rows[idx].Cells["MaPT"].Value.ToString();
                try
                {
                    string query = "Select * from ChiTietPhieuThue WHERE MaPT = @MaPT";
                    List<SqlParameter> data = new List<SqlParameter>();
                    data.Add(new SqlParameter("@MaPT", MaPT));
                    DataSet ds = db.getData(query, "ChiTietPhieuThue", data);

                    // Hiển thị dữ liệu từ DataSet lên DataGridView
                    dgvCTPT.DataSource = ds.Tables["ChiTietPhieuThue"];
                    // ValueMember, DisplayMember
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtMaPT.Text == "") return;
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string MaPT = txtMaPT.Text;
                string query = "Select Sum(ChiTietPhieuThue.SoLuong * GiaBan) from Sach, ChiTietPhieuThue WHERE ChiTietPhieuThue.MaSach = Sach.MaSach AND MaPT = @MaPT";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaPT", MaPT));
                int TongTien = (int)cmd.ExecuteScalar();
                TongTien = (TongTien / 100) * 10;

                int SNQuaHan = int.Parse(lbTreHan.Text);
                TongTien *= SNQuaHan;
                // Bước 5: Đóng kết nối
                conn.Close();
                txtThuThem.Text = TongTien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaPT.Text == "") return;
            try
            {
                int TongTien = int.Parse(txtThuThem.Text);
                int MaPT = int.Parse(txtMaPT.Text);
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@MaPT", MaPT));
                data.Add(new SqlParameter("@TongTien", TongTien));


                string query = "UPDATE PhieuThue Set TongTien = TongTien + @TongTien, TrangThai = 'paid' WHERE MaPT = @MaPT";
                db.execute(query, data);
                MessageBox.Show("Xác nhận thành công!");
                GetData();
                txtThuThem.Text = "";
                txtMaPT.Text = "";
                lbTreHan.Text = 0.ToString();
                dgvCTPT.DataSource = "your DataSource";
                dgvCTPT.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
