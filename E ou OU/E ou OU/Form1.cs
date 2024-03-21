using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ou_OU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int Idade = Convert.ToInt32(tbxIdade.Text);
            if( Idade >= 18 && Idade <= 67)
            {

                MessageBox.Show ("Voce pode doar sangue! " , " Verificacao Concluida " , MessageBoxButtons.OK ,MessageBoxIcon.Information);

            }
            else
            {

                //lblMsg.Text = "Voce nao pode doar sangue! ";
                MessageBox.Show("Voce pode doar sangue! ", " Verificacao Concluida ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
