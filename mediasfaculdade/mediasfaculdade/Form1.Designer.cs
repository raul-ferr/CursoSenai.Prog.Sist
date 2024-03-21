namespace mediasfaculdade
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSintuacao = new System.Windows.Forms.TextBox();
            this.btlCalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRecuperacao = new System.Windows.Forms.TextBox();
            this.btlRecupera = new System.Windows.Forms.Button();
            this.txtSintuacao2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "nota1";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(104, 31);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 23);
            this.txtNota1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "nota2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(104, 60);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 23);
            this.txtNota2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "nota3";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(104, 89);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 23);
            this.txtNota3.TabIndex = 1;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(331, 36);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 23);
            this.txtNota.TabIndex = 1;
            this.txtNota.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "nota final";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "sintuação";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSintuacao
            // 
            this.txtSintuacao.Location = new System.Drawing.Point(331, 65);
            this.txtSintuacao.Name = "txtSintuacao";
            this.txtSintuacao.Size = new System.Drawing.Size(100, 23);
            this.txtSintuacao.TabIndex = 1;
            // 
            // btlCalcular
            // 
            this.btlCalcular.Location = new System.Drawing.Point(356, 97);
            this.btlCalcular.Name = "btlCalcular";
            this.btlCalcular.Size = new System.Drawing.Size(75, 23);
            this.btlCalcular.TabIndex = 2;
            this.btlCalcular.Text = "Calcular";
            this.btlCalcular.UseVisualStyleBackColor = true;
            this.btlCalcular.Click += new System.EventHandler(this.btlCalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "recuperação";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRecuperacao
            // 
            this.txtRecuperacao.Location = new System.Drawing.Point(554, 36);
            this.txtRecuperacao.Name = "txtRecuperacao";
            this.txtRecuperacao.Size = new System.Drawing.Size(100, 23);
            this.txtRecuperacao.TabIndex = 1;
            this.txtRecuperacao.TextChanged += new System.EventHandler(this.txtNota_TextChanged);
            // 
            // btlRecupera
            // 
            this.btlRecupera.Location = new System.Drawing.Point(579, 97);
            this.btlRecupera.Name = "btlRecupera";
            this.btlRecupera.Size = new System.Drawing.Size(75, 23);
            this.btlRecupera.TabIndex = 3;
            this.btlRecupera.Text = "Calcular";
            this.btlRecupera.UseVisualStyleBackColor = true;
            this.btlRecupera.Click += new System.EventHandler(this.btlRecupera_Click);
            // 
            // txtSintuacao2
            // 
            this.txtSintuacao2.Location = new System.Drawing.Point(554, 68);
            this.txtSintuacao2.Name = "txtSintuacao2";
            this.txtSintuacao2.Size = new System.Drawing.Size(100, 23);
            this.txtSintuacao2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "sintuação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSintuacao2);
            this.Controls.Add(this.btlRecupera);
            this.Controls.Add(this.btlCalcular);
            this.Controls.Add(this.txtSintuacao);
            this.Controls.Add(this.txtRecuperacao);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNota1;
        private Label label2;
        private TextBox txtNota2;
        private Label label3;
        private TextBox txtNota3;
        private TextBox txtNota;
        private Label label4;
        private Label label5;
        private TextBox txtSintuacao;
        private Button btlCalcular;
        private Label label6;
        private TextBox txtRecuperacao;
        private Button btlRecupera;
        private TextBox txtSintuacao2;
        private Label label7;
    }
}