using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Movimientos
{
    public class entKardexPorVencimientoYLote
    {
        public int IDlinea { get; set; }
        public int IDDeposito { get; set; }
        public string IDProducto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Lote { get; set; }
        public decimal Entrada { get; set; }
        public decimal Salida { get; set; }
        public decimal Saldo { get; set; }
        public decimal NuevoSaldo { get; set; }
    }
}
