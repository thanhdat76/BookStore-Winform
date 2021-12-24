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

namespace BookStoreManagement.IOBill
{
    public partial class billList : UserControl
    {
        Connect.connectDB db = new Connect.connectDB();
        string con_str = "Data Source=DESKTOP-01B5JNH;Initial Catalog=BOOK_MANAGEMENT;Persist Security Info=True;User ID=sa; Password=123456;";

        public billList()
        {
            InitializeComponent();
            GetData();
        }

        void GetData()
        {
            try
            {
                string query1 = "Select MaHD, MaNV, MaKH, NgayLap, TongTien from HoaDon";

                DataSet ds1 = db.getData(query1, "HoaDon", null);

                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvDanhSachHD.DataSource = ds1.Tables["HoaDon"];
                // ValueMember, DisplayMember
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvDanhSachHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                string MaHD = dgvDanhSachHD.Rows[idx].Cells["MaHD"].Value.ToString();
                try
                {
                    string query = "Select * from ChiTietHD WHERE MaHD = @MaHD ";
                    List<SqlParameter> data = new List<SqlParameter>();
                    data.Add(new SqlParameter("@MaHD", MaHD));
                    DataSet ds = db.getData(query, "ChiTietHD", data);

                    // Hiển thị dữ liệu từ DataSet lên DataGridView
                    dgvCTHD.DataSource = ds.Tables["ChiTietHD"];
                    // ValueMember, DisplayMember
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
