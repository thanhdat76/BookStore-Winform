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

namespace BookStoreManagement.Managements
{
    public partial class Payroll : UserControl
    {
        Connect.connectDB db = new Connect.connectDB();
        string con_str = "Data Source=DESKTOP-01B5JNH;Initial Catalog=BOOK_MANAGEMENT;Persist Security Info=True;User ID=sa; Password=123456;";
        int MaNV;

        public Payroll()
        {
            InitializeComponent();
            GetDataCMBS();
        }

        void GetDataTT()
        {
            try
            {
                string Thang = cmbThang.Text;
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@Thang", Thang));
                string query = "SELECT Luong.MaNV, NhanVien.TenNV, Thang, SoNgayLam, SoGioLam, LuongCoBan, LuongLamThem FROM Luong, NhanVien WHERE NhanVien.MaNV = Luong.MaNV AND LUONG.Thang = @Thang";
                DataSet ds = db.getData(query, "Luong", data);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvThongTinNV.DataSource = ds.Tables["Luong"];
                // ValueMember, DisplayMember
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        void GetDataBangLuong()
        {
            try
            {
                string Thang = cmbThang.Text;
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@Thang", Thang));
                string query = "SELECT Luong.MaNV, NhanVien.TenNV, Thang, TongLuong FROM Luong, NhanVien WHERE NhanVien.MaNV = Luong.MaNV AND LUONG.Thang = @Thang";
                DataSet ds = db.getData(query, "Luong", data);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvBangLuong.DataSource = ds.Tables["Luong"];
                // ValueMember, DisplayMember
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

        void ClearText()
        {
            txtLuongCoBan.Text = "";
            txtLuongLamThem.Text = "";
            txtDiemDanh.Text = "";
            txtThemGioLam.Text = "";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            GetDataTT();
            GetDataBangLuong();
            ClearText();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {

            try { 
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string query = "Insert Into Luong (MaNV, Thang) VALUES (@MaNV, @Thang)";
                // Bước 4: Thực thi truy vấn
                string thang = cmbThang.Text;
                int Thang = int.Parse(thang);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNV", cmbMaNV.SelectedValue));
                cmd.Parameters.Add(new SqlParameter("@Thang", Thang));

                // --> Chọn phương thức thực thi phù hợp
                cmd.ExecuteNonQuery();
                // Bước 5: Đóng kết nối
                conn.Close();

                // Load lại dữ liệu lên GridView
                GetDataTT();
                GetDataBangLuong();

                MessageBox.Show("Thêm mới thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvThongTinNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                string manv = dgvThongTinNV.Rows[idx].Cells["codenv"].Value.ToString();
                MaNV = int.Parse(manv);
                txtLuongCoBan.Text = dgvThongTinNV.Rows[idx].Cells["lcb"].Value.ToString();
                txtLuongLamThem.Text = dgvThongTinNV.Rows[idx].Cells["llt"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "UPDATE Luong SET LuongCoBan = @LuongCoBan, LuongLamThem = @LuongLamThem WHERE MaNV = @MaNV";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
                cmd.Parameters.Add(new SqlParameter("@LuongCoBan", txtLuongCoBan.Text));
                cmd.Parameters.Add(new SqlParameter("@LuongLamThem", txtLuongLamThem.Text));

                // --> Chọn phương thức thực thi phù hợp
                cmd.ExecuteNonQuery();
                // Bước 5: Đóng kết nối
                conn.Close();
                GetDataTT();
                // Load lại dữ liệu lên GridView

                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "UPDATE Luong SET SoNgayLam = SoNgayLam + @SoNgayLam, SoGioLam = SoGioLam + @SoGioLam WHERE MaNV = @MaNV";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
                cmd.Parameters.Add(new SqlParameter("@SoNgayLam", txtDiemDanh.Text));
                cmd.Parameters.Add(new SqlParameter("@SoGioLam", txtThemGioLam.Text));

                // --> Chọn phương thức thực thi phù hợp
                cmd.ExecuteNonQuery();
                // Bước 5: Đóng kết nối
                conn.Close();
                GetDataTT();
                // Load lại dữ liệu lên GridView

                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "UPDATE Luong SET TongLuong = (LuongCoBan * SoNgayLam) + (LuongLamThem * SoGioLam) WHERE Thang = @Thang";
                // Bước 4: Thực thi truy vấn
                string thang = cmbThang.Text;
                int Thang = int.Parse(thang);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@Thang", Thang));

                // --> Chọn phương thức thực thi phù hợp
                cmd.ExecuteNonQuery();
                // Bước 5: Đóng kết nối
                conn.Close();
                GetDataBangLuong();
                // Load lại dữ liệu lên GridView

                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
