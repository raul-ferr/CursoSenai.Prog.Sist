using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variaveis
{
    public partial class soma : Form
    {
        public soma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N1 = Convert.ToInt32(tbxN1.Text);
            int N2 = Convert.ToInt32(tbxN2.Text);
            int soma = N1 + N2;
            tbxResultado.Text = soma.ToString();

             int N1 = Convert.ToInt32(tbxN1.Text);
              int N2 = Convert.ToInt32(tbxN2.Text);
              int N3 = Convert.ToInt32(tbxN3.Text);
              int N4 = Convert.ToInt32(tbxN4.Text);
              int N5 = Convert.ToInt32(tbxN5.Text);
              int soma = (N1 + N2 + N3 + N4 + N5);
              tbxResultado.Text = soma.ToString();




        }
     
        private void tbxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxN1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
