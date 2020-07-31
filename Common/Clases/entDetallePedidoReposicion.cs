using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Clases
{
    public class entDetallePedidoReposicion
    {
        public string IDProducto { get; set; }
        public string Descripcion { get; set; }
        public string IDUnidadManejo { get; set; }
        public decimal Cantidad { get; set; }
        //public decimal Precio { get; set; }
       // public DateTime FechaSalida { get; set; }
        //public decimal PorcentajeIVA { get; set; }
        //public decimal ValorNeto { get { return Precio * (decimal)Cantidad / (1 + (decimal)PorcentajeIVA); } } //sin IVA y sin descuentos


    }
}
