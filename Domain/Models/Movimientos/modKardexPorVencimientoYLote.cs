using DataAccess.Clases.Movimientos;
using DataAccess.Entities.Movimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Movimientos
{
    public class modKardexPorVencimientoYLote
    {
        clasKardexPorVencimientoYLote ObjetoDato = new clasKardexPorVencimientoYLote();
        public void insertar_Kardex_Por_Vencimiento_Y_Lote(entKardexPorVencimientoYLote obj)
        {
             ObjetoDato.insertar_Kardex_Por_Vencimiento_Y_Lote(obj);
        }
        public void eliminar_Kardex_Por_Vencimiento_Y_Lote_Saldo_Cero()
        {
             ObjetoDato.eliminar_Kardex_Por_Vencimiento_Y_Lote_Saldo_Cero();
        }
    }
}
