using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Diagnostics;

namespace Despertador001
{
    
   
    public partial class Form_alarme : Form
    {
        private Stopwatch st = new Stopwatch();
        int h, m, s;
        string hora, minuto, segundo;
        int q = 0;

        public Form_alarme()
        {
            InitializeComponent();
            labelh.Visible = false;
            labelm.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;

            label_nomealarme.Visible = false;
            labelsom.Visible = false;
            textBox_nomealarme.Visible = false;
            comboBox_som.Visible = false;
            btn_cancelar.Visible = false;
            btn_guardar.Visible = false;
            label_guardado.Visible = false;
            listBox1.Visible = false;
            pictureBox1.Visible = false;
            btn_fechar.Visible = false;
            btn_adiar.Visible = false;
            labelnome_al.Visible = false;
            comboBox_som.Items.Add("Alarm01");
            comboBox_som.Items.Add("Alarm02");
            comboBox_som.Items.Add("Alarm03");
            comboBox_som.Items.Add("Alarm04");

        } 


        SoundPlayer player = new SoundPlayer();
        private void timer1_Tick(object sender, EventArgs e)
        {
            //codigo para mostrar a hora na tela
            h = DateTime.Now.Hour;
            m = DateTime.Now.Minute;
            s = DateTime.Now.Second;
            labelhora.Text = h.ToString();
            //ou labelhora.Text =Convert.ToString(h);
            labelmin.Text = m.ToString();
            labelseg.Text = s.ToString();

            //codigo para tocar o alarme 
            if (hora == h.ToString() && minuto == m.ToString() && s.ToString()=="0")
            {
                pictureBox1.Visible = true;
                if (comboBox_som.Text != "") { 
                player.SoundLocation = @"C:\Windows\Media\" + comboBox_som.Text+".wav";
                }
                else
                {
                    player.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                }


                player.PlayLooping();
                btn_fechar.Visible = true;
                btn_adiar.Visible = true;
                btn_criaralarme.Visible = false;
                label_guardado.Visible = false;
                btn_cancelar.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                listBox1.Visible = false;
                labelnome_al.Visible = true;

            }           
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
              
            q++;
            if (q == 60)
            {              
                if (comboBox_som.Text != "")
                {
                    player.SoundLocation = @"C:\Windows\Media\" + comboBox_som.Text + ".wav";
                }
                else
                {
                    player.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                }
                player.PlayLooping();
            }
        }
    
        private void btn_adiar_Click(object sender, EventArgs e)
        {
            q = 0;
            player.Stop();
            timer2.Enabled = true;
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            player.Stop();
            labelh.Visible = false;
            labelm.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;

            label_nomealarme.Visible = false;
            labelsom.Visible = false;
            textBox_nomealarme.Visible = false;
            comboBox_som.Visible = false;
            btn_cancelar.Visible = false;
            btn_guardar.Visible = false;
            btn_criaralarme.Visible = true;
            label_guardado.Visible = true;
            listBox1.Visible = true;
            pictureBox1.Visible = false;
            btn_adiar.Visible = false;
            btn_fechar.Visible = false;
            labelnome_al.Visible = false;

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void btn_criaralarme_Click(object sender, EventArgs e)
        {

           
            btn_criaralarme.Visible = false;
            labelh.Visible = true;
            labelm.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            
            label_nomealarme.Visible = true;
            labelsom.Visible = true;
            textBox_nomealarme.Visible = true;
            comboBox_som.Visible = true;
            btn_cancelar.Visible = true;
            btn_guardar.Visible = true;
            label_guardado.Visible = false;
            listBox1.Visible = false;
            pictureBox1.Visible = false;

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            labelh.Visible = false;
            labelm.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
           
            label_nomealarme.Visible = false;
            labelsom.Visible = false;
            textBox_nomealarme.Visible = false;
            comboBox_som.Visible = false;
            btn_cancelar.Visible = false;
            btn_guardar.Visible = false;
            btn_criaralarme.Visible = true;
            label_guardado.Visible = true;
            listBox1.Visible = true;
            pictureBox1.Visible = false;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
                hora = comboBox1.Text;
                minuto = comboBox2.Text;
                
            
            if (hora != "" & minuto != "") {
                MessageBox.Show("Alarme marcado para as "+""+hora+"h e "+""+minuto+"min");
                labelh.Visible = false;
                labelm.Visible = false;
                comboBox1.Visible = false;
                comboBox2.Visible = false;
               
                label_nomealarme.Visible = false;
                labelsom.Visible = false;
                textBox_nomealarme.Visible = false;
                comboBox_som.Visible = false;
                btn_cancelar.Visible = false;
                btn_guardar.Visible = false;
                btn_criaralarme.Visible = true;
                label_guardado.Visible = true;
                listBox1.Visible = true;
                pictureBox1.Visible = false;
               
                listBox1.Items.Add("" + hora + "h e " + "" + minuto + "min");

                if (textBox_nomealarme.Text != "")
                {
                    labelnome_al.Text = textBox_nomealarme.Text;
                }
            }


        }
    }
}
