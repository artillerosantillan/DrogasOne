using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class entProveedor
    {
        public int IDProveedor { get; set; }
        public string Nombre { get; set; }
        public int IDTipoDocumento { get; set; }
        public string Documento { get; set; }
        public string NombresContacto { get; set; }
        public string ApellidosContacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
