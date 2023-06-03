using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Inforplay
{
    public partial class Form1 : Form
    {
        int q = 0;
        public Form1()
        {      
            InitializeComponent();
            timer1.Enabled = true;
            progressBar1.Value = 0;
           
            
            /*for (int i = 0; i <= progressBar1.Maximum; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(100);
            }*/


        }
       
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= progressBar1.Maximum)
            {
                progressBar1.Value += 10;
                
            }
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                progressBar1.Visible= false;
                labelload.Visible = false;             
                
                var f2 = new Form1_2();
                f2.Show();
                this.Hide();

            }

        }
    }
}
