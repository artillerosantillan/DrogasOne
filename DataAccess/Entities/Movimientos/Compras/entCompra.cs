using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class entCompra
    {
        public int IDCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int IDProveedor { get; set; }
        public int IDDeposito { get; set; }
        public string NumFactura { get; set; }
        public string NumConvocatoria { get; set; }
        public string Laboratorio { get; set; }
        public string NumPedido { get; set; }
        public string Liquidacion { get; set; }
        public string Procedencia { get; set; }
        public string Nota { get; set; }
        public decimal CostoTotal { get; set; }
    }
}
