using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Clases
{
    public class clasDeposito : ConnectionToSql
    {
        public DataTable ListarDeposito()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    DataTable Tabla = new DataTable();
                    Comando.Connection = connection;
                    Comando.CommandText = "SELECT * FROM Deposito order by Descripcion asc";
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader LeerFilas = Comando.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return Tabla;
                }
            }
        }
        public int devolver_IDDeposito_Depositoo(String Buscar)
        {
            int IDDeposito = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @"SELECT IDDeposito FROM Deposito 
                                            WHERE Descripcion=@Buscar";
                    Comando.Parameters.AddWithValue("@Buscar", Buscar);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    if (reader.Read())
                    {
                        IDDeposito = reader.GetInt32(0);
                    }
                    else
                        reader.Close();
                    connection.Close();
                    return IDDeposito;
                }

            }
        }
    }
}
