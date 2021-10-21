using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagement.BookRental
{
    public partial class bookRentalManagement : UserControl
    {
        public bookRentalManagement()
        {
            InitializeComponent();
        }

        private void tsmPhieuTS_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnShowBookRental.Controls)
            {
                ctrl.Dispose();
            }
            pnShowBookRental.Controls.Add(new BBookRental());
        }

        private void tsmDSUnpaid_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnShowBookRental.Controls)
            {
                ctrl.Dispose();
            }
            pnShowBookRental.Controls.Add(new UnpaidVoucher());
        }

        private void tsmPaid_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnShowBookRental.Controls)
            {
                ctrl.Dispose();
            }
            pnShowBookRental.Controls.Add(new PaidVoucher());
        }
    }
}
