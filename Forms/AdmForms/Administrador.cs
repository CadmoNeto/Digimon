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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - " + Dados.usuario;
        }

        private void addDigiBt_Click(object sender, EventArgs e)
        {
            AdicionarDigimon adicionarDigimon = new AdicionarDigimon();
            adicionarDigimon.ShowDialog();
        }

        private void addDigiEvoBt_Click(object sender, EventArgs e)
        {
            AdicionarDigiEvolucoes adicionarDigiEvolucoes = new AdicionarDigiEvolucoes();
            adicionarDigiEvolucoes.ShowDialog();
        }
    }
}
