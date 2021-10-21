using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagement.IOBill
{
    public partial class receiptManager : UserControl
    {
        public receiptManager()
        {
            InitializeComponent();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelReceipt.Controls)
            {
                ctrl.Dispose();
            }
            panelReceipt.Controls.Add(new Receipt());
        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelReceipt.Controls)
            {
                ctrl.Dispose();
            }
            panelReceipt.Controls.Add(new billList());
        }
    }
}
