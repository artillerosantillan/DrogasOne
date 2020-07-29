using DataAccess.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class modCodigoBarra
    {
        clasCodigoBarra objeto = new clasCodigoBarra();
        public void modEliminar_Codigo_Barra_Producto(string codigo)
        {
            objeto.eliminar_Codigo_Barra_Producto(codigo);
        }
    }
}
