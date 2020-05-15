using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Cache;
using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        //Attributes
        private int idUser;
        private string loginName;
        private string password;
        private string firstName;
        private string lastName;
        private string position;
        private string email;

        //Constructors
        public UserModel(int idUser, string loginName, string password, string firstName, string lastName, string position, string email)
        {
            this.idUser = idUser;
            this.loginName = loginName;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
            this.email = email;
        }


        public UserModel()
        {
        }

        //metodos
        public string editUserProfile()
        {
            try
            {
                userDao.editarPerfil(idUser, loginName, password, firstName, lastName, email);
                LoginUser(loginName, password);
                return "Su perfil ha sido actualizado exitosamente";
            }
            catch (Exception ex)
            {
                return "El nombre se usuario ya esta resgistrado, intente nuevamente "+ ex;
            }
        }

        public bool LoginUser(string user,string pass)
        {
            return userDao.Login(user, pass);
        }


        //recuperar contrasenia
        public string recuperarPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }
        public void AnyMethodos()
        {
            //seguridad y permisos
            if (CacheLoginUsuario.Position == Cargos.Administrator)
            {
                //
            }
            if (CacheLoginUsuario.Position == Cargos.Receptionist || CacheLoginUsuario.Position == Cargos.Accounting)
            {
                //
            }
        }
    }
    
}
