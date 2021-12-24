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
    public partial class Music : UserControl
    {
        public Music()
        {
            InitializeComponent();
        }
        string[] files, paths;

        private void txt_chose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txt_chose.Text = openFileDialog1.FileName;
            }
        }

        private void txt_start_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = txt_chose.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void txt_stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void txt_choseplaylist_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;


            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog1.SafeFileNames;
                paths = openFileDialog1.FileNames;
                for(int i =0; i<files.Length; i++)
                {
                    List.Items.Add(files[i]);
                }
            }
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[List.SelectedIndex];

        }

        private void txt_pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
