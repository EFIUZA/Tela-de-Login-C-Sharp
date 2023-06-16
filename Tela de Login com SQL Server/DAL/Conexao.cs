//Para utilizar o codigo com o seu banco SQL e altere a linha 16
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela_de_Login_com_SQL_Server.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"Data Source=NB-EFF\;Initial Catalog=LoginCSharp;Integrated Security=True";
        }
        public SqlConnection Conctar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
