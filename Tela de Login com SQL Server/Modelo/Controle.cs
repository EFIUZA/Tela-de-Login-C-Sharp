using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela_de_Login_com_SQL_Server.DAL;

namespace Tela_de_Login_com_SQL_Server.Modelo
{
    public class Controle
    {
        public bool Tem;
        public String Mensagem = "";
        public bool acessar(String Usuario, String Senha)
        {
            LoginDalComandos LoginDal = new LoginDalComandos();
            Tem = LoginDal.VerificarLogin(Usuario, Senha);
            if (!LoginDal.Mensagem.Equals(""))
            {
                this.Mensagem = LoginDal.Mensagem;
            }
            return Tem;
        }
        public String cadastro(String Usuario, String Senha, String ConfirmeSenha) 
        {
            LoginDalComandos LoginDal = new LoginDalComandos();
            this.Mensagem = LoginDal.Cadastrar(Usuario, Senha, ConfirmeSenha);
            if (LoginDal.Tem) //mensagem de sucesso
            {
                this.Tem = true;
            }
            return Mensagem;
        }


    }
}
