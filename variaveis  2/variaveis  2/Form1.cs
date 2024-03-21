using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variaveis__2
{
    public partial class multiplicacao : Form
    {
        public multiplicacao()
        {
            InitializeComponent();
   
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        double b  = Convert.ToDouble(tbxBase.Text);
        double a = Convert.ToDouble(tbxAltura.Text);
            double area = (b * a) / 2;
            tbxArea.Text = area.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)

        {
            tbxBase.Text = "";
            tbxAltura.Text = "";
            tbxArea.Text = " ;
            tbxBasse.Focus(); 

        }
    }
}
