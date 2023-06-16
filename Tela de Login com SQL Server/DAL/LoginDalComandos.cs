using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_de_Login_com_SQL_Server.DAL
{
    internal class LoginDalComandos
    {
        public bool Tem = false;
        public String Mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool VerificarLogin (String Usuario, String Senha) 
        {
            // comandos SQL para verificar dados no banco
            cmd.CommandText = "select * from logins where usuario = @Usuario and Senha = @Senha";
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            try 
            {
                cmd.Connection = con.Conctar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Tem = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.Mensagem = "Erro com Banco de Dados";
            }
            return Tem;
        }
        public String Cadastrar (String Usuario, String Senha, String ConfirmeSenha)
        {
            Tem = false;
            // comandos para inserir no banco de dados
            if (Senha.Equals(ConfirmeSenha))
            {
                cmd.CommandText = "insert into logins values (@e,@s);";
                cmd.Parameters.AddWithValue("@e", Usuario);
                cmd.Parameters.AddWithValue("@s", Senha);
                try
                {
                    cmd.Connection = con.Conctar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.Mensagem = "Cadastrado com sucesso!";
                    Tem = true;
                }
                catch (SqlException)
                {
                    this.Mensagem = "Erro com banco de dados";
                }
            }
            else
            {
                this.Mensagem = "Senhas não correspondem";
            }
            return Mensagem;
        }
    }
}
