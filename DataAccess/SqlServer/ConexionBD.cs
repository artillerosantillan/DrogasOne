using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlServer
{
    class ConexionBD
    {
        static private string CadenaConexion = "Server=.; DataBase=MyCompany; User Id=sa;Password=sa1;integrated security= false";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
