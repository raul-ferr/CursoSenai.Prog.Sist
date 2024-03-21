using System.Data;
using System.Data.SqlClient;
namespace usuariosenha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            SqlConnection sql = new SqlConnection("Data Source=SOB38723L1B1\\SQLEXPRESS; " +
                "Initial Catalog=usuariosenha;Integrated Security=true");
            SqlCommand command = new SqlCommand("select [usuario], [senha] from dbo.funcionario" +
                "where usuario=@usuario and senha=@senha" , sql);
            command.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            command.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if(drms.HasRows == true)
                {
                    paginainicialcs p = new paginainicialcs();
                    p.Show();
                }
                else
                {
                    MessageBox.Show("Nome não Encontrado!", "SYSTEMA NEOTECH",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }
    }
}