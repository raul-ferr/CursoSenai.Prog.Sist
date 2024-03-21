namespace Sorveteria_Senac
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
            this.comboSabores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChoco = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMoran = new System.Windows.Forms.CheckBox();
            this.cbLeite = new System.Windows.Forms.CheckBox();
            this.cobLeite = new System.Windows.Forms.CheckBox();
            this.cobMoran = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cobChoco = new System.Windows.Forms.CheckBox();
            this.La = new System.Windows.Forms.Label();
            this.lblPreçoF = new System.Windows.Forms.Label();
            this.lblCobertura = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCalda = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSabor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.preçoSabor = new System.Windows.Forms.Label();
            this.preçoCalda = new System.Windows.Forms.Label();
            this.preçoCobertura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sabores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboSabores
            // 
            this.comboSabores.FormattingEnabled = true;
            this.comboSabores.Items.AddRange(new object[] {
            "Chocolate",
            "Napolitano",
            "Flocos",
            "Leite Condensado"});
            this.comboSabores.Location = new System.Drawing.Point(88, 64);
            this.comboSabores.Name = "comboSabores";
            this.comboSabores.Size = new System.Drawing.Size(121, 23);
            this.comboSabores.TabIndex = 1;
            this.comboSabores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "SORVETERIA SENAC";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbChoco
            // 
            this.cbChoco.AutoSize = true;
            this.cbChoco.Location = new System.Drawing.Point(21, 146);
            this.cbChoco.Name = "cbChoco";
            this.cbChoco.Size = new System.Drawing.Size(80, 19);
            this.cbChoco.TabIndex = 3;
            this.cbChoco.Text = "Chocolate";
            this.cbChoco.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calda";
            // 
            // cbMoran
            // 
            this.cbMoran.AutoSize = true;
            this.cbMoran.Location = new System.Drawing.Point(21, 172);
            this.cbMoran.Name = "cbMoran";
            this.cbMoran.Size = new System.Drawing.Size(75, 19);
            this.cbMoran.TabIndex = 5;
            this.cbMoran.Text = "Morango";
            this.cbMoran.UseVisualStyleBackColor = true;
            // 
            // cbLeite
            // 
            this.cbLeite.AutoSize = true;
            this.cbLeite.Location = new System.Drawing.Point(21, 196);
            this.cbLeite.Name = "cbLeite";
            this.cbLeite.Size = new System.Drawing.Size(121, 19);
            this.cbLeite.TabIndex = 6;
            this.cbLeite.Text = "Leite Condensado";
            this.cbLeite.UseVisualStyleBackColor = true;
            // 
            // cobLeite
            // 
            this.cobLeite.AutoSize = true;
            this.cobLeite.Location = new System.Drawing.Point(185, 196);
            this.cobLeite.Name = "cobLeite";
            this.cobLeite.Size = new System.Drawing.Size(121, 19);
            this.cobLeite.TabIndex = 10;
            this.cobLeite.Text = "Leite Condensado";
            this.cobLeite.UseVisualStyleBackColor = true;
            // 
            // cobMoran
            // 
            this.cobMoran.AutoSize = true;
            this.cobMoran.Location = new System.Drawing.Point(185, 172);
            this.cobMoran.Name = "cobMoran";
            this.cobMoran.Size = new System.Drawing.Size(75, 19);
            this.cobMoran.TabIndex = 9;
            this.cobMoran.Text = "Morango";
            this.cobMoran.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(180, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cobertura";
            // 
            // cobChoco
            // 
            this.cobChoco.AutoSize = true;
            this.cobChoco.Location = new System.Drawing.Point(185, 146);
            this.cobChoco.Name = "cobChoco";
            this.cobChoco.Size = new System.Drawing.Size(80, 19);
            this.cobChoco.TabIndex = 7;
            this.cobChoco.Text = "Chocolate";
            this.cobChoco.UseVisualStyleBackColor = true;
            // 
            // La
            // 
            this.La.AutoSize = true;
            this.La.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.La.Location = new System.Drawing.Point(632, 46);
            this.La.Name = "La";
            this.La.Size = new System.Drawing.Size(86, 21);
            this.La.TabIndex = 11;
            this.La.Text = "Preço Final";
            // 
            // lblPreçoF
            // 
            this.lblPreçoF.AutoSize = true;
            this.lblPreçoF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreçoF.Location = new System.Drawing.Point(632, 123);
            this.lblPreçoF.Name = "lblPreçoF";
            this.lblPreçoF.Size = new System.Drawing.Size(86, 21);
            this.lblPreçoF.TabIndex = 12;
            this.lblPreçoF.Text = "Preço Final";
            this.lblPreçoF.Visible = false;
            // 
            // lblCobertura
            // 
            this.lblCobertura.AutoSize = true;
            this.lblCobertura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCobertura.Location = new System.Drawing.Point(540, 80);
            this.lblCobertura.Name = "lblCobertura";
            this.lblCobertura.Size = new System.Drawing.Size(86, 21);
            this.lblCobertura.TabIndex = 14;
            this.lblCobertura.Text = "Preço Final";
            this.lblCobertura.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(540, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cobertura";
            // 
            // lblCalda
            // 
            this.lblCalda.AutoSize = true;
            this.lblCalda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalda.Location = new System.Drawing.Point(448, 80);
            this.lblCalda.Name = "lblCalda";
            this.lblCalda.Size = new System.Drawing.Size(86, 21);
            this.lblCalda.TabIndex = 16;
            this.lblCalda.Text = "Preço Final";
            this.lblCalda.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(448, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Calda";
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSabor.Location = new System.Drawing.Point(356, 80);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(86, 21);
            this.lblSabor.TabIndex = 18;
            this.lblSabor.Text = "Preço Final";
            this.lblSabor.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(356, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Sabor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Escolher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // preçoSabor
            // 
            this.preçoSabor.AutoSize = true;
            this.preçoSabor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preçoSabor.Location = new System.Drawing.Point(356, 123);
            this.preçoSabor.Name = "preçoSabor";
            this.preçoSabor.Size = new System.Drawing.Size(51, 21);
            this.preçoSabor.TabIndex = 20;
            this.preçoSabor.Text = "Sabor";
            this.preçoSabor.Visible = false;
            // 
            // preçoCalda
            // 
            this.preçoCalda.AutoSize = true;
            this.preçoCalda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preçoCalda.Location = new System.Drawing.Point(446, 123);
            this.preçoCalda.Name = "preçoCalda";
            this.preçoCalda.Size = new System.Drawing.Size(51, 21);
            this.preçoCalda.TabIndex = 21;
            this.preçoCalda.Text = "Sabor";
            this.preçoCalda.Visible = false;
            // 
            // preçoCobertura
            // 
            this.preçoCobertura.AutoSize = true;
            this.preçoCobertura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preçoCobertura.Location = new System.Drawing.Point(540, 123);
            this.preçoCobertura.Name = "preçoCobertura";
            this.preçoCobertura.Size = new System.Drawing.Size(51, 21);
            this.preçoCobertura.TabIndex = 22;
            this.preçoCobertura.Text = "Sabor";
            this.preçoCobertura.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.preçoCobertura);
            this.Controls.Add(this.preçoCalda);
            this.Controls.Add(this.preçoSabor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSabor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCalda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCobertura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPreçoF);
            this.Controls.Add(this.La);
            this.Controls.Add(this.cobLeite);
            this.Controls.Add(this.cobMoran);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cobChoco);
            this.Controls.Add(this.cbLeite);
            this.Controls.Add(this.cbMoran);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbChoco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSabores);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboSabores;
        private Label label2;
        private CheckBox cbChoco;
        private Label label3;
        private CheckBox cbMoran;
        private CheckBox cbLeite;
        private CheckBox cobLeite;
        private CheckBox cobMoran;
        private Label label4;
        private CheckBox cobChoco;
        private Label La;
        private Label lblPreçoF;
        private Label lblCobertura;
        private Label label6;
        private Label lblCalda;
        private Label label8;
        private Label lblSabor;
        private Label label10;
        private Button button1;
        private Label preçoSabor;
        private Label preçoCalda;
        private Label preçoCobertura;
    }
}