namespace projeto3
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
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btlCalcular = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "A1:";
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(123, 43);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(100, 23);
            this.txtA1.TabIndex = 1;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(123, 84);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 23);
            this.txtN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "N:";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(123, 129);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 23);
            this.txtR.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "R:";
            // 
            // txtAn
            // 
            this.txtAn.Enabled = false;
            this.txtAn.Location = new System.Drawing.Point(123, 169);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(100, 23);
            this.txtAn.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "An:";
            // 
            // btlCalcular
            // 
            this.btlCalcular.Location = new System.Drawing.Point(276, 43);
            this.btlCalcular.Name = "btlCalcular";
            this.btlCalcular.Size = new System.Drawing.Size(75, 23);
            this.btlCalcular.TabIndex = 8;
            this.btlCalcular.Text = "Calcular";
            this.btlCalcular.UseVisualStyleBackColor = true;
            this.btlCalcular.Click += new System.EventHandler(this.btlCalcular_Click);
            // 
            // txtLista
            // 
            this.txtLista.AutoSize = true;
            this.txtLista.Location = new System.Drawing.Point(70, 217);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(34, 15);
            this.txtLista.TabIndex = 9;
            this.txtLista.Text = "Lista:";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(134, 217);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(38, 15);
            this.lblLista.TabIndex = 10;
            this.lblLista.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.btlCalcular);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtA1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtA1;
        private TextBox txtN;
        private Label label2;
        private TextBox txtR;
        private Label label3;
        private TextBox txtAn;
        private Label label4;
        private Button btlCalcular;
        private Label txtLista;
        private Label lblLista;
    }
}