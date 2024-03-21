namespace formasdepagamentos
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
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.abc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAvista = new System.Windows.Forms.RadioButton();
            this.rbPrazo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxPreco
            // 
            this.tbxPreco.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPreco.Location = new System.Drawing.Point(266, 62);
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(152, 20);
            this.tbxPreco.TabIndex = 0;
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.BackColor = System.Drawing.SystemColors.Info;
            this.tbxQuantidade.Location = new System.Drawing.Point(266, 112);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(152, 20);
            this.tbxQuantidade.TabIndex = 1;
            // 
            // tbxTotal
            // 
            this.tbxTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxTotal.Enabled = false;
            this.tbxTotal.Location = new System.Drawing.Point(266, 164);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(152, 20);
            this.tbxTotal.TabIndex = 2;
            this.tbxTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // abc
            // 
            this.abc.AutoSize = true;
            this.abc.Location = new System.Drawing.Point(161, 69);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(35, 13);
            this.abc.TabIndex = 5;
            this.abc.Text = "Preco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCalcular.Location = new System.Drawing.Point(280, 260);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 29);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // rbAvista
            // 
            this.rbAvista.AutoSize = true;
            this.rbAvista.Location = new System.Drawing.Point(530, 89);
            this.rbAvista.Name = "rbAvista";
            this.rbAvista.Size = new System.Drawing.Size(57, 17);
            this.rbAvista.TabIndex = 9;
            this.rbAvista.TabStop = true;
            this.rbAvista.Text = "A vista";
            this.rbAvista.UseVisualStyleBackColor = true;
            // 
            // rbPrazo
            // 
            this.rbPrazo.AutoSize = true;
            this.rbPrazo.Checked = true;
            this.rbPrazo.Location = new System.Drawing.Point(530, 146);
            this.rbPrazo.Name = "rbPrazo";
            this.rbPrazo.Size = new System.Drawing.Size(52, 17);
            this.rbPrazo.TabIndex = 10;
            this.rbPrazo.TabStop = true;
            this.rbPrazo.Text = "Prazo";
            this.rbPrazo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1233, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbPrazo);
            this.Controls.Add(this.rbAvista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.abc);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.tbxPreco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label abc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAvista;
        private System.Windows.Forms.RadioButton rbPrazo;
        private System.Windows.Forms.Label label3;
    }
}

