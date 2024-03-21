namespace mediasfaculdade
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

        private void txtNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void btlCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);
            double soma = nota1 + nota2 + nota3;
            double media = soma / 3;
            if (media >= 7)
            {
                txtNota.Text = Convert.ToString(media);
                txtSintuacao.Text = "Aprovado";
            }
            if (media < 7 && media >= 4)
            {
                txtNota.Text = Convert.ToString(media);
                txtSintuacao.Text = "Recuperação";
            }
            if (media < 4)
            {
                txtNota.Text = Convert.ToString(media);
                txtSintuacao.Text = "Reprovado";


            }


            {



            }
        }

        private void btlRecupera_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);

            double soma = nota1 + nota2 + nota3;
            double media2 = soma / 3;
            double recup = Convert.ToDouble(txtRecuperacao.Text);
            double result = (recup + media2) / 2;

            if (recup > 7) {
            

                txtRecuperacao.Text = Convert.ToString(result);
                txtSintuacao2.Text = "Aprovado";
            }

                if (recup < 7)
                {
                txtRecuperacao.Text = Convert.ToString(result);
                txtSintuacao2.Text = "Reprovado";
                }
            
        }
    }
}