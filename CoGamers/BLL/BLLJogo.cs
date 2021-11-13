using CoGamers.DAL;
using CoGamers.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoGamers.BLL
{
    class BLLJogo
    {
        DALJogo dALJogo = new DALJogo();

        public List<Jogo> GetJogos()
        {
            return dALJogo.GetJogos(); 
        }

        public List<Jogo> GetJogosPorUsuario(int idUsuario)
        {
            return dALJogo.GetJogosPorUsuario(idUsuario);
        }

        public void AdicionaNovoJogo(string nomeJogo)
        {
            dALJogo.AdicionaNovoJogo(nomeJogo);
        }


    }
}
