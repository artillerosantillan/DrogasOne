using DataAccess.Clases.Movimientos.Salidas;
using DataAccess.Entities.Movimientos.Salidas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Movimientos.Salidas
{
    public class modPedidoReposicionDetalle
    {
        clasPedidoReposicionDetalle objetoDato = new clasPedidoReposicionDetalle();
        public void insertar_Pedido_Reposicion(entPedidoReposicionDetalle obj)
        {
             objetoDato.insertar_Pedido_Reposicion_Detalle(obj);

        }
    }
}
