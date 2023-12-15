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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace CadmoTeste
{
    public partial class CriarDigimon : Form
    {
        private bool especieEscolhida = false;
        private bool tipoEscolhido = false;
        private bool estagioEscolhido = false;

        private string tipoAux = "";
        private string estagioAux = "";

        public CriarDigimon()
        {
            InitializeComponent();

            especieCombo.DataSource = SQLCommands.RetornaDigimonEspecie();
            tipoCombo.DataSource = SQLCommands.RetornaDigimonTipo();
            estagioCombo.DataSource = SQLCommands.RetornaDigimonEstagio();
        }

        

        private void especieCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string especieSelecionada = especieCombo.SelectedItem as string;

            if (especieSelecionada != null && especieSelecionada != string.Empty)
            {
                if (!tipoEscolhido && !estagioEscolhido)
                {
                    tipoCombo.SelectedIndexChanged -= tipoCombo_SelectedIndexChanged;
                    estagioCombo.SelectedIndexChanged -= estagioCombo_SelectedIndexChanged;

                    List<string> resultado = SQLCommands.SelecionaComboEspecie(especieSelecionada);

                    tipoCombo.DataSource = new List<string> { resultado[0] };
                    estagioCombo.DataSource = new List<string> { resultado[1] };

                    tipoCombo.SelectedIndexChanged += tipoCombo_SelectedIndexChanged;
                    estagioCombo.SelectedIndexChanged += estagioCombo_SelectedIndexChanged;

                    especieEscolhida = true;
                }
                else if (tipoEscolhido && !estagioEscolhido)
                {
                    string tipoSelecionado = tipoCombo.SelectedItem as string;

                    estagioCombo.SelectedIndexChanged -= estagioCombo_SelectedIndexChanged;

                    List<string> resultado = SQLCommands.SelecionaComboEspecie(especieSelecionada);

                    estagioCombo.DataSource = new List<string> { resultado[1] };

                    estagioCombo.SelectedIndexChanged += estagioCombo_SelectedIndexChanged;
                }
                else if (!tipoEscolhido && estagioEscolhido)
                {
                    string estagioSelecionado = estagioCombo.SelectedItem as string;

                    tipoCombo.SelectedIndexChanged -= tipoCombo_SelectedIndexChanged;

                    List<string> resultado = SQLCommands.SelecionaComboEspecie(especieSelecionada);

                    tipoCombo.DataSource = new List<string> { resultado[0] };

                    tipoCombo.SelectedIndexChanged += tipoCombo_SelectedIndexChanged;
                }
            }
            else
            {
                tipoCombo.SelectedIndexChanged -= tipoCombo_SelectedIndexChanged;
                estagioCombo.SelectedIndexChanged -= estagioCombo_SelectedIndexChanged;

                tipoCombo.DataSource = SQLCommands.RetornaDigimonTipo();
                estagioCombo.DataSource = SQLCommands.RetornaDigimonEstagio();

                tipoCombo.SelectedIndexChanged += tipoCombo_SelectedIndexChanged;
                estagioCombo.SelectedIndexChanged += estagioCombo_SelectedIndexChanged;

                especieEscolhida = false;
            }
        }

        private void tipoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSelecionado = tipoCombo.SelectedItem as string;

            if (tipoSelecionado == tipoAux)
            {
                especieEscolhida = false;
                estagioEscolhido = false;
            }

            if (tipoSelecionado != null && tipoSelecionado != string.Empty)
            {
                if (!especieEscolhida && !estagioEscolhido)
                {
                    especieCombo.SelectedIndexChanged -= especieCombo_SelectedIndexChanged;
                    estagioCombo.SelectedIndexChanged -= estagioCombo_SelectedIndexChanged;

                    List<List<string>> retorno = SQLCommands.SelecionaComboTipo(tipoSelecionado);
                    
                    especieCombo.DataSource = retorno[0];
                    estagioCombo.DataSource = retorno[1];
                    estagioCombo.SelectedItem = retorno[2][0];

                    especieCombo.SelectedIndexChanged += especieCombo_SelectedIndexChanged;
                    estagioCombo.SelectedIndexChanged += estagioCombo_SelectedIndexChanged;

                    tipoEscolhido = true;
                    tipoAux = tipoSelecionado;
                }
                else if(!especieEscolhida && estagioEscolhido)
                {
                    string estagioSelecionado = estagioCombo.SelectedItem as string;

                    especieCombo.SelectedIndexChanged -= especieCombo_SelectedIndexChanged;

                    List<List<string>> retorno = SQLCommands.SelecionaComboTipo(tipoSelecionado);

                    especieCombo.DataSource = retorno[0];

                    especieCombo.SelectedIndexChanged += especieCombo_SelectedIndexChanged;

                    tipoEscolhido = true;
                }
            }
            else
            {
                especieCombo.SelectedIndexChanged -= especieCombo_SelectedIndexChanged;
                estagioCombo.SelectedIndexChanged -= estagioCombo_SelectedIndexChanged;

                especieCombo.DataSource = SQLCommands.RetornaDigimonEspecie();
                estagioCombo.DataSource = SQLCommands.RetornaDigimonEstagio();

                especieCombo.SelectedIndexChanged += especieCombo_SelectedIndexChanged;
                estagioCombo.SelectedIndexChanged += estagioCombo_SelectedIndexChanged;

                tipoEscolhido = false;
            }
        }

        private void estagioCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estagioSelecionado = estagioCombo.SelectedItem as string;

            if (estagioSelecionado == estagioAux)
            {
                especieEscolhida = false;
                tipoEscolhido = false;
            }

            if (estagioSelecionado != null && estagioSelecionado != string.Empty)
            {
                if (!especieEscolhida && !tipoEscolhido)
                {
                    List<List<string>> retorno = SQLCommands.SelecionaComboEstagio(estagioSelecionado);

                    especieCombo.SelectedIndexChanged -= especieCombo_SelectedIndexChanged;
                    tipoCombo.SelectedIndexChanged -= tipoCombo_SelectedIndexChanged;

                    especieCombo.DataSource = retorno[0];
                    tipoCombo.DataSource = retorno[1];
                    tipoCombo.SelectedItem = retorno[2][0];

                    especieCombo.SelectedIndexChanged += especieCombo_SelectedIndexChanged;
                    tipoCombo.SelectedIndexChanged += tipoCombo_SelectedIndexChanged;

                    estagioEscolhido = true;
                    estagioAux = estagioSelecionado;
                }
                else if(!especieEscolhida && tipoEscolhido)
                {
                    List<List<string>> retorno = SQLCommands.SelecionaComboEstagio(estagioSelecionado);

                    especieCombo.SelectedIndexChanged -= especieCombo_SelectedIndexChanged;

                    especieCombo.DataSource = retorno[0];

                    especieCombo.SelectedIndexChanged += especieCombo_SelectedIndexChanged;

                    tipoEscolhido = true;
                }
            }
            else
            {
                especieCombo.SelectedIndexChanged -= especieCombo_SelectedIndexChanged;
                tipoCombo.SelectedIndexChanged -= tipoCombo_SelectedIndexChanged;

                especieCombo.DataSource = SQLCommands.RetornaDigimonEspecie();
                tipoCombo.DataSource = SQLCommands.RetornaDigimonTipo();

                especieCombo.SelectedIndexChanged += especieCombo_SelectedIndexChanged;
                tipoCombo.SelectedIndexChanged += tipoCombo_SelectedIndexChanged;

                tipoEscolhido = false;
            }
        }

        private void createDigimonButton_Click(object sender, EventArgs e)
        {
            try
            {
                Digimon digimon = new Digimon(especieCombo.SelectedItem.ToString());
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Atenção!");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atenção!");
            }
        }
    }
}
