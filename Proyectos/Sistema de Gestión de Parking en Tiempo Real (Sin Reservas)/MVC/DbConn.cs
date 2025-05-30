using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Carreras
{
    public class DbConn
    {
        
        private static string cadenaServer = "server=localhost;user=sa;password=sa;database=parking1; Integrated Security=False; TrustServerCertificate=True";

        public SqlConnection GetConexion()
        {
            SqlConnection conn = new SqlConnection(cadenaServer);
            return conn;
        }
        
    }
}
