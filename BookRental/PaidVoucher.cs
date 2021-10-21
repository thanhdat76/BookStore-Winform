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
    public partial class PaidVoucher : UserControl
    {
        Connect.connectDB db = new Connect.connectDB();
        string con_str = "Data Source=DESKTOP-V2HKTR2\\SQLEXPRESS; Initial Catalog=BOOK_MANAGEMENT; User ID=sa; Password=1;";


        public PaidVoucher()
        {
            InitializeComponent();
            GetData();
        }

        void GetData()
        {
            try
            {
                //string query1 = "Select MaPT, MaNV, MaKH, NgayLap, NgayTra, TrangThai, TongTien from PhieuNhap";
                string query1 = "Select * from PhieuThue WHERE TrangThai = 'paid'";

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
    }
}
