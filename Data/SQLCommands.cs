﻿using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CadmoTeste.Data
{
    public class SQLCommands
    {
        private static SqlConnection conexao = new SqlConnection("Data Source=(localdb)\\SQLConnection;Initial Catalog=cadmoDigimon;Integrated Security=True");

        #region RETORNOS BÁSICOS
        public static List<string> RetornaDigimonEspecie()
        {
            try
            {
                List<string> especies = new List<string>
                {
                    string.Empty
                };
                conexao.Open();

                SqlCommand cmd = new SqlCommand("SELECT especie FROM dados_base_digimon ORDER BY id", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    especies.Add(reader["especie"].ToString());
                }

                conexao.Close();

                return especies;
            }
            catch (SqlException ex)
            {
                conexao.Close();
                return new List<string>
                {
                    $"Erro: {ex.Message}"
                };
            }
        }

        public static List<string> RetornaDigimonTipo()
        {
            try
            {
                List<string> tipos = new List<string>
                {
                    string.Empty
                };
                conexao.Open();

                SqlCommand cmd = new SqlCommand("SELECT DISTINCT tipo FROM dados_base_digimon", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tipos.Add(reader["tipo"].ToString());
                }

                conexao.Close();

                return tipos.OrderBy(tipo => tipo).ToList();
            }
            catch (SqlException ex)
            {
                conexao.Close();
                return new List<string>
                {
                    $"Erro: {ex.Message}"
                };
            }
        }

        public static List<string> RetornaDigimonEstagio()
        {
            try
            {
                List<string> estagios = new List<string>
                {
                    string.Empty
                };
                conexao.Open();

                SqlCommand cmd = new SqlCommand("SELECT DISTINCT estagio FROM dados_base_digimon", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    estagios.Add(reader["estagio"].ToString());
                }

                conexao.Close();

                return estagios.OrderBy(estagio => Dados.RetornaEstagios().ToList().IndexOf(estagio)).ToList();
            }
            catch (SqlException ex)
            {
                conexao.Close();
                return new List<string>
                {
                    $"Erro: {ex.Message}"
                };
            }
        }
        #endregion

        #region JANELA CRIAR DIGIMON
        public static List<string> RetornaDadosEspecie(string especie)
        {
            try
            {
                List<string> retorno = new List<string>();

                conexao.Open();

                SqlCommand cmd = new SqlCommand($"SELECT tipo, estagio, nivelInicial FROM dados_base_digimon WHERE especie = '{especie}'", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    retorno.Add(reader["tipo"].ToString());
                    retorno.Add(reader["estagio"].ToString());
                    retorno.Add(reader["nivelInicial"].ToString());
                }

                conexao.Close();

                return retorno;
            }
            catch (SqlException ex)
            {
                conexao.Close();
                return new List<string>
                {
                    $"Erro: {ex.Message}"
                };
            }
        }

        public static List<string> SelecionaComboEspecie(string especie)
        {
            try
            {
                List<string> retorno = new List<string>();
                conexao.Open();

                SqlCommand cmd = new SqlCommand($"SELECT tipo, estagio FROM dados_base_digimon WHERE especie = '{especie}'", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    retorno.Add(reader["tipo"].ToString());
                    retorno.Add(reader["estagio"].ToString());
                }

                conexao.Close();
                return retorno;
            }
            catch (SqlException ex)
            {
                conexao.Close();
                return new List<string>
                {
                    $"Erro: {ex.Message}"
                };
            }
        }

        public static List<List<string>> SelecionaComboTipo(string tipo)
        {
            try
            {
                List<List<string>> retorno = new List<List<string>>();
                List<string> especies = new List<string>();
                List<string> estagios = new List<string>();
                List<string> primeiroEstagio = new List<string>();
                conexao.Open();

                SqlCommand cmd = new SqlCommand($"SELECT especie, estagio FROM dados_base_digimon WHERE tipo = '{tipo}'", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                bool primeiro = true;
                while(reader.Read())
                {
                    especies.Add(reader["especie"].ToString());
                    estagios.Add(reader["estagio"].ToString());
                    
                    if(primeiro)
                    {
                        primeiroEstagio.Add(reader["estagio"].ToString());
                        primeiro = false;
                    }
                }

                estagios = estagios.OrderBy(estagio => Dados.RetornaEstagios().ToList().IndexOf(estagio)).ToList();

                conexao.Close();
                retorno.Add(especies.Distinct().ToList());
                retorno.Add(estagios.Distinct().ToList());
                retorno.Add(primeiroEstagio);

                return retorno;
            }
            catch (SqlException ex)
            {
                conexao.Close();
                return new List<List<string>>
                {
                    new List<string>
                    {
                        $"Erro: {ex.Message}"
                    }
                };
            }
        }

        public static List<string> SelecionaTipoEstagio(string tipo, string estagio)
        {
            try
            {
                List<string> retorno = new List<string>();
                conexao.Open();

                SqlCommand sql = new SqlCommand($"SELECT especie FROM dados_base_digimon WHERE tipo = '{tipo}' AND estagio = '{estagio}'", conexao);
                SqlDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    retorno.Add(reader["especie"].ToString());
                }

                conexao.Close();
                return retorno;
            }
            catch (Exception ex)
            {
                conexao.Close();
                return new List<string>
                {
                    $"Erro {ex.Message}"
                };
            }
        }

        public static List<List<string>> SelecionaComboEstagio(string estagio)
        {
            try
            {
                List<List<string>> retorno = new List<List<string>>();
                List<string> especies = new List<string>();
                List<string> tipos = new List<string>();
                List<string> primeiroEstagio = new List<string>();
                conexao.Open();

                SqlCommand cmd = new SqlCommand($"SELECT especie, tipo FROM dados_base_digimon WHERE estagio = '{estagio}'", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                bool primeiro = true;
                while (reader.Read())
                {
                    especies.Add(reader["especie"].ToString());
                    tipos.Add(reader["tipo"].ToString());

                    if (primeiro)
                    {
                        primeiroEstagio.Add(reader["tipo"].ToString());
                        primeiro = false;
                    }
                }

                tipos = tipos.OrderBy(tipo => tipo).ToList();

                conexao.Close();
                retorno.Add(especies.Distinct().ToList());
                retorno.Add(tipos.Distinct().ToList());
                retorno.Add(primeiroEstagio);

                return retorno;
            }
            catch (SqlException ex)
            {
                conexao.Close();
                return new List<List<string>>
                {
                    new List<string>
                    {
                        $"Erro: {ex.Message}"
                    }
                };
            }
        }

        public static int CriarDigimon(List<object> digimon)
        {
            try
            {
                conexao.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO digimons (idUsuario, nome, especie, tipo, estagio, nivel) VALUES (@idUsuario, @nome, @especie, @tipo, @estagio, @nivel); SELECT SCOPE_IDENTITY();", conexao);

                cmd.Parameters.AddWithValue("@idUsuario", Dados.idUsuario);
                cmd.Parameters.AddWithValue("@nome", digimon[0]);
                cmd.Parameters.AddWithValue("@especie", digimon[1]);
                cmd.Parameters.AddWithValue("@tipo", digimon[2]);
                cmd.Parameters.AddWithValue("@estagio", digimon[3]);
                cmd.Parameters.AddWithValue("@nivel", digimon[4]);

                int id = Convert.ToInt32(cmd.ExecuteScalar());

                conexao.Close();
                return id;
            }
            catch (SqlException ex)
            {
                conexao.Close();
                throw ex;
            }
        }
        #endregion

        #region JANELA LOGIN
        public static List<string> Login(string usuario, string senha)
        {
            try
            {
                conexao.Open();

                SqlCommand cmd = new SqlCommand($"SELECT id, salt, hashSenha, administrador FROM usuarios WHERE usuario = '{usuario}'", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    conexao.Close();
                    return new List<string>
                    {
                        "Erro", "Usuário não cadastrado!"
                    };
                }
                else
                {
                    string hash = BCrypt.Net.BCrypt.HashPassword(senha, reader["salt"].ToString());
                    if (reader["hashSenha"].ToString() != hash)
                    {
                        conexao.Close();
                        return new List<string>
                        {
                            "Erro", "Senha incorreta!"
                        };
                    }
                }

                string administrador = reader["administrador"].ToString();

                Dados.usuario = usuario;

                if (administrador == "sim")
                    Dados.administrador = true;
                else
                    Dados.administrador = false;

                Dados.idUsuario = int.Parse(reader["id"].ToString());

                conexao.Close();

                return new List<string> { usuario, administrador };
            }
            catch (SqlException ex)
            {
                conexao.Close();
                return new List<string>
                {
                    $"Erro: {ex.Message}"
                };
            }
        }

        public static List<string> Cadastrar(string usuario, string senha)
        {
            try
            {
                conexao.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM usuarios WHERE usuario = '{usuario}'", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    conexao.Close();
                    reader.Close();
                    return new List<string>
                    {
                        "Erro", "Usuário já cadastrado"
                    };
                }

                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                string hashSenha = BCrypt.Net.BCrypt.HashPassword(senha, salt);

                reader.Close();
                cmd = new SqlCommand("INSERT INTO usuarios (usuario, salt, hashSenha, administrador) VALUES (@usuario, @salt, @hashSenha, @administrador)", conexao);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@salt", salt);
                cmd.Parameters.AddWithValue("@hashSenha", hashSenha);
                cmd.Parameters.AddWithValue("@administrador", "nao");

                int numLines = cmd.ExecuteNonQuery();

                conexao.Close();

                if (numLines > 0)
                {
                    return Login(usuario, senha);
                }
                else
                {
                    return new List<string>
                    {
                        "Erro:", "Houve uma falha no cadastro!"
                    };
                }
            }
            catch (SqlException ex)
            {
                conexao.Close();
                return new List<string>
                {
                    $"Erro: {ex.Message}"
                };
            }
        }
        #endregion

        #region JANELA EXIBIR DIGIMON
        public static List<object> RetornaDigimonsUsuario()
        {
            int idUsuario = Dados.idUsuario;

            try
            {
                List<int> ids = new List<int>();
                List<string> nomes = new List<string>();

                conexao.Open();

                SqlCommand cmd = new SqlCommand($"SELECT id, nome, especie FROM digimons WHERE idUsuario = {idUsuario}", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ids.Add(int.Parse(reader["id"].ToString()));
                    nomes.Add(reader["nome"].ToString() + " - " + reader["especie"].ToString());
                }

                conexao.Close();

                return new List<object> { ids, nomes };
            }
            catch (SqlException ex)
            {
                conexao.Close();
                return new List<object>
                {
                    $"Erro: {ex.Message}"
                };
            }
        }
        #endregion

        #region JANELA DIGIMON
        public static List<string> RetornaDigimonSelecionado(int id)
        {
            try
            {
                List<string> retorno = new List<string>();
                conexao.Open();
                SqlCommand cmd = new SqlCommand($"SELECT nome, especie, tipo, estagio, nivel FROM digimons WHERE id = {id}", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    retorno.Add(reader["nome"].ToString());
                    retorno.Add(reader["especie"].ToString());
                    retorno.Add(reader["tipo"].ToString());
                    retorno.Add(reader["estagio"].ToString());
                    retorno.Add(reader["nivel"].ToString());
                }

                conexao.Close();
                return retorno;
            }
            catch (Exception ex)
            {
                conexao.Close();
                return new List<string>
                {
                    $"Erro: {ex.Message}"
                };
            }
        }

        public static bool SubirNivelDigimon(int id, int nivel)
        {
            try
            {
                nivel = nivel + 1;
                bool retorno = false;

                conexao.Open();
                SqlCommand sql = new SqlCommand($"UPDATE digimons SET nivel = {nivel} WHERE id = {id}", conexao);
                SqlDataReader reader = sql.ExecuteReader();

                if (reader.RecordsAffected > 0)
                {
                    retorno = true;
                }

                conexao.Close();
                return retorno;
            }
            catch (Exception)
            {
                conexao.Close();
                return false;
            }
        }
        #endregion

        #region JANELA ADICIONAR DIGIMON
        public static bool AdicionarDigimon(string especie, string tipo, string estagio, int nivel)
        {
            try
            {
                conexao.Open();

                SqlCommand sql = new SqlCommand("INSERT INTO dados_base_digimon (especie, tipo, estagio, nivelInicial) VALUES (@especie, @tipo, @estagio, @nivelInicial)", conexao);

                sql.Parameters.AddWithValue("@especie", especie);
                sql.Parameters.AddWithValue("@tipo", tipo);
                sql.Parameters.AddWithValue("@estagio", estagio);
                sql.Parameters.AddWithValue("@nivelInicial", nivel);

                int numLines = sql.ExecuteNonQuery();
                conexao.Close();

                if (numLines > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                conexao.Close();
                return false;
            }
        }
        #endregion

        #region JANELA ADICIONAR DIGIEVOLUÇÃO
        public static bool AdicionarDigiEvolucao(string especie, string evolucao, int nivel)
        {
            try
            {
                conexao.Open();

                SqlCommand sql = new SqlCommand("INSERT INTO digiEvolucoes (especie, evolucao, nivelNecessario) VALUES (@especie, @evolucao, @nivelNecessario)", conexao);

                sql.Parameters.AddWithValue("@especie", especie);
                sql.Parameters.AddWithValue("@evolucao", evolucao);
                sql.Parameters.AddWithValue("@nivelNecessario", nivel);

                int numLinhas = sql.ExecuteNonQuery();
                conexao.Close();

                if (numLinhas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                conexao.Close();
                return false;
            }
        }

        public static List<string> SelecionaEspecieComboEvolucao(string especie)
        {
            try
            {
                conexao.Open();
                SqlCommand sql = new SqlCommand($"SELECT estagio FROM dados_base_digimon WHERE especie = '{especie}'", conexao);
                SqlDataReader reader = sql.ExecuteReader();
                string estagio = "";

                while (reader.Read())
                {
                    estagio = reader["estagio"].ToString();
                }

                reader.Close();
                List<string> retorno = new List<string>();

                switch (estagio)
                {
                    case "Novato":
                        sql = new SqlCommand("SELECT especie FROM dados_base_digimon WHERE estagio = 'Campeão' OR estagio = 'Armadura'", conexao);
                        break;
                    case "Campeão":
                        sql = new SqlCommand("SELECT especie FROM dados_base_digimon WHERE estagio = 'Ultimate'");
                        break;
                    case "Ultimate":
                        sql = new SqlCommand("SELECT especie FROM dados_base_digimon WHERE estagio = 'Mega'");
                        break;
                    default:
                        return new List<string>
                        {
                            "Não há possíveis evoluções para esta espécie!"
                        };
                }

                reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    retorno.Add(reader["especie"].ToString());
                }

                conexao.Close();
                return retorno;
            }
            catch (Exception ex)
            {
                conexao.Close();
                return new List<string>
                {
                    "Erro:", ex.Message
                };
            }
        }

        public static List<string> SelecionaEspecieComboDeEvolucao(string especie)
        {
            try
            {
                conexao.Open();
                SqlCommand sql = new SqlCommand($"SELECT estagio FROM dados_base_digimon WHERE especie = '{especie}'", conexao);
                SqlDataReader reader = sql.ExecuteReader();
                string estagio = "";

                while (reader.Read())
                {
                    estagio = reader["estagio"].ToString();
                }

                reader.Close();
                List<string> retorno = new List<string>();

                switch (estagio)
                {
                    case "Armadura":
                        sql = new SqlCommand("SELECT especie FROM dados_base_digimon WHERE estagio = 'Novato'");
                        break;
                    case "Campeão":
                        sql = new SqlCommand("SELECT especie FROM dados_base_digimon WHERE estagio = 'Novato'");
                        break;
                    case "Ultimate":
                        sql = new SqlCommand("SELECT especie FROM dados_base_digimon WHERE estagio = 'Campeão'");
                        break;
                    case "Mega":
                        sql = new SqlCommand("SELECT especie FROM dados_base_digimon WHERE estagio = 'Ultimate'");
                        break;
                    default:
                        return new List<string>
                        {
                            "Não há possíveis de-evoluções para esta espécie!"
                        };
                }

                reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    retorno.Add(reader["especie"].ToString());
                }

                conexao.Close();
                return retorno;
            }
            catch (Exception ex)
            {
                conexao.Close();
                return new List<string>
                {
                    "Erro:", ex.Message
                };
            }
        }
        #endregion
    }
}
