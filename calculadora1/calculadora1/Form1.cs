namespace calculadora1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            lblTexto.Text = "Bem-vindo " + txtUsuario.Text;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}