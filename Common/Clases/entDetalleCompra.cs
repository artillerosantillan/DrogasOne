using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class entDetalleCompra
    {
        public string IDProducto { get; set; }
        public string Descripcion { get; set; }
        public string IDUnidadManejo { get; set; }
        public decimal Costo { get; set; }
        public decimal Cantidad { get; set; }
        public string Lote { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal PorcentajeIVA { get; set; }
        //  public float PorcentajeDescuento { get; set; }
        public decimal ValorIVA { get { return Costo * (decimal)Cantidad - ValorNeto; } }
        public decimal ValorNeto { get { return Costo * (decimal)Cantidad / (1 + (decimal)PorcentajeIVA); } } //sin IVA y sin descuentos
       
     //public decimal ValorDescuento { get { return ValorBruto * (decimal)PorcentajeDescuento; } }
      //  public decimal ValorNeto { get { return Costo * (decimal)Cantidad ; } }
    }
}
