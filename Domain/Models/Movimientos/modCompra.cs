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
            public int ultimo_Id_Compra()
        {
            return ObjetoDato.ultimo_Id_Compra();
        }
        public bool compras_Tiene_Movimientos_IDProveedor(int IDProveedor)
        {
            return ObjetoDato.compras_Tiene_Movimientos_IDProveedor(IDProveedor);
        }
    }
}   
