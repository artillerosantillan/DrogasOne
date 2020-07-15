using DataAccess.Clases.Movimientos;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Movimientos
{
    public class modCompra
    {
        clasCompra ObjetoDato = new clasCompra();
        public int modInsertarCompra(entCompra obj)
        {
            return ObjetoDato.insertarCompra(obj);
        }
    }
}   
