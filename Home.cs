using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreManagement.Managements;
using BookStoreManagement.IOBill;
using BookStoreManagement.BookRental;



namespace BookStoreManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }



        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelShow.Controls)
            {
                ctrl.Dispose();
            }

            panelShow.Controls.Add(new employeeManager());
        }

        private void btnDoiTac_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelShow.Controls)
            {
                ctrl.Dispose();
            }
            panelShow.Controls.Add(new partnerManagement());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelShow.Controls)
            {
                ctrl.Dispose();
            }
            panelShow.Controls.Add(new receiptManager());
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelShow.Controls)
            {
                ctrl.Dispose();
            }
            panelShow.Controls.Add(new bookManagement());
        }

        private void btnThueSach_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelShow.Controls)
            {
                ctrl.Dispose();
            }
            panelShow.Controls.Add(new bookRentalManagement());
        }

        private void btnDoanhSo_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelShow.Controls)
            {
                ctrl.Dispose();
            }
            panelShow.Controls.Add(new Revenue());
        }
    }
}
