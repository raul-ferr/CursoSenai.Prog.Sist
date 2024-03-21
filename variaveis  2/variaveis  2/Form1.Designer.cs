namespace variaveis__2
{
    partial class multiplicacao
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
            this.tbxBase = new System.Windows.Forms.TextBox();
            this.tbxAltura = new System.Windows.Forms.TextBox();
            this.tbxArea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbxLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxBase
            // 
            this.tbxBase.Location = new System.Drawing.Point(342, 136);
            this.tbxBase.Name = "tbxBase";
            this.tbxBase.Size = new System.Drawing.Size(100, 20);
            this.tbxBase.TabIndex = 0;
            this.tbxBase.Text = "4";
            // 
            // tbxAltura
            // 
            this.tbxAltura.Location = new System.Drawing.Point(342, 189);
            this.tbxAltura.Name = "tbxAltura";
            this.tbxAltura.Size = new System.Drawing.Size(100, 20);
            this.tbxAltura.TabIndex = 1;
            this.tbxAltura.Text = "44";
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(502, 163);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(75, 23);
            this.tbxArea.TabIndex = 2;
            this.tbxArea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Area";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(342, 242);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 35);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbxLimpar
            // 
            this.tbxLimpar.Location = new System.Drawing.Point(467, 248);
            this.tbxLimpar.Name = "tbxLimpar";
            this.tbxLimpar.Size = new System.Drawing.Size(75, 23);
            this.tbxLimpar.TabIndex = 7;
            this.tbxLimpar.Text = "Limpar";
            this.tbxLimpar.UseVisualStyleBackColor = true;
            this.tbxLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // multiplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.tbxAltura);
            this.Controls.Add(this.tbxBase);
            this.Name = "multiplicacao";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBase;
        private System.Windows.Forms.TextBox tbxAltura;
        private System.Windows.Forms.Button tbxArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button tbxLimpar;
    }
}

