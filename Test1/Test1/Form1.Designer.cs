namespace Test1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textProduto1 = new System.Windows.Forms.TextBox();
            this.textProduto2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDesconto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textTotalF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "produto1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "produto2";
            // 
            // textProduto1
            // 
            this.textProduto1.Location = new System.Drawing.Point(118, 58);
            this.textProduto1.Name = "textProduto1";
            this.textProduto1.Size = new System.Drawing.Size(100, 23);
            this.textProduto1.TabIndex = 3;
            // 
            // textProduto2
            // 
            this.textProduto2.Location = new System.Drawing.Point(118, 98);
            this.textProduto2.Name = "textProduto2";
            this.textProduto2.Size = new System.Drawing.Size(100, 23);
            this.textProduto2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "total";
            // 
            // textTotal
            // 
            this.textTotal.Enabled = false;
            this.textTotal.Location = new System.Drawing.Point(118, 141);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(100, 23);
            this.textTotal.TabIndex = 6;
            this.textTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "desconto";
            // 
            // textDesconto
            // 
            this.textDesconto.Enabled = false;
            this.textDesconto.Location = new System.Drawing.Point(118, 174);
            this.textDesconto.Name = "textDesconto";
            this.textDesconto.Size = new System.Drawing.Size(100, 23);
            this.textDesconto.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "total final";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textTotalF
            // 
            this.textTotalF.Enabled = false;
            this.textTotalF.Location = new System.Drawing.Point(118, 214);
            this.textTotalF.Name = "textTotalF";
            this.textTotalF.Size = new System.Drawing.Size(100, 23);
            this.textTotalF.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textTotalF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textDesconto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textProduto2);
            this.Controls.Add(this.textProduto1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textProduto1;
        private TextBox textProduto2;
        private Label label4;
        private TextBox textTotal;
        private Label label5;
        private TextBox textDesconto;
        private Label label6;
        private TextBox textTotalF;
        private Button button1;
    }
}