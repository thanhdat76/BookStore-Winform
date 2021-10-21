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
    public partial class partnerManagement : UserControl
    {
        public partnerManagement()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnPartner.Controls)
            {
                ctrl.Dispose();
            }
            pnPartner.Controls.Add(new Client());
        }

        private void nhàPhânPhốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnPartner.Controls)
            {
                ctrl.Dispose();
            }
            pnPartner.Controls.Add(new Distributor());
        }
    }
}
