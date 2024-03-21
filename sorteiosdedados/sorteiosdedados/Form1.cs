using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sorteiosdedados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
        Random numAleatorio = new Random();
       int num = numAleatorio.Next(1, 100);
            lblSorteado.Text = num.ToString();
            if (num == Convert.ToInt32(tbxTentativa.Text))
                lblResultado.Text = "Parabens cara";
            else
                lblResultado.Text = "Tente Novamente porahh";
        
        }

        
        {

        }
    }
}
