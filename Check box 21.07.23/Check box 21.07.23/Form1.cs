using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_box_21._07._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int verifica = 0;
            if (ckb1.Checked)
            {
                verifica ++;
            }
            if (ckb2.Checked)
            {
                verifica ++;
            }
            if (ckb3.Checked)
            {
                verifica++;
            }
            if (ckb4.Checked)
            {
                verifica++;
            }
            if (ckb5.Checked)
            {
                verifica++;
            }
            if (verifica <= 1)
            {
                MessageBox.Show("INOCENTE","Lógica de programação SENAC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (verifica == 2)
            {
                MessageBox.Show("SUSPEITO", "Lógica de programação SENAC" ,MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (verifica == 3 || verifica == 4)
            {
                MessageBox.Show("CÚMPLICE", "Lógica de programação SENAC" ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (verifica == 5)
            {
                MessageBox.Show("ASSASSINO", "Lógica de programação SENAC" ,MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
            
        }
    }
}
