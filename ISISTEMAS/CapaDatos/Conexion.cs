using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class Conexion
    {
        static string cn = ("Data Source=.;Initial Catalog=SISVENTAS;Integrated Security=True");
        SqlConnection cone = new SqlConnection(cn);

        

        public SqlConnection AbrirConexion()
        {
            if (cone.State == ConnectionState.Closed)
            {
                cone.Open();
            }
            return cone;
        }
        public SqlConnection CerrarConexion()
        {
            if (cone.State == ConnectionState.Open)
            {
                cone.Close();
            }
            return cone;
        }
    }
}
