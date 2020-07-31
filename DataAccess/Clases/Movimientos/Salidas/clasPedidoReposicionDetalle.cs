using DataAccess.Entities.Movimientos.Salidas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Clases.Movimientos.Salidas
{
    public class clasPedidoReposicionDetalle: ConnectionToSql
    {
        public void insertar_Pedido_Reposicion_Detalle(entPedidoReposicionDetalle obj)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = @"INSERT INTO PedidoReposicionDetalle 
                                            VALUES(@IDPedidoReposicion,@IDProducto,@Descripcion,@Cantidad,@IDKardex)";
                    Comando.Parameters.AddWithValue("@IDPedidoReposicion", obj.IDPedidoReposicion);
                    Comando.Parameters.AddWithValue("@IDProducto", obj.IDProducto);
                    Comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    Comando.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
                    Comando.Parameters.AddWithValue("@IDKardex", obj.IDKardex); 
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
            }
        }
    }
}
