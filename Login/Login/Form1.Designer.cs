namespace Login
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
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.Label();
            this.tbxEntrar = new System.Windows.Forms.Button();
            this.lblconfirmar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(680, 243);
            this.tbxUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(216, 23);
            this.tbxUsuario.TabIndex = 0;
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(680, 336);
            this.tbxSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(216, 23);
            this.tbxSenha.TabIndex = 1;
            // 
            // TextBox1
            // 
            this.TextBox1.AutoSize = true;
            this.TextBox1.Location = new System.Drawing.Point(571, 249);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(55, 17);
            this.TextBox1.TabIndex = 2;
            this.TextBox1.Text = "usuario";
            // 
            // TextBox2
            // 
            this.TextBox2.AutoSize = true;
            this.TextBox2.Location = new System.Drawing.Point(579, 336);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(47, 17);
            this.TextBox2.TabIndex = 3;
            this.TextBox2.Text = "senha";
            // 
            // tbxEntrar
            // 
            this.tbxEntrar.Location = new System.Drawing.Point(751, 421);
            this.tbxEntrar.Name = "tbxEntrar";
            this.tbxEntrar.Size = new System.Drawing.Size(75, 23);
            this.tbxEntrar.TabIndex = 4;
            this.tbxEntrar.Text = "Entrar";
            this.tbxEntrar.UseVisualStyleBackColor = true;
            this.tbxEntrar.Click += new System.EventHandler(this.tbxEntrar_Click);
            // 
            // lblconfirmar
            // 
            this.lblconfirmar.AutoSize = true;
            this.lblconfirmar.Location = new System.Drawing.Point(751, 181);
            this.lblconfirmar.Name = "lblconfirmar";
            this.lblconfirmar.Size = new System.Drawing.Size(46, 17);
            this.lblconfirmar.TabIndex = 5;
            this.lblconfirmar.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1824, 837);
            this.Controls.Add(this.lblconfirmar);
            this.Controls.Add(this.tbxEntrar);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label TextBox1;
        private System.Windows.Forms.Label TextBox2;
        private System.Windows.Forms.Button tbxEntrar;
        private System.Windows.Forms.Label lblconfirmar;
    }
}

