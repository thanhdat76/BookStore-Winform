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
using BookStoreManagement.Models;

namespace BookStoreManagement.IOBill
{
    public partial class Receipt : UserControl
    {
        Connect.connectDB db = new Connect.connectDB();
        string con_str = "Data Source=DESKTOP-01B5JNH;Initial Catalog=BOOK_MANAGEMENT;Persist Security Info=True;User ID=sa; Password=123456;";
        public Receipt()
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

        void GetDataCart()
        {
            if (txtMaHD.Text == "") return;
            try
            {
                string MaHD = txtMaHD.Text;
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@MaHD", MaHD));
                string query = "Select * from ChiTietHD WHERE MaHD = @MaHD";
                DataSet ds = db.getData(query, "ChiTietHD", data);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvGioHang.DataSource = ds.Tables["ChiTietHD"];
                // ValueMember, DisplayMember
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ở đâu: " + ex.Message);
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            try
            {
                Random RanDom = new Random();
                int MaHDR = RanDom.Next(10000, 99999);
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string maHD = MaHDR.ToString();
                string query = "select Count(*) from HoaDon where MaHD = @maHD";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@maHD", maHD));
                int SoLuong = (int)cmd.ExecuteScalar();
                conn.Close();
                if (SoLuong == 1)
                {
                    btnTao_Click(sender, e);
                }
                else
                {
                    txtMaHD.Text = maHD;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "") return;
            try
            {
                // Thực thi truy vấn insert
                // Bước 1: Tạo kết nối

                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "insert into HoaDon (MaHD, MaNV, MaKH, NgayLap) VALUES (@MaHD, @MaNV, @MaKH, @NgayLap)";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                int MaHD = int.Parse(txtMaHD.Text);
                string NgayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add(new SqlParameter("@MaHD", MaHD));
                cmd.Parameters.Add(new SqlParameter("@MaNV", cmbMaNV.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@MaKH", cmbMaKH.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@NgayLap", NgayLap));

                // --> Chọn phương thức thực thi phù hợp
                cmd.ExecuteNonQuery();
                // Bước 5: Đóng kết nối
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
            if (txtMaHD.Text == "") return;
            try
            {
                // Thực thi truy vấn insert
                // Bước 1: Tạo kết nối
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "insert into ChiTietHD (MaHD, MaSach, TenSach, SoLuong) VALUES (@MaHD, @MaSach, @TenSach, @SoLuong)";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                int MaHD = int.Parse(txtMaHD.Text);
                string NgayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add(new SqlParameter("@MaHD", MaHD));
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

        private void label7_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "") return;
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string MaHD = txtMaHD.Text;
                string query = "Select Sum(ChiTietHD.SoLuong * GiaBan) from Sach, ChiTietHD WHERE ChiTietHD.MaSach = Sach.MaSach AND MaHD = @MaHD";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaHD", MaHD));
                int TongTien = (int)cmd.ExecuteScalar();
                // Bước 5: Đóng kết nối
                conn.Close();
                txtTongTien.Text = TongTien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //Tính tiền hàng của mỗi hóa đơn
        int CommodityMoney()
        {
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string MaHD = txtMaHD.Text;
                string query = "Select Sum(ChiTietHD.SoLuong * GiaNhap) from Sach, ChiTietHD WHERE ChiTietHD.MaSach = Sach.MaSach AND MaHD = @MaHD";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaHD", MaHD));
                int TienHang = (int)cmd.ExecuteScalar();
                // Bước 5: Đóng kết nối
                conn.Close();
                return TienHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return 0;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "") return;
            try
            {
                int TienHang = CommodityMoney();
                int TongTien = int.Parse(txtTongTien.Text);
                int MaHD = int.Parse(txtMaHD.Text);
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@MaHD", MaHD));
                data.Add(new SqlParameter("@TongTien", TongTien));
                data.Add(new SqlParameter("@TienHang", TienHang));


                string query = "UPDATE HoaDon Set TongTien = @TongTien, TienHang = @TienHang WHERE MaHD = @MaHD";
                db.execute(query, data);
                MessageBox.Show("Thêm mới thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "") return;
            try
            {
                int MaHD = int.Parse(txtMaHD.Text);
                List<SqlParameter> data1 = new List<SqlParameter>();
                data1.Add(new SqlParameter("@MaHD", MaHD));
                List<SqlParameter> data2 = new List<SqlParameter>();
                data2.Add(new SqlParameter("@MaHD", MaHD));

                string query1 = "DELETE ChiTietHD WHERE MaHD = @MaHD";
                string query2 = "DELETE HoaDon WHERE MaHD = @MaHD";

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
