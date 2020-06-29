using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Clases
{
    public class clasAlmacen : ConnectionToSql
    {
        public DataTable ListarAlmacen()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    DataTable Tabla = new DataTable();
                    Comando.Connection = connection;
                    Comando.CommandText = "Select * From Almacen order by Descripcion asc";
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader LeerFilas = Comando.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return Tabla;
                }
            }
        }
    }
}
