using Microsoft.VisualBasic;

namespace livros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btlEntrar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text;
            if(cpf == "111.222.333-44")
            {
                lblFrase.Text = "Bem-vindo Silvester Estalone";

            }
            else
            {
                lblFrase.Text = "Não te conheço";
            }
        }

        private void btlConcluir_Click(object sender, EventArgs e)
        {
            Emprestimo e1 = new Emprestimo();

            e1.cpf = txtCpf.Text;
            e1.setCategoria(gbCategoria.Controls.OfType<RadioButton>().Single(RadioButton => RadioButton.Checked).Text);
            e1.nomeLivro = txtLivro.Text;
            e1.quantidade = Convert.ToInt32(txtQuantidade.Text);

            MessageBox.Show("Livro emprestado com  Sucesso. Categoria: " + e1.getCategoria() + " Livro: " +e1.nomeLivro + " Quantidade de livros : " +e1.quantidade);
        }
    }
}