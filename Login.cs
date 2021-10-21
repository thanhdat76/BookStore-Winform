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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Khởi tạo kết nối
                string con_str = "Data Source=DESKTOP-V2HKTR2\\SQLEXPRESS; Initial Catalog=BOOK_MANAGEMENT; User ID=sa; Password=1;";
                SqlConnection conn = new SqlConnection(con_str);
                // Bước 2: Mở kết nối
                conn.Open();
                //MessageBox.Show("Kết nối thành công!");
                // Bước 3: Tạo truy vấn
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string query = "select Count(*) from TaiKhoan where TenTK = @tk and MatKhau = @mk";
                // Bước 4: Thực thi truy vấn
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", tk));
                cmd.Parameters.Add(new SqlParameter("@mk", mk));
                int SoLuong = (int)cmd.ExecuteScalar();
                // Bước 5: Đóng kết nối
                conn.Close();
                // Kiểm tra dữ liệu trả về
                if (SoLuong == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    this.DialogResult = DialogResult.OK;
                    //this.Close();
                    Home home1 = new Home();
                    this.Hide();
                    home1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}
