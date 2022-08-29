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
    public partial class excluirD : Form
    {
        public excluirD()
        {
            InitializeComponent();
        }

        private void lbConsultaF_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtuaF_Click(object sender, EventArgs e)
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
                string deleteBancoDados = "DELETE FROM alunosetec WHERE Nome = ('" + txtNomeF.Text + "')";

                //definindo o comando para a conexão a instrução SQL
                MySqlCommand comandoMySQL = new MySqlCommand(deleteBancoDados, conn);

                comandoMySQL.ExecuteNonQuery();

                MessageBox.Show("Aluno apagado!");
                txtNomeF.Text = "";
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

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            cadastro geral = new cadastro();
            geral.Show();
            this.Hide();
        }

        private void bntAtuaC_Click(object sender, EventArgs e)
        {
            IncluirDadosMySQLClickCursos();
        }

        public void IncluirDadosMySQLClickCursos()
        {
            MySqlConnection conn = null;
            try
            {

                //conexão com banco de dados
                string conexaoBancoDados = @"Server=localhost;Database=software;Uid=root;Pwd='';Connect Timeout=30;";
                //Abre a conexão
                conn = new MySqlConnection(conexaoBancoDados);
                conn.Open();
                string deleteBancoDados = "DELETE FROM cursostec WHERE Nome_do_curso = ('" + txtNomeC.Text + "')";

                //definindo o comando para a conexão a instrução SQL
                MySqlCommand comandoMySQL = new MySqlCommand(deleteBancoDados, conn);

                comandoMySQL.ExecuteNonQuery();

                MessageBox.Show("Curso apagado!");
                txtNomeC.Text = "";
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

        private void txtNomeC_TextChanged(object sender, EventArgs e)
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
    }
}
