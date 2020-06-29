using DataAccess.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class modAlmacen
    {
        clasAlmacen ObjetoDato = new clasAlmacen();
        public DataTable modListadoAlmacen()
        {
            return ObjetoDato.ListarAlmacen();
        }
    }
}
