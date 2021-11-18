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
    public partial class Client : UserControl
    {
        Connect.connectDB db = new Connect.connectDB();

        string con_str = "Data Source=THANGPC;Initial Catalog = BOOK_MANAGEMENT; User ID = sa; Password=123456";
        public Client()
        {
            InitializeComponent();
            GetData();
        }

        void GetData()
        {
            try
            {
                string query = "Select * from KhachHang";
                DataSet ds = db.getData(query, "KhachHang", null);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvClient.DataSource = ds.Tables["KhachHang"];
                // ValueMember, DisplayMember
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void clearText()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtGioiTinh.Text = "";
            txtSDT.Text = "0";
            txtMaKH.Focus();
        }

        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtMaKH.Text = dgvClient.Rows[idx].Cells["MaNV"].Value.ToString();
                txtTenKH.Text = dgvClient.Rows[idx].Cells["TenNV"].Value.ToString();
                txtGioiTinh.Text = dgvClient.Rows[idx].Cells["GioiTinh"].Value.ToString();
                txtSDT.Text = dgvClient.Rows[idx].Cells["SDT"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from KhachHang where TenNV like '%' + @tk + '%'";
                string tk = txtTimKiem.Text;
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@tk", tk));
                // Bước 4: Đổ dữ liệu lên DataSet
                DataSet ds = db.getData(query, "KhachHang", data);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvClient.DataSource = ds.Tables["KhachHang"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "") return;
            try
            {
                // Thực thi truy vấn insert
                // Bước 1: Tạo kết nối
               

                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "insert into KhachHang (MaKH, TenKH, GioiTinh, SDT) VALUES (@MaKH, @TenKH, @GioiTinh, @SDT)";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                int MaKH = int.Parse(txtMaKH.Text);
                cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
                cmd.Parameters.Add(new SqlParameter("@TenKH", txtTenKH.Text));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", txtGioiTinh.Text));
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "") return;
            try
            {
                // Thực thi truy vấn insert
                // Bước 1: Tạo kết nối
         
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "Delete from KhachHang where MaKH = @MaKH";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaKH", txtMaKH.Text));

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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực thi truy vấn insert
                // Bước 1: Tạo kết nối
              

                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "UPDATE KhachHang SET MaKH = @MaKH, TenKH = @TenKH, GioiTinh = @GioiTinh, SDT = @SDT WHERE MaKH = @MaKH";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                int MaKH = int.Parse(txtMaKH.Text);
                cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));
                cmd.Parameters.Add(new SqlParameter("@TenKH", txtTenKH.Text));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", txtGioiTinh.Text));
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            GetData();
        }
    }
}
