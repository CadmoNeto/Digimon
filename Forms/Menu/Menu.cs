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
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m); ;
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
                default:
                    break;
            }
            base.WndProc(ref m);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = "Menu - " + usuario;

            if (administrador)
            {
                this.Text = this.Text + " - Administrador";
                admBt.Enabled = true;
                admBt.Visible = true;
            }
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void criarDigimonBt_Click(object sender, EventArgs e)
        {
            
        }

        private void exibirDigimonBt_Click(object sender, EventArgs e)
        {
            
        }

        private void admBt_Click(object sender, EventArgs e)
        {
            Administrador admForm = new Administrador();
            admForm.Show();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            CriarDigimon criarDigimon = new CriarDigimon();
            criarDigimon.ShowDialog();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            ExibirDigimon exibirDigimon = new ExibirDigimon();
            exibirDigimon.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
