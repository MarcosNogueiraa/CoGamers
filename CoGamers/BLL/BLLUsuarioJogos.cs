using CoGamers.DAL;
using CoGamers.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoGamers.BLL
{
    class BLLUsuarioJogos
    {
        DALUsuarioJogos dALUsuarioJogos = new DALUsuarioJogos();

        public void RemoveJogo(int IDJogo, int IDUsuario)
        {
            dALUsuarioJogos.RemoveJogo(IDJogo, IDUsuario); 
        }

        public void AdicionaJogoAoUsuario(string nomeJogo, int IDUsuario)
        {
            dALUsuarioJogos.AdicionaJogoAoUsuario(nomeJogo, IDUsuario);
        }



    }
}
