using DataAccess.Entities.Movimientos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Clases.Movimientos
{
    public class clasCompraDetalle : ConnectionToSql
    {
        public void insertar_Compra_Detalle(entCompraDetalle obj)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = "INSERT INTO CompraDetalle VALUES(@IDCompra,@IDProducto,@Descripcion,@Costo,@Cantidad,@Lote,@FechaVencimiento,@IDKardex,@PorcentajeIVA)";
                    Comando.Parameters.AddWithValue("@IDCompra", obj.IDCompra);
                    Comando.Parameters.AddWithValue("@IDProducto", obj.IDProducto);
                    Comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    Comando.Parameters.AddWithValue("@Costo", obj.Costo);
                    Comando.Parameters.AddWithValue("@Cantidad", obj.Cantidad);
                    Comando.Parameters.AddWithValue("@Lote", obj.Lote);
                    Comando.Parameters.AddWithValue("@FechaVencimiento", obj.FechaVencimiento);
                    Comando.Parameters.AddWithValue("@IDKardex", obj.IDKardex);
                    Comando.Parameters.AddWithValue("@PorcentajeIVA", obj.PorcentajeIVA);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
            }
        }
    }
}
