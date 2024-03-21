namespace Check_box_21._07._23
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
            this.ckb1 = new System.Windows.Forms.CheckBox();
            this.ckb2 = new System.Windows.Forms.CheckBox();
            this.ckb3 = new System.Windows.Forms.CheckBox();
            this.ckb4 = new System.Windows.Forms.CheckBox();
            this.ckb5 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckb1
            // 
            this.ckb1.AutoSize = true;
            this.ckb1.Location = new System.Drawing.Point(26, 68);
            this.ckb1.Name = "ckb1";
            this.ckb1.Size = new System.Drawing.Size(169, 17);
            this.ckb1.TabIndex = 0;
            this.ckb1.Text = "Você telefonou para a vítima?";
            this.ckb1.UseVisualStyleBackColor = true;
            // 
            // ckb2
            // 
            this.ckb2.AutoSize = true;
            this.ckb2.Location = new System.Drawing.Point(26, 91);
            this.ckb2.Name = "ckb2";
            this.ckb2.Size = new System.Drawing.Size(148, 17);
            this.ckb2.TabIndex = 1;
            this.ckb2.Text = "Esteve no local do crime?";
            this.ckb2.UseVisualStyleBackColor = true;
            // 
            // ckb3
            // 
            this.ckb3.AutoSize = true;
            this.ckb3.Location = new System.Drawing.Point(26, 112);
            this.ckb3.Name = "ckb3";
            this.ckb3.Size = new System.Drawing.Size(130, 17);
            this.ckb3.TabIndex = 2;
            this.ckb3.Text = "Mora perto da vítima?";
            this.ckb3.UseVisualStyleBackColor = true;
            // 
            // ckb4
            // 
            this.ckb4.AutoSize = true;
            this.ckb4.Location = new System.Drawing.Point(26, 135);
            this.ckb4.Name = "ckb4";
            this.ckb4.Size = new System.Drawing.Size(125, 17);
            this.ckb4.TabIndex = 3;
            this.ckb4.Text = "Devia para a vítima?";
            this.ckb4.UseVisualStyleBackColor = true;
            // 
            // ckb5
            // 
            this.ckb5.AutoSize = true;
            this.ckb5.Location = new System.Drawing.Point(26, 158);
            this.ckb5.Name = "ckb5";
            this.ckb5.Size = new System.Drawing.Size(144, 17);
            this.ckb5.TabIndex = 4;
            this.ckb5.Text = "Trabalhou com a vítima?";
            this.ckb5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ckb1);
            this.groupBox1.Controls.Add(this.ckb2);
            this.groupBox1.Controls.Add(this.ckb3);
            this.groupBox1.Controls.Add(this.ckb4);
            this.groupBox1.Controls.Add(this.ckb5);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 255);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teste 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ckb1;
        private System.Windows.Forms.CheckBox ckb2;
        private System.Windows.Forms.CheckBox ckb3;
        private System.Windows.Forms.CheckBox ckb4;
        private System.Windows.Forms.CheckBox ckb5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

