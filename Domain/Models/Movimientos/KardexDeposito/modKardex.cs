using DataAccess.Clases.Movimientos;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Movimientos
{
    public class modKardex
    {
        clasKardex ObjetoDato = new clasKardex();
        public entKardex devolver_Ultimo_Kardex(string IDProducto,int IDDeposito)
        {
            return ObjetoDato.devolver_Ultimo_Kardex(IDProducto,IDDeposito);
        }
        public int modInsertarKardex(entKardex obj)
        {
            return ObjetoDato.insertar_Kardex(obj);
        }
        public bool kardex_Tiene_Movimientos_IDProducto(string IDProducto)
        {
            return ObjetoDato.Kardex_Tiene_Movimientos_IDProducto(IDProducto);
        }

    }
}
