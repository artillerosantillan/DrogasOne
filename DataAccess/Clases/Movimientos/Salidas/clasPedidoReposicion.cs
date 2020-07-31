using DataAccess.Entities.Modulos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Clases.Movimientos.Salidas
{
    public class clasPedidoReposicion : ConnectionToSql
    {
        public int insertar_Pedido_Reposicion(entPedidoReposicion obj)
        {
            int IDPedidoReposicion = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @"INSERT INTO PedidoReposicion (Fecha,IDCentroSalud,IDDeposito)
                                            VALUES(@Fecha, @IDCentroSalud, @IDDeposito);
                                            SELECT IDPedidoReposicion FROM PedidoReposicion 
                                            WHERE(IDPedidoReposicion = SCOPE_IDENTITY())";
                    Comando.Parameters.AddWithValue("@Fecha", obj.Fecha);
                    Comando.Parameters.AddWithValue("@IDCentroSalud", obj.IDCentroSalud);
                    Comando.Parameters.AddWithValue("@IDDeposito", obj.IDDeposito);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    if (reader.Read())
                    {
                        IDPedidoReposicion = reader.GetInt32(0);
                    }
                    reader.Close();
                    connection.Close();
                    return IDPedidoReposicion;
                }

            }
        }
        public int ultimo_Id_Pedido_Reposicion()
        {
            int IDPedidoReposicion = 0;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @" SELECT ISNULL(MAX(IDPedidoReposicion),0) AS IDPedidoReposicion FROM PedidoReposicion";//si el valor es nulo se asina el cero
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    if (reader.Read())
                    {
                        IDPedidoReposicion = reader.GetInt32(0);
                    }
                    else
                        reader.Close();
                    connection.Close();
                    return IDPedidoReposicion;
                }

            }
        }

    }
}
