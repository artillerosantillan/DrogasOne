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
                    Comando.CommandText = @"SELECT Deposito.Descripcion AS IDDeposito, IDProducto, Stock, 
                                                    Minimo, Maximo, DiasReposicion, CantidadMinima 
                                            FROM DepositoProducto INNER JOIN Deposito ON DepositoProducto.IDDeposito = Deposito.IDDeposito 
                                            WHERE IDProducto=@IDProducto";
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

            public int obtenerStockDepositoProducto(string CodigoProducto,int CodigoDeposito )
            {
                using (var connection = GetConnection())
                {
                    int stock=0;
                    connection.Open();
                    using (var Comando = new SqlCommand())
                    {
                        Comando.Connection = connection;
                        Comando.CommandText = @"SELECT *
                                                FROM DepositoProducto
                                                WHERE IDProducto=@IDProducto AND IDDeposito = @IDDeposito";
                        Comando.Parameters.AddWithValue("@IDProducto", CodigoProducto);
                        Comando.Parameters.AddWithValue("@IDDeposito", CodigoDeposito);
                        Comando.CommandType = CommandType.Text;
                        SqlDataReader LeerFilas = Comando.ExecuteReader();
                    if (LeerFilas.Read())
                    {
                        stock = LeerFilas.GetInt32(2);
                        
                    }
                        LeerFilas.Close();
                        connection.Close();
                        return stock;

                    }
                }

            }

        public void ActualizarStockDepositoProducto(string IDProducto,int IDDeposito, int Cantidad)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @"UPDATE DepositoProducto SET Stock = Stock + @Cantidad 
                                            WHERE IDDeposito=@IDDeposito AND IDProducto=@IDProducto";

                    Comando.Parameters.AddWithValue("@IDDeposito", IDDeposito);
                    Comando.Parameters.AddWithValue("@IDProducto", IDProducto);
                    Comando.Parameters.AddWithValue("@Cantidad", Cantidad);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }

            }
        }

        public void insertarDepositoProducto(entDepositoProducto obj)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @"INSERT INTO DepositoProducto 
                                            VALUES(@IDDeposito, @IDProducto, @Stock, @Minimo, @Maximo, @DiasReposicion, @CantidadMinima)";
                    Comando.Parameters.AddWithValue("@IDDeposito", obj.IDDeposito);
                    Comando.Parameters.AddWithValue("@IDProducto", obj.IDProducto);
                    Comando.Parameters.AddWithValue("@Stock", obj.Stock);
                    Comando.Parameters.AddWithValue("@Minimo", obj.Minimo);
                    Comando.Parameters.AddWithValue("@Maximo", obj.Maximo);
                    Comando.Parameters.AddWithValue("@DiasReposicion", obj.DiasReposicion);
                    Comando.Parameters.AddWithValue("@CantidadMinima", obj.CantidadMinima);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
            }
        }
    }
}
