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
    public partial class employeeManager : UserControl
    {
        public employeeManager()
        {
            InitializeComponent();
            panelStaff.Controls.Add(new Staff());
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelStaff.Controls)
            {
                ctrl.Dispose();
            }
            panelStaff.Controls.Add(new Staff());
        }

        private void tínhLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelStaff.Controls)
            {
                ctrl.Dispose();
            }
            panelStaff.Controls.Add(new Payroll());
        }
    }
}
