using CoGamers.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using CoGamers.BLL;

namespace CoGamers.DAL
{
    class DALUsuarioJogos
    {
        string con = "Server=localhost;Database=CoGamers;User Id=ProjetoCanil;Password=123;";

        public void RemoveJogo(int IDJogo, int IDPessoa)
        {
            List<Jogo> retorno = new List<Jogo>();

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = " DELETE FROM UsuarioJogos";
                           Query += " WHERE IDUsuario = " + IDPessoa + " ";
                           Query += " AND   IDJogo = " + IDJogo + " ;";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();

                    }
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

        public void AdicionaJogoAoUsuario(string nomeJogo, int IDPessoa)
        {
            List<Jogo> retorno = new List<Jogo>();

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = "INSERT INTO UsuarioJogos";  //RELACIONA USUARIO COM O JOGO ADICIONADO
                    Query += "      VALUES ((SELECT MAX(IDUsuarioJogo)+1 FROM UsuarioJogos), ";
                    Query += "         '" + IDPessoa + "', ";
                    Query += "        (SELECT IDJogo FROM JOGOS";
                    Query += "          WHERE Descricao = '" + nomeJogo + "'));";    


                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();

                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        
    }
}
