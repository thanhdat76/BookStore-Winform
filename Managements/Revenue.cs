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
    public partial class Revenue : UserControl
    {
        string con_str = "Data Source=DESKTOP-01B5JNH;Initial Catalog=BOOK_MANAGEMENT;Persist Security Info=True;User ID=sa; Password=123456;";
        Connect.connectDB db = new Connect.connectDB();

        public Revenue()
        {
            InitializeComponent();
            GetData();
        }

        void GetData()
        {
            try
            {
                string query = "Select * from DoanhThu";
                DataSet ds = db.getData(query, "DoanhThu", null);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvDoanhThu.DataSource = ds.Tables["DoanhThu"];
                // ValueMember, DisplayMember
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void XemDT()
        {
            if (cmbThang.Text == "") return;
            try
            {
                string thang = cmbThang.Text;
                int Thang = int.Parse(thang);
                List<Models.MRevenua> lst = new List<Models.MRevenua>();

                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string query = "Select * from ChiTietDoanhThu WHERE Thang = @Thang";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@Thang", Thang));
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Models.MRevenua obj = new Models.MRevenua(dr);
                    lst.Add(obj);
                }

                // Bước 4.1: Đọc dữ liệu, lưu vào List

                conn.Close();
                if (lst.Count < 1) 
                {
                    lbTLNV.Text = "";
                    lbTNS.Text = "";
                    lbDTCT.Text = "";
                    lbDTBS.Text = "";
                    lbLBS.Text = "";
                    return;
                }
                else
                {
                    lbTLNV.Text = lst[0].TraLuongNV;
                    lbTNS.Text = lst[0].NhapSach;
                    lbDTCT.Text = lst[0].ChoThueSach;
                    lbDTBS.Text = lst[0].DoanhSoBanSach;
                    lbLBS.Text = lst[0].LaiBanSach;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi here: " + ex.Message);
            }

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cmbThang.Text == "") return;

            try
            {
                XemDT();
                string query = "Select * from DoanhThu where Thang like '%' + @tk + '%'";
                string tk = cmbThang.Text;
                List<SqlParameter> data = new List<SqlParameter>();
                data.Add(new SqlParameter("@tk", tk));
                // Bước 4: Đổ dữ liệu lên DataSet
                DataSet ds = db.getData(query, "DoanhThu", data);
                // Hiển thị dữ liệu từ DataSet lên DataGridView
                dgvDoanhThu.DataSource = ds.Tables["DoanhThu"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (cmbThang.Text == "") return;
            try
            {
                string thang = cmbThang.Text;
                int Thang = int.Parse(thang);
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string query = "insert into DoanhThu (Thang) VALUES (@Thang)";
                string query2 = "insert into ChiTietDoanhThu (Thang) VALUES (@Thang)";


                SqlCommand cmd = new SqlCommand(query, conn);
                SqlCommand cmd2 = new SqlCommand(query2, conn);

                cmd.Parameters.Add(new SqlParameter("@Thang", Thang));
                cmd2.Parameters.Add(new SqlParameter("@Thang", Thang));


                // --> Chọn phương thức thực thi phù hợp
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                conn.Close();
                GetData();

                MessageBox.Show("Thêm mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTinhDoanhThu_Click(object sender, EventArgs e)
        {
            if (cmbThang.Text == "") return;
            try
            {
                string thang = cmbThang.Text;
                int Thang = int.Parse(thang);
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();

                string queryLuongNV = "SELECT SUM(TongLuong) FROM Luong WHERE Thang = @Thang";
                string queryTienNhapSach = "SELECT SUM(TienHang) FROM HoaDon WHERE MONTH(NgayLap) = @Thang";
                string queryTongTien = "SELECT SUM(TongTien) FROM HoaDon WHERE MONTH(NgayLap) = @Thang";
                string queryTongTienThue = "SELECT SUM(TongTien) FROM PhieuThue WHERE MONTH(NgayLap) = @Thang AND TrangThai = 'paid'";



                SqlCommand cmd = new SqlCommand(queryLuongNV, conn);
                SqlCommand cmd2 = new SqlCommand(queryTienNhapSach, conn);
                SqlCommand cmd3 = new SqlCommand(queryTongTien, conn);
                SqlCommand cmd4 = new SqlCommand(queryTongTienThue, conn);



                cmd.Parameters.Add(new SqlParameter("@Thang", Thang));
                cmd2.Parameters.Add(new SqlParameter("@Thang", Thang));
                cmd3.Parameters.Add(new SqlParameter("@Thang", Thang));
                cmd4.Parameters.Add(new SqlParameter("@Thang", Thang));




                // --> Chọn phương thức thực thi phù hợp
                string LuongNV = cmd.ExecuteScalar().ToString();
                string TienNhapSach = cmd2.ExecuteScalar().ToString();
                string TongTien = cmd3.ExecuteScalar().ToString();
                string TongTienThue = cmd4.ExecuteScalar().ToString();


                int TraLuongNV = 0;
                int NhapSach = 0;
                int DoanhSoBanSach = 0;
                int LaiBanSach = 0;
                int LaiThueSach = 0;

               


                if (LuongNV != null && LuongNV != "") { TraLuongNV = int.Parse(LuongNV); }
                if (TienNhapSach != null && TienNhapSach != "") { NhapSach = int.Parse(TienNhapSach); }
                if (TongTien != null && TongTien != "")
                {
                    DoanhSoBanSach = int.Parse(TongTien);
                    LaiBanSach = DoanhSoBanSach - NhapSach;
                }
                if (TongTienThue != null && TongTienThue != "") { LaiThueSach = int.Parse(TongTienThue); }

                int TongChi = TraLuongNV + NhapSach;
                int TongThu = LaiBanSach + LaiThueSach;
                int LoiNhuan = TongThu - TongChi;

                //Update bảng chi tiết doanh thu
                string query = "UPDATE ChiTietDoanhThu SET TraLuongNV = @TraLuongNV, NhapSach =  @NhapSach, DoanhSoBanSach = @DoanhSoBanSach, LaiBanSach = @LaiBanSach, ChoThueSach = @ChoThueSach WHERE Thang = @Thang";
                SqlCommand cmdUpdate = new SqlCommand(query, conn);
                cmdUpdate.Parameters.Add(new SqlParameter("@TraLuongNV", TraLuongNV));
                cmdUpdate.Parameters.Add(new SqlParameter("@NhapSach", NhapSach));
                cmdUpdate.Parameters.Add(new SqlParameter("@DoanhSoBanSach", DoanhSoBanSach));
                cmdUpdate.Parameters.Add(new SqlParameter("@LaiBanSach", LaiBanSach));
                cmdUpdate.Parameters.Add(new SqlParameter("@Thang", Thang));
                cmdUpdate.Parameters.Add(new SqlParameter("@ChoThueSach", LaiThueSach));


                cmdUpdate.ExecuteNonQuery();

                //Update bảng doanh thu
                string queryDT = "UPDATE DoanhThu SET TongChi = @TongChi, TongThu =  @TongThu, LoiNhuan = @LoiNhuan WHERE Thang = @Thang";
                SqlCommand cmdUpdateDT = new SqlCommand(queryDT, conn);
                cmdUpdateDT.Parameters.Add(new SqlParameter("@TongChi", TongChi));
                cmdUpdateDT.Parameters.Add(new SqlParameter("@TongThu", TongThu));
                cmdUpdateDT.Parameters.Add(new SqlParameter("@LoiNhuan", LoiNhuan));
                cmdUpdateDT.Parameters.Add(new SqlParameter("@Thang", Thang));

                cmdUpdateDT.ExecuteNonQuery();

                conn.Close();
                GetData();

                MessageBox.Show("Thêm mới thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
