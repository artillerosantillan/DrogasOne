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
        public decimal obtenerStockDepositoProducto(string CodigoProducto,int CodigoDeposito )
            {
                using (var connection = GetConnection())
                {
                    decimal stock = 0;
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
                        stock = LeerFilas.GetDecimal(2);
                        
                    }
                        LeerFilas.Close();
                        connection.Close();
                        return stock;

                    }
                }

            }

        public void aumentar_Stock_Deposito_Producto(string IDProducto,int IDDeposito, decimal Cantidad)
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
        public void restar_Stock_DepositoProducto(string IDProducto, int IDDeposito, decimal Cantidad)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @"UPDATE DepositoProducto SET Stock = Stock - @Cantidad 
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
        public void eliminar_Codigo_Deposito_Producto(string codigo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = "DELETE FROM DepositoProducto WHERE IDProducto = @IDProducto";
                    Comando.Parameters.AddWithValue("@IDProducto", codigo);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
            }
        }
        public decimal devolver_Stock_DepositoProducto(int IDDeposito, String IDProducto)
        {
            Decimal Stock = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @"SELECT ISNULL(Stock,0) AS Stock
                                            FROM DepositoProducto
                                            WHERE IDProducto=@IDProducto AND IDDeposito = @IDDeposito";
                    Comando.Parameters.AddWithValue("@IDDeposito", IDDeposito);
                    Comando.Parameters.AddWithValue("@IDProducto", IDProducto);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    if (reader.Read())
                    {
                        Stock = reader.GetDecimal(0);
                    }
                    else
                        reader.Close();
                    connection.Close();
                    return Stock;
                }

            }
        }
    }
}
