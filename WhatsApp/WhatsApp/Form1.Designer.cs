namespace WhatsApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtdest = new System.Windows.Forms.TextBox();
            this.txtmens = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblfundo = new System.Windows.Forms.Label();
            this.lblclaro = new System.Windows.Forms.Label();
            this.lblescuro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdest
            // 
            this.txtdest.Location = new System.Drawing.Point(133, 184);
            this.txtdest.Multiline = true;
            this.txtdest.Name = "txtdest";
            this.txtdest.Size = new System.Drawing.Size(157, 28);
            this.txtdest.TabIndex = 0;
            // 
            // txtmens
            // 
            this.txtmens.Location = new System.Drawing.Point(132, 286);
            this.txtmens.Multiline = true;
            this.txtmens.Name = "txtmens";
            this.txtmens.Size = new System.Drawing.Size(489, 203);
            this.txtmens.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enviar para:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mensagem :";
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.Gold;
            this.btnenviar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenviar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnenviar.Location = new System.Drawing.Point(663, 447);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(93, 42);
            this.btnenviar.TabIndex = 4;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(837, 53);
            this.label3.TabIndex = 5;
            this.label3.Text = "Whatsapp Sender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfundo
            // 
            this.lblfundo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfundo.ForeColor = System.Drawing.Color.White;
            this.lblfundo.Location = new System.Drawing.Point(129, 535);
            this.lblfundo.Name = "lblfundo";
            this.lblfundo.Size = new System.Drawing.Size(128, 23);
            this.lblfundo.TabIndex = 6;
            this.lblfundo.Text = "Fundo";
            this.lblfundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblfundo.Click += new System.EventHandler(this.lblfundo_Click);
            // 
            // lblclaro
            // 
            this.lblclaro.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblclaro.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclaro.ForeColor = System.Drawing.Color.White;
            this.lblclaro.Location = new System.Drawing.Point(189, 535);
            this.lblclaro.Name = "lblclaro";
            this.lblclaro.Size = new System.Drawing.Size(101, 23);
            this.lblclaro.TabIndex = 7;
            this.lblclaro.Text = "Light ";
            this.lblclaro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblclaro.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblescuro
            // 
            this.lblescuro.BackColor = System.Drawing.Color.Blue;
            this.lblescuro.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblescuro.ForeColor = System.Drawing.Color.White;
            this.lblescuro.Location = new System.Drawing.Point(93, 535);
            this.lblescuro.Name = "lblescuro";
            this.lblescuro.Size = new System.Drawing.Size(106, 23);
            this.lblescuro.TabIndex = 8;
            this.lblescuro.Text = "Dark ";
            this.lblescuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblescuro.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(861, 629);
            this.Controls.Add(this.lblescuro);
            this.Controls.Add(this.lblclaro);
            this.Controls.Add(this.lblfundo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmens);
            this.Controls.Add(this.txtdest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whatsapp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdest;
        private System.Windows.Forms.TextBox txtmens;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblfundo;
        private System.Windows.Forms.Label lblclaro;
        private System.Windows.Forms.Label lblescuro;
    }
}

