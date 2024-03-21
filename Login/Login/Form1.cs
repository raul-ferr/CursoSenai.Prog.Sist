using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxEntrar_Click(object sender, EventArgs e)
        {
            string usuario = tbxUsuario.Text;
            string senha = tbxSenha.Text;
            if (usuario == "adm")
            {
                if senha = ("admi123") 
                { 
                    lblconfirmar.ForeColor = Color.Green;
                    lblconfirmar.Text = "ok,acesso confirmado .";
                }
                else
                {
                    lblconfirmar.ForeColor = Color.Red;
                    lblconfirmar.Text = "senha incorreta.";
                }
            }
            else
            {
                lblconfirmar.ForeColor = Color.Red;
                lblconfirmar.Text = "Usuario incorreto.";


            }
        }
    }
}
