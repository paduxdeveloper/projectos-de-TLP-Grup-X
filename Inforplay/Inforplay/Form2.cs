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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            var f1 = new Form1_2();
            f1.Show();
            this.Hide();
        }

        private void btnhard_Click(object sender, EventArgs e)
        {
            var f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void btninfor_Click_1(object sender, EventArgs e)
        {
            var f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void btnsoft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tópico não Disponível!!\nEm desenvolvimento...");
        }

        private void btnprog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tópico não Disponível!!\nEm desenvolvimento...");
        }

        private void btnrede_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tópico não Disponível!!\nEm desenvolvimento...");
        }
    }
}
