using Microsoft.VisualBasic;

namespace tabuada2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btlCalcular_Click(object sender, EventArgs e)
        {

            double n1 = Convert.ToDouble(txtNumero1.Text);
            double n2 = Convert.ToDouble(txtNumero2.Text);
            Tabuada t1 = new Tabuada(n1, n2);
            double resultado;

            string operacao = gbOperacoes.Controls.OfType<RadioButton>
                ().Single(RadioButton => RadioButton.Checked).Text;

            if (operacao == "Soma")
                resultado = t1.soma(n1, n2);
            else if (operacao == "Subtração")
                resultado = t1.subtracao(n1, n2);
            else if (operacao == "Multiplicação")
                resultado = t1.multipicacao(n1, n2);
            else if (operacao == "Divisão")
                resultado = t1.divisao(n1, n2);
            else
                resultado = t1.calcular;


            MessageBox.Show(Convert.ToString("Resultado: " + resultado));

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           
        }
    }
}