using DataAccess.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class modBarraProducto
    {
        clasCodigoBarra ObjetoDato = new clasCodigoBarra();
        public DataTable modListarBarraProducto(string codigo)
        {
            return ObjetoDato.listadoBarraProducto(codigo);
        }
    }
}
