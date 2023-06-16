using Tela_de_Login_com_SQL_Server.Modelo;
using Tela_de_Login_com_SQL_Server.Telas;

namespace Tela_de_Login_com_SQL_Server
{
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbUsuario.Text, txbSenha.Text);
            if (controle.Tem)
            {
                MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TelaPrincipal bv = new TelaPrincipal();
                bv.Show(); 
            }
            else
            {
                MessageBox.Show("Login não encontrado, verifique o usuario e a senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}