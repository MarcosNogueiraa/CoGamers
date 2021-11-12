using CoGamers.BLL;
using CoGamers.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoGamers
{
    public partial class Login : Form
    {
        BLLUsuario bLLUsuario = new BLLUsuario();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bLLUsuario.LoginUsuario(tbEmail.Text, tBSenha.Text))
            {
                Usuario usuario = bLLUsuario.GetUsuario(tbEmail.Text);
                MessageBox.Show("Login bem sucedido", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Busca busca = new Busca(tbEmail.Text);
                busca.Show();
            }
            else
            {
                MessageBox.Show("E-mail ou senha inseridos não correspondem, tente novamente ou contate um administrador.", "Erro de Login",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
                
            }
        }

        private bool LoginUsuario()
        {
            return bLLUsuario.LoginUsuario(tbEmail.Text, tBSenha.Text);
        }
    }
}
