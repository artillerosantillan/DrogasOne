using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Modulos
{
    public class entPedidoReposicion
    {
        public int IDPedidoReposicion { get; set; }
        public DateTime Fecha { get; set;}
        public int IDCentroSalud { get; set; }
        public int IDDeposito { get; set; }
    }
}
