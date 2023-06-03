using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblclaro.Visible = false;
            lblescuro.Visible = false;
        }
       //
       //Metodo para enviar mensagem
       //
        private void enviarmensagem(string num,string mens)
        {

            try
            {
                if (num == "")
                {
                    MessageBox.Show("Digite o número de destino.");
                    txtdest.Focus();
                }
                else if (mens == "")
                {
                    MessageBox.Show("Digite a mensagem que deseja enviar.");
                    txtmens.Focus();
                }
                if (num.Length == 9)
                {
                    num = "+244" + num;
                    num = num.Replace(" ", "");
                    System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + num + "&text=" + mens);
                }



            }
            catch (Exception excepto)
            {

            }
        }

        //
        //botão de envio de mensagem
        //

        private void button1_Click(object sender, EventArgs e)
        {
            enviarmensagem(txtdest.Text, txtmens.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Show();
            f1.BackColor = Color.DodgerBlue;
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            var f1 = new Form1();
            f1.Show();
            f1.BackColor = Color.Blue;
            this.Hide();
        }

        private void lblfundo_Click(object sender, EventArgs e)
        {
            lblclaro.Visible = true;
            lblescuro.Visible = true;
            lblfundo.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
