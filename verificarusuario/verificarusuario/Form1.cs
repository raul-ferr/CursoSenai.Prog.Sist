namespace verificarusuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = Convert.ToString(txtUsuario.Text);
            string senha = Convert.ToString(txtSenha.Text);


                if ("cavalo123$" == usuario && "123456" == senha)
                {
                    lblAcesso.Text = "Bem vindo!!";
                lblAcesso.ForeColor = Color.Green;
                MessageBox.Show("Bem vindo");
                }


                if (usuario != "cavalo123$" || senha != "123456")
                {
                Console.WriteLine(txtSenha.Text = "");
                    lblAcesso.Text = "ACESSO NEGADO";
                lblAcesso.ForeColor = Color.Red;
                MessageBox.Show("ACESSO NEGADO");
                }
            
            
            
            
        }
    }
}