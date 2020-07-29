﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Clases.Movimientos
{
    public class clasCompra: ConnectionToSql
    {
        public int insertarCompra(entCompra obj)
        {
            int IDCompra=0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @"INSERT INTO Compra (Fecha, IDProveedor,	IDDeposito,	NumFactura,NumConvocatoria, 
                                                                Laboratorio, NumPedido, Liquidacion, Procedencia, Nota, CostoTotal)
                                            VALUES(@Fecha, @IDProveedor, @IDDeposito, @NumFactura, @NumConvocatoria, 
                                                   @Laboratorio, @NumPedido, @Liquidacion, @Procedencia, @Nota, @CostoTotal);
                                            SELECT IDCompra FROM Compra 
                                            WHERE(IDCompra = SCOPE_IDENTITY())";
                    Comando.Parameters.AddWithValue("@Fecha", obj.Fecha);
                    Comando.Parameters.AddWithValue("@IDProveedor", obj.IDProveedor);
                    Comando.Parameters.AddWithValue("@IDDeposito", obj.IDDeposito);
                    Comando.Parameters.AddWithValue("@NumFactura", obj.NumFactura);
                    Comando.Parameters.AddWithValue("@NumConvocatoria", obj.NumConvocatoria);
                    Comando.Parameters.AddWithValue("@Laboratorio", obj.Laboratorio);
                    Comando.Parameters.AddWithValue("@NumPedido", obj.NumPedido);
                    Comando.Parameters.AddWithValue("@Liquidacion", obj.Liquidacion);
                    Comando.Parameters.AddWithValue("@Procedencia", obj.Procedencia);
                    Comando.Parameters.AddWithValue("@Nota", obj.Nota);
                    Comando.Parameters.AddWithValue("@CostoTotal", obj.CostoTotal);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    if (reader.Read())
                    {
                        IDCompra = reader.GetInt32(0);
                    }
                    reader.Close();
                    connection.Close();
                    return IDCompra;
                }
                
            }
        }
        public int ultimo_Id_Compra()
        {
            int IDCompra = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @" SELECT ISNULL(MAX(IDCompra),0) AS IdCompra FROM Compra";//si el valor es nulo se asina el cero
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    if (reader.Read())
                    {
                            IDCompra = reader.GetInt32(0);
                    }
                    else
                    reader.Close();
                    connection.Close();
                    return IDCompra;
                }

            }
        }
        public bool compras_Tiene_Movimientos_IDProveedor(int IDProveedor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TOP 1 1 FROM Compra WHERE IDProveedor=@IDProveedor";
                    command.Parameters.AddWithValue("@IDProveedor", IDProveedor);
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
