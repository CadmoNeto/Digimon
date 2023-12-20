using CadmoTeste.Data;
using CadmoTeste.Forms;
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
        private string nome { get; set; }
        private string especie { get; set; }
        private string tipo { get; set; }
        private int nivel { get; set; }
        private string estagio { get; set; }

        public Digimon(string especie, string nome)
        {
            if (nome == null || nome == default || nome == string.Empty)
            {
                throw new ArgumentNullException("", "Favor informar algum nome para Digimon.");
            }
            else if (especie == null || especie == default || especie == string.Empty)
            {
                throw new ArgumentNullException("", "Favor informar alguma espécie de Digimon.");
            }
            else if (SQLCommands.RetornaDigimonEspecie().Contains(especie))
            {
                List<string> retorno = SQLCommands.RetornaDadosEspecie(especie);
                this.nome = nome;
                this.especie = especie;
                this.tipo = retorno[0];
                this.estagio = retorno[1];
                this.nivel = int.Parse(retorno[2]);

                MessageBox.Show($"Um {this.especie} foi criado com sucesso!\nSeguem os dados do Digimon:", "Sucesso!");
                MessageBox.Show($"Nome: {this.nome}\nEspécie: {this.especie}\nTipo: {this.tipo}\nNível: {this.nivel}\nEstágio: {this.estagio}", $"Dados de {this.nome}");

                CadmoTeste.Forms.Digimon digimon = new CadmoTeste.Forms.Digimon(SQLCommands.CriarDigimon(RetornaDados()));
                digimon.Show();
            }
            else
            {
                throw new ArgumentException("Favor informar uma espécie de Digimon catalogada.");
            }
        }

        public List<object> RetornaDados()
        {
            return new List<object>
            {
                this.nome, this.especie, this.tipo, this.estagio, this.nivel
            };
        }
    }
}
