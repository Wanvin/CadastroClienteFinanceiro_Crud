using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CadastroCliente
{
    internal class Conexao
    {

        SqlConnection con = new SqlConnection();

        public Conexao()
        {

            con.ConnectionString = "Server = DESKTOP-K20HCFL\\SQLEXPRESS; Database = CadastroCliente; Integrated Security=SSPI;Persist Security Info=False;";
        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public SqlConnection desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }

    }

}