namespace Sorveteria_Senac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sabor = comboSabores.Text;

            if(sabor == "")
            {
                MessageBox.Show("Você tem que escolher um sabor");
            }
            else
            {

                /* ------------------------- */

                if (cbChoco.Checked)
                    lblCalda.Text = "Chocolate";

                else if (cbLeite.Checked)
                    lblCalda.Text = "Leite Condensado";

                else if (cbMoran.Checked)
                    lblCalda.Text = "Morango";

                else
                    lblCalda.Text = "Nenhuma";

                /* ------------------------- */

                if (cobChoco.Checked)
                    lblCobertura.Text = "Chocolate";

                else if (cobLeite.Checked)
                    lblCobertura.Text = "Leite Condensado";

                else if (cobMoran.Checked)
                    lblCobertura.Text = "Morango";

                else
                    lblCobertura.Text = "Nenhuma";

                /* ------------------------- */

                double preço = 2.5;
                double preçoCob;
                double preçoCal;

                /* ------------------------- */

                if (lblCobertura.Text != "Nenhuma")
                    preçoCob = 0.5;
                else
                    preçoCob = 0;

                if (lblCalda.Text != "Nenhuma")
                    preçoCal = 0.5;
                else
                    preçoCal = 0;

                /* ------------------------- */

                double preçoFinal = preço + preçoCob + preçoCal;

                lblPreçoF.Text = "R$ " + Convert.ToString(preçoFinal) + "0";

                preçoSabor.Text = Convert.ToString(preço);
                preçoCalda.Text = Convert.ToString(preçoCal);
                preçoCobertura.Text = Convert.ToString(preçoCobertura);

                /* ------------------------- */

                lblSabor.Text = sabor;

                lblCalda.Visible = true;
                lblCobertura.Visible = true;
                lblPreçoF.Visible = true;
                lblSabor.Visible = true;

                /* ------------------------- */

                

            }

        }
    }
}