using System.Data.SqlClient;
namespace bancodedadossenac

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarToolTip();
        }
        private void ConfigurarToolTip()
        {

            toolTip1.AutoPopDelay = 10000;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Dica";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;

            toolTip1.SetToolTip(txtNome, "Informe o nome do aluno.");
            toolTip1.SetToolTip(txtMae, "Informe o nome da mãe do aluno.");
            toolTip1.SetToolTip(txtPai, "Informe o nome do pai do aluno.");
            toolTip1.SetToolTip(txtCpf, "Informe o cpf do aluno.");
            toolTip1.SetToolTip(DTPNascimento, "Informe o data de nascimento do aluno.");
        }


        private bool verificarCampos()
        {
            bool preenchido = true;
            errorProvider1.Clear();
            if (txtNome.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtNome, "Campo obrigatório!");
                preenchido = false;
            }

            if (txtMae.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtMae, "Campo obrigatório!");
                preenchido = false;
            }

            if (txtCpf.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtCpf, "Campo obrigatório!");
                preenchido = false;
            }
            if (preenchido)
                return true;
            else
                return false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                bool preenchimento = true;
                errorProvider1.Clear();
                errorProvider2.Clear();
                errorProvider3.Clear();

                string strconn = ("Data Source=SOB38723L1B1\\SQLEXPRESS; " +
                    "Initial Catalog=senac2;Integrated Security=true");

                SqlConnection conn = new SqlConnection(strconn);

                string sql = "INSERT INTO Aluno (usuario, nome_da_mae, data, nome_do_pai, cpf) " +
                    "Values (@usuario, @nome_da_mae, @data, @nome_do_pai, @cpf)";

                try
                {
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.Parameters.Add(new SqlParameter("@usuario", txtNome.Text));
                    comando.Parameters.Add(new SqlParameter("@nome_da_mae", txtMae.Text));
                    comando.Parameters.Add(new SqlParameter("@data", DTPNascimento.Text));
                    comando.Parameters.Add(new SqlParameter("@nome_do_pai", txtPai.Text));
                    comando.Parameters.Add(new SqlParameter("@cpf", txtCpf.Text));

                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Aluno cadastrado com sucesso!",
                        "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Não foi possivel cadastrar.", "Cadastro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio R = new Relatorio();
            R.Show();
        }
    }
}