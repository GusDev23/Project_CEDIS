using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DATOS
{
    class ConexionDB
    {
        public SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-LUHL6NJ;" +
                " Initial Catalog=Cedis; Integrated Security=true;");

        public SqlConnection abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection cerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
