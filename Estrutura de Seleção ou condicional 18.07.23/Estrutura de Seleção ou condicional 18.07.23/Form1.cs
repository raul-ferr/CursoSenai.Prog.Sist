using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrutura_de_Seleção_ou_condicional_18._07._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(tbxN1.Text);
            double n2 = double.Parse(tbxN2.Text);
            double n3 = double.Parse(tbxN3.Text);
            double media = (n1 + n2 + n3) / 3;

            if (media >= 7)
            {
                lblResultado.Text = "O Aluno está Aprovado.";

            }
            if (media < 7)
            {
                lblResultado.Text = "O aluno está Reprovado.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcula_Click(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            double quantidade = double.Parse(tbxQuantidade.Text);
            double valor = double.Parse(tbxValor.Text);
            double total = quantidade * valor;
            tbxTotal.Text = total.ToString();
            string pagamento = cbxModalidade.Text;
            double desconto = 0;

            if (pagamento == "a vista")
            {
                desconto = 0.1 * total;
            }
            tbxValorFinal.Text = (total - desconto).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcula3_Click(object sender, EventArgs e)
        {
            double number1 = double.Parse(tbxNumber1.Text);
            double number2 = double.Parse(tbxNumber2.Text);
            double resultado = 0;

            if (comboBox1.Text == "soma")
            {
                resultado = number1 + number2;
            }
            if (comboBox1.Text == "multiplicação")
            {
                resultado = number1 * number2;

            }
            tbxResultado.Text = resultado.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxClima.Text == "Sol")
            {
                lblDica.Text = "Dica pra hoje Que tal ir para uma praia??";
            }
            else if (cbxClima.Text == "Chuva")
            {
                lblDica.Text = "Dica pra hoje Nessas horas é bom assistir um filme na Netiflix";
            }
            else
            {
                lblDica.Text = "Dica pra hoje Um chocolate quente um cobertor cairia bem";
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tbxSenha.Text == "Myname")
            {
                lblMensagem.Text = "Acesso liberado. Bom dia";
                lblMensagem.ForeColor = Color.Blue;
            }
            else
            {
                lblMensagem.Text = "Acesso negado. Tente novamente";
                lblMensagem.ForeColor = Color.Red;
            }

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(tbxNotaUm.Text);
            double nota2 = double.Parse(tbxNotaDois.Text);
            double nota3 = double.Parse(tbxNotaTres.Text);
            double media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                lblMedia.Text = "Aprovado.";
                lblMedia.ForeColor = Color.Blue;

            }
            else if (media < 7 && media >= 4)
            {
                lblMedia.Text = "Recuperação.";
                lblMedia.ForeColor = Color.Yellow;
            }
            if (media < 4)
            {
                lblMedia.Text = "Reprovado";
                lblMedia.ForeColor = Color.Red;
            }
        }

        private void btnEntrar7_Click(object sender, EventArgs e)
        {
            string usuario = tbxUsuario.Text;
            string senha = tbxSenha1.Text;

            if (usuario == "leojulio@hotmail.com" && senha == "leojulio2023")
            {
                lblCondicao7.Text = "Seja Bem-Vindo Leonardo";
                lblCondicao7.ForeColor = Color.Blue;
            }
            else if (usuario != "leojulio@hotmail.com" && senha == "leojulio2023")
            {
                lblCondicao7.Text = "Email está incorreto Sr. Leonardo";
                lblCondicao7.ForeColor = Color.Red;
            }
            else if (usuario == "leojulio@hotmail.com" && senha != "leojulio2023")
            {
                lblCondicao7.Text = "Senha está incorreto Sr. Leonardo";
                lblCondicao7.ForeColor = Color.Red;
            }
            else
            {
                lblCondicao7.Text = "Email e Senha estao incorretos Sr. Leonardo";
                lblCondicao7.ForeColor = Color.Red;
            }
            
        }
    }
}
