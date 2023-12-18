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
        }

        private void Digimon_Load(object sender, EventArgs e)
        {
            List<string> retorno = SQLCommands.RetornaDigimonSelecionado(id);

            this.Text = this.Text + " - " + retorno[0];
            nomeDigimon.Text = retorno[0];
            especieDigimon.Text = retorno[1];
            tipoDigimon.Text = retorno[2];
            estagioDigimon.Text = retorno[3];
            nivelDigimon.Text = retorno[4];
        }
    }
}
