using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace browserapp
{
    public partial class Form1 : Form
    {
        string home = null;
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void navegar()
        {

            if (textBox1.Text != "")
            {
                webBrowser1.Navigate(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Digite uma URL: ");
                textBox1.Focus();
            }
        }

        private void btn_ir_Click(object sender, EventArgs e)
        {
            navegar();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                navegar();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                webBrowser1.GoHome();

            }
            else
            {
                webBrowser1.Navigate(home);
            }
           
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        private void btn_anterior_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward ();
        }

        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            btn_anterior.Enabled = webBrowser1.CanGoBack;
        }

        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            btn_proximo.Enabled = webBrowser1.CanGoForward;
        }
        private void btn_parar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void btn_definirhome_Click(object sender, EventArgs e)
        {
            home = textBox1.Text;
        }

        private void label_limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
