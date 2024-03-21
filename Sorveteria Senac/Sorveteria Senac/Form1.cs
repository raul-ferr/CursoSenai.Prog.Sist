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
                MessageBox.Show("Voc� tem que escolher um sabor");
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

                double pre�o = 2.5;
                double pre�oCob;
                double pre�oCal;

                /* ------------------------- */

                if (lblCobertura.Text != "Nenhuma")
                    pre�oCob = 0.5;
                else
                    pre�oCob = 0;

                if (lblCalda.Text != "Nenhuma")
                    pre�oCal = 0.5;
                else
                    pre�oCal = 0;

                /* ------------------------- */

                double pre�oFinal = pre�o + pre�oCob + pre�oCal;

                lblPre�oF.Text = "R$ " + Convert.ToString(pre�oFinal) + "0";

                pre�oSabor.Text = Convert.ToString(pre�o);
                pre�oCalda.Text = Convert.ToString(pre�oCal);
                pre�oCobertura.Text = Convert.ToString(pre�oCobertura);

                /* ------------------------- */

                lblSabor.Text = sabor;

                lblCalda.Visible = true;
                lblCobertura.Visible = true;
                lblPre�oF.Visible = true;
                lblSabor.Visible = true;

                /* ------------------------- */

                

            }

        }
    }
}