using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
namespace bibliotecasenac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtTurma.Enabled = true;
            txtQntdTurma.Enabled = true;
            txtQntdIndv.Enabled = false;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            txtQntdIndv.Enabled = true;
            txtQntdTurma.Enabled = false;
            txtTurma.Enabled = false;
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string turma = txtTurma.Text;
            int qntturma = Convert.ToInt32(txtQntdTurma.Text);
            int qntindividual = Convert.ToInt32(txtQntdIndv.Text);
            string data = DTPData.Text;

            string opcao = gbOpcao.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            if (turma != "0")
            {
                if (opcao == "Individual")
                {
                    turma = "";
                    qntindividual = 1;
                    qntturma = 0;
                    data = DTPData.Text;
                    txtQntdIndv.Enabled = true;

                }
                else
                {
                    turma = txtTurma.Text;
                    qntindividual = 0;
                    qntturma = Convert.ToInt32(txtQntdTurma.Text);
                    data = DTPData.Text;

                }

            }

            string strconn = ("Data Source=SOB38723L1B1\\SQLEXPRESS; Initial Catalog=biblioteca;Integrated Security=true");

            SqlConnection conn = new SqlConnection(strconn);

            string sql = "INSERT INTO visitantes (turma, dataa, quantidade_turma, quantidade_individual) Values (@turma, @dataa, @quantidade_turma, @quantidade_individual)";
            conn.Open();
            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);

                if (qntturma != 0)
                {

                    comando.Parameters.Add(new SqlParameter("@turma", turma));

                    comando.Parameters.Add(new SqlParameter("@dataa", data));
                    comando.Parameters.Add(new SqlParameter("@quantidade_turma", qntturma));

                    comando.Parameters.Add(new SqlParameter("@quantidade_individual", qntindividual));

                    comando.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Visitas Atualizadas", "cadastro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                }

                if(qntindividual != 0)
                {
                    comando.Parameters.Add(new SqlParameter("@turma", turma));

                    comando.Parameters.Add(new SqlParameter("@dataa", data));
                    comando.Parameters.Add(new SqlParameter("@quantidade_turma", qntturma));

                    comando.Parameters.Add(new SqlParameter("@quantidade_individual", qntindividual));

                    comando.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Visitas Atualizadas", "cadastro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Visitas não Atualizadas", "cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strconn = ("Data Source=SOB38723L1B1\\SQLEXPRESS; Initial Catalog=biblioteca;Integrated Security=true");

            SqlConnection conn = new SqlConnection(strconn);
            /*int turma = Convert.ToInt32(txtQntdTurma.Text);
            int individual = Convert.ToInt32(txtQntdIndv.Text);
            int soma = turma + individual;
            MessageBox.Show("A quantidade de visitantes desta semana foram de: " + soma);*/

            string sql = "select sum(quantidade_turma) + sum(quantidade_individual) as soma from dbo.visitantes";
            //string sql2 = "select sum(quantidade_individual) from visitantes";

            SqlCommand comando = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader drms = comando.ExecuteReader();
                if (drms.HasRows == true)
                {
                    drms.Read();
                    MessageBox.Show(Convert.ToString(drms["soma"]), "CADASTRO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nome n�o Encontrado!", "SYSTEMA NEOTECH",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //txtUsuario.Text = "";
                    //txtSenha.Text = "";
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Visitas não Atualizadas", "cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB38723L1B1\\SQLEXPRESS; " +
                "Initial Catalog=biblioteca;Integrated Security=true");
            string data = $"%{cbMes.Text}%";

            string command = $"select * from dbo.visitantes where dataa like '{data}'"; //O '$' serve para fazer reconher a variável como variável dentro das '{}'.

            SqlDataAdapter da = new SqlDataAdapter(command, sql);
            DataTable dt = new DataTable();

            da.Fill(dt); //Preencher o dataGrid com os dados da tabela.

            dgvGradeTab.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mes = cbMes.Text;
            string strconn = ("Data Source=SOB38723L1B1\\SQLEXPRESS; Initial Catalog=biblioteca;Integrated Security=true");

            SqlConnection conn = new SqlConnection(strconn);

            string sql = "select sum(quantidade_turma) + sum(quantidade_individual) as somames from visitantes where dataa  like '%/' + @dataa + '/%'";

            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.Add(new SqlParameter("@dataa", mes));
            try
            {
                conn.Open();
                SqlDataReader drms = comando.ExecuteReader();
                if (drms.HasRows == true)
                {

                    drms.Read();
                    txtTotalVis.Text = drms["somames"].ToString();
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Visitas não Atualizadas", "cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
            
            SqlConnection sql2 = new SqlConnection("Data Source=SOB38723L1B1\\SQLEXPRESS; " +
                  "Initial Catalog=biblioteca;Integrated Security=true");
            string data = $"%{cbMes.Text}%";

            string command = $"select * from dbo.visitantes where dataa like '{data}'"; //O '$' serve para fazer reconher a variável como variável dentro das '{}'.

            SqlDataAdapter da = new SqlDataAdapter(command, sql2);
            DataTable dt = new DataTable();

            da.Fill(dt); //Preencher o dataGrid com os dados da tabela.

            dgvGradeTab.DataSource = dt;
        }

        private void dgvGradeTab_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgvGradeTab.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

        }
    }
}