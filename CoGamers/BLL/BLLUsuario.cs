using CoGamers.DAL;
using CoGamers.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoGamers.BLL
{
    class BLLUsuario
    {
        DALUsuario dALUsuario = new DALUsuario();

        public List<Usuario> GetPessoasPorJogo(string nomeJogo)
        {
            return dALUsuario.GetUsuarioPorJogo(nomeJogo); 
        }

        public bool LoginUsuario(string email, string senha)
        {
            return dALUsuario.LoginUsuario(email, senha);
        }

        public Usuario GetUsuario(string email)
        {
            return dALUsuario.GetUsuario(email);
        }
    }
}
