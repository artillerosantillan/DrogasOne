using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Clases.Movimientos
{
    public class clasKardex: ConnectionToSql
    {

        public entKardex devolver_Ultimo_Kardex(string IDProducto, int IDDeposito )
        {
            entKardex data = new entKardex();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @"SELECT IDKardex,IDDeposito,IDProducto,Entidad,Fecha,Documento,Entrada,Salida,Saldo 
                                            FROM Kardex
                                            WHERE IDDeposito = @IDDeposito AND IDProducto = @IDProducto AND IDKardex = 
                                            (SELECT MAX(IDKardex) FROM Kardex WHERE IDDeposito = @IDDeposito AND IDProducto = @IDProducto)";
                    Comando.Parameters.AddWithValue("@IDProducto", IDProducto);
                    Comando.Parameters.AddWithValue("@IDDeposito", IDDeposito);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader LeerFilas = Comando.ExecuteReader();
                    if (LeerFilas.HasRows)
                    {
                        while (LeerFilas.Read())
                        {
                            data.IDKardex = LeerFilas.GetInt32(0);
                            data.IDDeposito = LeerFilas.GetInt32(1); 
                            data.IDProducto = LeerFilas.GetString(2); 
                            data.Entidad = LeerFilas.GetString(3);
                            data.Fecha = LeerFilas.GetDateTime(4);
                            data.Documento = LeerFilas.GetString(5); 
                            data.Entrada = LeerFilas.GetDecimal(6);
                            data.Salida = LeerFilas.GetDecimal(7);
                            data.Saldo = LeerFilas.GetDecimal(8);
                        }
                        return data;
                    }
                    else
                        return null;
                }
            }

        }
        public int insertar_Kardex(entKardex obj)
        {
            int IDKardex = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @"INSERT INTO Kardex (IDDeposito,IDProducto,Entidad,Fecha,Documento,Entrada,Salida,Saldo)
                                            VALUES(@IDDeposito,@IDProducto,@Entidad,@Fecha,@Documento,@Entrada,@Salida,@Saldo);
                                            SELECT IDKardex FROM Kardex 
                                            WHERE(IDKardex = SCOPE_IDENTITY())";
                    
                    Comando.Parameters.AddWithValue("@IDDeposito", obj.IDDeposito);
                    Comando.Parameters.AddWithValue("@IDProducto", obj.IDProducto);
                    Comando.Parameters.AddWithValue("@Entidad", obj.Entidad);
                    Comando.Parameters.AddWithValue("@Fecha", obj.Fecha);
                    Comando.Parameters.AddWithValue("@Documento", obj.Documento);
                    Comando.Parameters.AddWithValue("@Entrada", obj.Entrada);
                    Comando.Parameters.AddWithValue("@Salida", obj.Salida);
                    Comando.Parameters.AddWithValue("@Saldo", obj.Saldo);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    if (reader.Read())
                    {
                        IDKardex = reader.GetInt32(0);
                    }
                    reader.Close();
                    connection.Close();
                    return IDKardex;
                }

            }
        }
        public bool Kardex_Tiene_Movimientos_IDProducto(string IDProducto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TOP 1 1 FROM Kardex WHERE IDProducto=@IDProducto";
                    command.Parameters.AddWithValue("@IDProducto", IDProducto);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                        return true;
                    else
                        return false;
                }
            }
        }

    }
}
