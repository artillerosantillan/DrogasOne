using DataAccess.Clases.Movimientos.Salidas;
using DataAccess.Entities.Modulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Movimientos.Salidas
{
    public class modPedidoReposicion
    {
        clasPedidoReposicion objetoDato = new clasPedidoReposicion();
        public int ultimo_Id_Pedido_Reposicion()
        {
            return objetoDato.ultimo_Id_Pedido_Reposicion();
        }
        public int insertar_Pedido_Reposicion(entPedidoReposicion obj)
        {
            return objetoDato.insertar_Pedido_Reposicion(obj);
                 
        }
    }
}
