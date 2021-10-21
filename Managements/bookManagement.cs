using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagement.Managements
{
    public partial class bookManagement : UserControl
    {
        public bookManagement()
        {
            InitializeComponent();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnBookManagement.Controls)
            {
                ctrl.Dispose();
            }
            pnBookManagement.Controls.Add(new bookStore());
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnBookManagement.Controls)
            {
                ctrl.Dispose();
            }
            pnBookManagement.Controls.Add(new IOBill.enterCoupon());
        }

        private void danhSáchPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnBookManagement.Controls)
            {
                ctrl.Dispose();
            }
            pnBookManagement.Controls.Add(new IOBill.entryTicketList());
        }
    }
}
