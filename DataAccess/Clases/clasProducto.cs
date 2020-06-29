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
    public class clasProducto : ConnectionToSql
    {
        public DataTable listadoProducto()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    DataTable Tabla = new DataTable();
                    Comando.Connection = connection;
                    Comando.CommandText = "SELECT IDProducto,Producto.Descripcion,IDUnidadManejo, Almacen.Descripcion AS IDAlmacen,IVA.Descripcion AS IDIVA,Precio,CantidadKardex,CantidadVigente,Notas FROM Producto INNER JOIN Almacen ON Producto.IDAlmacen = Almacen.IDAlmacen INNER JOIN IVA ON Producto.IDIVA = IVA.IDIVA ORDER BY IDProducto asc";
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader LeerFilas = Comando.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return Tabla;
                }
            }

        }

        public DataTable buscarProducto(string buscar)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    DataTable buscarTabla = new DataTable();
                    Comando.Connection = connection;
                    Comando.CommandText = "SELECT IDProducto,Producto.Descripcion,IDUnidadManejo, Almacen.Descripcion AS IDAlmacen,IVA.Descripcion AS IDIVA,Precio,CantidadKardex,CantidadVigente,Notas FROM Producto INNER JOIN Almacen ON Producto.IDAlmacen = Almacen.IDAlmacen INNER JOIN IVA ON Producto.IDIVA = IVA.IDIVA WHERE Producto.Descripcion LIKE '%'+ @buscar + '%' OR  IDProducto LIKE '%'+ @buscar + '%'";
                    Comando.Parameters.AddWithValue("@buscar", buscar);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader LeerFilas = Comando.ExecuteReader();
                    buscarTabla.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return buscarTabla;
                }
            }

        }
        public void insertarProducto(entProducto obj)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = "INSERT INTO Producto values(@IDProducto,@Descripcion,@IDUnidadManejo,@IDAlmacen,@IDIVA,@Precio,@Notas,@CantidadKardex,@CantidadVigente)";
                    Comando.Parameters.AddWithValue("@IDProducto", obj.IDProducto);
                    Comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    Comando.Parameters.AddWithValue("@IDUnidadManejo", obj.IDUnidadManejo);
                    Comando.Parameters.AddWithValue("@IDAlmacen", obj.IDAlmacen);
                    Comando.Parameters.AddWithValue("@IDIVA", obj.IDIVA);
                    Comando.Parameters.AddWithValue("@Precio", obj.Precio);
                    Comando.Parameters.AddWithValue("@Notas", obj.Notas);
                    Comando.Parameters.AddWithValue("@CantidadKardex", obj.CantidadKardex);
                    Comando.Parameters.AddWithValue("@CantidadVigente", obj.CantidadVigente);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
            }
        }
        public void editarProducto(entProducto obj)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = "UPDATE Producto SET IDProducto=@IDProducto, Descripcion=@Descripcion,IDUnidadManejo=@IDUnidadManejo,IDAlmacen=@IDAlmacen,IDIVA=@IDIVA,Precio=@Precio,Notas=@Notas,CantidadKardex=@CantidadKardex,CantidadVigente= @CantidadVigente WHERE IDProducto=@IDProducto";
                    Comando.Parameters.AddWithValue("@IDProducto", obj.IDProducto);
                    Comando.Parameters.AddWithValue("@Descripcion", obj.Descripcion);
                    Comando.Parameters.AddWithValue("@IDUnidadManejo", obj.IDUnidadManejo);
                    Comando.Parameters.AddWithValue("@IDAlmacen", obj.IDAlmacen);
                    Comando.Parameters.AddWithValue("@IDIVA", obj.IDIVA);
                    Comando.Parameters.AddWithValue("@Precio", obj.Precio);
                    Comando.Parameters.AddWithValue("@Notas", obj.Notas);
                    Comando.Parameters.AddWithValue("@CantidadKardex", obj.CantidadKardex);
                    Comando.Parameters.AddWithValue("@CantidadVigente", obj.CantidadVigente);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
            }
        }
        public void eliminarProducto(string codigo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = "DELETE FROM Producto WHERE IDProducto = @IDProducto";
                    Comando.Parameters.AddWithValue("@IDProducto", codigo);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
            }
        }
        public bool existeProducto(string codigo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    DataTable buscarTabla = new DataTable();
                    Comando.Connection = connection;
                    Comando.CommandText = "SELECT 1 FROM Producto WHERE IDProducto=@IDProducto";
                    Comando.Parameters.AddWithValue("@IDProducto", codigo);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader LeerFilas = Comando.ExecuteReader();
                    if (LeerFilas.HasRows)
                    {
                        return true;
                    }
                    return false;
                }
            }


        }
    }
}
