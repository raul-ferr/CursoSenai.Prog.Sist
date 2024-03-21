namespace concessionaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btlCadastrar_Click(object sender, EventArgs e)
        {
            Carro c1 = new Carro();
            c1.Marca = txtMarca.Text;
            c1.Modelo = txtModelo.Text;
            c1.Ano = Convert.ToInt32(txtAno.Text);

            lblCadastrar.Text = "O carro da  marca " + c1.Marca + " do modelo " + c1.Modelo + " e do ano " + c1.Ano;
        }
    }
}