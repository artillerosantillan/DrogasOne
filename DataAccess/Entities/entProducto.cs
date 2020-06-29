using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class entProducto
    {
        public string IDProducto { get; set; }
        public string Descripcion { get; set; }
        public string IDUnidadManejo { get; set; }
        public int IDAlmacen { get; set; }
        public int IDIVA { get; set; }
        public Double Precio { get; set; }
        public string Notas { get; set; }
        public int CantidadKardex { get; set; }
        public int CantidadVigente { get; set; }

    }
}
