namespace tabuada2
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btlCalcular = new System.Windows.Forms.Button();
            this.rdbSoma = new System.Windows.Forms.RadioButton();
            this.rdbSubtração = new System.Windows.Forms.RadioButton();
            this.rbdMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rbdDivisao = new System.Windows.Forms.RadioButton();
            this.gbOperacoes = new System.Windows.Forms.GroupBox();
            this.gbOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(104, 12);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 23);
            this.txtNumero1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número 2:";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(104, 53);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 23);
            this.txtNumero2.TabIndex = 1;
            // 
            // btlCalcular
            // 
            this.btlCalcular.Location = new System.Drawing.Point(129, 94);
            this.btlCalcular.Name = "btlCalcular";
            this.btlCalcular.Size = new System.Drawing.Size(75, 23);
            this.btlCalcular.TabIndex = 2;
            this.btlCalcular.Text = "Calcular";
            this.btlCalcular.UseVisualStyleBackColor = true;
            this.btlCalcular.Click += new System.EventHandler(this.btlCalcular_Click);
            // 
            // rdbSoma
            // 
            this.rdbSoma.AutoSize = true;
            this.rdbSoma.Location = new System.Drawing.Point(68, 22);
            this.rdbSoma.Name = "rdbSoma";
            this.rdbSoma.Size = new System.Drawing.Size(55, 19);
            this.rdbSoma.TabIndex = 3;
            this.rdbSoma.TabStop = true;
            this.rdbSoma.Text = "Soma";
            this.rdbSoma.UseVisualStyleBackColor = true;
            // 
            // rdbSubtração
            // 
            this.rdbSubtração.AutoSize = true;
            this.rdbSubtração.Location = new System.Drawing.Point(68, 60);
            this.rdbSubtração.Name = "rdbSubtração";
            this.rdbSubtração.Size = new System.Drawing.Size(78, 19);
            this.rdbSubtração.TabIndex = 4;
            this.rdbSubtração.TabStop = true;
            this.rdbSubtração.Text = "Subtração";
            this.rdbSubtração.UseVisualStyleBackColor = true;
            // 
            // rbdMultiplicacao
            // 
            this.rbdMultiplicacao.AutoSize = true;
            this.rbdMultiplicacao.Location = new System.Drawing.Point(68, 99);
            this.rbdMultiplicacao.Name = "rbdMultiplicacao";
            this.rbdMultiplicacao.Size = new System.Drawing.Size(97, 19);
            this.rbdMultiplicacao.TabIndex = 5;
            this.rbdMultiplicacao.TabStop = true;
            this.rbdMultiplicacao.Text = "Multiplicação";
            this.rbdMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rbdDivisao
            // 
            this.rbdDivisao.AutoSize = true;
            this.rbdDivisao.Location = new System.Drawing.Point(68, 136);
            this.rbdDivisao.Name = "rbdDivisao";
            this.rbdDivisao.Size = new System.Drawing.Size(63, 19);
            this.rbdDivisao.TabIndex = 6;
            this.rbdDivisao.TabStop = true;
            this.rbdDivisao.Text = "Divisão";
            this.rbdDivisao.UseVisualStyleBackColor = true;
            // 
            // gbOperacoes
            // 
            this.gbOperacoes.Controls.Add(this.rdbSoma);
            this.gbOperacoes.Controls.Add(this.rbdDivisao);
            this.gbOperacoes.Controls.Add(this.rdbSubtração);
            this.gbOperacoes.Controls.Add(this.rbdMultiplicacao);
            this.gbOperacoes.Location = new System.Drawing.Point(280, 12);
            this.gbOperacoes.Name = "gbOperacoes";
            this.gbOperacoes.Size = new System.Drawing.Size(164, 157);
            this.gbOperacoes.TabIndex = 7;
            this.gbOperacoes.TabStop = false;
            this.gbOperacoes.Text = "Escolha uma operação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbOperacoes);
            this.Controls.Add(this.btlCalcular);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbOperacoes.ResumeLayout(false);
            this.gbOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNumero1;
        private Label label2;
        private TextBox txtNumero2;
        private Label label3;
        private TextBox txtNumero3;
        private Button btlCalcular;
        private RadioButton rdbSoma;
        private RadioButton rdbSubtração;
        private RadioButton rbdMultiplicacao;
        private RadioButton rbdDivisao;
        private GroupBox gbOperacoes;
        private Label label4;
        private Label label5;
        private Label txtResultado;
        private TextBox txtNuumero1;
        private TextBox txtNuumero2;
        private TextBox txtNuumero3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button btnCalcular;
        private GroupBox groupBox2;
    }
}