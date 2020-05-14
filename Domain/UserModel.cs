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
