using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio03__13._07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double capital = double.Parse(tbxCapital.Text);
            double taxa = double.Parse(tbxTaxa.Text)/100;
            double tempo = double.Parse(tbxTempo.Text);
            double multiplica = capital * taxa * tempo;
            tbxJuros.Text = multiplica.ToString();
        }
    }
}
