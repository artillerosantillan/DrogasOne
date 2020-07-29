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
    public class clasKardexPorVencimientoYLote : ConnectionToSql
    {
        public void insertar_Kardex_Por_Vencimiento_Y_Lote(entKardexPorVencimientoYLote obj)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = "INSERT INTO KardexPorVencimientoYLote VALUES(@IDDeposito,@IDProducto,@Lote,@FechaVencimiento,@Entrada,@Salida,@Saldo,@NuevoSaldo)";
                    Comando.Parameters.AddWithValue("@IDDeposito", obj.IDDeposito);
                    Comando.Parameters.AddWithValue("@IDProducto", obj.IDProducto);
                    Comando.Parameters.AddWithValue("@Lote", obj.Lote);
                    Comando.Parameters.AddWithValue("@FechaVencimiento", obj.FechaVencimiento);
                    Comando.Parameters.AddWithValue("@Entrada", obj.Entrada);
                    Comando.Parameters.AddWithValue("@Salida", obj.Salida);
                    Comando.Parameters.AddWithValue("@Saldo", obj.Saldo);
                    Comando.Parameters.AddWithValue("@NuevoSaldo", obj.NuevoSaldo);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
            }
        }
        public void eliminar_Kardex_Por_Vencimiento_Y_Lote_Saldo_Cero()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = "DELETE FROM KardexPorVencimientoYLote WHERE Saldo <= 0";
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
            }
        }


    }
}
