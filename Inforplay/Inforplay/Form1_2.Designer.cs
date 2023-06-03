namespace Inforplay
{
    partial class Form1_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_2));
            this.btninfo = new System.Windows.Forms.Button();
            this.labeleu = new System.Windows.Forms.Label();
            this.btnjogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninfo
            // 
            this.btninfo.BackColor = System.Drawing.Color.Gold;
            this.btninfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninfo.ForeColor = System.Drawing.Color.Maroon;
            this.btninfo.Location = new System.Drawing.Point(174, 520);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(186, 34);
            this.btninfo.TabIndex = 20;
            this.btninfo.Text = "Informações do jogo";
            this.btninfo.UseVisualStyleBackColor = false;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // labeleu
            // 
            this.labeleu.BackColor = System.Drawing.Color.Transparent;
            this.labeleu.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeleu.ForeColor = System.Drawing.Color.Yellow;
            this.labeleu.Location = new System.Drawing.Point(58, 246);
            this.labeleu.Name = "labeleu";
            this.labeleu.Size = new System.Drawing.Size(437, 43);
            this.labeleu.TabIndex = 21;
            this.labeleu.Text = "Bem vindo, Eu sou o Inforplay.\r\n\r\n";
            this.labeleu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnjogar
            // 
            this.btnjogar.BackColor = System.Drawing.Color.Gold;
            this.btnjogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjogar.ForeColor = System.Drawing.Color.Maroon;
            this.btnjogar.Location = new System.Drawing.Point(174, 478);
            this.btnjogar.Name = "btnjogar";
            this.btnjogar.Size = new System.Drawing.Size(186, 34);
            this.btnjogar.TabIndex = 22;
            this.btnjogar.Text = "Jogar";
            this.btnjogar.UseVisualStyleBackColor = false;
            this.btnjogar.Click += new System.EventHandler(this.btnjogar_Click);
            // 
            // Form1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(555, 593);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.labeleu);
            this.Controls.Add(this.btnjogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1_2";
            this.Load += new System.EventHandler(this.Form1_2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.Label labeleu;
        private System.Windows.Forms.Button btnjogar;
    }
}