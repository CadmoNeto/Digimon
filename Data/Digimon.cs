using CadmoTeste.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadmoTeste
{
    public class Digimon
    {
        private string especie { get; set; }
        private string tipo { get; set; }
        private int nivel { get; set; }
        private string estagio { get; set; }

        public Digimon(string especie)
        {
            if (especie == null || especie == default || especie == string.Empty)
            {
                throw new ArgumentNullException("", "Favor informar alguma espécie de Digimon.");
            }
            else if (SQLCommands.RetornaDigimonEspecie().Contains(especie))
            {
                List<string> retorno = SQLCommands.RetornaDadosEspecie(especie);
                this.especie = especie;
                this.tipo = retorno[0];
                this.nivel = int.Parse(retorno[1]);
                this.estagio = retorno[2];

                MessageBox.Show($"Um {this.especie} foi criado com sucesso!\nSeguem os dados do Digimon:", "Sucesso!");
                MessageBox.Show($"Espécie: {this.especie}\nTipo: {this.tipo}\nNível: {this.nivel}\nEstágio: {this.estagio}", $"Dados de {this.especie}");
            }
            else
            {
                throw new ArgumentException("Favor informar uma espécie de Digimon catalogada.");
            }
        }
    }
}
