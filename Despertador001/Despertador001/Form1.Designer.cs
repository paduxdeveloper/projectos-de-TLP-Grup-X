namespace Despertador001
{
    partial class Form_alarme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_alarme));
            this.data = new System.Windows.Forms.DateTimePicker();
            this.btn_criaralarme = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelhora = new System.Windows.Forms.Label();
            this.labelseg = new System.Windows.Forms.Label();
            this.labelmin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelh = new System.Windows.Forms.Label();
            this.labelm = new System.Windows.Forms.Label();
            this.label_nomealarme = new System.Windows.Forms.Label();
            this.textBox_nomealarme = new System.Windows.Forms.TextBox();
            this.labelsom = new System.Windows.Forms.Label();
            this.comboBox_som = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label_guardado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelnome_al = new System.Windows.Forms.Label();
            this.btn_adiar = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Dock = System.Windows.Forms.DockStyle.Top;
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(391, 20);
            this.data.TabIndex = 0;
            // 
            // btn_criaralarme
            // 
            this.btn_criaralarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criaralarme.Location = new System.Drawing.Point(107, 301);
            this.btn_criaralarme.Name = "btn_criaralarme";
            this.btn_criaralarme.Size = new System.Drawing.Size(165, 53);
            this.btn_criaralarme.TabIndex = 1;
            this.btn_criaralarme.Text = "Criar Alarme";
            this.btn_criaralarme.UseVisualStyleBackColor = true;
            this.btn_criaralarme.Click += new System.EventHandler(this.btn_criaralarme_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(116, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // labelhora
            // 
            this.labelhora.AutoSize = true;
            this.labelhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhora.Location = new System.Drawing.Point(270, 26);
            this.labelhora.Name = "labelhora";
            this.labelhora.Size = new System.Drawing.Size(22, 16);
            this.labelhora.TabIndex = 4;
            this.labelhora.Text = "00";
            // 
            // labelseg
            // 
            this.labelseg.AutoSize = true;
            this.labelseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelseg.Location = new System.Drawing.Point(356, 27);
            this.labelseg.Name = "labelseg";
            this.labelseg.Size = new System.Drawing.Size(22, 16);
            this.labelseg.TabIndex = 5;
            this.labelseg.Text = "00";
            // 
            // labelmin
            // 
            this.labelmin.AutoSize = true;
            this.labelmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmin.Location = new System.Drawing.Point(313, 27);
            this.labelmin.Name = "labelmin";
            this.labelmin.Size = new System.Drawing.Size(22, 16);
            this.labelmin.TabIndex = 6;
            this.labelmin.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelh
            // 
            this.labelh.AutoSize = true;
            this.labelh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelh.Location = new System.Drawing.Point(33, 36);
            this.labelh.Name = "labelh";
            this.labelh.Size = new System.Drawing.Size(42, 16);
            this.labelh.TabIndex = 9;
            this.labelh.Text = "Hora";
            // 
            // labelm
            // 
            this.labelm.AutoSize = true;
            this.labelm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelm.Location = new System.Drawing.Point(33, 79);
            this.labelm.Name = "labelm";
            this.labelm.Size = new System.Drawing.Size(53, 16);
            this.labelm.TabIndex = 10;
            this.labelm.Text = "Minuto";
            // 
            // label_nomealarme
            // 
            this.label_nomealarme.AutoSize = true;
            this.label_nomealarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomealarme.Location = new System.Drawing.Point(12, 157);
            this.label_nomealarme.Name = "label_nomealarme";
            this.label_nomealarme.Size = new System.Drawing.Size(124, 16);
            this.label_nomealarme.TabIndex = 12;
            this.label_nomealarme.Text = "Nome do Alarme";
            // 
            // textBox_nomealarme
            // 
            this.textBox_nomealarme.Location = new System.Drawing.Point(154, 157);
            this.textBox_nomealarme.Name = "textBox_nomealarme";
            this.textBox_nomealarme.Size = new System.Drawing.Size(154, 20);
            this.textBox_nomealarme.TabIndex = 13;
            // 
            // labelsom
            // 
            this.labelsom.AutoSize = true;
            this.labelsom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsom.Location = new System.Drawing.Point(15, 208);
            this.labelsom.Name = "labelsom";
            this.labelsom.Size = new System.Drawing.Size(113, 16);
            this.labelsom.TabIndex = 14;
            this.labelsom.Text = "Som de alarme";
            // 
            // comboBox_som
            // 
            this.comboBox_som.FormattingEnabled = true;
            this.comboBox_som.Location = new System.Drawing.Point(154, 208);
            this.comboBox_som.Name = "comboBox_som";
            this.comboBox_som.Size = new System.Drawing.Size(154, 21);
            this.comboBox_som.TabIndex = 15;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(153, 315);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(109, 42);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(268, 315);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(109, 42);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label_guardado
            // 
            this.label_guardado.AutoSize = true;
            this.label_guardado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_guardado.Location = new System.Drawing.Point(12, 55);
            this.label_guardado.Name = "label_guardado";
            this.label_guardado.Size = new System.Drawing.Size(146, 16);
            this.label_guardado.TabIndex = 18;
            this.label_guardado.Text = "Alarmes Guardados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(43, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.Location = new System.Drawing.Point(268, 330);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(109, 42);
            this.btn_fechar.TabIndex = 22;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(18, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 130);
            this.listBox1.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // labelnome_al
            // 
            this.labelnome_al.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnome_al.Location = new System.Drawing.Point(195, 55);
            this.labelnome_al.Name = "labelnome_al";
            this.labelnome_al.Size = new System.Drawing.Size(182, 16);
            this.labelnome_al.TabIndex = 25;
            this.labelnome_al.Text = "Nome_Alarme Null";
            // 
            // btn_adiar
            // 
            this.btn_adiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adiar.Location = new System.Drawing.Point(159, 330);
            this.btn_adiar.Name = "btn_adiar";
            this.btn_adiar.Size = new System.Drawing.Size(109, 42);
            this.btn_adiar.TabIndex = 26;
            this.btn_adiar.Text = "Adiar";
            this.btn_adiar.UseVisualStyleBackColor = true;
            this.btn_adiar.Click += new System.EventHandler(this.btn_adiar_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form_alarme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(391, 386);
            this.Controls.Add(this.btn_adiar);
            this.Controls.Add(this.labelnome_al);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_guardado);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.comboBox_som);
            this.Controls.Add(this.labelsom);
            this.Controls.Add(this.textBox_nomealarme);
            this.Controls.Add(this.label_nomealarme);
            this.Controls.Add(this.labelm);
            this.Controls.Add(this.labelh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelmin);
            this.Controls.Add(this.labelseg);
            this.Controls.Add(this.labelhora);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btn_criaralarme);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_alarme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Button btn_criaralarme;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelhora;
        private System.Windows.Forms.Label labelseg;
        private System.Windows.Forms.Label labelmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelh;
        private System.Windows.Forms.Label labelm;
        private System.Windows.Forms.Label label_nomealarme;
        private System.Windows.Forms.TextBox textBox_nomealarme;
        private System.Windows.Forms.Label labelsom;
        private System.Windows.Forms.ComboBox comboBox_som;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label_guardado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelnome_al;
        private System.Windows.Forms.Button btn_adiar;
        private System.Windows.Forms.Timer timer2;
    }
}

