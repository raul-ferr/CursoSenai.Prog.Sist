using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formasdepagamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Preco = Convert.ToDouble(tbxPreco.Text);
            double Quantidade = Convert.ToDouble(tbxQuantidade.Text);
            Double Total = 0;
            if (rbAvista.Checked)
                Total = Preco * Quantidade * 0.9;

            if(rbPrazo.Checked)
                 Total = Preco * Quantidade * 1.05;

            tbxTotal.Text = Total.ToString();
            
            

        }
    }
}
