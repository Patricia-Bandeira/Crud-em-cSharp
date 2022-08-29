using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace teste2021
{
    public partial class cadastroG : Form
    {
        public cadastroG()
        {
            InitializeComponent();
        }

        private void cadastroG_Load(object sender, EventArgs e)
        {
            CarregarDadosMySQLClick();
        }
        public void CarregarDadosMySQLClick()
        {
            MySqlConnection conn = null;
            try
            {

                //conexão com banco de dados
                string conexaoBancoDados = @"Server=localhost;Database=software;Uid=root;Pwd='';Connect Timeout=30; Allow Zero Datetime=True";
                //Abre a conexão
                conn = new MySqlConnection(conexaoBancoDados);
                conn.Open();
                string juliana = "select `matricula`, `Nome`,`Curso`, `Tipo`, `Inicio`, `Fim` FROM `alunosetec`";
                //definindo o comando para a conexão a instrução SQL
                MySqlCommand Paty = new MySqlCommand(juliana, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(Paty);
                //preenchendo o objeto DataTable a partir do DataAdapter
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridViewGeral.DataSource = dt;
            }
            catch (MySqlException msqle)
            {
                MessageBox.Show("Ocorreu um erro, entre em contato com a administração");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            cadastro funcionario = new cadastro();
            funcionario.Show();
            this.Hide();
        }
    }
}
