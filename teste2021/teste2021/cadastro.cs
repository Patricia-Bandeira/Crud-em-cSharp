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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void lbCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarF_Click(object sender, EventArgs e)
        {
            consultaF funcionario2 = new consultaF();
            funcionario2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultaC cliente = new consultaC();
            cliente.Show();
            this.Hide();
        }

        private void btnCadastrarF_Click(object sender, EventArgs e)
        {
            IncluirDadosMySQLClick();
        }

        public void IncluirDadosMySQLClick()
        {
            MySqlConnection conn = null;
            try
            {
 
                //conexão com banco de dados
                string conexaoBancoDados = @"Server=localhost;Database=software;Uid=root;Pwd='';Connect Timeout=30;";
                //Abre a conexão
                conn = new MySqlConnection(conexaoBancoDados);
                conn.Open();
                string insertBancoDados = "INSERT INTO alunosetec (Nome, Idade, Genero, Email, Contato, Endereco, Curso, Tipo, Inicio, Fim) Values ('" + txtNomeF.Text + "', '" + txtSalF.Text + "', '" + txtCpfF.Text + "', '" + txtEmailF.Text + "', '" + txtTelF.Text + "', '" + txtEndF.Text + "', '" + txtNiverF.Text + "', '" + txtRgF.Text + "', '" + txtIniF.Text + "', '" + txtFimF.Text + "')";
                                       
                //definindo o comando para a conexão a instrução SQL
                MySqlCommand comandoMySQL = new MySqlCommand(insertBancoDados, conn);

                comandoMySQL.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado");
                txtNomeF.Text = "";
                txtSalF.Text = "";
                txtCpfF.Text = "";
                txtEmailF.Text = "";
                txtTelF.Text = "";
                txtEndF.Text = "";
                txtNiverF.Text = "";
                txtRgF.Text = "";
                txtIniF.Text = "";
                txtFimF.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            IncluirDadosMySQLClickCliente();
        }

        public void IncluirDadosMySQLClickCliente()
        {
            MySqlConnection conn = null;
            try
            {

                //conexão com banco de dados
                string conexaoBancoDados = @"Server=localhost;Database=software;Uid=root;Pwd='';Connect Timeout=30;";
                //Abre a conexão
                conn = new MySqlConnection(conexaoBancoDados);
                conn.Open();
                string insertBancoDados = "INSERT INTO cursostec (Nome_do_curso, Duração, Tipo) Values ('" + txtNomeC.Text + "', '" + txtTelC.Text + "', '" + txtRgC.Text + "')";


                //definindo o comando para a conexão a instrução SQL
                MySqlCommand comandoMySQL = new MySqlCommand(insertBancoDados, conn);

                comandoMySQL.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado");
                txtNomeC.Text = "";
                txtTelC.Text = "";
                txtRgC.Text = "";
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

        private void lbFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadastroG geral = new cadastroG();
            geral.Show();
            this.Hide();
        }

        private void btnExcluirD_Click(object sender, EventArgs e)
        {
            excluirD mud = new excluirD();
            mud.Show();
            this.Hide();
        }
    }
}
