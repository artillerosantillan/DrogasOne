using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class CacheLoginUsuario
    {
        public static int IdUsuario { get; set; }
        public static string LoginUsuario { get; set; }
        public static string Nombres { get; set; }
        public static string Apellidos { get; set; }
        public static string Password { get; set; }
        public static DateTime FechaModificacionClave { get; set; }
        public static int IdRol { get; set; }
        public static string Email { get; set; }
    }
}
