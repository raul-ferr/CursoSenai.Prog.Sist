namespace Exercicio03__13._07
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCapital = new System.Windows.Forms.TextBox();
            this.tbxTaxa = new System.Windows.Forms.TextBox();
            this.tbxTempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxJuros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tempo";
            // 
            // tbxCapital
            // 
            this.tbxCapital.Location = new System.Drawing.Point(234, 71);
            this.tbxCapital.Name = "tbxCapital";
            this.tbxCapital.Size = new System.Drawing.Size(100, 20);
            this.tbxCapital.TabIndex = 3;
            // 
            // tbxTaxa
            // 
            this.tbxTaxa.Location = new System.Drawing.Point(234, 106);
            this.tbxTaxa.Name = "tbxTaxa";
            this.tbxTaxa.Size = new System.Drawing.Size(100, 20);
            this.tbxTaxa.TabIndex = 4;
            // 
            // tbxTempo
            // 
            this.tbxTempo.Location = new System.Drawing.Point(234, 146);
            this.tbxTempo.Name = "tbxTempo";
            this.tbxTempo.Size = new System.Drawing.Size(100, 20);
            this.tbxTempo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Juros";
            // 
            // tbxJuros
            // 
            this.tbxJuros.Location = new System.Drawing.Point(441, 99);
            this.tbxJuros.Name = "tbxJuros";
            this.tbxJuros.Size = new System.Drawing.Size(100, 20);
            this.tbxJuros.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(272, 209);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(220, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbxJuros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxTempo);
            this.Controls.Add(this.tbxTaxa);
            this.Controls.Add(this.tbxCapital);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxCapital;
        private System.Windows.Forms.TextBox tbxTaxa;
        private System.Windows.Forms.TextBox tbxTempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxJuros;
        private System.Windows.Forms.Button btnCalcular;
    }
}

