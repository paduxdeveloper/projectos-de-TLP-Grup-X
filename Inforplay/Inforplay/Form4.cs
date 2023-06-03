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
    public partial class Form4 : Form
    {
        string[] perg = new string[7];
        string[] r = new string[7];
        string[,] opc = new string[7, 4];

        int q1 = 0, q2 = 16, i = 0, m = 0;
        int x = 1, a = 0, b = 0, c = 0, d = 0;
        int pontos = 0;
        int altura_label = 20;
        int[] sorteados = new int[7];
        public Form4()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
            labelpontos.Text = pontos.ToString();
            progressBar1.Value = 0;

            perg[0] = "Qual é a estrutura básica de um computador?";
            perg[1] = "A que se refere o CPU? ";
            perg[2] = "Indique as memórias primárias? ";
            perg[3] = "Qual é a diferença entre as memórias RAM e ROM? ";
            perg[4] = "Qual é a função da memória CACHE?";
            perg[5] = "Onde se encontra a placa mãe de um computador";
            perg[6] ="Quais são os tipos de Modem?";
            


            r[0] = "CPU, Memórias e periféricos de input_output";
            r[1] = "Ao processador";
            r[2] = "PROM, Flash, DRAM";
            r[3] = "ROM só lê,RAM guarda dados temporários";
            r[4] = "Auxiliar a RAM e o Processador";
            r[5] = "No gabinete";
            r[6] = "Internos e externos";

            opc[0, 0] = "CPU, Memórias e periféricos de input_output";
            opc[0, 1] = "Teclado, CPU, Mouse";
            opc[0, 2] = "Hardware e Software";
            opc[0, 3] = "Monitor, Teclado e o Gabinete";

            opc[1, 0] = "Ao Gabinete";
            opc[1, 1] = "Ao Dispostivo de input_output";
            opc[1, 2] = "A transmissão dos dados";
            opc[1, 3] = "Ao processador";

            opc[2, 0] = "HD, Pendrive, DVD";
            opc[2, 1] = "DVD, CD, Disquete";
            opc[2, 2] = "PROM, Flash, DRAM";
            opc[2, 3] = "SuperFlash, RAMN, GRAM";

            opc[3, 0] = "RAM recebe e ROM só armazena os dados";
            opc[3, 1] = "ROM só lê,RAM guarda dados temporários";
            opc[3, 2] = "ROM é um Hardware,RAM é um Software";
            opc[3, 3] = "ROM só lê, RAM só escreve";

            opc[4, 0] = "Armazenar os ficheiros do computador";
            opc[4, 1] = "Auxiliar a RAM e o Processador";
            opc[4, 2] = "Servir de Modelo a RAM";
            opc[4, 3] = "Guardar os dados não usados";

            opc[5, 0] = "Na Unidade de controlo";
            opc[5, 1] = "No CPU";
            opc[5, 2] = "No gabinete";
            opc[5, 3] = "No dispositivo principal";

            opc[6, 0] = "Universais e específicos";
            opc[6, 1] = "Internos e externos";
            opc[6, 2] = "Universais e Locais";
            opc[6, 3] = "Electrónicos e Mecânicos";

        }
        private void btnsair_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            MessageBox.Show("Sair do jogo!!");
            var f1 = new Form1_2();
            f1.Show();
            this.Hide();
        }

       
        private void btnajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sem ajuda Disponível!!"); MessageBox.Show("Sem ajuda Disponível!!");
        }

        private void btnpular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Indisponível!!\nEm desenvolvimento...");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            c = 1;
            btnD.Enabled = false;
            btnB.Enabled = false;
            btnA.Enabled = false;
            timer2.Enabled = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            b = 1;
            btnD.Enabled = false;
            btnA.Enabled = false;
            btnC.Enabled = false;
            timer2.Enabled = false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            a = 1;
            btnD.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            timer2.Enabled = false;
        }
        

        private void btnD_Click(object sender, EventArgs e)
        {
            d = 1;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            timer2.Enabled = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (q2 >= 0)
            {
                labeltime.Text = q2.ToString();
                q2--;
            }

            if (q2 == 0)
            {
                timer2.Enabled = false;
                MessageBox.Show("Upps, Perdeu muito tempo!!");
                var f1 = new Form1_2();
                f1.Show();
                this.Hide();
            }
        }
        Random rd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = true;

            labelperg.Text = perg[i];
            btnA.Text = opc[i, 0];
            btnB.Text = opc[i, 1];
            btnC.Text = opc[i, 2];
            btnD.Text = opc[i, 3];
            labeln.Text = x.ToString();


            if (a == 1)
            {
                timer2.Enabled = false;
                q1++;
                if (q1 == 2)
                {
                    if (btnA.Text == r[i])
                    {
                        btnA.BackColor = Color.Green;

                    }
                    else
                    {
                        btnA.BackColor = Color.Red;
                        timer1.Enabled = false;
                        MessageBox.Show("Upps, não é não!!");
                        var f1 = new Form1_2();
                        f1.Show();
                        this.Hide();
                    }
                }
            }
            else if (b == 1)
            {
                timer2.Enabled = false;
                q1++;
                if (q1 == 2)
                {
                    if (btnB.Text == r[i])
                    {

                        btnB.BackColor = Color.Green;
                    }
                    else
                    {
                        btnB.BackColor = Color.Red;
                        timer1.Enabled = false;
                        MessageBox.Show("Upps, não é não!!");
                        var f1 = new Form1_2();
                        f1.Show();
                        this.Hide();
                    }
                }
            }
            else if (c == 1)
            {
                timer2.Enabled = false;
                q1++;
                if (q1 == 2)
                {
                    if (btnC.Text == r[i])
                    {
                        btnC.BackColor = Color.Green;
                    }
                    else
                    {
                        btnC.BackColor = Color.Red;
                        timer1.Enabled = false;
                        MessageBox.Show("Upps, não é não!!");
                        var f1 = new Form1_2();
                        f1.Show();
                        this.Hide();
                    }
                }
            }
            else if (d == 1)
            {
                timer2.Enabled = false;
                q1++;
                if (q1 == 2)
                {
                    if (btnD.Text == r[i])
                    {
                        btnD.BackColor = Color.Green;
                    }
                    else
                    {
                        btnD.BackColor = Color.Red;
                        timer1.Enabled = false;
                        MessageBox.Show("Upps, não é não!!");
                        var f1 = new Form1_2();
                        f1.Show();
                        this.Hide();
                    }
                }
            }
            if (q1 == 3)
            {
                progressBar1.Value += 14;
                x++;
                timer2.Enabled = true;
                q1 = 0;
                a = 0; b = 0; c = 0; d = 0;
                q2 = 16;
                btnC.Enabled = true;
                btnB.Enabled = true;
                btnA.Enabled = true;
                btnD.Enabled = true;
                labelperg.Text = "";
                btnA.Text = "";
                btnB.Text = "";
                btnC.Text = "";
                btnD.Text = "";
                labeln.Text = "";

                btnD.BackColor = labeltime.BackColor;
                btnC.BackColor = labeltime.BackColor;
                btnB.BackColor = labeltime.BackColor;
                btnA.BackColor = labeltime.BackColor;
                pontos += 3;
                labelpontos.Text = pontos.ToString();
                altura_label += 60;


                Inicio:
                i = rd.Next(0, 7);
                for (int p = 0; p < 6; p++)
                {
                    if (sorteados[p] == i)
                    {
                        goto Inicio;
                    }
                }
                sorteados[m] = i;
                m++;

                if (x == 8)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    labelperg.Text = "";
                    btnA.Text = "";
                    btnB.Text = "";
                    btnC.Text = "";
                    btnD.Text = "";
                    labeln.Text = "";

                    MessageBox.Show("Parabéns pelos 21 pontos \nEscolha um outro tópico!!");
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    var f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                
            }
        }




    }
}
