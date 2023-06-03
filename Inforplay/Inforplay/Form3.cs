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
    public partial class Form3 : Form
    {
        string[] perg = new string[7];
        string[] r = new string[7];
        string[,] opc = new string[7, 4];

        int q1 = 0, q2 = 16, i = 0,m=0;
        int x = 1 ,a = 0, b = 0, c = 0, d = 0;
        int pontos=0;
        int altura_label = 20;
        int[] sorteados = new int[7];
        
        public Form3()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
            labelpontos.Text = pontos.ToString();
            progressBar1.Value = 0;

            perg[0] = "O que significa \"Informática\"?";
            perg[1] = "Qual é o suporte básico da \"Informática\"? ";
            perg[2] = "Quando e quem criou a palavra\"Informática\"? ";
            perg[3] = "A Informática assenta sobre as seguintes áreas: ";
            perg[4] = "Indique a afirmação falsa:";
            perg[5] = "Quem é considerado o pai do Computador?";         
            perg[6] = "O que caracterizou a segunda geração do computador?";
            

            r[0] = "Informação Automática";
            r[1] = "O Computador";
            r[2] = "1962, por Philippe Dreifus";
            r[3] = "Hardware, Software e Firmware";
            r[4] = "Firmwares: programas feitos em firmas";
            r[5] = "Charles Babbage";
            r[6] = "Os transistores"; 

            opc[0, 0]= "Informação Digital";
            opc[0, 1]= "Informação Automática";
            opc[0, 2] = "Hardware e Software";
            opc[0, 3] = "Análise de computador";

            opc[1, 0] = "O Computador";            
            opc[1, 1] = "O Hardware e o Software";
            opc[1, 2] = "Os Sistemas Informáticos";
            opc[1, 3] = "A Informação";

            opc[2,0] = "1960, pela Informatic Association";
            opc[2,1 ]= "1952, por Philippe Dreifus ";
            opc[2,2] = "1976, pela Bell Laboratories";
            opc[2,3] = "1962, por Philippe Dreifus";

            opc[3,0] = "Hardware e Software";
            opc[3,1] = "Programação, Redes e Design ";
            opc[3,2] = "Informação e automatização";
            opc[3,3] = "Hardware, Software e Firmware";

            opc[4,0] = "Hardware: parte física do computador";
            opc[4,1] = "Firmwares: programas feitos em firmas";
            opc[4,2] = "Software: parte lógica do computador";
            opc[4,3] = "Telefone: é um computador";

            opc[5, 0] = "Albert Einsten";
            opc[5, 1] = "Blase Pascal";
            opc[5, 2] = "Charles Babbage";
            opc[5, 3] = "John Bardeen";

            opc[6, 0] = "Os transistores";
            opc[6, 1] = "As válvulas";
            opc[6, 2] = "Os microprocessadores";
            opc[6, 3] = "Os circuitos Integrados";


        }

        private void btnajuda_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Sem ajuda Disponível!!");
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

        private void btnpular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Indisponível!!\nEm desenvolvimento...");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            b = 1;
            btnA.Enabled= false;
            btnC.Enabled = false;
            btnD.Enabled = false;


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

        

        private void btnC_Click(object sender, EventArgs e)
        {
            c = 1;
            btnD.Enabled = false;
            btnB.Enabled = false;
            btnA.Enabled = false;
            timer2.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            d = 1;
            btnC.Enabled = false;
            btnB.Enabled = false;
            btnA.Enabled = false;
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

            /*for(int y=0; y <= 6; y++)
            {
                if (y == 0)
                {
                   
                    aleat = rd.Next(0, 6);
                    sorteados[y] = aleat;
                }
                else
                {
                    aleat = rd.Next(0, 6);
                    for (int p = 0; p < 6; i++)
                    {
                        if (aleat == sorteados[p])
                        {
                            aleat = rd.Next(0, 6);
                        }
                        else
                        {
                            i = aleat;
                        }
                    }
                }
            }*/

            /*if (i == 0)
            {
                i = rd.Next(0, 6);
                sorteados[0] = i;
            }*/


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
