using DataAccess.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class modDeposito
    {
            clasDeposito ObjetoDato = new clasDeposito();
            public DataTable modListaDeposito()
            {
                return ObjetoDato.ListarDeposito();
            }
        
    }
}
