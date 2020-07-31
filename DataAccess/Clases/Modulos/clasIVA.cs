using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Clases
{
    public class clasIVA : ConnectionToSql
    {
        public DataTable ListarIVA()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    DataTable Tabla = new DataTable();
                    Comando.Connection = connection;
                    Comando.CommandText = "SELECT * FROM IVA order by Descripcion asc";
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader LeerFilas = Comando.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return Tabla;
                }
            }
        }
        //-----------Devuelve los datos de IVA por IDIVA------
        public entIVA GetIVAByIDIVA(int codigo)
        {
            entIVA data = new entIVA();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @"SELECT IDIVA, 
                                                       Descripcion,
                                                       Tarifa
                                                FROM IVA 
                                                WHERE IDIVA=@IDIVA";
                    Comando.Parameters.AddWithValue("@IDIVA", codigo);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader LeerFilas = Comando.ExecuteReader();
                    if (LeerFilas.HasRows)
                    {
                        while (LeerFilas.Read())
                        {
                            data.IDIVA = LeerFilas.GetInt32(0);
                            data.Descripcion = LeerFilas.GetString(1); 
                            data.Tarifa = LeerFilas.GetDecimal(2); 
                        }
                        return data;
                    }
                    else
                        return null;
                }


            }
        }
    }
}
