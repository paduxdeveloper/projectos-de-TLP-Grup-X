using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inforplay
{
    public partial class Form1_2 : Form
    {
        public Form1_2()
        {
            InitializeComponent();
        }

        private void btnjogar_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jogo de perguntas na área da Informática\nAcumularás pontos a medida que respondes consoante ao tempo, as perguntas propostas");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_2_Load(object sender, EventArgs e)
        {

        }
    }
}
