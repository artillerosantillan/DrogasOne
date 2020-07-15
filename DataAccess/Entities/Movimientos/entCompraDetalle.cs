using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Movimientos
{
    public class entCompraDetalle
    {
        public int IDLinea { get; set; }
        public int IDCompra { get; set; }
        public String IDProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public int Cantidad { get; set; }
        public string Lote { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int IDKardex { get; set; }
        public decimal PorcentajeIVA { get; set; }

    }
}
