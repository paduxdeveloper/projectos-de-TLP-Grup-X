namespace crono_tempor_alarme
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btncomecar = new System.Windows.Forms.Button();
            this.btnrepetir = new System.Windows.Forms.Button();
            this.btnparar = new System.Windows.Forms.Button();
            this.btnretomar = new System.Windows.Forms.Button();
            this.btnrepor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "        00:00:00:0000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btncomecar
            // 
            this.btncomecar.BackColor = System.Drawing.Color.SeaShell;
            this.btncomecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomecar.Location = new System.Drawing.Point(189, 327);
            this.btncomecar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncomecar.Name = "btncomecar";
            this.btncomecar.Size = new System.Drawing.Size(244, 59);
            this.btncomecar.TabIndex = 1;
            this.btncomecar.Text = "INICIAR";
            this.btncomecar.UseVisualStyleBackColor = false;
            this.btncomecar.Click += new System.EventHandler(this.btncomecar_Click);
            // 
            // btnrepetir
            // 
            this.btnrepetir.BackColor = System.Drawing.Color.SeaShell;
            this.btnrepetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrepetir.Location = new System.Drawing.Point(305, 327);
            this.btnrepetir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrepetir.Name = "btnrepetir";
            this.btnrepetir.Size = new System.Drawing.Size(173, 59);
            this.btnrepetir.TabIndex = 2;
            this.btnrepetir.Text = "REPETIR";
            this.btnrepetir.UseVisualStyleBackColor = false;
            this.btnrepetir.Click += new System.EventHandler(this.btnrepetir_Click);
            // 
            // btnparar
            // 
            this.btnparar.BackColor = System.Drawing.Color.SeaShell;
            this.btnparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparar.Location = new System.Drawing.Point(137, 327);
            this.btnparar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnparar.Name = "btnparar";
            this.btnparar.Size = new System.Drawing.Size(173, 59);
            this.btnparar.TabIndex = 3;
            this.btnparar.Text = "PARAR";
            this.btnparar.UseVisualStyleBackColor = false;
            this.btnparar.Click += new System.EventHandler(this.btnparar_Click);
            // 
            // btnretomar
            // 
            this.btnretomar.BackColor = System.Drawing.Color.SeaShell;
            this.btnretomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretomar.Location = new System.Drawing.Point(137, 326);
            this.btnretomar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnretomar.Name = "btnretomar";
            this.btnretomar.Size = new System.Drawing.Size(173, 59);
            this.btnretomar.TabIndex = 4;
            this.btnretomar.Text = "RETOMAR";
            this.btnretomar.UseVisualStyleBackColor = false;
            this.btnretomar.Click += new System.EventHandler(this.btnretomar_Click);
            // 
            // btnrepor
            // 
            this.btnrepor.BackColor = System.Drawing.Color.SeaShell;
            this.btnrepor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrepor.Location = new System.Drawing.Point(305, 326);
            this.btnrepor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrepor.Name = "btnrepor";
            this.btnrepor.Size = new System.Drawing.Size(173, 59);
            this.btnrepor.TabIndex = 5;
            this.btnrepor.Text = "REPOR";
            this.btnrepor.UseVisualStyleBackColor = false;
            this.btnrepor.Click += new System.EventHandler(this.btnrepor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(631, 524);
            this.Controls.Add(this.btnrepor);
            this.Controls.Add(this.btnretomar);
            this.Controls.Add(this.btnparar);
            this.Controls.Add(this.btnrepetir);
            this.Controls.Add(this.btncomecar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronómetro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btncomecar;
        private System.Windows.Forms.Button btnrepetir;
        private System.Windows.Forms.Button btnparar;
        private System.Windows.Forms.Button btnretomar;
        private System.Windows.Forms.Button btnrepor;
    }
}

