namespace juros
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJuros_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btlCalcular_Click(object sender, EventArgs e)
        {
 // double montante = Convert.ToDouble(txtMontante.Text);
            double capital = Convert.ToDouble(txtCapital.Text);
            double taxa = Convert.ToDouble(txtTaxa.Text);
            double tempo = Convert.ToDouble(txtTempo.Text);

            double m = capital * Math.Pow(1 + taxa,tempo);
            double juros = m - capital;
            txtJuros.Text = Convert.ToString(juros);
        }
    }
}