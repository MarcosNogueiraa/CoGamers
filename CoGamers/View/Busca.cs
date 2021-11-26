using CoGamers.BLL;
using CoGamers.DAL;
using CoGamers.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoGamers
{
    public partial class Busca : Form
    {
        Usuario usuario;
        BLLJogo bLLJogo = new BLLJogo();
        BLLUsuario bLLUsuario= new BLLUsuario();
        BLLUsuarioJogos bLLUsuarioJogos= new BLLUsuarioJogos();
        List<Jogo> listaJogos = new List<Jogo>();
        List<Usuario> listaPessoas = new List<Usuario>();
        

        public Busca(string email)
        {
            InitializeComponent();
            AtualizaJogosBusca();
            this.usuario = bLLUsuario.GetUsuario(email);
            AtualizaJogosUsuario();
            rTBBemVindo.Text = "Bem Vindo, " + usuario.Nome + "!";

        }

        private void rTBBemVindo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaListaPessoas();
            lbPessoasQueJogam.Text = "Pessoas que jogam: " + cBFiltroJogos.Text;
            
        }

        private void AtualizaJogosBusca()
        {
            listaJogos = bLLJogo.GetJogos();
            cBFiltroJogos.Items.Clear();
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
            dGVJogosUsuario.Rows.Clear();
            foreach (Jogo jogo in listaJogos)
            {
                dGVJogosUsuario.Rows.Add(jogo.IDJogo,
                                            jogo.Descricao);
            }
        }

        private void PreencheInfoPessoa()
        {
            lbNomePessoaBusca.Text = dGVPessoasPorJogo.CurrentRow.Cells[0].Value.ToString();
            lbEmailPessoaBusca.Text = dGVPessoasPorJogo.CurrentRow.Cells[1].Value.ToString();
            btCopiaEmail.Visible = true;
        }

        private void dGVPessoasPorJogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PreencheInfoPessoa();

        }

        private void btRemoverJogo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Certeza que quer remover o jogo " + dGVJogosUsuario.CurrentRow.Cells[1].Value.ToString() + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bLLUsuarioJogos.RemoveJogo(int.Parse(dGVJogosUsuario.CurrentRow.Cells[0].Value.ToString()), usuario.IDUsuario);
                AtualizaJogosUsuario();
                AtualizaJogosBusca();
                AtualizaListaPessoas();
                MessageBox.Show("Jogo removido", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nenhuma alteração realizada", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btAdicionarJogo_Click(object sender, EventArgs e)
        {
            if(tBAdicionaJogo.Visible)
            {
                if (MessageBox.Show("Confirma a adição do jogo "+ tBAdicionaJogo.Text.Trim() + " aos seus jogos?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (!bLLJogo.GetJogos().Exists(x => x.Descricao.Equals(tBAdicionaJogo.Text.Trim()))){
                        if (MessageBox.Show("Jogo " + tBAdicionaJogo.Text.Trim() + " ainda não cadastrado, deseja cadastrá-lo e adicioná-lo aos seus jogos?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bLLJogo.AdicionaNovoJogo(tBAdicionaJogo.Text.Trim());
                        }
                        else
                        {
                            tBAdicionaJogo.Text = "Insira o nome do jogo";
                            tBAdicionaJogo.Visible = false;
                            MessageBox.Show("Operação cancelada.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    if (listaJogos.Exists(x => x.Descricao.Equals(tBAdicionaJogo.Text.Trim())))
                    {
                        MessageBox.Show("Jogo já está na sua lista, portanto não foi adicionado.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bLLUsuarioJogos.AdicionaJogoAoUsuario(tBAdicionaJogo.Text.Trim(), usuario.IDUsuario);
                        MessageBox.Show("Jogo " + tBAdicionaJogo.Text.Trim() + " adicionado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizaJogosUsuario();
                        AtualizaListaPessoas();
                        AtualizaJogosBusca();
                    }
                }
                else
                {
                    tBAdicionaJogo.Visible = false;
                }
            }
            else
            {
                tBAdicionaJogo.Visible = true;
                tBAdicionaJogo.Text = "Insira o nome do jogo";

            }

        }

        private void cBFiltroJogos_MouseClick(object sender, MouseEventArgs e)
        {
            lbNomePessoaBusca.Text = "";
            lbEmailPessoaBusca.Text = "";
            btCopiaEmail.Visible = false;
        }

        private void btCopiaEmail_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbEmailPessoaBusca.Text);
            MessageBox.Show("Email copiado para a área de transferência.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
