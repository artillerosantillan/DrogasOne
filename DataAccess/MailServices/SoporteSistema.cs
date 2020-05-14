using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailServices
{
    class SoporteSistema:ServidorCorreoMaestro
    {
        public SoporteSistema()
        {
            senderMail = "artillerosantillan@gmail.com";
            password = "artillero4088715";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }

    }
}
