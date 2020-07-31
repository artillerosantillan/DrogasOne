using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Clases.Movimientos.Salidas
{
    public class clasCentroSalud: ConnectionToSql
    {
        public DataTable listar_Centros_De_Salud()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    DataTable Tabla = new DataTable();
                    Comando.Connection = connection;
                    Comando.CommandText = "SELECT * FROM CentroSalud order by NombreCentroSalud asc";
                    Comando.CommandType = CommandType.Text;
                    SqlDataReader LeerFilas = Comando.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    LeerFilas.Close();
                    connection.Close();
                    return Tabla;
                }
            }
        }
        public DataTable buscar_Centro_Salud(string buscar)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Comando = new SqlCommand())
                {
                    DataTable buscarTabla = new DataTable();
                    Comando.Connection = connection;
                    Comando.CommandText = @"SELECT IDCentroSalud,TipoDocumento.Descripcion AS IDTipoDocumento,Documento,NombreCentroSalud,NombresAdmin,ApellidosAdmin,Direccion,Telefono,Correo,Aniversario 
                                            FROM CentroSalud INNER JOIN TipoDocumento ON CentroSalud.IDTipoDocumento = TipoDocumento.IDTipoDocumento 
                                            WHERE NombreCentroSalud LIKE '%'+ @buscar + '%' OR  NombresAdmin LIKE '%'+ @buscar + '%'";
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

    }
}
