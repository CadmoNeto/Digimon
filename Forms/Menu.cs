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
            this.FormClosed += Menu_FormClosed;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
