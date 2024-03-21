using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btlSoma_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble (txtNum1.Text);
            double num2 = Convert.ToDouble (txtNum2.Text);
            double soma = num1 + num2;
            txtResultado.Text = Convert.ToString(soma);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double sub = num1 - num2;
            txtResultado.Text = Convert.ToString(sub);
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double multi = num1 * num2;
            txtResultado.Text = Convert.ToString(multi);
        }

        private void btlDivisao_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double div = num1 / num2;
            txtResultado.Text = Convert.ToString(div);
        }

        private void btlLimpar_Click(object sender, EventArgs e)
        {
            string num1 = Convert.ToString(txtNum1.Text = (" "));
            string num2 = Convert.ToString(txtNum2.Text = (" "));
            txtResultado.Text = Convert.ToString(" ");
                
        }
    }
}
