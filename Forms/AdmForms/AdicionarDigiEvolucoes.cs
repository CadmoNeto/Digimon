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
    public partial class AdicionarDigiEvolucoes : Form
    {
        private List<string> estagios { get; set; }
        private bool especieSelecionada = false;
        private bool estagioSelecionado = false;

        public AdicionarDigiEvolucoes()
        {
            InitializeComponent();

            especieBox.SelectedIndexChanged -= especieBox_SelectedIndexChanged;
            evoBox.SelectedIndexChanged -= evoBox_SelectedIndexChanged;

            especieBox.DataSource = SQLCommands.RetornaDigimonEspecie();
            evoBox.DataSource = SQLCommands.RetornaDigimonEspecie();

            especieBox.SelectedIndexChanged += especieBox_SelectedIndexChanged;
            evoBox.SelectedIndexChanged += evoBox_SelectedIndexChanged;
        }

        private void especieBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (especieBox.Text != null && especieBox.Text != "" && especieBox.Text != string.Empty)
            {
                if (!this.estagioSelecionado)
                {
                    string especie = especieBox.Text;

                    evoBox.SelectedIndexChanged -= evoBox_SelectedIndexChanged;

                    evoBox.DataSource = SQLCommands.SelecionaEspecieComboEvolucao(especie);

                    evoBox.SelectedIndexChanged += evoBox_SelectedIndexChanged;

                    this.especieSelecionada = true;
                }
            }
            else
            {
                evoBox.SelectedIndexChanged -= evoBox_SelectedIndexChanged;

                evoBox.DataSource = SQLCommands.RetornaDigimonEspecie();

                evoBox.SelectedIndexChanged += evoBox_SelectedIndexChanged;

                this.especieSelecionada = false;
            }
        }

        private void evoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (evoBox.Text != null && evoBox.Text != "" && evoBox.Text != string.Empty)
            {
                if (!this.especieSelecionada)
                {
                    string especie = evoBox.Text;

                    especieBox.SelectedIndexChanged -= especieBox_SelectedIndexChanged;

                    especieBox.DataSource = SQLCommands.SelecionaEspecieComboDeEvolucao(especie);

                    especieBox.SelectedIndexChanged += especieBox_SelectedIndexChanged;

                    this.estagioSelecionado = true;
                }
            }
            else
            {
                especieBox.SelectedIndexChanged -= especieBox_SelectedIndexChanged;

                especieBox.DataSource = SQLCommands.RetornaDigimonEspecie();

                especieBox.SelectedIndexChanged += especieBox_SelectedIndexChanged;

                this.estagioSelecionado = false;
            }
        }

        private void addDigiEvoBt_Click(object sender, EventArgs e)
        {
            string especie = especieBox.Text;
            string evolucao = evoBox.Text;
            int nivel = int.Parse(nivelBox.Text);
            bool insercao = SQLCommands.AdicionarDigiEvolucao(especie, evolucao, nivel);

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
                    evoBox.Text = "";
                    nivelBox.Text = "";

                    especieBox.DataSource = SQLCommands.RetornaDigimonEspecie();
                    evoBox.DataSource = SQLCommands.RetornaDigimonEspecie();
                }
            }
            else
            {
                MessageBox.Show("Adição não realizada, erro na inclusão da espécie!", "Erro!");
            }
        }
    }
}
