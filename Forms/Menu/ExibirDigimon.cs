using CadmoTeste.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmoTeste.Forms
{
    public partial class ExibirDigimon : Form
    {
        private List<int> ids = new List<int>();
        private List<string> nomes = new List<string>();

        public ExibirDigimon()
        {
            InitializeComponent();
            this.Load += ExibirDigimon_Load;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void ExibirDigimon_Load(object sender, EventArgs e)
        {
            List<object> retorno = SQLCommands.RetornaDigimonsUsuario();
            ids = (List<int>)retorno[0];
            nomes = (List<string>)retorno[1];
            escolherDigimonCombo.DataSource = nomes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (escolherDigimonCombo.SelectedItem.ToString() == "")
            {
                throw new Exception("Favor escolha um dos Digimon listados!");
            }

            Digimon digimon = new Digimon(ids[escolherDigimonCombo.SelectedIndex]);
            digimon.ShowDialog();
        }
    }
}
