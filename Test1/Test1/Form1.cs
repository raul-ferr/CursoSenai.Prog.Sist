namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double p1 = Convert.ToDouble(textProduto1.Text);
            double p2 = Convert.ToDouble(textProduto2.Text);
            double soma = p1 + p2;
            textTotal.Text = Convert.ToString(soma);

            if (soma >= 50)
            {
                double desc = soma * 0.1;
                textDesconto.Text = Convert.ToString(desc);
                double vFinal = soma - desc;
                textTotalF.Text = Convert.ToString(vFinal);
            }
            if (soma < 50 && soma > 20)
            {
                double desc = soma * 0.05;
                textDesconto.Text = desc.ToString();
                double valoFinal = soma - desc;
                textTotalF.Text = valoFinal.ToString();
            }
            if(soma <= 20)
            {
                double desc = soma * 0.02;
                textDesconto.Text = desc.ToString();
                double valoFinal = soma - desc;
                textTotalF.Text = valoFinal.ToString();
            }



















            }


             

        }
    }
