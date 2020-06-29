using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Clases
{
   public class clasDepositoProducto: ConnectionToSql
    {
        public DataTable listadoDepositoProducto(string codigo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    DataTable Tabla = new DataTable();
                    Comando.Connection = connection;
                    Comando.CommandText = "SELECT Deposito.Descripcion AS IDDeposito, IDProducto, Stock, Minimo, Maximo, DiasReposicion, CantidadMinima FROM DepositoProducto INNER JOIN Deposito ON DepositoProducto.IDDeposito= Deposito.IDDeposito WHERE IDProducto=@IDProducto";
                    Comando.Parameters.AddWithValue("@IDProducto", codigo);
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
