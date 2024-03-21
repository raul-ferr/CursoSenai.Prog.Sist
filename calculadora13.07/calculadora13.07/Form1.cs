using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora13._07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {



            //pegar o valor do 1º número e atribuir em uma variável
            double Número1 = double.Parse(tbxN1.Text);
            //pegar o valor do 2º número e atribuir em uma variável
            double Número2 = double.Parse(tbxN2.Text);
            //calcular a soma
            double soma = Número1 + Número2;
            //exibir o resultado na caixa de texto tbxResultado
            tbxResultado.Text = soma.ToString();

        }
        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            double Número1 = double.Parse(tbxN1.Text);
            double Número2 = double.Parse(tbxN2.Text);
            double subtrai = Número1 - Número2;
            tbxResultado.Text = subtrai.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                double Número1 = double.Parse(tbxN1.Text);
                double Número2 = double.Parse(tbxN2.Text);
                double divide = Número1 / Número2;
                tbxResultado.Text = divide.ToString();
            }
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            double Número1 = double.Parse(tbxN1.Text);
            double Número2 = double.Parse(tbxN2.Text);
            double multiplica = Número1 * Número2;
            tbxResultado.Text = multiplica.ToString();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            tbxN1.Text = "";
            tbxN2.Text = "";
            tbxResultado.Text = "";
        }
    }

}
