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
    public partial class GiftManagement : UserControl
    {
        Connect.connectDB db = new Connect.connectDB();
        string con_str = "Data Source=THANGPC;Initial Catalog = BOOK_MANAGEMENT; User ID = sa; Password=123456";
        public GiftManagement()
        {
            InitializeComponent();
            pictureBox2.Image = Image.FromFile("C:\\Users\\Admin\\OneDrive\\Pictures\\Saved Pictures\\gifts.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random RanDom = new Random();
                int MaQTR = RanDom.Next(1, 6);
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string maQT = MaQTR.ToString();
                string query = "select TenQT from gift where MaQT = @maQT";
                string query2 = "select img from gift where MaQT = @maQT";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlCommand cmd1 = new SqlCommand(query2, conn);
                cmd1.Parameters.Add(new SqlParameter("@maQT", maQT));
                cmd.Parameters.Add(new SqlParameter("@maQT", maQT));
                string tenQT = cmd.ExecuteScalar().ToString();
                string img = cmd1.ExecuteScalar().ToString();
                conn.Close();          
                textBox1.Text = maQT;
                textBox2.Text = tenQT;
                pictureBox1.Image = Image.FromFile(img);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                label1.Text = "Chúc mừng bạn đã nhận được quà tặng là: "+ tenQT +". Cảm ơn và hẹn gặp lại !";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
