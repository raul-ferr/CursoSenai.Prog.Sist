namespace contabancaria
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
        Banco c1 = new Banco();

        private void btnOk_Click(object sender, EventArgs e)
        {
          

            double valor = Convert.ToDouble(txtValor.Text);
            string pix = Convert.ToString(txtPix.Text);
            double conta = Convert.ToDouble(txtBancario.Text);
            string ag = Convert.ToString(txtAg.Text);
            string cc = Convert.ToString(txtCc.Text);
            string opcoes = gbOpcoes.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            if (opcoes == "Saldo") {

                if (conta != 0)
                {
                    //c1.setSaldo(conta);
                }

                if (c1.getSaldo() != 0)
                {
                    MessageBox.Show("Seu saldo � de: " + c1.getSaldo());
                }
            }

                

            if(opcoes == "Dep�sito")
            {
                MessageBox.Show("Voc� depositou: " + valor + "\n Seu saldo ficou no valor de: " + c1.setDeposito(valor));
            }

            if(opcoes == "Saque")
            {

                double saque = c1.setSaque(valor);
                MessageBox.Show("Voc� fez um saque de: " +valor + "\n Seu saldo ficou no valor de: " + saque);
            }
            
            if(opcoes == "Transfer�ncia")
            {
                MessageBox.Show("Voc� fez uma tranfer�ncia para " + pix + " com o valor de: " + c1.setTrasnfe(valor));
            }

        }
    }
}