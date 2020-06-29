using DataAccess.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
  public  class modDepositoProducto
    {
        clasDepositoProducto ObjetoDato = new clasDepositoProducto();
        public DataTable modListarDepositoProducto(string codigo)
        {
            return ObjetoDato.listadoDepositoProducto(codigo);
        }
    }
}
