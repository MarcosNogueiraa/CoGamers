using CoGamers.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using CoGamers.BLL;

namespace CoGamers.DAL
{
    class DALJogo
    {
        string con = "Server=localhost;Database=CoGamers;User Id=ProjetoCanil;Password=123;";

        public List<Jogo> GetJogos()
        {
            List<Jogo> retorno = new List<Jogo>();

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "SELECT IDJogo, Descricao FROM Jogos";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();
                        while (odbcDataReader.Read())
                        {
                            Jogo jogo = new Jogo()
                            {
                                IDJogo = Convert.ToInt32(odbcDataReader["IDJogo"]),
                                Descricao = Convert.ToString(odbcDataReader["Descricao"])
                            };
                            retorno.Add(jogo);
                        }
                    }
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Jogo> GetJogosPorUsuario(int idUsuario)
        {
            List<Jogo> retorno = new List<Jogo>();

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "select jo.IDJogo, jo.Descricao  from UsuarioJogos uj ";
                           Query += " INNER JOIN Jogos jo ON uj.IDJogo = jo.IDJogo " ;
                           Query += " WHERE IDUsuario = " + idUsuario + " ;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();
                        while (odbcDataReader.Read())
                        {
                            Jogo jogo = new Jogo()
                            {
                                IDJogo = Convert.ToInt32(odbcDataReader["IDJogo"]),
                                Descricao = Convert.ToString(odbcDataReader["Descricao"])
                            };
                            retorno.Add(jogo);
                        }
                    }
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
