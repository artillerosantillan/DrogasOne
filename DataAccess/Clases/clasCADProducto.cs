using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Entities;

namespace DataAccess.Clases
{
    public class clasCADProducto : ConnectionToSql
    {
        entProducto tablaProducto = new entProducto();

        //public List<entProducto> GetProductoByIDProducto(string codigo)
        //{
            //entProducto tablaProducto = null;

            //using (var connection = GetConnection())
            //{
            //    connection.Open();
            //    using (var Comando = new SqlCommand())
            //    {
            //        Comando.Connection = connection;
            //        Comando.CommandText = "SELECT IDProducto, Descripcion,IDUnidadManejo, IDAlmacen, Precio,Notas,IDIVA,CantidadKardex,CantidadVigente FROM Producto WHERE IDProducto=@IDProducto";
            //        Comando.Parameters.AddWithValue("@IDProducto", codigo);
            //        Comando.CommandType = CommandType.Text;
            //        SqlDataReader reader = Comando.ExecuteReader();
            //        if (reader.HasRows)
            //        {
            //            //mientras lee las filas, cargamos los valores a la clase statica
            //            // los numeros derepsenta las columas de a tabla enpiza de 0
            //            while (reader.Read())
            //            {
            //                tablaProducto.IDProducto = reader.GetString(0);
            //                tablaProducto.Descripcion = reader.GetString(1);
            //                tablaProducto.IDUnidadManejo = reader.GetString(2);
            //                tablaProducto.IDAlmacen = reader.GetInt32(3);
            //                tablaProducto.IDIVA = reader.GetInt32(4);
            //                tablaProducto.Precio = reader.GetInt32(5);
            //                tablaProducto.Notas = reader.GetString(6);
            //                tablaProducto.CantidadKardex = reader.GetInt32(7);
            //                tablaProducto.CantidadVigente = reader.GetInt32(8);
            //            }
            //            return tablaProducto;
            //        }
            //        else
            //            return tablaProducto;

            //    }
        //    //}
        //}
    }
}
