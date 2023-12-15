﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadmoTeste.Data
{
    public class SQLCommands
    {
        private static SqlConnection conexao = new SqlConnection("Data Source=(localdb)\\SQLConnection;Initial Catalog=cadmoDigimon;Integrated Security=True");

        public static List<string> RetornaDigimonEspecie()
        {
            try
            {
                List<string> especies = new List<string>
                {
                    string.Empty
                };
                conexao.Open();

                SqlCommand cmd = new SqlCommand("SELECT especie FROM dados_base_digimon", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    especies.Add(reader["especie"].ToString());
                }

                conexao.Close();

                return especies;
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                conexao.Close();
                return new List<string>
                {
                    $"Erro: {ex.Message}"
                };
            }
        }

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
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
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

        public static List<string> Login(string usuario, string senha)
        {
            try
            {
                conexao.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM usuarios WHERE usuario = '{usuario}'", conexao);
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    conexao.Close();
                    return new List<string>
                    {
                        "Erro", "Usuário não cadastrado!"
                    };
                }
                else if (reader["senha"].ToString() != senha)
                {
                    conexao.Close();
                    return new List<string>
                    {
                        "Erro", "Senha incorreta!"
                    };
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
            catch (Exception ex)
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

                reader.Close();
                cmd = new SqlCommand("INSERT INTO usuarios (usuario, senha, administrador) VALUES (@usuario, @senha, @administrador)", conexao);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@administrador", "nao");

                cmd.ExecuteNonQuery();

                conexao.Close();

                return Login(usuario, senha);
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
    }
}