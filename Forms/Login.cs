using CadmoTeste.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmoTeste.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBt_Click(object sender, EventArgs e)
        {
            string usuario = usuarioText.Text;
            string senha = senhaText.Text;

            List<string> retorno = SQLCommands.Login(usuario, senha);

            if (retorno[0] == "Erro")
            {
                MessageBox.Show(retorno[1], "Erro");
            }
            else
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso");
                Menu menu = new Menu();
                menu.Show();

                this.Hide();
            }
        }

        private void cadastrarBt_Click(object sender, EventArgs e)
        {
            string usuario = usuarioText.Text;
            string senha = senhaText.Text;

            List<string> retorno = SQLCommands.Cadastrar(usuario, senha);

            if (retorno[0] == "Erro")
            {
                MessageBox.Show(retorno[1], "Erro");
            }
            else
            {
                MessageBox.Show("Usuário cadastrado com sucesso", "Sucesso");
                Menu menu = new Menu();
                menu.Show();

                //this.Close();
            }
        }
    }
}
