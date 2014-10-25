using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
        public static SqlConnection obtenerConexion(){
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "integrated security=SSPI;data source=JUAN;" + "persist security info=False;initial catalog=BDBeca";
            conexion.Open();
            return conexion;
        }
    }
}
