using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Movimientos.Salidas
{
    public class entPedidoReposicionDetalle
    {
        public int IDLinea { get; set; }
        public int IDPedidoReposicion { get; set; }
        public string IDProducto { get; set; }
        public string Descripcion { get; set; }
        //public decimal Precio { get; set; }
        public decimal Cantidad { get; set; }
        public int IDKardex { get; set; }
        
    }
}
