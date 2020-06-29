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
        //Metodo editar perfil de usuario ---------------------------------------------
        public void editarPerfil(int id, string userName, string password, string name, string lastName, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Users set LoginName=@userName, Password=@pass, FirstName=@name, LastName=@lastName, Email=@mail where UserID=@id";
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }


        public bool Login(string user, string pass) //metod de iniciar sesion
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Usuario WHERE LoginUsuario = @user AND Password = @pass";
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
                            CacheLoginUsuario.IdUsuario = reader.GetInt32(0);
                            CacheLoginUsuario.LoginUsuario = reader.GetString(1);
                            CacheLoginUsuario.Nombres = reader.GetString(2);
                            CacheLoginUsuario.Apellidos = reader.GetString(3);
                            CacheLoginUsuario.Password = reader.GetString(4);
                            CacheLoginUsuario.FechaModificacionClave = reader.GetDateTime(5);
                            CacheLoginUsuario.IdRol = reader.GetInt32(6);
                            CacheLoginUsuario.Email = reader.GetString(7);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        //recuperar contrasenia
        public string recoverPassword(string userRequesting)
        { //obtenemos la conexion
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users WHERE LoginName=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);
                        var mailService = new MailServices.SoporteSistema();
                        mailService.sendMail(
                          subject: "Solicitud de recuperacion de contrasenia",
                          body: "Hola, " + userName + "\nYou Requested to Recover your password.\n" +
                          "your current password is: " + accountPassword +
                          "\nHowever, we ask that you change your password inmediately once you enter the system.",
                          recipientMail: new List<string> { userMail }
                          );
                        return "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                          "Please check your mail: " + userMail +
                          "\nHowever, we ask that you change your password inmediately once you enter the system.";
                    }
                    else
                        return "Lo sentimos, no tiene una cuenta con este nombre 0 correo eltectronico";
                }
            }
        }

        //
        public void AnyMethod()
            {
                //if (CacheLoginUsuario.IdRol == Cargos.Administrator)
                //{
                //    //
                //}
                //if (CacheLoginUsuario.IdRol == Cargos.Receptionist || CacheLoginUsuario.Position ==Cargos.Accounting)
                //{
                //    //
                //}
            }
    }
}
