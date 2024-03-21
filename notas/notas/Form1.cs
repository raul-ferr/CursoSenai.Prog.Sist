namespace notas
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

        private void btlSoma_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNota1.Text);
            double num2 = Convert.ToDouble(txtNota2.Text);
            double num3 = Convert.ToDouble(txtNota3.Text);
            double soma = num1 + num2 + num3;

            double media = soma / 6;
            txtMedia.Text = Convert.ToString(media);
        }
    }
}