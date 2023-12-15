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
    public partial class Menu : Form
    {
        private static string usuario = Dados.usuario;
        private static bool administrador = Dados.administrador;
        private static int userId = Dados.idUsuario;

        public Menu()
        {
            InitializeComponent();
            this.Load += Menu_Load;
            this.FormClosed += Menu_FormClosed;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "Menu - " + usuario;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void criarDigimonBt_Click(object sender, EventArgs e)
        {
            CriarDigimon criarDigimon = new CriarDigimon();
            criarDigimon.ShowDialog();
        }

        private void exibirDigimonBt_Click(object sender, EventArgs e)
        {
            ExibirDigimon exibirDigimon = new ExibirDigimon();
            exibirDigimon.ShowDialog();
        }
    }
}
