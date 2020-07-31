using DataAccess.Clases.Movimientos.Salidas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Movimientos.Salidas
{
    public class modCentroSalud
    {
        clasCentroSalud ObjetoDato = new clasCentroSalud();
        public DataTable listar_Centros_De_Salud()
        {
            return ObjetoDato.listar_Centros_De_Salud();
        }
        public DataTable buscar_Centro_Centro_Salud(string buscar)
        {
            return ObjetoDato.buscar_Centro_Salud(buscar);
        }
    }
}
