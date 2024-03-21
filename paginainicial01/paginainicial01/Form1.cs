using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paginainicial01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            string senha = tbxSenha.Text;
            string nome = tbxNome.Text;
            lblTexto.Text = " seja bem-vindo " + nome + " sua senha é: " + senha
            
        }
    }
}
