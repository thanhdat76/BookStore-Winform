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
    public partial class Distributor : UserControl
    {

        string con_str = "Data Source=DESKTOP-V2HKTR2\\SQLEXPRESS; Initial Catalog=BOOK_MANAGEMENT; User ID=sa; Password=1;";
        Connect.connectDB db = new Connect.connectDB();
        public Distributor()
        {
            InitializeComponent();
            GetData();
        }

        void GetData()
        {
            try
            {
                string query = "Select * from NhaPP";
                DataSet ds = db.getData(query, "NhaPP", null);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvDistributor.DataSource = ds.Tables["NhaPP"];
                // ValueMember, DisplayMember
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void clearText()
        {
            txtMaNPP.Text = "";
            txtTenNPP.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "0";
            txtMaNPP.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            GetData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNPP.Text == "") return;
            try
            {
                // Bước 1: 
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "insert into NhaPP (MaNPP, TenNPP, DiaChi, SDT) VALUES (@MaNPP, @TenNPP, @DiaChi, @SDT)";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                int MaNPP = int.Parse(txtMaNPP.Text);
                cmd.Parameters.Add(new SqlParameter("@MaNPP", MaNPP));
                cmd.Parameters.Add(new SqlParameter("@TenNPP", txtTenNPP.Text));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", txtDiaChi.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", txtSDT.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
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
            if (txtMaNPP.Text == "") return;
            try
            {
                // Bước 1: Tạo kết nốis
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                // Bước 3: Tạo truy vấn
                string query = "Delete from NhaPP where MaNPP = @MaNPP";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@MaNPP", txtMaNPP.Text));

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
                string query = "UPDATE NhaPP SET MaNPP = @MaNPP, TenNPP = @TenNPP, DiaChi = @DiaChi, SDT = @SDT WHERE MaNPP = @MaNPP";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                int MaNPP = int.Parse(txtMaNPP.Text);
                cmd.Parameters.Add(new SqlParameter("@MaNPP", MaNPP));
                cmd.Parameters.Add(new SqlParameter("@TenNPP", txtTenNPP.Text));
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from NhaPP where TenNPP like '%' + @tk + '%'";
                string tk = txtTimKiem.Text;
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@tk", tk));
                // Bước 4: Đổ dữ liệu lên DataSet
                DataSet ds = db.getData(query, "NhaPP", data);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvDistributor.DataSource = ds.Tables["NhaPP"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvDistributor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txtMaNPP.Text = dgvDistributor.Rows[idx].Cells["MaNPP"].Value.ToString();
                txtTenNPP.Text = dgvDistributor.Rows[idx].Cells["TenNPP"].Value.ToString();
                txtDiaChi.Text = dgvDistributor.Rows[idx].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgvDistributor.Rows[idx].Cells["SDT"].Value.ToString();
            }
        }
    }
}
