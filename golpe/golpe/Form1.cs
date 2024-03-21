namespace golpe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btlMontar_Click(object sender, EventArgs e)
        {
            Ninja n1 = new Ninja();
            n1.Numeros = txtNumeros.Text;
            n1.Atras = txtAtras.Text;
            n1.Validade = Convert.ToInt32(txtValidade.Text);

            Random random = new Random();

            string[] ninja = new string[7]
            {
               "Neji", "Sasuke", "Shikamaru", "Naruto", "Hinata", "Francismar", "Tsunade"
            };

            lblNinja.Text = ninja[random.Next(6)];
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}