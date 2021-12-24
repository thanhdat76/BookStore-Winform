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

namespace BookStoreManagement
{
    public partial class Staff : UserControl
    {

        Connect.connectDB db = new Connect.connectDB();

        public Staff()
        {
            InitializeComponent();
            GetData();
        }

        void GetData()
        {
            try
            {
                string query = "Select * from NhanVien";
                DataSet ds = db.getData(query, "NhanVien", null);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvStaff.DataSource = ds.Tables["NhanVien"];
                // ValueMember, DisplayMember
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void clearText()
        {
            /*btnThem.Enabled = true;
            txtMaSP.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;*/

            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "0";
            txtSDT.Text = "0";

            txtMaNV.Focus();
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                /*btnThem.Enabled = false;
                txtMaSP.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;*/

                txtMaNV.Text = dgvStaff.Rows[idx].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgvStaff.Rows[idx].Cells["TenNV"].Value.ToString();
                txtGioiTinh.Text = dgvStaff.Rows[idx].Cells["GioiTinh"].Value.ToString();
                //txtMaLoaiSP.Text = dgvSanPham.Rows[idx].Cells["MaLoaiSP"].Value.ToString();
                //cmbDiaChi.SelectedValue = dgvStaff.Rows[idx].Cells["MaLoaiSP"].Value.ToString();
                txtDiaChi.Text = dgvStaff.Rows[idx].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgvStaff.Rows[idx].Cells["SDT"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "") return;
            try
            {
                // Thực thi truy vấn insert
                // Bước 1: Tạo kết nối
                string con_str = "Data Source=DESKTOP-01B5JNH;Initial Catalog=BOOK_MANAGEMENT;Persist Security Info=True;User ID=sa; Password=123456;";
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "Delete from NhanVien where MaNV = @MaNV";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNV", txtMaNV.Text));

                // --> Chọn phương thức thực thi phù hợp
                cmd.ExecuteNonQuery();
                // Bước 5: Đóng kết nối
                conn.Close();

                // Load lại dữ liệu lên GridView
                clearText();
                GetData();

                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            GetData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "") return;
            try
            {
                // Thực thi truy vấn insert
                // Bước 1: Tạo kết nối
                string con_str = "Data Source=DESKTOP-01B5JNH;Initial Catalog=BOOK_MANAGEMENT;Persist Security Info=True;User ID=sa; Password=123456;";

                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "insert into NhanVien (MaNV, TenNV, GioiTinh, DiaChi, SDT) VALUES (@MaNV, @TenNV, @GioiTinh, @DiaChi, @SDT)";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                int MaNV = int.Parse(txtMaNV.Text);
                cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
                cmd.Parameters.Add(new SqlParameter("@TenNV", txtTenNV.Text));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", txtGioiTinh.Text));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", txtSDT.Text));

                // --> Chọn phương thức thực thi phù hợp
                cmd.ExecuteNonQuery();
                // Bước 5: Đóng kết nối
                conn.Close();

                // Load lại dữ liệu lên GridView
                clearText();
                GetData();

                MessageBox.Show("Thêm mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực thi truy vấn insert
                // Bước 1: Tạo kết nối
                string con_str = "Data Source=DESKTOP-01B5JNH;Initial Catalog=BOOK_MANAGEMENT;Persist Security Info=True;User ID=sa; Password=123456;";

                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "UPDATE NhanVien SET MaNV = @MaNV, TenNV = @TenNV, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SDT WHERE MaNV = @MaNV";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                int MaNV = int.Parse(txtMaNV.Text);
                cmd.Parameters.Add(new SqlParameter("@MaNV", MaNV));
                cmd.Parameters.Add(new SqlParameter("@TenNV", txtTenNV.Text));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", txtGioiTinh.Text));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", txtSDT.Text));

                // --> Chọn phương thức thực thi phù hợp
                cmd.ExecuteNonQuery();
                // Bước 5: Đóng kết nối
                conn.Close();

                // Load lại dữ liệu lên GridView
                clearText();
                GetData();

                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from NhanVien where TenNV like '%' + @tk + '%'";
                string tk = txtTimKiem.Text;
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@tk", tk));
                // Bước 4: Đổ dữ liệu lên DataSet
                DataSet ds = db.getData(query, "NhanVien", data);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvStaff.DataSource = ds.Tables["NhanVien"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
