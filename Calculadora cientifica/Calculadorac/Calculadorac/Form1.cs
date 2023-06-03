using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadorac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        // 
        //declarar as variaveis
        // 

        bool vaimudar = false, fechar = false;
            
        //
        //deixar responcivo
        //
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width < 800)
            {
                splitTela.Panel2Collapsed = true;
            }
            else
            {
                splitTela.Panel2Collapsed = false;
            }
        }
        //
        //Faz as contas 
        //
        private double Evaluate(string expression)
        {

            expression = expression.Replace(",", ".");
            expression = expression.Replace("÷", "/");
            expression = expression.Replace("×", "*");

            try
            {
                System.Data.DataTable table = new System.Data.DataTable();
                table.Columns.Add("expression", string.Empty.GetType(), expression);
                System.Data.DataRow row = table.NewRow();
                table.Rows.Add(row);
                return double.Parse((string)row["expression"]);

            }
            catch
            {
                return double.Parse("0");
            }



        }
        //
        //botões da calculadora principais
        //

        private void btnNum_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (lblresultado.Text == "0" || vaimudar )
            {
                lblresultado.Text = "";
                vaimudar = false;
            }
            lblresultado.Text += btn.Text;
        }

        private void btnOpe_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string aux = lblresultado.Text;
            lblresultado.Text = Evaluate(lblconta.Text + lblresultado.Text).ToString();
            if(fechar)
                lblconta.Text += " " + btn.Text + " ";
            else
                lblconta.Text += aux + " " + btn.Text + " ";
            vaimudar = true;
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {
            
        }
       

        private void button6_Click(object sender, EventArgs e)
        {
            lblresultado.Text = "0";
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            lblresultado.Text = "0";
            lblconta.Text = ""; 
        }

        private void btnapag_Click(object sender, EventArgs e)
        {
            if (lblresultado.Text !="") { 
            lblresultado.Text = lblresultado.Text.Substring(0, lblresultado.Text.Length - 1);
            }
            else {
                lblresultado.Text = "0";
            }
            
        }

        private void btnvirg_Click(object sender, EventArgs e)
        {
            if (!lblresultado.Text.Contains('.')){
                lblresultado.Text += ".";
            }
        }

        private void btnmaisoumenos_Click(object sender, EventArgs e)
        {
            lblresultado.Text = (double.Parse(lblresultado.Text) * -1).ToString();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            string conta = lblconta.Text + lblresultado.Text;
            double resultado = Evaluate(conta);
            lblresultado.Text = resultado.ToString();
            lblconta.Text = "";
            vaimudar = true;
        }
        //
        //botões da calculadora funções 1 linha
        //

        private void button2_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.Pow(double.Parse(lblresultado.Text), 2).ToString();
            vaimudar = true;
        } 

        private void btnsen_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.Sin(double.Parse(lblresultado.Text)).ToString();
            vaimudar = true;
        }

        private void btncosen_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.Cos(double.Parse(lblresultado.Text)).ToString();
            vaimudar = true;
        }

        private void btntangen_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.Tan(double.Parse(lblresultado.Text)).ToString();
            vaimudar = true;
        }

       
        //
        //botões da calculadora funções 2 linha
        //
        private void btnxelev3_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.Pow(double.Parse(lblresultado.Text), 3).ToString();
            vaimudar = true;
        }
        private void btnsen1_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.Asin(double.Parse(lblresultado.Text)).ToString();
            vaimudar = true;
        }

        private void btncos1_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.Acos(double.Parse(lblresultado.Text)).ToString();
            vaimudar = true;
        }

        private void btntang1_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.Atan(double.Parse(lblresultado.Text)).ToString();
            vaimudar = true;
        }


        //
        //botões da calculadora funções 3 linha
        //
        private void btnlogari_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.Log(double.Parse(lblresultado.Text)).ToString();
            vaimudar = true;
        }
        private void btnExp_Click(object sender, EventArgs e)
        {
            string resultado = lblresultado.Text;
            if (resultado.Contains(','))
            {
                lblresultado.Text = resultado + "e+";
            }
            else
                lblresultado.Text = resultado + ",e+";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            string aux = lblresultado.Text;
            lblresultado.Text = Evaluate(lblresultado.Text + lblconta.Text).ToString();
            lblconta.Text += aux + "Mod";
            vaimudar = true;
        }
        private void btneuler_Click_1(object sender, EventArgs e)
        {
            lblresultado.Text = Math.E.ToString();
            vaimudar = true;
        }

        //
        //botões da calculadora funções 4 linha
        //

        private void btnraiz_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.Sqrt(double.Parse(lblresultado.Text)).ToString();
            vaimudar = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.Pow(10,double.Parse(lblresultado.Text)).ToString();
            lblconta.Text = "10 ^";
            vaimudar = true;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            lblresultado.Text = (Math.Log(double.Parse(lblresultado.Text))/Math.Log(Math.E)).ToString();
            vaimudar = true;
        }

        private void btndms_Click(object sender, EventArgs e)
        {
            lblresultado.Text = (1/double.Parse(lblresultado.Text)).ToString();
            vaimudar = true;
        }

        //
        //botões da calculadora funções 4 linha
        //

        private void btnpi_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Math.PI.ToString();
            vaimudar = true;
        }

        private void btnfator_Click(object sender, EventArgs e)
        {
            double num = double.Parse(lblresultado.Text);
            double mult = 1;
            for (int i = 1; i <= num; i++)
            {

                mult = mult * i;
            }
            lblresultado.Text = mult.ToString();
            vaimudar = true;
        }

        private void btnabrirparen_Click(object sender, EventArgs e)
        {
            if (!lblconta.Text.Contains('('))
            {
                lblconta.Text += "(";
            }
            else
            {
                lblconta.Text = "";
            }
           
            vaimudar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnfecharparen_Click(object sender, EventArgs e)
        {
            string aux = lblresultado.Text;
            lblresultado.Text = Evaluate(lblresultado.Text + lblconta.Text).ToString();
            lblconta.Text += aux + ")";
            vaimudar = true;
            fechar = true;
        }
    }
}
