using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class entDepositoProducto
    {
        public int IDDeposito { get; set; }
        public string IDProducto {get; set;}
        public int Stock {get; set; }
        public int Minimo {get; set; }
        public int Maximo {get; set; }
        public int DiasReposicion {get; set;}
        public int CantidadMinima {get; set;}
    }
}
