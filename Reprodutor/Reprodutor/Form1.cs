using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reprodutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog sms = new OpenFileDialog();

            if (sms.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = sms.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.Ctlcontrols.next();
            }
        }

      
    }
}
