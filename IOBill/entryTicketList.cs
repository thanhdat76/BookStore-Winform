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
    public partial class entryTicketList : UserControl
    {
        Connect.connectDB db = new Connect.connectDB();
        string con_str = "Data Source=DESKTOP-01B5JNH;Initial Catalog=BOOK_MANAGEMENT;Persist Security Info=True;User ID=sa; Password=123456;";

        public entryTicketList()
        {
            InitializeComponent();
            GetData();
        }

        void GetData()
        {
            try
            {
                string query1 = "Select * from PhieuNhap";

                DataSet ds1 = db.getData(query1, "PhieuNhap", null);

                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvDSPN.DataSource = ds1.Tables["PhieuNhap"];
                // ValueMember, DisplayMember
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvDSPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                string MaPN = dgvDSPN.Rows[idx].Cells["MaPN"].Value.ToString();
                try
                {
                    string query = "Select * from ChiTietPhieuNhap WHERE MaPN = @MaPN ";
                    List<SqlParameter> data = new List<SqlParameter>();
                    data.Add(new SqlParameter("@MaPN", MaPN));
                    DataSet ds = db.getData(query, "ChiTietPhieuNhap", data);

                    // Hiển thị dữ liệu từ DataSet lên DataGridView
                    dgvCTPN.DataSource = ds.Tables["ChiTietPhieuNhap"];
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
