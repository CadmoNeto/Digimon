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
    public partial class AdicionarDigimon : Form
    {
        public AdicionarDigimon()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void AdicionarDigimon_Load(object sender, EventArgs e)
        {
            tipoCombo.DataSource = SQLCommands.RetornaDigimonTipo();
            estagioCombo.DataSource = SQLCommands.RetornaDigimonEstagio();
        }

        private void nivelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void createDigimonButton_Click(object sender, EventArgs e)
        {
            string especie = especieBox.Text;
            string tipo = tipoCombo.Text;
            string estagio = estagioCombo.Text;
            int nivel = int.Parse(nivelBox.Text);
            bool insercao = SQLCommands.AdicionarDigimon(especie, tipo, estagio, nivel);

            if (insercao)
            {
                MessageBox.Show("Adição realizada com sucesso!", "Sucesso!");

                DialogResult resultado = MessageBox.Show("Deseja adicionar outro Digimon?", "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    especieBox.Text = "";
                    tipoCombo.Text = "";
                    estagioCombo.Text = "";
                    nivelBox.Text = "";

                    tipoCombo.DataSource = SQLCommands.RetornaDigimonTipo();
                    estagioCombo.DataSource = SQLCommands.RetornaDigimonEstagio();
                }
            }
            else
            {
                MessageBox.Show("Adição não realizada, erro na inclusão da espécie!", "Erro!");
            }
        }
    }
}
