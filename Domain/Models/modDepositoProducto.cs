using DataAccess.Clases;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
  public  class modDepositoProducto
    {
        clasDepositoProducto ObjetoDato = new clasDepositoProducto();
        public DataTable modListarDepositoProducto(string codigo)
        {
            return ObjetoDato.listadoDepositoProducto(codigo);
        }
        public int modObtenerStockDepositoProducto(string CodigoProducto, int CodigoDeposito)
        {
            return ObjetoDato.obtenerStockDepositoProducto(CodigoProducto, CodigoDeposito);
        }
        public void modActualizarStockDepositoProducto(string IDProducto, int IDDeposito, int Cantidad)
        {
            ObjetoDato.ActualizarStockDepositoProducto(IDProducto, IDDeposito, Cantidad);
        }
        public void modInsertarDepositoProducto(entDepositoProducto obj)
        {
            ObjetoDato.insertarDepositoProducto(obj);
        }
    }
}
