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
    public partial class consultaC : Form
    {
        public consultaC()
        {
            InitializeComponent();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            cadastro cliente = new cadastro();
            cliente.Show();
            this.Hide();
        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void consultaC_Load(object sender, EventArgs e)
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
                string camila = "Select * from cursostec";
                //definindo o comando para a conexão a instrução SQL
                MySqlCommand rafael = new MySqlCommand(camila, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(rafael);
                //preenchendo o objeto DataTable a partir do DataAdapter
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridViewCliente.DataSource = dt;
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

    }
}
