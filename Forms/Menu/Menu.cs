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
            nome.Text = Dados.usuario;
            id.Text = $"{Dados.usuario}#{Dados.idUsuario}";

            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;

            panel1.Controls.Remove(criarDigimonBt);
            this.Controls.Add(criarDigimonBt);
            panel1.Controls.Remove(exibirDigimonBt);
            this.Controls.Add(exibirDigimonBt);

            criarDigimonBt.BringToFront();
            exibirDigimonBt.BringToFront();

            panel2.Controls.Remove(label2);
            this.Controls.Add(label2);
            panel2.Controls.Remove(label3);
            this.Controls.Add(label3);
            panel2.Controls.Remove(nomelabel);
            this.Controls.Add(nomelabel);
            panel2.Controls.Remove(nome);
            this.Controls.Add(nome);
            panel2.Controls.Remove(idLabel);
            this.Controls.Add(idLabel);
            panel2.Controls.Remove(id);
            this.Controls.Add(id);
            panel2.Controls.Remove(admBt);
            this.Controls.Add(admBt);

            label2.BringToFront();
            label3.BringToFront();
            nomelabel.BringToFront();
            nome.BringToFront();
            id.BringToFront();
            idLabel.BringToFront();
            admBt.BringToFront();

            label2.Location = new System.Drawing.Point(panel4.Location.X + label2.Location.X, panel4.Location.Y + label2.Location.Y);
            label3.Location = new System.Drawing.Point(panel4.Location.X + label3.Location.X, panel4.Location.Y + label3.Location.Y);
            nomelabel.Location = new System.Drawing.Point(panel4.Location.X + nomelabel.Location.X, panel4.Location.Y + nomelabel.Location.Y);
            nome.Location = new System.Drawing.Point(panel4.Location.X + nome.Location.X, panel4.Location.Y + nome.Location.Y);
            id.Location = new System.Drawing.Point(panel4.Location.X + id.Location.X, panel4.Location.Y + id.Location.Y);
            idLabel.Location = new System.Drawing.Point(panel4.Location.X + idLabel.Location.X, panel4.Location.Y + idLabel.Location.Y);
            admBt.Location = new System.Drawing.Point(panel4.Location.X + admBt.Location.X, panel4.Location.Y + admBt.Location.Y);

            if (administrador)
            {
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
            CriarDigimon criarDigimon = new CriarDigimon();
            criarDigimon.ShowDialog();
        }

        private void exibirDigimonBt_Click(object sender, EventArgs e)
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

        private void admoBt_Click(object sender, EventArgs e)
        {
            Administrador admForm = new Administrador();
            admForm.Show();
        }
    }
}
