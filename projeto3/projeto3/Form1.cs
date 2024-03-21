namespace projeto3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btlCalcular_Click(object sender, EventArgs e)
        {
            //calcular An e inserir no txtAn
            //an = a1 * q^(n-1)
            double A1 = Convert.ToDouble(txtA1.Text);
            double N = Convert.ToDouble(txtN.Text);
            double Q = Convert.ToDouble(txtR.Text);
            double cont = 1;

            double termoAtual = A1;
            double An = A1 * Math.Pow(Q , (N-1));
            txtAn.Text = An.ToString();
            //Criar a lista da PA e inserir no lblLista
            lblLista.Text = "";
            while (cont <= N)
            {
                lblLista.Text += termoAtual.ToString();
                if (cont < N)
                    lblLista.Text += ", ";
                    termoAtual *= Q;
                    cont++;
                


            }
        }

        private void btlPg_Click(object sender, EventArgs e)
        {

        }
    }
}