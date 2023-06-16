using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_de_Login_com_SQL_Server.Modelo;

namespace Tela_de_Login_com_SQL_Server.Telas
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaDeLogin cad =
                new TelaDeLogin();
            cad.Show();
        }

        private void btnCriarLogin_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String Mensagem = controle.cadastro(txbUsuario.Text, txbSenha.Text, txbConfirmeASenha.Text);
            if(controle.Tem)
            {
                MessageBox.Show (Mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
            }

        }
    }
}
