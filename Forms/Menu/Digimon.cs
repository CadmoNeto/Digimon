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
    public partial class Digimon : Form
    {
        private int id { get; set; }

        public Digimon(int id)
        {
            InitializeComponent();
            this.id = id;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Digimon_Load(object sender, EventArgs e)
        {
            List<string> retorno = SQLCommands.RetornaDigimonSelecionado(this.id);

            this.Text = this.Text + " - " + retorno[0];
            nomeDigimon.Text = retorno[0];
            especieDigimon.Text = retorno[1];
            tipoDigimon.Text = retorno[2];
            estagioDigimon.Text = retorno[3];
            nivelDigimon.Text = retorno[4];
        }

        private void levelUpBt_Click(object sender, EventArgs e)
        {
            int nivel = int.Parse(nivelDigimon.Text);
            bool retorno = SQLCommands.SubirNivelDigimon(id, nivel);

            if (retorno)
            {
                nivel = nivel + 1;
                nivelDigimon.Text = nivel.ToString();
                MessageBox.Show($"{nomeDigimon.Text} subiu de nível! Nível atual {nivelDigimon.Text}!", "Level Up!");
            }
            else
            {
                MessageBox.Show($"{nomeDigimon.Text} não conseguiu subir de nível", "Falha...");
            }
        }
    }
}
