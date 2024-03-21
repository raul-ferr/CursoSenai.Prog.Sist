namespace variaveis
{
    partial class soma
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
            this.tbxN2 = new System.Windows.Forms.TextBox();
            this.tbxN1 = new System.Windows.Forms.TextBox();
            this.tbxN4 = new System.Windows.Forms.TextBox();
            this.tbxN5 = new System.Windows.Forms.TextBox();
            this.tbxN3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxResultado = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxN2
            // 
            this.tbxN2.Location = new System.Drawing.Point(365, 137);
            this.tbxN2.Name = "tbxN2";
            this.tbxN2.Size = new System.Drawing.Size(100, 20);
            this.tbxN2.TabIndex = 0;
            this.tbxN2.Text = "44";
            // 
            // tbxN1
            // 
            this.tbxN1.Location = new System.Drawing.Point(365, 100);
            this.tbxN1.Name = "tbxN1";
            this.tbxN1.Size = new System.Drawing.Size(100, 20);
            this.tbxN1.TabIndex = 1;
            this.tbxN1.Text = "4";
            this.tbxN1.TextChanged += new System.EventHandler(this.tbxN1_TextChanged);
            // 
            // tbxN4
            // 
            this.tbxN4.Location = new System.Drawing.Point(365, 226);
            this.tbxN4.Name = "tbxN4";
            this.tbxN4.Size = new System.Drawing.Size(100, 20);
            this.tbxN4.TabIndex = 2;
            this.tbxN4.Text = "4";
            // 
            // tbxN5
            // 
            this.tbxN5.Location = new System.Drawing.Point(365, 265);
            this.tbxN5.Name = "tbxN5";
            this.tbxN5.Size = new System.Drawing.Size(100, 20);
            this.tbxN5.TabIndex = 3;
            this.tbxN5.Text = "4";
            // 
            // tbxN3
            // 
            this.tbxN3.Location = new System.Drawing.Point(365, 179);
            this.tbxN3.Name = "tbxN3";
            this.tbxN3.Size = new System.Drawing.Size(100, 20);
            this.tbxN3.TabIndex = 4;
            this.tbxN3.Text = "4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "soma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Location = new System.Drawing.Point(302, 103);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(51, 13);
            this.numero.TabIndex = 6;
            this.numero.Text = "numero 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "numero 2 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "numero 3 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "numero 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "numero 5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = ",";
            // 
            // tbxResultado
            // 
            this.tbxResultado.Location = new System.Drawing.Point(365, 300);
            this.tbxResultado.Name = "tbxResultado";
            this.tbxResultado.Size = new System.Drawing.Size(100, 20);
            this.tbxResultado.TabIndex = 12;
            this.tbxResultado.TextChanged += new System.EventHandler(this.tbxResultado_TextChanged);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(295, 307);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(55, 13);
            this.resultado.TabIndex = 13;
            this.resultado.Text = "Resultado";
            // 
            // soma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.tbxResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxN3);
            this.Controls.Add(this.tbxN5);
            this.Controls.Add(this.tbxN4);
            this.Controls.Add(this.tbxN1);
            this.Controls.Add(this.tbxN2);
            this.Name = "soma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxN2;
        private System.Windows.Forms.TextBox tbxN1;
        private System.Windows.Forms.TextBox tbxN4;
        private System.Windows.Forms.TextBox tbxN5;
        private System.Windows.Forms.TextBox tbxN3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxResultado;
        private System.Windows.Forms.Label resultado;
    }
}

