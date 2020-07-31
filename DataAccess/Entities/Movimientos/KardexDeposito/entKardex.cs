using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class entKardex
    {
        public int IDKardex { get; set; }
        public int IDDeposito { get; set; }
        public string Documento { get; set; }
        public DateTime Fecha { get; set; }
        public string IDProducto { get; set; }
        public string Entidad { get; set; }
        public decimal Entrada { get; set; }
        public decimal Salida { get; set; }
        public decimal Saldo { get; set; }
        


    }
}
