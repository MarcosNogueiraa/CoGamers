using CoGamers.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace CoGamers.DAL
{
    class DALUsuario
    {
        string con = "Server=localhost;Database=CoGamers;User Id=ProjetoCanil;Password=123;";

        public List<Usuario> GetUsuarioPorJogo(string nomeJogo)
        {

            List<Usuario> retorno = new List<Usuario>();
            try
            { 
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = " SELECT us.Nome, us.Email FROM Usuario us ";
                            Query += " INNER JOIN UsuarioJogos uj ON us.IDUsuario = uj.IDUsuario ";
                            Query += " INNER JOIN Jogos jo ON uj.IDJogo = jo.IDJogo ";
                            Query += " WHERE Descricao = '"+ nomeJogo + "'";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();

                        while (odbcDataReader.Read())
                        {
                            Usuario usuario = new Usuario()
                            {
                                Nome = Convert.ToString(odbcDataReader["Nome"]),
                                Email = Convert.ToString(odbcDataReader["Email"])
                            };
                            retorno.Add(usuario);
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

        public bool LoginUsuario(string email, string senha)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = " select CONVERT(varchar, Senha) SenhaCorreta from usuario ";
                            Query+= "WHERE email = '"+email+"'";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();

                        while (odbcDataReader.Read())
                        {
                            if (senha == Convert.ToString(odbcDataReader["SenhaCorreta"]))
                            {
                                return true;
                            }
                        }
                    }
                    return false;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Usuario GetUsuario(string email)
        {
            Usuario usuario = new Usuario();

            try
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    string Query = " select IDUsuario, Nome, Email from usuario ";
                    Query += "WHERE email = '" + email + "'";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        SqlDataReader odbcDataReader = command.ExecuteReader();

                        while (odbcDataReader.Read())
                        {
                                usuario.IDUsuario = Convert.ToInt32(odbcDataReader["IDUsuario"]);
                                usuario.Nome = Convert.ToString(odbcDataReader["Nome"]);
                                usuario.Email = Convert.ToString(odbcDataReader["Email"]);
                        }
                    }
                    return usuario;

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
