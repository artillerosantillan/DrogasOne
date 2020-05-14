using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache; //referenciamos la capa common
using Common;

namespace DataAccess
{
    public class UserDao: ConnectionToSql
    {
        public bool Login(string user, string pass) //metod de iniciar sesion
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users WHERE LoginName = @user AND Password = @pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //mientras lee las filas, cargamos los valores a la clase statica
                        // los numeros derepsenta las columas de a tabla enpiza de 0
                        while (reader.Read())
                        {
                            CacheLoginUsuario.IdUser = reader.GetInt32(0);
                            CacheLoginUsuario.LoginName = reader.GetString(1);
                            CacheLoginUsuario.Password = reader.GetString(2);
                            CacheLoginUsuario.FirstName = reader.GetString(3);
                            CacheLoginUsuario.LastName = reader.GetString(4);
                            CacheLoginUsuario.Position = reader.GetString(5);
                            CacheLoginUsuario.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        } 
            //
            public void AnyMethod()
            {
                if (CacheLoginUsuario.Position == Cargos.Administrator)
                {
                    //
                }
                if (CacheLoginUsuario.Position == Cargos.Receptionist || CacheLoginUsuario.Position ==Cargos.Accounting)
                {
                    //
                }
            }
    }
}
