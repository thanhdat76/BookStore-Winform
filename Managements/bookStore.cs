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
    public partial class bookStore : UserControl
    {
        Connect.connectDB db = new Connect.connectDB();
        string con_str = "Data Source=DESKTOP-V2HKTR2\\SQLEXPRESS; Initial Catalog=BOOK_MANAGEMENT; User ID=sa; Password=1;";

        public bookStore()
        {
            InitializeComponent();
            GetData();
        }

        void GetData()
        {
            try
            {
                string query = "Select * from Sach";
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



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from Sach where TheLoai like '%' + @TheLoai + '%' OR TenSach like '%' + @TenSach + '%'";
                string TimKiem = txtTimKiem.Text;
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@TheLoai", TimKiem));
                data.Add(new SqlParameter("@TenSach", TimKiem));

                // Bước 4: Đổ dữ liệu lên DataSet
                DataSet ds = db.getData(query, "Sach", data);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvSach.DataSource = ds.Tables["Sach"];
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
                txtMaSach.Text = dgvSach.Rows[idx].Cells["MS"].Value.ToString();
                txtTenSach.Text = dgvSach.Rows[idx].Cells["TS"].Value.ToString();
                txtTheLoai.Text = dgvSach.Rows[idx].Cells["TL"].Value.ToString();
                txtTacGia.Text = dgvSach.Rows[idx].Cells["TG"].Value.ToString();
                txtGiaNhap.Text = dgvSach.Rows[idx].Cells["GN"].Value.ToString();
                txtGiaBan.Text = dgvSach.Rows[idx].Cells["GB"].Value.ToString();
                txtSoLuong.Text = dgvSach.Rows[idx].Cells["SL"].Value.ToString();
            }
        }

        private void txtThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "") return;
            try
            {
                // Thực thi truy vấn insert
                // Bước 1: Tạo kết nối
               
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "insert into Sach (MaSach, TenSach, TheLoai, TacGia, GiaNhap, GiaBan, SoLuong) VALUES (@MaSach, @TenSach, @TheLoai, @TacGia, @GiaNhap, @GiaBan, @SoLuong)";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                int MaSach = int.Parse(txtMaSach.Text);
                int GiaNhap = int.Parse(txtGiaNhap.Text);
                int GiaBan = int.Parse(txtGiaBan.Text);
                int SoLuong = int.Parse(txtSoLuong.Text);

                cmd.Parameters.Add(new SqlParameter("@MaSach", MaSach));
                cmd.Parameters.Add(new SqlParameter("@TenSach", txtTenSach.Text));
                cmd.Parameters.Add(new SqlParameter("@TheLoai", txtTheLoai.Text));
                cmd.Parameters.Add(new SqlParameter("@TacGia", txtTacGia.Text));
                cmd.Parameters.Add(new SqlParameter("@GiaNhap", GiaNhap));
                cmd.Parameters.Add(new SqlParameter("@GiaBan", GiaBan));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));

                // --> Chọn phương thức thực thi phù hợp
                cmd.ExecuteNonQuery();
                // Bước 5: Đóng kết nối
                conn.Close();

                // Load lại dữ liệu lên GridView
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
            if (txtMaSach.Text == "") return;
            try
            {
                // Thực thi truy vấn insert
                // Bước 1: Tạo kết nối
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "Delete from Sach where MaSach = @MaSach";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaSach", txtMaSach.Text));

                // --> Chọn phương thức thực thi phù hợp
                cmd.ExecuteNonQuery();
                // Bước 5: Đóng kết nối
                conn.Close();

                // Load lại dữ liệu lên GridView
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
                string query = "UPDATE Sach SET MaSach = @MaSach, TenSach = @TenSach, TheLoai = @TheLoai, TacGia = @TacGia, GiaBan = @GiaBan, GiaNhap = @GiaNhap, SoLuong = @SoLuong WHERE MaSach = @MaSach";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                int MaSach = int.Parse(txtMaSach.Text);
                int GiaNhap = int.Parse(txtGiaNhap.Text);
                int GiaBan = int.Parse(txtGiaBan.Text);
                int SoLuong = int.Parse(txtSoLuong.Text);

                cmd.Parameters.Add(new SqlParameter("@MaSach", MaSach));
                cmd.Parameters.Add(new SqlParameter("@TenSach", txtTenSach.Text));
                cmd.Parameters.Add(new SqlParameter("@TheLoai", txtTheLoai.Text));
                cmd.Parameters.Add(new SqlParameter("@TacGia", txtTacGia.Text));
                cmd.Parameters.Add(new SqlParameter("@GiaNhap", GiaNhap));
                cmd.Parameters.Add(new SqlParameter("@GiaBan", GiaBan));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", SoLuong));

                // --> Chọn phương thức thực thi phù hợp
                cmd.ExecuteNonQuery();
                // Bước 5: Đóng kết nối
                conn.Close();

                // Load lại dữ liệu lên GridView
                GetData();

                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
