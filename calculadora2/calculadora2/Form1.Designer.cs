namespace calculadora2
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btlSoma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btlSubtracao = new System.Windows.Forms.Button();
            this.btlMulti = new System.Windows.Forms.Button();
            this.btlDivisao = new System.Windows.Forms.Button();
            this.btlLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "#1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "#2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(92, 34);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(159, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(92, 72);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(159, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // btlSoma
            // 
            this.btlSoma.Location = new System.Drawing.Point(292, 36);
            this.btlSoma.Name = "btlSoma";
            this.btlSoma.Size = new System.Drawing.Size(75, 23);
            this.btlSoma.TabIndex = 4;
            this.btlSoma.Text = "+";
            this.btlSoma.UseVisualStyleBackColor = true;
            this.btlSoma.Click += new System.EventHandler(this.btlSoma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(92, 105);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(159, 20);
            this.txtResultado.TabIndex = 6;
            // 
            // btlSubtracao
            // 
            this.btlSubtracao.Location = new System.Drawing.Point(373, 36);
            this.btlSubtracao.Name = "btlSubtracao";
            this.btlSubtracao.Size = new System.Drawing.Size(75, 23);
            this.btlSubtracao.TabIndex = 7;
            this.btlSubtracao.Text = "-";
            this.btlSubtracao.UseVisualStyleBackColor = true;
            this.btlSubtracao.Click += new System.EventHandler(this.button1_Click);
            // 
            // btlMulti
            // 
            this.btlMulti.Location = new System.Drawing.Point(292, 65);
            this.btlMulti.Name = "btlMulti";
            this.btlMulti.Size = new System.Drawing.Size(75, 23);
            this.btlMulti.TabIndex = 8;
            this.btlMulti.Text = "x";
            this.btlMulti.UseVisualStyleBackColor = true;
            this.btlMulti.Click += new System.EventHandler(this.button2_Click);
            // 
            // btlDivisao
            // 
            this.btlDivisao.Location = new System.Drawing.Point(373, 65);
            this.btlDivisao.Name = "btlDivisao";
            this.btlDivisao.Size = new System.Drawing.Size(75, 23);
            this.btlDivisao.TabIndex = 9;
            this.btlDivisao.Text = "/";
            this.btlDivisao.UseVisualStyleBackColor = true;
            this.btlDivisao.Click += new System.EventHandler(this.btlDivisao_Click);
            // 
            // btlLimpar
            // 
            this.btlLimpar.Location = new System.Drawing.Point(373, 107);
            this.btlLimpar.Name = "btlLimpar";
            this.btlLimpar.Size = new System.Drawing.Size(75, 23);
            this.btlLimpar.TabIndex = 10;
            this.btlLimpar.Text = "Limpar";
            this.btlLimpar.UseVisualStyleBackColor = true;
            this.btlLimpar.Click += new System.EventHandler(this.btlLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btlLimpar);
            this.Controls.Add(this.btlDivisao);
            this.Controls.Add(this.btlMulti);
            this.Controls.Add(this.btlSubtracao);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btlSoma);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btlSoma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btlSubtracao;
        private System.Windows.Forms.Button btlMulti;
        private System.Windows.Forms.Button btlDivisao;
        private System.Windows.Forms.Button btlLimpar;
    }
}

