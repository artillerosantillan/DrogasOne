using DataAccess.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class modIVA
    {
        clasIVA ObjetoDato = new clasIVA();
        public DataTable modListadoIVA()
        {
            return ObjetoDato.ListarIVA ();
        }
    }
}
