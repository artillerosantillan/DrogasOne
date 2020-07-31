using DataAccess.Clases.Movimientos;
using DataAccess.Entities.Movimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Movimientos
{
    public class modCompraDetalle
    {
        clasCompraDetalle ObjetoDato = new clasCompraDetalle();
        public void modInsertarCompra(entCompraDetalle obj)
        {
             ObjetoDato.insertar_Compra_Detalle(obj);
        }
    }
}
