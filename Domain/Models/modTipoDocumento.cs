using DataAccess.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class modTipoDocumento
    {
        clasTipoDocumento ObjetoDato = new clasTipoDocumento();
        public DataTable modListadoTipoDocumento()
        {
            return ObjetoDato.ListarTopoDocumento();
        }
    }
}
