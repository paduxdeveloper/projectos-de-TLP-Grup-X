using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace crono_tempor_alarme
{
    public partial class Form1 : Form
    {
        private Stopwatch st;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            btnparar.Visible = false;
            btnrepetir.Visible = false;
            btnretomar.Visible = false;
            btnrepor.Visible = false;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            st = new Stopwatch();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            this.label1.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", st.Elapsed);
            /* OU poderia ser tambem  
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", st.Elapsed);
            this refere ao atributo ou propriedade Text
            */


        }

        private void btncomecar_Click(object sender, EventArgs e)
        {
            st.Start();
            btncomecar.Visible = false;
            btnparar.Visible = true;
            btnrepetir.Visible = true;

        }

       

        private void btnparar_Click(object sender, EventArgs e)
        {
            st.Stop();
            btnparar.Visible = false;
            btnrepetir.Visible = false;
            btnretomar.Visible = true;
            btnrepor.Visible = true;





        }

        private void btnretomar_Click(object sender, EventArgs e)
        {
            st.Start();
            btnparar.Visible = true;
            btnrepetir.Visible = true;
        }

        private void btnrepor_Click(object sender, EventArgs e)
        {
            st.Reset();

            btnparar.Visible = false;
            btnrepetir.Visible = false;
            btnretomar.Visible = false;
            btnrepor.Visible = false;
            btncomecar.Visible = true;

        }

        private void btnrepetir_Click(object sender, EventArgs e)
        {
            st.Restart();

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
