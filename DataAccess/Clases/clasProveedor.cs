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
    public class clasProveedor: ConnectionToSql
    {
        public DataTable listadoProveedor()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    DataTable Tabla = new DataTable();
                    Comando.Connection = connection;
                    Comando.CommandText = "SELECT IDProveedor,Nombre,TipoDocumento.Descripcion AS IDTipoDocumento, Documento,NombresContacto,ApellidosContacto,Direccion,Telefono,Email FROM Proveedor INNER JOIN TipoDocumento ON Proveedor.IDTipoDocumento = TipoDocumento.IDTipoDocumento ORDER BY Nombre asc";
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader LeerFilas = Comando.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return Tabla;
                }
            }

        }

        public DataTable buscacProveedor(string buscar)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    DataTable buscarTabla = new DataTable();
                    Comando.Connection = connection;
                    Comando.CommandText = "SELECT IDProveedor,Nombre,TipoDocumento.Descripcion AS IDTipoDocumento, Documento,NombresContacto,ApellidosContacto,Direccion,Telefono,Email FROM Proveedor INNER JOIN TipoDocumento ON Proveedor.IDTipoDocumento = TipoDocumento.IDTipoDocumento WHERE Nombre LIKE '%'+ @buscar + '%' OR  NombresContacto LIKE '%'+ @buscar + '%'";
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
        public void insertarProveedor(entProveedor obj)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = "insert into Proveedor values(@Nombre,@TipoDocumento,@Documento,@NombresContacto,@ApellidosContacto,@Direccion,@Telefono,@Email)";
                    Comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    Comando.Parameters.AddWithValue("@TipoDocumento", obj.IDTipoDocumento);
                    Comando.Parameters.AddWithValue("@Documento", obj.Documento);
                    Comando.Parameters.AddWithValue("@NombresContacto", obj.NombresContacto);
                    Comando.Parameters.AddWithValue("@ApellidosContacto", obj.ApellidosContacto);
                    Comando.Parameters.AddWithValue("@Direccion", obj.Direccion);
                    Comando.Parameters.AddWithValue("@Telefono", obj.Telefono);
                    Comando.Parameters.AddWithValue("@Email", obj.Email);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
            }
        }
        public void editarProveedor(entProveedor obj)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = "update Proveedor set Nombre=@Nombre,IDTipoDocumento=@IDTipoDocumento,Documento=@Documento,NombresContacto=@NombresContacto,ApellidosContacto=@ApellidosContacto,Direccion=@Direccion,Telefono=@Telefono,Email= @Email WHERE IDProveedor=@IDProveedor";
                    Comando.Parameters.AddWithValue("@IDProveedor", obj.IDProveedor);
                    Comando.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    Comando.Parameters.AddWithValue("@IDTipoDocumento", obj.IDTipoDocumento);
                    Comando.Parameters.AddWithValue("@Documento", obj.Documento);
                    Comando.Parameters.AddWithValue("@NombresContacto", obj.NombresContacto);
                    Comando.Parameters.AddWithValue("@ApellidosContacto", obj.ApellidosContacto);
                    Comando.Parameters.AddWithValue("@Direccion", obj.Direccion);
                    Comando.Parameters.AddWithValue("@Telefono", obj.Telefono);
                    Comando.Parameters.AddWithValue("@Email", obj.Email);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
            }
        }
        public void eliminarProveedor(int codigo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    Comando.Connection = connection;
                    Comando.CommandText = "DELETE FROM Proveedor where IDProveedor = @IDProveedor";
                    Comando.Parameters.AddWithValue("@IDProveedor",codigo);
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader reader = Comando.ExecuteReader();
                    reader.Close();
                    connection.Close();
                }
            }
        }
        public bool existeProveedor(string documento)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    DataTable buscarTabla = new DataTable();
                    Comando.Connection = connection;
                    Comando.CommandText = "SELECT 1 FROM Proveedor WHERE Documento=@Documento";
                    Comando.Parameters.AddWithValue("@Documento", documento);
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
