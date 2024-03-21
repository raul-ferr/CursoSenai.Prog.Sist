using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bancodedadossenac
{
    public partial class Relatorio : Form
    {
        string id;
        public Relatorio()
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
            toolTip1.SetToolTip(cbMes, "Escolha o mês em que deseja ver seu relatorio.");
            toolTip1.SetToolTip(dtpData, "Escolha a data em que deseja ver seu relatorio.");
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
        private SqlConnection conexao()
        {
            
                SqlConnection sql = new SqlConnection("Data Source=SOB38723L1B1\\SQLEXPRESS; " +
                "Initial Catalog=senac2;Integrated Security=true");

            return sql;
        }

        private DataTable select(string data, SqlConnection sql)
        {
            string dataa = data;
            string command = $"select * from dbo.Aluno where " +
                $"data like  '{dataa}'";
            SqlDataAdapter da = new SqlDataAdapter(command, sql);

            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }
          

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB38723L1B1\\SQLEXPRESS; " +
                "Initial Catalog=senac2;Integrated Security=true");
            

            dgvLista.DataSource = select(dtpData.Text, sql);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB38723L1B1\\SQLEXPRESS; " +
               "Initial Catalog=senac2;Integrated Security=true");
            string dataa = $"%/{cbMes.Text}/%";
            string command = $"select * from dbo.Aluno where " +
                $"data like  '{dataa}'";
            SqlDataAdapter da = new SqlDataAdapter(command, sql);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvLista.DataSource = dt;
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {




            string strconn = ("Data Source=SOB38723L1B1\\SQLEXPRESS; " +
               "Initial Catalog=senac2;Integrated Security=true");

            SqlConnection conn = conexao();

            SqlCommand command = new SqlCommand("update Aluno SET usuario = @usuario, nome_da_mae = @nome_da_mae" +
                "data = @data, nome_do_pai = @nome_do_pai, cpf = @cpf where id = @id", conn);


            string sql = "update Aluno SET usuario = @usuario, nome_da_mae = @nome_da_mae, " +
                "data = @data, nome_do_pai = @nome_do_pai, cpf = @cpf where id = @id";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(id)));
                comando.Parameters.Add(new SqlParameter("@usuario", txtNome.Text));
                comando.Parameters.Add(new SqlParameter("@nome_da_mae", txtMae.Text));
                comando.Parameters.Add(new SqlParameter("@data", DTPNascimento.Text));
                comando.Parameters.Add(new SqlParameter("@nome_do_pai", txtPai.Text));
                comando.Parameters.Add(new SqlParameter("@cpf", txtCpf.Text));

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Alteração feita com sucesso!",
                    "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Não foi possivel fazer as alterações!!", "Cadastro",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            id = dgvLista.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvLista.CurrentRow.Cells[1].Value.ToString();
            txtMae.Text = dgvLista.CurrentRow.Cells[2].Value.ToString();
            DTPNascimento.Text = dgvLista.CurrentRow.Cells[3].Value.ToString();
            txtPai.Text = dgvLista.CurrentRow.Cells[4].Value.ToString();
            txtCpf.Text = dgvLista.CurrentRow.Cells[5].Value.ToString();
        }

        private void DTPNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection sql = conexao();
            {
                SqlCommand command = new SqlCommand("Delete from Aluno where id=@id", sql);
                int id = Convert.ToInt32(dgvLista.CurrentRow.Cells[0].Value);

                try
                {
                    command.Parameters.Add (new SqlParameter("@id", id));


                    sql.Open();
                    command.ExecuteNonQuery();
                    sql.Close();
                    MessageBox.Show("Cadastro deletado com sucesso",
                        "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
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
}


