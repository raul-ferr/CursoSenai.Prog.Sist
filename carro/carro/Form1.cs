namespace carro
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
            c1.setMarca(txtMarca.Text);
            c1.setAno(Convert.ToInt32(txtAno.Text));
            c1.setCor(txtCor.Text);

            lblResultado.Text = "=========================\n Marca: " + c1.getMarca() + ", "+ " Ano: "+ c1.getAno() + ", "  + " Cor: " + c1.getCor() + "\n=========================";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}