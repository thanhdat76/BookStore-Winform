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
using System.Threading;

namespace BookStoreManagement.BookRental
{
    public partial class BBookRental : UserControl
    {
        Connect.connectDB db = new Connect.connectDB();
        string con_str = "Data Source=DESKTOP-01B5JNH;Initial Catalog=BOOK_MANAGEMENT;Persist Security Info=True;User ID=sa; Password=123456;";

        public BBookRental()
        {
            InitializeComponent();
            GetData();
            GetDataCMBS();
            GetDataCMBM();
        }

        public void GetDataCMBM()
        {
            try
            {
                List<Models.MClient> lstM = new List<Models.MClient>();
                // Lấy dữ liệu Sản Phẩm từ Database về Lưu vào List
                // Bước 1: Khởi tạo kết nối
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string queryM = "Select * from KhachHang";
                // Bước 4: Thực thi truy vấn\
                SqlCommand cmdM = new SqlCommand(queryM, conn);
                SqlDataReader drM = cmdM.ExecuteReader();

                // Bước 4.1: Đọc dữ liệu, lưu vào List

                while (drM.Read())
                {
                    Models.MClient obj = new Models.MClient(drM);
                    lstM.Add(obj);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                // Hiển thị dữ liệu của Lst lên ComboBox
                cmbMaKH.DataSource = lstM;

                // Dữ liệu hiển thị trên ComboBox (DisplayMember), và giá trị tương ứng với dữ liệu đó (ValueMember)
                cmbMaKH.DisplayMember = "TenKH";
                cmbMaKH.ValueMember = "MaKH";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void GetDataCMBS()
        {
            try
            {
                List<Models.Staff> lstS = new List<Models.Staff>();
                // Lấy dữ liệu Sản Phẩm từ Database về Lưu vào List
                // Bước 1: Khởi tạo kết nối
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string queryS = "Select * from NhanVien";
                // Bước 4: Thực thi truy vấn\
                SqlCommand cmdS = new SqlCommand(queryS, conn);
                SqlDataReader drS = cmdS.ExecuteReader();

                // Bước 4.1: Đọc dữ liệu, lưu vào List
                while (drS.Read())
                {
                    Models.Staff obj = new Models.Staff(drS);
                    lstS.Add(obj);
                }
                // Bước 5: Đóng kết nối
                conn.Close();
                // Hiển thị dữ liệu của Lst lên ComboBox
                cmbMaNV.DataSource = lstS;

                // Dữ liệu hiển thị trên ComboBox (DisplayMember), và giá trị tương ứng với dữ liệu đó (ValueMember)
                cmbMaNV.DisplayMember = "TenNV";
                cmbMaNV.ValueMember = "MaNV";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        void GetDataCart()
        {
            if (txtMaPT.Text == "") return;
            try
            {
                string MaPT = txtMaPT.Text;
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@MaPT", MaPT));
                string query = "Select * from ChiTietPhieuThue WHERE MaPT = @MaPT";
                DataSet ds = db.getData(query, "ChiTietPhieuThue", data);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvGioHang.DataSource = ds.Tables["ChiTietPhieuThue"];
                // ValueMember, DisplayMember
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ở đâu: " + ex.Message);
            }
        }

        void GetData()
        {
            try
            {
                string query = "Select MaSach, TenSach, TheLoai, TacGia, GiaBan from Sach";
                DataSet ds = db.getData(query, "Sach", null);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvSach.DataSource = ds.Tables["Sach"];
                // ValueMember, DisplayMember
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                Random RanDom = new Random();
                int MaPTR = RanDom.Next(10000, 99999);
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string maPT = MaPTR.ToString();
                string query = "select Count(*) from PhieuThue where MaPT = @maPT";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@maPT", MaPTR));
                int SoLuong = (int)cmd.ExecuteScalar();
                conn.Close();
                if (SoLuong == 1)
                {
                    btnTao_Click(sender, e);
                }
                else
                {
                    txtMaPT.Text = maPT;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            if (txtMaPT.Text == "") return;
            try
            {
                SqlConnection conn = new SqlConnection(con_str);

                conn.Open();

                string query = "insert into PhieuThue (MaPT, MaNV, MaKH, NgayLap, NgayTra) VALUES (@MaPT, @MaNV, @MaKH, @NgayLap, @NgayTra)";

                SqlCommand cmd = new SqlCommand(query, conn);
                int MaPT = int.Parse(txtMaPT.Text);
                string NgayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd");
                string NgayTra = dtpNgayTra.Value.ToString("yyyy-MM-dd");

                cmd.Parameters.Add(new SqlParameter("@MaPT", MaPT));
                cmd.Parameters.Add(new SqlParameter("@MaNV", cmbMaNV.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@MaKH", cmbMaKH.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@NgayLap", NgayLap));
                cmd.Parameters.Add(new SqlParameter("@NgayTra", NgayTra));


                cmd.ExecuteNonQuery();

                conn.Close();


                MessageBox.Show("Thêm mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtMaSach.Text = dgvSach.Rows[idx].Cells["MaSach"].Value.ToString();
                txtTenSach.Text = dgvSach.Rows[idx].Cells["TenSach"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPT.Text == "") return;
            try
            {
                // Thực thi truy vấn insert
                // Bước 1: Tạo kết nối
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "insert into ChiTietPhieuThue (MaPT, MaSach, TenSach, SoLuong) VALUES (@MaPT, @MaSach, @TenSach, @SoLuong)";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                int MaPT = int.Parse(txtMaPT.Text);
                cmd.Parameters.Add(new SqlParameter("@MaPT", MaPT));
                cmd.Parameters.Add(new SqlParameter("@MaSach", txtMaSach.Text));
                cmd.Parameters.Add(new SqlParameter("@TenSach", txtTenSach.Text));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", txtSoLuong.Text));

                // --> Chọn phương thức thực thi phù hợp
                cmd.ExecuteNonQuery();
                // Bước 5: Đóng kết nối
                conn.Close();

                // Load lại dữ liệu lên GridView
                GetDataCart();

                MessageBox.Show("Thêm mới thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void lbTamTinh_Click(object sender, EventArgs e)
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

                DateTime NL = dtpNgayLap.Value;
                DateTime NT = dtpNgayTra.Value;

                TimeSpan interval = NT - NL;

                TongTien = TongTien * interval.Days;
                // Bước 5: Đóng kết nối
                conn.Close();
                txtTongTien.Text = TongTien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMaPT.Text == "") return;
            try
            {
                int TongTien = int.Parse(txtTongTien.Text);
                int MaPT = int.Parse(txtMaPT.Text);
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@MaPT", MaPT));
                data.Add(new SqlParameter("@TongTien", TongTien));


                string query = "UPDATE PhieuThue Set TongTien = @TongTien WHERE MaPT = @MaPT";
                db.execute(query, data);
                MessageBox.Show("Xác nhận thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuyPT_Click(object sender, EventArgs e)
        {
            if (txtMaPT.Text == "") return;
            try
            {
                int MaPT = int.Parse(txtMaPT.Text);
                List<SqlParameter> data1 = new List<SqlParameter>();
                data1.Add(new SqlParameter("@MaPT", MaPT));
                List<SqlParameter> data2 = new List<SqlParameter>();
                data2.Add(new SqlParameter("@MaPT", MaPT));

                string query1 = "DELETE ChiTietPhieuThue WHERE MaPT = @MaPT";
                string query2 = "DELETE PhieuThue WHERE MaPT = @MaPT";

                db.execute(query1, data1);
                db.execute(query2, data2);
                MessageBox.Show("Hủy thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
