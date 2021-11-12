using CoGamers.BLL;
using CoGamers.DAL;
using CoGamers.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoGamers
{
    public partial class Busca : Form
    {
        Usuario usuario;
        BLLJogo bLLJogo = new BLLJogo();
        BLLUsuario bLLUsuario= new BLLUsuario();
        List<Jogo> listaJogos = new List<Jogo>();
        List<Usuario> listaPessoas = new List<Usuario>();
        

        public Busca(string email)
        {
            InitializeComponent();
            CarregaJogosBusca();
            this.usuario = bLLUsuario.GetUsuario(email);
            AtualizaJogosUsuario();

        }

        private void rTBBemVindo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaListaPessoas();

        }

        private void CarregaJogosBusca()
        {
            listaJogos = bLLJogo.GetJogos();
            foreach (Jogo jogo in listaJogos)
            {
                cBFiltroJogos.Items.Add(jogo.Descricao);
            }
        }

        private void AtualizaListaPessoas()
        {
            listaPessoas = bLLUsuario.GetPessoasPorJogo(cBFiltroJogos.Text);
            dGVPessoasPorJogo.Rows.Clear();
            foreach (Usuario user in listaPessoas)
            {
                dGVPessoasPorJogo.Rows.Add(user.Nome,
                                            user.Email);
            }
        }

        private void AtualizaJogosUsuario()
        {
            listaJogos = bLLJogo.GetJogosPorUsuario(usuario.IDUsuario);
            foreach (Jogo jogo in listaJogos)
            {
                dGVJogosUsuario.Rows.Add(jogo.IDJogo,
                                            jogo.Descricao);
            }
        }

        private void dGVPessoasPorJogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void PreencheInfoPessoa()
        {
            lbNomePessoaBusca.Text = dGVPessoasPorJogo.CurrentRow.Cells[0].Value.ToString();
            lbEmailPessoaBusca.Text = dGVPessoasPorJogo.CurrentRow.Cells[1].Value.ToString();
        }

        private void dGVPessoasPorJogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PreencheInfoPessoa();

        }
    }
}
