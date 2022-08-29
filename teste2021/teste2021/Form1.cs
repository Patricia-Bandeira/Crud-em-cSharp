using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste2021
{
    public partial class Form1 : Form
    {
        Thread nt;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Diretor" && textBox2.Text == "etec2022")
            {
                this.Close();
                nt = new Thread(cadastro);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!");
            }
        }

        private void cadastro(object obj)
        {
            Application.Run(new cadastro());
        }

        private void lbSenha_Click(object sender, EventArgs e)
        {

        }

        private void lbLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
