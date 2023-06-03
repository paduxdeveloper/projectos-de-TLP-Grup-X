using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora001
{
    public partial class Form1 : Form
    {
        double n1 = 0;
        double n2 = 0;
        double r = 0;
        string oper = "";
        long tb1 = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            label1.Text = "";
            textBox2.Text = "";
            btnigual.Enabled = true;
        }

        private void btndel_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && label1.Text != "")
                btndel.Enabled = false;

            //fazer com q se tiver um texto no textBox1 e na label1 apague primeiro  na label

            if (label1.Text != "")
            {
                label1.Text = "";
            }
            if (textBox1.Text != "" )
            { 
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

            if (textBox1.Text == "")
            {
                n1 = 0;
            }
            if (textBox2.Text == "")
            {
                n2 = 0;
            }



        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            //repetir este codigo nas outras operacoes e em igual
            if(textBox1.Text!="" & textBox2.Text != "")
            {
                btnigual.Enabled = true;
                textBox1.Text = textBox2.Text;
                textBox2.Text = "";
                label1.Text = "+";
            }
            if (textBox1.Text!="")
            {
                n1 = double.Parse(textBox1.Text);
                oper = "+";
                label1.Text = oper;
                textBox1.Text = "";
            }
        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                btnigual.Enabled = true;
                textBox1.Text = textBox2.Text;
                textBox2.Text = "";
                label1.Text = "-";
            }
                if (textBox1.Text!="")
            {
                n1 = double.Parse(textBox1.Text);
                oper = "-";
                label1.Text = oper;
                textBox1.Text = "";
            }
        }

        private void btnproduto_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                btnigual.Enabled = true;
                textBox1.Text = textBox2.Text;
                textBox2.Text = "";
                label1.Text = "x";
            }
                if (textBox1.Text!="")
            {
                n1 = double.Parse(textBox1.Text);
                oper = "x";
                label1.Text = oper;
                textBox1.Text = "";
            }
        }

        private void btndivisao_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                btnigual.Enabled = true;
                textBox1.Text = textBox2.Text;
                textBox2.Text = "";
                label1.Text = ":";
            }
                if (textBox1.Text!="")
            {
                n1 = double.Parse(textBox1.Text);
                oper = ":";
                label1.Text = oper;
                textBox1.Text = "";
            }
        }

        private void btnponto_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text += ",";
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            //codigo para dizer q n1 = n1
            if (textBox1.Text != "" && textBox2.Text == "" && label1.Text=="")
            {
                
                n1 = 0;
                oper = "";
                label1.Text = oper;
                r = double.Parse(textBox1.Text);

            }
           
            if (textBox1.Text!="" && textBox2.Text!="" && label1.Text != "")
            {
                btnigual.Enabled = false;
            }
            if (textBox1.Text != "" && textBox2.Text == "")
            {
                
                n2 = double.Parse(textBox1.Text);
                if (oper == "+")
                {
                    r = n1 + n2;
                }
                else if (oper == "-")
                {
                    r = n1 - n2;
                }
                else if (oper == "x")
                {
                    r = n1 * n2;
                }
                else if (oper == ":")
                {
                    r = n1 / n2;
                }
                

            }

            btnigual.Enabled = false;

            if (oper != "")
            {
                textBox1.Text = Convert.ToString(n1) + "" + oper + Convert.ToString(n2);
                label1.Text = "=";
                textBox2.Text = Convert.ToString(r);

                comboBox1.Items.Add(n1 + oper + n2 + "=" + r);
            }
            else
            {
                textBox1.Text = Convert.ToString(n2);
                label1.Text = "=";
                textBox2.Text = Convert.ToString(r);

                comboBox1.Items.Add(n2 + "=" + r);

            }
            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
