using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CadmoTeste.Data
{
    public static class Dados
    {
        #region DADOS LOGIN
        public static string usuario { get; set; }
        public static bool administrador { get; set; }
        public static int idUsuario { get; set; }
        #endregion

        #region ATRIBUTOS/ DADOS
        private static string[] estagios = new string[]
        {
            "Novato", "Campeão", "Armadura", "Ultimate", "Mega"
        };
        #endregion

        #region RETORNOS SIMPLES
        public static string[] RetornaEstagios()
        {
            return estagios;
        }
        #endregion
    }
}
