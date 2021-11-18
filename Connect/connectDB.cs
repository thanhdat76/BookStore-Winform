using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagement.Connect
{
    class connectDB
    {
        string con_str = "Data Source=THANGPC;Initial Catalog = BOOK_MANAGEMENT; User ID = sa; Password=123456";
        SqlConnection conn = null;

        public connectDB()
        {
            conn = new SqlConnection(con_str);
        }

        public DataSet getData(string query, string table_name, List<SqlParameter> _params)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                if (_params != null)
                    da.SelectCommand.Parameters.AddRange(_params.ToArray());
                da.Fill(ds, table_name);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi ở đây:" + ex.Message);
            }
            return ds;
        }

        public void execute(string query, List<SqlParameter> _params)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (_params != null)
                    cmd.Parameters.AddRange(_params.ToArray());
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
